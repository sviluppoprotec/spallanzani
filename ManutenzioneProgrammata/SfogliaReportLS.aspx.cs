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
using S_Controls.Collections;
using System.Text;
using System.IO;
using System.Web.Mail;
using System.Configuration;
using ICSharpCode;
using ICSharpCode.SharpZipLib;
using ICSharpCode.SharpZipLib.Zip;
using ApplicationDataLayer.DBType;
using MyCollection;
using ExcelPMP;
using PMPExcel;
using System.Threading;

namespace TheSite.ManutenzioneProgrammata
{
	/// <summary>
	/// Descrizione di riepilogo per SfogliaReportLS.
	/// </summary>
	public class SfogliaReportLS : System.Web.UI.Page
	{
		protected Csy.WebControls.DataPanel PanelRicerca;
		protected S_Controls.S_Button btnsRicerca;
		protected System.Web.UI.WebControls.Button cmdReset;
		protected System.Web.UI.WebControls.ValidationSummary ValidationSummary1;
		protected System.Web.UI.WebControls.TextBox txtDescrizione;
		protected System.Web.UI.WebControls.DataGrid DataGridRicerca;
		protected WebControls.PageTitle	PageTitle1;
		protected WebControls.GridTitle GridTitle1;
		protected System.Web.UI.WebControls.DropDownList DropAnno;
		Classi.ManProgrammata.RecuperoDocPmp _RecuproDocPmp= new Classi.ManProgrammata.RecuperoDocPmp();
		TheSite.Classi.ManProgrammata.InvioDocPmP  _inviodoc = new TheSite.Classi.ManProgrammata.InvioDocPmP();
		protected System.Web.UI.WebControls.Label LblMessage;
		protected System.Web.UI.WebControls.DropDownList cmbsmese;
		public static string HelpLink = string.Empty;

		private void Page_Load(object sender, System.EventArgs e)
		{
			Classi.SiteModule _SiteModule = (Classi.SiteModule) HttpContext.Current.Items["SiteModule"];
			HelpLink = _SiteModule.HelpLink;
			this.PageTitle1.Title = _SiteModule.ModuleTitle;				
			GridTitle1.hplsNuovo.Visible=false;
			

			if(!IsPostBack)
			{
				
				LoadAnno();
			}
			// Inserire qui il codice utente necessario per inizializzare la pagina.
		}

		#region Codice generato da Progettazione Web Form
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: questa chiamata è richiesta da Progettazione Web Form ASP.NET.
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
			this.btnsRicerca.Click += new System.EventHandler(this.btnsRicerca_Click);
			this.cmdReset.Click += new System.EventHandler(this.cmdReset_Click);
			this.DataGridRicerca.ItemCommand += new System.Web.UI.WebControls.DataGridCommandEventHandler(this.DataGridRicerca_ItemCommand);
			this.DataGridRicerca.PageIndexChanged += new System.Web.UI.WebControls.DataGridPageChangedEventHandler(this.DataGridRicerca_PageIndexChanged);
			this.DataGridRicerca.ItemDataBound += new System.Web.UI.WebControls.DataGridItemEventHandler(this.DataGridRicerca_ItemDataBound);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void LoadAnno()
		{
		
			for(int i=2014;i<=2025;i++)
				DropAnno.Items.Add(new ListItem(i.ToString(),i.ToString()));  
		}

		private void btnsRicerca_Click(object sender, System.EventArgs e)
		{
			Ricerca();
		}
		private void Ricerca()
		{
			LblMessage.Text="";
			DataGridRicerca.CurrentPageIndex =0;
			RicercaPiani();
		}

