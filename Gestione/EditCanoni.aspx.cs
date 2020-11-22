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



namespace TheSite.Gestione
{
	/// <summary>
	
	/// </summary>
	public class EditCanoni : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Label lblOperazione;
		protected Csy.WebControls.MessagePanel PanelMess;		
		protected System.Web.UI.WebControls.Panel PanelEdit;
		protected S_Controls.S_Button btnsSalva;
		protected S_Controls.S_Button btnsElimina;
		protected System.Web.UI.WebControls.Button btnAnnulla;
		protected System.Web.UI.WebControls.Label lblFirstAndLast;
		protected System.Web.UI.WebControls.RequiredFieldValidator rfvEqstd;
		protected S_Controls.S_TextBox txtsdescrizione;
		protected System.Web.UI.WebControls.ValidationSummary vlsEdit;
		int itemId = 0;
		int FunId = 0;
		private int Dimension=0;
		protected S_Controls.S_ComboBox S_anno;
		protected S_Controls.S_TextBox ImpCons1;
		protected S_Controls.S_TextBox ImpCons2;
		protected System.Web.UI.WebControls.DropDownList DropMese;
		protected System.Web.UI.WebControls.HyperLink LkCons;
		protected System.Web.UI.WebControls.ImageButton btImgDeleteCons;
		protected System.Web.UI.HtmlControls.HtmlInputFile Uploader;
		protected S_Controls.S_Label S_Lblerror;
		public string nomefile=string.Empty;
		protected S_Controls.S_TextBox S_TextBox1;
		protected System.Web.UI.WebControls.Label LbCPnr;
		protected System.Web.UI.WebControls.Button btn_S_Hlav;
		protected System.Web.UI.WebControls.Repeater Repeater1;
		protected S_Controls.S_TextBox S_textbox2;
		protected S_Controls.S_TextBox S_textbox3;
		protected System.Web.UI.WebControls.DropDownList Dropdownlist1;
		
		Canoni _fp;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			FunId = Int32.Parse(Request["FunId"]);			

			lblFirstAndLast.Visible=true;
			btImgDeleteCons.Visible =false;
			LkCons.Visible=false;
			
			if (Request["itemId"] != null) 
			{
				itemId = Int32.Parse(Request["itemId"]);				
			}

