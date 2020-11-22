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
using MyCollection;

namespace TheSite.ManutenzioneProgrammata
{
	/// <summary>
	/// Descrizione di riepilogo per SfogliaMP.
	/// </summary>
	public class SfogliaMP : System.Web.UI.Page
	{
		protected S_Controls.S_ComboBox cmbsServizio;
		protected S_Controls.S_ComboBox cmbsStdApparecchiature;
		protected WebControls.RicercaModulo RicercaModulo1;
		protected WebControls.PageTitle	PageTitle1;
		protected WebControls.CodiceApparecchiature CodiceApparecchiature1;
		public static int FunId = 0;
		protected Csy.WebControls.DataPanel DataPanel1;
		protected S_Controls.S_Button btRicerca;
		protected S_Controls.S_Button btReset;
		public static string HelpLink = string.Empty;			
		
		MyCollection.clMyCollection _myColl = new MyCollection.clMyCollection();
		
		protected WebControls.CalendarPicker CalendarPicker1;
		protected WebControls.CalendarPicker CalendarPicker2;

		//public delegate void xx(object sender, CommandEventArgs e);
		//public event xx xx2;

		public MyCollection.clMyCollection _Contenitore
		{
			get {return _myColl;}
		}

		private void Page_Load(object sender, System.EventArgs e)
		{
					
			Classi.SiteModule _SiteModule = (Classi.SiteModule) HttpContext.Current.Items["SiteModule"];

			//			this.DataGrid1.Columns[1].Visible = _SiteModule.IsEditable;												
		

			FunId = _SiteModule.ModuleId;
			HelpLink = _SiteModule.HelpLink;
			this.PageTitle1.Title = _SiteModule.ModuleTitle;
			
			

			
			RicercaModulo1.DelegateCodiceEdificio1 = new TheSite.WebControls.DelegateCodiceEdificio(this.BindServizi);

			///TODO: Impostare tali parametri per impostare l'user control Codice apparecchiature
			///Ogni qualvolta lo si deve implementare in una pagina.
			///Tali parametri verranno utilizzati dal controllo per passare i valori in query string
			/// Imposto il nome della combo Apparecchiature
			CodiceApparecchiature1.NameComboApparecchiature ="cmbsStdApparecchiature";
			/// Imposto il nome della combo Servizio
			CodiceApparecchiature1.NameComboServizio ="cmbsServizio";
			/// Imposto il nome dell'user control RicercaModulo
			CodiceApparecchiature1.NameUserControlRicercaModulo  ="RicercaModulo1";

//			System.Text.StringBuilder sbValid = new System.Text.StringBuilder();
//			sbValid.Append("this.value = 'Attendere ...';");
//			sbValid.Append("this.disabled = true;");
//			sbValid.Append("document.getElementById('" + btRicerca.ClientID + "').disabled = true;");
//			sbValid.Append(this.Page.GetPostBackEventReference(this.btRicerca));
//			sbValid.Append(";");
//			this.btRicerca.Attributes.Add("onclick", sbValid.ToString());
			

			if(!IsPostBack)
			{
				CalendarPicker1.Datazione.Text=DateTime.Now.ToShortDateString();
				CalendarPicker2.Datazione.Text=DateTime.Now.ToShortDateString();
				if(Request.QueryString["FunId"]!=null)
					ViewState["FunId"]=Request.QueryString["FunId"];

				
				BindControls();
				
			}

		}
		private void BindControls()
		{ 
			
			BindServizi("");
			BindApparecchiatura();
			
		}
	
		
		private void BindServizi(string CodEdificio)
		{	
			this.cmbsServizio.Items.Clear();		
			S_ControlsCollection CollezioneControlli = new  S_ControlsCollection();

			Classi.ClassiDettaglio.Servizi  _Servizio = new TheSite.Classi.ClassiDettaglio.Servizi(Context.User.Identity.Name);

			DataSet _MyDs;

			if (CodEdificio!="")
			{
				S_Controls.Collections.S_Object s_Bl_Id = new S_Object();
				s_Bl_Id.ParameterName = "p_Bl_Id";
				s_Bl_Id.DbType = CustomDBType.VarChar;
				s_Bl_Id.Direction = ParameterDirection.Input;
				s_Bl_Id.Index = 0;
				s_Bl_Id.Value =	CodEdificio;
				s_Bl_Id.Size = 8;

				
				S_Controls.Collections.S_Object s_ID_Servizio = new S_Object();
				s_ID_Servizio.ParameterName = "p_ID_Servizio";
				s_ID_Servizio.DbType = CustomDBType.Integer;
				s_ID_Servizio.Direction = ParameterDirection.Input;
				s_ID_Servizio.Index = 1;
				s_ID_Servizio.Value = 0;

				CollezioneControlli.Add(s_Bl_Id);				
				CollezioneControlli.Add(s_ID_Servizio);

				_MyDs = _Servizio.GetData(CollezioneControlli);
			}
			else
			{
				_MyDs = _Servizio.GetData();
			}

			if (_MyDs.Tables[0].Rows.Count > 0)
			{

				this.cmbsServizio.DataSource =_MyDs.Tables[0];
				this.cmbsServizio.DataTextField = "DESCRIZIONE";
				this.cmbsServizio.DataValueField = "IDSERVIZIO";
				this.cmbsServizio.DataBind();
			}
			else
			{
				string s_Messagggio = "- Nessun Servizio -";
				this.cmbsServizio.Items.Add(Classi.GestoreDropDownList.ItemMessaggio(s_Messagggio, "0"));
			}
		
		}


		
		private void BindApparecchiatura()
		{
			
			this.cmbsStdApparecchiature.Items.Clear();
		
			Classi.AnagrafeImpianti.Apparecchiature  _Apparecchiature = new TheSite.Classi.AnagrafeImpianti.Apparecchiature(Context.User.Identity.Name);
			
			DataSet _MyDs;

			if (!IsPostBack)
			{
				_MyDs = _Apparecchiature.GetData().Copy();
			}
			else
			{
				S_ControlsCollection _SColl = new S_ControlsCollection();

				S_Controls.Collections.S_Object s_BlId = new S_Object();
				s_BlId.ParameterName = "p_Bl_Id";
				s_BlId.DbType = CustomDBType.VarChar;
				s_BlId.Direction = ParameterDirection.Input;
				s_BlId.Size =50;
				s_BlId.Index = 0;
				s_BlId.Value = RicercaModulo1.TxtCodice.Text;
				_SColl.Add(s_BlId);
			
				S_Controls.Collections.S_Object s_Servizio = new S_Object();
				s_Servizio.ParameterName = "p_Servizio";
				s_Servizio.DbType = CustomDBType.Integer;
				s_Servizio.Direction = ParameterDirection.Input;
				s_Servizio.Index = 1;
				s_Servizio.Value = (cmbsServizio.SelectedValue=="")? 0:Int32.Parse(cmbsServizio.SelectedValue);
				_SColl.Add(s_Servizio);

				_MyDs = _Apparecchiature.GetData(_SColl).Copy();
                 
			}
  
			if (_MyDs.Tables[0].Rows.Count > 0)
			{
				this.cmbsStdApparecchiature.DataSource = Classi.GestoreDropDownList.ItemBlankDataSource(
					_MyDs.Tables[0], "DESCRIZIONE", "ID", "- Selezionare una Apparecchiatura -", "");
				this.cmbsStdApparecchiature.DataTextField = "DESCRIZIONE";
				this.cmbsStdApparecchiature.DataValueField = "ID";
				this.cmbsStdApparecchiature.DataBind();
			}
			else
			{
				string s_Messagggio = "- Nessuna Apparecchiatura -";
				this.cmbsStdApparecchiature.Items.Add(Classi.GestoreDropDownList.ItemMessaggio(s_Messagggio, String.Empty));
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
			this.btRicerca.Click += new System.EventHandler(this.btRicerca_Click);
			this.btReset.Click += new System.EventHandler(this.btReset_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void btReset_Click(object sender, System.EventArgs e)
		{			
			Response.Redirect("SfogliaMP.aspx?FunID=" + ViewState["FunId"]);
		}

		private void cmbsServizio_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			BindApparecchiatura();
		}

	
		private S_Controls.Collections.S_ControlsCollection GetDatiAprrarecchiature()
		{
			///Istanzio un nuovo oggetto Collection per aggiungere i parametri
			S_Controls.Collections.S_ControlsCollection _SCollection = new S_Controls.Collections.S_ControlsCollection();
			///creo i parametri
		
			S_Controls.Collections.S_Object s_p_Bl_Id = new S_Controls.Collections.S_Object();
			s_p_Bl_Id.ParameterName = "p_Bl_Id";
			s_p_Bl_Id.DbType = ApplicationDataLayer.DBType.CustomDBType.VarChar;
			s_p_Bl_Id.Direction = ParameterDirection.Input;
			s_p_Bl_Id.Size =50;
			s_p_Bl_Id.Index = 0;
			s_p_Bl_Id.Value = RicercaModulo1.TxtCodice.Text;
			_SCollection.Add(s_p_Bl_Id);

			S_Controls.Collections.S_Object s_p_campus = new S_Controls.Collections.S_Object();
			s_p_campus.ParameterName = "p_campus";
			s_p_campus.DbType = ApplicationDataLayer.DBType.CustomDBType.VarChar;
			s_p_campus.Direction = ParameterDirection.Input;
			s_p_campus.Index = 1;
			s_p_campus.Size=50;
			s_p_campus.Value = RicercaModulo1.TxtRicerca.Text;
			///Aggiungo i parametri alla collection
			_SCollection.Add(s_p_campus);

		

			
			S_Controls.Collections.S_Object s_p_Servizio = new S_Controls.Collections.S_Object();
			s_p_Servizio.ParameterName = "p_Servizio";
			s_p_Servizio.DbType = ApplicationDataLayer.DBType.CustomDBType.Integer;
			s_p_Servizio.Direction = ParameterDirection.Input;
			s_p_Servizio.Index = 2;
			s_p_Servizio.Value = (cmbsServizio.SelectedValue ==string.Empty)? 0:Int32.Parse(cmbsServizio.SelectedValue);
			///Aggiungo i parametri alla collection
			_SCollection.Add(s_p_Servizio);

			S_Controls.Collections.S_Object s_p_eqstdid = new S_Controls.Collections.S_Object();
			s_p_eqstdid.ParameterName = "p_eqstdid";
			s_p_eqstdid.DbType = ApplicationDataLayer.DBType.CustomDBType.Integer;
			s_p_eqstdid.Direction = ParameterDirection.Input;
			s_p_eqstdid.Size =8;
			s_p_eqstdid.Index = 3;
			s_p_eqstdid.Value = (cmbsStdApparecchiature.SelectedValue==string.Empty)? 0:Int32.Parse(cmbsStdApparecchiature.SelectedValue);
			_SCollection.Add(s_p_eqstdid);

			S_Controls.Collections.S_Object s_p_eq_id = new S_Controls.Collections.S_Object();
			s_p_eq_id.ParameterName = "p_eq_id";
			s_p_eq_id.DbType = ApplicationDataLayer.DBType.CustomDBType.VarChar;
			s_p_eq_id.Direction = ParameterDirection.Input;
			//			s_p_eq_id.Size =8;
			s_p_eq_id.Index = 4;
			s_p_eq_id.Size =50;
			s_p_eq_id.Value = CodiceApparecchiature1.CodiceApparecchiatura;
			///Aggiungo i parametri alla collection
			_SCollection.Add(s_p_eq_id);


			S_Controls.Collections.S_Object s_p_DataDa = new S_Controls.Collections.S_Object();
			s_p_DataDa.ParameterName = "p_DataDa";
			s_p_DataDa.DbType = ApplicationDataLayer.DBType.CustomDBType.VarChar;
			s_p_DataDa.Direction = ParameterDirection.Input;
			s_p_DataDa.Index = _SCollection.Count;
			s_p_DataDa.Size= 20;
			s_p_DataDa.Value = (CalendarPicker1.Datazione.Text =="")? "":CalendarPicker1.Datazione.Text;  			
			_SCollection.Add(s_p_DataDa);

			S_Controls.Collections.S_Object s_p_DataA = new S_Controls.Collections.S_Object();
			s_p_DataA.ParameterName = "p_DataA";
			s_p_DataA.DbType = ApplicationDataLayer.DBType.CustomDBType.VarChar;
			s_p_DataA.Direction = ParameterDirection.Input;
			s_p_DataA.Index = _SCollection.Count;
			s_p_DataA.Size= 20;
			s_p_DataA.Value = (CalendarPicker2.Datazione.Text =="")? "":CalendarPicker2.Datazione.Text;  			
			_SCollection.Add(s_p_DataA);

			
			//andrea
		


			return _SCollection;
		}



		private void Ricerca(bool reset)
		{
			
			
			//esporta in excel
			Csy.WebControls.Export 	_objExport = new Csy.WebControls.Export();
			DataTable _dt = new DataTable();	
		
			Classi.AnagrafeImpianti.Apparecchiature  _Apparecchiature =new TheSite.Classi.AnagrafeImpianti.Apparecchiature(Context.User.Identity.Name);
			S_Controls.Collections.S_ControlsCollection _SCollection =GetDatiAprrarecchiature();


			DataSet Ds = _Apparecchiature.RicercaAttPMPExcel(_SCollection).Copy();
			
			_dt =Ds.Tables[0].Copy();
				
			if (_dt.Rows.Count > 300000)
			{
				String scriptString = "<script language=JavaScript>alert('I record trovati sono in numero maggiore di 300.000. Impostare filtri più restrittivi');";
				scriptString += "<";
				scriptString += "/";
				scriptString += "script>";

				if(!this.IsClientScriptBlockRegistered("clientScriptexp"))
					this.RegisterStartupScript ("clientScriptexp", scriptString);
			} 
			else 
			{
			
				if (_dt.Rows.Count != 0)
				{
					_objExport.ExportDetails(_dt, Csy.WebControls.Export.ExportFormat.Excel, "exp.xls" ); 		
				}
				else
				{
					String scriptString = "<script language=JavaScript>alert('Nessun elemento da esportare per le date scelte');";
					scriptString += "<";
					scriptString += "/";
					scriptString += "script>";

					if(!this.IsClientScriptBlockRegistered("clientScriptexp"))
						this.RegisterStartupScript ("clientScriptexp", scriptString);
				}
			}
			
			
			
			//			S_Controls.Collections.S_ControlsCollection CollezioneControlli = new S_Controls.Collections.S_ControlsCollection();
			//			int mindex=0;
			//			// Data Da						
			//			S_Controls.Collections.S_Object s_p_DataDa = new S_Controls.Collections.S_Object();
			//			s_p_DataDa.ParameterName = "p_DataDa";
			//			s_p_DataDa.DbType = ApplicationDataLayer.DBType.CustomDBType.VarChar;
			//			s_p_DataDa.Direction = ParameterDirection.Input;
			//			s_p_DataDa.Index = mindex;
			//			s_p_DataDa.Size= 20;
			//			s_p_DataDa.Value = (CalendarPicker1.Datazione.Text =="")? "":CalendarPicker1.Datazione.Text;  			
			//			CollezioneControlli.Add(s_p_DataDa);
			//			mindex++;
			//			S_Controls.Collections.S_Object s_p_DataA = new S_Controls.Collections.S_Object();
			//			s_p_DataA.ParameterName = "p_DataA";
			//			s_p_DataA.DbType = ApplicationDataLayer.DBType.CustomDBType.VarChar;
			//			s_p_DataA.Direction = ParameterDirection.Input;
			//			s_p_DataA.Index = mindex;
			//			s_p_DataA.Size= 20;
			//			s_p_DataA.Value = (CalendarPicker2.Datazione.Text =="")? "":CalendarPicker2.Datazione.Text;  			
			//			CollezioneControlli.Add(s_p_DataA);

			//			mindex++;
			//			// Servizio					
			//			S_Controls.Collections.S_Object s_P_servizio = new S_Object();
			//			s_P_servizio.ParameterName = "P_servizio";
			//			s_P_servizio.DbType = CustomDBType.Integer;
			//			s_P_servizio.Direction = ParameterDirection.Input;
			//			s_P_servizio.Index = mindex;
			//			s_P_servizio.Value=(cmbsServizio.SelectedValue=="0")?0:int.Parse(cmbsServizio.SelectedValue);			
			//			CollezioneControlli.Add(s_P_servizio);
			//			mindex++;
			
			
			// Bl codice dell'edificio					
			//			S_Controls.Collections.S_Object s_P_bl_id = new S_Object();
			//			s_P_bl_id.ParameterName = "P_bl_id";
			//			s_P_bl_id.DbType = CustomDBType.VarChar;
			//			s_P_bl_id.Direction = ParameterDirection.Input;
			//			s_P_bl_id.Index =mindex;
			//			s_P_bl_id.Size=50; 
			//			s_P_bl_id.Value=RicercaModulo1.TxtCodice.Text;			
			//			CollezioneControlli.Add(s_P_bl_id);
			//			mindex++;
			//			// Bl Descrizione dell'edificio					
			//			S_Controls.Collections.S_Object s_P_campus = new S_Object();
			//			s_P_campus.ParameterName = "P_campus";
			//			s_P_campus.DbType = CustomDBType.VarChar;
			//			s_P_campus.Direction = ParameterDirection.Input;
			//			s_P_campus.Index = mindex;
			//			s_P_campus.Size=50; 
			//			s_P_campus.Value=RicercaModulo1.Campus;			
			//			CollezioneControlli.Add(s_P_campus);
			//			mindex++;
			
						
			//			// Standard delle apparecchiature				
			//			S_Controls.Collections.S_Object s_P_standard = new S_Object();
			//			s_P_standard.ParameterName = "P_standard";
			//			s_P_standard.DbType = CustomDBType.Integer;
			//			s_P_standard.Direction = ParameterDirection.Input;
			//			s_P_standard.Index = mindex++;
			//			s_P_standard.Value=(cmbsStdApparecchiature.SelectedValue=="")?0:int.Parse(cmbsStdApparecchiature.SelectedValue);			
			//			CollezioneControlli.Add(s_P_standard);
			//			mindex++;
			//
			//			// Apparecchiature				
			//			S_Controls.Collections.S_Object s_P_apparecchiatura = new S_Object();
			//			s_P_apparecchiatura.ParameterName = "P_apparecchiatura";
			//			s_P_apparecchiatura.DbType = CustomDBType.VarChar;
			//			s_P_apparecchiatura.Direction = ParameterDirection.Input;
			//			s_P_apparecchiatura.Size = 50;
			//			s_P_apparecchiatura.Index =mindex++;
			//			s_P_apparecchiatura.Value=CodiceApparecchiature1.CodiceApparecchiatura;			
			//			CollezioneControlli.Add(s_P_apparecchiatura);
			//			mindex++;
			
			//			S_Controls.Collections.S_Object s_CurrentUser = new S_Object();
			//			s_CurrentUser.ParameterName = "p_CurrentUser";
			//			s_CurrentUser.DbType = CustomDBType.VarChar;
			//			s_CurrentUser.Direction = ParameterDirection.Input;
			//			s_CurrentUser.Index = mindex++;
			//			s_CurrentUser.Value = System.Web.HttpContext.Current.User.Identity.Name;
			//			CollezioneControlli.Add(s_CurrentUser);
			//			// pageindex
			//			mindex++;
			
			

			//			TheSite.Classi.ManProgrammata.SfogliaRdlOdl _SfogliaRdlOdl=new TheSite.Classi.ManProgrammata.SfogliaRdlOdl(Context.User.Identity.Name);
			//			DataSet _Ds= _SfogliaRdlOdl.GetData(CollezioneControlli);
			//
			//		
			//			if (reset==true)
			//			{
			//				CollezioneControlli.RemoveAt(CollezioneControlli.Count -1); 
			//				CollezioneControlli.RemoveAt(CollezioneControlli.Count -1); 
			//				CollezioneControlli.RemoveAt(CollezioneControlli.Count -1); 
			//				int _totalRecords = _SfogliaRdlOdl.GetDataCount(CollezioneControlli);
			//					
			//			}

			

			
		}
		public bool completare=false;
		
		
		private void btRicerca_Click(object sender, System.EventArgs e)
		{
			
			Ricerca(true);
			
		}

		

	}
}