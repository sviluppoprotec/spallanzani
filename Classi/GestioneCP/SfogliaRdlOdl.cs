using System.Collections;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Text;
using System.Data;
using S_Controls;
using S_Controls.Collections;
using ApplicationDataLayer;
using ApplicationDataLayer.DBType;

namespace TheSite.Classi.GestioneCP
{
	/// <summary>
	/// Descrizione di riepilogo per SfogliaRdlOdl.
	/// </summary>
	////////	public class SfogliaRdlOdl
	////////	{
	////////		public SfogliaRdlOdl()
	////////		{
	////////			//
	////////			// TODO: aggiungere qui la logica del costruttore
	////////			//
	////////		}
	////////	}
	///

	/// Descrizione di riepilogo per SfogliaRdlOdl.
	/// </summary>
	public class SfogliaRdlOdl: AbstractBase
	{
		string username=string.Empty; 
		public SfogliaRdlOdl(string UserName)
		{
			username=UserName;
		}
		public override DataSet GetSingleData(int itemId)
		{
			return null;
		}

		public override DataSet GetData()
		{
			return null;
		}
		public override DataSet GetData(S_ControlsCollection CollezioneControlli)
		{
			S_Controls.Collections.S_Object s_Cursor = new S_Object();
			s_Cursor.ParameterName = "IO_CURSOR";
			s_Cursor.DbType = CustomDBType.Cursor;
			s_Cursor.Direction = ParameterDirection.Output;
			s_Cursor.Index = CollezioneControlli.Count + 1;
			CollezioneControlli.Add(s_Cursor);

			ApplicationDataLayer.OracleDataLayer _OraDl = new OracleDataLayer(s_ConnStr);
			string s_StrSql = "pack_cperiodici_sfoglia.sp_getrdlodl";	
			DataSet _Ds = _OraDl.GetRows(CollezioneControlli, s_StrSql).Copy();			

			return _Ds;	
		}


		public  DataSet GetPMPCP(S_ControlsCollection CollezioneControlli)
		{
			S_Controls.Collections.S_Object s_Cursor = new S_Object();
			s_Cursor.ParameterName = "IO_CURSOR";
			s_Cursor.DbType = CustomDBType.Cursor;
			s_Cursor.Direction = ParameterDirection.Output;
			s_Cursor.Index = CollezioneControlli.Count ;
			CollezioneControlli.Add(s_Cursor);

			ApplicationDataLayer.OracleDataLayer _OraDl = new OracleDataLayer(s_ConnStr);
			string s_StrSql = "pack_cperiodici_sfoglia.GETPMPCP";	
			DataSet _Ds = _OraDl.GetRows(CollezioneControlli, s_StrSql).Copy();			

			return _Ds;	
		}