		private void RicercaPiani()
		{
			//DataGridRicerca.CurrentPageIndex =0;
			DataGridRicerca.Visible=true;
			

			S_ControlsCollection _SCollection = new S_ControlsCollection();		

		

			S_Controls.Collections.S_Object s_p_nomefile = new S_Object();
			s_p_nomefile.ParameterName = "p_nomefile";
			s_p_nomefile.DbType = CustomDBType.VarChar;
			s_p_nomefile.Direction = ParameterDirection.Input;
			s_p_nomefile.Size=225;
			s_p_nomefile.Index = _SCollection.Count;
			if(txtDescrizione.Text=="")
				s_p_nomefile.Value=DBNull.Value;
			else
				s_p_nomefile.Value=txtDescrizione.Text;			
			_SCollection.Add(s_p_nomefile);
		
			S_Controls.Collections.S_Object s_p_mese = new S_Object();
			s_p_mese.ParameterName = "p_mese";
			s_p_mese.DbType = CustomDBType.VarChar;
			s_p_mese.Direction = ParameterDirection.Input;
			s_p_mese.Size=225;
			s_p_mese.Index = _SCollection.Count;
			s_p_mese.Value=cmbsmese.SelectedValue;			
			_SCollection.Add(s_p_mese);
			

			S_Controls.Collections.S_Object s_p_anno = new S_Object();
			s_p_anno.ParameterName = "p_anno";
			s_p_anno.DbType = CustomDBType.VarChar;
			s_p_anno.Direction = ParameterDirection.Input;
			s_p_anno.Size=225;
			s_p_anno.Index = _SCollection.Count;
			s_p_anno.Value=DropAnno.SelectedValue;			
			_SCollection.Add(s_p_anno);

			
			TheSite.Classi.AnagrafeImpianti.AnagrafeDocDWF  _AnagrafeDocDWF = new TheSite.Classi.AnagrafeImpianti.AnagrafeDocDWF(Context.User.Identity.Name);
			DataSet _MyDs = _AnagrafeDocDWF.GetREPORTKPI(_SCollection);
			//DataSet _MyDs = _RecuproDocPmp.GetPiani(_SCollection, cmbsTipoDocumenti.SelectedValue);	

			if (_MyDs.Tables[0].Rows.Count == 0 )
			{
				DataGridRicerca.CurrentPageIndex=0;
				GridTitle1.DescriptionTitle="Nessun dato trovato."; 
			}
			else
			{
				GridTitle1.DescriptionTitle="";
				this.GridTitle1.NumeroRecords = _MyDs.Tables[0].Rows.Count.ToString();	
			}
			this.DataGridRicerca.DataSource = _MyDs.Tables[0];
			this.DataGridRicerca.DataBind();
		}

		
		private void DataGridRicerca_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			DataGridRicerca.CurrentPageIndex = e.NewPageIndex;
			RicercaPiani();
			
		}

		private void DataGridRicerca_ItemCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
		{
			if (e.CommandName=="Download")
			{

				string PathDir=Server.MapPath("../KPI");
				//PathDir=PathDir + @"\Manutenzione Programmata";//Manutenzione Programmata
			    PathDir=PathDir ;//KPI

				string PathDirAnnuale=PathDir ;//Cartella del Piano annuale

				string PathDirMensile=PathDir ;//Cartella de Piano Mensile

				string DestPath="";
				
					
					//PathDirMensile =PathDirMensile + @"\" + e.CommandArgument.ToString().Split(',')[1];//Cartella de Piano Mensile
					//PathDirMensile =PathDirMensile + @"\" + e.Item.Cells[0].ToString();//Cartella de Piano Mensile
					PathDirMensile =PathDirMensile ;//Cartella de Piano Mensile
					DestPath=PathDirMensile;
			
				//string FileName=DestPath + @"\" + e.CommandArgument.ToString().Split(',')[0];
				string FileName=DestPath + @"\" + e.CommandArgument.ToString();
				//string FileName=DestPath + @"\" + e.Item.Cells[0].ToString();
		
				Response.Clear();
				Response.ContentType = "application/xls";
				Response.AddHeader("content-disposition", "inline; filename=" + Path.GetFileName(FileName));
	   
				Response.WriteFile(FileName);
			}
			
			

			
		}

		private void cmdReset_Click(object sender, System.EventArgs e)
		{
			string varapp="";
			if(Request.QueryString["FunId"]!=null)
				varapp="FunId=" + Request.QueryString["FunId"]; 

			if(Request["VarApp"]!=null)
				varapp+="&VarApp=" + Request["VarApp"];
			
			Server.Transfer("SfogliaReportLS.aspx?" + varapp);
		}

		private void DataGridRicerca_ItemDataBound(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
		{
			if (e.Item.ItemType==ListItemType.AlternatingItem ||  e.Item.ItemType==ListItemType.Item)
			{
				
//				string tipo_doc= ((DataRowView)e.Item.DataItem)["tipo_doc"].ToString(); 
				
			}
				//e.Item.DataItem
			}
		}
		
	
	

		

	}


