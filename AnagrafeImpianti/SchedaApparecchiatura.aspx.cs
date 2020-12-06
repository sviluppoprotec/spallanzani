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
using TheSite.Classi.ClassiDettaglio;  
using S_Controls;
using S_Controls.Collections;
using ApplicationDataLayer.DBType; 
using System.Xml;
using System.IO;


 
using ApplicationDataLayer;
 

namespace TheSite.CommonPage
{
	/// <summary>
	/// Descrizione di riepilogo per SchedaApparecchiatura.
	/// </summary>
	public class SchedaApparecchiatura : System.Web.UI.Page
	{
		protected S_Controls.S_Label S_lblcodicecomponente;
		protected S_Controls.S_Label S_lblstdapparecchiature;
		protected S_Controls.S_Label S_lblcodiceedificio;
		protected S_Controls.S_Label S_lbledificio;
		protected S_Controls.S_Label S_lblpiano;
		protected S_Controls.S_Label S_lbltecnico;
		protected S_Controls.S_Label S_lblmarca;
		protected S_Controls.S_Label S_lblmodello;
		protected S_Controls.S_Label S_lbltipo;
		
		protected S_Controls.S_Label S_COD_CUT;
		protected S_Controls.S_Label S_DESC_CUT;
		protected S_Controls.S_Label S_COD_UT;
		protected S_Controls.S_Label S_DESC_UT;
		protected S_Controls.S_Label S_COD_CET;
		protected S_Controls.S_Label S_DESC_CET;
		protected S_Controls.S_Label S_PRG_UNI;
		protected System.Web.UI.WebControls.Panel Panel1;
		protected System.Web.UI.WebControls.DataList DataList1;
		protected Csy.WebControls.DataPanel DataPanelPassi;
		protected System.Web.UI.WebControls.DataList Datalist2;
		protected Csy.WebControls.DataPanel DataPanel1;
		protected Csy.WebControls.DataPanel DataPanelCaratteristiche;
		protected WebControls.PageTitle PageTitle1;
		protected Csy.WebControls.DataPanel DatapanelUNI;

		public string Imagename="eq_image=";

		public static int FunId = 0;
		protected S_Controls.S_Button btnsRichieste;
		protected S_Controls.S_Label S_lblstanza;
		protected S_Controls.S_Label S_lblqta;		
		public static string HelpLink = string.Empty;
		protected S_Controls.S_Label S_LblStato;
		//protected System.Web.UI.WebControls.HyperLink HyperLink1;  //stanza
		//protected System.Web.UI.WebControls.HyperLink HyperLink2;
		protected System.Web.UI.WebControls.Literal LiteralScriptAttivita;
		protected System.Web.UI.WebControls.Literal LiteralScriptDocumenti;
		protected System.Web.UI.WebControls.Literal LiteralScriptPiano; 
		protected System.Web.UI.WebControls.Literal LiteralScriptStanza; 
		int IDEQ=0;
		public string v_id_bl= string.Empty;
		public string v_id_fl= string.Empty;
		public string v_id_rm= string.Empty;
		protected System.Web.UI.WebControls.Repeater repetarpassi;

