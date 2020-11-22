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
	public class ins_doc_normativi : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Label lblFirstAndLast;
		protected System.Web.UI.WebControls.ValidationSummary vlsEdit;
		protected WebControls.PageTitle PageTitle1;
		public static string HelpLink = string.Empty;
		int itemId = 0;
		int FunId = 0;
		protected Csy.WebControls.MessagePanel PanelMess;
		protected S_Controls.S_Button btnAnnulla;
		public Classi.ManCorrettiva.ClManCorrettiva _ClManCorrettiva;
		protected S_Controls.S_Button btnSalva;
		protected S_Controls.S_Button btnCancella;
		protected System.Web.UI.HtmlControls.HtmlInputFile Uploader;
		protected S_Controls.S_Label S_Lblerror;
		protected System.Web.UI.WebControls.ValidationSummary ValidationSummary1;
		protected S_Controls.S_Label S_label1;
		private int Dimension=0;
		protected System.Web.UI.WebControls.HyperLink LkCons;
		protected System.Web.UI.WebControls.ImageButton btImgDeleteCons;
		protected S_Controls.S_TextBox txtsNomeDoc;
		protected S_Controls.S_TextBox txtsDescDoc;
		protected S_Controls.S_TextBox txtsNormaApp;
		protected S_Controls.S_TextBox txtsVersDoc;
		//protected S_Controls.S_TextBox txtsIdDocNorm;
		protected System.Web.UI.WebControls.Panel PanelEdit;
		ric_doc_normativi _fp;
			
	
		private void Page_Load(object sender, System.EventArgs e)
		{			
			//this.btnSalva.Attributes.Add("onclick","controllaValori();");

			PageTitle1.Title="Documenti Normativi";
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
				
				if (itemId!=0)		
				{//Classi.ClassiAnagrafiche.Ditte _Ditte = new TheSite.Classi.ClassiAnagrafiche.Ditte();

				
					Classi.GestioneCP.DocNormativi docNorm = new TheSite.Classi.GestioneCP.DocNormativi(HttpContext.Current.User.ToString());
		
					DataSet _MyDs = docNorm.GETDOCNORM(itemId).Copy();	
					
					if (_MyDs.Tables[0].Rows.Count > 0)
					{					
						DataRow _Dr = _MyDs.Tables[0].Rows[0];
						
						//					id_wr_cp, id_wo_cp, descrizione, 
						//					data_inizio_prevista, data_completamento_fine, 
						//					id_bl, id_eq, id_freq 

						this.txtsNomeDoc.Text =_Dr["nome_doc"].ToString();
						this.txtsDescDoc.Text =_Dr["desc_doc"].ToString();
						this.txtsNormaApp.Text=_Dr["norma_apparenza"].ToString();
						this.txtsVersDoc.Text =_Dr["versione_doc"].ToString();

						if (_Dr["file_name"]!= DBNull.Value)
						{
							LkCons.Text=_Dr["file_name"].ToString();
							btImgDeleteCons.CommandArgument=_Dr["id_doc_norm"].ToString();
							btImgDeleteCons.Visible =true;
							LkCons.Visible=true;
							string destDir =  "../Doc_DB/doc_norm/" + _Dr["file_name"].ToString();
							LkCons.NavigateUrl =destDir;
						}
						else{
							btImgDeleteCons.Visible =false;
							LkCons.Visible=false;
						}

					}
						
				}
				else
				{
					btnCancella.Visible=false;
					this.txtsNomeDoc.Text = "";
					this.txtsDescDoc.Text = "";
					this.txtsNormaApp.Text= "";
					this.txtsVersDoc.Text = "";
				}
						
			
				ViewState["UrlReferrer"] = Request.UrlReferrer.ToString();
				if(Context.Handler is TheSite.GestioneControlliPeriodici.ric_doc_normativi) 
				{
					_fp = (TheSite.GestioneControlliPeriodici.ric_doc_normativi) Context.Handler;
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
			this.btnAnnulla.Click += new System.EventHandler(this.btnAnnulla_Click);
			this.btnCancella.Click += new System.EventHandler(this.btnCancella_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		/// <summary>
		/// Indica che il file che si sta cercando di inviare già esiste.
		/// </summary>
		/// <returns></returns>
		private bool ExistFile(string RenameFileName)
		{
			if (Uploader.PostedFile!=null && Uploader.PostedFile.FileName!="") 
			{
				
				string fileName= System.IO.Path.GetFileName(Uploader.PostedFile.FileName);

				string destDir =Server.MapPath("../Doc_DB/doc_norm");
				//Creazione del percorso dove il file va inserito
				
				if (!Directory.Exists(destDir))
					Directory.CreateDirectory(destDir);

				string destPath  =string.Empty; 
				//
//				if (RenameFileName=="")
					destPath  = System.IO.Path.Combine(destDir, fileName);
//				else
//					destPath  = System.IO.Path.Combine(destDir, RenameFileName);

				return File.Exists(destPath);  
	
			}
			else
				return false;
		}

		private string PostFile(string RenameFile)
		{
			  
			try
			{
				string fileName= RenameFile;

				string destDir =Server.MapPath("../Doc_DB/doc_norm");
				

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

		private void btnSalva_Click(object sender, System.EventArgs e)
		{
			

////////////////////////////// gestione file
			///
			string exte=string.Empty; 
			string nomefile=string.Empty;
			//Si tratta di un inserimento
			if (Uploader.PostedFile.FileName!=null && !Uploader.PostedFile.FileName.Equals(""))
			{
				if(LkCons!=null && LkCons.Text!=null && !LkCons.Text.Equals(""))
				{
					string destDir =Server.MapPath("../Doc_DB/doc_norm");
				
					destDir=System.IO.Path.Combine(destDir, LkCons.Text);
					File.Delete(destDir);
				}
nomefile= System.IO.Path.GetFileName(Uploader.PostedFile.FileName);
				exte= System.IO.Path.GetExtension(Uploader.PostedFile.FileName);
				if (this.ExistFile(exte)==true)
				{
					//S_Lblerror.Text="Il file è gia presente impossibile inserire."; 
					//return;
					
					

					DateTime saveNow = DateTime.Now;
					//Console.WriteLine("Today is " + thisDate1.ToString("MMMM dd, yyyy") + ".");
 string dtString = saveNow.ToString( @"ddMMyyyyhhmmss");
					nomefile =  nomefile.Substring(0, nomefile.IndexOf(exte))+"_"+dtString+exte;
				}
			}
			else{
				nomefile=LkCons.Text;
			}

			nomefile=PostFile(nomefile);
			//Posto il file eventuale selezionato
			
////////// Gestione file
			Classi.GestioneCP.DocNormativi DocNorm = new TheSite.Classi.GestioneCP.DocNormativi();
			int i_RowsAffected = 0;
			S_Controls.Collections.S_ControlsCollection _SCollection = new S_Controls.Collections.S_ControlsCollection();
			
			S_Object p_nome_doc = new S_Object();
			p_nome_doc.ParameterName = "p_nome_doc";
			p_nome_doc.DbType = CustomDBType.VarChar;
			p_nome_doc.Direction = ParameterDirection.Input;
			p_nome_doc.Index = i_RowsAffected++;
			p_nome_doc.Size=40;
			p_nome_doc.Value = txtsNomeDoc.Text;
			_SCollection.Add(p_nome_doc);

			S_Object p_desc_doc = new S_Object();
			p_desc_doc.ParameterName = "p_desc_doc";
			p_desc_doc.DbType = CustomDBType.VarChar;
			p_desc_doc.Direction = ParameterDirection.Input;
			p_desc_doc.Index = i_RowsAffected++;
			p_desc_doc.Size=40;
			p_desc_doc.Value = txtsDescDoc.Text;
			_SCollection.Add(p_desc_doc);

			S_Object p_norma_apparenza = new S_Object();
			p_norma_apparenza.ParameterName = "p_norma_apparenza";
			p_norma_apparenza.DbType = CustomDBType.VarChar;
			p_norma_apparenza.Direction = ParameterDirection.Input;
			p_norma_apparenza.Index = i_RowsAffected++;
			p_norma_apparenza.Size=40;
			p_norma_apparenza.Value = txtsNormaApp.Text;
			_SCollection.Add(p_norma_apparenza);

			S_Controls.Collections.S_Object s_p_nomefile = new S_Object();
			s_p_nomefile.ParameterName = "p_nomefile";
			s_p_nomefile.DbType = CustomDBType.VarChar;
			s_p_nomefile.Direction = ParameterDirection.Input;
			s_p_nomefile.Index = i_RowsAffected++;
			s_p_nomefile.Size =50;
			s_p_nomefile.Value = nomefile;
			_SCollection.Add(s_p_nomefile);
			
			S_Controls.Collections.S_Object p_versione_doc = new S_Object();
			p_versione_doc.ParameterName = "p_versione_doc";
			p_versione_doc.DbType = CustomDBType.VarChar;
			p_versione_doc.Direction = ParameterDirection.Input;
			p_versione_doc.Index = i_RowsAffected++;
			p_versione_doc.Size =50;
			p_versione_doc.Value = txtsVersDoc.Text;
			_SCollection.Add(p_versione_doc);
			
			
			if (itemId != 0)
			{
				S_Object id_doc_norm = new S_Object();
				id_doc_norm.ParameterName = "p_id_doc_norm";
				id_doc_norm.DbType = CustomDBType.Integer;
				id_doc_norm.Direction = ParameterDirection.Input;
				id_doc_norm.Index = i_RowsAffected;
				id_doc_norm.Size = 100;
				id_doc_norm.Value = itemId;//Int32.Parse(txtsIdDocNorm.Text);
				_SCollection.Add(id_doc_norm);
			}
			
			try 
			{
				if (itemId != 0)
				{
					itemId=DocNorm.UPD_DOC_NORM(_SCollection);
					Server.Transfer("ric_doc_normativi.aspx");
				}
				else
				{
				    //itemId=1000;
					itemId=DocNorm.INS_DOC_NORM(_SCollection); 
					//string exit=DocNorm.vv(txtsNomeDoc.Text,txtsDescDoc.Text,txtsNormaApp.Text,nomefile,txtsVersDoc.Text);

					Server.Transfer("ric_doc_normativi.aspx");
				}
			}					
			catch (Exception ex)
			{				
				string s_Err =  ex.Message.ToString().ToUpper();
				PanelMess.ShowError(s_Err, true);
			}	
			

		}


		private void btnCancella_Click(object sender, System.EventArgs e)
		{
			if (itemId != 0)
			{	
				Classi.GestioneCP.DocNormativi DocNorm = new TheSite.Classi.GestioneCP.DocNormativi();
				int i_RowsAffected = 0;
				S_Controls.Collections.S_ControlsCollection _SCollection = new S_Controls.Collections.S_ControlsCollection();
				
				S_Object id_doc_norm = new S_Object();
				id_doc_norm.ParameterName = "p_id_doc_norm";
				id_doc_norm.DbType = CustomDBType.Integer;
				id_doc_norm.Direction = ParameterDirection.Input;
				id_doc_norm.Index = i_RowsAffected;
				id_doc_norm.Size = 100;
				id_doc_norm.Value = itemId;//Int32.Parse(txtsIdDocNorm.Text);
				_SCollection.Add(id_doc_norm);

				DataSet _MyDs = DocNorm.DEL_DOC_NORM(_SCollection);

				if (_MyDs.Tables[0].Rows.Count == 1)
				{
					DataRow _Dr = _MyDs.Tables[0].Rows[0];
					string a = _Dr["n_file"].ToString();
					if(Int32.Parse(a) == 1)
					{
						string destDir =Server.MapPath("../Doc_DB/doc_norm");
				
						destDir=System.IO.Path.Combine(destDir, _Dr["file_name"].ToString());
						File.Delete(destDir);
					}
				}
				Server.Transfer("ric_doc_normativi.aspx");
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

			Classi.GestioneCP.DocNormativi DocNorm = new TheSite.Classi.GestioneCP.DocNormativi();
			S_ControlsCollection _SCollection = new S_ControlsCollection();
			int result=0;
		
			S_Object p_id_doc_norm = new S_Object();
			p_id_doc_norm.ParameterName = "p_id_doc_norm";
			p_id_doc_norm.DbType = CustomDBType.Integer;
			p_id_doc_norm.Direction = ParameterDirection.Input;
			p_id_doc_norm.Index = i_RowsAffected;
			p_id_doc_norm.Size = 100;
			p_id_doc_norm.Value = itemId;//Int32.Parse(txtsIdDocNorm.Text);
			_SCollection.Add(p_id_doc_norm);

			result= DocNorm.ExecuteUpdateFile(_SCollection); 

			string destDir =Server.MapPath("../Doc_DB/doc_norm");
			
			destDir=System.IO.Path.Combine(destDir, LkCons.Text);
			File.Delete(destDir);

			LkCons.Visible =false;
			btImgDeleteCons.Visible=false;
		}

		private void btnAnnulla_Click(object sender, System.EventArgs e)
		{
			Server.Transfer("ric_doc_normativi.aspx");
		}
	}


	
}

