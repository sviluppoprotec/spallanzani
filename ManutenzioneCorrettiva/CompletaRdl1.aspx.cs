

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
using MyCollection;
using System.Reflection;
using ApplicationDataLayer;
using ApplicationDataLayer.DBType;
using S_Controls.Collections;
using System.IO;
using System.Globalization;




namespace TheSite.ManutenzioneCorrettiva
{
	/// <summary>
	/// Descrizione di riepilogo per CompletaRdl.
	/// </summary>
	public class CompletaRdl1 : System.Web.UI.Page
	{
		#region dichiarazioni variabili
		protected WebControls.CalendarPicker CalendarPicker1;
		protected WebControls.CalendarPicker CalendarPicker2;
		protected WebControls.CalendarPicker CalendarPicker4;
		protected WebControls.CalendarPicker CalendarPicker6;
		protected WebControls.CalendarPicker CalendarPicker7;
		protected WebControls.CalendarPicker CalendarPicker8;
		protected WebControls.CalendarPicker CalendarPicker10;
		public Classi.SiteModule _SiteModule;
		protected System.Web.UI.WebControls.Label lblNote;
		protected System.Web.UI.WebControls.Label lblTelefono;
		protected System.Web.UI.WebControls.TextBox txtHidBl;
		protected System.Web.UI.WebControls.Label lblfabbricato;
		protected System.Web.UI.WebControls.Label lblstanzaric;
		protected System.Web.UI.WebControls.Label lblemailric;
		protected System.Web.UI.WebControls.Label lblOraRichiesta;
		protected System.Web.UI.WebControls.Label lblGruppo;
		protected System.Web.UI.WebControls.Label lblDataRichiesta;
		protected System.Web.UI.WebControls.Label lbltelefonoric;
		protected System.Web.UI.WebControls.Label lblOperatore;
		protected System.Web.UI.WebControls.Label lblRichiedente;
		protected System.Web.UI.WebControls.Label LblRdl;
		protected System.Web.UI.WebControls.Button BtSalvaSGA;
		protected S_Controls.S_ComboBox cmbsServizio;
		protected S_Controls.S_ComboBox cmdsStdApparecchiatura;
		protected S_Controls.S_ComboBox cmbEQ;
		protected S_Controls.S_TextBox txtsDescrizione;
		protected S_Controls.S_TextBox txtCausa;
		protected S_Controls.S_TextBox txtEffettoGuasto;
		protected Csy.WebControls.DataPanel PanelGeneral;
		protected S_Controls.S_ComboBox cmbsTipoManutenzione;
		protected WebControls.PageTitle PageTitle1;
		protected System.Web.UI.WebControls.Label lblSeguito1;
		protected System.Web.UI.WebControls.Label lblSeguito2;
		protected WebControls.AggiungiReclamo AggiungiReclamo;
		protected WebControls.AggiungiSollecito AggiungiSollecito;
		protected WebControls.AggiungiChiariInfo AggiungiChiariInfo;
		bool IsEditable=false;
		Classi.ManCorrettiva.ClManCorrettiva _ClManCorrettiva;
		protected S_Controls.S_TextBox txtSoluzioneProposta;
		//protected System.Web.UI.HtmlControls.HtmlInputFile btnPersonale;
		//protected System.Web.UI.HtmlControls.HtmlInputFile btOpenMat;
		protected S_Controls.S_ComboBox cmbsTipoIntrevento;
		protected System.Web.UI.WebControls.Repeater rpdc;
		protected System.Web.UI.WebControls.Button BtUpload;
		protected System.Web.UI.HtmlControls.HtmlInputFile UploadFile;
		protected Csy.WebControls.DataPanel Datapanel3;
		protected System.Web.UI.WebControls.Label LblOrdine;
		protected S_Controls.S_ComboBox cmbsAddetto;
		protected S_Controls.S_ComboBox cmbsUrgenza;
		protected System.Web.UI.WebControls.Label LblMessaggio;
		protected System.Web.UI.WebControls.Button btRifiuta;
		protected System.Web.UI.WebControls.Button btSospendi;
		protected System.Web.UI.WebControls.Button btApprova;
		protected S_Controls.S_ComboBox cmbOra1;
		protected S_Controls.S_ComboBox cmbMin2;
		protected System.Web.UI.HtmlControls.HtmlInputHidden hidBl_id;
		protected System.Web.UI.HtmlControls.HtmlInputHidden HSga;
		protected System.Web.UI.HtmlControls.HtmlInputHidden HPageBack;
		protected System.Web.UI.HtmlControls.HtmlInputHidden HPrj;
		protected System.Web.UI.HtmlControls.HtmlInputHidden Hidden1;
		protected System.Web.UI.WebControls.TextBox TxtNumPreventivo;
		protected S_Controls.S_TextBox txtImpPrev1;
		protected S_Controls.S_TextBox txtImpPrev2;
		protected System.Web.UI.WebControls.HyperLink LkPrev;
		protected System.Web.UI.WebControls.ImageButton btImgDelete;		
		public int wr_id=0;
		//Double totale;
		//Double tot;
		protected System.Web.UI.WebControls.Label lblSGA;
		protected System.Web.UI.WebControls.Label LblDataInvioSga;
		protected System.Web.UI.WebControls.DropDownList CmbPeriodo;
		protected System.Web.UI.WebControls.Label presidio;
		protected S_Controls.S_ComboBox cmbminfinelav;
		protected S_Controls.S_ComboBox cmborafinelav;

		protected S_Controls.S_TextBox txtPercentuale1;
		
		
		protected S_Controls.S_TextBox txtPercentuale2;
		protected S_Controls.S_TextBox txtModalitaPagamento;
		protected S_Controls.S_TextBox txtNoteSga;
		protected System.Web.UI.WebControls.Button BtInviaPreventivo;
		protected System.Web.UI.HtmlControls.HtmlInputFile FilePreventivo;
		protected S_Controls.S_OptionButton OptAMisura;
		protected S_Controls.S_OptionButton OptAForfait;
		protected S_Controls.S_TextBox TxtAForfait;
		protected S_Controls.S_TextBox txtCostiMateriali1;
		protected S_Controls.S_TextBox txtCostiMateriali2;
		protected S_Controls.S_TextBox txtCostiPersonale1;
		protected S_Controls.S_TextBox txtCostiPersonale2;
		protected S_Controls.S_TextBox txtCostiTotale1;
		protected S_Controls.S_TextBox txtCostiTotale2;
		protected System.Web.UI.WebControls.Label lblCostoMateriali;
		protected System.Web.UI.WebControls.Label lblCostiPersonale;
		protected System.Web.UI.WebControls.Label LblTotale;
		protected System.Web.UI.WebControls.Label LblTotMateriali;
		protected System.Web.UI.WebControls.Label LblTotPersonale;
		protected System.Web.UI.WebControls.Label LblTotGenerale;
		protected S_Controls.S_TextBox ImpCons1;
		protected S_Controls.S_TextBox ImpCons2;
		protected System.Web.UI.WebControls.Button BtInviaCons;
		protected System.Web.UI.WebControls.HyperLink LkCons;
		protected System.Web.UI.WebControls.ImageButton btImgDeleteCons;
		protected Csy.WebControls.DataPanel Datapanel5;
		protected S_Controls.S_ComboBox cmbsstatolavoro;
		protected S_Controls.S_TextBox txtsAnnotazioni;
		protected System.Web.UI.WebControls.TextBox txtBuonoLavoroEster;
		protected S_Controls.S_ComboBox OraIni;
		protected S_Controls.S_ComboBox MinitiIni;
		protected S_Controls.S_ComboBox S_COMBOBOX2;
		protected S_Controls.S_ComboBox S_COMBOBOX1;
		protected S_Controls.S_ComboBox OraFine;
		protected S_Controls.S_ComboBox MinutiFine;
		protected System.Web.UI.WebControls.DropDownList cmbStatoIntervento;
		protected System.Web.UI.WebControls.CheckBox CkDisser;
		protected S_Controls.S_TextBox cmbDescrizioneIntervento;
		protected S_Controls.S_TextBox txtNoteCompletamento;
		protected System.Web.UI.WebControls.RadioButtonList RdListLivello;
		protected Csy.WebControls.DataPanel Datapanel4;
		protected System.Web.UI.WebControls.Button BtSalva;
		protected System.Web.UI.WebControls.Button BtDIE;
		protected System.Web.UI.WebControls.Button btFoglioPdf;
		protected System.Web.UI.WebControls.Button btChiudi;
		protected System.Web.UI.HtmlControls.HtmlInputFile FileConsuntivo;
		protected System.Web.UI.HtmlControls.HtmlGenericControl azioni;
		protected Csy.WebControls.DataPanel Datapanel2;
		protected System.Web.UI.WebControls.TextBox txtOperazioneN;
		protected S_Controls.S_ComboBox CmbMese;
		protected System.Web.UI.WebControls.CheckBox Ck1;
		protected System.Web.UI.WebControls.CheckBox Ck2;
		protected System.Web.UI.WebControls.Button btFoglio;
		protected System.Web.UI.WebControls.DropDownList cmbsCdC;
	    protected System.Web.UI.WebControls.DropDownList cmbCdC;
		protected Csy.WebControls.DataPanel Datapanel6;
		protected S_Controls.S_ComboBox OraSopralluogo;
		protected S_Controls.S_ComboBox MinutiSopralluogo;
		protected System.Web.UI.WebControls.Repeater Repeater1;
		protected System.Web.UI.WebControls.Repeater Repeater2;
		protected System.Web.UI.WebControls.Repeater Repeater3;
		protected Csy.WebControls.DataPanel Datapanel1;
		protected Csy.WebControls.DataPanel Datapanel7;
		protected Csy.WebControls.DataPanel Datapanel8;
		protected System.Web.UI.WebControls.TextBox txtord;
		protected S_Controls.S_ComboBox S_PIANO;
		protected S_Controls.S_Label S_Lblcodedificio1;
		protected System.Web.UI.WebControls.Button Button1;
		protected WebControls.UserStanzeRic UserStanzeRic1;
		protected WebControls.RicercaModulo RicercaModulo1;
		protected S_Controls.S_ComboBox S_macroarea;
		protected S_Controls.S_ComboBox S_COMBOBOX4;
		protected S_Controls.S_ComboBox S_COMBOBOX3;
		protected S_Controls.S_ComboBox S_tipintervento;
		
		
		string chiamante;

		#endregion
		private void Page_Load(object sender, System.EventArgs e)
		{
			LkCons.Target="_blank";
			//Istanzio la classe 
			_ClManCorrettiva=new TheSite.Classi.ManCorrettiva.ClManCorrettiva(Context.User.Identity.Name);
			// Inserire qui il codice utente necessario per inizializzare la pagina.
			// ***********************  MODIFICA PER I PERMESSI SULLA PAGINA CORRENTE **********************
			string _mypage="./ManutenzioneCorrettiva/CompletaRdl1.aspx";			
			_SiteModule = new TheSite.Classi.SiteModule(_mypage);
			PageTitle1.Title="Aggiorna RdL";
			// *********************************************************************************************
			this.IsEditable=_SiteModule.IsEditable;

			//Imposto le proprieta sui controlli
			SetProperty();
			UserStanzeRic1.NameLblId = "S_Lblcodedificio1";			
			UserStanzeRic1.NameComboPiano="S_PIANO";
			UserStanzeRic1.NameUserControlRicercaModulo = "RicercaModulo1";

			if(Request["wr_id"]!=null)
				wr_id=int.Parse(Request["wr_id"]);
			if(Request["chiamante"]!=null)
				chiamante=Request["chiamante"].ToString();
			#region Costi
		
			//btnPersonale.Attributes.Add("onclick","OpenPopUpAddetti('"+ wr_id +"' );");
			Datapanel5.Visible=true;
			//Faccio i conti
			
			DataSet DsManodoperaCosti = _ClManCorrettiva.TotManodopera(wr_id);			
						if(DsManodoperaCosti.Tables[0].Rows.Count>0)
						{
							DataRow riga= DsManodoperaCosti.Tables[0].Rows[0];
							lblCostiPersonale.Text=riga["totaddetto"].ToString();
							lblCostoMateriali.Text=riga["totmateriale"].ToString();
							double tot=double.Parse(riga["totaddetto"].ToString()) + double.Parse(riga["totmateriale"].ToString());
							LblTotale.Text=tot.ToString();
						}
						else
						{
							lblCostiPersonale.Text="0";
							lblCostoMateriali.Text="0";
							LblTotale.Text="0";
						}
				
			#endregion
			if(!IsPostBack)
			{				
		
				#region Recupero la proprieta di ricerca
				// Recupero il tipo dall'oggetto context.
				Type myType=Context.Handler.GetType();       
				// recupero il PropertyInfo object passando il nome della propriet� da recuperare.
				PropertyInfo myPropInfo = myType.GetProperty("_Contenitore");
			
				// verifico che questa propriet� esista.
				if(myPropInfo!=null)
					this.ViewState.Add("mioContenitore",myPropInfo.GetValue(Context.Handler,null));

				//				this.ViewState.Add("mioContenitore",this.GetProperty(Context.Handler,"_Contenitore",new clMyCollection()));
				#endregion
				if (chiamante=="SfogliaDoc")
				{
					string pagebak="SfogliaDoc.aspx";
					HPageBack.Value= pagebak.Substring(pagebak.LastIndexOf("/")+1);

				}
				else
				{
					string pagebak=((System.Web.HttpRequest)(((System.Web.UI.Page)((this.Page))).Request)).FilePath;
					HPageBack.Value= pagebak.Substring(pagebak.LastIndexOf("/")+1);
				}
				//Imposto le caselle che accettano solo numeri

				LoadDati();
//								if (Datapanel5.Visible==true)
//								{
//									CaricaFondi();
//								}

				string funzioneJsCalcolaTotale = "javascript:RicalcolaTotaliAG();";					
				txtCostiMateriali1.Attributes.Add("onkeyup",funzioneJsCalcolaTotale);
				txtCostiMateriali2.Attributes.Add("onkeyup",funzioneJsCalcolaTotale);

				 				
				txtCostiPersonale1.Attributes.Add("onkeyup",funzioneJsCalcolaTotale);
				txtCostiPersonale2.Attributes.Add("onkeyup",funzioneJsCalcolaTotale);

			 				
				txtCostiTotale1.Attributes.Add("onkeyup",funzioneJsCalcolaTotale);
				txtCostiTotale2.Attributes.Add("onkeyup",funzioneJsCalcolaTotale);
			}

			//Carico i solleciti della RdL
			LoadSolleciti();
			
			//Carico i reclami della RdL
			LoadReclami();
			//Carico le rcihieste informazioni-chiarimenti RdL
			LoadChiarInfo();

			SetVisible();
			
			///Parte riguardante i solleciti
			AggiungiSollecito.Progetto=HPrj.Value;
			AggiungiSollecito.TxtID_WR=this.wr_id.ToString();
//			VisualizzaSolleciti1.TxtID_WR=this.wr_id.ToString();
			
			// REclamo
			AggiungiReclamo.Progetto=HPrj.Value;
			AggiungiReclamo.TxtID_WR=this.wr_id.ToString();
			
			//Chiarimento e Informazioni
			AggiungiChiariInfo.Progetto=HPrj.Value;
			AggiungiChiariInfo.TxtID_WR=this.wr_id.ToString();

			//Imposto la combo della manutenzione
			Page.RegisterStartupScript("tipman","<script language='javascript'>SetPreventivo(document.getElementById('" + cmbsTipoManutenzione.ClientID + "').value);</script>");
			if (Datapanel5.Visible==true)
			{
				Page.RegisterStartupScript("sum","<script language='javascript'>somma();</script>");
			}


		}

