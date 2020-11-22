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
using System.Reflection;  
using System.IO;

namespace TheSite.GestioneControlliPeriodici
{
	/// <summary>
	/// Descrizione di riepilogo per EditDitte.
	/// </summary>
	public class INSCP : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Panel PanelEdit;
		protected System.Web.UI.WebControls.Label lblFirstAndLast;
		protected System.Web.UI.WebControls.ValidationSummary vlsEdit;
		protected WebControls.PageTitle PageTitle1;
		public static string HelpLink = string.Empty;
		int itemId = 0;
		int FunId = 0;
		protected WebControls.RicercaModulo RicercaModulo1;
		protected Csy.WebControls.MessagePanel PanelMess;
		protected WebControls.CalendarPicker CalendarPicker1;
		protected WebControls.CalendarPicker CalendarPicker3;
		protected S_Controls.S_TextBox txtsCP;
		protected S_Controls.S_TextBox txtsNoteCompletamento;
		public Classi.ManCorrettiva.ClManCorrettiva _ClManCorrettiva;		
		protected System.Web.UI.WebControls.Label LbCPnr;
		protected System.Web.UI.WebControls.Label lblOdl;
		protected S_Controls.S_ComboBox cmbs_Frequenza;
		protected S_Controls.S_Button btnSalva;
		protected S_Controls.S_Button btnCancella;
		protected System.Web.UI.HtmlControls.HtmlInputFile Uploader;
		protected S_Controls.S_Label S_Lblerror;
		protected System.Web.UI.WebControls.ValidationSummary ValidationSummary1;
		protected S_Controls.S_Label S_label1;
		private int Dimension=0;
		protected System.Web.UI.WebControls.HyperLink LkCons;
		protected System.Web.UI.WebControls.ImageButton btImgDeleteCons;
		protected System.Web.UI.WebControls.DropDownList Dropdownlist1;
		CP _fp;
			
	
		private void Page_Load(object sender, System.EventArgs e)
		{			
			//this.btnSalva.Attributes.Add("onclick","controllaValori();");

			PageTitle1.Title="Completamento Controlli Periodici";
			_ClManCorrettiva=new TheSite.Classi.ManCorrettiva.ClManCorrettiva();
			FunId = Int32.Parse(Request["FunId"]);			
			
			btImgDeleteCons.Visible =false;
			LkCons.Visible=false;
			
			if (Request["ItemID"] != null) 
			{
				itemId = Int32.Parse(Request["ItemID"]);				
			}

			if (!Page.IsPostBack )
			{	
				
				LoadFrequenze();
				if (itemId!=0)		
								
				{//Classi.ClassiAnagrafiche.Ditte _Ditte = new TheSite.Classi.ClassiAnagrafiche.Ditte();

				
					Classi.GestioneCP.SfogliaRdlOdl _GCP = new TheSite.Classi.GestioneCP.SfogliaRdlOdl(HttpContext.Current.User.ToString());
		
					DataSet _MyDs = _GCP.GETWRCP(itemId).Copy();	
					
					if (_MyDs.Tables[0].Rows.Count > 0)
					{					
						DataRow _Dr = _MyDs.Tables[0].Rows[0];
						
						//					id_wr_cp, id_wo_cp, descrizione, 
						//					data_inizio_prevista, data_completamento_fine, 
						//					id_bl, id_eq, id_freq 


						this.LbCPnr.Text=_Dr["id_wr_cp"].ToString();
						//descrizione CP
						this.txtsCP.Text= _Dr["descrizione"].ToString();
						//this.lblFreq.Text=_Dr["frequenza"].ToString();
						
						this.Dropdownlist1.SelectedValue=_Dr["cl"].ToString();

						//Data Inizio Lavori
						if(_Dr["data_inizio_prevista"] != DBNull.Value)
							CalendarPicker1.Datazione.Text =  _Dr["data_inizio_prevista"].ToString();
						
						//Data  Fine Lavori
						if(_Dr["data_completamento_fine"] != DBNull.Value)
							CalendarPicker3.Datazione.Text =  _Dr["data_completamento_fine"].ToString();
						//Data  Fine Lavori
					
						if (_Dr["note_completamento"]!= DBNull.Value)
							this.txtsNoteCompletamento.Text=(string) _Dr["note_completamento"];
						//LoadEdificio();
						//if (_Dr["id_bl"]!= DBNull.Value)
						if (_Dr["bl_id"]!= DBNull.Value)
							this.RicercaModulo1.TxtCodice.Text=_Dr["bl_id"].ToString();
						
						if (_Dr["id_freq"]!= DBNull.Value)
							this.cmbs_Frequenza.SelectedValue=_Dr["id_freq"].ToString();
						
						if (_Dr["nomefilecp"]!= DBNull.Value)
						{
							LkCons.Text=_Dr["nomefilecp"].ToString();
							btImgDeleteCons.CommandArgument=_Dr["id_wr_cp"].ToString();
							btImgDeleteCons.Visible =true;
							LkCons.Visible=true;
							string destDir =  "../Doc_DB/cp/" + _Dr["nomefilecp"].ToString();
							LkCons.NavigateUrl =destDir;
						}
						else{
							btImgDeleteCons.Visible =false;
							LkCons.Visible=false;
						}

							
						//LoadApparato();
						//if (_Dr["id_eq"]!= DBNull.Value && !_Dr["id_eq"].Equals("0"))
					
						//					LoadStatoLavoro();
						//					cmbsstatolavoro.SelectedValue=_Dr["id_stato_richiesta"].ToString();
						//					if (cmbsstatolavoro.SelectedValue=="4")
						//						cmbsstatolavoro.Enabled=false;
				
					}
						
				}
				else
				{
					btnCancella.Visible=false;
					LbCPnr.Text="";
					txtsCP.Text="";
					txtsNoteCompletamento.Text="";
					//LoadEdificio();
					LoadFrequenze();
					//string s_Messagggio = "- Nessun Apparato -";
					//this.cmbs_Apparato.Items.Add(Classi.GestoreDropDownList.ItemMessaggio(s_Messagggio,  String.Empty));
				}
						
			
				ViewState["UrlReferrer"] = Request.UrlReferrer.ToString();
				if(Context.Handler is TheSite.GestioneControlliPeriodici.CP) 
				{
					_fp = (TheSite.GestioneControlliPeriodici.CP) Context.Handler;
					this.ViewState.Add("mioContenitore",_fp._Contenitore); 
				}	

			}
		}

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


		
		