		private void Page_Load(object sender, System.EventArgs e)
		{
			Classi.SiteModule _SiteModule = (Classi.SiteModule) HttpContext.Current.Items["SiteModule"];

			FunId = _SiteModule.ModuleId;
			HelpLink = _SiteModule.HelpLink;
			this.PageTitle1.Title = _SiteModule.ModuleTitle;
			// Inserire qui il codice utente necessario per inizializzare la pagina.
			if(!IsPostBack)
			{
				if (Context.Items["eq_id"]!=null)
					this.eq_id =(string)Context.Items["eq_id"];

				if (Request.QueryString["eq_id"]!=null)
				{
					this.eq_id =(string)Request.QueryString["eq_id"];
					this.PageTitle1.Visible =false;
				}
				Execute();
			}
			System.Text.StringBuilder Strbuild=new System.Text.StringBuilder();
			Strbuild.Append("\r\n<s" + "cript type=\"text/javascript\">");
			Strbuild.Append("function hideControl(c,c2){");
			Strbuild.Append("var ctrl = document.getElementById(c).style;\n");
			Strbuild.Append("if(ctrl.display=='none')\n");
			Strbuild.Append("{	ctrl.display ='block';\n");
			Strbuild.Append("	document.getElementById(c2).src='../Images/downarrows_trans.gif';\n");
			Strbuild.Append("}else{	\n");
			Strbuild.Append("	ctrl.display ='none';\n");
			Strbuild.Append("	document.getElementById(c2).src='../Images/uparrows_trans.gif';\n");
			Strbuild.Append("}\n");
			Strbuild.Append("}\n");
			Strbuild.Append("</s" + "cript>");

			this.RegisterClientScriptBlock ("exmpandi",Strbuild.ToString());
			//	this.RegisterClientScriptBlock ("exmpandi","\r\n<s" + "cript type=\"text/javascript\">function hideControl(c){var ctrl = document.getElementById(c).style; ctrl.display = (ctrl.display == 'none')?'block':'none'; }</s" + "cript>");
			//  -----   trasferisci script sulle litteral 
			//	<P><asp:literal id="LitDWFInter" Runat="server"></asp:literal></P>		
//			string BotAttivita="<INPUT style=\"Z-INDEX: 0\" value=\"VisualizzaScheda\" type=\"button\" onclick=\"cmbSelezione(1)\">";
//			BottoniDWF=BottoniDWF +"\n";
//			BottoniDWF=BottoniDWF + "<INPUT style=\"Z-INDEX: 0\" value=\"VisualizzaAttivita\" type=\"button\" onclick=\"cmbSelezione(2)\">";
//			BottoniDWF=BottoniDWF +"\n";
//			BottoniDWF=BottoniDWF + "<INPUT style=\"Z-INDEX: 0\" value=\"VisualizzaDocumenti\" type=\"button\" onclick=\"cmbSelezione(3)\">";
//			BottoniDWF=BottoniDWF +"\n";
			//  BottoniDWF=BottoniDWF + "<INPUT style=\"Z-INDEX: 0\" value=\"ImpostaApparato\" type=\"button\" onclick=\"SetApparato('GRF022')\">";
			//BottoniDWF=BottoniDWF +"\n";

	//   Anchor.HRef="javascript:hideControl('" + iddiv + "','" + img.ClientID + "');"; 
   ///   <a id="vattivita" name="vattivita" onclick=":javascript:cmbSelezione(2,'"+this.eq_id +"');">VisualizzaAttivita</a>
			//string BotAttivita="<INPUT style=\"Z-INDEX: 0\" value=\"VisualizzaAttivita\" type=\"button\" onclick=\"cmbSelezione(2,'"+this.eq_id +"')\">";
			string BotAttivita="<a id=\"vattivita\" name=\"vattivita\" onclick=\"javascript:cmbSelezione(2,'"+this.eq_id +"');\">Apri</a>";
		
			LiteralScriptAttivita.Text=BotAttivita;

			string BotDocumenti="<a id=\"vdoc\" name=\"vdoc\" onclick=\"javascript:cmbSelezione(3,'"+this.eq_id +"');\">Apri</a>";
			
			LiteralScriptDocumenti.Text=BotDocumenti;

			string BotPiano="<a id=\"vpiano\" name=\"vpiano\" onclick=\"javascript:fpiano('"+this.v_id_bl+"','"+this.v_id_fl +"','"+this.v_id_rm +"');\">Apri</a>";
			LiteralScriptPiano.Text=BotPiano;
			
			string BotStanza="<a id=\"vstanza\" name=\"vstanza\" onclick=\"javascript:SetStanza('"+this.v_id_bl+"','"+this.v_id_fl +"','"+this.v_id_rm +"');\">Apri</a>";
																									
			LiteralScriptStanza.Text=BotStanza;


		}

		#region proprietà

		private string eq_id
		{
			get 
			{
				if(ViewState["s_eq_id"]==null)
					 return string.Empty;
				 else
					 return (String) ViewState["s_eq_id"];
			}
			set 
			{
				if (value==null)
					ViewState["s_eq_id"] = string.Empty;
				else
					ViewState["s_eq_id"] = value;
			}
		}

		#endregion

