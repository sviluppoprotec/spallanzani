using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Text;
using System.IO;
using System.Web.Mail;
using System.Configuration;
using ICSharpCode;
using ICSharpCode.SharpZipLib;
using ICSharpCode.SharpZipLib.Zip;
using S_Controls.Collections;
using ApplicationDataLayer.DBType;
using MyCollection;
using ExcelPMP;
using PMPExcel;
using System.Threading;
   
namespace TheSite
{
	/// <summary>
	/// Descrizione di riepilogo per DocPmP.
	/// </summary>
	public class DocPmP : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Button BtInvia;
		protected System.Web.UI.WebControls.Label lblMessage;
		protected System.Web.UI.WebControls.DropDownList DrTipoDocumenti;
		protected System.Web.UI.WebControls.TextBox TxtAnnotazioni;
		protected System.Web.UI.WebControls.Label lblMese;
		protected System.Web.UI.WebControls.Label lblAnno;
		protected System.Web.UI.WebControls.DropDownList DropMese;
		protected System.Web.UI.WebControls.DropDownList DropAnno;
		protected System.Web.UI.HtmlControls.HtmlInputFile UploadFile;
		protected System.Web.UI.WebControls.DropDownList DrEdifici;
		protected WebControls.PageTitle	PageTitle1;
		int Result;
		string prj="";
		public string HelpLink="";
		protected System.Web.UI.WebControls.CheckBox CKMail;
		TheSite.Classi.ManProgrammata.InvioDocPmP  _inviodoc = new TheSite.Classi.ManProgrammata.InvioDocPmP();

		private void Page_Load(object sender, System.EventArgs e)
		{
			Classi.SiteModule _SiteModule = (Classi.SiteModule) HttpContext.Current.Items["SiteModule"];
			HelpLink = _SiteModule.HelpLink;
			this.PageTitle1.Title = _SiteModule.ModuleTitle;
			
			if(Request.QueryString["VarApp"]!=null)
				this.prj =	Request.QueryString["VarApp"]; 
			// Inserire qui il codice utente necessario per inizializzare la pagina.
			if (!IsPostBack)
				LoadCombo();
		}
		
		private void LoadCombo()
		{
			TheSite.Classi.ManProgrammata.InvioDocPmP  _inviodoc = new TheSite.Classi.ManProgrammata.InvioDocPmP();
			DataSet Ds=_inviodoc.GetEdifici(Context.User.Identity.Name);
			DrEdifici.DataSource=Ds.Tables[0];
			DrEdifici.DataTextField ="Denominazione";
			DrEdifici.DataValueField="id"; 
			DrEdifici.DataBind();

			for(int i=2008;i<=2020;i++)
				DropAnno.Items.Add(new ListItem(i.ToString(),i.ToString()));  
			DropAnno.SelectedValue=System.DateTime.Today.Year.ToString();

			DrTipoDocumenti.Attributes.Add("onclick","setvis()");
		}

