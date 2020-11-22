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
using System.Data.OracleClient;
using System.Configuration;
using System.Text;

using S_Controls;




namespace TheSite.Classi.GestioneCP
{
	public class DocNormativi : AbstractBase
	{
		public string UserName;

		public DocNormativi(string UserName)
		{
			this.UserName= UserName;
		}

		public DocNormativi(){}
		

		#region Metodi Pubblici
		public int ExecuteUpdateFile(S_ControlsCollection CollezioneControlli)
		{
			int i_Result=0;

			S_Controls.Collections.S_Object id_doc_norm_out = new S_Object();
			id_doc_norm_out.ParameterName = "file_delete";
			id_doc_norm_out.DbType = CustomDBType.VarChar;
			id_doc_norm_out.Direction = ParameterDirection.Output;
			id_doc_norm_out.Index = CollezioneControlli.Count;
			id_doc_norm_out.Value = "";
			CollezioneControlli.Add(id_doc_norm_out);
			
			ApplicationDataLayer.OracleDataLayer _OraDl = new OracleDataLayer(s_ConnStr);
			i_Result = _OraDl.GetRowsAffected(CollezioneControlli,  "PACK_CPERIODICI_SFOGLIA.UPD_FILE_DOC_NORM");
				
			return i_Result;
		
		}

		public DataSet docNormativiList(S_ControlsCollection CollezioneControlli)
		{
			ApplicationDataLayer.OracleDataLayer _OraDl = new OracleDataLayer(s_ConnStr);
			string s_StrSql = "PACK_CPERIODICI_SFOGLIA.DOC_NORMATIVI_LIST";	
			DataSet _Ds = _OraDl.GetRows(CollezioneControlli, s_StrSql).Copy();			

			return _Ds;	
		}

		
		public string  vv(	string p_nome_doc ,string p_desc_doc ,string p_norma_apparenza    ,
		string p_nomefile    , string p_versione_doc       )
		
		{
			
		 string Result="";
			string ConnectionString=ConfigurationSettings.AppSettings.Get("ConnectionString");
			string s_StrSql = "PACK_CPERIODICI_SFOGLIA.INS_DOC_NORM_str";
			using(OracleConnection connection = new OracleConnection(ConnectionString))
			{
				try
				{
					connection.Open();

					using(OracleCommand command = new OracleCommand(s_StrSql,connection))
					{
						command.CommandType = System.Data.CommandType.StoredProcedure;
					
						

						OracleParameter p1 = new OracleParameter("p_nome_doc",OracleType.VarChar);
						p1.Value     = p_nome_doc;
						p1.Direction = System.Data.ParameterDirection.Input;
						command.Parameters.Add(p1);
						
						OracleParameter p2 = new OracleParameter("p_desc_doc",OracleType.VarChar);
						p2.Value     = p_desc_doc;
						p2.Direction = System.Data.ParameterDirection.Input;
						command.Parameters.Add(p2);

						OracleParameter p3 = new OracleParameter("p_norma_apparenza",OracleType.VarChar);
						p2.Value     = p_norma_apparenza;
						p2.Direction = System.Data.ParameterDirection.Input;
						command.Parameters.Add(p3);

						OracleParameter p4 = new OracleParameter("p_nomefile",OracleType.VarChar);
						p2.Value     = p_nomefile;
						p2.Direction = System.Data.ParameterDirection.Input;
						command.Parameters.Add(p4);
						
						OracleParameter p5 = new OracleParameter("p_versione_doc",OracleType.VarChar);
						p2.Value     = p_versione_doc;
						p2.Direction = System.Data.ParameterDirection.Input;
						command.Parameters.Add(p5);

						OracleParameter p6 = new OracleParameter("MSG_OUT",OracleType.VarChar,1000);
						p3.Value     = "";
						p3.Direction = System.Data.ParameterDirection.InputOutput;
						command.Parameters.Add(p6);

						command.ExecuteNonQuery();

						Result=p3.Value.ToString();
					}
				}
				finally
				{
					if(connection.State == ConnectionState.Open)
					{
						connection.Dispose();
					}
				}
				return Result;
			}
			}

		
		
