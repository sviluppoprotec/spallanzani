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
using TheSite.Classi.ClassiDettaglio;
using MyCollection; 
namespace TheSite.AnagrafeImpianti
{
	/// <summary>
	/// Descrizione di riepilogo per NavigazioneAppDEMO.
	/// </summary>
	public class NavigazioneAppDEMO : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.DataGrid MyDataGrid1;
		protected WebControls.GridTitle GridTitle1; 
		protected WebControls.PageTitle PageTitle1;

		public static int FunId = 0;				
		public static string HelpLink = string.Empty;
		public int s_stanza=0;
		public int s_bl_id=0;
		public int s_piani=0;
		public string TitoloPiano;
		public string TitoloStanza;
		TheSite.AnagrafeImpianti.DataRoom _fp;
		MyCollection.clMyCollection _myColl = new MyCollection.clMyCollection();
		S_Controls.Collections.S_ControlsCollection _SCollection = new S_Controls.Collections.S_ControlsCollection();
		protected System.Web.UI.WebControls.Label lblEdificio;
		protected System.Web.UI.WebControls.Label lblNrstanza;
		protected System.Web.UI.WebControls.Label lblDescstanza;
		protected System.Web.UI.WebControls.Label lblPiano;
		protected System.Web.UI.WebControls.Label lblArea;
		protected System.Web.UI.WebControls.Label lblAltezza;
		protected System.Web.UI.WebControls.Label lblCategoria;
		protected System.Web.UI.WebControls.Label lblDestuso;
		protected System.Web.UI.WebControls.Label lblPavimento;
		protected System.Web.UI.WebControls.Label lblPareti;
		protected System.Web.UI.WebControls.Label lblSoffitto;
		public string bl_str ="";
		public string fl_str ="";
		public string rm_str ="";
		Classi.AnagrafeImpianti.DataRoom _DataRoom = new TheSite.Classi.AnagrafeImpianti.DataRoom();

		public MyCollection.clMyCollection _Contenitore
		{ 
			get 
			{
				if(this.ViewState["mioContenitore"]!=null)
					return (MyCollection.clMyCollection)this.ViewState["mioContenitore"];
				else
					return new MyCollection.clMyCollection();
			}
		}