			if (!Page.IsPostBack )
			{					
				LoadAnno();
				
				if (itemId != 0) 
				{					
					
					Dropdownlist1.Enabled=true;
					S_textbox2.Enabled=true;
					S_textbox3.Enabled=true;
					btn_S_Hlav.Enabled=true;
					
					Classi.ClassiAnagrafiche.Contab _Contab = new TheSite.Classi.ClassiAnagrafiche.Contab();
				
					DataSet _MyDs = _Contab.GetSingleData_Canone(itemId).Copy();									
					
					if (_MyDs.Tables[0].Rows.Count == 1)
					{					
						DataRow _Dr = _MyDs.Tables[0].Rows[0];						
						
						this.LbCPnr.Text=_Dr["id"].ToString();
						
						LoadCanoniServizi();


						if (_Dr["Descrizione"] != DBNull.Value)
							this.txtsdescrizione.Text = (string) _Dr["descrizione"];

						if (_Dr["mesenum"] != DBNull.Value)
							this.DropMese.SelectedValue = (string) _Dr["mesenum"];
						
						if (_Dr["anno"] != DBNull.Value)
							this.S_anno.SelectedValue =  _Dr["anno"].ToString();						
						
						if (_Dr["importo"] != DBNull.Value)
						{
							this.ImpCons1.Text=Classi.Function.GetTypeNumber(_Dr["importo"], TheSite.Classi.NumberType.Intero);  
							this.ImpCons2.Text =Classi.Function.GetTypeNumber(_Dr["importo"], TheSite.Classi.NumberType.Decimale); 
						}

						if (_Dr["nomefile"]!= DBNull.Value)
						{
							LkCons.Text=_Dr["nomefile"].ToString();
							btImgDeleteCons.CommandArgument=_Dr["id"].ToString();
							btImgDeleteCons.Visible =true;
							LkCons.Visible=true;
							string destDir =  "../Doc_DB/canoni/" + _Dr["nomefile"].ToString();
							LkCons.NavigateUrl =destDir;
						}
						else
						{
							btImgDeleteCons.Visible =false;
							LkCons.Visible=false;
						}




						//lblFirstAndLast.Text=_Contab.GetFirstAndLastUser(_Dr);

						this.lblOperazione.Text = "Modifica Canone : " + this.txtsdescrizione.Text;
						this.lblFirstAndLast.Visible = true;												
						this.btnsElimina.Visible = true;
						this.btnsElimina.Attributes.Add("onclick", "return confirm('Si vuole effettuare la cancellazione?')");
					
					}		
				}
				else
				{
					Dropdownlist1.Enabled=false;
					S_textbox2.Enabled=false;
					S_textbox3.Enabled=false;
					btn_S_Hlav.Enabled=false;

					this.lblOperazione.Text = "Inserimento Canoni";
					this.lblFirstAndLast.Visible = false;
					this.btnsElimina.Visible = false;
					
				}
				
				ViewState["UrlReferrer"] = Request.UrlReferrer.ToString();
				if(Context.Handler is TheSite.Gestione.Canoni) 
				{
					_fp = (TheSite.Gestione.Canoni) Context.Handler;
					this.ViewState.Add("mioContenitore",_fp._Contenitore); 
				}	
				
				if (Request["TipoOper"] == "read")
				{
					txtsdescrizione.Enabled=false;
					btnsElimina.Enabled=false;
					btnsSalva.Enabled=false;
				}
				else
				{
					txtsdescrizione.Enabled=true;					
					btnsElimina.Enabled=true;
					btnsSalva.Enabled=true;
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
			this.btImgDeleteCons.Click += new System.Web.UI.ImageClickEventHandler(this.btImgDeleteCons_Click);
			this.btn_S_Hlav.Click += new System.EventHandler(this.btn_S_Hlav_Click);
			this.Repeater1.ItemDataBound += new System.Web.UI.WebControls.RepeaterItemEventHandler(this.Repeater1_ItemDataBound);
			this.Repeater1.ItemCommand += new System.Web.UI.WebControls.RepeaterCommandEventHandler(this.Repeater1_ItemCommand);
			this.btnsSalva.Click += new System.EventHandler(this.btnsSalva_Click);
			this.btnsElimina.Click += new System.EventHandler(this.btnsElimina_Click);
			this.btnAnnulla.Click += new System.EventHandler(this.btnAnnulla_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		private void btnsSalva_Click(object sender, System.EventArgs e)
		{
			string exte=string.Empty; 
			string nomefile=string.Empty;
			//Si tratta di un inserimento
			if (Uploader.PostedFile.FileName!=null)
			{
				if(LkCons!=null && LkCons.Text!=null && !LkCons.Text.Equals(""))
				{
					string destDir =Server.MapPath("../Doc_DB/canoni");
				
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
			nomefile=PostFile(exte);
			S_TextBox1.Text=PostFile(exte);

//			string mes="Attenzione il Canone Mensile: " + txtsdescrizione.Text.Trim(); 
//			mes+=" è già presente nel sistema" ;			
			Aggiorna();	
//			if(itemId==0)
//				if(ControllaDup())
//					Aggiorna();
//				else
//					Classi.SiteJavaScript.msgBox(this.Page,mes); 
//			else
//				Aggiorna();				
			
		}

		private void btnAnnulla_Click(object sender, System.EventArgs e)
		{
			Server.Transfer("Canoni.aspx");
		}

		private void btnsElimina_Click(object sender, System.EventArgs e)
		{
			Classi.ClassiAnagrafiche.Contab _Contab = new TheSite.Classi.ClassiAnagrafiche.Contab();				
						
			this.txtsdescrizione.DBDefaultValue = DBNull.Value;
			this.txtsdescrizione.Text=this.txtsdescrizione.Text.Trim();
			int i_RowsAffected = 0;

			S_Controls.Collections.S_ControlsCollection _SCollection = new S_Controls.Collections.S_ControlsCollection();


			// Id
			S_Controls.Collections.S_Object s_IdIn = new S_Object();
			s_IdIn.ParameterName = "p_Id";
			s_IdIn.DbType = CustomDBType.Integer;
			s_IdIn.Direction = ParameterDirection.Input;
			s_IdIn.Size=10;
			s_IdIn.Index = _SCollection.Count;
			s_IdIn.Value = itemId;									
			
			_SCollection.Add(s_IdIn);
			// 
			S_Controls.Collections.S_Object s_descrizione = new S_Object();
			s_descrizione.ParameterName = "p_DESCRIZIONE";
			s_descrizione.DbType = CustomDBType.VarChar;
			s_descrizione.Direction = ParameterDirection.Input;
			s_descrizione.Size=255;
			s_descrizione.Index = _SCollection.Count;;
			s_descrizione.Value = txtsdescrizione.Text;	
			
			_SCollection.Add(s_descrizione);

			S_Controls.Collections.S_Object s_nomefile = new S_Object();
			s_nomefile.ParameterName = "p_nomefile";
			s_nomefile.DbType = CustomDBType.VarChar;
			s_nomefile.Direction = ParameterDirection.Input;
			s_nomefile.Size=255;
			s_nomefile.Index = _SCollection.Count;;
			s_nomefile.Value = nomefile;	
			
			_SCollection.Add(s_nomefile);

			S_Controls.Collections.S_Object s_mesi = new S_Object();
			s_mesi.ParameterName = "p_mese";
			s_mesi.DbType = CustomDBType.VarChar;
			s_mesi.Direction = ParameterDirection.Input;
			s_mesi.Size=255;
			s_mesi.Index = _SCollection.Count;;
			s_mesi.Value = DropMese.SelectedValue;	
			
			_SCollection.Add(s_mesi);

			S_Controls.Collections.S_Object s_anni = new S_Object();
			s_anni.ParameterName = "p_anno";
			s_anni.DbType = CustomDBType.VarChar;
			s_anni.Direction = ParameterDirection.Input;
			s_anni.Size=255;
			s_anni.Index = _SCollection.Count;;
			s_anni.Value =int.Parse(S_anno.SelectedValue);	
			
			_SCollection.Add(s_anni);
			
			S_Controls.Collections.S_Object s_imp = new S_Object();
			s_imp.ParameterName = "p_importo";
			s_imp.DbType = CustomDBType.Double;
			s_imp.Direction = ParameterDirection.Input;
			s_imp.Size=20;
			s_imp.Index = _SCollection.Count;
			if(ImpCons1.Text=="")
				s_imp.Value =0;
			else
				s_imp.Value =double.Parse(ImpCons1.Text + "," + ImpCons2.Text); 
		
			
			_SCollection.Add(s_imp);
			


			try
			{
				
				i_RowsAffected = _Contab.Execute_Canoni(_SCollection,"Delete");												
				Server.Transfer("Canoni.aspx");				
			}

			catch (Exception ex)
			{				
				string s_Err =  ex.Message.ToString().ToUpper();
				PanelMess.ShowError(s_Err, true);
			}			
		}

		private bool ControllaDup()
		{
			
			Classi.Function _Function = new TheSite.Classi.Function();
			// Nome della tabella 
			string tabella = "Contabilizzazione";
			// Nome del campo sui cui effettuare la ricerca (WHERE)
			string campo_input = "Contabilizzazione";
			// Il campo valore è relativo alla stringa
			string valore = "'" + txtsdescrizione.Text.Trim().Replace("'","''") + "'";			
			// Nome del Campo restituito in Output
			string campo_output = "IdContabilizzazione";

			DataSet _MyDs =_Function.ControllaDuplicato(tabella,campo_input,valore,campo_output);											
			
			if (_MyDs.Tables[0].Rows.Count==0)
				return true;
			else
				return false;
		}

		private void LoadAnno()
		{
		
			for(int i=2014;i<=2025;i++)
				S_anno.Items.Add(new ListItem(i.ToString(),i.ToString()));  
		}
	
		private string PostFile(string RenameFile)
		{
			  
			if (Uploader.PostedFile!=null && Uploader.PostedFile.FileName!="") 
			{
				try
				{
					string fileName= System.IO.Path.GetFileName(Uploader.PostedFile.FileName);

					string destDir =Server.MapPath("../Doc_DB/canoni");
					
	
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
		private bool ExistFile(string RenameFileName)
		{
			if (Uploader.PostedFile!=null && Uploader.PostedFile.FileName!="") 
			{
				
				string fileName= System.IO.Path.GetFileName(Uploader.PostedFile.FileName);

				string destDir =Server.MapPath("../Doc_DB/canoni");
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
		
		
		private void LoadCanoniServizi()
		{
			TheSite.Classi.ClassiAnagrafiche.Contab _Contab= new  TheSite.Classi.ClassiAnagrafiche.Contab();
			DataSet _MyDs = _Contab.GetData_CanoneServizi(this.itemId);
			if(_MyDs.Tables[0].Rows.Count==0)
			{
				Repeater1.Visible =false;
				return;
			}
			Repeater1.Visible =true;
			Repeater1.DataSource =_MyDs.Tables[0];
			Repeater1.DataBind();

		
		}


		private void Aggiorna()
		{
			Classi.ClassiAnagrafiche.Contab _Contab = new TheSite.Classi.ClassiAnagrafiche.Contab();				
						
			this.txtsdescrizione.DBDefaultValue = DBNull.Value;
			this.txtsdescrizione.Text=this.txtsdescrizione.Text.Trim();
			int i_RowsAffected = 0;

			S_Controls.Collections.S_ControlsCollection _SCollection = new S_Controls.Collections.S_ControlsCollection();
			

			// Id
			S_Controls.Collections.S_Object s_IdIn = new S_Object();
			s_IdIn.ParameterName = "p_Id";
			s_IdIn.DbType = CustomDBType.Integer;
			s_IdIn.Direction = ParameterDirection.Input;
			s_IdIn.Size=10;
			s_IdIn.Index = _SCollection.Count;
			s_IdIn.Value = itemId;									
			
			_SCollection.Add(s_IdIn);
			// 
			S_Controls.Collections.S_Object s_descrizione = new S_Object();
			s_descrizione.ParameterName = "p_DESCRIZIONE";
			s_descrizione.DbType = CustomDBType.VarChar;
			s_descrizione.Direction = ParameterDirection.Input;
			s_descrizione.Size=255;
			s_descrizione.Index = _SCollection.Count;;
			s_descrizione.Value = txtsdescrizione.Text;	
			
			_SCollection.Add(s_descrizione);

			S_Controls.Collections.S_Object s_nomefile = new S_Object();
			s_nomefile.ParameterName = "p_nomefile";
			s_nomefile.DbType = CustomDBType.VarChar;
			s_nomefile.Direction = ParameterDirection.Input;
			s_nomefile.Size=255;
			s_nomefile.Index = _SCollection.Count;;
			s_nomefile.Value = S_TextBox1.Text;	
			
			_SCollection.Add(s_nomefile);

			S_Controls.Collections.S_Object s_mesi = new S_Object();
			s_mesi.ParameterName = "p_mese";
			s_mesi.DbType = CustomDBType.VarChar;
			s_mesi.Direction = ParameterDirection.Input;
			s_mesi.Size=255;
			s_mesi.Index = _SCollection.Count;;
			s_mesi.Value = DropMese.SelectedValue;	
			
			_SCollection.Add(s_mesi);

			S_Controls.Collections.S_Object s_anni = new S_Object();
			s_anni.ParameterName = "p_anno";
			s_anni.DbType = CustomDBType.Integer;
			s_anni.Direction = ParameterDirection.Input;
			s_anni.Size=255;
			s_anni.Index = _SCollection.Count;;
			s_anni.Value =int.Parse(S_anno.SelectedValue);	
			
			_SCollection.Add(s_anni);
			
			S_Controls.Collections.S_Object s_imp = new S_Object();
			s_imp.ParameterName = "p_importo";
			s_imp.DbType = CustomDBType.Double;
			s_imp.Direction = ParameterDirection.Input;
			s_imp.Size=20;
			s_imp.Index = _SCollection.Count;
			if(ImpCons1.Text=="")
				s_imp.Value =0;
			else
				s_imp.Value =double.Parse(ImpCons1.Text + "," + ImpCons2.Text); 
		
			
			_SCollection.Add(s_imp);
			

			try
			{
				if (itemId == 0)
				{
						i_RowsAffected = _Contab.Execute_Canoni(_SCollection,"Insert");
					if (i_RowsAffected==-1000)
					{
					S_Lblerror.Text="canone del mese/anno già inserito, inserimento non effettuato";
					}
					else
					{
						lblFirstAndLast.Text="inserimento effettuato"; 
						Server.Transfer("Canoni.aspx");	
					}
				}
				else
				{i_RowsAffected = _Contab.Execute_Canoni(_SCollection,"Update");
				lblFirstAndLast.Text="aggiornamento effettuato";
				
				}				
					
				//Server.Transfer("Canoni.aspx");				
			}

			catch (Exception ex)
			{				
				string s_Err =  ex.Message.ToString().ToUpper();
				PanelMess.ShowError(s_Err, true);
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

			Classi.ClassiAnagrafiche.Contab _Contab = new TheSite.Classi.ClassiAnagrafiche.Contab();
			S_ControlsCollection _SCollection = new S_ControlsCollection();
			int result=0;
		
			S_Object p_id = new S_Object();
			p_id.ParameterName = "p_id";
			p_id.DbType = CustomDBType.Integer;
			p_id.Direction = ParameterDirection.Input;
			p_id.Index = i_RowsAffected;
			p_id.Size = 100;
			p_id.Value = Int32.Parse(LbCPnr.Text);
			_SCollection.Add(p_id);

			result= _Contab.ExecuteUpdateFile(_SCollection); 

			string destDir =Server.MapPath("../Doc_DB/canoni");
			
			destDir=System.IO.Path.Combine(destDir, LkCons.Text);
			File.Delete(destDir);

			LkCons.Visible =false;
			btImgDeleteCons.Visible=false;
		}

		private void Repeater1_ItemCommand(object source, System.Web.UI.WebControls.RepeaterCommandEventArgs e)
		{
			if(e.CommandName.ToLower().Equals("delete")) 
			{
				
				Classi.ClassiAnagrafiche.Contab _Contab = new TheSite.Classi.ClassiAnagrafiche.Contab();
				int result=_Contab.Execute_Canoni_Servizidel(Int32.Parse(e.CommandArgument.ToString()));				
				LoadCanoniServizi();
			}
		}

		private void Repeater1_ItemDataBound(object sender, System.Web.UI.WebControls.RepeaterItemEventArgs e)
		{
			if(e.Item.ItemType ==ListItemType.Item ||   e.Item.ItemType ==ListItemType.AlternatingItem)
			{
			
				ImageButton bt=e.Item.FindControl("delete1") as ImageButton; 
				bt.Attributes.Add("onclick", "return deletedoc();");
			}
		
		}

		private void btn_S_Hlav_Click(object sender, System.EventArgs e)
		{
			S_ControlsCollection _SColl = new S_ControlsCollection();
			
			S_Controls.Collections.S_Object p_id_canoni = new S_Object();
			p_id_canoni.ParameterName = "p_id_canone";
			p_id_canoni.DbType = CustomDBType.Integer;
			p_id_canoni.Direction = ParameterDirection.Input;
			p_id_canoni.Index = _SColl.Count;			 
			p_id_canoni.Value =itemId;
			_SColl.Add(p_id_canoni);
			

			S_Controls.Collections.S_Object p_servizio= new S_Object();
			p_servizio.ParameterName = "p_descrizione";
			p_servizio.DbType = CustomDBType.VarChar;
			p_servizio.Direction = ParameterDirection.Input;
			p_servizio.Index = _SColl.Count;
			p_servizio.Size=255;
			p_servizio.Value=Dropdownlist1.SelectedValue;
			_SColl.Add(p_servizio);

			S_Controls.Collections.S_Object s_imp = new S_Object();
			s_imp.ParameterName = "p_importo";
			s_imp.DbType = CustomDBType.Double;
			s_imp.Direction = ParameterDirection.Input;
			s_imp.Size=20;
			s_imp.Index = _SColl.Count;
			if(S_textbox2.Text=="")
				s_imp.Value =0;
			else
				s_imp.Value =double.Parse(S_textbox2.Text + "," + S_textbox3.Text); 
				
			_SColl.Add(s_imp);

			
			Classi.ClassiAnagrafiche.Contab _Contab = new TheSite.Classi.ClassiAnagrafiche.Contab();
			int result= _Contab.Execute_CanoniServiziins(_SColl);

			
			LoadCanoniServizi();
			
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
	}
}

#endregion