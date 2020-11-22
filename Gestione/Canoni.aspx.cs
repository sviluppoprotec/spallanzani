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
using S_Controls;
using MyCollection;
using System.Configuration;
using System.Text;
using ApplicationDataLayer;
using ApplicationDataLayer.DBType;
using System.IO;


namespace TheSite.Gestione
{
	/// <summary>
	/// Descrizione di riepilogo per TipoIntervento.
	/// </summary>
	public class Canoni: System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.DataGrid DataGridRicerca;
		public static int FunId = 0;
		public static string HelpLink = string.Empty;
		MyCollection.clMyCollection _myColl = new clMyCollection();
		protected S_Controls.S_TextBox txtsDescrizione;
		protected S_Controls.S_Button btnsRicerca;
		protected Csy.WebControls.DataPanel PanelRicerca;
		protected WebControls.GridTitle GridTitle1;
		protected WebControls.PageTitle PageTitle1;
		protected S_Controls.S_Button BtnReset;
		protected System.Web.UI.WebControls.DropDownList DropMese;
		protected S_Controls.S_ComboBox S_anno;
		
		EditCanoni _fp;
	
		private void Page_Load(object sender, System.EventArgs e)
		{			
						
			Classi.SiteModule _SiteModule = (Classi.SiteModule) HttpContext.Current.Items["SiteModule"];
			this.GridTitle1.hplsNuovo.NavigateUrl = "../Gestione/EditCanoni.aspx?ItemID=0&FunId=" + _SiteModule.ModuleId;
			this.GridTitle1.hplsNuovo.Visible = _SiteModule.IsEditable;	

			this.DataGridRicerca.Columns[1].Visible = true;
			this.DataGridRicerca.Columns[2].Visible = _SiteModule.IsEditable;				
						
			FunId = _SiteModule.ModuleId;
			HelpLink = _SiteModule.HelpLink;
			this.PageTitle1.Title = _SiteModule.ModuleTitle;			
			// Inserire qui il codice utente necessario per inizializzare la pagina.
			if (!Page.IsPostBack)
			{		
				LoadAnno();
				if(Context.Handler is TheSite.Gestione.EditCanoni) 
				{									
					_fp = (TheSite.Gestione.EditCanoni) Context.Handler;
					if (_fp!=null)
					{
						_myColl=_fp._Contenitore;
						_myColl.SetValues(this.Page.Controls);
						Ricerca();
					}					
				}		

			}
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
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		public MyCollection.clMyCollection _Contenitore
		{
			get 
			{
				return _myColl;
			}
		}

		private void LoadAnno()
		{
		
			for(int i=2014;i<=2025;i++)
				S_anno.Items.Add(new ListItem(i.ToString(),i.ToString()));  
		}
		
		private void btnsRicerca_Click(object sender, System.EventArgs e)
		{
			Ricerca();
		}
		

		private void Ricerca()
		{
			Classi.ClassiAnagrafiche.Contab _Contab = new TheSite.Classi.ClassiAnagrafiche.Contab();

			
			this.txtsDescrizione.DBDefaultValue = "%";	
		
			
			this.txtsDescrizione.Text=this.txtsDescrizione.Text.Trim();			

			S_ControlsCollection _SCollection = new S_ControlsCollection();

			
			S_Controls.Collections.S_Object s_descrizione = new S_Object();
			s_descrizione.ParameterName = "p_DESCRIZIONE";
			s_descrizione.DbType = CustomDBType.VarChar;
			s_descrizione.Direction = ParameterDirection.Input;
			s_descrizione.Size=255;
			s_descrizione.Index = _SCollection.Count;;
			s_descrizione.Value =txtsDescrizione.Text;	
			_SCollection.Add(s_descrizione);
			
			S_Controls.Collections.S_Object s_mese = new S_Object();
			s_mese.ParameterName = "p_mese";
			s_mese.DbType = CustomDBType.VarChar;
			s_mese.Direction = ParameterDirection.Input;
			s_mese.Size=10;
			s_mese.Index = _SCollection.Count;;
			s_mese.Value = DropMese.SelectedValue;	
			_SCollection.Add(s_mese);

			S_Controls.Collections.S_Object s_anni = new S_Object();
			s_anni.ParameterName = "p_anno";
			s_anni.DbType = CustomDBType.Integer;
			s_anni.Direction = ParameterDirection.Input;
			s_anni.Size=10;
			s_anni.Index = _SCollection.Count;;
			s_anni.Value = int.Parse(S_anno.SelectedValue);;	
			_SCollection.Add(s_anni);
			

		
			DataSet _MyDs = _Contab.GetData_Canone(_SCollection);
			this.DataGridRicerca.DataSource = _MyDs.Tables[0];
			if (_MyDs.Tables[0].Rows.Count == 0 )
			{
				DataGridRicerca.CurrentPageIndex=0;
			}
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

		private void DataGridRicerca_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			DataGridRicerca.CurrentPageIndex = e.NewPageIndex;			
			Ricerca();
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
				ImageButton _img1 = (ImageButton) e.Item.Cells[1].FindControl("Imagebutton3");
				_img1.Attributes.Add("title","Visualizza");

				ImageButton _img2 = (ImageButton) e.Item.Cells[1].FindControl("Imagebutton2");
				_img2.Attributes.Add("title","Modifica");
						
			}
		}
		
		public void LinkButton1_Click(object sender, CommandEventArgs e)
		{
			//_myColl.AddControl(this.Page.Controls, ParentType.Page);
			//Server.Transfer("CompletamentoMP1.aspx?id_wo=" + e.CommandArgument+"&FunId="+FunId); 
		
			string PathDir=Server.MapPath("../Doc_DB");
			PathDir=PathDir + @"\canoni" ;			

			string DestPath="";			
					
			DestPath =PathDir + @"\" + e.CommandArgument.ToString();//Cartella de Piano Mensile
			
			//string FileName=DestPath + @"\" + e.CommandArgument.ToString();
					
			Response.Clear();
			Response.ContentType = "application/xls";
			Response.AddHeader("content-disposition", "inline; filename=" + Path.GetFileName(DestPath));
	   
			Response.WriteFile(DestPath);

		
		
		}



		private void BtnReset_Click(object sender, System.EventArgs e)
		{
			Response.Redirect("Canoni.aspx?FunId=" + FunId);
		}

		
	}
}