		private void Execute()
		{
			S_Controls.Collections.S_ControlsCollection CollezioneControlli = new  S_Controls.Collections.S_ControlsCollection();
			
			S_Controls.Collections.S_Object s_p_eq_std = new S_Controls.Collections.S_Object();
			s_p_eq_std.ParameterName = "p_eq_std";
			s_p_eq_std.DbType = CustomDBType.VarChar;
			s_p_eq_std.Direction = ParameterDirection.Input;
			s_p_eq_std.Index = 0;
			s_p_eq_std.Value = this.eq_id;			
			s_p_eq_std.Size = 50;
			CollezioneControlli.Add(s_p_eq_std);

			Classi.ClassiDettaglio.SchedaApparecchiatura  _SchedaApparecchiatura =new Classi.ClassiDettaglio.SchedaApparecchiatura(""); 

			DataSet Ds = _SchedaApparecchiatura.GetData(CollezioneControlli);
			if (Ds.Tables[0].Rows.Count>0)
			{
				S_lblcodicecomponente.Text=Ds.Tables[0].Rows[0]["var_eq_eq_id"].ToString();
				S_lblstdapparecchiature.Text=Ds.Tables[0].Rows[0]["var_eqstd_description"].ToString();
				S_lblcodiceedificio.Text=Ds.Tables[0].Rows[0]["var_eq_bl_id"].ToString();
				S_lbledificio.Text=Ds.Tables[0].Rows[0]["var_bl_name"].ToString();
				S_lblpiano.Text=Ds.Tables[0].Rows[0]["var_eq_fl_id"].ToString();
				v_id_bl= Ds.Tables[0].Rows[0]["var_id_bl"].ToString();
				v_id_fl= Ds.Tables[0].Rows[0]["var_id_fl"].ToString();
				v_id_rm= Ds.Tables[0].Rows[0]["var_id_rm"].ToString();

				try
				{
					S_lblstanza.Text=Ds.Tables[0].Rows[0]["stanza"].ToString();
                    string nUrl = @"../AnagrafeImpianti/DataRoom.aspx?id_edificio_cad=202&id_piano_cad=41&var_stanza=94193&FromWebCad=true";
					nUrl=@"../AnagrafeImpianti/navigazioneappdemo.aspx?FunId=1&var_bl_id=202&var_piani=41&var_stanza=94191&TitoloStanza=ScedaDettaglioStanza&FromWebCad=true";

					string idRM_new = GetidRM(this.eq_id);
					nUrl = nUrl.Replace("94191",idRM_new.ToString());
					nUrl = "javascript:SetStanza('RM008','RM008','RM008')";
					nUrl = string.Format("javascript:SetStanza('PU004A','PTE','{0}')",Ds.Tables[0].Rows[0][14].ToString());
                    //HyperLink1.NavigateUrl=nUrl;

					S_lblqta.Text=Ds.Tables[0].Rows[0]["quantita"].ToString();
					S_LblStato.Text=Ds.Tables[0].Rows[0]["var_eq_condition"].ToString();
				}
				catch(Exception ex)
				{Response.Write(ex.Message);}
				S_lbltecnico.Text=Ds.Tables[0].Rows[0]["var_sottocomponente"].ToString();
				S_lblmarca.Text=Ds.Tables[0].Rows[0]["var_vn_id"].ToString();
				S_lblmodello.Text=Ds.Tables[0].Rows[0]["var_eq_option1"].ToString();
				S_lbltipo.Text=Ds.Tables[0].Rows[0]["var_eq_option2"].ToString();
				
				S_COD_CUT.Text=Ds.Tables[0].Rows[0]["var_COD_CUT"].ToString();
				S_DESC_CUT.Text=Ds.Tables[0].Rows[0]["var_DESC_CUT"].ToString();
				S_COD_UT.Text=Ds.Tables[0].Rows[0]["var_COD_UT"].ToString();
				S_DESC_UT.Text=Ds.Tables[0].Rows[0]["var_DESC_UT"].ToString();
				S_COD_CET.Text=Ds.Tables[0].Rows[0]["var_COD_CET"].ToString();
				S_DESC_CET.Text=Ds.Tables[0].Rows[0]["var_DESC_CET"].ToString();
				S_PRG_UNI.Text=Ds.Tables[0].Rows[0]["var_PRG_UNI"].ToString();


				
				//nome del file imagine
				Imagename+=Ds.Tables[0].Rows[0]["var_eq_image_eq_assy"].ToString();
				BindAttivita(Ds.Tables[0].Rows[0]["var_eqstd_id"].ToString());


				//Dati tecnici
				Classi.ClassiDettaglio.DatiTecniciApparecchiatura  _DatiTecniciApparecchiatura=new Classi.ClassiDettaglio.DatiTecniciApparecchiatura(Context.User.Identity.Name);
				DataSet _DsTemp;
				//Da Cambiare 
				IDEQ=Convert.ToInt32(Ds.Tables[0].Rows[0]["var_eq_id"]);
				_DsTemp =_DatiTecniciApparecchiatura.GetSingleDatitecnici(IDEQ);
		
				if(_DsTemp.Tables[0].Rows.Count>0)
				{
					//DescrizioniTecniche((string)Ds.Tables[0].Rows[0]["var_eq_comments"]); 
					DataList1.DataSource=_DsTemp;
					DataList1.DataBind();
				}
				else
					DataPanelCaratteristiche.TitleText="Nessuna Caratteristica Tecnica";


			}
			else
			{
				S_lblcodicecomponente.Text="";
				S_lblstdapparecchiature.Text="";
				S_lblcodiceedificio.Text="";
				S_lbledificio.Text="";
				S_lblpiano.Text="";
				S_lbltecnico.Text="";
				S_lblmarca.Text="";
				S_lblmodello.Text="";
				S_lbltipo.Text="";
				//HyperLink1.NavigateUrl="javascript:alert('Nessuna Stanza Selezionata')";
			}
		}

