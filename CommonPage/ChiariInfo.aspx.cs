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
using S_Controls;
using S_Controls.Collections;
using ApplicationDataLayer;
using ApplicationDataLayer.DBType; 

namespace TheSite.CommonPage
{
	/// <summary>
	/// Descrizione di riepilogo per ChiariInfo.
	/// </summary>
	public class ChiariInfo : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.HyperLink HyperLink1;
		protected S_Controls.S_TextBox txtsMotivo;
		protected System.Web.UI.WebControls.Panel PanelEdit;
		//protected S_Controls.S_Button btnsAggiungi;
		protected System.Web.UI.WebControls.HyperLink Hyperlink2;
		protected S_Controls.S_Button btnsAggiungi;
		protected System.Web.UI.WebControls.Label lbloperazione;
		protected WebControls.RichiedentiSollecito RichiedentiSollecito1;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			lbloperazione.Text="";
			this.idric = Request.QueryString["idric"]; 
			this.btnsAggiungi.Attributes.Add("onclick","return ControllaRichiedente('" +  RichiedentiSollecito1.s_RichNome.ClientID + "','" + RichiedentiSollecito1.s_RichCognome.ClientID + "')");
			//this.btnsAggiungi.Attributes.Add("onclick","return ControllaRichiedente('" +  RichiedentiSollecito1.s_RichNome.ClientID + "','" + RichiedentiSollecito1.s_RichCognome.ClientID + "')");
				