		#region Dati Per il ritorno in Back
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
		#endregion
		
	
		protected string FormattaDecimali(object numero,object cifre)
		{
			NumberFormatInfo nfi = new CultureInfo("it-IT", false ).NumberFormat;
			nfi.NumberDecimalDigits = Convert.ToInt32(cifre);
			decimal numFormattato = Convert.ToDecimal(numero);
			return numFormattato.ToString("N",nfi);
		}
		private bool IsCompleta
		{
			get
			{
				//				if(Request["c"]==null)
				//					return false;
				//				else
				//					return true;
				if(this.ViewState["IsCompleta"]!=null)
					return (bool)this.ViewState["IsCompleta"];
				else
					return false;

			}
			set {this.ViewState.Add("IsCompleta",value);}
		}
		private bool IsCompletata
		{
			get
			{
				if(this.ViewState["IsCompletata"]!=null)
					return (bool)this.ViewState["IsCompletata"];
				else
					return false;

			}
			set {this.ViewState.Add("IsCompleta",value);}
		}
		//Imposto le proprieta sui controlli
		private void SetProperty()
		{
			

			txtImpPrev1.Attributes.Add("onkeypress","return caratteriok(event,'0123456789');");
			txtImpPrev2.Attributes.Add("onkeypress","return caratteriok(event,'0123456789');");



			txtImpPrev1.Attributes.Add("onpaste","return false;");
			txtImpPrev2.Attributes.Add("onpaste","return false;");



			TxtNumPreventivo.Attributes.Add("onpaste","return false;");
			
			
			BtSalvaSGA.Attributes.Add("onclick","return IsValidDateWork();"); 
			btApprova.Attributes.Add("onclick","return IsEmissione();");

			BtSalva.Attributes.Add("onclick","return IsCompleta();");
			BtDIE.Attributes.Add("onclick","return IsCompleta();");

			btImgDelete.Attributes.Add("onclick","return deletedoc();");

			
			//			OptAMisura.Attributes.Add("onclick","VisualizzaNote('"+ OptAForfait.ClientID +"' );");
			//			OptAForfait.Attributes.Add("onclick","VisualizzaNote('"+ OptAForfait.ClientID +"' );");

			btImgDelete.Attributes.Add("onclick","return confirm('Eliminare il documento del Preventivo allegato?');");
			btImgDeleteCons.Attributes.Add("onclick","return confirm('Eliminare il documento del Consuntivo allegato?');");

			//BtDIE.Attributes.Add("onclick","return ContrallaNumSga();");
		}
		//Imposta la visibilt� e la abilitazione dei controlli una volta approvata la richiesta
		private void SetVisisbleCompletata()
		{
			//btImgDelete.Visible=true;
			cmbEQ.Enabled=false;
			cmbsServizio.Enabled=false;
			cmdsStdApparecchiatura.Enabled=false;
			BtInviaPreventivo.Enabled=true;
			Datapanel5.Visible=true;
			Datapanel4.Visible=true;
		}
		private void DisableControl(Control ctrl)
		{
			foreach(Control ctr in ctrl.Controls)
			{
				if(ctr is TextBox || ctr is DropDownList || ctr is RadioButton || ctr is CheckBox)
				{
					if (ctr is TextBox)	((TextBox)ctr).Enabled=false;
					if (ctr is DropDownList) ((DropDownList)ctr).Enabled=false;
					if (ctr is RadioButton)	((RadioButton)ctr).Enabled=false;
					if (ctr is CheckBox)	((CheckBox)ctr).Enabled=false;
				}	
			}
		}
		private void SetVisible()
		{
			if(this.IsCompleta==true)//completamento
			{
				btApprova.Visible =false;
				btSospendi.Visible =false;
				btRifiuta.Visible =false;
				Button1.Visible=false;
				//BtSalvaSGA.Visible=false;
				//btChiudi.Visible=false;
				Datapanel4.Visible=true;
				Datapanel5.Visible=true;
				Datapanel5.Collapsed=false; // sezione consuntivo economico
				//Datapanel3.Collapsed=true; // sezione emissione ordine
				Datapanel2.Collapsed=true; //documentazione
				Datapanel1.Collapsed=true;
				Datapanel7.Collapsed=true;
				Datapanel8.Collapsed=true;
				//Datapanel1.Collapsed =true;
				if (!Context.User.IsInRole("callcenter"))
					Page.RegisterStartupScript("sr","<script language='javascript'>SetStato(document.getElementById('" + cmbsstatolavoro.ClientID + "').value);</script>");

				//				DisableControl(Datapanel1);
				//				DisableControl(Datapanel3);
				//DisableControl(PanelGeneral);
				
			}
			else //approvazione
			{
				
				btApprova.Visible =true;
				btSospendi.Visible =true;
				btRifiuta.Visible =true;
				Button1.Visible=true;
				Datapanel4.Visible=false;
				Datapanel5.Visible=false;
				azioni.Visible=false;
				
			}
//			if (Context.User.IsInRole("callcenter"))
//			{
//				Datapanel2.Visible=false; //Documentazione
//				btApprova.Visible =false;
//				btSospendi.Visible =false;
//				btRifiuta.Visible =false;
//				Datapanel4.Visible=false; 
//				Datapanel5.Visible=false;
//				Datapanel1.Visible=false;
//				Datapanel7.Visible=false;
//				Datapanel8.Visible=false;
//			}

		}
//		private void SetImportiEnable()
//		{
//			txtImpPrev1.Enabled=false;
//			txtImpPrev2.Enabled=false;
//			BtInviaPreventivo.Visible=false;
//			FilePreventivo.Disabled=true;			
//			btImgDelete.Visible=false;
////			ImpCons1.Enabled=false;
////			ImpCons2.Enabled=false;
////			txtCostiMateriali1.Enabled=false;
////			txtCostiMateriali2.Enabled=false;
////			txtCostiPersonale1.Enabled=false;
////			txtCostiPersonale2.Enabled=false;
////			txtCostiTotale1.Enabled=false;
////			txtCostiTotale2.Enabled=false;
//
//		
//		}	


		/// <summary>
		/// Carica i dati di una richiesta
		/// </summary>
		private void LoadDati()
		{
			//Carica la combo il Tipo di manutenzione
			LoadTipoManutenzione();
			//Carico a il combo Del Tipo Intervento
			LoadTipoIntervento();
			//Carico i Piani 
			LoadMacroArea();
			
			
			//Carico i dati della Richiesta
			DataSet _Ds=  _ClManCorrettiva.GetSingleRdlNew1(this.wr_id);
			if (_Ds.Tables[0].Rows.Count==0)
			{
				return;
			}
			DataRow _Dr = _Ds.Tables[0].Rows[0];
			//Carico le ditte associate all'edificio
			
			//Id dell'edificio
			hidBl_id.Value =_Dr["id_bl"].ToString();
			
			txtHidBl.Text=_Dr["bl_id"].ToString();
			//Carico i Piani 
			//LoadPiani();
			LoadPianibl(_Dr["id_bl"].ToString());


			S_Lblcodedificio1.Text=_Dr["bl_id"].ToString();	

			//Carico i documenti allegati della RdL
			LoadDocument();


//			//Carico i solleciti della RdL
//			LoadSolleciti();
//			
//			//Carico i reclami della RdL
//			LoadReclami();
//			//Carico le rcihieste informazioni-chiarimenti RdL
//			LoadChiarInfo();


			//Carico i documenti allegati al preventivo
			LoadDocumentPrev();
			//carico i documenti allegati al consuntivo
			LoadDocumentCons();


			HPrj.Value=_Dr["id_progetto"].ToString();

			LblRdl.Text =	_Dr["id"].ToString();		

			if (_Dr["id_wr_status"] != DBNull.Value)
				if(_Dr["id_wr_status"].ToString()=="6")//Approvata
				{
					btApprova.Visible =false;
					btSospendi.Visible =false;
					btRifiuta.Visible =false;
					Datapanel4.Visible=true;
					Datapanel5.Visible=true;
					//BtSalvaSGA.Text="Invia SGA";
				}
			if(_Dr["id_wr_status"].ToString()=="1" || _Dr["id_wr_status"].ToString()=="7" || _Dr["id_wr_status"].ToString()=="15")//Emessa
			{
				IsCompleta=false;
			}

			if(_Dr["id_wr_status"].ToString()!="1" && _Dr["id_wr_status"].ToString()!="7" && _Dr["id_wr_status"].ToString()!="15")//Emessa
			{
				IsCompleta=true;
				//BtSalvaSGA.Text="Invia SGA";
			}
			
			//Imposto la visibilit�
			//SetVisible();

			if(_Dr["id_wr_status"].ToString()=="4")
			{
				//marianna bisogna salvare sempre
				//IsCompletata=true;
				//BtSalva.Enabled=false;
				cmbsstatolavoro.Enabled=false;
				//BtDIE.Text ="Invia DIE";
				BtSalva.Attributes.Add("onclick","return SgaSalvata();");
				BtDIE.Attributes.Add("onclick","return SgaSalvata();");

			}
//			//controllo stato autorizzativo
//			if(_Dr["id_stato_aut"].ToString()=="3" )
//				//&& _Dr["tipomanutenzione_id"].ToString()=="3" 
//				//)Emessa
//			{
//				AUT="PREVENTIVO GIA' AUTORIZZATO NON E' POSSIBILE SALVARE ALTRO PREVENTIVO";
//				//SetImportiEnable();
//			}		

			
			//WO RDL
			

			if (_Dr["wo_id"] != DBNull.Value)
				LblOrdine.Text=_Dr["wo_id"].ToString();					

			//RICHIEDENTE
			if (_Dr["richiedente"] != DBNull.Value)
				this.lblRichiedente.Text=_Dr["richiedente"].ToString();
			//OPERATORE
			if (_Dr["operatore"] != DBNull.Value)
				this.lblOperatore.Text=_Dr["operatore"].ToString();
			//TELEFONORICHIEDENTE
			if (_Dr["telefonoric"] != DBNull.Value)
				this.lbltelefonoric.Text=_Dr["telefonoric"].ToString();
			//EMAILRICHIEDENTE
			if (_Dr["emailric"] != DBNull.Value)
				this.lblemailric.Text=_Dr["emailric"].ToString();
			//STANZARICHIEDENTE
			if (_Dr["stanzaric"] != DBNull.Value)
				this.lblstanzaric.Text=_Dr["stanzaric"].ToString();
			//TELEFONO
			if (_Dr["telefono"] != DBNull.Value)
				this.lblTelefono.Text=_Dr["telefono"].ToString();
			//DATARICHIESTA				
			if (_Dr["dataRichiesta"] != DBNull.Value)
				this.lblDataRichiesta.Text= System.DateTime.Parse(_Dr["dataRichiesta"].ToString()).ToShortDateString();
			//ORARICHIESTA				
			if (_Dr["dataRichiesta"] != DBNull.Value)
				this.lblOraRichiesta.Text= System.DateTime.Parse(_Dr["dataRichiesta"].ToString()).ToShortTimeString();				
			//GRUPPO
			if (_Dr["gruppo"] != DBNull.Value)
				this.lblGruppo.Text=_Dr["gruppo"].ToString();
			//FABBRICATO
			if (_Dr["fabbricato"] != DBNull.Value)
				this.lblfabbricato.Text=_Dr["fabbricato"].ToString();
//			//Stanza
//			if (_Dr["stanza"] != DBNull.Value)
//				this.lblStanza.Text=_Dr["stanza"].ToString();

			if(_Dr["stanza"]!=DBNull.Value)
				UserStanzeRic1.DescStanza=_Dr["stanza"].ToString();

			if (_Dr["IDS"]!=DBNull.Value)
				UserStanzeRic1.IdStanza=_Dr["IDS"].ToString();
			
			if (_Dr["id_rm_cat"] != DBNull.Value)
				this.S_macroarea.SelectedValue=_Dr["id_rm_cat"].ToString();	

			//Piano
//			if (_Dr["piano"] != DBNull.Value)
//				this.lblPiano.Text=_Dr["piano"].ToString();
			
			if (_Dr["id_fl"] != DBNull.Value)
				this.S_PIANO.SelectedValue=_Dr["id_fl"].ToString();	

			//NOTA
			if (_Dr["nota"] != DBNull.Value)
				this.lblNote.Text=_Dr["nota"].ToString();
			//CLASSIFICAZIONE INTERVENTO
			
			if (_Dr["tipointervento_id"] != DBNull.Value)
				this.S_tipintervento.SelectedValue=_Dr["tipointervento_id"].ToString();	

			//Carico i servizi in base all'edificio
			LoadServizio(_Dr["id_bl"].ToString());
			//Servizio				
			if (_Dr["servizio_id"] != DBNull.Value)
				this.cmbsServizio.SelectedValue=_Dr["servizio_id"].ToString();	
			 
			//Carico lo standar Apparecchiature
			LoadStandardApparechiature();
			//Standard Apparecchiatura
			if (_Dr["eqstd_id"] != DBNull.Value)
				this.cmdsStdApparecchiatura.SelectedValue=_Dr["eqstd_id"].ToString();
			//Carico le Apparecchiature
			LoadApparechiature();
			if (_Dr["id_eq"] != DBNull.Value)
				this.cmbEQ.SelectedValue=_Dr["id_eq"].ToString();				

			//Descrizione Intervento
			if (_Dr["descrizione"] != DBNull.Value)
				this.txtsDescrizione.Text=_Dr["descrizione"].ToString();		

			if (_Dr["DataRdl"] != DBNull.Value)
			{
				this.CalendarPicker1.Datazione.Text=DateTime.Parse( _Dr["DataRdl"].ToString()).ToShortDateString();
				//this.lblDataRichiesta.Text= System.DateTime.Parse(_Dr["dataRichiesta"].ToString()).ToShortDateString();
				//ORARICHIESTA	
				
				System.DateTime cmboradatarichiesta= System.DateTime.Parse(_Dr["DataRdl"].ToString());
				S_COMBOBOX4.SelectedValue =cmboradatarichiesta.Hour.ToString().PadLeft(2,Convert.ToChar("0"))  ;
				S_COMBOBOX3.SelectedValue =cmboradatarichiesta.Minute.ToString().PadLeft(2,Convert.ToChar("0")) ;
			}

			if (_Dr["datafine"] != DBNull.Value)
				this.CalendarPicker2.Datazione.Text=DateTime.Parse( _Dr["datafine"].ToString()).ToShortDateString();
			else
				this.CalendarPicker2.Datazione.Text="";

			// Paolo
			if (_Dr["datafine"]!=DBNull.Value)
			{
				System.DateTime cmborafinelavaz= System.DateTime.Parse(_Dr["datafine"].ToString());
				cmborafinelav.SelectedValue =cmborafinelavaz.Hour.ToString().PadLeft(2,Convert.ToChar("0"))  ;
				cmbminfinelav.SelectedValue =cmborafinelavaz.Minute.ToString().PadLeft(2,Convert.ToChar("0")) ;
			}
			// Altro

			if (_Dr["date_est_completion"] != DBNull.Value)
				this.CalendarPicker10.Datazione.Text=DateTime.Parse( _Dr["date_est_completion"].ToString()).ToShortDateString();
			else
				this.CalendarPicker10.Datazione.Text="";

			// Fine Altro
			// Paolo

			if (_Dr["datafine"]!=DBNull.Value)
			{
				System.DateTime cmborafinelavaz= System.DateTime.Parse(_Dr["datafine"].ToString());
				cmborafinelav.SelectedValue =cmborafinelavaz.Hour.ToString().PadLeft(2,Convert.ToChar("0"))  ;
				cmbminfinelav.SelectedValue =cmborafinelavaz.Minute.ToString().PadLeft(2,Convert.ToChar("0")) ;
			}
			// Paolo

			if (_Dr["tipomanutenzione_id"] != DBNull.Value)
				cmbsTipoManutenzione.SelectedValue= _Dr["tipomanutenzione_id"].ToString();

			if (_Dr["tipointervento_id"] != DBNull.Value)
				cmbsTipoIntrevento.SelectedValue=_Dr["tipointervento_id"].ToString();
		
			if (_Dr["SGA"] != DBNull.Value)
				this.HSga.Value =_Dr["SGA"].ToString();
			
			if (_Dr["SGA"] != DBNull.Value)
				this.lblSGA.Text =_Dr["SGA"].ToString();

			LoadDataInvioSGA();		

			if (_Dr["SGA_NOTE"] != DBNull.Value)
				this.txtNoteSga.Text =_Dr["SGA_NOTE"].ToString();

			if (_Dr["SGA_SOLUZIONE_PROP"] != DBNull.Value)
				this.txtSoluzioneProposta.Text =_Dr["SGA_SOLUZIONE_PROP"].ToString();

			if (_Dr["sga_anomalia"] != DBNull.Value)
				this.txtCausa.Text =_Dr["sga_anomalia"].ToString();

			if (_Dr["sga_effetto"] != DBNull.Value)
				this.txtEffettoGuasto.Text =_Dr["sga_effetto"].ToString();

			//AGGIUNTA---
			//LoadAddettiDitta1(int.Parse(_Dr["servizio_id"].ToString()));
			LoadAddettiDitta(_Dr["bl_id"].ToString(), int.Parse(_Dr["servizio_id"].ToString()));
			
			//Addetto
			if (_Dr["addetto_id"] != DBNull.Value)
				this.cmbsAddetto.SelectedValue=_Dr["addetto_id"].ToString();	
				
			
			
			//Fine Caricamento Dati Richiesta
			
			//			if(_Dr["presidio"]!= DBNull.Value)
			//			{
			//				presidio.Text=_Dr["presidio"].ToString();
			LoadUrgenze(_Dr["id_bl"].ToString());
			//				if (presidio.Text=="0")
			//				{
			if (_Dr["priorita"] != DBNull.Value)
				cmbsUrgenza.SelectedValue=_Dr["priorita"].ToString();
			//				}
			//				if (presidio.Text=="1")
			//				{
			//					if (_Dr["priorita_p"] != DBNull.Value)
			//						cmbsUrgenza.SelectedValue=_Dr["priorita_p"].ToString();
			//				}
			//			
			//			}
		
			if (_Dr["order_estimate_id"] != DBNull.Value)
				TxtNumPreventivo.Text=_Dr["order_estimate_id"].ToString();

			if (_Dr["cost_est_other"] != DBNull.Value)
			{
				this.txtImpPrev1.Text=Classi.Function.GetTypeNumber(_Dr["cost_est_other"], TheSite.Classi.NumberType.Intero);  
				this.txtImpPrev2.Text =Classi.Function.GetTypeNumber(_Dr["cost_est_other"], TheSite.Classi.NumberType.Decimale);  
			}
			else
			{
				this.txtImpPrev1.Text="0";
				this.txtImpPrev2.Text="00";
			}
			if (_Dr["fpath_estimate"] != DBNull.Value)
			{
				btImgDelete.Visible =true;
				LkPrev.Visible=true;
			}
			else
			{
				btImgDelete.Visible =false;
				LkPrev.Visible=false;
			}


			//STATO DELLA RDL
				
			DataSet _MyDsStato= _ClManCorrettiva.GetStatusRdl(this.wr_id);
			if (_MyDsStato.Tables[0].Rows.Count>0)
			{
				DataRow _DrStato = _MyDsStato.Tables[0].Rows[0];
				string descrizionestato = _DrStato["descrizione"].ToString();
				LblMessaggio.Text="Stato della Richiesta di Lavoro : " + descrizionestato + " in data: " + _DrStato["data"]  ;
			}

			//SOPRALLUOGO
			if (_Dr["datasopralluogo"] != DBNull.Value)
				CalendarPicker4.Datazione.Text= System.DateTime.Parse(_Dr["datasopralluogo"].ToString()).ToShortDateString();
			
			//ORARIO SOPRALLUOGO
			string minuti="00";
			string ora="00";
			if (_Dr["datasopralluogo"] != DBNull.Value)
			{
				System.DateTime orasop= System.DateTime.Parse(_Dr["datasopralluogo"].ToString());
				ora=orasop.Hour.ToString();
				minuti=orasop.Minute.ToString();
				OraSopralluogo.SelectedValue=ora.PadLeft(2,Convert.ToChar("0"));
				MinutiSopralluogo.SelectedValue=minuti.PadLeft(2,Convert.ToChar("0"));
					
			}

			//DATASTART
			if (_Dr["date_est_start"] != DBNull.Value)
				CalendarPicker6.Datazione.Text= System.DateTime.Parse(_Dr["date_est_start"].ToString()).ToShortDateString();
			
			//ORARIO DATASTART
			minuti="00";
			ora="00";
			if (_Dr["date_est_start"] != DBNull.Value)
			{
				System.DateTime orarich= System.DateTime.Parse(_Dr["date_est_start"].ToString());
				ora=orarich.Hour.ToString();
				minuti=orarich.Minute.ToString();
				cmbOra1.SelectedValue=ora.PadLeft(2,Convert.ToChar("0"));
				cmbMin2.SelectedValue=minuti.PadLeft(2,Convert.ToChar("0"));
					
			}

			if(this.IsCompleta==true)//completamento
			{
				
				
				SetVisisbleCompletata();

				LoadStatoLavoro();
				//Carico lo stato dell'intervento della DIE
				LoadStatoIntervento();
				
				this.cmbsTipoIntrevento.AutoPostBack=true;
				cmbsstatolavoro.SelectedValue= _Dr["idstatus"].ToString();

				if (_Dr["cost_total"] != DBNull.Value)
				{
					this.ImpCons1.Text=Classi.Function.GetTypeNumber(_Dr["cost_total"], TheSite.Classi.NumberType.Intero);  
					this.ImpCons2.Text =Classi.Function.GetTypeNumber(_Dr["cost_total"], TheSite.Classi.NumberType.Decimale);  
				}
				else
				{
					this.ImpCons1.Text="0";
					this.ImpCons2.Text="00";
				}
				if (_Dr["fpath_consumptive"] != DBNull.Value)
				{
					btImgDeleteCons.Visible =true;
					LkCons.Visible=true;
				}
				else
				{
					btImgDeleteCons.Visible =false;
					LkCons.Visible=false;
				}
				
				BindCdC(int.Parse(_Dr["servizio_id"].ToString()));
				
				if (_Dr["contabilizzazione"] != DBNull.Value && 
					_Dr["contabilizzazione"].ToString()!="0"
					)					
					cmbCdC.SelectedValue=_Dr["contabilizzazione"].ToString();
				
				if (_Dr["nrord"] != DBNull.Value)					
					txtord.Text=_Dr["nrord"].ToString();
				

				//nota Sospesa
				if (_Dr["notesospesa"] != DBNull.Value)
					txtsAnnotazioni.Text = _Dr["notesospesa"].ToString();
				//note consuntivo
				if (_Dr["forfait_note"] != DBNull.Value)
					TxtAForfait.Text = _Dr["forfait_note"].ToString();
				
								if (_Dr["forfait"] != DBNull.Value)
								{
									OptAForfait.Checked = (_Dr["forfait"].ToString()=="0")?false:true;
//									if (_Dr["forfait"].ToString()=="0")
//										TxtAForfait.Enabled=false;
//									else
//										TxtAForfait.Enabled=true;
								}
								else
								{
									OptAMisura.Checked=true; 
								
								}		
	
				if (_Dr["date_start"]!=DBNull.Value)
					CalendarPicker7.Datazione.Text= System.DateTime.Parse(_Dr["date_start"].ToString()).ToShortDateString();

				if (_Dr["date_end"]!=DBNull.Value)
					CalendarPicker8.Datazione.Text= System.DateTime.Parse(_Dr["date_end"].ToString()).ToShortDateString();

				if (_Dr["date_start"]!=DBNull.Value)
				{
					System.DateTime OraIniz= System.DateTime.Parse(_Dr["date_start"].ToString());
					OraIni.SelectedValue =OraIniz.Hour.ToString().PadLeft(2,Convert.ToChar("0"))  ;
					MinitiIni.SelectedValue =OraIniz.Minute.ToString().PadLeft(2,Convert.ToChar("0")) ;
				}
				if (_Dr["date_end"]!=DBNull.Value)
				{
					System.DateTime OraFinez= System.DateTime.Parse(_Dr["date_end"].ToString());      
					OraFine.SelectedValue =OraFinez.Hour.ToString().PadLeft(2,Convert.ToChar("0")) ;
					MinutiFine.SelectedValue =OraFinez.Minute.ToString().PadLeft(2,Convert.ToChar("0"));
				}

				// Paolo   da rivedere il campo della query che seleziona il dato per questo picker
				if (_Dr["date_est_completion"]!=DBNull.Value)
					CalendarPicker10.Datazione.Text= System.DateTime.Parse(_Dr["date_est_completion"].ToString()).ToShortDateString();

				if (_Dr["date_est_completion"]!=DBNull.Value)
				{
					System.DateTime OraInizi= System.DateTime.Parse(_Dr["date_est_completion"].ToString());
					S_COMBOBOX2.SelectedValue =OraInizi.Hour.ToString().PadLeft(2,Convert.ToChar("0"))  ;
					S_COMBOBOX1.SelectedValue =OraInizi.Minute.ToString().PadLeft(2,Convert.ToChar("0")) ;
				}
				// Paolo


				if (_Dr["comments"] != DBNull.Value)
					cmbDescrizioneIntervento.Text = _Dr["comments"].ToString();

				if (_Dr["AC_ID"]!= DBNull.Value)
					txtBuonoLavoroEster.Text = _Dr["AC_ID"].ToString();

				if (_Dr["DISSERVIZIO"]!= DBNull.Value)
					CkDisser.Checked =( int.Parse(_Dr["DISSERVIZIO"].ToString())==1)?true:false;

				if (_Dr["DIE_TIPO_INTERVENTO"]!= DBNull.Value)
					cmbStatoIntervento.SelectedValue = _Dr["DIE_TIPO_INTERVENTO"].ToString();

				
				#region commento

								if (_Dr["DIE_COSTO_MATERIALE"]!= DBNull.Value)
								{
									txtCostiMateriali1.Text =Classi.Function.GetTypeNumber(_Dr["DIE_COSTO_MATERIALE"], TheSite.Classi.NumberType.Intero);  
									txtCostiMateriali2.Text=Classi.Function.GetTypeNumber(_Dr["DIE_COSTO_MATERIALE"], TheSite.Classi.NumberType.Decimale);  
								}
								else
								{
									this.txtCostiMateriali1.Text="0";
									this.txtCostiMateriali2.Text="00";
								}
								if (_Dr["DIE_COSTO_PERSONALE"]!= DBNull.Value)
								{
									txtCostiPersonale1.Text =Classi.Function.GetTypeNumber(_Dr["DIE_COSTO_PERSONALE"], TheSite.Classi.NumberType.Intero);  
									txtCostiPersonale2.Text=Classi.Function.GetTypeNumber(_Dr["DIE_COSTO_PERSONALE"], TheSite.Classi.NumberType.Decimale);  
								}
								else
								{
									this.txtCostiPersonale1.Text="0";
									this.txtCostiPersonale2.Text="00";
								}
				
								if (_Dr["DIE_COSTO_TOTALE"]!= DBNull.Value)
								{
									txtCostiTotale1.Text =Classi.Function.GetTypeNumber(_Dr["DIE_COSTO_TOTALE"], TheSite.Classi.NumberType.Intero);  
									txtCostiTotale2.Text=Classi.Function.GetTypeNumber(_Dr["DIE_COSTO_TOTALE"], TheSite.Classi.NumberType.Decimale);  
								}
								else
								{
									this.txtCostiTotale1.Text="0";
									this.txtCostiTotale2.Text="00";
								}
				#endregion
				if (_Dr["DIE_NOTE"]!= DBNull.Value)
					txtNoteCompletamento.Text=_Dr["DIE_NOTE"].ToString();		

				if (_Dr["satisfaction_id"] != DBNull.Value)
					RdListLivello.SelectedValue = _Dr["satisfaction_id"].ToString();

			}
		}
		/// <summary>
		/// Carico la descrizione dei documenti caricati
		/// </summary>
		private void LoadDocument()
		{

			DataSet _MyDs =  _ClManCorrettiva.GetDocumentazione(this.wr_id,"DOC");
			if(_MyDs.Tables[0].Rows.Count==0)
			{
				rpdc.Visible =false;
				return;
			}
			rpdc.Visible =true;
			rpdc.DataSource =_MyDs.Tables[0];
			rpdc.DataBind();

		


		}

		
		private void LoadSolleciti()
		{
		
			Classi.ManOrdinaria.Solleciti _Solleciti = new Classi.ManOrdinaria.Solleciti();
			DataSet _MyDs1 =  _Solleciti.GetDataWR(this.wr_id.ToString());
			if(_MyDs1.Tables[0].Rows.Count==0)
			{
				Repeater1.Visible =false;
				return;
			}
			Repeater1.Visible =true;
			Repeater1.DataSource =_MyDs1.Tables[0];
			Repeater1.DataBind();
		
		}

