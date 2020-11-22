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
using ApplicationDataLayer;
using ApplicationDataLayer.DBType;
using MyCollection;
using System.Text;
using System.IO;
using System.Web.Mail;
using System.Configuration;
using ICSharpCode;
using ICSharpCode.SharpZipLib;
using ICSharpCode.SharpZipLib.Zip;
using ExcelPMP;
using PMPExcel;
using System.Threading;

namespace TheSite.GestioneControlliPeriodici
{
	/// <summary>
	/// Descrizione di riepilogo per Categorie.
	/// </summary>
	public class ric_doc_normativi : System.Web.UI.Page
	{
		protected S_Controls.S_Button btnsRicerca;
		protected System.Web.UI.WebControls.Button BtnReset;
		protected Csy.WebControls.DataPanel PanelRicerca;
		protected System.Web.UI.WebControls.DataGrid DataGridRicerca;

		ins_doc_normativi insDocNorm;
		public static int FunId = 0;
		public static string HelpLink = string.Empty;
		MyCollection.clMyCollection _myColl = new clMyCollection();
		protected WebControls.GridTitle GridTitle1;
		protected WebControls.PageTitle PageTitle1;
		protected S_Controls.S_TextBox txtsNomeDoc;
		protected S_Controls.S_TextBox txtsDescDoc;
		protected S_Controls.S_TextBox txtsNormaApp;
		protected S_Controls.S_TextBox txtsVersDoc;
		protected S_Controls.S_TextBox nomeFile;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			Classi.SiteModule _SiteModule = (Classi.SiteModule) HttpContext.Current.Items["SiteModule"];
			this.GridTitle1.hplsNuovo.NavigateUrl = "../GestioneControlliPeriodici/ins_doc_normativi.aspx?ItemID=0&FunId=" + _SiteModule.ModuleId;
			this.GridTitle1.hplsNuovo.Visible = _SiteModule.IsEditable;	

			this.DataGridRicerca.Columns[1].Visible = true;
			this.DataGridRicerca.Columns[2].Visible = _SiteModule.IsEditable;				
						
			FunId = _SiteModule.ModuleId;
			HelpLink = _SiteModule.HelpLink;
			this.PageTitle1.Title = _SiteModule.ModuleTitle;
						
			if (!Page.IsPostBack)
			{	
				this.GridTitle1.hplsNuovo.NavigateUrl = "../GestioneControlliPeriodici/ins_doc_normativi.aspx?ItemID=0&FunId=" + _SiteModule.ModuleId;
				this.GridTitle1.hplsNuovo.Visible = _SiteModule.IsEditable;	

				if(Context.Handler is TheSite.GestioneControlliPeriodici.ins_doc_normativi) 
				{									
					insDocNorm = (TheSite.GestioneControlliPeriodici.ins_doc_normativi) Context.Handler;
					if (insDocNorm!=null)
					{
						_myColl=insDocNorm._Contenitore;
						_myColl.SetValues(this.Page.Controls);
						Ricerca();
					}
					
				}		

			}
		}

		public MyCollection.clMyCollection _Contenitore
		{
			get 
			{
				return _myColl;
			}
		}
        