		//		private void LoadStatoLavoro()
		//		{
		//			this.cmbsstatolavoro.Items.Clear();		
		//		    
		//
		//			DataSet _MyDs = _ClManCorrettiva.GetStatoLavoro();
		//
		//			if (_MyDs.Tables[0].Rows.Count > 0)
		//			{
		//				this.cmbsstatolavoro.DataSource = Classi.GestoreDropDownList.ItemBlankDataSource(
		//					_MyDs.Tables[0], "descrizione", "id", "- Selezionare lo Stato di Lavoro  -", "");
		//				this.cmbsstatolavoro.DataTextField = "descrizione";
		//				this.cmbsstatolavoro.DataValueField = "id";
		//				this.cmbsstatolavoro.DataBind();          
		//
		//			//this.cmbsstatolavoro.Attributes.Add("onchange","SetStato(this.value);");
		//
		//			}
		//			else
		//			{
		//				string s_Messagggio = "- Nessuno Stato di Lavoro  -";
		//				this.cmbsstatolavoro.Items.Add(Classi.GestoreDropDownList.ItemMessaggio(s_Messagggio, String.Empty));
		//			}
		//		}
	
		//		private void LoadEdificio()
		//		{
		//			cmbs_Edificio.Items.Clear();
		//
		//			Classi.GestioneCP.CompletamentoCP  _inviodoc = new TheSite.Classi.GestioneCP.CompletamentoCP(Context.User.Identity.Name);
		//			DataSet Ds=_inviodoc.GetEdifici(Context.User.Identity.Name);
		//			
		//			if (Ds.Tables[0].Rows.Count > 0)
		//			{
		//				this.cmbs_Edificio.DataSource = Classi.GestoreDropDownList.ItemBlankDataSource(
		//					Ds.Tables[0], "denominazione", "id", "- Selezionare Edificio  -", "");
		//				this.cmbs_Edificio.DataTextField = "denominazione";
		//				this.cmbs_Edificio.DataValueField = "id";
		//				this.cmbs_Edificio.DataBind();          
		//
		//			}
		//			else
		//			{
		//				string s_Messagggio = "- Nessuno Edificio  -";
		//				this.cmbs_Edificio.Items.Add(Classi.GestoreDropDownList.ItemMessaggio(s_Messagggio, String.Empty));
		//				
		//			}
		//		}
	