		private void LoadReclami()
		{
		
			Classi.ManOrdinaria.Reclamo _Reclamo = new Classi.ManOrdinaria.Reclamo();
			DataSet _MyDs2 =  _Reclamo.GetDataWR(this.wr_id.ToString());
			if(_MyDs2.Tables[0].Rows.Count==0)
			{
				Repeater2.Visible =false;
				return;
			}
			Repeater2.Visible =true;
			Repeater2.DataSource =_MyDs2.Tables[0];
			Repeater2.DataBind();
		
		}

		private void LoadChiarInfo()
		{
		
			Classi.ManOrdinaria.ChiariInfo _ChiariInfo = new Classi.ManOrdinaria.ChiariInfo();
			DataSet _MyDs3 =  _ChiariInfo.GetDataWR(this.wr_id.ToString());
			if(_MyDs3.Tables[0].Rows.Count==0)
			{
				Repeater3.Visible =false;
				return;
			}
			Repeater3.Visible =true;
			Repeater3.DataSource =_MyDs3.Tables[0];
			Repeater3.DataBind();
		
		}



		
		private void LoadDataInvioSGA()
		{
			//recupero data di invio sga
			DataSet DsData = _ClManCorrettiva.GetDataInvioSga(this.wr_id,DocType.SGA);
				
			if (DsData.Tables[0].Rows.Count == 1)
			{
				DataRow _DrData = DsData.Tables[0].Rows[0];
				LblDataInvioSga.Text="Data invio: " + _DrData["data_invio"].ToString();
			}
		}

		/// <summary>
		/// Carica il Tipo di manutenzione
		/// </summary>
		private void LoadTipoManutenzione()
		{
		
			DataSet _MyDs =  _ClManCorrettiva.GetTipoManutenzione();

			if (_MyDs.Tables[0].Rows.Count>0)
			{
				cmbsTipoManutenzione.DataSource = _MyDs.Tables[0];
				this.cmbsTipoManutenzione.DataTextField = "descrizione";
				this.cmbsTipoManutenzione.DataValueField = "id";
				this.cmbsTipoManutenzione.DataBind();
				this.cmbsTipoManutenzione.Attributes.Add("onchange","SetPreventivo(this.value);"); 
			}	
		}
		/// <summary>
		/// Carica lo stato dell'inetrevnto
		/// </summary>
		private void LoadStatoIntervento()
		{
		
			//			DataSet _MyDs =  _ClManCorrettiva.GetStatoInetervento();
			//
			//			if (_MyDs.Tables[0].Rows.Count>0)
			//			{
			//				cmbStatoIntervento.Items.Clear();
			//				cmbStatoIntervento.DataSource = _MyDs.Tables[0];
			//				this.cmbStatoIntervento.DataTextField = "descrizione";
			//				this.cmbStatoIntervento.DataValueField = "id";
			//				this.cmbStatoIntervento.DataBind();
			//			}	
		}
		/// <summary>
		/// Carica gli stati di lavoro di una richiesta
		/// </summary>
		/// <param name="stato_id"></param>
		private void LoadStatoLavoro()
		{
			this.cmbsstatolavoro.Items.Clear();		
		    

			DataSet _MyDs = _ClManCorrettiva.GetStatoLavoro();

			if (_MyDs.Tables[0].Rows.Count > 0)
			{
				this.cmbsstatolavoro.DataSource = Classi.GestoreDropDownList.ItemBlankDataSource(
					_MyDs.Tables[0], "descrizione", "id", "- Selezionare lo Stato di Lavoro  -", "");
				this.cmbsstatolavoro.DataTextField = "descrizione";
				this.cmbsstatolavoro.DataValueField = "id";
				this.cmbsstatolavoro.DataBind();          

				this.cmbsstatolavoro.Attributes.Add("onchange","SetStato(this.value);");

			}
			else
			{
				string s_Messagggio = "- Nessuno Stato di Lavoro  -";
				this.cmbsstatolavoro.Items.Add(Classi.GestoreDropDownList.ItemMessaggio(s_Messagggio, String.Empty));
			}
		}
		//Carico a il combo Del Tipo Intervento
		private void LoadTipoIntervento()
		{
			cmbsTipoIntrevento.Items.Clear();

			DataSet _MyDs;
			_MyDs = _ClManCorrettiva.GetTipointervento();
			if (_MyDs.Tables[0].Rows.Count > 0)
			{
				this.cmbsTipoIntrevento.DataSource =_MyDs.Tables[0];
				this.cmbsTipoIntrevento.DataTextField = "descrizione_breve";
				this.cmbsTipoIntrevento.DataValueField = "id";
				this.cmbsTipoIntrevento.DataBind();
			}
			else
			{
				string s_Messagggio = "- Nessun Tipo Intervento -";
				this.cmbsTipoIntrevento.Items.Add(Classi.GestoreDropDownList.ItemMessaggio(s_Messagggio, String.Empty));
			}
		}

		private void LoadPiani()
		{
			S_PIANO.Items.Clear();

			DataSet _MyDs;
			_MyDs = _ClManCorrettiva.GetPiani();
			if (_MyDs.Tables[0].Rows.Count > 0)
			{
				this.S_PIANO.DataSource =_MyDs.Tables[0];
				this.S_PIANO.DataTextField = "descrizione";
				this.S_PIANO.DataValueField = "id";
				this.S_PIANO.DataBind();
			}
			else
			{
				string s_Messagggio = "- Nessun Piano -";
				this.S_PIANO.Items.Add(Classi.GestoreDropDownList.ItemMessaggio(s_Messagggio, String.Empty));
			}
		}

		
		private void LoadPianibl(string id_bl)
		{
			S_PIANO.Items.Clear();

			DataSet _MyDs;
			_MyDs = _ClManCorrettiva.GetPianibl(id_bl);
			if (_MyDs.Tables[0].Rows.Count > 0)
			{
				this.S_PIANO.DataSource =_MyDs.Tables[0];
				this.S_PIANO.DataTextField = "descrizione";
				this.S_PIANO.DataValueField = "id";
				this.S_PIANO.DataBind();
			}
			else
			{
				string s_Messagggio = "- Nessun Piano -";
				this.S_PIANO.Items.Add(Classi.GestoreDropDownList.ItemMessaggio(s_Messagggio, String.Empty));
			}
		}

		

