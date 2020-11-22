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

namespace TheSite.ManutenzioneProgrammata
{
	/// <summary>
	/// Descrizione di riepilogo per Completa_WO.
	/// </summary>
	public class Completa_WO1 : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Repeater RepeaterMaster;
		protected WebControls.PageTitle PageTitle1;
		public int rr=0;

	    int addetto_id=0;
		string Data=null;
		string Data1=null;
		string Dataip=null;
		string Datafp=null;
		string Wo=null;
		string addettoWR=null;

		private void Page_Load(object sender, System.EventArgs e)
		{
			Response.Expires = -1;
			Response.Cache.SetNoStore();

			PageTitle1.VisibleLogut=false; 
			if(!IsPostBack)
			{
				if(Request.QueryString["addetto"]!=null)
				{
					addetto_id=Convert.ToInt32( Request.QueryString["addetto"]);
					Data=Request.QueryString["data"];
					Data1=Request.QueryString["data1"];
					Dataip=Request.QueryString["dataip"];
					Datafp=Request.QueryString["datafp"];

					BindingMaster();
				}
				else
				{
					Wo=Request.QueryString["wo"];
					Data=Request.QueryString["data"];
					Data1=Request.QueryString["data1"];
					Dataip=Request.QueryString["dataip"];
					Datafp=Request.QueryString["datafp"];
					addettoWR=Request.QueryString["addettoWR"];
					BindingMasterSingle();
				}

				string mes = "<script language=\"javascript\">\n";			
				mes += "opener.refreshgriglia();";
				mes += "</script>\n";

				this.Page.RegisterStartupScript("agg",mes);
			}

		}

		private void BindingMaster()
		{
			if(Session["CheckedListMP"]!=null)
			{
				Hashtable _HS = (Hashtable)Session["CheckedListMP"];
					_HS=RemoveHash(_HS);
				RepeaterMaster.DataSource =_HS;
				RepeaterMaster.DataBind(); 
			}
		}
		private void BindingMasterSingle()
		{
			if(Wo!=null)
			{
				Hashtable _HS=new Hashtable();
				_HS.Add(Request.QueryString["wo"],true);
				RepeaterMaster.DataSource =_HS;
				RepeaterMaster.DataBind(); 
			}
			
		}
		/// <summary>
		/// Rimuove gli item con valore a false
		/// che indica quelli che non sono stati ceccati
		/// </summary>
		/// <param name="myList"></param>
		private  Hashtable RemoveHash(Hashtable myList )  
		{
			Hashtable _HS=new Hashtable();
			IDictionaryEnumerator myEnumerator = myList.GetEnumerator();
			while ( myEnumerator.MoveNext() )
				if((bool)myEnumerator.Value==true)
					_HS.Add(myEnumerator.Key,myEnumerator.Value);

			return _HS;
	
		}