		public  int GetDataCount(S_ControlsCollection CollezioneControlli)
		{
			

			S_Controls.Collections.S_Object s_Cursor = new S_Object();
			s_Cursor.ParameterName = "IO_CURSOR";
			s_Cursor.DbType = CustomDBType.Cursor;
			s_Cursor.Direction = ParameterDirection.Output;
			s_Cursor.Index = CollezioneControlli.Count + 1;
			CollezioneControlli.Add(s_Cursor);

			ApplicationDataLayer.OracleDataLayer _OraDl = new OracleDataLayer(s_ConnStr);
			string s_StrSql = "PACK_CPERIODICI_SFOGLIA.SP_GETRDLODLCOUNT";	
			DataSet _Ds = _OraDl.GetRows(CollezioneControlli, s_StrSql).Copy();			

			return int.Parse(_Ds.Tables[0].Rows[0][0].ToString());  
		}
		//		public int GetDataCount(S_ControlsCollection CollezioneControlli)
		//		{
		//			
		//
		//			S_Controls.Collections.S_Object s_Cursor = new S_Object();
		//			s_Cursor.ParameterName = "IO_CURSOR";
		//			s_Cursor.DbType = CustomDBType.Cursor;
		//			s_Cursor.Direction = ParameterDirection.Output;
		//			s_Cursor.Index = CollezioneControlli.Count + 1;
		//			CollezioneControlli.Add(s_Cursor);
		//
		//			ApplicationDataLayer.OracleDataLayer _OraDl = new OracleDataLayer(s_ConnStr);
		//			string s_StrSql = "PACK_ORDINARIA_SFOGLIA.SP_GETRDLODL2Count";	
		//			DataSet _Ds = _OraDl.GetRows(CollezioneControlli, s_StrSql).Copy();			
		//
		//			return int.Parse(_Ds.Tables[0].Rows[0][0].ToString());	
		//		}
		public  DataSet GetStatoLavoro()
		{
			
			S_ControlsCollection CollezioneControlli=new S_ControlsCollection();

			S_Controls.Collections.S_Object s_Cursor = new S_Object();
			s_Cursor.ParameterName = "IO_CURSOR";
			s_Cursor.DbType = CustomDBType.Cursor;
			s_Cursor.Direction = ParameterDirection.Output;
			s_Cursor.Index = CollezioneControlli.Count + 1;

			CollezioneControlli.Add(s_Cursor);

			ApplicationDataLayer.OracleDataLayer _OraDl = new OracleDataLayer(s_ConnStr);
			string s_StrSql = "PACK_ORDINARIA_SFOGLIA.SP_GETSTATOLAVORO";	
			DataSet _Ds = _OraDl.GetRows(CollezioneControlli, s_StrSql).Copy();			

			return _Ds;	
		}
		public DataSet GetSingleRdl(int wo_id)
		{
			S_ControlsCollection CollezioneControlli=new S_ControlsCollection();

			S_Controls.Collections.S_Object s_p_wo_id = new S_Object();
			s_p_wo_id.ParameterName = "p_wo_id";
			s_p_wo_id.DbType = CustomDBType.Integer;
			s_p_wo_id.Direction = ParameterDirection.Input;
			s_p_wo_id.Index = CollezioneControlli.Count + 1;
			s_p_wo_id.Value=wo_id;
			CollezioneControlli.Add(s_p_wo_id);


			S_Controls.Collections.S_Object s_Cursor = new S_Object();
			s_Cursor.ParameterName = "IO_CURSOR";
			s_Cursor.DbType = CustomDBType.Cursor;
			s_Cursor.Direction = ParameterDirection.Output;
			s_Cursor.Index = CollezioneControlli.Count + 1;

			CollezioneControlli.Add(s_Cursor);

			ApplicationDataLayer.OracleDataLayer _OraDl = new OracleDataLayer(s_ConnStr);
			string s_StrSql = "PACK_ORDINARIA_SFOGLIA.SP_GETSINGLERDL";	
			DataSet _Ds = _OraDl.GetRows(CollezioneControlli, s_StrSql).Copy();			

			return _Ds;	
		}
		public DataSet GETWRCP(int wr_id)
		{
			S_ControlsCollection CollezioneControlli=new S_ControlsCollection();

			S_Controls.Collections.S_Object s_p_id_wr_cp = new S_Object();
			s_p_id_wr_cp.ParameterName = "p_id_wr_cp";
			s_p_id_wr_cp.DbType = CustomDBType.Integer;
			s_p_id_wr_cp.Direction = ParameterDirection.Input;
			s_p_id_wr_cp.Index = 0;
			s_p_id_wr_cp.Value=wr_id;
			CollezioneControlli.Add(s_p_id_wr_cp);


			S_Controls.Collections.S_Object s_Cursor = new S_Object();
			s_Cursor.ParameterName = "IO_CURSOR";
			s_Cursor.DbType = CustomDBType.Cursor;
			s_Cursor.Direction = ParameterDirection.Output;
			s_Cursor.Index = CollezioneControlli.Count;
			CollezioneControlli.Add(s_Cursor);

			ApplicationDataLayer.OracleDataLayer _OraDl = new OracleDataLayer(s_ConnStr);
			string s_StrSql = "PACK_CPERIODICI_SFOGLIA.GETWRCP";	
			DataSet _Ds = _OraDl.GetRows(CollezioneControlli, s_StrSql).Copy();			

			return _Ds;	
		}
		