		/// <summary>
		/// Carica i Servizi di un detereminato edificio
		/// </summary>
		/// <param name="CodiceEdificio"></param>
		private void LoadServizio(string CodiceEdificio)
		{
			this.cmbsServizio.Items.Clear();		
			S_ControlsCollection CollezioneControlli = new  S_ControlsCollection();

			DataSet _MyDs;

		
			S_Controls.Collections.S_Object s_Bl_Id = new S_Object();
			s_Bl_Id.ParameterName = "p_bl_id";
			s_Bl_Id.DbType = CustomDBType.Integer;
			s_Bl_Id.Direction = ParameterDirection.Input;
			s_Bl_Id.Index = 0;
			s_Bl_Id.Value =	CodiceEdificio;
		
	
			CollezioneControlli.Add(s_Bl_Id);				
		

			_MyDs = _ClManCorrettiva.GetServiceBulding2(CollezioneControlli);

			if (_MyDs.Tables[0].Rows.Count > 0)
			{
//				this.cmbsServizio.DataSource = Classi.GestoreDropDownList.ItemBlankDataSource(
//					_MyDs.Tables[0], "DESCRIZIONE", "IDSERVIZIO", "Non Definito", "");
				this.cmbsServizio.DataSource =_MyDs.Tables[0];
				this.cmbsServizio.DataTextField = "DESCRIZIONE";
				this.cmbsServizio.DataValueField = "IDSERVIZIO";
				this.cmbsServizio.DataBind();
			}
			else
			{
				string s_Messagggio = "Non Definito";
				this.cmbsServizio.Items.Add(Classi.GestoreDropDownList.ItemMessaggio(s_Messagggio, ""));
			}
		}
		/// <summary>
		/// Carico gli standard apparechiature
		/// </summary>
		private void LoadStandardApparechiature()
		{
			
//			if (this.cmbsServizio.SelectedIndex==0)
//			{
//				cmdsStdApparecchiatura.Items.Clear();
//				string s_Messagggio = "- Nessuno Standard -";
//				this.cmdsStdApparecchiatura.Items.Add(Classi.GestoreDropDownList.ItemMessaggio(s_Messagggio, String.Empty));
//			}
//			else
//			{
				this.cmdsStdApparecchiatura.Items.Clear();
			
				DataSet _MyDs;

				S_ControlsCollection _SColl = new S_ControlsCollection();

				S_Controls.Collections.S_Object s_BlId = new S_Object();
				s_BlId.ParameterName = "p_Bl_Id";
				s_BlId.DbType = CustomDBType.VarChar;
				s_BlId.Direction = ParameterDirection.Input;
				s_BlId.Size =50;
				s_BlId.Index = 0;
				s_BlId.Value = txtHidBl.Text;
				_SColl.Add(s_BlId);
		
				S_Controls.Collections.S_Object s_Servizio = new S_Object();
				s_Servizio.ParameterName = "p_Servizio";
				s_Servizio.DbType = CustomDBType.Integer;
				s_Servizio.Direction = ParameterDirection.Input;
				s_Servizio.Index = 1;
				s_Servizio.Value = (cmbsServizio.SelectedValue=="")? 0:Int32.Parse(cmbsServizio.SelectedValue);
				_SColl.Add(s_Servizio);

				_MyDs = _ClManCorrettiva.GetStandardApparechiature(_SColl);
           
  
				if (_MyDs.Tables[0].Rows.Count > 0)
				{
					this.cmdsStdApparecchiatura.DataSource = Classi.GestoreDropDownList.ItemBlankDataSource(
						_MyDs.Tables[0], "DESCRIZIONE", "ID", "- Selezionare uno Standard -", "");
					this.cmdsStdApparecchiatura.DataTextField = "DESCRIZIONE";
					this.cmdsStdApparecchiatura.DataValueField = "ID";
					this.cmdsStdApparecchiatura.DataBind();
				}
				else
				{
					cmdsStdApparecchiatura.Items.Clear();
					string s_Messagggio = "- Nessuno Standard -";
					this.cmdsStdApparecchiatura.Items.Add(Classi.GestoreDropDownList.ItemMessaggio(s_Messagggio, String.Empty));
				}
			//}
		}
		/// <summary>
		/// Carico le apparechiature
		/// </summary>
		private void LoadApparechiature()
		{
//			if (this.cmbsServizio.SelectedIndex==0)
//			{
//				cmbEQ.Items.Clear();
//				string s_Messagggio = "- Nessuna Apparecchiatura -";
//				this.cmbEQ.Items.Add(Classi.GestoreDropDownList.ItemMessaggio(s_Messagggio, String.Empty));
//			}
//			else
//			{
				///Istanzio un nuovo oggetto Collection per aggiungere i parametri
				S_Controls.Collections.S_ControlsCollection _SCollection = new S_Controls.Collections.S_ControlsCollection();
				///creo i parametri
		
				S_Controls.Collections.S_Object s_p_Bl_Id = new S_Controls.Collections.S_Object();
				s_p_Bl_Id.ParameterName = "p_Bl_Id";
				s_p_Bl_Id.DbType = ApplicationDataLayer.DBType.CustomDBType.VarChar;
				s_p_Bl_Id.Direction = ParameterDirection.Input;
				s_p_Bl_Id.Size =50;
				s_p_Bl_Id.Index = _SCollection.Count;
				s_p_Bl_Id.Value = "";
				_SCollection.Add(s_p_Bl_Id);

				//				S_Controls.Collections.S_Object s_p_campus = new S_Controls.Collections.S_Object();
				//				s_p_campus.ParameterName = "p_campus";
				//				s_p_campus.DbType = ApplicationDataLayer.DBType.CustomDBType.VarChar;
				//				s_p_campus.Direction = ParameterDirection.Input;
				//				s_p_campus.Index = 1;
				//				s_p_campus.Size=50;
				//				s_p_campus.Value = lblfabbricato.Text;
				//				///Aggiungo i parametri alla collection
				//				_SCollection.Add(s_p_campus);

				S_Controls.Collections.S_Object s_p_Servizio = new S_Controls.Collections.S_Object();
				s_p_Servizio.ParameterName = "p_Servizio";
				s_p_Servizio.DbType = ApplicationDataLayer.DBType.CustomDBType.Integer;
				s_p_Servizio.Direction = ParameterDirection.Input;
				s_p_Servizio.Index = _SCollection.Count;
				s_p_Servizio.Value = (cmbsServizio.SelectedValue ==string.Empty)? 0:Int32.Parse(cmbsServizio.SelectedValue);
				///Aggiungo i parametri alla collection
				_SCollection.Add(s_p_Servizio);

				S_Controls.Collections.S_Object s_p_eqstdid = new S_Controls.Collections.S_Object();
				s_p_eqstdid.ParameterName = "p_eqstdid";
				s_p_eqstdid.DbType = ApplicationDataLayer.DBType.CustomDBType.Integer;
				s_p_eqstdid.Direction = ParameterDirection.Input;
				s_p_eqstdid.Size =8;
				s_p_eqstdid.Index = _SCollection.Count;
				s_p_eqstdid.Value = (cmdsStdApparecchiatura.SelectedValue==string.Empty)? 0:Int32.Parse(cmdsStdApparecchiatura.SelectedValue);
				_SCollection.Add(s_p_eqstdid);

				//				S_Controls.Collections.S_Object s_p_eq_id = new S_Controls.Collections.S_Object();
				//				s_p_eq_id.ParameterName = "p_eq_id";
				//				s_p_eq_id.DbType = ApplicationDataLayer.DBType.CustomDBType.VarChar;
				//				s_p_eq_id.Direction = ParameterDirection.Input;
				//				s_p_eq_id.Size =8;
				//				s_p_eq_id.Index = 4;
				//				s_p_eq_id.Size =50;
				//				s_p_eq_id.Value = (cmbEQ.SelectedValue==string.Empty)? "":cmbEQ.Items[cmbEQ.SelectedIndex].Text;
				//				_SCollection.Add(s_p_eq_id);

				//				S_Controls.Collections.S_Object p_dismesso = new S_Controls.Collections.S_Object();
				//				p_dismesso.ParameterName = "p_dismesso";
				//				p_dismesso.DbType = ApplicationDataLayer.DBType.CustomDBType.VarChar;
				//				p_dismesso.Direction = ParameterDirection.Input;
				//				p_dismesso.Size =8;
				//				p_dismesso.Index = 4;
				//				p_dismesso.Size =50;
				//				p_dismesso.Value = 1;
				//				_SCollection.Add(p_dismesso);

				
				DataSet _MyDs=_ClManCorrettiva.GetListaEQ(_SCollection);

				if (_MyDs.Tables[0].Rows.Count > 0)
				{
					this.cmbEQ.DataSource = Classi.GestoreDropDownList.ItemBlankDataSource(
						_MyDs.Tables[0], "ID", "id_eq", "- Selezionare un' Apparecchiatura -", "");
					this.cmbEQ.DataTextField = "ID";
					this.cmbEQ.DataValueField = "id_eq";
					this.cmbEQ.DataBind();
				}
				else
				{
					cmbEQ.Items.Clear();
					string s_Messagggio = "- Nessuna Apparecchiatura -";
					this.cmbEQ.Items.Add(Classi.GestoreDropDownList.ItemMessaggio(s_Messagggio, String.Empty));
				}	
			//}
		}
	
		
		/// </summary>
		private void LoadUrgenze(string Codice)
		{
			
			if(Codice!="")
			{
				int cod= Convert.ToInt32(Codice);
				Classi.ClassiDettaglio.Urgenza _Urgenza = new TheSite.Classi.ClassiDettaglio.Urgenza();
				cmbsUrgenza.Items.Clear(); 
				this.cmbsUrgenza.DataSource = _Urgenza.GetPriorita(cod);
				this.cmbsUrgenza.DataTextField = "DESCRIPTION";
				this.cmbsUrgenza.DataValueField = "ID";
				this.cmbsUrgenza.DataBind();
				//this.cmbsUrgenza.SelectedValue = "7";
			}
			else
			{
				string s_Messagggio = "- Nessuna urgenza -";
				this.cmbsUrgenza.Items.Add(Classi.GestoreDropDownList.ItemMessaggio(s_Messagggio, String.Empty));
			}
			
		}
		/// <summary>
		/// carica gli addetti in base ad una ditta ed ad un edificio
		/// </summary>
		/// <param name="bl_id"></param>
		/// <param name="ditta_id"></param>
		private void LoadAddettiDitta(string bl_id, int servizi_id)
		{	
			this.cmbsAddetto.Items.Clear();				
			

			DataSet _MyDs;

			//_MyDs = _ClManCorrettiva.GetAddetti("",bl_id,ditta_id,servizi_id);
			_MyDs = _ClManCorrettiva.GetAddetti_data("",bl_id,servizi_id,wr_id);

			if (_MyDs.Tables[0].Rows.Count > 0)
			{
				this.cmbsAddetto.DataSource = Classi.GestoreDropDownList.ItemBlankDataSource(
					_MyDs.Tables[0], "NOMINATIVO", "ID", "- Selezionare un Addetto -", "0");
				this.cmbsAddetto.DataTextField = "NOMINATIVO";
				this.cmbsAddetto.DataValueField = "ID";
				this.cmbsAddetto.DataBind();
			}
			else
			{
				string s_Messagggio = "- Nessun Addetto  -";
				this.cmbsAddetto.Items.Add(Classi.GestoreDropDownList.ItemMessaggio(s_Messagggio, "0"));
			}		
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
			this.BtUpload.Click += new System.EventHandler(this.BtUpload_Click);
			this.rpdc.ItemDataBound += new System.Web.UI.WebControls.RepeaterItemEventHandler(this.rpdc_ItemDataBound);
			this.rpdc.ItemCommand += new System.Web.UI.WebControls.RepeaterCommandEventHandler(this.rpdc_ItemCommand);
			this.Repeater1.ItemDataBound += new System.Web.UI.WebControls.RepeaterItemEventHandler(this.Repeater1_ItemDataBound);
			this.Repeater2.ItemDataBound += new System.Web.UI.WebControls.RepeaterItemEventHandler(this.Repeater2_ItemDataBound);
			this.Repeater3.ItemDataBound += new System.Web.UI.WebControls.RepeaterItemEventHandler(this.Repeater3_ItemDataBound);
			this.BtInviaPreventivo.Click += new System.EventHandler(this.BtInviaPreventivo_Click);
			this.btImgDelete.Click += new System.Web.UI.ImageClickEventHandler(this.btImgDelete_Click);
			this.BtSalvaSGA.Click += new System.EventHandler(this.BtSalvaSGA_Click);
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.btRifiuta.Click += new System.EventHandler(this.btRifiuta_Click);
			this.btSospendi.Click += new System.EventHandler(this.btSospendi_Click);
			this.btApprova.Click += new System.EventHandler(this.btApprova_Click);
			this.BtInviaCons.Click += new System.EventHandler(this.BtInviaCons_Click);
			this.btImgDeleteCons.Click += new System.Web.UI.ImageClickEventHandler(this.btImgDeleteCons_Click);
			this.BtSalva.Click += new System.EventHandler(this.BtSalva_Click);
			this.BtDIE.Click += new System.EventHandler(this.BtDIE_Click);
			this.btFoglioPdf.Click += new System.EventHandler(this.btFoglioPdf_Click);
			this.btChiudi.Click += new System.EventHandler(this.btChiudi_Click);
			this.btFoglio.Click += new System.EventHandler(this.btFoglio_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void BtSalvaSGA_Click(object sender, System.EventArgs e)
		{
			
			SaveSGA();
			//SendSGA();
			string percorso="";
			Classi.RptRtf.SGA_DIE sd =new TheSite.Classi.RptRtf.SGA_DIE();
			percorso=sd.GENERAPDFSGA(int.Parse(Request["wr_id"]),lblSGA.Text,Context.User.Identity.Name);
			LoadDati();

		}
		private void SendSGA()
		{
			string formatdate=DateTime.Now.Millisecond.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Hour.ToString() +DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() +DateTime.Now.Year.ToString();	
			
			string fileName="";
			if (HPrj.Value=="2") // vodafone
				fileName = @"\XSLT\XSLsgaRptVod04.xslt";
			else
				fileName = @"\XSLT\XSLsgaRpt04.xslt";
			string PathSgaXlst = Server.MapPath(Request.ApplicationPath + fileName);
			TheSite.Classi.RptRtf.SGARTF trs = new TheSite.Classi.RptRtf.SGARTF();
			trs.FileXlst = PathSgaXlst;
			string[] Files=trs.GeneraRtf(this.wr_id,formatdate);
			TheSite.Classi.MailSend mail=new TheSite.Classi.MailSend();
			SaveInvio(Files[1],DocType.SGA);
			mail.SendMail(Files[0],this.wr_id,DocType.SGA);
		}

	
		private S_ControlsCollection GetSgaParameter()
		{
			S_ControlsCollection _SColl = new S_ControlsCollection();
		
			S_Controls.Collections.S_Object p = new S_Object();
			p.ParameterName = "p_wr_id";
			p.DbType = CustomDBType.Integer;
			p.Direction = ParameterDirection.Input;
			p.Index = _SColl.Count;
			p.Value = this.wr_id;
			_SColl.Add(p);

			
			p = new S_Object();
			p.ParameterName = "p_servizio";
			p.DbType = CustomDBType.Integer;
			p.Direction = ParameterDirection.Input;
			p.Index = _SColl.Count;
			if (cmbsServizio.SelectedValue=="" || cmbsServizio.SelectedValue=="0")
				p.Value = DBNull.Value;
			else
				p.Value =int.Parse(cmbsServizio.SelectedValue);
			_SColl.Add(p);

			
			p = new S_Object();
			p.ParameterName = "p_stdapparecchiatura";
			p.DbType = CustomDBType.Integer;
			p.Direction = ParameterDirection.Input;
			p.Index = _SColl.Count;
			if (cmdsStdApparecchiatura.SelectedValue=="" || cmdsStdApparecchiatura.SelectedValue=="0")
				p.Value =DBNull.Value;
			else
				p.Value =int.Parse(cmdsStdApparecchiatura.SelectedValue);
			_SColl.Add(p);

			p = new S_Object();
			p.ParameterName = "p_eq";
			p.DbType = CustomDBType.Integer;
			p.Direction = ParameterDirection.Input;
			p.Index = _SColl.Count;
			if (cmbEQ.SelectedValue=="" || cmbEQ.SelectedValue=="0")
				p.Value =DBNull.Value;
			else
				p.Value =int.Parse(cmbEQ.SelectedValue);
			_SColl.Add(p);

			p = new S_Object();
			p.ParameterName = "p_datarichiesta";
			p.DbType = CustomDBType.Date;
			p.Direction = ParameterDirection.Input;
			p.Index = _SColl.Count;
	
			string data_startrich =string.Empty; 
			data_startrich=CalendarPicker1.Datazione.Text;
			if(data_startrich!="")
			{ 
				string ora_iniziorich=((S_COMBOBOX4.SelectedValue=="")?"00":S_COMBOBOX4.SelectedValue) + ":" + ((S_COMBOBOX3.SelectedValue=="")?"00":S_COMBOBOX3.SelectedValue) + ":00";
				data_startrich += " " + ora_iniziorich;  
			}
			if(data_startrich!="")
				p.Value =data_startrich;
			else
				p.Value =DBNull.Value;
			
			_SColl.Add(p);

			p = new S_Object();
			p.ParameterName = "p_id_fl";
			p.DbType = CustomDBType.Integer;
			p.Direction = ParameterDirection.Input;
			p.Index = _SColl.Count;
			p.Value = int.Parse(S_PIANO.SelectedValue); 
			_SColl.Add(p);
			
			p = new S_Object();
			p.ParameterName = "p_id_rm";
			p.DbType = CustomDBType.Integer;
			p.Direction = ParameterDirection.Input;
			p.Index = _SColl.Count;
			p.Value =(UserStanzeRic1.IdStanza=="")?0:int.Parse(UserStanzeRic1.IdStanza);
			_SColl.Add(p);

			p = new S_Object();
			p.ParameterName = "p_id_rm_cat";
			p.DbType = CustomDBType.Integer;
			p.Direction = ParameterDirection.Input;
			p.Index = _SColl.Count;
			p.Value = 
				(S_macroarea.SelectedValue=="")?29:int.Parse(S_macroarea.SelectedValue);
			
			_SColl.Add(p);

			p = new S_Object();
			p.ParameterName = "p_descrizione";
			p.DbType = CustomDBType.VarChar;
			p.Direction = ParameterDirection.Input;
			p.Size =4000;
			p.Index = _SColl.Count;
			p.Value =txtsDescrizione.Text;
			_SColl.Add(p);

			p = new S_Object();
			p.ParameterName = "p_anomalia";
			p.DbType = CustomDBType.VarChar;
			p.Direction = ParameterDirection.Input;
			p.Size =408;
			p.Index = _SColl.Count;
			p.Value =txtCausa.Text;
			_SColl.Add(p);

			p = new S_Object();
			p.ParameterName = "p_effetto";
			p.DbType = CustomDBType.VarChar;
			p.Direction = ParameterDirection.Input;
			p.Size =408;
			p.Index = _SColl.Count;
			p.Value =txtEffettoGuasto.Text;
			_SColl.Add(p);

			p = new S_Object();
			p.ParameterName = "p_soluzione";
			p.DbType = CustomDBType.VarChar;
			p.Direction = ParameterDirection.Input;
			p.Size =408;
			p.Index = _SColl.Count;
			p.Value =txtSoluzioneProposta.Text;
			_SColl.Add(p);

			// DATASOPRALLUOGO
			p = new S_Object();
			p.ParameterName = "p_datasopralluogo";
			p.DbType = CustomDBType.VarChar;
			p.Direction = ParameterDirection.Input;
			p.Index = _SColl.Count;			
			p.Size=30;

			//Data Sopralluogo	
			string data_sopralluogo=CalendarPicker4.Datazione.Text;
			if(data_sopralluogo!="")
			{ 
				string ora_sopralluogo= ((OraSopralluogo.SelectedValue=="")?"00":OraSopralluogo.SelectedValue) + ":" + ((MinutiSopralluogo.SelectedValue=="")?"00":MinutiSopralluogo.SelectedValue) + ":00";
				data_sopralluogo = data_sopralluogo + " " + ora_sopralluogo;  
			}
			p.Value = data_sopralluogo;
			_SColl.Add(p);

			// DATAINIZIO
			p = new S_Object();
			p.ParameterName = "p_datainizio";
			p.DbType = CustomDBType.Date;
			p.Direction = ParameterDirection.Input;
			p.Index = _SColl.Count;			
			p.Size=30;

			//Data Inizio
			string data_inizio=CalendarPicker6.Datazione.Text;
			if(data_inizio!="")
			{ 
				string ora_inizio= ((cmbOra1.SelectedValue=="")?"00":cmbOra1.SelectedValue) + ":" + ((cmbMin2.SelectedValue=="")?"00":cmbMin2.SelectedValue) + ":00";
				data_inizio = data_inizio + " " + ora_inizio;  
			}
			p.Value = data_inizio;
			_SColl.Add(p);


			p = new S_Object();
			p.ParameterName = "p_datefine";
			p.DbType = CustomDBType.Date;
			p.Direction = ParameterDirection.Input;
			p.Index = _SColl.Count;
			if (CalendarPicker2.Datazione.Text=="")  
				p.Value =DBNull.Value;
			else
			{
				string data_end1 =string.Empty; 
				data_end1=CalendarPicker2.Datazione.Text;
				if(data_end1!="")
				{ 
					string ora_end=((cmborafinelav.SelectedValue=="")?"00":cmborafinelav.SelectedValue) + ":" + ((cmbminfinelav.SelectedValue=="")?"00":cmbminfinelav.SelectedValue) + ":00";
					data_end1 += " " + ora_end;  
				}
				if(data_end1!="")
					p.Value =data_end1;
				else
					p.Value =DBNull.Value;


			}
			_SColl.Add(p);

			p = new S_Object();
			p.ParameterName = "p_tipomanutenzione";
			p.DbType = CustomDBType.Integer;
			p.Direction = ParameterDirection.Input;
			p.Index = _SColl.Count;
			p.Value =int.Parse(cmbsTipoManutenzione.SelectedValue);  
			_SColl.Add(p);

			
		
			p = new S_Object();
			p.ParameterName = "p_tipointervento";
			p.DbType = CustomDBType.Integer;
			p.Direction = ParameterDirection.Input;
			p.Index = _SColl.Count;
			p.Value =int.Parse(cmbsTipoIntrevento.SelectedValue);  
			_SColl.Add(p);

			



//			p = new S_Object();
//			p.ParameterName = "p_modalita";
//			p.DbType = CustomDBType.VarChar;
//			p.Direction = ParameterDirection.Input;
//			p.Index = _SColl.Count;
//			p.Size=112;
//			p.Value =txtModalitaPagamento.Text; 
//			_SColl.Add(p);

			p = new S_Object();
			p.ParameterName = "p_note";
			p.DbType = CustomDBType.VarChar;
			p.Direction = ParameterDirection.Input;
			p.Index = _SColl.Count;
			p.Size=408;
			p.Value =txtNoteSga.Text; 
			_SColl.Add(p);


			return _SColl;
		}

		private S_ControlsCollection GetSgaParameterCompletamentotestata()
		{
			S_ControlsCollection _SColl = new S_ControlsCollection();
		
			S_Controls.Collections.S_Object p = new S_Object();
			p.ParameterName = "p_wr_id";
			p.DbType = CustomDBType.Integer;
			p.Direction = ParameterDirection.Input;
			p.Index = _SColl.Count;
			p.Value = this.wr_id;
			_SColl.Add(p);
				

			p = new S_Object();
			p.ParameterName = "p_descrizione";
			p.DbType = CustomDBType.VarChar;
			p.Direction = ParameterDirection.Input;
			p.Size =4000;
			p.Index = _SColl.Count;
			p.Value =txtsDescrizione.Text;
			_SColl.Add(p);

			p = new S_Object();
			p.ParameterName = "p_anomalia";
			p.DbType = CustomDBType.VarChar;
			p.Direction = ParameterDirection.Input;
			p.Size =408;
			p.Index = _SColl.Count;
			p.Value =txtCausa.Text;
			_SColl.Add(p);

			p = new S_Object();
			p.ParameterName = "p_effetto";
			p.DbType = CustomDBType.VarChar;
			p.Direction = ParameterDirection.Input;
			p.Size =408;
			p.Index = _SColl.Count;
			p.Value =txtEffettoGuasto.Text;
			_SColl.Add(p);

			p = new S_Object();
			p.ParameterName = "p_soluzione";
			p.DbType = CustomDBType.VarChar;
			p.Direction = ParameterDirection.Input;
			p.Size =408;
			p.Index = _SColl.Count;
			p.Value =txtSoluzioneProposta.Text;
			_SColl.Add(p);
			
			// DATASOPRALLUOGO
			p = new S_Object();
			p.ParameterName = "p_datasopralluogo";
			p.DbType = CustomDBType.VarChar;
			p.Direction = ParameterDirection.Input;
			p.Index = _SColl.Count;			
			p.Size=30;

			//Data Sopralluogo	
			string data_sopralluogo=CalendarPicker4.Datazione.Text;
			if(data_sopralluogo!="")
			{ 
				string ora_sopralluogo= ((OraSopralluogo.SelectedValue=="")?"00":OraSopralluogo.SelectedValue) + ":" + ((MinutiSopralluogo.SelectedValue=="")?"00":MinutiSopralluogo.SelectedValue) + ":00";
				data_sopralluogo = data_sopralluogo + " " + ora_sopralluogo;  
			}
			p.Value = data_sopralluogo;
			_SColl.Add(p);


			p = new S_Object();
			p.ParameterName = "p_datainizio";
			p.DbType = CustomDBType.Date;
			p.Direction = ParameterDirection.Input;
			p.Index = _SColl.Count;
			if (CalendarPicker6.Datazione.Text=="")  
				p.Value =DBNull.Value;
			else
			{	string data_end1 =string.Empty; 
			data_end1=CalendarPicker6.Datazione.Text;
			if(data_end1!="")
			{ 
				string ora_end=((cmbOra1.SelectedValue=="")?"00":cmbOra1.SelectedValue) + ":" + ((cmbMin2.SelectedValue=="")?"00":cmbMin2.SelectedValue) + ":00";
				data_end1 += " " + ora_end;  
			}
			if(data_end1!="")
				p.Value =data_end1;
			else
				p.Value =DBNull.Value;}
			_SColl.Add(p);

			p = new S_Object();
			p.ParameterName = "p_datefine";
			p.DbType = CustomDBType.Date;
			p.Direction = ParameterDirection.Input;
			p.Index = _SColl.Count;
			if (CalendarPicker2.Datazione.Text=="")  
				p.Value =DBNull.Value;
			else
			{
				string data_end1 =string.Empty; 
				data_end1=CalendarPicker2.Datazione.Text;
				if(data_end1!="")
				{ 
					string ora_end=((cmborafinelav.SelectedValue=="")?"00":cmborafinelav.SelectedValue) + ":" + ((cmbminfinelav.SelectedValue=="")?"00":cmbminfinelav.SelectedValue) + ":00";
					data_end1 += " " + ora_end;  
				}
				if(data_end1!="")
					p.Value =data_end1;
				else
					p.Value =DBNull.Value;
			}
			_SColl.Add(p);

			p = new S_Object();
			p.ParameterName = "p_tipomanutenzione";
			p.DbType = CustomDBType.Integer;
			p.Direction = ParameterDirection.Input;
			p.Index = _SColl.Count;
			p.Value =int.Parse(cmbsTipoManutenzione.SelectedValue);  
			_SColl.Add(p);

			p = new S_Object();
			p.ParameterName = "p_tipointervento";
			p.DbType = CustomDBType.Integer;
			p.Direction = ParameterDirection.Input;
			p.Index = _SColl.Count;
			p.Value =int.Parse(cmbsTipoIntrevento.SelectedValue);  


			return _SColl;
		}

		
		private int SaveSGA()
		{
			int result=0;
			S_ControlsCollection _SColl =GetSgaParameter();

			S_Object p = new S_Object();
			p.ParameterName = "p_stato";
			p.DbType = CustomDBType.Integer;
			p.Direction = ParameterDirection.Input;
			p.Index = _SColl.Count;
			p.Value =-1; 
			_SColl.Add(p);


			result= _ClManCorrettiva.ExecuteUpdateSGA(_SColl); 
			return result;
		}



		private void BtUpload_Click(object sender, System.EventArgs e)
		{
			if (UploadFile.PostedFile!=null && UploadFile.PostedFile.FileName!="") 
			{
				string fileName= System.IO.Path.GetFileName(UploadFile.PostedFile.FileName);

				string destDir =Server.MapPath("../Doc_DB");
				string folderChild=System.IO.Path.Combine(destDir, txtHidBl.Text);
				if (!Directory.Exists(folderChild))
					Directory.CreateDirectory(folderChild);	

				folderChild=System.IO.Path.Combine(folderChild, this.wr_id.ToString());
				if (!Directory.Exists(folderChild))
					Directory.CreateDirectory(folderChild);

				string destPath  = System.IO.Path.Combine(folderChild, fileName);
				UploadFile.PostedFile.SaveAs(destPath);	
				//Salvo il documento nella tabella
				
				SaveDocument(fileName,UploadFile.PostedFile.ContentLength.ToString(),"DOC");
				LoadDocument();
			}
		}
		private void SaveDocument(string filename, string dimesione, string tipodoc)
		{
			S_ControlsCollection _SColl = new S_ControlsCollection();
			int result=0;
		
			S_Controls.Collections.S_Object p = new S_Object();
			p.ParameterName = "p_wr_id";
			p.DbType = CustomDBType.Integer;
			p.Direction = ParameterDirection.Input;
			p.Index = _SColl.Count;
			p.Value = this.wr_id;
			_SColl.Add(p);

			p = new S_Object();
			p.ParameterName = "p_nomedoc";
			p.DbType = CustomDBType.VarChar;
			p.Direction = ParameterDirection.Input;
			p.Size =255;
			p.Index = _SColl.Count;
			p.Value = filename;
			_SColl.Add(p);

			p = new S_Object();
			p.ParameterName = "p_estenzione";
			p.DbType = CustomDBType.VarChar;
			p.Direction = ParameterDirection.Input;
			p.Size =25;
			p.Index = _SColl.Count;
			p.Value =Path.GetExtension(filename);
			_SColl.Add(p);

			p = new S_Object();
			p.ParameterName = "p_dimensione";
			p.DbType = CustomDBType.VarChar;
			p.Direction = ParameterDirection.Input;
			p.Size =255;
			p.Index = _SColl.Count;
			p.Value =dimesione.ToString();
			_SColl.Add(p);

			p = new S_Object();
			p.ParameterName = "p_tipo";
			p.DbType = CustomDBType.VarChar;
			p.Direction = ParameterDirection.Input;
			p.Size =255;
			p.Index = _SColl.Count;
			p.Value =tipodoc;
			_SColl.Add(p);

			p = new S_Object();
			p.ParameterName = "p_operazione";
			p.DbType = CustomDBType.Integer;
			p.Direction = ParameterDirection.Input;
			p.Index = _SColl.Count;
			p.Value =1;//Inserimento
			_SColl.Add(p);

			result= _ClManCorrettiva.ExecuteUpdateDOC1(_SColl); 
		}

		private void rpdc_ItemDataBound(object sender, System.Web.UI.WebControls.RepeaterItemEventArgs e)
		{
			if(e.Item.ItemType ==ListItemType.Item ||   e.Item.ItemType ==ListItemType.AlternatingItem)
			{
				string filename= ((DataRowView)e.Item.DataItem)["NOME_DOC"].ToString();  
				string destDir =  "../Doc_DB/" +  txtHidBl.Text + "/" + this.wr_id.ToString() + "/" +filename;
				Label lbl=	e.Item.FindControl("lbln") as Label;
				lbl.Text="<a href=\"" + destDir + "\" target=\"_blank\">" + filename +"</a>";

				ImageButton bt=e.Item.FindControl("delete") as ImageButton; 
				bt.Attributes.Add("onclick", "return deletedoc();");
			}
		}

		private void rpdc_ItemCommand(object source, System.Web.UI.WebControls.RepeaterCommandEventArgs e)
		{
			if(e.CommandName.ToLower().Equals("delete")) 
			{
				
				if (this.IsCompletata) return;

				S_ControlsCollection _SColl = new S_ControlsCollection();
				string [] vari=e.CommandArgument.ToString().Split(',');
		
				S_Controls.Collections.S_Object p = new S_Object();
				p.ParameterName = "p_id_file";
				p.DbType = CustomDBType.Integer;
				p.Direction = ParameterDirection.Input;
				p.Index = _SColl.Count;
				p.Value = vari[0];
				_SColl.Add(p);


				p = new S_Object();
				p.ParameterName = "p_operazione";
				p.DbType = CustomDBType.Integer;
				p.Direction = ParameterDirection.Input;
				p.Index = _SColl.Count;
				p.Value =2;//Inserimento
				_SColl.Add(p);

				_ClManCorrettiva.ExecuteUpdateDOC(_SColl);

				string destDir =Server.MapPath("../Doc_DB");
				
				destDir=System.IO.Path.Combine(destDir, txtHidBl.Text);
				destDir=System.IO.Path.Combine(destDir, this.wr_id.ToString());
				destDir=System.IO.Path.Combine(destDir, vari[1]);
				File.Delete(destDir);
				LoadDocument();
			}

		}



	
		private S_ControlsCollection GetParamEmissione(S_ControlsCollection _SColl)
		{

			// URGENZA
			S_Controls.Collections.S_Object p = new S_Object();
			p.ParameterName = "p_urgenza";
			p.DbType = CustomDBType.Integer;
			p.Direction = ParameterDirection.Input;
			p.Index = _SColl.Count;
			p.Value = cmbsUrgenza.SelectedValue; //Int32.Parse(cmbsUrgenza.SelectedValue.Split(Convert.ToChar(","))[0]);	
			_SColl.Add(p);

			p = new S_Object();
			p.ParameterName = "p_addetto_id";
			p.DbType = CustomDBType.Integer;
			p.Direction = ParameterDirection.Input;
			p.Index = _SColl.Count;
			if(cmbsAddetto.SelectedValue=="0")
				p.Value = DBNull.Value;
			else
				p.Value =int.Parse(cmbsAddetto.SelectedValue);
			_SColl.Add(p);
			
			
			

//			// ID_DITTA
//			p = new S_Object();
//			p.ParameterName = "p_id_ditta";
//			p.DbType = CustomDBType.Integer;
//			p.Direction = ParameterDirection.Input;
//			p.Index = _SColl.Count;
//			p.Value = (cmbsDitta.SelectedValue=="")?0:int.Parse(cmbsDitta.SelectedValue);
//			_SColl.Add(p);

//			// ID dell'edificio
//			p = new S_Object();
//			p.ParameterName = "p_bl_id";
//			p.DbType = CustomDBType.Integer;
//			p.Direction = ParameterDirection.Input;
//			p.Index = _SColl.Count;
//			p.Value = int.Parse(hidBl_id.Value);
//			_SColl.Add(p);
//			// RICHIEDENTE
//
//			p = new S_Object();
//			p.ParameterName = "p_richiedente";
//			p.DbType = CustomDBType.VarChar;
//			p.Direction = ParameterDirection.Input;
//			p.Index = _SColl.Count;
//			p.Size=35;
//			p.Value = lblRichiedente.Text;
//			_SColl.Add(p);
			
			// NR PREVENTIVO
			p = new S_Object();
			p.ParameterName = "p_numeropreventivo";
			p.DbType = CustomDBType.VarChar;
			p.Direction = ParameterDirection.Input;
			p.Index = _SColl.Count;
			p.Size=20;
			p.Value =TxtNumPreventivo.Text;
			_SColl.Add(p);

			//IMPORTO PREVENTIVO
			p = new S_Object();
			p.ParameterName = "p_importopreventivo";
			p.DbType = CustomDBType.Double;
			p.Direction = ParameterDirection.Input;
			p.Index = _SColl.Count;
			if(txtImpPrev1.Text=="") 
				p.Value =0;
			else
				p.Value =double.Parse(txtImpPrev1.Text + "," + txtImpPrev2.Text);  
			_SColl.Add(p);
			

			return _SColl;
		}

		private void btApprova_Click(object sender, System.EventArgs e)
		{	
			
			string scriptString="";
			TheSite.Classi.ManStraordinaria.ManCorrettivaPaging _Manc1= new TheSite.Classi.ManStraordinaria.ManCorrettivaPaging();
			string msgsoglia=_Manc1.CKSogliaAut(double.Parse(txtImpPrev1.Text + "," + txtImpPrev2.Text),int.Parse(cmbsServizio.SelectedValue),wr_id);
			if (msgsoglia!="")			
			{
				scriptString= "<script language=\"JavaScript\">alert(\"" + msgsoglia + "\");<";
				scriptString += "/";
				scriptString += "script>";
				this.RegisterStartupScript("Startup2", scriptString);
				return;
			}

			if(S_macroarea==null || S_macroarea.SelectedValue.Equals("")
				||S_macroarea.SelectedValue.Equals("30")
				)
			{
				scriptString= "<script language=\"JavaScript\">alert('Selezionare Macroarea Obbligatoriamente');<";
				scriptString += "/";
				scriptString += "script>";
				this.RegisterStartupScript("Startup2", scriptString);
				return;
			}
			


			
//			if (AUT!="")
//			{
//				scriptString= "<script language=\"JavaScript\">alert(\"" + AUT + "\");<";
//				scriptString += "/";
//				scriptString += "script>";
//				this.RegisterStartupScript("Startup2", scriptString);
//				return;			
//			}
			
			
			
//			
		
//			string msg=_Manc1.CKStatusAut(wr_id, int.Parse(cmbsTipoManutenzione.SelectedValue));
//			//controllo stato autorizzazione//
//			//int.Parse(cmbsTipoManutenzione.SelectedValue);  
//			//TheSite.Classi.ManStraordinaria.ManCorrettivaPaging _Manc= new TheSite.Classi.ManStraordinaria.ManCorrettivaPaging();
//			//string msg=_Manc1.CKStatusAut(wr_id, int.Parse(cmbsTipoManutenzione.SelectedValue));
//			string scriptString="";
//			if (msg=="RDL NON AUTORIZZATA")			
//			{scriptString= "<script language=\"JavaScript\">alert(\"" + msg + "\");<";
//			scriptString += "/";
//			scriptString += "script>";
//			this.RegisterStartupScript("Startup2", scriptString);
//			return;
//			}
			//controllo stato autorizzazione//
			S_ControlsCollection _SColl =GetSgaParameter();
			// STATO
			S_Object p = new S_Object();
			p.ParameterName = "p_stato";
			p.DbType = CustomDBType.Integer;
			p.Direction = ParameterDirection.Input;
			p.Index = _SColl.Count;
			p.Value =6; 
			_SColl.Add(p);

			_SColl=GetParamEmissione(_SColl);			
			

				int result= _ClManCorrettiva.ExecuteUpdateSGA2(_SColl); 
				SaveDocumentPreventivo();
				LoadDati();
				azioni.Visible=true;

		}

		private void btSospendi_Click(object sender, System.EventArgs e)
		{
			

			S_ControlsCollection _SColl = new S_ControlsCollection();
		
			S_Controls.Collections.S_Object p = new S_Object();
			p.ParameterName = "p_wr_id";
			p.DbType = CustomDBType.Integer;
			p.Direction = ParameterDirection.Input;
			p.Index = _SColl.Count;
			p.Value = this.wr_id;
			_SColl.Add(p);
			
			
			p = new S_Object();
			p.ParameterName = "p_stato";
			p.DbType = CustomDBType.Integer;
			p.Direction = ParameterDirection.Input;
			p.Index = _SColl.Count;
			p.Value =15; //Sospesa
			_SColl.Add(p);

			int result= _ClManCorrettiva.ExecuteUpdateSGARIFSOSP(_SColl);  

			//SaveDocumentPreventivo();

			Chiudi();
		}

		private void btRifiuta_Click(object sender, System.EventArgs e)
		{
			S_ControlsCollection _SColl = new S_ControlsCollection();
		
			S_Controls.Collections.S_Object p = new S_Object();
			p.ParameterName = "p_wr_id";
			p.DbType = CustomDBType.Integer;
			p.Direction = ParameterDirection.Input;
			p.Index = _SColl.Count;
			p.Value = this.wr_id;
			_SColl.Add(p);

			p = new S_Object();
			p.ParameterName = "p_stato";
			p.DbType = CustomDBType.Integer;
			p.Direction = ParameterDirection.Input;
			p.Index = _SColl.Count;
			p.Value =7; //Rifiutata
			_SColl.Add(p);

			int result= _ClManCorrettiva.ExecuteUpdateSGARIFSOSP(_SColl); 
		
			//SaveDocumentPreventivo();

			Chiudi();
			//lblDataRichiesta.Text.Substring(7,4);
		}

		private void btChiudi_Click(object sender, System.EventArgs e)
		{
			Chiudi();
		}
		private void Chiudi()
		{
			string varapp="";
			if(Request["VarApp"]!=null)
				varapp="&VarApp=" + Request["VarApp"];			
			Server.Transfer(HPageBack.Value +"?FunId=" + ViewState["FunId"] + varapp);
		}

		private void btFoglioPdf_Click(object sender, System.EventArgs e)
		{
			ScriptRapportoTecnicoPdf(int.Parse(LblOrdine.Text.Trim()));
			//andrea
			//ScriptSGAPdf(int.Parse(LblRdl.Text.Trim()));
			//ScriptDIEPdf(int.Parse(LblRdl.Text.Trim()));
		}
		private void ScriptRapportoTecnicoPdf(int wo_id)
		{
			string pagina="RapportoTecnicoInterventoPdf.aspx?WO_Id=" + wo_id.ToString();
			string s_TestataScript = "<script language=\"javascript\">\n";
			string funz="ApriPopUp('"+ pagina +"')";
			string s_CodaScript = "</script>\n";
			string funzione=s_TestataScript + funz + s_CodaScript;
			this.Page.RegisterStartupScript("funz",funzione);


		}



		private void ScriptRapportoTecnico(int wo_id)
		{
			string pagina="RapportoTecnicoIntervento.aspx?WO_Id=" + wo_id.ToString();
			string s_TestataScript = "<script language=\"javascript\">\n";
			string funz="ApriPopUp('"+ pagina +"')";
			string s_CodaScript = "</script>\n";
			string funzione=s_TestataScript + funz + s_CodaScript;
			this.Page.RegisterStartupScript("funz",funzione);
		}
//		private void ScriptSGA(int wr_id)
//		{
//			// da inserire una nuova pagina aspx SGA
//			string pagina="SGAPdf.aspx?Wr_Id=" + wr_id.ToString();
//			string s_TestataScript = "<script language=\"javascript\">\n";
//			string funz="ApriPopUp('"+ pagina +"')";
//			string s_CodaScript = "</script>\n";
//			string funzione=s_TestataScript + funz + s_CodaScript;
//			this.Page.RegisterStartupScript("funz",funzione);
//		}
//
//		private void ScriptDIE(int wr_id)
//		{
//			// da inserire una nuova pagina aspx SGA
//			string pagina="DIEPdf.aspx?Wr_Id=" + wr_id.ToString();
//			string s_TestataScript = "<script language=\"javascript\">\n";
//			string funz="ApriPopUp('"+ pagina +"')";
//			string s_CodaScript = "</script>\n";
//			string funzione=s_TestataScript + funz + s_CodaScript;
//			this.Page.RegisterStartupScript("funz",funzione);
//		}

		

		private void BtDIE_Click(object sender, System.EventArgs e)
		{

			//if(!IsCompletata)
			SaveCompletamento();
			//SendDIE();
			string percorso="";
			Classi.RptRtf.SGA_DIE sd =new TheSite.Classi.RptRtf.SGA_DIE();
			percorso=sd.GENERAPDFDIE(int.Parse(Request["wr_id"]),lblSGA.Text,Context.User.Identity.Name);
			LoadDati();
		}
		private void SendDIE()
		{
			string formatdate=DateTime.Now.Millisecond.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Hour.ToString() +DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() +DateTime.Now.Year.ToString();	
			TheSite.XSLT.DIE die =new TheSite.XSLT.DIE(this.wr_id,formatdate);
			string[] Files=die.GenerateDIE();

			TheSite.Classi.MailSend mail=new TheSite.Classi.MailSend();
			mail.SendMail(Files[0],this.wr_id,DocType.DIE);

			SaveInvio(Files[1],DocType.DIE);
		}

		private void BtSalva_Click(object sender, System.EventArgs e)
		{
			SaveCompletamento();
			
			LoadDati();
		}
		private void SaveCompletamento()
		{	

			//controllo stato autorizzazione//
			int.Parse(cmbsTipoManutenzione.SelectedValue);  
			TheSite.Classi.ManStraordinaria.ManCorrettivaPaging _Manc= new TheSite.Classi.ManStraordinaria.ManCorrettivaPaging();
			string msg=_Manc.CKStatusAut(wr_id, int.Parse(cmbsTipoManutenzione.SelectedValue));
			string scriptString="";
			if (msg=="RDL NON AUTORIZZATA")			
			{
				scriptString= "<script language=\"JavaScript\">alert(\"" + msg + "\");<";
				scriptString += "/";
				scriptString += "script>";
				this.RegisterStartupScript("Startup2", scriptString);
				return;
			}
			
//			if(S_PIANO==null || S_PIANO.SelectedValue.Equals("")){
//				scriptString= "<script language=\"JavaScript\">alert('Piano Obbligatorio');<";
//				scriptString += "/";
//				scriptString += "script>";
//				this.RegisterStartupScript("Startup2", scriptString);
//				return;
//			}
//			if(UserStanzeRic1==null || UserStanzeRic1.IdStanza.Equals(""))
//			{
//				scriptString= "<script language=\"JavaScript\">alert('Stanza Obbligatoria');<";
//				scriptString += "/";
//				scriptString += "script>";
//				this.RegisterStartupScript("Startup2", scriptString);
//				return;
//			}

			if(S_macroarea==null || S_macroarea.SelectedValue.Equals("")
				||S_macroarea.SelectedValue.Equals("30")
				)
			{
				scriptString= "<script language=\"JavaScript\">alert('Selezionare Macroarea Obbligatoriamente');<";
				scriptString += "/";
				scriptString += "script>";
				this.RegisterStartupScript("Startup2", scriptString);
				return;
			}


			//fine controllo stato
			S_ControlsCollection _SColl = new S_ControlsCollection();
		
			S_Controls.Collections.S_Object p = new S_Object();
			p.ParameterName = "p_wr_id";
			p.DbType = CustomDBType.Integer;
			p.Direction = ParameterDirection.Input;
			p.Index = _SColl.Count;
			p.Value = this.wr_id;
			_SColl.Add(p);

			p = new S_Object();
			p.ParameterName = "p_datarichiesta";
			p.DbType = CustomDBType.Date;
			p.Direction = ParameterDirection.Input;
			p.Index = _SColl.Count;
	
			string data_startrich =string.Empty; 
			data_startrich=CalendarPicker1.Datazione.Text;
			if(data_startrich!="")
			{ 
				string ora_iniziorich=((S_COMBOBOX4.SelectedValue=="")?"00":S_COMBOBOX4.SelectedValue) + ":" + ((S_COMBOBOX3.SelectedValue=="")?"00":S_COMBOBOX3.SelectedValue) + ":00";
				data_startrich += " " + ora_iniziorich;  
			}
			if(data_startrich!="")
				p.Value =data_startrich;
			else
				p.Value =DBNull.Value;

			_SColl.Add(p);
			
			
			p = new S_Object();
			p.ParameterName = "p_id_fl";
			p.DbType = CustomDBType.Integer;
			p.Direction = ParameterDirection.Input;
			p.Index = _SColl.Count;
			p.Value = int.Parse(S_PIANO.SelectedValue); 
			_SColl.Add(p);
			
			p = new S_Object();
			p.ParameterName = "p_id_rm";
			p.DbType = CustomDBType.Integer;
			p.Direction = ParameterDirection.Input;
			p.Index = _SColl.Count;
			p.Value =(UserStanzeRic1.IdStanza=="")?0:int.Parse(UserStanzeRic1.IdStanza);
			_SColl.Add(p);

			p = new S_Object();
			p.ParameterName = "p_id_rm_cat";
			p.DbType = CustomDBType.Integer;
			p.Direction = ParameterDirection.Input;
			p.Index = _SColl.Count;
			p.Value = int.Parse(S_macroarea.SelectedValue); 
			_SColl.Add(p);
				

			p = new S_Object();
			p.ParameterName = "p_descrizione";
			p.DbType = CustomDBType.VarChar;
			p.Direction = ParameterDirection.Input;
			p.Size =4000;
			p.Index = _SColl.Count;
			p.Value =txtsDescrizione.Text;
			_SColl.Add(p);

			p = new S_Object();
			p.ParameterName = "p_anomalia";
			p.DbType = CustomDBType.VarChar;
			p.Direction = ParameterDirection.Input;
			p.Size =408;
			p.Index = _SColl.Count;
			p.Value =txtCausa.Text;
			_SColl.Add(p);

			p = new S_Object();
			p.ParameterName = "p_effetto";
			p.DbType = CustomDBType.VarChar;
			p.Direction = ParameterDirection.Input;
			p.Size =408;
			p.Index = _SColl.Count;
			p.Value =txtEffettoGuasto.Text;
			_SColl.Add(p);

			p = new S_Object();
			p.ParameterName = "p_soluzione";
			p.DbType = CustomDBType.VarChar;
			p.Direction = ParameterDirection.Input;
			p.Size =408;
			p.Index = _SColl.Count;
			p.Value =txtSoluzioneProposta.Text;
			_SColl.Add(p);
			
			// DATASOPRALLUOGO
			p = new S_Object();
			p.ParameterName = "p_datasopralluogo";
			p.DbType = CustomDBType.VarChar;
			p.Direction = ParameterDirection.Input;
			p.Index = _SColl.Count;			
			p.Size=30;

			//Data Sopralluogo	
			string data_sopralluogo=CalendarPicker4.Datazione.Text;
			if(data_sopralluogo!="")
			{ 
				string ora_sopralluogo= ((OraSopralluogo.SelectedValue=="")?"00":OraSopralluogo.SelectedValue) + ":" + ((MinutiSopralluogo.SelectedValue=="")?"00":MinutiSopralluogo.SelectedValue) + ":00";
				data_sopralluogo = data_sopralluogo + " " + ora_sopralluogo;  
			}
			p.Value = data_sopralluogo;
			_SColl.Add(p);


			p = new S_Object();
			p.ParameterName = "p_datainizio";
			p.DbType = CustomDBType.Date;
			p.Direction = ParameterDirection.Input;
			p.Index = _SColl.Count;
			if (CalendarPicker6.Datazione.Text=="")  
				p.Value =DBNull.Value;
			else
			{
					string data_end1 =string.Empty; 
				data_end1=CalendarPicker6.Datazione.Text;
				if(data_end1!="")
				{ 
					string ora_end=((cmbOra1.SelectedValue=="")?"00":cmbOra1.SelectedValue) + ":" + ((cmbMin2.SelectedValue=="")?"00":cmbMin2.SelectedValue) + ":00";
					data_end1 += " " + ora_end;  
				}
				if(data_end1!="")
					p.Value =data_end1;
				else
					p.Value =DBNull.Value;}
			_SColl.Add(p);

			p = new S_Object();
			p.ParameterName = "p_datefine";
			p.DbType = CustomDBType.Date;
			p.Direction = ParameterDirection.Input;
			p.Index = _SColl.Count;
			if (CalendarPicker2.Datazione.Text=="")  
				p.Value =DBNull.Value;
			else
			{
				string data_end1 =string.Empty; 
				data_end1=CalendarPicker2.Datazione.Text;
				if(data_end1!="")
				{ 
					string ora_end=((cmborafinelav.SelectedValue=="")?"00":cmborafinelav.SelectedValue) + ":" + ((cmbminfinelav.SelectedValue=="")?"00":cmbminfinelav.SelectedValue) + ":00";
					data_end1 += " " + ora_end;  
				}
				if(data_end1!="")
					p.Value =data_end1;
				else
					p.Value =DBNull.Value;
			}
			_SColl.Add(p);

			p = new S_Object();
			p.ParameterName = "p_tipomanutenzione";
			p.DbType = CustomDBType.Integer;
			p.Direction = ParameterDirection.Input;
			p.Index = _SColl.Count;
			p.Value =int.Parse(cmbsTipoManutenzione.SelectedValue);  
			_SColl.Add(p);

			p = new S_Object();
			p.ParameterName = "p_tipointervento";
			p.DbType = CustomDBType.Integer;
			p.Direction = ParameterDirection.Input;
			p.Index = _SColl.Count;
			p.Value =int.Parse(cmbsTipoIntrevento.SelectedValue);  
			_SColl.Add(p);
		
			p = new S_Object();
			p.ParameterName = "p_note";
			p.DbType = CustomDBType.VarChar;
			p.Direction = ParameterDirection.Input;
			p.Index = _SColl.Count;
			p.Size=408;
			p.Value =txtNoteSga.Text; 
			_SColl.Add(p);
		
		
			// URGENZA
			p = new S_Object();
			p.ParameterName = "p_urgenza";
			p.DbType = CustomDBType.Integer;
			p.Direction = ParameterDirection.Input;
			p.Index = _SColl.Count;
			p.Value = cmbsUrgenza.SelectedValue; //Int32.Parse(cmbsUrgenza.SelectedValue.Split(Convert.ToChar(","))[0]);	
			_SColl.Add(p);

			p = new S_Object();
			p.ParameterName = "p_addetto_id";
			p.DbType = CustomDBType.Integer;
			p.Direction = ParameterDirection.Input;
			p.Index = _SColl.Count;
			if(cmbsAddetto.SelectedValue=="0")
				p.Value = DBNull.Value;
			else
				p.Value =int.Parse(cmbsAddetto.SelectedValue);
			_SColl.Add(p);

//			// ID_DITTA
//			p = new S_Object();
//			p.ParameterName = "p_id_ditta";
//			p.DbType = CustomDBType.Integer;
//			p.Direction = ParameterDirection.Input;
//			p.Index = _SColl.Count;
//			p.Value = (cmbsDitta.SelectedValue=="")?0:int.Parse(cmbsDitta.SelectedValue);
//			_SColl.Add(p);
//		
			
		
			p = new S_Object();
			p.ParameterName = "p_date_start";
			p.DbType = CustomDBType.VarChar;
			p.Direction = ParameterDirection.Input;
			p.Index = _SColl.Count;
			string data_start=string.Empty; 
			data_start=CalendarPicker7.Datazione.Text;
			if(data_start!="")
			{ 
				string ora_ini=((OraIni.SelectedValue=="")?"00":OraIni.SelectedValue) + ":" + ((MinitiIni.SelectedValue=="")?"00":MinitiIni.SelectedValue) + ":00";
				data_start += " " + ora_ini;  
			}
			if(data_start!="")
				p.Value =data_start;
			else
				p.Value =DBNull.Value;
			_SColl.Add(p);

			p = new S_Object();
			p.ParameterName = "p_date_end";
			p.DbType = CustomDBType.VarChar;
			p.Direction = ParameterDirection.Input;
			p.Index = _SColl.Count;
			string data_end=string.Empty; 
			data_end=CalendarPicker8.Datazione.Text;
			if(data_end!="")
			{ 
				string ora_end=((OraFine.SelectedValue=="")?"00":OraFine.SelectedValue) + ":" + ((MinutiFine.SelectedValue=="")?"00":MinutiFine.SelectedValue) + ":00";
				data_end += " " + ora_end;  
			}
			if(data_end!="")
				p.Value =data_end;
			else
				p.Value =DBNull.Value;
			_SColl.Add(p);

			p = new S_Object();
			p.ParameterName = "p_date_est_completion";
			p.DbType = CustomDBType.VarChar;
			p.Direction = ParameterDirection.Input;
			p.Index = _SColl.Count;
			string date_est_completion=string.Empty; 
			date_est_completion=CalendarPicker10.Datazione.Text;
			if(date_est_completion!="")
			{ 
				string ora_ini=((S_COMBOBOX2.SelectedValue=="")?"00":S_COMBOBOX2.SelectedValue) + ":" + ((S_COMBOBOX1.SelectedValue=="")?"00":S_COMBOBOX1.SelectedValue) + ":00";
				date_est_completion += " " + ora_ini;  
			}
			if(date_est_completion!="")
				p.Value =date_est_completion;
			else
				p.Value =DBNull.Value;
			_SColl.Add(p);


			p = new S_Object();
			p.ParameterName = "p_comments";
			p.DbType = CustomDBType.VarChar;
			p.Direction = ParameterDirection.Input;
			p.Index = _SColl.Count;
			p.Size =256;
			p.Value =cmbDescrizioneIntervento.Text;
			_SColl.Add(p);

			p = new S_Object();
			p.ParameterName = "p_ca_id";
			p.DbType = CustomDBType.VarChar;
			p.Direction = ParameterDirection.Input;
			p.Index = _SColl.Count;
			p.Size =32;
			p.Value =txtBuonoLavoroEster.Text;
			_SColl.Add(p);

			p = new S_Object();
			p.ParameterName = "p_satisfaction_id";
			p.DbType = CustomDBType.VarChar;
			p.Direction = ParameterDirection.Input;
			p.Index = _SColl.Count;
			p.Size =32;
			p.Value =RdListLivello.SelectedValue;
			_SColl.Add(p);

			p = new S_Object();
			p.ParameterName = "p_sospesa";
			p.DbType = CustomDBType.VarChar;
			p.Direction = ParameterDirection.Input;
			p.Index = _SColl.Count;
			p.Size =2000;
			p.Value =txtsAnnotazioni.Text;
			_SColl.Add(p);

			p = new S_Object();
			p.ParameterName = "P_DISSERVIZIO";
			p.DbType = CustomDBType.Integer;
			p.Direction = ParameterDirection.Input;
			p.Index = _SColl.Count;
			p.Value =(CkDisser.Checked==true)?1:0;
			_SColl.Add(p);

			p = new S_Object();
			p.ParameterName = "P_DIE_TIPO_INTERVENTO";
			p.DbType = CustomDBType.Integer;
			p.Direction = ParameterDirection.Input;
			p.Index = _SColl.Count;
			p.Value =cmbStatoIntervento.SelectedValue;
			_SColl.Add(p);


			p = new S_Object();
			p.ParameterName = "P_DIE_COSTO_MATERIALE";
			p.DbType = CustomDBType.Double;
			p.Direction = ParameterDirection.Input;
			p.Index = _SColl.Count;
			//			p.Value =DBNull.Value;
			//			_SColl.Add(p);

			if(txtCostiMateriali1.Text=="")
				p.Value =DBNull.Value;
			else
				p.Value =double.Parse(txtCostiMateriali1.Text + "," + txtCostiMateriali2.Text); 
			_SColl.Add(p);

			p = new S_Object();
			p.ParameterName = "P_DIE_COSTO_PERSONALE";
			p.DbType = CustomDBType.Double;
			p.Direction = ParameterDirection.Input;
			p.Index = _SColl.Count;
			//			p.Value =DBNull.Value;
			//			_SColl.Add(p);
			if(txtCostiPersonale1.Text=="")
				p.Value =DBNull.Value;
			else
				p.Value =double.Parse(txtCostiPersonale1.Text + "," + txtCostiPersonale2.Text); 
			_SColl.Add(p);

			p = new S_Object();
			p.ParameterName = "P_DIE_COSTO_TOTALE";
			p.DbType = CustomDBType.Double;
			p.Direction = ParameterDirection.Input;
			p.Index = _SColl.Count;
			//			p.Value =DBNull.Value;
			//			_SColl.Add(p);
			if(txtCostiTotale1.Text=="")
				p.Value =DBNull.Value;
			else
				p.Value =double.Parse(txtCostiTotale1.Text + "," + txtCostiTotale2.Text); 
			_SColl.Add(p);

			// Aggiunto da Andrea   Importo a consuntivo
			p= new S_Object();
			p.ParameterName ="P_DIE_IMP_CONSUNTIVO";
			p.DbType = CustomDBType.Double;
			p.Direction= ParameterDirection.Input;
			p.Index = _SColl.Count;
			if(ImpCons1.Text=="")
				p.Value =0;
			else
				p.Value =double.Parse(ImpCons1.Text + "," + ImpCons2.Text); 
			_SColl.Add(p);
			

			p = new S_Object();
			p.ParameterName = "P_DIE_NOTE";
			p.DbType = CustomDBType.VarChar;
			p.Direction = ParameterDirection.Input;
			p.Index = _SColl.Count;
			p.Size=250;
			p.Value =txtNoteCompletamento.Text; 
			_SColl.Add(p);

			

			p = new S_Object();
			p.ParameterName = "P_FORFAIT";
			p.DbType = CustomDBType.Integer;
			p.Direction = ParameterDirection.Input;
			p.Index = _SColl.Count;
			if(OptAForfait.Checked==true)
				p.Value =1; //Importo a forfait
			else
				p.Value =0; 
			_SColl.Add(p);


			p = new S_Object();
			p.ParameterName = "P_FORFAIT_NOTE";
			p.DbType = CustomDBType.VarChar;
			p.Direction = ParameterDirection.Input;
			p.Index = _SColl.Count;
			p.Size=250;
			p.Value =TxtAForfait.Text; 
			//						if(OptAForfait.Checked) 
			//						
			//		     else
			//			p.Value =DBNull.Value;
			_SColl.Add(p);

			// NR PREVENTIVO
			p = new S_Object();
			p.ParameterName = "p_numeropreventivo";
			p.DbType = CustomDBType.VarChar;
			p.Direction = ParameterDirection.Input;
			p.Index = _SColl.Count;
			p.Size=20;
			p.Value =TxtNumPreventivo.Text;
			_SColl.Add(p);

			//IMPORTO PREVENTIVO
			p = new S_Object();
			p.ParameterName = "p_importopreventivo";
			p.DbType = CustomDBType.Double;
			p.Direction = ParameterDirection.Input;
			p.Index = _SColl.Count;
			if(txtImpPrev1.Text=="") 
				p.Value =0;
			else
				p.Value =double.Parse(txtImpPrev1.Text + "," + txtImpPrev2.Text);  
			_SColl.Add(p);

			p = new S_Object();
			p.ParameterName = "p_stato";
			p.DbType = CustomDBType.Integer;
			p.Direction = ParameterDirection.Input;
			p.Index = _SColl.Count;
			p.Value =cmbsstatolavoro.SelectedValue; 
			_SColl.Add(p);
			
			p = new S_Object();
			p.ParameterName = "p_idcontabilizzazione";
			p.DbType = CustomDBType.Integer;
			p.Direction = ParameterDirection.Input;
			p.Size=100;
			p.Index = _SColl.Count;
			p.Value =cmbCdC.SelectedValue;
			_SColl.Add(p);

			p = new S_Object();
			p.ParameterName = "p_nr_ord";
			p.DbType = CustomDBType.VarChar;
			p.Direction = ParameterDirection.Input;
			p.Size=100;
			p.Index = _SColl.Count;
			p.Value =txtord.Text;
			_SColl.Add(p);

			
			p = new S_Object();
			p.ParameterName = "p_a1_b1";
			p.DbType = CustomDBType.VarChar;
			p.Direction = ParameterDirection.Input;
			p.Size=2;
			p.Index = _SColl.Count;
			p.Value = S_tipintervento.SelectedValue; 
			_SColl.Add(p);



			int result= _ClManCorrettiva.Completamentonew_rev2(_SColl); 
			//LoadDati();

		}

		private void BtInviaPreventivo_Click(object sender, System.EventArgs e)
		{
			
			
			// controllo ruolo-utente livello autorizzazione 1 e 2 messaggio negativo
			string scriptString="";
			TheSite.Classi.ManStraordinaria.ManCorrettivaPaging _Manc1= new TheSite.Classi.ManStraordinaria.ManCorrettivaPaging();
			string msgAut=_Manc1.CKPREVAUT(Context.User.Identity.Name);
			if (msgAut!="")
			
			{
				scriptString= "<script language=\"JavaScript\">alert(\"" + msgAut + "\");<";
				scriptString += "/";
				scriptString += "script>";
				this.RegisterStartupScript("Startup2", scriptString);
				return;
				
			}
			//controllo autorizzazione RDL gi� effettuata messaggio negativo
			
			string msg=_Manc1.CKStatusAut(wr_id, int.Parse(cmbsTipoManutenzione.SelectedValue));
			if (msg!="")
			{
				scriptString= "<script language=\"JavaScript\">alert(\"" + msg + "\");<";
				scriptString += "/";
				scriptString += "script>";
				this.RegisterStartupScript("Startup2", scriptString);
				return;
			
			}
			


			SaveDocumentPreventivo();

		}
		private void SaveDocumentPreventivo()
		{
			//il preventivio � sotto soglia? si modifico lo stato autorizzativo
			TheSite.Classi.ManStraordinaria.ManCorrettivaPaging _Manc1= new TheSite.Classi.ManStraordinaria.ManCorrettivaPaging();
			string msgsoglia=_Manc1.CKSogliaAut(double.Parse(txtImpPrev1.Text + "," + txtImpPrev2.Text),int.Parse(cmbsServizio.SelectedValue),wr_id);
			//string msg=_Manc1.CKStatusAut(wr_id, int.Parse(cmbsTipoManutenzione.SelectedValue));
			
			string fileName=string.Empty;
			if (FilePreventivo.PostedFile!=null && FilePreventivo.PostedFile.FileName!="") 
			{
				fileName= System.IO.Path.GetFileName(FilePreventivo.PostedFile.FileName);

				string destDir =Server.MapPath("../Doc_DB");
				string folderChild=System.IO.Path.Combine(destDir, "Correttiva");
				if (!Directory.Exists(folderChild))
					Directory.CreateDirectory(folderChild);

				folderChild=System.IO.Path.Combine(folderChild, this.wr_id.ToString() + "/PREV");
				if (!Directory.Exists(folderChild))
					Directory.CreateDirectory(folderChild);	
				string destPath  = System.IO.Path.Combine(folderChild, fileName);
				FilePreventivo.PostedFile.SaveAs(destPath);	
				//Salvo il documento nella tabella
				//marianna 
				SaveDocumentPreventivo(fileName);
			
			}
			else
				fileName=LkPrev.Text;
			SaveDocumentPreventivo(fileName);

			LoadDocumentPrev();
		}
		private void SaveDocumentPreventivo(string filename)
		{
			S_ControlsCollection _SColl = new S_ControlsCollection();
			int result=0;
		
			S_Controls.Collections.S_Object p = new S_Object();
			p.ParameterName = "p_wr_id";
			p.DbType = CustomDBType.Integer;
			p.Direction = ParameterDirection.Input;
			p.Index = _SColl.Count;
			p.Value = this.wr_id;
			_SColl.Add(p);

			p = new S_Object();
			p.ParameterName = "p_numeropreventivo";
			p.DbType = CustomDBType.VarChar;
			p.Direction = ParameterDirection.Input;
			p.Index = _SColl.Count;
			
			if(TxtNumPreventivo.Text=="")
				p.Value = 0;
			else
				p.Value = TxtNumPreventivo.Text;
			_SColl.Add(p);

			p = new S_Object();
			p.ParameterName = "p_importopreventivo";
			p.DbType = CustomDBType.Double;
			p.Direction = ParameterDirection.Input;
			p.Index = _SColl.Count;
			if(txtImpPrev1.Text=="")
				p.Value =0;
			else
				p.Value =double.Parse(txtImpPrev1.Text + "," + txtImpPrev2.Text); 
			_SColl.Add(p);

			p = new S_Object();
			p.ParameterName = "p_pdfpreventivo";
			p.DbType = CustomDBType.VarChar;
			p.Direction = ParameterDirection.Input;
			p.Size =250;
			p.Index = _SColl.Count;
			p.Value =filename;
			_SColl.Add(p);

			p = new S_Object();
			p.ParameterName = "p_operazione";
			p.DbType = CustomDBType.Integer;
			p.Direction = ParameterDirection.Input;
			p.Index = _SColl.Count;
			p.Value =1;//Aggiornamento
			_SColl.Add(p);

			result= _ClManCorrettiva.ExecuteUpdatePreventivo1(_SColl); 
		}
		private void LoadDocumentPrev()
		{
			LkPrev.Visible =false;
			btImgDelete.Visible=false;
			DataSet _MyDs =  _ClManCorrettiva.GetDocumentazionePrev1(this.wr_id);
			if(_MyDs.Tables[0].Rows.Count==0)
			{
				LkPrev.Visible =false;
				btImgDelete.Visible=false;
				return;
			}			
			
			if (_MyDs.Tables[0].Rows[0]["nome_doc"]!= DBNull.Value)
			{
				LkPrev.Visible =true;
				btImgDelete.Visible=true;
				LkPrev.Text=_MyDs.Tables[0].Rows[0]["nome_doc"].ToString();
				btImgDelete.CommandArgument=_MyDs.Tables[0].Rows[0]["id_file"].ToString();
				string destDir =  "../Doc_DB/Correttiva/" + this.wr_id.ToString() + "/PREV/" +_MyDs.Tables[0].Rows[0]["nome_doc"].ToString();
				LkPrev.NavigateUrl =destDir;}
			
		}
		private void btImgDelete_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			if(LkPrev.Text=="")
			{
				LkPrev.Visible =false;
				btImgDelete.Visible=false;
				return;
			}

			S_ControlsCollection _SColl = new S_ControlsCollection();
			int result=0;
		
			S_Controls.Collections.S_Object p = new S_Object();
			p.ParameterName = "p_wr_id";
			p.DbType = CustomDBType.Integer;
			p.Direction = ParameterDirection.Input;
			p.Index = _SColl.Count;
			p.Value = this.wr_id;
			_SColl.Add(p);

			p = new S_Object();
			p.ParameterName = "p_operazione";
			p.DbType = CustomDBType.Integer;
			p.Direction = ParameterDirection.Input;
			p.Index = _SColl.Count;
			p.Value =-1;//Eliminazione
			_SColl.Add(p);

			result= _ClManCorrettiva.ExecuteUpdatePreventivo(_SColl); 

			string destDir =Server.MapPath("../Doc_DB");
			
			destDir=System.IO.Path.Combine(destDir,"Correttiva");
			destDir=System.IO.Path.Combine(destDir, this.wr_id.ToString());
			destDir=System.IO.Path.Combine(destDir, "PREV/" + LkPrev.Text);
			File.Delete(destDir);

			LkPrev.Visible =false;
			btImgDelete.Visible=false;
		}
		//Click dell'invio del documento del consuntivo
		private void BtInviaCons_Click(object sender, System.EventArgs e)
		{
			SaveDocumentConsuntivo();
		}
		private void SaveDocumentConsuntivo()
		{
			string fileName=string.Empty;
			if (FileConsuntivo.PostedFile!=null && FileConsuntivo.PostedFile.FileName!="") 
			{
				fileName= System.IO.Path.GetFileName(FileConsuntivo.PostedFile.FileName);

				string destDir =Server.MapPath("../Doc_DB");

				
				string folderChild=System.IO.Path.Combine(destDir, "Correttiva");
				if (!Directory.Exists(folderChild))
					Directory.CreateDirectory(folderChild);	

				folderChild=System.IO.Path.Combine(folderChild, this.wr_id.ToString() + "/CONS");
				if (!Directory.Exists(folderChild))

					Directory.CreateDirectory(folderChild);	
				string destPath  = System.IO.Path.Combine(folderChild, fileName);
		
				FileConsuntivo.PostedFile.SaveAs(destPath);	
				//Salvo il documento nella tabella
				SaveDocumentConsuntivo(fileName);	
			}
			else
				fileName=LkCons.Text;

			LoadDocumentCons();
		}
		
		private void SaveDocumentConsuntivo(string filename)
		{
			S_ControlsCollection _SColl = new S_ControlsCollection();
			int result=0;
		
			S_Controls.Collections.S_Object p = new S_Object();
			p.ParameterName = "p_wr_id";
			p.DbType = CustomDBType.Integer;
			p.Direction = ParameterDirection.Input;
			p.Index = _SColl.Count;
			p.Value = this.wr_id;
			_SColl.Add(p);

			p = new S_Object();
			p.ParameterName = "p_importoconsuntivo";
			p.DbType = CustomDBType.Double;
			p.Direction = ParameterDirection.Input;
			p.Index = _SColl.Count;
			//			p.Value =DBNull.Value;
			//			_SColl.Add(p);
			if(ImpCons1.Text=="")
				p.Value =DBNull.Value;
			else
				p.Value =double.Parse(ImpCons1.Text + "," + ImpCons2.Text); 
			_SColl.Add(p);

			p = new S_Object();
			p.ParameterName = "p_pdfconsuntivo";
			p.DbType = CustomDBType.VarChar;
			p.Direction = ParameterDirection.Input;
			p.Size =250;
			p.Index = _SColl.Count;
			p.Value =filename;
			_SColl.Add(p);

			p = new S_Object();
			p.ParameterName = "p_operazione";
			p.DbType = CustomDBType.Integer;
			p.Direction = ParameterDirection.Input;
			p.Index = _SColl.Count;
			p.Value =1;//Aggiornamento
			_SColl.Add(p);

			result= _ClManCorrettiva.ExecuteUpdateConsuntivo1(_SColl);
		}
		
		private void LoadDocumentCons()
		{
			DataSet _MyDs =  _ClManCorrettiva.GetDocumentazioneCons1(this.wr_id);
			if(_MyDs.Tables[0].Rows.Count==0)
			{
				LkCons.Visible =false;
				btImgDeleteCons.Visible=false;
				return;
			}
			
			if (_MyDs.Tables[0].Rows[0]["nome_doc"]!=DBNull.Value)
			{
				LkCons.Visible =true;
				btImgDeleteCons.Visible=true;
				LkCons.Text=_MyDs.Tables[0].Rows[0]["nome_doc"].ToString();
				btImgDeleteCons.CommandArgument=_MyDs.Tables[0].Rows[0]["id_file"].ToString();

				string destDir =  "../Doc_DB/Correttiva/" + this.wr_id.ToString() + "/CONS/" +_MyDs.Tables[0].Rows[0]["nome_doc"].ToString();
				LkCons.NavigateUrl =destDir;
			}
		}

		private void btImgDeleteCons_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			if(LkCons.Text=="")
			{
				LkCons.Visible =false;
				btImgDeleteCons.Visible=false;
				return;
			}

			S_ControlsCollection _SColl = new S_ControlsCollection();
			int result=0;
		
			S_Controls.Collections.S_Object p = new S_Object();
			p.ParameterName = "p_wr_id";
			p.DbType = CustomDBType.Integer;
			p.Direction = ParameterDirection.Input;
			p.Index = _SColl.Count;
			p.Value = this.wr_id;
			_SColl.Add(p);

			p = new S_Object();
			p.ParameterName = "p_operazione";
			p.DbType = CustomDBType.Integer;
			p.Direction = ParameterDirection.Input;
			p.Index = _SColl.Count;
			p.Value =-1;//Eliminazione
			_SColl.Add(p);

			result= _ClManCorrettiva.ExecuteUpdateConsuntivo1(_SColl); 

			string destDir =Server.MapPath("../Doc_DB");
			
			destDir=System.IO.Path.Combine(destDir, "Correttiva");
			destDir=System.IO.Path.Combine(destDir, this.wr_id.ToString());
			destDir=System.IO.Path.Combine(destDir, "CONS/" + LkCons.Text);
			File.Delete(destDir);

			LkCons.Visible =false;
			btImgDeleteCons.Visible=false;
		}
		private void SaveInvio(string FileName,DocType TipoDoc)
		{
			S_ControlsCollection _SColl =new S_ControlsCollection();
	

			S_Object p = new S_Object();
			p.ParameterName = "p_id";
			p.DbType = CustomDBType.Integer;
			p.Direction = ParameterDirection.Input;
			p.Index = _SColl.Count;
			p.Value =0;
			_SColl.Add(p);

			p = new S_Object();
			p.ParameterName = "p_NOME_DOC";
			p.DbType = CustomDBType.VarChar;
			p.Direction = ParameterDirection.Input;
			p.Index = _SColl.Count;
			p.Size=255;
			p.Value =Path.GetFileName(FileName);
			_SColl.Add(p);

			p = new S_Object();
			p.ParameterName = "p_DATA_INVIO";
			p.DbType = CustomDBType.Date;
			p.Direction = ParameterDirection.Input;
			p.Index = _SColl.Count;
			p.Size=15;
			p.Value =DateTime.Now;
			_SColl.Add(p);
                                        
			p = new S_Object();
			p.ParameterName = "p_USERS";
			p.DbType = CustomDBType.VarChar;
			p.Direction = ParameterDirection.Input;
			p.Index = _SColl.Count;
			p.Size=255;
			p.Value =Context.User.Identity.Name;
			_SColl.Add(p);

			p = new S_Object();
			p.ParameterName = "p_TIPO_DOC";
			p.DbType = CustomDBType.VarChar;
			p.Direction = ParameterDirection.Input;
			p.Index = _SColl.Count;
			p.Size=32;
			p.Value =TipoDoc.ToString();
			_SColl.Add(p);

			p = new S_Object();
			p.ParameterName = "p_CODICE";
			p.DbType = CustomDBType.VarChar;
			p.Direction = ParameterDirection.Input;
			p.Index = _SColl.Count;
			p.Size=255;
			p.Value =this.HSga.Value;
			_SColl.Add(p);
 
			p = new S_Object();
			p.ParameterName = "p_ID_WR";
			p.DbType = CustomDBType.Integer;
			p.Direction = ParameterDirection.Input;
			p.Index = _SColl.Count;
			p.Value =this.wr_id;
			_SColl.Add(p);

			p = new S_Object();
			p.ParameterName = "p_ID_BL";
			p.DbType = CustomDBType.Integer;
			p.Direction = ParameterDirection.Input;
			p.Index = _SColl.Count;
			p.Value =this.hidBl_id.Value;
			_SColl.Add(p);
            
			p = new S_Object();
			p.ParameterName = "p_CODICE_BL";
			p.DbType = CustomDBType.VarChar;
			p.Direction = ParameterDirection.Input;
			p.Index = _SColl.Count;
			p.Size=255;
			p.Value =txtHidBl.Text;
			_SColl.Add(p);

			p = new S_Object();
			p.ParameterName = "p_Operazione";
			p.DbType = CustomDBType.VarChar;
			p.Direction = ParameterDirection.Input;
			p.Index = _SColl.Count;
			p.Size=255;
			p.Value ="Insert";
			_SColl.Add(p);

			int result= _ClManCorrettiva.ExecuteTracciaDoc(_SColl); 
		}