		private void DescrizioniTecniche(string Description)
		{
			try
			{
				DataSet _Ds=new DataSet();
				StringReader stream; 
				XmlTextReader reader = null;
				stream=new StringReader(Description);
				reader = new XmlTextReader(stream);
				_Ds.ReadXml(reader,XmlReadMode.Auto);
				DataList1.DataSource=_Ds;
				DataList1.DataBind();
					
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
		private void BindAttivita(string eqstd_id)
		{
		 
			S_Controls.Collections.S_ControlsCollection CollezioneControlli = new  S_Controls.Collections.S_ControlsCollection();
			
			S_Controls.Collections.S_Object s_p_eqstd_id = new S_Controls.Collections.S_Object();
			s_p_eqstd_id.ParameterName = "p_eqstd_id";
			s_p_eqstd_id.DbType = CustomDBType.Integer;
			s_p_eqstd_id.Direction = ParameterDirection.Input;
			s_p_eqstd_id.Index = 0;
			s_p_eqstd_id.Value = Int32.Parse(eqstd_id);			
			CollezioneControlli.Add(s_p_eqstd_id);

			Classi.AnagrafeImpianti.Passi  _Passi =new Classi.AnagrafeImpianti.Passi(""); 

			DataSet Ds = _Passi.GetData(CollezioneControlli);
			Datalist2.DataSource=Ds;
			Datalist2.DataBind(); 
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
			this.Datalist2.ItemDataBound += new System.Web.UI.WebControls.DataListItemEventHandler(this.Datalist2_ItemDataBound);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void Datalist2_ItemDataBound(object sender, System.Web.UI.WebControls.DataListItemEventArgs e)
		{
			if ((e.Item.ItemType== ListItemType.Item) || (e.Item.ItemType==ListItemType.AlternatingItem) ||
				(e.Item.ItemType==ListItemType.EditItem))
			{

				string iddiv=((HtmlGenericControl)e.Item.Controls[15]).ClientID;
				HtmlAnchor  Anchor=(HtmlAnchor)e.Item.Controls[1];
				LiteralControl img =(LiteralControl)e.Item.Controls[1].Controls[0];
				Anchor.HRef="javascript:hideControl('" + iddiv + "','" + img.ClientID + "');"; 

				Repeater repeta =(Repeater)e.Item.FindControl("repetarpassi");
				repeta.DataSource=BindingPassi(Datalist2.DataKeys[e.Item.ItemIndex].ToString());
				repeta.DataBind();
			    
			}
		}

		private DataSet BindingPassi(string id)
		{
			Classi.AnagrafeImpianti.Passi  _Passi =new Classi.AnagrafeImpianti.Passi(""); 
			return _Passi.GetSingleData(Int32.Parse(id));
		}

		private void btnsRichieste_Click(object sender, System.EventArgs e)
		{
			Response.Redirect("RichiesteApparecchiatura.aspx?FunId="+FunId);
		}

		
		private string GetidRM(string eq_id_str)
		{
			 string s_ConnStr = System.Configuration.ConfigurationSettings.AppSettings["ConnectionString"];
			//= 'SCA062' 
			string sql = "select eq.id_rm FROM eq where eq.eq_id in ('" + eq_id_str + "')";
			S_ControlsCollection _SCollection = new S_ControlsCollection();			
		
			S_Controls.Collections.S_Object s_p_sql = new S_Controls.Collections.S_Object();
			s_p_sql.ParameterName = "p_sql";
			s_p_sql.DbType = ApplicationDataLayer.DBType.CustomDBType.VarChar;
			s_p_sql.Direction = ParameterDirection.Input;
			s_p_sql.Size =2000;
			s_p_sql.Index = 0;
			s_p_sql.Value = sql;
			_SCollection.Add(s_p_sql);

			S_Controls.Collections.S_Object s_Cursor = new S_Object();
			s_Cursor.ParameterName = "IO_CURSOR";
			s_Cursor.DbType = CustomDBType.Cursor;
			s_Cursor.Direction = ParameterDirection.Output;
			s_Cursor.Index = 1;

			_SCollection.Add(s_Cursor);

			
			DataSet _Ds;											

			ApplicationDataLayer.OracleDataLayer _OraDl = new OracleDataLayer(s_ConnStr);
			string s_StrSql = "PACK_COMMON.SP_DYNAMIC_SELECT";	
			_Ds = _OraDl.GetRows(_SCollection, s_StrSql).Copy();		
		
			string idstanza = _Ds.Tables[0].Rows[0][0].ToString();
			return idstanza;
		}


	}
}