		#region Codice generato da Progettazione Web Form
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: questa chiamata � richiesta da Progettazione Web Form ASP.NET.
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// Metodo necessario per il supporto della finestra di progettazione. Non modificare
		/// il contenuto del metodo con l'editor di codice.
		/// </summary>
		private void InitializeComponent()
		{    
			this.BtInvia.Click += new System.EventHandler(this.BtInvia_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion
		private int DeleteFile(int idFile)
		{
			S_ControlsCollection _SCollection = new S_ControlsCollection();		

			S_Controls.Collections.S_Object s_p_ID = new S_Object();
			s_p_ID.ParameterName = "p_Id";
			s_p_ID.DbType = CustomDBType.Integer;
			s_p_ID.Direction = ParameterDirection.Input;
			s_p_ID.Index =_SCollection.Count;
			s_p_ID.Value=idFile;			
			_SCollection.Add(s_p_ID);
           
			int Result=_inviodoc.DeleteFile(_SCollection);
			return Result;
		}
		private int SalvaInvio()
		{
			S_ControlsCollection _SCollection = new S_ControlsCollection();		

			S_Controls.Collections.S_Object s_p_ID = new S_Object();
			s_p_ID.ParameterName = "p_Id";
			s_p_ID.DbType = CustomDBType.Integer;
			s_p_ID.Direction = ParameterDirection.Input;
			s_p_ID.Index =_SCollection.Count;
			s_p_ID.Value=DBNull.Value;			
			_SCollection.Add(s_p_ID);

			S_Controls.Collections.S_Object s_p_BL_ID = new S_Object();
			s_p_BL_ID.ParameterName = "p_bl_Id";
			s_p_BL_ID.DbType = CustomDBType.Integer;
			s_p_BL_ID.Direction = ParameterDirection.Input;
			s_p_BL_ID.Index =_SCollection.Count;
			s_p_BL_ID.Value=Convert.ToInt32(DrEdifici.SelectedValue);			
			_SCollection.Add(s_p_BL_ID);

			S_Controls.Collections.S_Object s_p_NOME_DOC = new S_Object();
			s_p_NOME_DOC.ParameterName = "p_NOME_DOC";
			s_p_NOME_DOC.DbType = CustomDBType.VarChar;
			s_p_NOME_DOC.Direction = ParameterDirection.Input;
			s_p_NOME_DOC.Size=225;
			s_p_NOME_DOC.Index = _SCollection.Count;
			s_p_NOME_DOC.Value=System.IO.Path.GetFileName(UploadFile.PostedFile.FileName);			
			_SCollection.Add(s_p_NOME_DOC);
             
			S_Controls.Collections.S_Object s_p_ID_STATO = new S_Object();
			s_p_ID_STATO.ParameterName = "p_ID_STATO";
			s_p_ID_STATO.DbType = CustomDBType.Integer;
			s_p_ID_STATO.Direction = ParameterDirection.Input;
			s_p_ID_STATO.Index =_SCollection.Count;

			if(DrTipoDocumenti.SelectedValue=="1")
				s_p_ID_STATO.Value="1";	
			if(DrTipoDocumenti.SelectedValue=="2")
				s_p_ID_STATO.Value="3";
			if(DrTipoDocumenti.SelectedValue=="3")
				s_p_ID_STATO.Value="1";
			if(DrTipoDocumenti.SelectedValue=="4")
				s_p_ID_STATO.Value="5";
			if(DrTipoDocumenti.SelectedValue=="5")
				s_p_ID_STATO.Value="3";
				
			_SCollection.Add(s_p_ID_STATO);

			S_Controls.Collections.S_Object s_p_DATA_INVIO = new S_Object();
			s_p_DATA_INVIO.ParameterName = "p_DATA_INVIO";
			s_p_DATA_INVIO.DbType = CustomDBType.VarChar;
			s_p_DATA_INVIO.Direction = ParameterDirection.Input;
			s_p_DATA_INVIO.Size=225;
			s_p_DATA_INVIO.Index = _SCollection.Count;
			if (CKMail.Checked==true)
				s_p_DATA_INVIO.Value= System.DateTime.Now.ToString().Replace('.',':');		
			else
				s_p_DATA_INVIO.Value=DBNull.Value;
			_SCollection.Add(s_p_DATA_INVIO);

			S_Controls.Collections.S_Object s_p_DATA_INSERIMENTo = new S_Object();
			s_p_DATA_INSERIMENTo.ParameterName = "p_DATA_INSERIMENTo";
			s_p_DATA_INSERIMENTo.DbType = CustomDBType.VarChar;
			s_p_DATA_INSERIMENTo.Direction = ParameterDirection.Input;
			s_p_DATA_INSERIMENTo.Size=225;
			s_p_DATA_INSERIMENTo.Index = _SCollection.Count;
			s_p_DATA_INSERIMENTo.Value= System.DateTime.Now.ToString().Replace('.',':');		
			_SCollection.Add(s_p_DATA_INSERIMENTo);

			S_Controls.Collections.S_Object s_p_anno = new S_Object();
			s_p_anno.ParameterName = "p_anno";
			s_p_anno.DbType = CustomDBType.Integer;
			s_p_anno.Direction = ParameterDirection.Input;
			s_p_anno.Size=225;
			s_p_anno.Index = _SCollection.Count;
			s_p_anno.Value=  DropAnno.SelectedValue;		
			_SCollection.Add(s_p_anno);

			S_Controls.Collections.S_Object s_p_note = new S_Object();
			s_p_note.ParameterName = "p_note1";
			s_p_note.DbType = CustomDBType.VarChar;
			s_p_note.Direction = ParameterDirection.Input;
			s_p_note.Size=225;
			s_p_note.Index = _SCollection.Count;
			s_p_note.Value=  TxtAnnotazioni.Text.Trim();		
			_SCollection.Add(s_p_note);

			if (DrTipoDocumenti.SelectedValue=="2" || DrTipoDocumenti.SelectedValue=="1")
				Result=_inviodoc.SaveAnni(_SCollection);
			else
			{
				S_Controls.Collections.S_Object s_p_mese = new S_Object();
				s_p_mese.ParameterName = "p_mese";
				s_p_mese.DbType = CustomDBType.Integer;
				s_p_mese.Direction = ParameterDirection.Input;
				s_p_mese.Size=225;
				s_p_mese.Index = _SCollection.Count;
				s_p_mese.Value=  DropMese.SelectedValue;		
				_SCollection.Add(s_p_mese);

				Result=_inviodoc.SaveMesi(_SCollection);
			}
			return Result;
		}
		
		#region SalvaFileDifferibile
		private int SaveDifferibile()
		{
			S_ControlsCollection _SCollection = new S_ControlsCollection();		

			S_Controls.Collections.S_Object s_p_ID = new S_Object();
			s_p_ID.ParameterName = "p_Id";
			s_p_ID.DbType = CustomDBType.Integer;
			s_p_ID.Direction = ParameterDirection.Input;
			s_p_ID.Index =_SCollection.Count;
			s_p_ID.Value=DBNull.Value;			
			_SCollection.Add(s_p_ID);

			S_Controls.Collections.S_Object s_p_BL_ID = new S_Object();
			s_p_BL_ID.ParameterName = "p_bl_Id";
			s_p_BL_ID.DbType = CustomDBType.Integer;
			s_p_BL_ID.Direction = ParameterDirection.Input;
			s_p_BL_ID.Index =_SCollection.Count;
			s_p_BL_ID.Value=Convert.ToInt32(DrEdifici.SelectedValue);			
			_SCollection.Add(s_p_BL_ID);

			S_Controls.Collections.S_Object s_p_NOME_DOC = new S_Object();
			s_p_NOME_DOC.ParameterName = "p_NOME_DOC";
			s_p_NOME_DOC.DbType = CustomDBType.VarChar;
			s_p_NOME_DOC.Direction = ParameterDirection.Input;
			s_p_NOME_DOC.Size=225;
			s_p_NOME_DOC.Index = _SCollection.Count;
			s_p_NOME_DOC.Value=System.IO.Path.GetFileName(UploadFile.PostedFile.FileName);			
			_SCollection.Add(s_p_NOME_DOC);
             
			S_Controls.Collections.S_Object s_p_ID_STATO = new S_Object();
			s_p_ID_STATO.ParameterName = "p_ID_STATO";
			s_p_ID_STATO.DbType = CustomDBType.Integer;
			s_p_ID_STATO.Direction = ParameterDirection.Input;
			s_p_ID_STATO.Index =_SCollection.Count;
			s_p_ID_STATO.Value="6";
			_SCollection.Add(s_p_ID_STATO);

			S_Controls.Collections.S_Object s_p_DATA_INVIO = new S_Object();
			s_p_DATA_INVIO.ParameterName = "p_DATA_INVIO";
			s_p_DATA_INVIO.DbType = CustomDBType.VarChar;
			s_p_DATA_INVIO.Direction = ParameterDirection.Input;
			s_p_DATA_INVIO.Size=225;
			s_p_DATA_INVIO.Index = _SCollection.Count;
			if (CKMail.Checked==true)
				s_p_DATA_INVIO.Value= System.DateTime.Now.ToString().Replace('.',':');		
			else
				s_p_DATA_INVIO.Value=DBNull.Value;
			_SCollection.Add(s_p_DATA_INVIO);

			S_Controls.Collections.S_Object s_p_DATA_INSERIMENTo = new S_Object();
			s_p_DATA_INSERIMENTo.ParameterName = "p_DATA_INSERIMENTo";
			s_p_DATA_INSERIMENTo.DbType = CustomDBType.VarChar;
			s_p_DATA_INSERIMENTo.Direction = ParameterDirection.Input;
			s_p_DATA_INSERIMENTo.Size=225;
			s_p_DATA_INSERIMENTo.Index = _SCollection.Count;
			s_p_DATA_INSERIMENTo.Value= System.DateTime.Now.ToString().Replace('.',':');		
			_SCollection.Add(s_p_DATA_INSERIMENTo);

			S_Controls.Collections.S_Object s_p_anno = new S_Object();
			s_p_anno.ParameterName = "p_anno";
			s_p_anno.DbType = CustomDBType.Integer;
			s_p_anno.Direction = ParameterDirection.Input;
			s_p_anno.Size=225;
			s_p_anno.Index = _SCollection.Count;
			s_p_anno.Value=  DropAnno.SelectedValue;		
			_SCollection.Add(s_p_anno);

			S_Controls.Collections.S_Object s_p_note = new S_Object();
			s_p_note.ParameterName = "p_note1";
			s_p_note.DbType = CustomDBType.VarChar;
			s_p_note.Direction = ParameterDirection.Input;
			s_p_note.Size=225;
			s_p_note.Index = _SCollection.Count;
			s_p_note.Value=  TxtAnnotazioni.Text.Trim();		
			_SCollection.Add(s_p_note);

		
			S_Controls.Collections.S_Object s_p_mese = new S_Object();
			s_p_mese.ParameterName = "p_mese";
			s_p_mese.DbType = CustomDBType.Integer;
			s_p_mese.Direction = ParameterDirection.Input;
			s_p_mese.Size=225;
			s_p_mese.Index = _SCollection.Count;
			s_p_mese.Value=  DropMese.SelectedValue;		
			_SCollection.Add(s_p_mese);

			Result=_inviodoc.SavePrescrizioni(_SCollection);
			
			return Result;
		}
		#endregion


		/// <summary>
		/// Questa routine risalva i  nuovi file riemessi con il piano mensile eseguito
		/// </summary>
		internal void SalvaEseguito(string FileExcel, string FileA8)
		{
			for(int i=0;i<=1;i++)
			{
				S_ControlsCollection _SCollection = new S_ControlsCollection();		

				S_Controls.Collections.S_Object s_p_ID = new S_Object();
				s_p_ID.ParameterName = "p_Id";
				s_p_ID.DbType = CustomDBType.Integer;
				s_p_ID.Direction = ParameterDirection.Input;
				s_p_ID.Index =_SCollection.Count;
				s_p_ID.Value=DBNull.Value;			
				_SCollection.Add(s_p_ID);

				S_Controls.Collections.S_Object s_p_BL_ID = new S_Object();
				s_p_BL_ID.ParameterName = "p_bl_Id";
				s_p_BL_ID.DbType = CustomDBType.Integer;
				s_p_BL_ID.Direction = ParameterDirection.Input;
				s_p_BL_ID.Index =_SCollection.Count;
				s_p_BL_ID.Value=Convert.ToInt32(DrEdifici.SelectedValue);			
				_SCollection.Add(s_p_BL_ID);

				S_Controls.Collections.S_Object s_p_NOME_DOC = new S_Object();
				s_p_NOME_DOC.ParameterName = "p_NOME_DOC";
				s_p_NOME_DOC.DbType = CustomDBType.VarChar;
				s_p_NOME_DOC.Direction = ParameterDirection.Input;
				s_p_NOME_DOC.Size=225;
				s_p_NOME_DOC.Index = _SCollection.Count;
				if(i==0)
					s_p_NOME_DOC.Value=System.IO.Path.GetFileName(FileExcel);	
				else
					s_p_NOME_DOC.Value=System.IO.Path.GetFileName(FileA8);
				_SCollection.Add(s_p_NOME_DOC);
             
				S_Controls.Collections.S_Object s_p_ID_STATO = new S_Object();
				s_p_ID_STATO.ParameterName = "p_ID_STATO";
				s_p_ID_STATO.DbType = CustomDBType.Integer;
				s_p_ID_STATO.Direction = ParameterDirection.Input;
				s_p_ID_STATO.Index =_SCollection.Count;
				s_p_ID_STATO.Value="5";
				_SCollection.Add(s_p_ID_STATO);

				S_Controls.Collections.S_Object s_p_DATA_INVIO = new S_Object();
				s_p_DATA_INVIO.ParameterName = "p_DATA_INVIO";
				s_p_DATA_INVIO.DbType = CustomDBType.VarChar;
				s_p_DATA_INVIO.Direction = ParameterDirection.Input;
				s_p_DATA_INVIO.Size=225;
				s_p_DATA_INVIO.Index = _SCollection.Count;
				if (CKMail.Checked==true)
					s_p_DATA_INVIO.Value= System.DateTime.Now.ToString().Replace('.',':');	
				else
					s_p_DATA_INVIO.Value=DBNull.Value;
				_SCollection.Add(s_p_DATA_INVIO);

				S_Controls.Collections.S_Object s_p_DATA_INSERIMENTo = new S_Object();
				s_p_DATA_INSERIMENTo.ParameterName = "p_DATA_INSERIMENTo";
				s_p_DATA_INSERIMENTo.DbType = CustomDBType.VarChar;
				s_p_DATA_INSERIMENTo.Direction = ParameterDirection.Input;
				s_p_DATA_INSERIMENTo.Size=225;
				s_p_DATA_INSERIMENTo.Index = _SCollection.Count;
				s_p_DATA_INSERIMENTo.Value=  System.DateTime.Now.ToString().Replace('.',':');		
				_SCollection.Add(s_p_DATA_INSERIMENTo);

				S_Controls.Collections.S_Object s_p_anno = new S_Object();
				s_p_anno.ParameterName = "p_anno";
				s_p_anno.DbType = CustomDBType.Integer;
				s_p_anno.Direction = ParameterDirection.Input;
				s_p_anno.Size=225;
				s_p_anno.Index = _SCollection.Count;
				s_p_anno.Value=  DropAnno.SelectedValue;		
				_SCollection.Add(s_p_anno);

				S_Controls.Collections.S_Object s_p_note = new S_Object();
				s_p_note.ParameterName = "p_note1";
				s_p_note.DbType = CustomDBType.VarChar;
				s_p_note.Direction = ParameterDirection.Input;
				s_p_note.Size=225;
				s_p_note.Index = _SCollection.Count;
				s_p_note.Value=  TxtAnnotazioni.Text.Trim();		
				_SCollection.Add(s_p_note);

				S_Controls.Collections.S_Object s_p_mese = new S_Object();
				s_p_mese.ParameterName = "p_mese";
				s_p_mese.DbType = CustomDBType.Integer;
				s_p_mese.Direction = ParameterDirection.Input;
				s_p_mese.Size=225;
				s_p_mese.Index = _SCollection.Count;
				s_p_mese.Value=  DropMese.SelectedValue;		
				_SCollection.Add(s_p_mese);
                if(i==0)
					Result=_inviodoc.SaveMesi(_SCollection);
				else
				{
					if (FileA8!="")
						_inviodoc.SaveMesi(_SCollection);
				}
			}
	
		}
		internal void SalvaA8( string FileA8)
		{
		
				S_ControlsCollection _SCollection = new S_ControlsCollection();		

				S_Controls.Collections.S_Object s_p_ID = new S_Object();
				s_p_ID.ParameterName = "p_Id";
				s_p_ID.DbType = CustomDBType.Integer;
				s_p_ID.Direction = ParameterDirection.Input;
				s_p_ID.Index =_SCollection.Count;
				s_p_ID.Value=DBNull.Value;			
				_SCollection.Add(s_p_ID);

				S_Controls.Collections.S_Object s_p_BL_ID = new S_Object();
				s_p_BL_ID.ParameterName = "p_bl_Id";
				s_p_BL_ID.DbType = CustomDBType.Integer;
				s_p_BL_ID.Direction = ParameterDirection.Input;
				s_p_BL_ID.Index =_SCollection.Count;
				s_p_BL_ID.Value=Convert.ToInt32(DrEdifici.SelectedValue);			
				_SCollection.Add(s_p_BL_ID);

				S_Controls.Collections.S_Object s_p_NOME_DOC = new S_Object();
				s_p_NOME_DOC.ParameterName = "p_NOME_DOC";
				s_p_NOME_DOC.DbType = CustomDBType.VarChar;
				s_p_NOME_DOC.Direction = ParameterDirection.Input;
				s_p_NOME_DOC.Size=225;
				s_p_NOME_DOC.Index = _SCollection.Count;
		
				s_p_NOME_DOC.Value=System.IO.Path.GetFileName(FileA8);
				_SCollection.Add(s_p_NOME_DOC);
             
				S_Controls.Collections.S_Object s_p_ID_STATO = new S_Object();
				s_p_ID_STATO.ParameterName = "p_ID_STATO";
				s_p_ID_STATO.DbType = CustomDBType.Integer;
				s_p_ID_STATO.Direction = ParameterDirection.Input;
				s_p_ID_STATO.Index =_SCollection.Count;

				if(DrTipoDocumenti.SelectedValue=="1")
					s_p_ID_STATO.Value="1";	
				if(DrTipoDocumenti.SelectedValue=="2")
					s_p_ID_STATO.Value="3";
				if(DrTipoDocumenti.SelectedValue=="3")
					s_p_ID_STATO.Value="1";
				if(DrTipoDocumenti.SelectedValue=="4")
					s_p_ID_STATO.Value="5";
				if(DrTipoDocumenti.SelectedValue=="5")
					s_p_ID_STATO.Value="3";

				_SCollection.Add(s_p_ID_STATO);

				S_Controls.Collections.S_Object s_p_DATA_INVIO = new S_Object();
				s_p_DATA_INVIO.ParameterName = "p_DATA_INVIO";
				s_p_DATA_INVIO.DbType = CustomDBType.VarChar;
				s_p_DATA_INVIO.Direction = ParameterDirection.Input;
				s_p_DATA_INVIO.Size=225;
				s_p_DATA_INVIO.Index = _SCollection.Count;
				if (CKMail.Checked==true)
					s_p_DATA_INVIO.Value= System.DateTime.Now.ToString().Replace('.',':');	
			    else
					s_p_DATA_INVIO.Value=DBNull.Value;
				_SCollection.Add(s_p_DATA_INVIO);

				S_Controls.Collections.S_Object s_p_DATA_INSERIMENTo = new S_Object();
				s_p_DATA_INSERIMENTo.ParameterName = "p_DATA_INSERIMENTo";
				s_p_DATA_INSERIMENTo.DbType = CustomDBType.VarChar;
				s_p_DATA_INSERIMENTo.Direction = ParameterDirection.Input;
				s_p_DATA_INSERIMENTo.Size=225;
				s_p_DATA_INSERIMENTo.Index = _SCollection.Count;
				s_p_DATA_INSERIMENTo.Value=  System.DateTime.Now.ToString().Replace('.',':');		
				_SCollection.Add(s_p_DATA_INSERIMENTo);

				S_Controls.Collections.S_Object s_p_anno = new S_Object();
				s_p_anno.ParameterName = "p_anno";
				s_p_anno.DbType = CustomDBType.Integer;
				s_p_anno.Direction = ParameterDirection.Input;
				s_p_anno.Size=225;
				s_p_anno.Index = _SCollection.Count;
				s_p_anno.Value=  DropAnno.SelectedValue;		
				_SCollection.Add(s_p_anno);

				S_Controls.Collections.S_Object s_p_note = new S_Object();
				s_p_note.ParameterName = "p_note1";
				s_p_note.DbType = CustomDBType.VarChar;
				s_p_note.Direction = ParameterDirection.Input;
				s_p_note.Size=225;
				s_p_note.Index = _SCollection.Count;
				s_p_note.Value=  TxtAnnotazioni.Text.Trim();		
				_SCollection.Add(s_p_note);

				S_Controls.Collections.S_Object s_p_mese = new S_Object();
				s_p_mese.ParameterName = "p_mese";
				s_p_mese.DbType = CustomDBType.Integer;
				s_p_mese.Direction = ParameterDirection.Input;
				s_p_mese.Size=225;
				s_p_mese.Index = _SCollection.Count;
				s_p_mese.Value=  DropMese.SelectedValue;		
				_SCollection.Add(s_p_mese);

				_inviodoc.SaveMesi(_SCollection);
	
		}
		/// <summary>
		/// Aggiorna il Piano di manutenzione Mensile
		/// </summary>
		private bool UpdatePMP(string FileName,PMPExcel.UpdateType updatetype)
		{
			string ConnectionStr =System.Configuration.ConfigurationSettings.AppSettings["ConnectionString"];
			PMPExcel.PMPExcel exc=new PMPExcel.PMPExcel(FileName,updatetype,Context.User.Identity.Name,ConnectionStr);
			try
			{
				StringBuilder sb = exc.ReadDocument();
				lblMessage.Text=sb.ToString().Replace("\n","</br>");
				return exc.IsValid;
			}
			catch(Exception x)
			{
				lblMessage.Text=x.Message;
				return false;
			}
			finally 
			{
				if (exc != null)
					((IDisposable)exc).Dispose();

			}
		}
		private void BtInvia_Click(object sender, System.EventArgs e)
		{
			lblMessage.Text="";
			SendDoc();
		}

		#region Prescrizioni
		private void SalvaDifferibili()
		{
			string PathDir=Server.MapPath("../Doc_DB");
			if (UploadFile.PostedFile!=null && UploadFile.PostedFile.FileName!="") 
			{
				PathDir=PathDir + @"\Manutenzione Programmata";//Manutenzione Programmata
				if(!Directory.Exists(PathDir))
					Directory.CreateDirectory(PathDir);

				string PathDirAnnuale=PathDir + @"\PAM" + DropAnno.SelectedValue;//Cartella del Piano annuale

				if(!Directory.Exists(PathDirAnnuale))
					Directory.CreateDirectory(PathDirAnnuale);

				string PathDirMensile=PathDir + @"\PMP" + DropAnno.SelectedValue;//Cartella de Piano Mensile
				if(!Directory.Exists(PathDirMensile))
					Directory.CreateDirectory(PathDirMensile);

				string DestPath="";
				string[] CodEdi=DrEdifici.Items[DrEdifici.SelectedIndex].Text.Split('-');
		
				PathDirMensile =PathDirMensile + @"\" + CodEdi[0].Trim();//Cartella de Piano Mensile
				if(!Directory.Exists(PathDirMensile))
					Directory.CreateDirectory(PathDirMensile);
				DestPath=PathDirMensile;
		
				string FileName=DestPath + @"\" + System.IO.Path.GetFileName(UploadFile.PostedFile.FileName);
				
				//Salvo il file nella directory
				if (File.Exists(FileName))
				{
					//File.Delete(FileName);
					lblMessage.Text="Impossibile Salvare il file inviato. Il file gi� esiste, rinominare il file o selezionare un file diverso.";
					return;
				}
				UploadFile.PostedFile.SaveAs(FileName);
				int IdFile=SaveDifferibile();
				if (IdFile<1)
					File.Delete(FileName);
				else
					lblMessage.Text="Il Documento � stato inserito con successo.";
			}
		}
		#endregion

		private bool IsValidDocAnnoVod()
		{
			//Proposto
			//VOD PAM2008_308A(PI).xls
			lblMessage.Text="";
			string FileName =System.IO.Path.GetFileName(UploadFile.PostedFile.FileName);
			//Verifico che il file inviato sia un file excel
			if(Path.GetExtension(FileName) !=".xls")
			{
				lblMessage.Text="Il File selezionato non � un file Excel!";
				return true;
			}
			//Splitto il nome del file per ricavare il codice edifio mese anno
			string[] arrstr=FileName.Split('_');
			string [] arrstr2=arrstr[1].Split('(');
			
			//Controllo esattezza nome
			if(arrstr.Length< 2 || arrstr2.Length < 2)
				{
					//Controllo lo stato del piano per verificare la correttezza del nome
					if(DrTipoDocumenti.SelectedValue=="1")
						{
							lblMessage.Text="Il File selezionato non � un file Valido per l'invio, il formato deve essere:PAM_ANNO_NOMEEDIFICIO(PROVINCIA).xls!";
							return true;
						}
					else if(DrTipoDocumenti.SelectedValue=="2")
						{
							//CONTROLLARE IL NOME DI VODAFONE PAM ESEGUITO
							lblMessage.Text="Il File selezionato non � un file Valido per l'invio, il formato deve essere:PAM_ANNO_NOMEEDIFICIO(PROVINCIA).xls!";
							return true;
						}
				}
			
			//Recuper il nome del
			string BL_ID=arrstr2[0];
			string Year;
			Year=arrstr[0].Substring(3,4);
			//Recupero il codice edificio dalla combo
			string[] CodEdi=DrEdifici.Items[DrEdifici.SelectedIndex].Text.Split('-');
			
			if(CodEdi[0].Trim()!=BL_ID)
			{
				lblMessage.Text="Il Nome del File selezionato contiene un Edificio diverso da quello selezionato!";
				return true;
			}
			
			if(DropAnno.SelectedValue!=Year)
			{
				lblMessage.Text="Il Nome del File selezionato contiene un Anno diverso da quello selezionato!";
				return true;
			}

			
			string username=Context.User.Identity.Name; 
			int Id_Bl=Convert.ToInt32(DrEdifici.SelectedValue);
			return false;
		}
		private bool IsValidDocAnnoH3G()
		{
			//Proposto
			//H3G BA_PAM2008_1.xls
			lblMessage.Text="";
			string FileName =System.IO.Path.GetFileName(UploadFile.PostedFile.FileName);
			//Verifico che il file inviato sia un file excel
			if(Path.GetExtension(FileName) !=".xls")
			{
				lblMessage.Text="Il File selezionato non � un file Excel!";
				return true;
			}
			//Splitto il nome del file per ricavare il codice edifio mese anno
			string[] arrstr=FileName.Split('_');
			string [] arrstr2=arrstr[1].Split('(');
			
			//Controllo esattezza nome
			if(arrstr.Length< 2 || arrstr2.Length < 2)
			{
				//Controllo lo stato del piano per verificare la correttezza del nome
				if(DrTipoDocumenti.SelectedValue=="1")
				{																										
					lblMessage.Text="Il File selezionato non � un file Valido per l'invio, il formato deve essere:NOMEEDIFICIO_PamAnno_Versione.xls!";
					return true;
				}
				else if(DrTipoDocumenti.SelectedValue=="2")
				{
					//CONTROLLARE IL NOME DI VODAFONE PAM ESEGUITO
					lblMessage.Text="Il File selezionato non � un file Valido per l'invio, il formato deve essere:NOMEEDIFICIO_PamAnno_Versione.xls!";
					return true;
				}
			}
			
			//Recuper il nome del
			string BL_ID=arrstr2[0];
			string Year;
			Year=arrstr[0].Substring(3,4);
			//Recupero il codice edificio dalla combo
			string[] CodEdi=DrEdifici.Items[DrEdifici.SelectedIndex].Text.Split('-');
			
			if(CodEdi[0].Trim()!=BL_ID)
			{
				lblMessage.Text="Il Nome del File selezionato contiene un Edificio non corrisponde a quello selezionato!";
				return true;
			}
			
			if(DropAnno.SelectedValue!=Year)
			{
				lblMessage.Text="Il Nome del File selezionato contiene un Anno non corrisponde a quello selezionato!";
				return true;
			}

			string username=Context.User.Identity.Name; 
			int Id_Bl=Convert.ToInt32(DrEdifici.SelectedValue);
			return false;
		}
		/// <summary>
		/// Controlla la validit� del documento inviato al server
		/// </summary>
		/// <returns></returns>
		private bool IsValidDocMensile()
		{
			lblMessage.Text="";
			//Recupero il nome del file
			string FileName =System.IO.Path.GetFileName(UploadFile.PostedFile.FileName);
			//Verifico che il file inviato sia un file excel
			if(Path.GetExtension(FileName) !=".xls")
			{
				lblMessage.Text="Il File selezionato non � un file Excel!";
				return true;
			}
			//Splitto il nome del file per ricavare il codice edifio mese anno
			string[] arrstr=FileName.Split('_');
			//Controllo la lunghezza dell'array
			if(arrstr.Length<4)
			{
				lblMessage.Text="Il File selezionato non � un file Valido per l'invio il formato deve essere: PMX_xls_NOMEEDIFICIO_MESE_ANNO_VERSIONE.xls!";
				return true;
			}
			//Recuper il nome del
			string BL_ID=arrstr[2];
			string Month =GetMese(arrstr[3]);
			string Year;
			
			if(arrstr[4].Length==2)
				Year="20" + arrstr[4];
			else
				Year= arrstr[4];
			//Recupero il codice edificio dalla combo
			string[] CodEdi=DrEdifici.Items[DrEdifici.SelectedIndex].Text.Split('-');
			if(CodEdi[0].Trim()!=BL_ID)
			{
				lblMessage.Text="Il Nome del File selezionato contiene un Edificio corrisponde all'edificio selezionato!";
				return true;
			}
			if(DropMese.SelectedValue!=Convert.ToInt32(Month).ToString())
			{
				lblMessage.Text="Il Nome del File selezionato contiene un Mese corrisponde a quello selezionato!";
				return true;
			}
			if(DropAnno.SelectedValue!=Year)
			{
				lblMessage.Text="Il Nome del File selezionato contiene un Anno non corrisponde a quello selezionato!";
				return true;
			}

			int result=0;
			string username=Context.User.Identity.Name; 
			int Id_Bl=Convert.ToInt32(DrEdifici.SelectedValue);
			//Verifico che il piano Proposto Inviato non sia stato gi� accettato o eseguito 
			//(Deve stare come proposto)
			if(DrTipoDocumenti.SelectedValue=="3")//PIANO PROPOSTO
			{
				result=_inviodoc.IsValidStatus(Id_Bl,Convert.ToInt32(Month),Convert.ToInt32(Year),3,username);
				if(result==-1)
				{
					lblMessage.Text="Il Programma non pu� essere aggiornato in Proposto perch� � gi� eseguito in precedenza o non stato accettato!";
					return true;
				}
			}
			
			//Verifico che il Piano Eseguito Inviato stia con stato Accettato (quindi non proposto) 
			//e che non stia con stato come gi� eseguito
			if(DrTipoDocumenti.SelectedValue=="4")//PIANO ESEGUITO
			{
				if(arrstr[0].ToUpper()!="PME")
				{
					lblMessage.Text="Il Programma inviato come Eseguito perch� � il nome del file non inizia con PME!";
					return true;
				}

				result=_inviodoc.IsValidStatus(Id_Bl,Convert.ToInt32(Month),Convert.ToInt32(Year),4,username);
				if(result==-1)
				{
					lblMessage.Text="Il Programma non pu� essere aggiornato in Eseguito perch� � gi� eseguito in precedenza o non stato accettato!";
					return true;
				}
			}

			//Verifico che il piano Accettato Inviato stia con stato proposto e non stia gi� con stato 
			//accettato o eseguito
			if(DrTipoDocumenti.SelectedValue=="5")//PIANO ACCETTATO
			{
				result=_inviodoc.IsValidStatus(Id_Bl,Convert.ToInt32(Month),Convert.ToInt32(Year),5,username);
				if(result==-1)
				{
					lblMessage.Text="Il Programma non pu� essere aggiornato in Accetto perch� � gi� eseguito in precedenza o non stato accettato!";
					return true;
				}
			}

			return false;
		}
		internal string FileZipMail="";
		private string GetNameFileZip(string NameFile)
		{
		

			string FileZip ="";
			FileZip = Path.GetDirectoryName(NameFile) + @"\" + Path.GetFileNameWithoutExtension(NameFile) + ".zip";
			int j=0;
			while  (j>-1)
			{
				try
				{
					if (File.Exists(FileZip))
						File.Delete(FileZip);
					break;
				}
				catch
				{
					FileZip = Path.GetDirectoryName(NameFile) + @"\" + Path.GetFileNameWithoutExtension(NameFile) + "_" + j .ToString() + ".zip";
				}
				j++;
			}
			return FileZip;
		}
		private void SendDoc()
		{
			

			if (DrTipoDocumenti.SelectedValue=="6")//Differibili
			{
				SalvaDifferibili();
				//Invio della Mail in modalit� asincrona di tracciatura
				Thread t1 = new Thread(new ThreadStart(SendTracker));
				t1.Start();
				return;
			}
			string PathDir=Server.MapPath("../Doc_DB");
			if (UploadFile.PostedFile!=null && UploadFile.PostedFile.FileName!="") 
			{
				PathDir=PathDir + @"\Manutenzione Programmata";//Manutenzione Programmata
				if(!Directory.Exists(PathDir))
					Directory.CreateDirectory(PathDir);

				string PathDirAnnuale=PathDir + @"\PAM" + DropAnno.SelectedValue;//Cartella del Piano annuale

				if(!Directory.Exists(PathDirAnnuale))
					Directory.CreateDirectory(PathDirAnnuale);

				string PathDirMensile=PathDir + @"\PMP" + DropAnno.SelectedValue;//Cartella de Piano Mensile
				if(!Directory.Exists(PathDirMensile))
					Directory.CreateDirectory(PathDirMensile);

				string DestPath="";
				string[] CodEdi=DrEdifici.Items[DrEdifici.SelectedIndex].Text.Split('-');
				if(DrTipoDocumenti.SelectedValue=="3" || DrTipoDocumenti.SelectedValue=="4" || DrTipoDocumenti.SelectedValue=="5")//Piano mensile
				{
					
					PathDirMensile =PathDirMensile + @"\" + CodEdi[0].Trim();//Cartella de Piano Mensile
					if(!Directory.Exists(PathDirMensile))
						Directory.CreateDirectory(PathDirMensile);
					DestPath=PathDirMensile;
				}
				else//Piano Annuale
				{
					DestPath=PathDirAnnuale;
				}
				string FileName=DestPath + @"\" + System.IO.Path.GetFileName(UploadFile.PostedFile.FileName);
				
				//Salvo il file nella directory
				if (File.Exists(FileName))
				{
					//File.Delete(FileName);
					lblMessage.Text="Impossibile Salvare il file inviato. Il file gi� esiste, rinominare il file o selezionare un file diverso.";
					return;
				}

				//Controllo che tipo di piano devo inserire per poi verificare la correttezza del documento
				if(DrTipoDocumenti.SelectedValue=="1" || DrTipoDocumenti.SelectedValue=="2")
					{
						if (prj=="1")
						{
							if (IsValidDocAnnoH3G()==true)
							return;
						}
						else if (prj=="2")
						{
							if (IsValidDocAnnoVod()==true)
							return;
						}
					}
				
				else
					{
						//Controlla che il file inviato corrisponda all'edificio selezionato.
						if(IsValidDocMensile()==true)
							return;
					}
				UploadFile.PostedFile.SaveAs(FileName);

				int IdFile=SalvaInvio();
				bool Ok=false;
				//Salvo le modifiche al piano mensile
				if(DrTipoDocumenti.SelectedValue=="3") 
					Ok=UpdatePMP(FileName,PMPExcel.UpdateType.Proposto);

				if(DrTipoDocumenti.SelectedValue=="4") 
					Ok=UpdatePMP(FileName,PMPExcel.UpdateType.Eseguito);	

				if(DrTipoDocumenti.SelectedValue=="5") 
					Ok=UpdatePMP(FileName,PMPExcel.UpdateType.Accettato);

				//Invio della Mail in modalit� asincrona di tracciatura
				Thread t1 = new Thread(new ThreadStart(SendTracker));
				t1.Start();

				if(Ok==true)
					SendMail(FileName);
				else
				{
				  //Elimino il file Inviato
					DeleteFile(IdFile);
					File.Delete(FileName);
				}
			}
		}


		private void SendMail(string FileName)
		{
			Response.Flush();

			string[] CodEdi=DrEdifici.Items[DrEdifici.SelectedIndex].Text.Split('-');
			int Id_progetto=_inviodoc.GetIdProgetto(CodEdi[0].Trim());
			string CodiceEdificio=CodEdi[0].Trim();
            int Mese=Convert.ToInt32(DropMese.SelectedValue);
			int Anno=Convert.ToInt32(DropAnno.SelectedValue);
			//Se il piano � eseguito ricreo il file A8 ed XSL
			if(DrTipoDocumenti.SelectedValue=="4") 
			{
				
				string Out=Path.GetDirectoryName(FileName);
				string FileExcel="";
				string FileExcelA8="";
				
				//CREAZIONE DEL FILE EXCEL PME
				FileExcel=CreaFileXLS(Out,CodiceEdificio,Mese,Anno);
			    
				if(Id_progetto==1)
			        FileExcelA8=CreaFileA8(Out,CodiceEdificio,Mese,Anno);

				string FileZip="";//Se deve inviare la email Zippa i File
				if (CKMail.Checked ==true) 
					FileZip =CreaFileZip(FileExcel,FileExcelA8);
					
				FileZipMail=FileZip;	
				SalvaEseguito(FileExcel,FileExcelA8);
			}
			else
			{

                string FileExcel="";
				string FileExcelA8="";
				if(Id_progetto==1)
				{
					string Out=Path.GetDirectoryName(FileName);
					FileExcelA8=CreaFileA8(Out,CodiceEdificio,Mese,Anno);
					SalvaA8(FileExcelA8);
				}
				//MDG: Eventuale modifica ricrea il file Inviato
				//FileExcel=CreaFileXLS(Out,CodiceEdificio,Mese,Anno);
				//Il file da passare non � + FileName ma FileExcel
                FileExcel=FileName;

				string FileZip ="";
				if (CKMail.Checked ==true) 
					FileZip =CreaFileZip(FileExcel,FileExcelA8);
				
				FileZipMail=FileZip;
			}
			
			Response.Flush();
	       

			//Invio della Mail in modalit� asincrona
			Thread t = new Thread(new ThreadStart(Send));
			t.Start();
		}

		#region Crea il File EXCEL XLS
		/// <summary>
		/// Crea il File EXCEL XLS
		/// </summary>
		/// <param name="Out">Path di destinazione del file creato</param>
		/// <param name="CodEdi">Codice Edificio</param>
		/// <param name="Mese">Mese di creazione del Piano</param>
		/// <param name="Anno">Anno di creazione del Piano</param>
		/// <returns>Nome del File Excel creato comprensivo di percorso fisico</returns>
		internal string CreaFileXLS(string Out, string CodEdi,int Mese,int Anno)
		{
			string ConnectionStr =System.Configuration.ConfigurationSettings.AppSettings["ConnectionString"];
			string Master=Server.MapPath("../MasterExcel");
			string FileExcel="";
			ExcelWritePMP   exc=new ExcelWritePMP(Master,Out,ConnectionStr);
			try
			{
				FileExcel=exc.WriteFilePMP(CodEdi,Mese,Anno);
			
			}
			finally 
			{
				if (exc != null)
					((IDisposable)exc).Dispose();

			}
			return FileExcel;
		}
		#endregion

		#region Crea il File EXCEL A8
		/// <summary>
		/// Crea il File EXCEL A8
		/// </summary>
		/// <param name="Out">Path di destinazione del file creato</param>
		/// <param name="CodEdi">Codice Edificio</param>
		/// <param name="Mese">Mese di creazione del Piano</param>
		/// <param name="Anno">Anno di creazione del Piano</param>
		/// <returns>Nome del File Excel creato comprensivo di percorso fisico</returns>
		internal string CreaFileA8(string Out, string CodEdi,int Mese,int Anno)
		{
			string ConnectionStr =System.Configuration.ConfigurationSettings.AppSettings["ConnectionString"];
			string Master=Server.MapPath("../MasterExcel");
			string FileExcelA8="";
			MP_RPT_XLS.MPRPT rpt=new MP_RPT_XLS.MPRPT();
			try
			{
				rpt.Anno =Anno;
				rpt.CodSede =CodEdi;
				rpt.Mese =Mese;
				rpt.PathFileOutPut = Out;
				rpt.StrDataDdb =ConnectionStr;
				rpt.GeneraRptXlsMp(Master,CodEdi,
					Mese,Anno);

				FileExcelA8=rpt.NomeFileCompleto;
						
			}
			finally 
			{
				if (rpt != null)
					((IDisposable)rpt).Dispose();

			}
			return FileExcelA8;
		}
		#endregion

		#region Crea il File ZIP
		/// <summary>
		/// Crea un File Zip Con i file Appena Creati
		/// </summary>
		/// <param name="FileXLS"></param>
		/// <param name="FileA8"></param>
		/// <returns>Nome del file Zip appena creato</returns>
		internal string CreaFileZip(string FileXLS,string FileExcelA8)
		{
			string FileZip =GetNameFileZip(FileXLS);
			FileZipMail=FileZip;
			ZipOutputStream s = new ZipOutputStream(File.Create(FileZip)); 
			s.SetLevel(5); // 0 - store only to 9 - means best compression 
			FileStream fs = File.OpenRead(FileXLS); 
			byte[] buffer = new byte[fs.Length]; 
			fs.Read(buffer, 0, buffer.Length); 
			ZipEntry entry = new ZipEntry(Path.GetFileName(FileXLS)); 
			s.PutNextEntry(entry); 
			s.Write(buffer, 0, buffer.Length); 

			if(File.Exists(FileExcelA8))
			{
				fs = File.OpenRead(FileExcelA8); 
				buffer = new byte[fs.Length]; 
				fs.Read(buffer, 0, buffer.Length); 
				entry = new ZipEntry(Path.GetFileName(FileExcelA8)); 
				s.PutNextEntry(entry); 
				s.Write(buffer, 0, buffer.Length); 
			}
           
			s.Finish(); 
			s.Close(); 
			fs.Close();
	
			return FileZip;
		}
		#endregion

		#region Invio delle Mail hai destinatari
	
		private void Send()
		{
			//Invio comunque una mail di tracciatura delle operazioni
			//SendTracker();
			//Non ivio le email se il flag non � spuntato
			if (CKMail.Checked ==false) return;

			DataSet _Ds;
			if(DrTipoDocumenti.SelectedValue=="4")
				_Ds= _inviodoc.GetDestinatari(int.Parse(DrEdifici.SelectedValue),true);
			else
				_Ds= _inviodoc.GetDestinatari(int.Parse(DrEdifici.SelectedValue),false);

			DataColumn dc = new DataColumn("IsExecute",System.Type.GetType("System.Int32"));
			dc.DefaultValue =0;
			DataTable dt=_Ds.Tables[0];
			dt.Columns.Add(dc);

			bool flag_mail=false;
			string MailUser=_inviodoc.GetMailByUser(); 
			foreach(DataRow riga in  dt.Rows)
			{
				if(MailUser.Trim().ToLower()==riga["email"].ToString().Trim().ToLower())
				{
					flag_mail=true;
					riga["IsExecute"]=1;
					break;
				}
			}
			
			if(flag_mail==false && MailUser!="")
			{
				DataRow riga=dt.NewRow();
				riga["email"]=MailUser;
				riga["IsExecute"]=1;
				dt.Rows.Add(riga);
			}
			dt.AcceptChanges();
			
			int Count=0;
			string Dest="";
			string AllDest="";
			foreach(DataRow RigaDest in dt.Rows)
				if(RigaDest["id_utente"].ToString()=="")
					AllDest+=RigaDest["email"].ToString() + "; ";

			foreach(DataRow riga in dt.Rows)
			{

				
				if(riga["id_utente"].ToString()!="")
				{
					Dest=riga["email"].ToString();
				}
				else
				{
					Count++;
					if (Count>1) continue;
					if (Count==1) Dest=AllDest;
				}


				MailMessage mailMessage= new MailMessage();
				mailMessage.BodyFormat = MailFormat.Html;
				mailMessage.BodyEncoding=System.Text.Encoding.UTF8; 
				mailMessage.From = ConfigurationSettings.AppSettings["MailFrom"].ToString();
				mailMessage.To =Dest;
				mailMessage.Cc="ssys@cft-sir.it";
				Dest="";


				string Body="";
				//Se � un piano Mensile
		
				//Se � un piano Mensile
				if (DrTipoDocumenti.SelectedValue=="3" || DrTipoDocumenti.SelectedValue=="4" || DrTipoDocumenti.SelectedValue=="5")
				{
					
					string Lk="";
					string Lk1="";

					if (DrTipoDocumenti.SelectedValue=="3") //Proposto
					{
						string tipo="";
						if(riga["id_utente"].ToString()!="")
						{
							tipo="&t=m&e=" + DrEdifici.SelectedValue;
							Lk="<DIV>&nbsp;</DIV><DIV>&nbsp;</DIV><DIV><A href=\"http://www.cft-sir.it/SIRHV/default.aspx?u=" +  riga["id_utente"].ToString() + tipo + "&s=3&id=" + Result.ToString() + "\">Programma Accettato </A></DIV>";
							Lk+="<DIV>&nbsp;</DIV><DIV><A href=\"http://www.cft-sir.it/SIRHV/default.aspx?u=" +  riga["id_utente"].ToString() + tipo + "&s=4&id=" + Result.ToString() + "\">Programma Accettato con Riserva</A></DIV>";
							Lk+="<DIV>&nbsp;</DIV><DIV><A href=\"http://www.cft-sir.it/SIRHV/default.aspx?u=" +  riga["id_utente"].ToString() + tipo + "&s=2&id=" + Result.ToString()+ "\">Programma Rifiutato</A></DIV><DIV>&nbsp;</DIV>";
							Lk1="<DIV>Sono predisposti i seguenti link per <STRONG>Approvare</STRONG>,&nbsp;<STRONG>Approvare con promessa di aggiustamento</STRONG>&nbsp;o&nbsp;<STRONG>Respingere</STRONG> il programma di manutenzione.</DIV>";
						}
					}

					string Destinatari="";
					foreach(DataRow riga2 in  dt.Rows)
						Destinatari+=riga2["email"].ToString() + "; ";


					Body="<!DOCTYPE HTML PUBLIC \"-//W3C//DTD HTML 4.0 Transitional//EN\">";
					Body+="<HTML><HEAD><META http-equiv=Content-Type content=\"text/html; charset=iso-8859-1\">";
					Body+="<BODY bgColor=#ffffff><DIV>Altri destinatari: " +Destinatari + "</DIV>";
					Body+="<DIV>E' stato inserito un nuovo documento del " + DrTipoDocumenti.Items[DrTipoDocumenti.SelectedIndex].Text + " relativo alla sede " + DrEdifici.Items[DrEdifici.SelectedIndex].Text;
					Body+="	del mese di " + DropMese.Items[DropMese.SelectedIndex].Text + " " + DropAnno.Items[DropAnno.SelectedIndex].Text +"</DIV>";
					Body+="<DIV>con le seguenti annotazioni:</DIV><DIV>" + TxtAnnotazioni.Text + "</DIV>";
					Body+=Lk1;
					Body+=Lk;
					Body+="<DIV>&nbsp;</DIV>";

					
					if(riga["IsExecute"].ToString()=="1")
					{
						Body+="</br>Rapporto del File inviato:</br>";
						Body+=lblMessage.Text;
					}
					Body+="<DIV>SIR Cofathec Servizi S.p.a.</DIV><DIV>&nbsp;</DIV></BODY></HTML>";

					mailMessage.Body = Body;

					//mailMessage.Fields["http://schemas.microsoft.com/cdo/configuration/smtpauthenticate"] = 1;
					mailMessage.Fields["http://schemas.microsoft.com/cdo/configuration/sendusername"] = ConfigurationSettings.AppSettings["usersmtp"].ToString(); 
					mailMessage.Fields["http://schemas.microsoft.com/cdo/configuration/sendpassword"] = ConfigurationSettings.AppSettings["pwdsmtp"].ToString();

					if (File.Exists(FileZipMail))
					{
						MailAttachment attach = new MailAttachment(FileZipMail);
						mailMessage.Attachments.Add(attach);
					}
					SmtpMail.SmtpServer = ConfigurationSettings.AppSettings["SmtpServer2"].ToString();
					SmtpMail.Send(mailMessage);
				}
				else//Piano annuale
				{

					string Lk="";
					string Lk1="";
					if (DrTipoDocumenti.SelectedValue=="1") //Proposto
					{
						string tipo="";
						if(riga["id_utente"].ToString()!="")
						{
							tipo="&t=a&e=" + DrEdifici.SelectedValue;
							Lk="<DIV>&nbsp;</DIV><DIV><A href=\"http://www.cft-sir.it/SIRHV/default.aspx?u=" +  riga["id_utente"].ToString() + tipo + "&s=3&id=" + Result.ToString() + "\">Piano Accettato </A></DIV>";
							Lk+="<DIV>&nbsp;</DIV><DIV><A href=\"http://www.cft-sir.it/SIRHV/default.aspx?u=" +  riga["id_utente"].ToString() + tipo + "&s=4&id=" + Result.ToString() + "\">Piano Accettato con Riserva</A></DIV>";
							Lk+="<DIV>&nbsp;</DIV><DIV><A href=\"http://www.cft-sir.it/SIRHV/default.aspx?u=" +  riga["id_utente"].ToString() + tipo + "&s=2&id=" + Result.ToString()+ "\">Piano Rifiutato</A></DIV><DIV>&nbsp;</DIV>";
						
							Lk1="<DIV>Sono predisposti i seguenti link per <STRONG>Approvare</STRONG>,&nbsp;<STRONG>Approvare con promessa di aggiustamento</STRONG>&nbsp;o&nbsp;<STRONG>Respingere</STRONG> il piano di manutenzione Annuale.</DIV>";
						}
					}

					string CodiceEdi=DrEdifici.Items[DrEdifici.SelectedIndex].Text.Substring(1,DrEdifici.Items[DrEdifici.SelectedIndex].Text.IndexOf("-")-1);
					mailMessage.Subject =  string.Format(DrTipoDocumenti.Items[DrTipoDocumenti.SelectedIndex].Text +  " anno " + DropAnno.Items[DropAnno.SelectedIndex].Text.Substring(2) + " Sede: " + CodiceEdi + " Data invio: {0} Ora: {1}",DateTime.Now.ToLongDateString(),DateTime.Now.ToLongTimeString());
					
					string Destinatari="";
					foreach(DataRow riga2 in  dt.Rows)
						Destinatari+=riga2["email"].ToString() + "; ";
					Body="<!DOCTYPE HTML PUBLIC \"-//W3C//DTD HTML 4.0 Transitional//EN\">";
					Body+="<HTML><HEAD><META http-equiv=Content-Type content=\"text/html; charset=iso-8859-1\">";
					Body+="<BODY bgColor=#ffffff><DIV>Altri destinatari: " +Destinatari + "</DIV>";
					Body+="<DIV>E' stato inserito un nuovo documento del " + DrTipoDocumenti.Items[DrTipoDocumenti.SelectedIndex].Text + " relativo alla sede " + DrEdifici.Items[DrEdifici.SelectedIndex].Text;
					Body+="	" + DropAnno.Items[DropAnno.SelectedIndex].Text +"</DIV>";
					Body+="<DIV>con le seguenti annotazioni:</DIV><DIV>" + TxtAnnotazioni.Text + "</DIV>";
					Body+=Lk1;
					Body+=Lk;
					Body+="<DIV>&nbsp;</DIV>";

					
					if(riga["IsExecute"].ToString()=="1")
					{
						Body+="</br>Rapporto del File inviato:</br>";
						Body+=lblMessage.Text;
					}
					Body+="<DIV>SIR Cofathec Servizi S.p.a.</DIV><DIV>&nbsp;</DIV></BODY></HTML>";

					mailMessage.Body = Body;
					if (File.Exists(FileZipMail))
					{
						MailAttachment attach = new MailAttachment(FileZipMail);
						mailMessage.Attachments.Add(attach);
					}

					//mailMessage.Fields["http://schemas.microsoft.com/cdo/configuration/smtpauthenticate"] = 1;
					mailMessage.Fields["http://schemas.microsoft.com/cdo/configuration/sendusername"] = ConfigurationSettings.AppSettings["usersmtp"].ToString(); 
					mailMessage.Fields["http://schemas.microsoft.com/cdo/configuration/sendpassword"] = ConfigurationSettings.AppSettings["pwdsmtp"].ToString();

					SmtpMail.SmtpServer = ConfigurationSettings.AppSettings["SmtpServer2"].ToString();
					SmtpMail.Send(mailMessage);

				}
			}//Ciclo for
		}

		#endregion
		
		#region Email di tracciatura
		//Mai di tracciatura delle operazione
		private void SendTracker()
		{
			MailMessage mailMessage= new MailMessage();
			mailMessage.BodyFormat = MailFormat.Html;
			mailMessage.BodyEncoding=System.Text.Encoding.UTF8; 
			mailMessage.From = ConfigurationSettings.AppSettings["MailFrom"].ToString();
			mailMessage.To ="ssysmp@cft-sir.it";
			DataSet _Ds;
			if(DrTipoDocumenti.SelectedValue=="4")
				_Ds= _inviodoc.GetDestinatari(int.Parse(DrEdifici.SelectedValue),true);
			else
				_Ds= _inviodoc.GetDestinatari(int.Parse(DrEdifici.SelectedValue),false);

			string CodiceEdi=DrEdifici.Items[DrEdifici.SelectedIndex].Text.Substring(0,DrEdifici.Items[DrEdifici.SelectedIndex].Text.IndexOf("-")-1);
			mailMessage.Subject =  string.Format(DrTipoDocumenti.Items[DrTipoDocumenti.SelectedIndex].Text + " mese " + DropMese.Items[DropMese.SelectedIndex].Text + " " + DropAnno.Items[DropAnno.SelectedIndex].Text.Substring(2) + " Sede: " + CodiceEdi + " Data invio: {0} Ora: {1}",DateTime.Now.ToLongDateString(),DateTime.Now.ToLongTimeString());
					
			string Destinatari="";
			foreach(DataRow riga2 in  _Ds.Tables[0].Rows)
				Destinatari+=riga2["email"].ToString() + "; ";

            string Body="";
			Body="<!DOCTYPE HTML PUBLIC \"-//W3C//DTD HTML 4.0 Transitional//EN\">";
			Body+="<HTML><HEAD><META http-equiv=Content-Type content=\"text/html; charset=iso-8859-1\">";
			Body+="<BODY bgColor=#ffffff><DIV>Altri destinatari: " +Destinatari + "</DIV>";
			Body+="<DIV>E' stato inserito un nuovo documento del " + DrTipoDocumenti.Items[DrTipoDocumenti.SelectedIndex].Text + " relativo alla sede " + DrEdifici.Items[DrEdifici.SelectedIndex].Text;
			Body+="	del mese di " + DropMese.Items[DropMese.SelectedIndex].Text + " " + DropAnno.Items[DropAnno.SelectedIndex].Text +"</DIV>";
			Body+="<DIV>con le seguenti annotazioni:</DIV><DIV>" + TxtAnnotazioni.Text + "</DIV>";
			Body+="<DIV>&nbsp;</DIV>";
			Body+="</br>Rapporto del File inviato:</br>";
			Body+=lblMessage.Text;
			Body+="<DIV>SIR Cofathec Servizi S.p.a.</DIV><DIV>&nbsp;</DIV></BODY></HTML>";

			mailMessage.Body = Body;

			//mailMessage.Fields["http://schemas.microsoft.com/cdo/configuration/smtpauthenticate"] = 1;
			mailMessage.Fields["http://schemas.microsoft.com/cdo/configuration/sendusername"] = ConfigurationSettings.AppSettings["usersmtp2"].ToString(); 
			mailMessage.Fields["http://schemas.microsoft.com/cdo/configuration/sendpassword"] = ConfigurationSettings.AppSettings["pwdsmtp2"].ToString();
			if (File.Exists(FileZipMail))
			{
				MailAttachment attach = new MailAttachment(FileZipMail);
				mailMessage.Attachments.Add(attach);
			}
			SmtpMail.SmtpServer = ConfigurationSettings.AppSettings["SmtpServer2"].ToString();
			SmtpMail.Send(mailMessage);
		}
		#endregion

		private string GetMese(string mese)
		{
			if(mese.ToUpper()=="GEN") return "01";
			if(mese.ToUpper()=="FEB") return "02";
			if(mese.ToUpper()=="MAR") return "03";
			if(mese.ToUpper()=="APR") return "04";
			if(mese.ToUpper()=="MAG") return "05";
			if(mese.ToUpper()=="GIU") return "06";
			if(mese.ToUpper()=="LUG") return "07";
			if(mese.ToUpper()=="AGO") return "08";
			if(mese.ToUpper()=="SET") return "09";
			if(mese.ToUpper()=="OTT") return "10";
			if(mese.ToUpper()=="NOV") return "11";
			if(mese.ToUpper()=="DIC") return "12";

			if(mese.ToUpper()=="GENNAIO") return "01";
			if(mese.ToUpper()=="FEBBRAIO") return "02";
			if(mese.ToUpper()=="MARZO") return "03";
			if(mese.ToUpper()=="APRILE") return "04";
			if(mese.ToUpper()=="MAGGIO") return "05";
			if(mese.ToUpper()=="GIUGNO") return "06";
			if(mese.ToUpper()=="LUGLIO") return "07";
			if(mese.ToUpper()=="AGOSTO") return "08";
			if(mese.ToUpper()=="SETTEMBRE") return "09";
			if(mese.ToUpper()=="OTTOBRE") return "10";
			if(mese.ToUpper()=="NOVEMBRE") return "11";
			if(mese.ToUpper()=="DICEMBRE") return "12";

			return "";
		}

		
	}
	
}