		private void BindCdC( int id_servizio )
		{
			this.cmbCdC.Items.Clear();
		
			Classi.ClassiAnagrafiche.Contab _Contab=new TheSite.Classi.ClassiAnagrafiche.Contab();
			DataSet _MyDs;
			_MyDs=_Contab.GetSingleDataSV_Rev(id_servizio);
			if (_MyDs.Tables[0].Rows.Count > 0)
			{
					
//				this.cmbCdC.DataSource = Classi.GestoreDropDownList.ItemBlankDataSource(
//					_MyDs.Tables[0], "DESCRIZIONE", "ID", "Non Definito", "0");
				
				this.cmbCdC.DataSource=_MyDs.Tables[0];
				this.cmbCdC.DataTextField = "DESCRIZIONE";
				this.cmbCdC.DataValueField = "ID";
				this.cmbCdC.DataBind();
			}
			else
			{
				string s_Messagggio = "Non Definito";
				this.cmbCdC.Items.Add(Classi.GestoreDropDownList.ItemMessaggio(s_Messagggio, "0"));
			}
				

		}

		private void btFoglio_Click(object sender, System.EventArgs e)
		{
			string url = System.Configuration.ConfigurationSettings.AppSettings["linkReportPermessoLavoro"];
			string url_tot = string.Format("{0}?RdLId={1}",url,wr_id);// "http://pempr1.cofasir.it/GetPL.aspx?RdLId="+wr_id
			//url_tot ="http://pt.cofasir.it/GetPL1.aspx?RdLId=464";
			Response.Redirect(url_tot);
		}