		private DataSet UpdateWo(int itemId)
		{
					
			
			Classi.ManProgrammata.CompletaOrdine  _Completa = new TheSite.Classi.ManProgrammata.CompletaOrdine();
			
					
			
			int wo_id =  itemId;	
					S_Controls.Collections.S_ControlsCollection CollezioneControlli = new S_Controls.Collections.S_ControlsCollection();
						
					S_Controls.Collections.S_Object p_wo_id = new S_Object();
					p_wo_id.ParameterName = "p_wo_id";
					p_wo_id.DbType = CustomDBType.Integer;
					p_wo_id.Direction = ParameterDirection.Input;
					p_wo_id.Index = 0;					
					p_wo_id.Value = wo_id;																	
					CollezioneControlli.Add(p_wo_id);

					S_Controls.Collections.S_Object p_addetto_id = new S_Object();
					p_addetto_id.ParameterName = "p_addetto_id";
					p_addetto_id.DbType = CustomDBType.Integer;
					p_addetto_id.Direction = ParameterDirection.Input;
					p_addetto_id.Index = 1;					
					p_addetto_id.Value = addetto_id;																	
					CollezioneControlli.Add(p_addetto_id);

					
					S_Controls.Collections.S_Object p_dataip = new S_Object();
					p_dataip.ParameterName = "p_dataip";
					p_dataip.DbType = CustomDBType.Date;
					p_dataip.Direction = ParameterDirection.Input;
					p_dataip.Index = 2;					
					if (Dataip.ToString()!=String.Empty)
					p_dataip.Value = Convert.ToDateTime(Dataip).ToString("d");
					else
					p_dataip.Value = Convert.ToDateTime("01/01/1900").ToString("d");
						//String.Empty;									
					CollezioneControlli.Add(p_dataip);
							
					S_Controls.Collections.S_Object p_datafp = new S_Object();
					p_datafp.ParameterName = "p_datafp";
					p_datafp.DbType = CustomDBType.Date;
					p_datafp.Direction = ParameterDirection.Input;
					p_datafp.Index = 3;					
					if (Datafp.ToString()!=String.Empty)
					p_datafp.Value = Convert.ToDateTime(Datafp).ToString("d");
					else
					p_datafp.Value=Convert.ToDateTime("01/01/1900").ToString("d");
						//String.Empty;									
					CollezioneControlli.Add(p_datafp);
			
					S_Controls.Collections.S_Object p_data = new S_Object();
					p_data.ParameterName = "p_data";
					p_data.DbType = CustomDBType.Date;
					p_data.Direction = ParameterDirection.Input;
					p_data.Index = 4;					
					p_data.Value = Convert.ToDateTime(Data).ToString("d");																	
					CollezioneControlli.Add(p_data);
					
					S_Controls.Collections.S_Object p_data1 = new S_Object();
					p_data1.ParameterName = "p_data1";
					p_data1.DbType = CustomDBType.Date;
					p_data1.Direction = ParameterDirection.Input;
					p_data1.Index = 5;					
					p_data1.Value = Convert.ToDateTime(Data1).ToString("d");																	
					CollezioneControlli.Add(p_data1);

					DataSet Ds=_Completa.CompletaWO1(CollezioneControlli);	
									
					return Ds;			
		}