		//		private void LoadApparato()
		//		{
		//			this.cmbs_Apparato.Items.Clear();
		//		
		//			Classi.GestioneCP.CompletamentoCP  _CompletamentoCP = new TheSite.Classi.GestioneCP.CompletamentoCP(Context.User.Identity.Name);
		//			
		//			DataSet _MyDs;
		//			
		//			S_ControlsCollection _SColl = new S_ControlsCollection();
		//
		//			S_Controls.Collections.S_Object s_p_id_bl = new S_Object();
		//			s_p_id_bl.ParameterName = "p_id_bl";
		//			s_p_id_bl.DbType = CustomDBType.Integer;
		//			s_p_id_bl.Direction = ParameterDirection.Input;
		//			s_p_id_bl.Size =100;
		//			s_p_id_bl.Index = 0;
		//			s_p_id_bl.Value =(cmbs_Edificio.SelectedValue=="")?0:int.Parse(cmbs_Edificio.SelectedValue);
		//			_SColl.Add(s_p_id_bl);
		//			
		//			_MyDs = _CompletamentoCP.GetApparati(_SColl).Copy();
		//                 
		//		
		//  
		//			if (_MyDs.Tables[0].Rows.Count > 0)
		//			{
		//				this.cmbs_Apparato.DataSource = Classi.GestoreDropDownList.ItemBlankDataSource(
		//					_MyDs.Tables[0], "DESCRIZIONE", "ID", "- Selezionare Apparato -", "0");
		//				this.cmbs_Apparato.DataTextField = "DESCRIZIONE";
		//				this.cmbs_Apparato.DataValueField = "ID";
		//				this.cmbs_Apparato.DataBind();
		//			}
		//			else
		//			{
		//				string s_Messagggio = "- Nessun Apparato -";
		//				this.cmbs_Apparato.Items.Add(Classi.GestoreDropDownList.ItemMessaggio(s_Messagggio,  String.Empty));
		//			}
		//
		//		}
		//		


