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
using System.Reflection; 
using System.IO;

namespace TheSite.AnagrafeImpianti
{
	/// <summary>
	/// Descrizione di riepilogo per SfogliaRdlOdl_MP1.
	/// </summary>
	public class SfogliaODLRDLM : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Button Button1;
		protected System.Web.UI.WebControls.DataGrid DataGrid2;
		protected WebControls.CalendarPicker CalendarPicker1;
		protected WebControls.CalendarPicker CalendarPicker2;
		protected WebControls.GridTitle GridTitle1;
		protected System.Web.UI.WebControls.Button Button2;	
		protected WebControls.PageTitle PageTitle1;
		protected System.Web.UI.HtmlControls.HtmlInputHidden HPageBack;
		protected System.Web.UI.WebControls.Label S_lblcodicecomponente;
		protected System.Web.UI.WebControls.Label S_lblstdapparecchiature;
		protected System.Web.UI.WebControls.Label S_lbledificio;
		protected System.Web.UI.WebControls.Label S_lblcodiceedificio;
		public string v_eq_id;



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
			// Inserire qui il codice utente necessario per inizializzare la pagina.
			
			PageTitle1.Title="RdL apparato ";
			if( Context.Items["eq_id_char"]!=null 
				)
			{
				PageTitle1.Title="RdL apparato "+ 
					Context.Items["eq_id_char"].ToString();
			}
				  ;
			if( Request["eq_id_char"]!=null 
				)
			{
				PageTitle1.Title="RdL apparato "+ 
					Request["eq_id_char"].ToString();
			}

			if(Request["FromWebCad"] != null)
			{
				//BtnHidden = "style=\"visibility: hidden\"";
				PageTitle1.VisibleLogut = false;
				Button2.Visible=false;
			}