		private void Repeater1_ItemDataBound(object sender, System.Web.UI.WebControls.RepeaterItemEventArgs e)
		{
		if(e.Item.ItemType ==ListItemType.Item ||   e.Item.ItemType ==ListItemType.AlternatingItem)
			{
//				string filename= ((DataRowView)e.Item.DataItem)["NOME_DOC"].ToString();  
//				string destDir =  "../Doc_DB/" +  txtHidBl.Text + "/" + this.wr_id.ToString() + "/" +filename;
//				Label lbl=	e.Item.FindControl("lbln") as Label;
//				lbl.Text="<a href=\"" + destDir + "\" target=\"_blank\">" + filename +"</a>";
//
//				ImageButton bt=e.Item.FindControl("delete") as ImageButton; 
//				bt.Attributes.Add("onclick", "return deletedoc();");
		}
		}

		private void Repeater2_ItemDataBound(object sender, System.Web.UI.WebControls.RepeaterItemEventArgs e)
		{
			if(e.Item.ItemType ==ListItemType.Item ||   e.Item.ItemType ==ListItemType.AlternatingItem)
			{}
		}

		private void Repeater3_ItemDataBound(object sender, System.Web.UI.WebControls.RepeaterItemEventArgs e)
		{
			if(e.Item.ItemType ==ListItemType.Item ||   e.Item.ItemType ==ListItemType.AlternatingItem)
			{}
		}

