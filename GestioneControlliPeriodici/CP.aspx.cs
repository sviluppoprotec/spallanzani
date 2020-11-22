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

namespace TheSite.GestioneControlliPeriodici
{
	/// <summary>
	/// Descrizione di riepilogo per Categorie.
	/// </summary>
	public class CP : System.Web.UI.Page
	{
		protected S_Controls.S_TextBox txtsCodice;
		protected S_Controls.S_TextBox txtsDescrizione;
		protected S_Controls.S_Button btnsRicerca;
		protected System.Web.UI.WebControls.Button BtnReset;
		protected Csy.WebControls.DataPanel PanelRicerca;
		protected System.Web.UI.WebControls.DataGrid DataGridRicerca;
		protected WebControls.RicercaModulo RicercaModulo1;
		
		INSCP _fp;
		public static int FunId = 0;
		public static string HelpLink = string.Empty;
		MyCollection.clMyCollection _myColl = new clMyCollection();
		protected WebControls.GridTitle GridTitle1;
		protected WebControls.PageTitle PageTitle1;
		protected WebControls.CalendarPicker CalendarPicker1;
		protected System.Web.UI.WebControls.DropDownList ListCompl;
		protected S_Controls.S_TextBox nomeFile;
		protected WebControls.CalendarPicker CalendarPicker2;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			Classi.SiteModule _SiteModule = (Classi.SiteModule) HttpContext.Current.Items["SiteModule"];
			this.GridTitle1.hplsNuovo.NavigateUrl = "../GestioneControlliPeriodici/INSCP.aspx?ItemID=0&FunId=" + _SiteModule.ModuleId;
			this.GridTitle1.hplsNuovo.Visible = _SiteModule.IsEditable;	

			this.DataGridRicerca.Columns[1].Visible = true;
			this.DataGridRicerca.Columns[2].Visible = _SiteModule.IsEditable;				
						
			FunId = _SiteModule.ModuleId;
			HelpLink = _SiteModule.HelpLink;
			this.PageTitle1.Title = _SiteModule.ModuleTitle;
						