			if(!IsPostBack)
			{
				#region Recupero la proprieta di ricerca
				// Recupero il tipo dall'oggetto context.
				Type myType=Context.Handler.GetType();       
				// recupero il PropertyInfo object passando il nome della proprietà da recuperare.
				PropertyInfo myPropInfo = myType.GetProperty("_Contenitore");
			
				// verifico che questa proprietà esista.
				if(myPropInfo!=null)
					this.ViewState.Add("mioContenitore",myPropInfo.GetValue(Context.Handler,null));

				#endregion
				string pagebak=((System.Web.HttpRequest)(((System.Web.UI.Page)((this.Page))).Request)).FilePath;
				HPageBack.Value= pagebak.Substring(pagebak.LastIndexOf("/")+1);			
				//Button2.Attributes.Add("onclick","javascript:history.back();");
				
				if (Context.Items["eq_id_char"]!=null ||Request.QueryString["eq_id_char"]!=null)
				{
				    
					this.eq_id=(string)Context.Items["eq_id_char"];
					if (eq_id.ToString()==string.Empty)
						this.eq_id=(string)Request.QueryString["eq_id_char"];
				    v_eq_id=eq_id;
					execute();
					CaricaScheda();
				}
			}
		}
		private string  eq_id
		{
			get 
			{ 
				if(this.ViewState["eq_id"]!=null)
					return (string)ViewState["eq_id"];
				else 
					return string.Empty;
			}
			set{ViewState.Add("eq_id",value);}
		}
		
		
		private void CaricaScheda()
		{
			S_Controls.Collections.S_ControlsCollection CollezioneControlli = new  S_Controls.Collections.S_ControlsCollection();
			
			S_Controls.Collections.S_Object s_p_eq_std = new S_Controls.Collections.S_Object();
			s_p_eq_std.ParameterName = "p_eq_std";
			s_p_eq_std.DbType = CustomDBType.VarChar;
			s_p_eq_std.Direction = ParameterDirection.Input;
			s_p_eq_std.Index = 0;
			s_p_eq_std.Value = eq_id;			
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
				this.eq_id = Ds.Tables[0].Rows[0][0].ToString();
			}
			else
			{
				S_lblcodicecomponente.Text="";
				S_lblstdapparecchiature.Text="";
				S_lblcodiceedificio.Text="";
				S_lbledificio.Text="";			
			}
		}
		
		private void execute()
		{

			
			TheSite.Classi.ManProgrammata.SfogliaRdlOdl _SfogliaRdlOdl=new TheSite.Classi.ManProgrammata.SfogliaRdlOdl(Context.User.Identity.Name);
			
			DataSet _Ds = _SfogliaRdlOdl.GetDettailSingleRdl1MAN(v_eq_id);			
												
			if (_Ds.Tables[0].Rows.Count>0)
			{
				GridTitle1.Visible =true;
				GridTitle1.hplsNuovo.Visible=false;
				GridTitle1.NumeroRecords= _Ds.Tables[0].Rows.Count.ToString();  
				this.DataGrid2.DataSource = _Ds.Tables[0];
				this.DataGrid2.DataBind();
				DataGrid2.Visible=true;
			}
			else
			{
				GridTitle1.Visible =false;
				DataGrid2.Visible=false;
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
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.Button2.Click += new System.EventHandler(this.Button2_Click);
			this.DataGrid2.ItemCommand += new System.Web.UI.WebControls.DataGridCommandEventHandler(this.DataGrid2_ItemCommand);
			this.DataGrid2.PageIndexChanged += new System.Web.UI.WebControls.DataGridPageChangedEventHandler(this.DataGrid2_PageIndexChanged);
			this.DataGrid2.ItemDataBound += new System.Web.UI.WebControls.DataGridItemEventHandler(this.DataGrid2_ItemDataBound);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void DataGrid2_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			///Imposto la Nuova Pagina
			DataGrid2.CurrentPageIndex=e.NewPageIndex;
			ricercadate();;
		}

	

		private void DataGrid2_ItemCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
		{
			if (e.CommandName=="Download")
			{	
				
				if (e.Item.Cells[11].Text=="2")
				{
					//if (e.CommandArgument.ToString()==""||e.CommandArgument.ToString()==string.Empty)
					//	return;
				
					 string PathDir=Server.MapPath("../DOC_DB");
					 string DestPath=PathDir;
					 string FileName=DestPath + @"\" + e.Item.Cells[11].Text;
					Response.Clear();
					Response.ContentType = "application/xls";
					Response.AddHeader("content-disposition", "inline; filename=" + Path.GetFileName(FileName));	   
					Response.WriteFile(FileName);
			
				}
				else
				{
					string PathDir1=Server.MapPath("../DOC_DB");
					string DestPath1=PathDir1;	
					string FileName1=DestPath1 + @"\" + e.Item.Cells[11].Text;
					Response.Clear();
					Response.ContentType = "application/xls";
					Response.AddHeader("content-disposition", "inline; filename=" + Path.GetFileName(FileName1));	   
					Response.WriteFile(FileName1);
			
				}
			}


		}

		private void DataGrid2_ItemDataBound(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
		{
		
			if( e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem )
			{
				//Label lbl=new Label();
				
				System.Web.UI.WebControls.ImageButton lk  = (ImageButton)  e.Item.Cells[9].FindControl("btScarica");
				if (DataBinder.Eval(e.Item.DataItem, "filename")!=System.DBNull.Value) 
				{					
					lk.Visible = true;
				}
				else
				{
					lk.Visible = false;
				}

			}
		}

		private void Button1_Click(object sender, System.EventArgs e)
		{
		ricercadate();
		}
		
		private void ricercadate()
		{
			TheSite.Classi.ManProgrammata.SfogliaRdlOdl _SfogliaRdlOdl=new TheSite.Classi.ManProgrammata.SfogliaRdlOdl(Context.User.Identity.Name);
			
			DataSet _Ds = _SfogliaRdlOdl.GetDettailSingleRdl1MANDATE(eq_id,CalendarPicker1.Datazione.Text, CalendarPicker2.Datazione.Text);			
												
			if (_Ds.Tables[0].Rows.Count>0)
			{
				GridTitle1.Visible =true;
				GridTitle1.hplsNuovo.Visible=false;
				GridTitle1.NumeroRecords= _Ds.Tables[0].Rows.Count.ToString();  
				this.DataGrid2.DataSource = _Ds.Tables[0];
				this.DataGrid2.DataBind();
				DataGrid2.Visible=true;
			}
			else
			{
				GridTitle1.Visible =false;
				DataGrid2.Visible=false;
			}
		
		}


		private void Button2_Click(object sender, System.EventArgs e)
		{
			Server.Transfer(HPageBack.Value);

		}
		
	}
}