		public int INS_DOC_NORM(S_ControlsCollection CollezioneControlli)
		{
		
			int i_Result=0;
			
			S_Controls.Collections.S_Object p_id_doc_norm = new S_Object();
			p_id_doc_norm.ParameterName = "p_id_doc_norm";
			p_id_doc_norm.DbType = CustomDBType.Integer;
			p_id_doc_norm.Direction = ParameterDirection.Output;
			p_id_doc_norm.Index = CollezioneControlli.Count;
			p_id_doc_norm.Value = 0;
			CollezioneControlli.Add(p_id_doc_norm);

			
			ApplicationDataLayer.OracleDataLayer _OraDl = new OracleDataLayer(s_ConnStr);
			i_Result = _OraDl.GetRowsAffected(CollezioneControlli,  "PACK_CPERIODICI_SFOGLIA.INS_DOC_NORM");
				
			return i_Result;
		
		}
		
		public int UPD_DOC_NORM(S_ControlsCollection CollezioneControlli)
		{
			int i_Result=0;
			S_Controls.Collections.S_Object p_id_doc_norm_out = new S_Object();
			p_id_doc_norm_out.ParameterName = "p_id_doc_norm_out";
			p_id_doc_norm_out.DbType = CustomDBType.Integer;
			p_id_doc_norm_out.Direction = ParameterDirection.Output;
			p_id_doc_norm_out.Index = CollezioneControlli.Count;
			p_id_doc_norm_out.Value = 0;
			CollezioneControlli.Add(p_id_doc_norm_out);

			ApplicationDataLayer.OracleDataLayer _OraDl = new OracleDataLayer(s_ConnStr);
			i_Result = _OraDl.GetRowsAffected(CollezioneControlli,  "PACK_CPERIODICI_SFOGLIA.UPD_DOC_NORM");
				
			return i_Result;
		
		}
		public DataSet DEL_DOC_NORM(S_ControlsCollection CollezioneControlli)
		{
			//int i_Result=0;
//			S_Controls.Collections.S_Object id_doc_norm_out = new S_Object();
//			id_doc_norm_out.ParameterName = "id_doc_norm_out";
//			id_doc_norm_out.DbType = CustomDBType.Integer;
//			id_doc_norm_out.Direction = ParameterDirection.Output;
//			id_doc_norm_out.Index = CollezioneControlli.Count;
//			id_doc_norm_out.Value = 0;
//			CollezioneControlli.Add(id_doc_norm_out);

//			S_Object file_delete = new S_Object();
//			file_delete.ParameterName = "file_delete";
//			file_delete.DbType = CustomDBType.VarChar;
//			file_delete.Index = CollezioneControlli.Count;
//			file_delete.Size=300;
//			file_delete.Value = "";
//			CollezioneControlli.Add(file_delete);
//
//			ApplicationDataLayer.OracleDataLayer _OraDl = new OracleDataLayer(s_ConnStr);
//			System.Data.OracleClient.OracleParameterCollection pc = _OraDl.ParametersArray(CollezioneControlli,  "PACK_CPERIODICI_SFOGLIA.DEL_DOC_NORM");
//				
//			string file_del = pc[1].Value.ToString();
//
//			return file_del;
			S_Controls.Collections.S_Object s_Cursor = new S_Object();
			s_Cursor.ParameterName = "IO_CURSOR";
			s_Cursor.DbType = CustomDBType.Cursor;
			s_Cursor.Direction = ParameterDirection.Output;
			s_Cursor.Index = CollezioneControlli.Count;
			CollezioneControlli.Add(s_Cursor);

			ApplicationDataLayer.OracleDataLayer _OraDl = new OracleDataLayer(s_ConnStr);
			
			DataSet _Ds = _OraDl.GetRows(CollezioneControlli,  "PACK_CPERIODICI_SFOGLIA.DEL_DOC_NORM").Copy();			

			return _Ds;	
		}
		public DataSet GETDOCNORM(int id_doc_norm)
		{
			S_ControlsCollection CollezioneControlli=new S_ControlsCollection();

			S_Controls.Collections.S_Object p_id_doc_norm = new S_Object();
			p_id_doc_norm.ParameterName = "p_id_doc_norm";
			p_id_doc_norm.DbType = CustomDBType.Integer;
			p_id_doc_norm.Direction = ParameterDirection.Input;
			p_id_doc_norm.Index = 0;
			p_id_doc_norm.Value=id_doc_norm;
			CollezioneControlli.Add(p_id_doc_norm);


			S_Controls.Collections.S_Object s_Cursor = new S_Object();
			s_Cursor.ParameterName = "IO_CURSOR";
			s_Cursor.DbType = CustomDBType.Cursor;
			s_Cursor.Direction = ParameterDirection.Output;
			s_Cursor.Index = CollezioneControlli.Count;
			CollezioneControlli.Add(s_Cursor);

			ApplicationDataLayer.OracleDataLayer _OraDl = new OracleDataLayer(s_ConnStr);
			string s_StrSql = "PACK_CPERIODICI_SFOGLIA.GETDOCNORM";	
			DataSet _Ds = _OraDl.GetRows(CollezioneControlli, s_StrSql).Copy();			

			return _Ds;	
		}
		/// <summary>
		/// DataSet con tutti i record
		/// </summary>
		/// <returns></returns>
		