			if (!Page.IsPostBack)
			{	
				this.GridTitle1.hplsNuovo.NavigateUrl = "../GestioneControlliPeriodici/INSCP.aspx?ItemID=0&FunId=" + _SiteModule.ModuleId;
				this.GridTitle1.hplsNuovo.Visible = _SiteModule.IsEditable;	

				//CalendarPicker1.Datazione.Text=DateTime.Now.ToShortDateString();
				//CalendarPicker2.Datazione.Text=DateTime.Now.ToShortDateString();
				//LoadTipoCP();
				if(Context.Handler is TheSite.GestioneControlliPeriodici.INSCP) 
				{									
					_fp = (TheSite.GestioneControlliPeriodici.INSCP) Context.Handler;
					if (_fp!=null)
					{
						_myColl=_fp._Contenitore;
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
        
//		private void LoadTipoCP()
//		{
//			this.cmbs_TipoCP.Items.Clear();
//		
//			Classi.GestioneCP.CompletamentoCP _CompletamentoCP = new TheSite.Classi.GestioneCP.CompletamentoCP(Context.User.Identity.Name);
//				
//			DataSet _MyDs = _CompletamentoCP.GetDataTipoCP().Copy();
//			  
//			if (_MyDs.Tables[0].Rows.Count > 0)
//			{				
//				this.cmbs_TipoCP.DataSource = Classi.GestoreDropDownList.ItemBlankDataSource(
//					_MyDs.Tables[0], "descrizione","id", "- Selezionare un Tipo Controllo Periodico-", "0");
//				this.cmbs_TipoCP.DataTextField = "descrizione";
//				this.cmbs_TipoCP.DataValueField = "id";
//				this.cmbs_TipoCP.DataBind();
//			}
//			else
//			{
//				string s_Messagggio = "- Nessuna Frequenza -";
//				this.cmbs_TipoCP.Items.Add(Classi.GestoreDropDownList.ItemMessaggio(s_Messagggio,  String.Empty));
//			}
//		}
		
		private void Ricerca()
		{
			Classi.GestioneCP.SfogliaRdlOdl SfogliaRdlOdl = new TheSite.Classi.GestioneCP.SfogliaRdlOdl(HttpContext.Current.User.ToString());
		
			//			DataSet _MyDs = _GCP.GETWRCP_SF(itemId).Copy();	
			
			//Classi.ClassiAnagrafiche.DestUso  _DestUso = new TheSite.Classi.ClassiAnagrafiche.DestUso();
			
			this.txtsCodice.DBDefaultValue = "%";
			this.txtsDescrizione.DBDefaultValue = "%";
			this.txtsCodice.Text=this.txtsCodice.Text.Trim();
			this.txtsDescrizione.Text=this.txtsDescrizione.Text.Trim();
			
			int index=0;
			
			S_Controls.Collections.S_ControlsCollection _SCollection = new S_Controls.Collections.S_ControlsCollection();
			
			S_Object p_id_wr_cp = new S_Object();
			p_id_wr_cp.ParameterName = "p_id_wr_cp";
			p_id_wr_cp.DbType = CustomDBType.VarChar;
			p_id_wr_cp.Direction = ParameterDirection.Input;
			p_id_wr_cp.Index = index;
			p_id_wr_cp.Size=100;
			p_id_wr_cp.Value = txtsCodice.Text;
			_SCollection.Add(p_id_wr_cp);
			
			S_Object p_descrizione = new S_Object();
			p_descrizione.ParameterName = "p_descrizione";
			p_descrizione.DbType = CustomDBType.VarChar;
			p_descrizione.Direction = ParameterDirection.Input;
			p_descrizione.Index = index++;
			p_descrizione.Size=250;
			p_descrizione.Value =txtsDescrizione.Text;
			_SCollection.Add(p_descrizione);
			
			S_Object p_data_inizio = new S_Object();
			p_data_inizio.ParameterName = "p_data_inizio";
			p_data_inizio.DbType = CustomDBType.VarChar;
			p_data_inizio.Direction = ParameterDirection.Input;
			p_data_inizio.Index = index++;
			p_data_inizio.Size=255;
			p_data_inizio.Value = CalendarPicker1.Datazione.Text;
			_SCollection.Add(p_data_inizio);
			
			S_Object p_data_fine = new S_Object();
			p_data_fine.ParameterName = "p_data_fine";
			p_data_fine.DbType = CustomDBType.VarChar;
			p_data_fine.Direction = ParameterDirection.Input;
			p_data_fine.Index = index++;
			p_data_fine.Size=255;
			p_data_fine.Value = CalendarPicker2.Datazione.Text;
			_SCollection.Add(p_data_fine);
			
			S_Object p_completato = new S_Object();
			p_completato.ParameterName = "p_completato";
			p_completato.DbType = CustomDBType.Integer;
			p_completato.Direction = ParameterDirection.Input;
			p_completato.Size=225;
			p_completato.Index = index++;
			p_completato.Value=  ListCompl.SelectedValue;		
			_SCollection.Add(p_completato);

			

			S_Controls.Collections.S_Object s_CurrentUser = new S_Object();
			s_CurrentUser.ParameterName = "p_username";
			s_CurrentUser.DbType = CustomDBType.VarChar;
			s_CurrentUser.Direction = ParameterDirection.Input;
			s_CurrentUser.Index = index++;
			s_CurrentUser.Value = System.Web.HttpContext.Current.User.Identity.Name;
			_SCollection.Add(s_CurrentUser);	

			S_Object p_nomeFile = new S_Object();
			p_nomeFile.ParameterName = "p_nomeFile";
			p_nomeFile.DbType = CustomDBType.VarChar;
			p_nomeFile.Direction = ParameterDirection.Input;
			p_nomeFile.Index = index++;
			p_nomeFile.Size=250;
			p_nomeFile.Value =nomeFile.Text;
			_SCollection.Add(p_nomeFile);

			S_Controls.Collections.S_Object s_p_ID_BL = new S_Controls.Collections.S_Object();
			s_p_ID_BL.ParameterName = "p_ID_BL";
			s_p_ID_BL.DbType = ApplicationDataLayer.DBType.CustomDBType.Integer;
			s_p_ID_BL.Direction = ParameterDirection.Input;
			s_p_ID_BL.Size =50;
			s_p_ID_BL.Index = index++;
			s_p_ID_BL.Value = (this.RicercaModulo1._txthidbl.Value=="")?0:Int32.Parse(this.RicercaModulo1._txthidbl.Value);
			_SCollection.Add(s_p_ID_BL);
			
			
//			S_Controls.Collections.S_Object s_p_BL_ID = new S_Controls.Collections.S_Object();
//			s_p_BL_ID.ParameterName = "p_BL_ID";
//			s_p_BL_ID.DbType = ApplicationDataLayer.DBType.CustomDBType.VarChar;
//			s_p_BL_ID.Direction = ParameterDirection.Input;
//			s_p_BL_ID.Size =50;
//			s_p_BL_ID.Index = index++;
//			s_p_BL_ID.Value = (RicercaModulo1.TxtCodice.Text=="")?"0":RicercaModulo1.TxtCodice.Text;
//			_SCollection.Add(s_p_BL_ID);

			S_Controls.Collections.S_Object s_Cursor = new S_Object();
			s_Cursor.ParameterName = "IO_CURSOR";
			s_Cursor.DbType = CustomDBType.Cursor;
			s_Cursor.Direction = ParameterDirection.Output;
			s_Cursor.Index = index++;
			_SCollection.Add(s_Cursor);


			DataSet _MyDs =  SfogliaRdlOdl.GETWRCP_SF_BL(_SCollection).Copy();
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
			Response.Redirect("CP.aspx?FunId=" + FunId);
		}

		private void DataGridRicerca_ItemCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
		{
			if (e.CommandName=="Dettaglio")
			{	
				_myColl.AddControl(this.Page.Controls, ParentType.Page);
				string s_url = e.CommandArgument.ToString();							
				Server.Transfer(s_url);				
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