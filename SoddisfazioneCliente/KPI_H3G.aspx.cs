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
using System.IO;
using KPIH3G;
using System.Configuration;

using S_Controls;
using S_Controls.Collections;
using ApplicationDataLayer;
using ApplicationDataLayer.DBType;
using MyCollection;

namespace TheSite.SoddisfazioneCliente
{
	/// <summary>
	/// Descrizione di riepilogo per KPI_H3G.
	/// </summary>
	public class KPI_H3G : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.DropDownList drMese3;
		protected System.Web.UI.WebControls.DropDownList drAnno3;
		protected System.Web.UI.WebControls.DropDownList drMese1;
		protected System.Web.UI.WebControls.DropDownList drAnno1;
		protected System.Web.UI.WebControls.DropDownList drMese2;
		protected System.Web.UI.WebControls.DropDownList drAnno2;
		protected System.Web.UI.WebControls.Button bt2;
		protected System.Web.UI.WebControls.Button bt3;
		protected System.Web.UI.WebControls.DropDownList DrMese4;
		protected System.Web.UI.WebControls.DropDownList DrAnno4;
		protected System.Web.UI.WebControls.DropDownList DrEdi;
		protected System.Web.UI.WebControls.Button bt4;
		protected System.Web.UI.WebControls.DropDownList DrProcedura;
		protected System.Web.UI.WebControls.Button bt1;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			// Inserire qui il codice utente necessario per inizializzare la pagina.
			if(!IsPostBack)
				LoadAnni();
		}
		
		private void LoadAnni()
		{
			for(int i=2008;i<=2020;i++)
			{
				drAnno1.Items.Add(new ListItem(i.ToString(),i.ToString()));
				drAnno2.Items.Add(new ListItem(i.ToString(),i.ToString()));
				drAnno3.Items.Add(new ListItem(i.ToString(),i.ToString()));
				DrAnno4.Items.Add(new ListItem(i.ToString(),i.ToString()));
			}
			
			TheSite.Classi.ManProgrammata.InvioDocPmP  _inviodoc = new TheSite.Classi.ManProgrammata.InvioDocPmP();
			DataSet Ds=_inviodoc.GetEdifici(Context.User.Identity.Name);
			DrEdi.DataSource=Ds.Tables[0];
			DrEdi.DataTextField ="Denominazione";
			DrEdi.DataValueField="bl_id"; 
			DrEdi.DataBind();

			DrProcedura.Items.Add(new ListItem("Tutte le RDL","1"));  
			DrProcedura.Items.Add(new ListItem("Rdl per Data e Sede","2"));
			DrProcedura.Items.Add(new ListItem("Rdl con Invio","3"));
			DrProcedura.Items.Add(new ListItem("Rdl con Invio per Data e Sede","4"));
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
			this.bt1.Click += new System.EventHandler(this.bt1_Click);
			this.bt2.Click += new System.EventHandler(this.bt2_Click);
			this.bt3.Click += new System.EventHandler(this.bt3_Click);
			this.bt4.Click += new System.EventHandler(this.bt4_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		
		private void Download(int TipoFile)
		{
			string filename="";
			int Mese;
			int Anno;
			string ConnectionString=ConfigurationSettings.AppSettings["ConnectionString"];
			string FileMaster=Server.MapPath("../MasterExcel");
			string Out =Server.MapPath("../Doc_DB/TempFile"); 
			if(TipoFile==1)
			{
				Mese=int.Parse(drMese1.SelectedValue);
				Anno =int.Parse(drAnno1.SelectedValue);
				FileMaster+=@"\MTempiIntervento.xls";
				TimeRequest t=new TimeRequest(Mese,Anno,ConnectionString,FileMaster,Out);
				filename =t.CreateFile(); 
			}

			if(TipoFile==2)
			{
				Mese=int.Parse(drMese2.SelectedValue);
				Anno =int.Parse(drAnno2.SelectedValue);
				FileMaster+=@"\MTempiPorteREI.xls";
				TempiPorteREI t=new TempiPorteREI(Mese,Anno,ConnectionString,FileMaster,Out);
				filename =t.CreateFile(); 
			}


			if(TipoFile==3)
			{
				Mese=int.Parse(drMese3.SelectedValue);
				Anno =int.Parse(drAnno3.SelectedValue);
				FileMaster+=@"\Requirements.xls";
				PMProgrammata t=new PMProgrammata(Mese,Anno,ConnectionString,FileMaster,Out);
				filename =t.CreateFile(); 
			}

			if(TipoFile==4)
			{
				Csy.WebControls.Export 	_objExport = new Csy.WebControls.Export();
				DataTable _dt = new DataTable();
			    string Procedura="";
				if (DrProcedura.SelectedValue =="1") 
					Procedura="PACK_VerificaSLA.SP_RDL";
				if (DrProcedura.SelectedValue =="2") 
					Procedura="PACK_VerificaSLA.SP_RDL_DATA_BL";
				if (DrProcedura.SelectedValue =="3") 
					Procedura="PACK_VerificaSLA.SP_RDL_CON_INVIO";
				if (DrProcedura.SelectedValue =="4") 
					Procedura="PACK_VerificaSLA.SP_RDL_CON_INVIO_DATA_BL";

				_dt = GetDati(int.Parse(DrProcedura.SelectedValue),Procedura);

				if (_dt.Rows.Count > 0)
				{
					_objExport.ExportDetails(_dt, Csy.WebControls.Export.ExportFormat.Excel, "exp.xls" ); 		
				}else
					return;
			}


			Response.Clear();
			Response.ContentType = "application/xls";
			Response.AddHeader("content-disposition", "attachment; filename=" + Path.GetFileName(filename));	
			Response.WriteFile(filename);
			Response.End();
		}

		private void bt1_Click(object sender, System.EventArgs e)
		{
			Download(1);
		}
		private void bt2_Click(object sender, System.EventArgs e)
		{
			Download(2);
		}

		private void bt3_Click(object sender, System.EventArgs e)
		{
			Download(3);
		}

		private void bt4_Click(object sender, System.EventArgs e)
		{
			Download(4);
		}
		public DataTable GetDati(int Parm, string ProcedureName)
		{
			S_ControlsCollection CollezioneControlli =new S_ControlsCollection();
			if (Parm==1)
			{
				S_Controls.Collections.S_Object p = new S_Object();
				p.ParameterName = "P_ID_PROGETTO";
				p.DbType = CustomDBType.Integer;
				p.Direction = ParameterDirection.Input;
				p.Index = CollezioneControlli.Count;
				p.Value =1;    
				CollezioneControlli.Add(p);

			}

			if (Parm==2 || Parm==4)
			{
				S_Controls.Collections.S_Object p = new S_Object();
				p.ParameterName = "P_ID_PROGETTO";
				p.DbType = CustomDBType.Integer;
				p.Direction = ParameterDirection.Input;
				p.Index = CollezioneControlli.Count;
				p.Value =1;    
				CollezioneControlli.Add(p);

				p = new S_Object();
				p.ParameterName = "P_ANNO";
				p.DbType = CustomDBType.VarChar;
				p.Direction = ParameterDirection.Input;
				p.Index = CollezioneControlli.Count;
				p.Value =DrAnno4.SelectedValue;   
				p.Size = 4;
				CollezioneControlli.Add(p);

				p = new S_Object();
				p.ParameterName = "P_MESE";
				p.DbType = CustomDBType.VarChar;
				p.Direction = ParameterDirection.Input;
				p.Index = CollezioneControlli.Count;
				if(DrMese4.SelectedValue.Length==1)
					p.Value ="0" + DrMese4.SelectedValue;
				else
					p.Value =DrMese4.SelectedValue;
				p.Size = 4;
				CollezioneControlli.Add(p);

				p = new S_Object();
				p.ParameterName = "P_COD_SEDE";
				p.DbType = CustomDBType.VarChar;
				p.Direction = ParameterDirection.Input;
				p.Index = CollezioneControlli.Count;
				p.Value =DrEdi.SelectedValue;   
				p.Size = 10;
				CollezioneControlli.Add(p);

			}


			if (Parm==3)
			{
				S_Controls.Collections.S_Object p = new S_Object();
				p.ParameterName = "P_ID_PROGETTO";
				p.DbType = CustomDBType.Integer;
				p.Direction = ParameterDirection.Input;
				p.Index = CollezioneControlli.Count;
				p.Value =1;    
				CollezioneControlli.Add(p);

			}


			S_Controls.Collections.S_Object s_IdOut = new S_Object();
			s_IdOut.ParameterName = "IO_CURSOR";
			s_IdOut.DbType = CustomDBType.Cursor;
			s_IdOut.Direction = ParameterDirection.Output;
			s_IdOut.Index = CollezioneControlli.Count;
			CollezioneControlli.Add(s_IdOut);

			ApplicationDataLayer.OracleDataLayer _OraDl = new OracleDataLayer( System.Configuration.ConfigurationSettings.AppSettings["ConnectionString"]);
			
			DataSet _Ds =  _OraDl.GetRows(CollezioneControlli, ProcedureName);
			return _Ds.Tables[0];
		}

	
	}
}