		private DataTable UpdateWr()
		{
			int ck=0;
			DataTable  Dt=new DataTable();
			if(Session["DatiListMP"]!=null)
			{
				
				Classi.ManProgrammata.CompletaOrdine  _Completa = new TheSite.Classi.ManProgrammata.CompletaOrdine();
				Hashtable _HS = (Hashtable)Session["DatiListMP"];
				IDictionaryEnumerator myEnumerator = _HS.GetEnumerator();
		
				while ( myEnumerator.MoveNext() )
				{
					WRList  _campi = (WRList)myEnumerator.Value;
					
					S_Controls.Collections.S_ControlsCollection CollezioneControlli = new S_Controls.Collections.S_ControlsCollection();
						
					S_Controls.Collections.S_Object p_wo_id = new S_Object();
					p_wo_id.ParameterName = "p_wo_id";
					p_wo_id.DbType = CustomDBType.Integer;
					p_wo_id.Direction = ParameterDirection.Input;
					p_wo_id.Index = 0;					
					p_wo_id.Value = Wo;																	
					CollezioneControlli.Add(p_wo_id);

					S_Controls.Collections.S_Object p_wr_id = new S_Object();
					p_wr_id.ParameterName = "p_wr_id";
					p_wr_id.DbType = CustomDBType.Integer;
					p_wr_id.Direction = ParameterDirection.Input;
					p_wr_id.Index = 1;					
					p_wr_id.Value = _campi.id;																	
					CollezioneControlli.Add(p_wr_id);

					S_Controls.Collections.S_Object p_dataip = new S_Object();
					p_dataip.ParameterName = "p_dataip";
					p_dataip.DbType = CustomDBType.Date;
					p_dataip.Direction = ParameterDirection.Input;
					p_dataip.Index = 2;					
					if (Dataip.ToString()!=String.Empty)
						p_dataip.Value = Convert.ToDateTime(Dataip).ToString("d");
					else
						p_dataip.Value = Convert.ToDateTime("01/01/1900").ToString("d");																	
					CollezioneControlli.Add(p_dataip);

					S_Controls.Collections.S_Object p_datafp = new S_Object();
					p_datafp.ParameterName = "p_datafp";
					p_datafp.DbType = CustomDBType.Date;
					p_datafp.Direction = ParameterDirection.Input;
					p_datafp.Index = 3;					
					if (Datafp.ToString()!=String.Empty)
						p_datafp.Value = Convert.ToDateTime(Datafp).ToString("d");
					else
						p_datafp.Value=Convert.ToDateTime("01/01/1900").ToString("d");																	
					CollezioneControlli.Add(p_datafp);				
					
					
					S_Controls.Collections.S_Object p_data = new S_Object();
					p_data.ParameterName = "p_data";
					p_data.DbType = CustomDBType.Date;
					p_data.Direction = ParameterDirection.Input;
					p_data.Index = 4;					
					p_data.Value = Convert.ToDateTime(Data).ToString("d");																	
					CollezioneControlli.Add(p_data);

					S_Controls.Collections.S_Object p_data1 = new S_Object();
					p_data1.ParameterName = "p_data1";
					p_data1.DbType = CustomDBType.Date;
					p_data1.Direction = ParameterDirection.Input;
					p_data1.Index = 5;					
					p_data1.Value = Convert.ToDateTime(Data1).ToString("d");																	
					CollezioneControlli.Add(p_data1);
				
					S_Controls.Collections.S_Object p_stato = new S_Object();
					p_stato.ParameterName = "p_stato";
					p_stato.DbType = CustomDBType.Integer;
					p_stato.Direction = ParameterDirection.Input;
					p_stato.Index = 4;					
						
					if(_campi.stato==false)//sospesa
					{
						p_stato.Value = 1; 	
					}
					else//chiusa
					{
						p_stato.Value = 0; 	
					}										
					CollezioneControlli.Add(p_stato);

					S_Controls.Collections.S_Object p_motivo = new S_Object();
					p_motivo.ParameterName = "p_motivo";
					p_motivo.DbType = CustomDBType.VarChar;
					p_motivo.Direction = ParameterDirection.Input;
					p_motivo.Size=4000; 
					p_motivo.Index = 5;					
					p_motivo.Value = _campi.descrizione; 																
					CollezioneControlli.Add(p_motivo);
					ck =_Completa.AggiornaWr1(CollezioneControlli);


S_Controls.Collections.S_Object p_addetto_id = new S_Object();
p_addetto_id.ParameterName = "p_addetto_id";
p_addetto_id.DbType = CustomDBType.Integer;
p_addetto_id.Direction = ParameterDirection.Input;
p_addetto_id.Index = 1;					
p_addetto_id.Value = int.Parse(addettoWR);
CollezioneControlli.Add(p_addetto_id);


//					DataSet DsTemp=	_Completa.GETWO11(Wo);
//					Dt=DsTemp.Tables[0].Clone();
//					if (DsTemp.Tables[0].Rows.Count>0)
//					{
//						int r=DsTemp.Tables[0].Rows.Count;
//						
//						if(Dt.Rows.Count==0)  
//							Dt=DsTemp.Tables[0].Clone();
//						else 
//						{
//							Dt.ImportRow(DsTemp.Tables[0].Rows[0]);
//						  } 
				}
				int v = int.Parse(Wo);
				//p_addetto_id
				Classi.ManProgrammata.CompletaOrdine  _Completa1 = new TheSite.Classi.ManProgrammata.CompletaOrdine();
				DataSet DsTemp=	_Completa1.GETWO11(v);
			Dt=DsTemp.Tables[0];

			}
		
			return Dt;	
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
			this.RepeaterMaster.ItemDataBound += new System.Web.UI.WebControls.RepeaterItemEventHandler(this.RepeaterMaster_ItemDataBound);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void RepeaterMaster_ItemDataBound(object sender, System.Web.UI.WebControls.RepeaterItemEventArgs e)
		{
			if((e.Item.ItemType == ListItemType.Item) || 
				(e.Item.ItemType == ListItemType.AlternatingItem))
			{
				Repeater RepeaterDett= (Repeater)e.Item.FindControl("RepeaterDettail");
                int item=Convert.ToInt32(DataBinder.Eval(e.Item.DataItem, "Key").ToString());

                DataTable Dt;
				if(Wo==null)
					Dt=UpdateWo(item).Tables[0] ;
				else
				{
					Dt=UpdateWr();
					//reloadparent();
				}
                RepeaterDett.DataSource =Dt;
				RepeaterDett.DataBind(); 

			}
		}
//		private void reloadparent()
//		{ 
//			String scriptString = "<script language='JavaScript'>\n";
//			scriptString += "opener.__doPostBack('DataGridRicerca','');\n";
//			scriptString += "<";
//			scriptString += "/";
//			scriptString += "script>";
//        
//			if(!this.IsStartupScriptRegistered("Startup"))
//				this.RegisterStartupScript("Startup", scriptString);
//
//			 
//		}
	}
}
