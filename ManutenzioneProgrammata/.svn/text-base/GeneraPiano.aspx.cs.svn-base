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
using ExcelPMP;
using PMPExcel;
namespace TheSite.ManutenzioneProgrammata
{
	/// <summary>
	/// Descrizione di riepilogo per GeneraPiano.
	/// </summary>
	public class GeneraPiano : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Label lblMessage;
		protected System.Web.UI.WebControls.DropDownList DrEdifici;
		protected System.Web.UI.WebControls.DropDownList DrTipoDocumenti;
		protected System.Web.UI.WebControls.Label lblAnno;
		protected System.Web.UI.WebControls.DropDownList DropAnno;
		protected System.Web.UI.WebControls.Label lblMese;
		protected System.Web.UI.WebControls.DropDownList DropMese;
		protected System.Web.UI.WebControls.Button BtInvia;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
//			// Inserire qui il codice utente necessario per inizializzare la pagina.
//			if(Request.QueryString["VarApp"]!=null)
//				this.prj =	Request.QueryString["VarApp"]; 
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
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void BtInvia_Click(object sender, System.EventArgs e)
		{
			string tempedi=DrEdifici.Items[DrEdifici.SelectedIndex].Text;
			string[] CodEdi=tempedi.Split('-');
			string CodiceEdificio=CodEdi[0].Trim();
			int Mese=Convert.ToInt32(DropMese.SelectedValue);
			int Anno=Convert.ToInt32(DropAnno.SelectedValue);
			string Out= Server.MapPath("../Doc_DB/TempFile/");
			string FileExcel="";
			string[] dirs=Directory.GetDirectories(Server.MapPath("../Doc_DB/TempFile"));
			try
			{
				foreach(string dir in dirs)
				{
					Directory.Delete(dir,true);
				}
			}
			finally
			{
					
			}

			//Genera il file Xls
			if (DrTipoDocumenti.SelectedValue =="1")
			{
				//CREAZIONE DEL FILE EXCEL PME
				FileExcel=CreaFileXLS(Out,CodiceEdificio,Mese,Anno);
					
			}
			else//Genera il file A8
			{
				FileExcel=CreaFileA8(Out,CodiceEdificio,Mese,Anno);
			}

			Response.Clear();
			Response.ContentType = "application/excel";
			Response.AddHeader("content-disposition", "attachment; filename=" + Path.GetFileName(FileExcel));
			Response.WriteFile(FileExcel);
			Response.Flush();
			File.Delete(FileExcel);
			
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
		private string CreaFileXLS(string Out, string CodEdi,int Mese,int Anno)
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
	}
}