			if(Request.QueryString["VarApp"]!=null)
				RichiedentiSollecito1.Progetto=	Request.QueryString["VarApp"];
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
			this.btnsAggiungi.Click += new System.EventHandler(this.btnsAggiungi_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private string idric
		{
			get {return (String) ViewState["s_Idric"];}
			set {ViewState["s_Idric"] = value;}
		}

		
		
		private void btnsAggiungi_Click(object sender, System.EventArgs e)
		{
			this.txtsMotivo.DBDefaultValue = DBNull.Value;

			this.txtsMotivo.Text = this.txtsMotivo.Text.Trim();

			int i_RowsAffected = 0;

			if (RichiedentiSollecito1.s_RichID.Text!="" && txtsMotivo.Text!="" )
			{

				S_Controls.Collections.S_ControlsCollection _SCollection = new S_Controls.Collections.S_ControlsCollection();

				S_Controls.Collections.S_Object s_p_ID_RICHIEDENTE =new S_Controls.Collections.S_Object();
				s_p_ID_RICHIEDENTE.ParameterName="p_ID_RICHIEDENTE";
				s_p_ID_RICHIEDENTE.DbType=CustomDBType.Integer;
				s_p_ID_RICHIEDENTE.Direction=ParameterDirection.Input;
				s_p_ID_RICHIEDENTE.Index=_SCollection.Count;
				s_p_ID_RICHIEDENTE.Size=10;
				s_p_ID_RICHIEDENTE.Value=Int32.Parse(RichiedentiSollecito1.s_RichID.Text);

				_SCollection.Add(s_p_ID_RICHIEDENTE);

				S_Controls.Collections.S_Object s_p_NomeCompleto =new S_Controls.Collections.S_Object();
				s_p_NomeCompleto.ParameterName="p_NomeCompleto";
				s_p_NomeCompleto.DbType=CustomDBType.VarChar;
				s_p_NomeCompleto.Direction=ParameterDirection.Input;
				s_p_NomeCompleto.Index=_SCollection.Count;
				s_p_NomeCompleto.Size=50;
				s_p_NomeCompleto.Value=RichiedentiSollecito1.NomeCompleto.ToString();

				_SCollection.Add(s_p_NomeCompleto);



				S_Controls.Collections.S_Object s_p_CognomeCompleto =new S_Controls.Collections.S_Object();
				s_p_CognomeCompleto.ParameterName="p_CognomeCompleto";
				s_p_CognomeCompleto.DbType=CustomDBType.VarChar;
				s_p_CognomeCompleto.Direction=ParameterDirection.Input;
				s_p_CognomeCompleto.Index=_SCollection.Count;
				s_p_CognomeCompleto.Size=50;
				s_p_CognomeCompleto.Value=RichiedentiSollecito1.CognomeCompleto.ToString();

				_SCollection.Add(s_p_CognomeCompleto);

				S_Controls.Collections.S_Object s_p_phone =new S_Controls.Collections.S_Object();
				s_p_phone.ParameterName="p_phone";
				s_p_phone.DbType=CustomDBType.VarChar;
				s_p_phone.Direction=ParameterDirection.Input;
				s_p_phone.Index=_SCollection.Count;
				s_p_phone.Size=50;
				s_p_phone.Value=RichiedentiSollecito1.telefono.ToString();
				_SCollection.Add(s_p_phone);					
					
				S_Controls.Collections.S_Object s_p_email =new S_Controls.Collections.S_Object();
				s_p_email.ParameterName="p_email";
				s_p_email.DbType=CustomDBType.VarChar;
				s_p_email.Direction=ParameterDirection.Input;
				s_p_email.Index=_SCollection.Count;
				s_p_email.Size=50;
				s_p_email.Value=RichiedentiSollecito1.email.ToString();
				_SCollection.Add(s_p_email);

				
				S_Controls.Collections.S_Object s_p_stanza =new S_Controls.Collections.S_Object();
				s_p_stanza.ParameterName="p_stanza";
				s_p_stanza.DbType=CustomDBType.VarChar;
				s_p_stanza.Direction=ParameterDirection.Input;
				s_p_stanza.Index=_SCollection.Count;
				s_p_stanza.Size=50;
				s_p_stanza.Value=RichiedentiSollecito1.stanza.ToString();

				_SCollection.Add(s_p_stanza);



				S_Controls.Collections.S_Object s_p_Gruppo =new S_Controls.Collections.S_Object();
				s_p_Gruppo.ParameterName="p_ID_Gruppo";
				s_p_Gruppo.DbType=CustomDBType.Integer;
				s_p_Gruppo.Direction=ParameterDirection.Input;
				s_p_Gruppo.Index=_SCollection.Count;
				s_p_Gruppo.Size=50;
				s_p_Gruppo.Value=Convert.ToInt32(RichiedentiSollecito1.IdGruppo);

				_SCollection.Add(s_p_Gruppo);



				S_Controls.Collections.S_Object s_p_Motivo =new S_Controls.Collections.S_Object();
				s_p_Motivo.ParameterName="p_Motivo";
				s_p_Motivo.DbType=CustomDBType.VarChar;
				s_p_Motivo.Direction=ParameterDirection.Input;
				s_p_Motivo.Index=_SCollection.Count;
				s_p_Motivo.Size=50;
				s_p_Motivo.Value=txtsMotivo.Text;

				_SCollection.Add(s_p_Motivo);


				Classi.ManOrdinaria.ChiariInfo _ChiariInfo = new TheSite.Classi.ManOrdinaria.ChiariInfo();

				i_RowsAffected = _ChiariInfo.ExecuteAddChiariInfo(_SCollection,int.Parse(this.idric));

				string jscript = "<script language=JavaScript>\n";
				jscript +="var oVDiv=parent.document.getElementById('PopupAddChiariInfo').style;\n";
				jscript += "oVDiv.display = 'none';";
				jscript += "<";
				jscript += "/";
				jscript += "script>";

				if(!this.IsStartupScriptRegistered("clientScriptChiudi"))
					this.RegisterStartupScript("clientScriptChiudi", jscript);
				lbloperazione.Text="Richiesta Chiarimento inserita";

			}
			else
			{
				lbloperazione.Text="Inserire richiedente e richiesta di Chiarimento";
				return;}

			//xx
		}

		
		}
	}