		/// <summary>
		/// 
		/// </summary>		

		public override DataSet GetData()
		{
			return null;
		}
		public override DataSet GetSingleData(int itemId)
		{
			DataSet _Ds;

			S_Controls.Collections.S_ControlsCollection CollezioneControlli = new S_Controls.Collections.S_ControlsCollection();

			S_Controls.Collections.S_Object s_WO_ID = new S_Object();

			s_WO_ID.ParameterName = "p_Wo_Id";
			s_WO_ID.DbType = CustomDBType.Integer;
			s_WO_ID.Direction = ParameterDirection.Input;
			s_WO_ID.Index = 0;
			s_WO_ID.Size=4;
			s_WO_ID.Value=itemId;
			CollezioneControlli.Add(s_WO_ID);	
		
			// Tipo Manutenzione
			S_Controls.Collections.S_Object s_TipoManutenzione = new S_Object();

			s_TipoManutenzione.ParameterName = "p_TipoManutenzione";
			s_TipoManutenzione.DbType = CustomDBType.Integer;
			s_TipoManutenzione.Direction = ParameterDirection.Input;
			s_TipoManutenzione.Index = 1;
			s_TipoManutenzione.Size=4;
			s_TipoManutenzione.Value=Classi.TipoManutenzioneType.ManutenzioneProgrammata;						
			CollezioneControlli.Add(s_TipoManutenzione);

			S_Controls.Collections.S_Object s_Cursor = new S_Object();			
			s_Cursor.ParameterName = "IO_CURSOR";
			s_Cursor.DbType = CustomDBType.Cursor;
			s_Cursor.Direction = ParameterDirection.Output;
			s_Cursor.Index = 2;
			CollezioneControlli.Add(s_Cursor);
			
			ApplicationDataLayer.OracleDataLayer _OraDl = new OracleDataLayer(s_ConnStr);
			string s_StrSql = "PACK_MAN_PROG.GetSingleWO";	
			_Ds = _OraDl.GetRows(CollezioneControlli, s_StrSql).Copy();			

			return _Ds;
		}
		public DataSet GetApparati(S_ControlsCollection CollezioneControlli)
		{
			DataSet _Ds;

			//S_Controls.Collections.S_ControlsCollection CollezioneControlli = new S_Controls.Collections.S_ControlsCollection();

		

			S_Controls.Collections.S_Object s_Cursor = new S_Object();			
			s_Cursor.ParameterName = "IO_CURSOR";
			s_Cursor.DbType = CustomDBType.Cursor;
			s_Cursor.Direction = ParameterDirection.Output;
			s_Cursor.Index = 2;
			CollezioneControlli.Add(s_Cursor);
			
			ApplicationDataLayer.OracleDataLayer _OraDl = new OracleDataLayer(s_ConnStr);
			string s_StrSql = "PACK_CPERIODICI_SFOGLIA.SP_GET_LISTA_EQ";	
			_Ds = _OraDl.GetRows(CollezioneControlli, s_StrSql).Copy();			

			return _Ds;
		}

		
		public DataSet GetEdifici(string username)
		{
			DataSet _Ds;
			S_Controls.Collections.S_ControlsCollection control = new S_Controls.Collections.S_ControlsCollection();

			S_Controls.Collections.S_Object p = new S_Object();
			p.ParameterName = "p_username";
			p.DbType = CustomDBType.VarChar;
			p.Direction = ParameterDirection.Input;
			p.Index = control.Count;
			p.Size=20;
			p.Value=username;						
			control.Add(p);

			S_Controls.Collections.S_Object s_Cursor = new S_Object();			
			s_Cursor.ParameterName = "IO_CURSOR";
			s_Cursor.DbType = CustomDBType.Cursor;
			s_Cursor.Direction = ParameterDirection.Output;
			s_Cursor.Index = control.Count;
			control.Add(s_Cursor);
			
			ApplicationDataLayer.OracleDataLayer _OraDl = new OracleDataLayer(s_ConnStr);
			string s_StrSql = "PACK_CPERIODICI_SFOGLIA.sp_getedifici";	
			_Ds = _OraDl.GetRows(control, s_StrSql).Copy();			

			return _Ds;
		}
		public  DataSet GetDataFReq()
		{
			DataSet _Ds;
			S_ControlsCollection CollezioneControlli = new S_ControlsCollection(); 

			S_Controls.Collections.S_Object S_Cursor=new S_Object();
			S_Cursor.ParameterName ="IO_CURSOR";
			S_Cursor.DbType=CustomDBType.Cursor;
			S_Cursor.Direction=ParameterDirection.Output;
			S_Cursor.Index = 0;
		
			CollezioneControlli.Add(S_Cursor);

			ApplicationDataLayer.OracleDataLayer _OraDL=new OracleDataLayer(s_ConnStr);
			string s_StrSql = "PACK_CPERIODICI_SFOGLIA.SP_GETALLPMPFREQUENZA";
			_Ds=_OraDL.GetRows(CollezioneControlli,s_StrSql).Copy();
			return _Ds;
		}
		