		private void Page_Load(object sender, System.EventArgs e)
		{
			
			Classi.SiteModule _SiteModule = (Classi.SiteModule) HttpContext.Current.Items["SiteModule"];

			FunId = int.Parse(Request["FunId"]);
			HelpLink = _SiteModule.HelpLink;
//   DIACHIARO PRIMA LE VARIABILI INT

//   get da request le variabili stringa RM001, PTE,CP001

//   POI LE RICERCO IN DB E LE TRASFORMO IN INT (ID)

    //  QUINDI VALORIZZO LE VARIABILI USATE QUI: s_bl_id    s_piani    s_stanza

//------------------------------
//	bl_str ="";
//		fl_str ="";
//		 rm_str ="";
//			
//			if (Request["var_stanza"]== null || Request["var_stanza"]=="" ||Request["var_stanza"]==string.Empty)
//			{
//				s_stanza=0;
//				TitoloPiano = Request["TitoloPiano"].ToString();
//				PageTitle1.Title = "Apparecchiature del Piano " + TitoloPiano;
//			}
//			else
//			{}

			if (Request["rm"]!= null&&Request["rm"]!=string.Empty&&Request["rm"]!="")
			{
				S_Controls.Collections.S_Object s_p_rm = new S_Controls.Collections.S_Object();
				s_p_rm.ParameterName = "p_rm";
				s_p_rm.DbType = ApplicationDataLayer.DBType.CustomDBType.VarChar;
				s_p_rm.Direction = ParameterDirection.Input;
				s_p_rm.Size=20;
				s_p_rm.Index = 1;
				s_p_rm.Value = Request["rm"].ToString();
				_SCollection.Add(s_p_rm);

				S_Controls.Collections.S_Object s_p_fl = new S_Controls.Collections.S_Object();
				s_p_fl.ParameterName = "p_fl";
				s_p_fl.DbType = ApplicationDataLayer.DBType.CustomDBType.VarChar;
				s_p_fl.Direction = ParameterDirection.Input;
				s_p_fl.Size=20;
				s_p_fl.Index = 2;
				s_p_fl.Value = Request["fl"].ToString();
				_SCollection.Add(s_p_fl);
				
				S_Controls.Collections.S_Object s_p_bl = new S_Controls.Collections.S_Object();
				s_p_bl.ParameterName = "p_bl";
				s_p_bl.DbType = ApplicationDataLayer.DBType.CustomDBType.VarChar;
				s_p_bl.Direction = ParameterDirection.Input;
				s_p_bl.Size=20;
				s_p_bl.Index = 3;
				s_p_bl.Value =Request["bl"].ToString();;
				_SCollection.Add(s_p_bl);

				DataSet Ds1= _DataRoom.DatiTestata_STR(_SCollection);
				DataRow _Dr1 = Ds1.Tables[0].Rows[0];				
				if (_Dr1["id_rm"] != DBNull.Value)
				s_stanza=(int) int.Parse(_Dr1["id_rm"].ToString());

				if (_Dr1["id_piani"] != DBNull.Value)
					s_piani=(int) int.Parse(_Dr1["id_piani"].ToString());	

				if (_Dr1["id_bl"] != DBNull.Value)
					s_bl_id=(int) int.Parse(_Dr1["id_bl"].ToString());	
				
			}
			if (s_piani==0)			
			s_piani = (int) int.Parse(Request["var_piani"]);
			if (s_bl_id==0)		
			s_bl_id = (int) int.Parse(Request["var_bl_id"]);
			
			if ((Request["var_stanza"]== null || Request["var_stanza"]=="" ||Request["var_stanza"]==string.Empty)
				&&(Request["rm"]==null||Request["rm"]==""||Request["rm"]==string.Empty)
				)
			{
				s_stanza=0;
				//TitoloPiano = //Request["fl"].ToString();					
					//Request["TitoloPiano"].ToString();
				PageTitle1.Title = "Apparecchiature del Piano " ;//+ TitoloPiano;
			}
			else
			{
				if (s_stanza==0)
				s_stanza= (int) int.Parse(Request["var_stanza"]);
				

				//TitoloStanza = Request["TitoloStanza"].ToString();
				PageTitle1.Title = "Apparecchiature della Stanza ";//+ TitoloStanza;
				_SCollection.Clear();
				
				S_Controls.Collections.S_Object s_p_stanza = new S_Controls.Collections.S_Object();
				s_p_stanza.ParameterName = "p_stanza";
				s_p_stanza.DbType = ApplicationDataLayer.DBType.CustomDBType.Integer;
				s_p_stanza.Direction = ParameterDirection.Input;
				s_p_stanza.Size=20;
				s_p_stanza.Index = 1;
				s_p_stanza.Value = s_stanza;
				_SCollection.Add(s_p_stanza);
				
				DataSet Ds= _DataRoom.DatiTestata(_SCollection);
				if (Ds.Tables[0].Rows.Count == 1)
				{
					DataRow _Dr = Ds.Tables[0].Rows[0];
					if (_Dr["altezza"] != DBNull.Value)
						this.lblAltezza.Text =_Dr["altezza"].ToString();
					if (_Dr["area"] != DBNull.Value)
						this.lblArea.Text =_Dr["area"].ToString();
					if (_Dr["categoria"] != DBNull.Value)
						this.lblCategoria.Text =_Dr["categoria"].ToString();
					if (_Dr["Descstanza"] != DBNull.Value)
						this.lblDescstanza.Text =_Dr["Descstanza"].ToString();					
					if (_Dr["Destuso"] != DBNull.Value)
						this.lblDestuso.Text =_Dr["Destuso"].ToString();
					if (_Dr["Edificio"] != DBNull.Value)
						this.lblEdificio.Text =_Dr["Edificio"].ToString();
					if (_Dr["Nrstanza"] != DBNull.Value)
						this.lblNrstanza.Text =_Dr["Nrstanza"].ToString();
					if (_Dr["pareti"] != DBNull.Value)
						this.lblPareti.Text =_Dr["pareti"].ToString();
					if (_Dr["pavimento"] != DBNull.Value)
						this.lblPavimento.Text =_Dr["pavimento"].ToString();
					if (_Dr["Piano"] != DBNull.Value)
						this.lblPiano.Text =_Dr["Piano"].ToString();
					if (_Dr["soffitto"] != DBNull.Value)
						this.lblSoffitto.Text =_Dr["soffitto"].ToString();
				}
			
				_SCollection.Clear();
			}				
			

			if (!IsPostBack) 
			{	
				Execute();
				GridTitle1.Visible = true;
								
				if(Context.Handler is TheSite.AnagrafeImpianti.DataRoom) 
				{
					_fp = (TheSite.AnagrafeImpianti.DataRoom) Context.Handler;
					this.ViewState.Add("mioContenitore",_fp._Contenitore); 
				}	

			}
			
			GridTitle1.hplsNuovo.Visible=false;

			///DataRoom.aspx?id_edificio_cad=201&id_piano_cad=1&FromWebCad=true
			if (Request.QueryString["FromWebCad"]!=null || Request.QueryString["FromWebCad"].ToString()!=String.Empty)
			{
				if(Request.QueryString["WebCadIndietro"]!=null)
				{
					//BntIndietro.Visible=true;
				}
				PageTitle1.VisibleLogut = false;
			}
			else
			{
				PageTitle1.VisibleLogut=true;
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
			this.MyDataGrid1.PageIndexChanged += new System.Web.UI.WebControls.DataGridPageChangedEventHandler(this.MyDataGrid1_PageIndexChanged);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void setvisiblecontrol(bool Visibile)
		{
			GridTitle1.VisibleRecord=Visibile;
			GridTitle1.hplsNuovo.Visible =false;
			MyDataGrid1.Visible = Visibile;
		}

		private void Execute()
		{
			_SCollection.Clear();
			
			S_Controls.Collections.S_Object s_p_bl_id = new S_Controls.Collections.S_Object();
			s_p_bl_id.ParameterName = "p_Id_bl";
			s_p_bl_id.DbType = ApplicationDataLayer.DBType.CustomDBType.Integer;
			s_p_bl_id.Direction = ParameterDirection.Input;
			s_p_bl_id.Size =50;
			s_p_bl_id.Index = 0;
			s_p_bl_id.Value = s_bl_id;
			_SCollection.Add(s_p_bl_id);

			S_Controls.Collections.S_Object s_p_piani = new S_Controls.Collections.S_Object();
			s_p_piani.ParameterName = "p_piani";
			s_p_piani.DbType = ApplicationDataLayer.DBType.CustomDBType.Integer;
			s_p_piani.Direction = ParameterDirection.Input;
			s_p_piani.Size=20;
			s_p_piani.Index = 1;
			s_p_piani.Value = s_piani;
			_SCollection.Add(s_p_piani);

			S_Controls.Collections.S_Object s_p_stanza = new S_Controls.Collections.S_Object();
			s_p_stanza.ParameterName = "p_stanza";
			s_p_stanza.DbType = ApplicationDataLayer.DBType.CustomDBType.Integer;
			s_p_stanza.Direction = ParameterDirection.Input;
			s_p_stanza.Size=20;
			s_p_stanza.Index = 2;
			s_p_stanza.Value = s_stanza;
			_SCollection.Add(s_p_stanza);

			DataSet Ds=_DataRoom.RicercaApparecchiaturaPerStanza(_SCollection);
			
			GridTitle1.Visible = true;
			if (Ds.Tables[0].Rows.Count > 0) 
			{
				setvisiblecontrol(true);
				GridTitle1.DescriptionTitle="";
				GridTitle1.NumeroRecords =Ds.Tables[0].Rows.Count.ToString();
				MyDataGrid1.DataSource= Ds.Tables[0];
				MyDataGrid1.DataBind();
			}
			else
			{
				GridTitle1.DescriptionTitle="Nessun dato trovato.";
				setvisiblecontrol(false);
				GridTitle1.Visible=true;
			}
		}

		private void MyDataGrid1_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			MyDataGrid1.CurrentPageIndex=e.NewPageIndex;
			Execute();
		}

//		private void BntIndietro_Click(object sender, System.EventArgs e)
//		{
//			Server.Transfer("DataRoom.aspx?FunId="+FunId+"&FromWebCad="+Request["FromWebCad"]);
//		}

	}
}