		private void LoadFrequenze()
		{
			this.cmbs_Frequenza.Items.Clear();
		
			Classi.GestioneCP.CompletamentoCP _CompletamentoCP = new TheSite.Classi.GestioneCP.CompletamentoCP(Context.User.Identity.Name);
				
			DataSet _MyDs = _CompletamentoCP.GetDataFReq().Copy();
			  
			if (_MyDs.Tables[0].Rows.Count > 0)
			{				
				this.cmbs_Frequenza.DataSource = Classi.GestoreDropDownList.ItemBlankDataSource(
					_MyDs.Tables[0], "fqdes","id", "- Selezionare una Frequenza -", "");
				this.cmbs_Frequenza.DataTextField = "fqdes";
				this.cmbs_Frequenza.DataValueField = "id";
				this.cmbs_Frequenza.DataBind();
			}
			else
			{
				string s_Messagggio = "- Nessuna Frequenza -";
				this.cmbs_Frequenza.Items.Add(Classi.GestoreDropDownList.ItemMessaggio(s_Messagggio,  String.Empty));
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
			this.btImgDeleteCons.Click += new System.Web.UI.ImageClickEventHandler(this.btImgDeleteCons_Click);
			this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
			this.btnCancella.Click += new System.EventHandler(this.btnCancella_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

	
		//		private void btnsSalva_Click(object sender, System.EventArgs e)
		//		{			
		//			
		//			Classi.GestioneCP.CompletamentoCP _CCP = new TheSite.Classi.GestioneCP.CompletamentoCP();
		//			int i_RowsAffected = 0;
		//			S_Controls.Collections.S_ControlsCollection _SCollection = new S_Controls.Collections.S_ControlsCollection();
		//			//_SCollection.AddItems(this.PanelEdit.Controls);
		//		
		//			
		//			S_Object p_id_wr_cp = new S_Object();
		//			p_id_wr_cp.ParameterName = "p_id_wr_cp";
		//			p_id_wr_cp.DbType = CustomDBType.Integer;
		//			p_id_wr_cp.Direction = ParameterDirection.Input;
		//			p_id_wr_cp.Index = i_RowsAffected;
		//			p_id_wr_cp.Size = 100;
		//			p_id_wr_cp.Value = Int32.Parse(LblRdl.Text);
		//			_SCollection.Add(p_id_wr_cp);
		//			
		//			S_Object p_data_inizio_prevista = new S_Object();
		//			p_data_inizio_prevista.ParameterName = "p_data_inizio_prevista";
		//			p_data_inizio_prevista.DbType = CustomDBType.VarChar;
		//			p_data_inizio_prevista.Direction = ParameterDirection.Input;
		//			p_data_inizio_prevista.Index = i_RowsAffected++;
		//			p_data_inizio_prevista.Size=255;
		//			p_data_inizio_prevista.Value = CalendarPicker1.Datazione.Text;
		//			_SCollection.Add(p_data_inizio_prevista);
		//
		//
		//			S_Object p_data_fine_prevista = new S_Object();
		//			p_data_fine_prevista.ParameterName = "p_data_fine_prevista";
		//			p_data_fine_prevista.DbType = CustomDBType.VarChar;
		//			p_data_fine_prevista.Direction = ParameterDirection.Input;
		//			p_data_fine_prevista.Index = i_RowsAffected++;
		//			p_data_fine_prevista.Size=255;
		//			p_data_fine_prevista.Value = CalendarPicker2.Datazione.Text;
		//			_SCollection.Add(p_data_fine_prevista);
		//
		//			S_Object p_data_completamento_inizio = new S_Object();
		//			p_data_completamento_inizio.ParameterName = "p_data_completamento_inizio";
		//			p_data_completamento_inizio.DbType = CustomDBType.VarChar;
		//			p_data_completamento_inizio.Direction = ParameterDirection.Input;
		//			p_data_completamento_inizio.Index = i_RowsAffected++;
		//			p_data_completamento_inizio.Size=255;
		//			p_data_completamento_inizio.Value = CalendarPicker3.Datazione.Text;
		//			_SCollection.Add(p_data_completamento_inizio);
		//
		//			S_Object p_data_completamento_fine = new S_Object();
		//			p_data_completamento_fine.ParameterName = "p_data_completamento_fine";
		//			p_data_completamento_fine.DbType = CustomDBType.VarChar;
		//			p_data_completamento_fine.Direction = ParameterDirection.Input;
		//			p_data_completamento_fine.Index = i_RowsAffected++;
		//			p_data_completamento_fine.Size=255;
		//			p_data_completamento_fine.Value = CalendarPicker4.Datazione.Text;
		//			_SCollection.Add(p_data_completamento_fine);
		//			
		//			S_Object p_addetto_id = new S_Object();
		//			p_addetto_id.ParameterName = "p_addetto_id";
		//			p_addetto_id.DbType = CustomDBType.Integer;
		//			p_addetto_id.Direction = ParameterDirection.Input;
		//			p_addetto_id.Index = i_RowsAffected++;
		//			p_addetto_id.Size = 100;
		//			p_addetto_id.Value = Convert.ToInt32(cmbsAddetto.SelectedValue);
		//			_SCollection.Add(p_addetto_id);
		//
		//			
		//			S_Object p_id_stato_richiesta = new S_Object();
		//			p_id_stato_richiesta.ParameterName = "p_id_stato_richiesta";
		//			p_id_stato_richiesta.DbType = CustomDBType.Integer;
		//			p_id_stato_richiesta.Direction = ParameterDirection.Input;
		//			p_id_stato_richiesta.Index = i_RowsAffected++;
		//			p_id_stato_richiesta.Size = 100;
		//			p_id_stato_richiesta.Value = Convert.ToInt32(cmbsstatolavoro.SelectedValue);
		//			_SCollection.Add(p_id_stato_richiesta);
		//
		//
		//			S_Object p_note_completamento = new S_Object();
		//			p_note_completamento.ParameterName = "p_note_completamento";
		//			p_note_completamento.DbType = CustomDBType.VarChar;
		//			p_note_completamento.Direction = ParameterDirection.Input;
		//			p_note_completamento.Index = i_RowsAffected++;
		//			p_note_completamento.Size = 500;
		//			p_note_completamento.Value = txtsNoteCompletamento.Text;
		//			_SCollection.Add(p_note_completamento);
		//
		//			try {
		//				i_RowsAffected=_CCP.UPDATWEWRCP(_SCollection);
		//			
		//				}
		//			catch (Exception ex)
		//			{				
		//				string s_Err =  ex.Message.ToString().ToUpper();
		//				PanelMess.ShowError(s_Err, true);
		//			}	
		//
		//
		//		}

		//		private void btnAnnulla_Click(object sender, System.EventArgs e)
		//		{
		//
		//			Server.Transfer("CP.aspx");
		//
		//		}
		/// <summary>
		/// Indica che il file che si sta cercando di inviare già esiste.
		/// </summary>
		/// <returns></returns>
		private bool ExistFile(string RenameFileName)
		{
			if (Uploader.PostedFile!=null && Uploader.PostedFile.FileName!="") 
			{
				
				string fileName= System.IO.Path.GetFileName(Uploader.PostedFile.FileName);

				string destDir =Server.MapPath("../Doc_DB/cp");
				//Creazione del percorso dove il file va inserito
				
				if (!Directory.Exists(destDir))
					Directory.CreateDirectory(destDir);

				string destPath  =string.Empty; 
				//
				if (RenameFileName=="")
					destPath  = System.IO.Path.Combine(destDir, fileName);
				else
					destPath  = System.IO.Path.Combine(destDir, RenameFileName);

				return File.Exists(destPath);  
	
			}
			else
				return false;
		}

		private string PostFile(string RenameFile)
		{
			  
			if (Uploader.PostedFile!=null && Uploader.PostedFile.FileName!="") 
			{
				try
				{
					string fileName= System.IO.Path.GetFileName(Uploader.PostedFile.FileName);

					string destDir =Server.MapPath("../Doc_DB/cp");
					
	
					if (!Directory.Exists(destDir))
						Directory.CreateDirectory(destDir);

					string destPath  = System.IO.Path.Combine(destDir, fileName);
					this.Dimension=Uploader.PostedFile.ContentLength;
					

					Uploader.PostedFile.SaveAs(destPath);				
					return fileName;
				}
				catch (Exception ex)
				{
					S_Lblerror.Text=string.Format("Errore nell'invio del File: {0}",ex.Message); 
					Console.WriteLine(ex.Message);
					return "";
				}
			}
			else 
				return "";

		}

		private void btnSalva_Click(object sender, System.EventArgs e)
		{
			

////////////////////////////// gestione file
			///
			string exte=string.Empty; 
			string nomefile=string.Empty;
			//Si tratta di un inserimento
			if (Uploader.PostedFile.FileName!=null)
			{
				if(LkCons!=null && LkCons.Text!=null && !LkCons.Text.Equals(""))
				{
					string destDir =Server.MapPath("../Doc_DB/cp");
				
					destDir=System.IO.Path.Combine(destDir, LkCons.Text);
					File.Delete(destDir);
				}

				exte= System.IO.Path.GetExtension(Uploader.PostedFile.FileName);
				if (this.ExistFile(exte)==true)
				{
					S_Lblerror.Text="Il file è già presente impossibile inserire."; 
					return;
				} 
			}

			//Posto il file eventuale selezionato
			nomefile=PostFile(exte);
////////// Gestione file





			Classi.GestioneCP.CompletamentoCP _CCP = new TheSite.Classi.GestioneCP.CompletamentoCP();
			int i_RowsAffected = 0;
			S_Controls.Collections.S_ControlsCollection _SCollection = new S_Controls.Collections.S_ControlsCollection();
			
			S_Object p_descrizione = new S_Object();
			p_descrizione.ParameterName = "p_descrizione";
			p_descrizione.DbType = CustomDBType.VarChar;
			p_descrizione.Direction = ParameterDirection.Input;
			p_descrizione.Index = i_RowsAffected++;
			p_descrizione.Size=4000;
			p_descrizione.Value = txtsCP.Text;
			_SCollection.Add(p_descrizione);

			S_Controls.Collections.S_Object p_servizio= new S_Object();
			p_servizio.ParameterName = "p_servizio";
			p_servizio.DbType = CustomDBType.VarChar;
			p_servizio.Direction = ParameterDirection.Input;
			p_servizio.Index = i_RowsAffected++;;
			p_servizio.Size=255;
			p_servizio.Value=Dropdownlist1.SelectedValue;
			_SCollection.Add(p_servizio);

			S_Object p_data_inizio_prevista = new S_Object();
			p_data_inizio_prevista.ParameterName = "p_data_inizio_prevista";
			p_data_inizio_prevista.DbType = CustomDBType.VarChar;
			p_data_inizio_prevista.Direction = ParameterDirection.Input;
			p_data_inizio_prevista.Index = i_RowsAffected++;
			p_data_inizio_prevista.Size=255;
			p_data_inizio_prevista.Value = CalendarPicker1.Datazione.Text;
			_SCollection.Add(p_data_inizio_prevista);

			//				if (itemId != 0)
			//				{
			S_Object p_data_completamento_fine = new S_Object();
			p_data_completamento_fine.ParameterName = "p_data_completamento_fine";
			p_data_completamento_fine.DbType = CustomDBType.VarChar;
			p_data_completamento_fine.Direction = ParameterDirection.Input;
			p_data_completamento_fine.Index = i_RowsAffected++;
			p_data_completamento_fine.Size=255;
			p_data_completamento_fine.Value = CalendarPicker3.Datazione.Text;
			_SCollection.Add(p_data_completamento_fine);

			S_Object p_note_completamento = new S_Object();
			p_note_completamento.ParameterName = "p_note_completamento";
			p_note_completamento.DbType = CustomDBType.VarChar;
			p_note_completamento.Direction = ParameterDirection.Input;
			p_note_completamento.Index = i_RowsAffected++;
			p_note_completamento.Size = 500;
			p_note_completamento.Value = txtsNoteCompletamento.Text;
			_SCollection.Add(p_note_completamento);
			//				}

			//				S_Object p_id_bl = new S_Object();
			//				p_id_bl.ParameterName = "p_id_bl";
			//				p_id_bl.DbType = CustomDBType.Integer;
			//				p_id_bl.Direction = ParameterDirection.Input;
			//				p_id_bl.Index = i_RowsAffected++;
			//				p_id_bl.Size = 100;
			//				p_id_bl.Value = Convert.ToInt32(cmbs_Edificio.SelectedValue);
			//				_SCollection.Add(p_id_bl);


			S_Controls.Collections.S_Object s_p_Bl_Id = new S_Controls.Collections.S_Object();
			s_p_Bl_Id.ParameterName = "p_Bl_Id";
			s_p_Bl_Id.DbType = ApplicationDataLayer.DBType.CustomDBType.VarChar;
			s_p_Bl_Id.Direction = ParameterDirection.Input;
			s_p_Bl_Id.Size =50;
			s_p_Bl_Id.Index = 0;
			s_p_Bl_Id.Value = RicercaModulo1.TxtCodice.Text;
			_SCollection.Add(s_p_Bl_Id);

			//				S_Object p_id_eq = new S_Object();
			//				p_id_eq.ParameterName = "p_id_eq";
			//				p_id_eq.DbType = CustomDBType.Integer;
			//				p_id_eq.Direction = ParameterDirection.Input;
			//				p_id_eq.Index = i_RowsAffected++;
			//				p_id_eq.Size = 100;
			//				p_id_eq.Value = (cmbs_Apparato.SelectedValue=="")?0:int.Parse(cmbs_Apparato.SelectedValue);
			//					//Convert.ToInt32(cmbs_Apparato.SelectedValue);
			//				_SCollection.Add(p_id_eq);
				
		
				
			

			S_Object p_id_freq = new S_Object();
			p_id_freq.ParameterName = "p_id_freq";
			p_id_freq.DbType = CustomDBType.Integer;
			p_id_freq.Direction = ParameterDirection.Input;
			p_id_freq.Index = i_RowsAffected++;
			p_id_freq.Size = 100;
			p_id_freq.Value = Convert.ToInt32(cmbs_Frequenza.SelectedValue);
			_SCollection.Add(p_id_freq);

			S_Controls.Collections.S_Object s_p_nomefile = new S_Object();
			s_p_nomefile.ParameterName = "p_nomefile";
			s_p_nomefile.DbType = CustomDBType.VarChar;
			s_p_nomefile.Direction = ParameterDirection.Input;
			s_p_nomefile.Index =1;
			s_p_nomefile.Size =50;
			s_p_nomefile.Value = nomefile;
			_SCollection.Add(s_p_nomefile);
			
			if (itemId != 0)
			{
				S_Object p_id_wr_cp = new S_Object();
				p_id_wr_cp.ParameterName = "p_id_wr_cp";
				p_id_wr_cp.DbType = CustomDBType.Integer;
				p_id_wr_cp.Direction = ParameterDirection.Input;
				p_id_wr_cp.Index = i_RowsAffected;
				p_id_wr_cp.Size = 100;
				p_id_wr_cp.Value = Int32.Parse(LbCPnr.Text);
				_SCollection.Add(p_id_wr_cp);
			}
			
			try 
			{
				//					int DATAINIZIONUM=0;
				//					int DATAFINENUM=0;
				//					if (CalendarPicker1.Datazione.Text!= "")
				//					{
				//						string[] DATAINIZIO =  CalendarPicker1.Datazione.Text.Split(Convert.ToChar("/"));
				//					
				//						DATAINIZIONUM= Int32.Parse(DATAINIZIO[2]+DATAINIZIO[1]+DATAINIZIO[0]);}
				//									
				//					if (CalendarPicker3.Datazione.Text!= "")
				//					{
				//						string[] DATAFINE = CalendarPicker3.Datazione.Text.Split(Convert.ToChar("/"));
				//						DATAFINENUM= Int32.Parse(DATAFINE[2]+DATAFINE[1]+DATAFINE[0]);
				//					}
				if (itemId != 0)
				{
					itemId=_CCP.UPD_CP(_SCollection);
					Server.Transfer("CP.aspx");
				}
				else
				{
					itemId=_CCP.INS_CP(_SCollection); 
					Server.Transfer("CP.aspx");
				}
			}					
			catch (Exception ex)
			{				
				string s_Err =  ex.Message.ToString().ToUpper();
				PanelMess.ShowError(s_Err, true);
			}	
			

		}

		//		private void cmbs_Edificio_SelectedIndexChanged(object sender, System.EventArgs e)
		//		{
		//			LoadApparato();
		//		}

		

		private void btnCancella_Click(object sender, System.EventArgs e)
		{
			if (itemId != 0)
			{	
				Classi.GestioneCP.CompletamentoCP _CCP = new TheSite.Classi.GestioneCP.CompletamentoCP();
				int i_RowsAffected = 0;
				S_Controls.Collections.S_ControlsCollection _SCollection = new S_Controls.Collections.S_ControlsCollection();
				
				S_Object p_id_wr_cp = new S_Object();
				p_id_wr_cp.ParameterName = "p_id_wr_cp";
				p_id_wr_cp.DbType = CustomDBType.Integer;
				p_id_wr_cp.Direction = ParameterDirection.Input;
				p_id_wr_cp.Index = i_RowsAffected;
				p_id_wr_cp.Size = 100;
				p_id_wr_cp.Value = Int32.Parse(LbCPnr.Text);
				_SCollection.Add(p_id_wr_cp);

				itemId=_CCP.DEL_CP(_SCollection);
				Server.Transfer("CP.aspx");
			}
		}

		private void btImgDeleteCons_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			int i_RowsAffected = 0;
			if(LkCons.Text=="")
			{
				LkCons.Visible =false;
				btImgDeleteCons.Visible=false;
				return;
			}

			Classi.GestioneCP.CompletamentoCP _CCP = new TheSite.Classi.GestioneCP.CompletamentoCP();
			S_ControlsCollection _SCollection = new S_ControlsCollection();
			int result=0;
		
			S_Object p_id_wr_cp = new S_Object();
			p_id_wr_cp.ParameterName = "p_id_wr_cp";
			p_id_wr_cp.DbType = CustomDBType.Integer;
			p_id_wr_cp.Direction = ParameterDirection.Input;
			p_id_wr_cp.Index = i_RowsAffected;
			p_id_wr_cp.Size = 100;
			p_id_wr_cp.Value = Int32.Parse(LbCPnr.Text);
			_SCollection.Add(p_id_wr_cp);

			result= _CCP.ExecuteUpdateFile(_SCollection); 

			string destDir =Server.MapPath("../Doc_DB/cp");
			
			destDir=System.IO.Path.Combine(destDir, LkCons.Text);
			File.Delete(destDir);

			LkCons.Visible =false;
			btImgDeleteCons.Visible=false;
		}

		private void btnAnnulla_Click(object sender, System.EventArgs e)
		{
			Server.Transfer("CP.aspx");
		}
	}


	
}