		public  DataSet GetDataTipoCP()
		{
			DataSet _Ds;
			S_ControlsCollection CollezioneControlli = new S_ControlsCollection(); 

			S_Controls.Collections.S_Object S_Cursor=new S_Object();
			S_Cursor.ParameterName ="IO_CURSOR";
			S_Cursor.DbType=CustomDBType.Cursor;
			S_Cursor.Direction=ParameterDirection.Output;
			S_Cursor.Index = 0;
		
			CollezioneControlli.Add(S_Cursor);

			ApplicationDataLayer.OracleDataLayer _OraDL=new OracleDataLayer(s_ConnStr);
			string s_StrSql = "PACK_CPERIODICI_SFOGLIA.SP_GETALLTIPOCP";
			_Ds=_OraDL.GetRows(CollezioneControlli,s_StrSql).Copy();
			return _Ds;
		}
		

		/// <summary>
		/// 
		/// </summary>
		/// <param name="CollezioneControlli"></param>
		/// <returns></returns>
		public override DataSet GetData(S_ControlsCollection CollezioneControlli)
		{
			DataSet _Ds;

			S_Controls.Collections.S_Object s_UserName = new S_Object();
			s_UserName.ParameterName = "p_UserName";
			s_UserName.DbType = CustomDBType.VarChar;
			s_UserName.Direction = ParameterDirection.Input;
			s_UserName.Index = 8;
			s_UserName.Size=50;
			s_UserName.Value=System.Web.HttpContext.Current.User.Identity.Name;
			CollezioneControlli.Add(s_UserName);

			S_Controls.Collections.S_Object s_Cursor = new S_Object();			
			s_Cursor.ParameterName = "IO_CURSOR";
			s_Cursor.DbType = CustomDBType.Cursor;
			s_Cursor.Direction = ParameterDirection.Output;
			s_Cursor.Index = 9;
			CollezioneControlli.Add(s_Cursor);
			
			ApplicationDataLayer.OracleDataLayer _OraDl = new OracleDataLayer(s_ConnStr);
			string s_StrSql = "PACK_MAN_PROG.GetCompletamento";	
			_Ds = _OraDl.GetRows(CollezioneControlli, s_StrSql).Copy();			

			return _Ds;		
		}



