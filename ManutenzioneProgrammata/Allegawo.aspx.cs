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
using ApplicationDataLayer.DBType;
using System.IO;


namespace TheSite.ManutenzioneProgrammata
{
	/// <summary>
	/// Descrizione di riepilogo per Completa_WO.
	/// </summary>
	public class Allegawo : System.Web.UI.Page
	{
		protected WebControls.PageTitle PageTitle1;
		public int rr=0;

		
	
		
		public string Wo=null;
		protected System.Web.UI.WebControls.Button BtUpload;
		protected System.Web.UI.HtmlControls.HtmlInputFile UploadFile;
		protected System.Web.UI.WebControls.Label lblestfile;
		protected System.Web.UI.WebControls.Button Button1;
	
		
		protected System.Web.UI.WebControls.Label lblfileAllegato;
		

		private void Page_Load(object sender, System.EventArgs e)
		{
			
			
			
			Response.Expires = -1;
			Response.Cache.SetNoStore();

			PageTitle1.VisibleLogut=false; 
			if(!IsPostBack)
			{
				Wo=Request.QueryString["wo"];
				lblestfile.Text=Wo;
				
				string mes = "<script language=\"javascript\">\n";			
				mes += "opener.refreshgriglia();";
				mes += "</script>\n";

				this.Page.RegisterStartupScript("agg",mes);
				LoadDocument();
			}

		}

	
	
		/// <summary>
		/// Rimuove gli item con valore a false
		/// che indica quelli che non sono stati ceccati
		/// </summary>
		/// <param name="myList"></param>


		private DataSet UpdateWo(int itemId)
		{
					
			
			Classi.ManProgrammata.CompletaOrdine  _Completa = new TheSite.Classi.ManProgrammata.CompletaOrdine();
			
					
			
			int wo_id =  itemId;	
			S_Controls.Collections.S_ControlsCollection CollezioneControlli = new S_Controls.Collections.S_ControlsCollection();
						
			S_Controls.Collections.S_Object p_wo_id = new S_Object();
			p_wo_id.ParameterName = "p_wo_id";
			p_wo_id.DbType = CustomDBType.Integer;
			p_wo_id.Direction = ParameterDirection.Input;
			p_wo_id.Index = 0;					
			p_wo_id.Value = wo_id;																	
			CollezioneControlli.Add(p_wo_id);
			

			DataSet Ds=_Completa.CompletaWO1(CollezioneControlli);	
									
			return Ds;			
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
			this.BtUpload.Click += new System.EventHandler(this.BtUpload_Click);
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

	

		private void BtUpload_Click(object sender, System.EventArgs e)
		{
			if (UploadFile.PostedFile!=null && UploadFile.PostedFile.FileName!="") 
			{
				string fileName= System.IO.Path.GetFileName(UploadFile.PostedFile.FileName);

				string destDir =Server.MapPath("../Doc_DB/WO");
				//string folderChild=System.IO.Path.Combine(destDir, "WO");
				//if (!Directory.Exists(folderChild))
				//	Directory.CreateDirectory(folderChild);	

				//folderChild=System.IO.Path.Combine(folderChild, lblestfile.Text);
//				if (!Directory.Exists(folderChild))
//					Directory.CreateDirectory(folderChild);

				string destPath  = System.IO.Path.Combine(destDir, fileName);
				UploadFile.PostedFile.SaveAs(destPath);	
				//Salvo il documento nella tabella
				
				SaveDocument(fileName,UploadFile.PostedFile.ContentLength.ToString(),"DOC");
				LoadDocument();
			}
		}
		
		private void SaveDocument(string filename, string dimesione, string tipodoc)
		{
			Classi.ManCorrettiva.ClManCorrettiva _ClManCorrettiva =new TheSite.Classi.ManCorrettiva.ClManCorrettiva(Context.User.Identity.Name);
			
			S_ControlsCollection _SColl = new S_ControlsCollection();
			int result=0;
		
			S_Controls.Collections.S_Object p = new S_Object();
			p.ParameterName = "p_wo_id";
			p.DbType = CustomDBType.VarChar;
			p.Direction = ParameterDirection.Input;
			p.Index = _SColl.Count;
			p.Value = lblestfile.Text;
			_SColl.Add(p);

			p = new S_Object();
			p.ParameterName = "p_name_file";
			p.DbType = CustomDBType.VarChar;
			p.Direction = ParameterDirection.Input;
			p.Index = _SColl.Count;
			p.Value = filename;
			_SColl.Add(p);

			p = new S_Object();
			p.ParameterName = "p_operazione";
			p.DbType = CustomDBType.Integer;
			p.Direction = ParameterDirection.Input;
			p.Index = _SColl.Count;
			p.Value =1;//Inserimento
			_SColl.Add(p);

			result= _ClManCorrettiva.ExecuteUpdateDOCWO(_SColl); 
			
		}
		
		private void LoadDocument()
		{
			Classi.ManCorrettiva.ClManCorrettiva _ClManCorrettiva =new TheSite.Classi.ManCorrettiva.ClManCorrettiva(Context.User.Identity.Name);
			
			
			DataSet _MyDs =  _ClManCorrettiva.GetDocumentazionewo(lblestfile.Text);
			
			if(_MyDs.Tables[0].Rows.Count==0)
			{
				lblfileAllegato.Visible =false;
			}
			else{
				DataRow _Dr = _MyDs.Tables[0].Rows[0];
				lblfileAllegato.Text=_Dr["name_file"].ToString();
			
			}
			

		}

		private void Button1_Click(object sender, System.EventArgs e)
		{
		
		}




		//		private void reloadparent()
		//		{ 
		//			String scriptString = "<script language='JavaScript'>\n";
		//			scriptString += "opener.__doPostBack('DataGridRicerca','');\n";
		//			scriptString += "<";
		//			scriptString += "/";
		//			scriptString += "script>";
		//        
		//			if(!this.IsStartupScriptRegistered("Startup"))
		//				this.RegisterStartupScript("Startup", scriptString);
		//
		//			 
		//		}
	}
}
