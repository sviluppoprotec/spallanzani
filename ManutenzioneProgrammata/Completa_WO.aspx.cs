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
	public class Completa_WO : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Repeater RepeaterMaster;
		protected WebControls.PageTitle PageTitle1;

	    int addetto_id=0;
		string Data=null;
		string Wo=null;
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
					BindingMaster();
				}
				else
				{
					Wo=Request.QueryString["wo"];
					Data=Request.QueryString["data"];
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

					S_Controls.Collections.S_Object p_data = new S_Object();
					p_data.ParameterName = "p_data";
					p_data.DbType = CustomDBType.Date;
					p_data.Direction = ParameterDirection.Input;
					p_data.Index = 2;					
					p_data.Value = Convert.ToDateTime(Data).ToString("d");																	
					CollezioneControlli.Add(p_data);
				
					DataSet Ds=_Completa.CompletaWO(CollezioneControlli);	
									
					return Ds;			
		}

		private DataTable UpdateWr()
		{
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

					S_Controls.Collections.S_Object p_data = new S_Object();
					p_data.ParameterName = "p_data";
					p_data.DbType = CustomDBType.Date;
					p_data.Direction = ParameterDirection.Input;
					p_data.Index = 2;					
					p_data.Value = Convert.ToDateTime(Data).ToString("d");																	
					CollezioneControlli.Add(p_data);
				
					S_Controls.Collections.S_Object p_stato = new S_Object();
					p_stato.ParameterName = "p_stato";
					p_stato.DbType = CustomDBType.Integer;
					p_stato.Direction = ParameterDirection.Input;
					p_stato.Index = 3;					
						
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
					p_motivo.Index = 4;					
					p_motivo.Value = _campi.descrizione; 																
					CollezioneControlli.Add(p_motivo);

					DataSet DsTemp=_Completa.AggiornaWr(CollezioneControlli);	
				
					if (DsTemp.Tables[0].Rows.Count>0)
					{
						
						if(Dt.Rows.Count==0)  
							Dt=DsTemp.Tables[0].Clone();
                        Dt.ImportRow(DsTemp.Tables[0].Rows[0]);  
                
					}
											
				}
				
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
