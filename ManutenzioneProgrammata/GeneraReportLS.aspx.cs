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
using System.IO;
using ICSharpCode;
using ICSharpCode.SharpZipLib;
using ICSharpCode.SharpZipLib.Zip;
using ApplicationDataLayer;
using ApplicationDataLayer.DBType;
using ApplicationDataLayer.Collections;
using S_Controls.Collections;
using System.Reflection; 



namespace TheSite.ManutenzioneProgrammata
{
	/// <summary>
	/// Descrizione di riepilogo per GeneraReportLS.
	/// </summary>
	public class GeneraReportLS : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Label lblMessage;
		protected System.Web.UI.WebControls.Label lblAnno;
		protected System.Web.UI.WebControls.DropDownList DropAnno;
		protected System.Web.UI.WebControls.Label lblMese;
		protected System.Web.UI.WebControls.DropDownList DropMese;
		protected System.Web.UI.HtmlControls.HtmlInputFile Uploader;
		protected System.Web.UI.WebControls.Button BtInvia;
		protected System.Web.UI.WebControls.Label Lblins;
		protected WebControls.PageTitle	PageTitle1;
		public string origineDir=@System.Configuration.ConfigurationSettings.AppSettings["DIRKPIMASTER"].ToString();

		public string destDir1=@System.Configuration.ConfigurationSettings.AppSettings["DIRKPIDEST"].ToString();

		protected System.Web.UI.WebControls.DropDownList DropFile;
		protected System.Web.UI.WebControls.Button Button1;

		public string destDirFile=@System.Configuration.ConfigurationSettings.AppSettings["DIRKPIMASTERFILE"].ToString();
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			Lblins.Text="";

			Classi.SiteModule _SiteModule = (Classi.SiteModule) HttpContext.Current.Items["SiteModule"];
			
			this.PageTitle1.Title = _SiteModule.ModuleTitle;	
			lblMessage.Text="";