		public DataSet GetDatiWO(S_ControlsCollection CollezioneControlli)
		{
			DataSet _Ds;		

			S_Controls.Collections.S_Object s_Cursor = new S_Object();			
			s_Cursor.ParameterName = "IO_CURSOR";
			s_Cursor.DbType = CustomDBType.Cursor;
			s_Cursor.Direction = ParameterDirection.Output;
			s_Cursor.Index = 1;
			CollezioneControlli.Add(s_Cursor);
			
			ApplicationDataLayer.OracleDataLayer _OraDl = new OracleDataLayer(s_ConnStr);
			string s_StrSql = "PACK_MAN_PROG.GetDatiWO";	
			_Ds = _OraDl.GetRows(CollezioneControlli, s_StrSql).Copy();			

			return _Ds;		
		}
		public DataSet GetDatiWR(S_ControlsCollection CollezioneControlli)
		{
			DataSet _Ds;		
			//
			//			S_Controls.Collections.S_Object s_Cursor = new S_Object();			
			//			s_Cursor.ParameterName = "IO_CURSOR";
			//			s_Cursor.DbType = CustomDBType.Cursor;
			//			s_Cursor.Direction = ParameterDirection.Output;
			//			s_Cursor.Index = 1;
			//			CollezioneControlli.Add(s_Cursor);
			
			ApplicationDataLayer.OracleDataLayer _OraDl = new OracleDataLayer(s_ConnStr);
			string s_StrSql = "PACK_MAN_PROG.GetDatiWR";	
			_Ds = _OraDl.GetRows(CollezioneControlli, s_StrSql).Copy();			

			return _Ds;		
		}
		public DataSet GetDatiWR1(S_ControlsCollection CollezioneControlli)
		{
			DataSet _Ds;		
			//
			//			S_Controls.Collections.S_Object s_Cursor = new S_Object();			
			//			s_Cursor.ParameterName = "IO_CURSOR";
			//			s_Cursor.DbType = CustomDBType.Cursor;
			//			s_Cursor.Direction = ParameterDirection.Output;
			//			s_Cursor.Index = 1;
			//			CollezioneControlli.Add(s_Cursor);
			
			ApplicationDataLayer.OracleDataLayer _OraDl = new OracleDataLayer(s_ConnStr);
			string s_StrSql = "PACK_MAN_PROG.GetDatiWR1";	
			_Ds = _OraDl.GetRows(CollezioneControlli, s_StrSql).Copy();			

			return _Ds;		
		}
		

		#endregion

		#region Metodi Private

		protected override int ExecuteUpdate(S_ControlsCollection CollezioneControlli, ExecuteType Operazione, int itemId)
		{
			return 0;
		}

		#endregion
	}


}