		private void Button1_Click(object sender, System.EventArgs e)
		{
			Chiudi();
		}
		private void LoadMacroArea()
		{
			this.S_macroarea.Items.Clear();		
		    

			DataSet _MyDs = _ClManCorrettiva.GetMacroArea();

			if (_MyDs.Tables[0].Rows.Count > 0)
			{
				this.S_macroarea.DataSource = Classi.GestoreDropDownList.ItemBlankDataSource(
					_MyDs.Tables[0], "descrizione", "id", "- Selezionare la MacroArea -", "");
				this.S_macroarea.DataTextField = "descrizione";
				this.S_macroarea.DataValueField = "id";
				this.S_macroarea.DataBind();   

			}
			else
			{
				string s_Messagggio = "- Nessuna MacroArea  -";
				this.S_macroarea.Items.Add(Classi.GestoreDropDownList.ItemMessaggio(s_Messagggio, String.Empty));
			}
		}

		private void cmbsServizio_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			LoadStandardApparechiature();
			//LoadApparechiature();			
			//ImpostaPriority(Int32.Parse(cmbsServizio.SelectedValue));
			LoadAddettiDitta(RicercaModulo1.TxtCodice.Text, Int32.Parse(cmbsServizio.SelectedValue));
			//da caricare sempre
			BindCdC(Int32.Parse(cmbsServizio.SelectedValue));
		}

		private void cmdsStdApparecchiatura_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			LoadApparechiature();
		}
	
		


//		private void cmbsTipoIntrevento_SelectedIndexChanged(object sender, System.EventArgs e)
//		{
//			CaricaFondi();
//		}

	


	

		

	

		

		

		
	}
}