		private void Ricerca()
		{
			Classi.GestioneCP.DocNormativi docNorm = new TheSite.Classi.GestioneCP.DocNormativi(HttpContext.Current.User.ToString());
/*		
            this.txtsNomeDoc.DBDefaultValue = "%";
			this.txtsDescDoc.DBDefaultValue = "%";
			this.txtsNormaApp.DBDefaultValue = "%";
			this.txtsVersDoc.DBDefaultValue = "%";
			this.nomeFile.DBDefaultValue = "%";
*/
			int index=0;
			
			S_Controls.Collections.S_ControlsCollection _SCollection = new S_Controls.Collections.S_ControlsCollection();
/*			
			S_Object p_id_wr_cp = new S_Object();
			p_id_wr_cp.ParameterName = "id_doc_norm";
			p_id_wr_cp.DbType = CustomDBType.VarChar;
			p_id_wr_cp.Direction = ParameterDirection.Input;
			p_id_wr_cp.Index = index;
			p_id_wr_cp.Size=100;
			p_id_wr_cp.Value = txtsCodice.Text;
			_SCollection.Add(p_id_wr_cp);
*/			
			S_Object p_nome_doc = new S_Object();
			p_nome_doc.ParameterName = "p_nome_doc";
			p_nome_doc.DbType = CustomDBType.VarChar;
			p_nome_doc.Direction = ParameterDirection.Input;
			p_nome_doc.Index = index++;
			p_nome_doc.Size=250;
			p_nome_doc.Value =txtsNomeDoc.Text+"%";
			_SCollection.Add(p_nome_doc);

			S_Object p_desc_doc = new S_Object();
			p_desc_doc.ParameterName = "p_desc_doc";
			p_desc_doc.DbType = CustomDBType.VarChar;
			p_desc_doc.Direction = ParameterDirection.Input;
			p_desc_doc.Index = index++;
			p_desc_doc.Size=250;
			p_desc_doc.Value =txtsDescDoc.Text+"%";
			_SCollection.Add(p_desc_doc);
			
			S_Object p_norma_apparenza = new S_Object();
			p_norma_apparenza.ParameterName = "p_norma_apparenza";
			p_norma_apparenza.DbType = CustomDBType.VarChar;
			p_norma_apparenza.Direction = ParameterDirection.Input;
			p_norma_apparenza.Index = index++;
			p_norma_apparenza.Size=250;
			p_norma_apparenza.Value =txtsNormaApp.Text+"%";
			_SCollection.Add(p_norma_apparenza);
			
			S_Object p_nomefile = new S_Object();
			p_nomefile.ParameterName = "p_nomefile";
			p_nomefile.DbType = CustomDBType.VarChar;
			p_nomefile.Direction = ParameterDirection.Input;
			p_nomefile.Index = index++;
			p_nomefile.Size=250;
			p_nomefile.Value =nomeFile.Text+"%";
			_SCollection.Add(p_nomefile);
			
			S_Object p_versione_doc = new S_Object();
			p_versione_doc.ParameterName = "p_versione_doc";
			p_versione_doc.DbType = CustomDBType.VarChar;
			p_versione_doc.Direction = ParameterDirection.Input;
			p_versione_doc.Index = index++;
			p_versione_doc.Size=250;
			p_versione_doc.Value =txtsVersDoc.Text+"%";
			_SCollection.Add(p_versione_doc);

			S_Controls.Collections.S_Object s_Cursor = new S_Object();
			s_Cursor.ParameterName = "IO_CURSOR";
			s_Cursor.DbType = CustomDBType.Cursor;
			s_Cursor.Direction = ParameterDirection.Output;
			s_Cursor.Index = index++;
			_SCollection.Add(s_Cursor);

			DataSet _MyDs =  docNorm.docNormativiList(_SCollection).Copy();
			this.DataGridRicerca.DataSource = _MyDs.Tables[0];
			if (_MyDs.Tables[0].Rows.Count == 0 )
				DataGridRicerca.CurrentPageIndex=0;
			else
			{
				int Pagina = 0;
				if ((_MyDs.Tables[0].Rows.Count % DataGridRicerca.PageSize) >0)
				{
					Pagina ++;
				}
				if (DataGridRicerca.PageCount != Convert.ToInt16((_MyDs.Tables[0].Rows.Count / DataGridRicerca.PageSize) + Pagina))
				{					
					DataGridRicerca.CurrentPageIndex=0;					
				}
			}


			this.DataGridRicerca.DataBind();					
			this.GridTitle1.NumeroRecords = _MyDs.Tables[0].Rows.Count.ToString();
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
			this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
			this.DataGridRicerca.ItemCommand += new System.Web.UI.WebControls.DataGridCommandEventHandler(this.DataGridRicerca_ItemCommand);
			this.DataGridRicerca.PageIndexChanged += new System.Web.UI.WebControls.DataGridPageChangedEventHandler(this.DataGridRicerca_PageIndexChanged);
			this.DataGridRicerca.ItemDataBound += new System.Web.UI.WebControls.DataGridItemEventHandler(this.DataGridRicerca_ItemDataBound);
			this.DataGridRicerca.SelectedIndexChanged += new System.EventHandler(this.DataGridRicerca_SelectedIndexChanged);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void btnsRicerca_Click(object sender, System.EventArgs e)
		{
			Ricerca();
		}

		private void BtnReset_Click(object sender, System.EventArgs e)
		{
			Response.Redirect("ric_doc_normativi.aspx?FunId=" + FunId);
		}

		private void DataGridRicerca_ItemCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
		{
			if (e.CommandName=="Dettaglio")
			{	
				_myColl.AddControl(this.Page.Controls, ParentType.Page);
				string s_url = e.CommandArgument.ToString();							
				Server.Transfer(s_url);				
			}

			if (e.CommandName=="Download")
			{

				string PathDir=Server.MapPath("../Doc_DB/doc_norm");
								
				string FileName=PathDir + @"\" + e.CommandArgument.ToString().Split(',')[0];
				string FileNameext=e.CommandArgument.ToString().Split(',')[0];
				FileNameext=FileNameext.Split('.')[1];
				Response.Clear();
				switch (FileNameext)
				{
					case "pdf":
						Response.ContentType = "application/pdf";
						break;
					case "htm":
					case "html":
						Response.ContentType = "text/html";
						break;
					case "txt":
						Response.ContentType = "text/plain";
						break;
					case "jpg":
						Response.ContentType = "application/octet-stream";
						break;
					case "doc":
						Response.ContentType = "application/msword";
						break;

					case "xls":
					case "csv":
						Response.ContentType = "application/xls";
						break;
					default:
						Response.ContentType = "application/unknown";
						break;
				}
				
//				Response.ContentType = "application/pdf";
				Response.AddHeader("content-disposition", "inline; filename=" + Path.GetFileName(FileName));
				Response.Flush();
				Response.WriteFile(FileName);
				Response.End();
				//
//				switch (FileNameext)
//				{
//					case "pdf":
//						Response.ContentType = "application/pdf";
//						break;
//					case "htm":
//					case "html":
//						Response.ContentType = "text/html";
//						break;
//					case "txt":
//						Response.ContentType = "text/plain";
//						break;
//					case "doc":
//						Response.ContentType = "application/msword";
//						break;
//					case "xls":
//					case "csv":
//						Response.ContentType = "application/xls";
//						break;
//					default:
//						Response.ContentType = "application/unknown";
//						break;
//				}
//				Response.Flush();
//				Response.WriteFile(file.FullName);
//				Response.End();








			}
		}

		private void DataGridRicerca_ItemDataBound(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
		{
			if((e.Item.ItemType == ListItemType.Item) ||
				(e.Item.ItemType == ListItemType.AlternatingItem))
			{	
				
			
				ImageButton _img2 = (ImageButton) e.Item.Cells[1].FindControl("Imagebutton2");
				_img2.Attributes.Add("title","Modifica");
												
			}
		}

		private void DataGridRicerca_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			DataGridRicerca.CurrentPageIndex = e.NewPageIndex;			
			Ricerca();
		}

		private void DataGridRicerca_SelectedIndexChanged(object sender, System.EventArgs e)
		{
		
		}

	
	}
}