			if (!IsPostBack)
				LoadAnno();
			
				
		}
		private void LoadAnno()
		{
		
			for(int i=2014;i<=2025;i++)
				DropAnno.Items.Add(new ListItem(i.ToString(),i.ToString()));  
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
			this.BtInvia.Click += new System.EventHandler(this.BtInvia_Click);
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void BtInvia_Click(object sender, System.EventArgs e)
		{
			try
			{
				string url = System.Configuration.ConfigurationSettings.AppSettings["linkReportKPI"];
				string url_tot = string.Format("{0}?Mese={1}&Anno={2}",
					url,DropMese.SelectedValue.ToString(),DropAnno.SelectedValue.ToString());// "http://pempr1.cofasir.it/GetPL.aspx?RdLId="+wr_id
				//string url_tot = string.Format("{0}?RdLId={1}",url,wr_id);
				//url_tot ="http://pt.cofasir.it/GetPL1.aspx?RdLId=464";
				//http://localhost:58835/GetKPIPUI.aspx?Mese=01&Anno=2015
				Response.Redirect(url_tot);
			
			}
				
			catch (Exception ex)
			{
				string results =  ex.Message.ToString().ToUpper();
				//string result="Processo non andato a buon fine"; 
				String scriptString = "<script language=\"JavaScript\">alert(\"" + results + "\");<";
				scriptString += "/";
				scriptString += "script>";
				this.RegisterStartupScript("Startup1", scriptString);
			
			}		
			
			
		}
						
		
		private void InsdbReport(string fileNamerin, int conto )
		{
			TheSite.Classi.AnagrafeImpianti.AnagrafeDocDWF  _AnagrafeDocDWF = new TheSite.Classi.AnagrafeImpianti.AnagrafeDocDWF(Context.User.Identity.Name);
			S_ControlsCollection _SColl = new S_ControlsCollection();

			S_Controls.Collections.S_Object s_p_nomefile = new S_Object();
			s_p_nomefile.ParameterName = "p_nomefile";
			s_p_nomefile.DbType = CustomDBType.VarChar;
			s_p_nomefile.Direction = ParameterDirection.Input;
			s_p_nomefile.Index =_SColl.Count;
			s_p_nomefile.Size =255;
			s_p_nomefile.Value = fileNamerin;
			_SColl.Add(s_p_nomefile);

			S_Controls.Collections.S_Object s_p_revisione = new S_Object();
			s_p_revisione.ParameterName = "p_revisione";
			s_p_revisione.DbType = CustomDBType.VarChar;
			s_p_revisione.Direction = ParameterDirection.Input;
			s_p_revisione.Index =_SColl.Count;
			s_p_revisione.Size =100;
			s_p_revisione.Value = conto.ToString();
			_SColl.Add(s_p_revisione);

			S_Controls.Collections.S_Object s_p_mese = new S_Object();
			s_p_mese.ParameterName = "p_mese";
			s_p_mese.DbType = CustomDBType.VarChar;
			s_p_mese.Direction = ParameterDirection.Input;
			s_p_mese.Index =_SColl.Count;
			s_p_mese.Size =4;
			s_p_mese.Value = DropMese.SelectedValue;
			_SColl.Add(s_p_mese);

			S_Controls.Collections.S_Object s_p_anno = new S_Object();
			s_p_anno.ParameterName = "p_anno";
			s_p_anno.DbType = CustomDBType.VarChar;
			s_p_anno.Direction = ParameterDirection.Input;
			s_p_anno.Index =_SColl.Count;
			s_p_anno.Size =4;
			s_p_anno.Value = DropAnno.SelectedValue;
			_SColl.Add(s_p_anno);
							
			S_Controls.Collections.S_Object s_p_verfile = new S_Object();
			s_p_verfile.ParameterName = "p_verfile";
			s_p_verfile.DbType = CustomDBType.VarChar;
			s_p_verfile.Direction = ParameterDirection.Input;
			s_p_verfile.Index =_SColl.Count;
			s_p_verfile.Size =4;
			s_p_verfile.Value = DropFile.SelectedValue;
			_SColl.Add(s_p_verfile);
							
			int result= _AnagrafeDocDWF.INSREPORTKPI(_SColl);
			Lblins.Text="Inserimento file: "+fileNamerin;
		}

		#region Crea il File EXCEL A8
		/// <summary>
		/// Crea il File EXCEL A8
		/// </summary>
		/// <param name="Out">Path di destinazione del file creato</param>
		/// <param name="CodEdi">Codice Edificio</param>
		/// <param name="Mese">Mese di creazione del Piano</param>
		/// <param name="Anno">Anno di creazione del Piano</param>
		/// <returns>Nome del File Excel creato comprensivo di percorso fisico</returns>
		private string CreaFileA8(string Out, string CodEdi,int Mese,int Anno)
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

		private void Button1_Click(object sender, System.EventArgs e)
		{
			TheSite.Classi.AnagrafeImpianti.AnagrafeDocDWF  _AnagrafeDocDWF = new TheSite.Classi.AnagrafeImpianti.AnagrafeDocDWF(Context.User.Identity.Name);
			int versione =_AnagrafeDocDWF.VERSIONEREPORTKPI(DropMese.SelectedValue.ToString(),DropAnno.SelectedValue.ToString());
			int conto=_AnagrafeDocDWF.CONTOREPORTKPI(DropMese.SelectedValue.ToString(),DropAnno.SelectedValue.ToString());
			
			if (versione==0) // versione del file non definitiva
			{
				//string finenomefile="";		
				
				//				if (conto>=1)
				//				{finenomefile="_IP_R"+conto.ToString() +".xls";}
				//				
				//				else
				//				{finenomefile="_IP_R0.xls";}	
			
				//******inserimento codice alternativo
				//string fileNamerin="";
				//string exte="";
				//string OriginePath="";
				//string destPathstomove="";
				
				//				string fileName=string.Empty;

				try
				{
				
					//fileName= System.IO.Path.GetFileName(FilePreventivo.PostedFile.FileName);
					//fileName= System.IO.Path.GetFileName(@"C:\Inetpub\wwwroot\ifo\MasterExcel\ReportKPI.xls");
					if (Uploader.PostedFile!=null && Uploader.PostedFile.FileName!="") 
					{	
						string fileNameupload= System.IO.Path.GetFileName(Uploader.PostedFile.FileName);

						string destDirUpload =Server.MapPath("../KPI");

						string destPathUpload  = System.IO.Path.Combine(destDirUpload, fileNameupload);
						Uploader.PostedFile.SaveAs(destPathUpload);	
						//
						//								
						//						string FileInsert=destDir1 + @"\" + System.IO.Path.GetFileName(Uploader.PostedFile.FileName);
						//						//Uploader.PostedFile.SaveAs(FileInsert);
						//						fileName= System.IO.Path.GetFileName(FileInsert);
						//						OriginePath  = System.IO.Path.Combine(destDir1, fileName);
						//						destPathstomove= System.IO.Path.Combine(destDir1,DropAnno.SelectedValue.ToString()+"_"+DropMese.SelectedValue.ToString()+finenomefile);
						//						fileNamerin=Path.GetFileName(destPathstomove);
						//						File.Copy(OriginePath,destPathstomove);
						//						File.Delete(OriginePath);
						InsdbReport(fileNameupload,conto);
					}
					
				
				}//chiusura del try 
				
				catch (Exception ex)
				{
					string results =  ex.Message.ToString().ToUpper();
					//string result="Processo non andato a buon fine"; 
					String scriptString = "<script language=\"JavaScript\">alert(\"" + results + "\");<";
					scriptString += "/";
					scriptString += "script>";
					this.RegisterStartupScript("Startup1", scriptString);
					lblMessage.Text="Inserimento File non terminato";
				}		
			
			}
			else
			{
				string uscita =  "Il Report per il mese di "+DropMese.SelectedValue+" anno "+DropAnno.SelectedValue + " è stato generato in versione definifitiva. Impossibile generare un nuovo report."; 
				String scriptString = "<script language=\"JavaScript\">alert(\"" + uscita + "\");<";
				scriptString += "/";
				scriptString += "script>";
				this.RegisterStartupScript("Startup1", scriptString);
			}
		}
	}
}