		public DataSet GETWRCP_SF(S_ControlsCollection CollezioneControlli)
		{
		

			//			S_Controls.Collections.S_Object s_Cursor = new S_Object();
			//			s_Cursor.ParameterName = "IO_CURSOR";
			//			s_Cursor.DbType = CustomDBType.Cursor;
			//			s_Cursor.Direction = ParameterDirection.Output;
			//			s_Cursor.Index = CollezioneControlli.Count;
			//			CollezioneControlli.Add(s_Cursor);

			ApplicationDataLayer.OracleDataLayer _OraDl = new OracleDataLayer(s_ConnStr);
			string s_StrSql = "PACK_CPERIODICI_SFOGLIA.GETWRCP_SF";	
			DataSet _Ds = _OraDl.GetRows(CollezioneControlli, s_StrSql).Copy();			

			return _Ds;	
		}


		public DataSet GETWRCP_SF_BL(S_ControlsCollection CollezioneControlli)
		{
		

			//			S_Controls.Collections.S_Object s_Cursor = new S_Object();
			//			s_Cursor.ParameterName = "IO_CURSOR";
			//			s_Cursor.DbType = CustomDBType.Cursor;
			//			s_Cursor.Direction = ParameterDirection.Output;
			//			s_Cursor.Index = CollezioneControlli.Count;
			//			CollezioneControlli.Add(s_Cursor);

			ApplicationDataLayer.OracleDataLayer _OraDl = new OracleDataLayer(s_ConnStr);
			string s_StrSql = "PACK_CPERIODICI_SFOGLIA.GETWRCP_SF_BL";	
			DataSet _Ds = _OraDl.GetRows(CollezioneControlli, s_StrSql).Copy();			

			return _Ds;	
		}

		
		public DataSet GETWRCP_SF_(S_ControlsCollection CollezioneControlli)
		{
		

			//			S_Controls.Collections.S_Object s_Cursor = new S_Object();
			//			s_Cursor.ParameterName = "IO_CURSOR";
			//			s_Cursor.DbType = CustomDBType.Cursor;
			//			s_Cursor.Direction = ParameterDirection.Output;
			//			s_Cursor.Index = CollezioneControlli.Count;
			//			CollezioneControlli.Add(s_Cursor);

			ApplicationDataLayer.OracleDataLayer _OraDl = new OracleDataLayer(s_ConnStr);
			string s_StrSql = "PACK_CPERIODICI_SFOGLIA.GETWRCP_SF_";	
			DataSet _Ds = _OraDl.GetRows(CollezioneControlli, s_StrSql).Copy();			

			return _Ds;	
		}

		public DataSet GETWRCP_SF_EQ(S_ControlsCollection CollezioneControlli)
		{
		

			//			S_Controls.Collections.S_Object s_Cursor = new S_Object();
			//			s_Cursor.ParameterName = "IO_CURSOR";
			//			s_Cursor.DbType = CustomDBType.Cursor;
			//			s_Cursor.Direction = ParameterDirection.Output;
			//			s_Cursor.Index = CollezioneControlli.Count;
			//			CollezioneControlli.Add(s_Cursor);

			ApplicationDataLayer.OracleDataLayer _OraDl = new OracleDataLayer(s_ConnStr);
			string s_StrSql = "PACK_CPERIODICI_SFOGLIA.GETWRCP_SF_EQ";	
			DataSet _Ds = _OraDl.GetRows(CollezioneControlli, s_StrSql).Copy();			

			return _Ds;	
		}

		public DataSet GETWRCP_rv(int wr_id)
		{
			S_ControlsCollection CollezioneControlli=new S_ControlsCollection();

			S_Controls.Collections.S_Object s_p_id_wr_cp = new S_Object();
			s_p_id_wr_cp.ParameterName = "p_id_wr_cp";
			s_p_id_wr_cp.DbType = CustomDBType.Integer;
			s_p_id_wr_cp.Direction = ParameterDirection.Input;
			s_p_id_wr_cp.Index = 0;
			s_p_id_wr_cp.Value=wr_id;
			CollezioneControlli.Add(s_p_id_wr_cp);


			S_Controls.Collections.S_Object s_Cursor = new S_Object();
			s_Cursor.ParameterName = "IO_CURSOR";
			s_Cursor.DbType = CustomDBType.Cursor;
			s_Cursor.Direction = ParameterDirection.Output;
			s_Cursor.Index = CollezioneControlli.Count;
			
			CollezioneControlli.Add(s_Cursor);

			ApplicationDataLayer.OracleDataLayer _OraDl = new OracleDataLayer(s_ConnStr);
			string s_StrSql = "PACK_CPERIODICI_SFOGLIA.SELECT_CP";	
			DataSet _Ds = _OraDl.GetRows(CollezioneControlli, s_StrSql).Copy();			

			return _Ds;	
		}
		
		public DataSet GetDettailSingleRdl(int wo_id)
		{
			S_ControlsCollection CollezioneControlli=new S_ControlsCollection();

			S_Controls.Collections.S_Object s_p_wo_id = new S_Object();
			s_p_wo_id.ParameterName = "p_wo_id";
			s_p_wo_id.DbType = CustomDBType.Integer;
			s_p_wo_id.Direction = ParameterDirection.Input;
			s_p_wo_id.Index = CollezioneControlli.Count + 1;
			s_p_wo_id.Value=wo_id;
			CollezioneControlli.Add(s_p_wo_id);


			S_Controls.Collections.S_Object s_Cursor = new S_Object();
			s_Cursor.ParameterName = "IO_CURSOR";
			s_Cursor.DbType = CustomDBType.Cursor;
			s_Cursor.Direction = ParameterDirection.Output;
			s_Cursor.Index = CollezioneControlli.Count + 1;

			CollezioneControlli.Add(s_Cursor);

			ApplicationDataLayer.OracleDataLayer _OraDl = new OracleDataLayer(s_ConnStr);
			string s_StrSql = "PACK_ORDINARIA_SFOGLIA.SP_PASSIWR";	
			DataSet _Ds = _OraDl.GetRows(CollezioneControlli, s_StrSql).Copy();			

			return _Ds;	
		}
		public DataSet GetDettailSingleRdl1(int wo_id)
		{
			S_ControlsCollection CollezioneControlli=new S_ControlsCollection();

			S_Controls.Collections.S_Object s_p_wo_id = new S_Object();
			s_p_wo_id.ParameterName = "p_wo_id";
			s_p_wo_id.DbType = CustomDBType.Integer;
			s_p_wo_id.Direction = ParameterDirection.Input;
			s_p_wo_id.Index = CollezioneControlli.Count + 1;
			s_p_wo_id.Value=wo_id;
			CollezioneControlli.Add(s_p_wo_id);


			S_Controls.Collections.S_Object s_Cursor = new S_Object();
			s_Cursor.ParameterName = "IO_CURSOR";
			s_Cursor.DbType = CustomDBType.Cursor;
			s_Cursor.Direction = ParameterDirection.Output;
			s_Cursor.Index = CollezioneControlli.Count + 1;

			CollezioneControlli.Add(s_Cursor);

			ApplicationDataLayer.OracleDataLayer _OraDl = new OracleDataLayer(s_ConnStr);
			string s_StrSql = "PACK_ORDINARIA_SFOGLIA.SP_PASSIWR1";	
			DataSet _Ds = _OraDl.GetRows(CollezioneControlli, s_StrSql).Copy();			

			return _Ds;	
		}
		#region Metodi Private

		protected override int ExecuteUpdate(S_ControlsCollection CollezioneControlli, ExecuteType Operazione, int itemId)
		{
			return 0;
		}

		#endregion
	}


}
