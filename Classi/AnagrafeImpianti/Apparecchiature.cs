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

namespace TheSite.Classi.AnagrafeImpianti
{
	/// <summary>
	/// Descrizione di riepilogo per Apparecchiature.
	/// Autore Fabio Civerchia
	/// </summary>
	public class Apparecchiature : AbstractBase
	{
		private string s_username;
		public Apparecchiature(string Username)
		{
			this.s_username = Username;
		}
		public Apparecchiature()
		{

		}
		public DataSet GetReport(int TipoReport, int bl_id)
		{
			DataSet _Ds;

			S_ControlsCollection CollezioneControlli = new S_ControlsCollection();

			if (TipoReport == 0)
			{
				S_Controls.Collections.S_Object p_blid = new S_Object();
				p_blid.ParameterName = "p_bl_Id";
				p_blid.DbType = CustomDBType.Integer;
				p_blid.Direction = ParameterDirection.Input;
				p_blid.Index = CollezioneControlli.Count;
				p_blid.Value = bl_id;
				CollezioneControlli.Add(p_blid);

			}
			if (TipoReport == 1 || TipoReport == 2 || TipoReport == 0)
			{
				S_Controls.Collections.S_Object s_UserName = new S_Object();
				s_UserName.ParameterName = "p_UserName";
				s_UserName.DbType = CustomDBType.VarChar;
				s_UserName.Direction = ParameterDirection.Input;
				s_UserName.Index = CollezioneControlli.Count;
				s_UserName.Value = this.s_username;
				s_UserName.Size = 50;
				CollezioneControlli.Add(s_UserName);
			}

			S_Controls.Collections.S_Object s_Cursor = new S_Object();
			s_Cursor.ParameterName = "IO_CURSOR";
			s_Cursor.DbType = CustomDBType.Cursor;
			s_Cursor.Direction = ParameterDirection.Output;
			s_Cursor.Index = CollezioneControlli.Count;
			CollezioneControlli.Add(s_Cursor);

			ApplicationDataLayer.OracleDataLayer _OraDl = new OracleDataLayer(s_ConnStr);
			string s_StrSql = "";
			if (TipoReport == 0)
				s_StrSql = "PACK_APPARECCHIATURE.SP_GETSTD1";
			if (TipoReport == 1)
				s_StrSql = "PACK_APPARECCHIATURE.SP_GETSTD2";
			if (TipoReport == 2)
				s_StrSql = "PACK_APPARECCHIATURE.SP_GETSTD3";
			if (TipoReport == 3)
				s_StrSql = "PACK_APPARECCHIATURE.SP_GETSTD4";
			if (TipoReport == 4)
				s_StrSql = "PACK_APPARECCHIATURE.SP_GETSTD5";


			_Ds = _OraDl.GetRows(CollezioneControlli, s_StrSql).Copy();

			return _Ds;
		}

		public DataSet GetReport_(int TipoReport, int bl_id, int servizio, int stdapparato)
		{
			DataSet _Ds;

			S_ControlsCollection CollezioneControlli = new S_ControlsCollection();

			if (TipoReport == 0)
			{
				S_Controls.Collections.S_Object p_blid = new S_Object();
				p_blid.ParameterName = "p_bl_Id";
				p_blid.DbType = CustomDBType.Integer;
				p_blid.Direction = ParameterDirection.Input;
				p_blid.Index = CollezioneControlli.Count;
				p_blid.Value = bl_id;
				CollezioneControlli.Add(p_blid);

			}
			if (TipoReport == 1 || TipoReport == 0)
			{
				S_Controls.Collections.S_Object s_UserName = new S_Object();
				s_UserName.ParameterName = "p_UserName";
				s_UserName.DbType = CustomDBType.VarChar;
				s_UserName.Direction = ParameterDirection.Input;
				s_UserName.Index = CollezioneControlli.Count;
				s_UserName.Value = this.s_username;
				s_UserName.Size = 50;
				CollezioneControlli.Add(s_UserName);
			}

			if (TipoReport == 2)
			{


				S_Controls.Collections.S_Object p_idservizio = new S_Object();
				p_idservizio.ParameterName = "p_idservizio";
				p_idservizio.DbType = CustomDBType.Integer;
				p_idservizio.Direction = ParameterDirection.Input;
				p_idservizio.Index = CollezioneControlli.Count;
				p_idservizio.Value = servizio;
				CollezioneControlli.Add(p_idservizio);


				S_Controls.Collections.S_Object p_stdapparato = new S_Object();
				p_stdapparato.ParameterName = "p_stdapparato";
				p_stdapparato.DbType = CustomDBType.Integer;
				p_stdapparato.Direction = ParameterDirection.Input;
				p_stdapparato.Index = CollezioneControlli.Count;
				p_stdapparato.Value = stdapparato;
				CollezioneControlli.Add(p_stdapparato);

				S_Controls.Collections.S_Object s_UserName = new S_Object();
				s_UserName.ParameterName = "p_UserName";
				s_UserName.DbType = CustomDBType.VarChar;
				s_UserName.Direction = ParameterDirection.Input;
				s_UserName.Index = CollezioneControlli.Count;
				s_UserName.Value = this.s_username;
				s_UserName.Size = 50;
				CollezioneControlli.Add(s_UserName);



			}

			S_Controls.Collections.S_Object s_Cursor = new S_Object();
			s_Cursor.ParameterName = "IO_CURSOR";
			s_Cursor.DbType = CustomDBType.Cursor;
			s_Cursor.Direction = ParameterDirection.Output;
			s_Cursor.Index = CollezioneControlli.Count;
			CollezioneControlli.Add(s_Cursor);

			ApplicationDataLayer.OracleDataLayer _OraDl = new OracleDataLayer(s_ConnStr);
			string s_StrSql = "";
			if (TipoReport == 0)
				s_StrSql = "PACK_APPARECCHIATURE.SP_GETSTD1";
			if (TipoReport == 1)
				s_StrSql = "PACK_APPARECCHIATURE.SP_GETSTD2";
			if (TipoReport == 2)
				s_StrSql = "PACK_APPARECCHIATURE.SP_GETSTD3__";
			if (TipoReport == 3)
				s_StrSql = "PACK_APPARECCHIATURE.SP_GETSTD4";
			if (TipoReport == 4)
				s_StrSql = "PACK_APPARECCHIATURE.SP_GETSTD5";


			_Ds = _OraDl.GetRows(CollezioneControlli, s_StrSql).Copy();

			return _Ds;
		}


		/// <summary>
		/// Metodo che recupera tutte le apparecchiature legate ad l'utente loggato
		/// Viene eseguita all'ingresso di ogni pagina la prima volta
		/// </summary>
		/// <returns></returns>
		public override DataSet GetData()
		{
			DataSet _Ds;

			S_ControlsCollection CollezioneControlli = new S_ControlsCollection();

			S_Controls.Collections.S_Object s_UserName = new S_Object();
			s_UserName.ParameterName = "p_UserName";
			s_UserName.DbType = CustomDBType.VarChar;
			s_UserName.Direction = ParameterDirection.Input;
			s_UserName.Index = 0;
			s_UserName.Value = this.s_username;
			s_UserName.Size = 50;

			S_Controls.Collections.S_Object s_Cursor = new S_Object();
			s_Cursor.ParameterName = "IO_CURSOR";
			s_Cursor.DbType = CustomDBType.Cursor;
			s_Cursor.Direction = ParameterDirection.Output;
			s_Cursor.Index = 1;

			CollezioneControlli.Add(s_UserName);
			CollezioneControlli.Add(s_Cursor);

			ApplicationDataLayer.OracleDataLayer _OraDl = new OracleDataLayer(s_ConnStr);
			string s_StrSql = "PACK_APPARECCHIATURE.SP_GETSTDALLAPPARECCHIATURA";
			_Ds = _OraDl.GetRows(CollezioneControlli, s_StrSql).Copy();

			return _Ds;
		}

		/// <summary>
		/// Metodo che recupera tutte le apparecchiature legate ad l'utente loggato
		/// 
		/// Viene eseguita all'ingresso di ogni pagina la prima volta
		/// </summary>
		/// <param name="CollezioneControlli"> Accetta due parametri in ingressi che sono p_Servizio di tipo number
		/// che indica il servizio e  p_Bl_Id di tipo varchar2 che indica l'edificio
		///  </param>
		/// <returns></returns>
		public override DataSet GetData(S_ControlsCollection CollezioneControlli)
		{
			DataSet _Ds;

			S_Controls.Collections.S_Object s_UserName = new S_Object();
			s_UserName.ParameterName = "p_UserName";
			s_UserName.DbType = CustomDBType.VarChar;
			s_UserName.Direction = ParameterDirection.Input;
			s_UserName.Index = CollezioneControlli.Count + 1;
			s_UserName.Value = this.s_username;
			s_UserName.Size = 50;
			CollezioneControlli.Add(s_UserName);

			S_Controls.Collections.S_Object s_Cursor = new S_Object();
			s_Cursor.ParameterName = "IO_CURSOR";
			s_Cursor.DbType = CustomDBType.Cursor;
			s_Cursor.Direction = ParameterDirection.Output;
			s_Cursor.Index = CollezioneControlli.Count + 1;

			CollezioneControlli.Add(s_Cursor);

			ApplicationDataLayer.OracleDataLayer _OraDl = new OracleDataLayer(s_ConnStr);
			string s_StrSql = "PACK_APPARECCHIATURE.SP_GETSTDAPPARECCHIATURE";
			_Ds = _OraDl.GetRows(CollezioneControlli, s_StrSql).Copy();

			return _Ds;
		}

		public DataSet GetDataServizi(S_ControlsCollection CollezioneControlli)
		{
			DataSet _Ds;

			S_Controls.Collections.S_Object s_UserName = new S_Object();
			s_UserName.ParameterName = "p_UserName";
			s_UserName.DbType = CustomDBType.VarChar;
			s_UserName.Direction = ParameterDirection.Input;
			s_UserName.Index = CollezioneControlli.Count + 1;
			s_UserName.Value = this.s_username;
			s_UserName.Size = 50;
			CollezioneControlli.Add(s_UserName);

			S_Controls.Collections.S_Object s_Cursor = new S_Object();
			s_Cursor.ParameterName = "IO_CURSOR";
			s_Cursor.DbType = CustomDBType.Cursor;
			s_Cursor.Direction = ParameterDirection.Output;
			s_Cursor.Index = CollezioneControlli.Count + 1;

			CollezioneControlli.Add(s_Cursor);

			ApplicationDataLayer.OracleDataLayer _OraDl = new OracleDataLayer(s_ConnStr);
			string s_StrSql = "PACK_APPARECCHIATURE.SP_GETSTDSERVIZIO";
			_Ds = _OraDl.GetRows(CollezioneControlli, s_StrSql).Copy();

			return _Ds;
		}

		public DataSet GetAppDataServizi(string eqstd_id)
		{
			DataSet _Ds;
			S_ControlsCollection CollezioneControlli = new S_ControlsCollection();
			S_Controls.Collections.S_Object s_p_eqstd_id = new S_Object();
			s_p_eqstd_id.ParameterName = "p_eqstd_id";
			s_p_eqstd_id.DbType = CustomDBType.VarChar;
			s_p_eqstd_id.Direction = ParameterDirection.Input;
			s_p_eqstd_id.Index = 0;
			s_p_eqstd_id.Value = eqstd_id;
			s_p_eqstd_id.Size = 50;
			CollezioneControlli.Add(s_p_eqstd_id);

			S_Controls.Collections.S_Object s_Cursor = new S_Object();
			s_Cursor.ParameterName = "IO_CURSOR";
			s_Cursor.DbType = CustomDBType.Cursor;
			s_Cursor.Direction = ParameterDirection.Output;
			s_Cursor.Index = CollezioneControlli.Count;

			CollezioneControlli.Add(s_Cursor);

			ApplicationDataLayer.OracleDataLayer _OraDl = new OracleDataLayer(s_ConnStr);
			string s_StrSql = "PACK_APPARECCHIATURE.GETSERVIZIOSTD";
			_Ds = _OraDl.GetRows(CollezioneControlli, s_StrSql).Copy();

			return _Ds;
		}


		public DataSet GetDataServizi_APP(S_ControlsCollection CollezioneControlli)
		{
			DataSet _Ds;

			S_Controls.Collections.S_Object s_UserName = new S_Object();
			s_UserName.ParameterName = "p_UserName";
			s_UserName.DbType = CustomDBType.VarChar;
			s_UserName.Direction = ParameterDirection.Input;
			s_UserName.Index = CollezioneControlli.Count + 1;
			s_UserName.Value = this.s_username;
			s_UserName.Size = 50;
			CollezioneControlli.Add(s_UserName);

			S_Controls.Collections.S_Object s_Cursor = new S_Object();
			s_Cursor.ParameterName = "IO_CURSOR";
			s_Cursor.DbType = CustomDBType.Cursor;
			s_Cursor.Direction = ParameterDirection.Output;
			s_Cursor.Index = CollezioneControlli.Count + 1;

			CollezioneControlli.Add(s_Cursor);

			ApplicationDataLayer.OracleDataLayer _OraDl = new OracleDataLayer(s_ConnStr);
			string s_StrSql = "PACK_APPARECCHIATURE.SP_GETSTDSERVIZIO_APP";
			_Ds = _OraDl.GetRows(CollezioneControlli, s_StrSql).Copy();

			return _Ds;
		}



		public DataSet RicercaAppar(S_ControlsCollection CollezioneControlli)
		{
			DataSet _Ds;

			S_Controls.Collections.S_Object s_UserName = new S_Object();
			s_UserName.ParameterName = "p_UserName";
			s_UserName.DbType = CustomDBType.VarChar;
			s_UserName.Direction = ParameterDirection.Input;
			s_UserName.Index = CollezioneControlli.Count + 1;
			s_UserName.Value = this.s_username;
			s_UserName.Size = 50;
			CollezioneControlli.Add(s_UserName);

			S_Controls.Collections.S_Object s_Cursor = new S_Object();
			s_Cursor.ParameterName = "IO_CURSOR";
			s_Cursor.DbType = CustomDBType.Cursor;
			s_Cursor.Direction = ParameterDirection.Output;
			s_Cursor.Index = CollezioneControlli.Count + 1;
			CollezioneControlli.Add(s_Cursor);

			ApplicationDataLayer.OracleDataLayer _OraDl = new OracleDataLayer(s_ConnStr);
			string s_StrSql = "PACK_APPARECCHIATURE.SP_RICERCAAPPAR";
			_Ds = _OraDl.GetRows(CollezioneControlli, s_StrSql).Copy();

			return _Ds;
		}
		/// <summary>
		/// Ricerca una determinata apparecchiatura
		/// </summary>
		/// <param name="CollezioneControlli">I parametri che devono essere passati sono:
		/// p_Bl_Id di tipo varchar2,
		///p_campus di tipo  varchar2,
		///p_Servizio di tipo number,
		///p_eqstd di tipo varchar2,
		///p_eqid di tipo Varchar2
		/// </param>
		/// <returns></returns>
		public DataSet RicercaApparecchiatura(S_ControlsCollection CollezioneControlli)
		{
			DataSet _Ds;

			S_Controls.Collections.S_Object s_UserName = new S_Object();
			s_UserName.ParameterName = "p_UserName";
			s_UserName.DbType = CustomDBType.VarChar;
			s_UserName.Direction = ParameterDirection.Input;
			s_UserName.Index = CollezioneControlli.Count;
			s_UserName.Value = this.s_username;
			s_UserName.Size = 50;
			CollezioneControlli.Add(s_UserName);

			S_Controls.Collections.S_Object s_Cursor = new S_Object();
			s_Cursor.ParameterName = "IO_CURSOR";
			s_Cursor.DbType = CustomDBType.Cursor;
			s_Cursor.Direction = ParameterDirection.Output;
			s_Cursor.Index = CollezioneControlli.Count;
			CollezioneControlli.Add(s_Cursor);

			ApplicationDataLayer.OracleDataLayer _OraDl = new OracleDataLayer(s_ConnStr);
			string s_StrSql = "PACK_APPARECCHIATURE.SP_RICERCAAPPARECCHIATURA";
			_Ds = _OraDl.GetRows(CollezioneControlli, s_StrSql).Copy();

			return _Ds;
		}
		public DataSet RicercApparecchiatura(S_ControlsCollection CollezioneControlli)
		{
			DataSet _Ds;

			S_Controls.Collections.S_Object s_UserName = new S_Object();
			s_UserName.ParameterName = "p_UserName";
			s_UserName.DbType = CustomDBType.VarChar;
			s_UserName.Direction = ParameterDirection.Input;
			s_UserName.Index = CollezioneControlli.Count;
			s_UserName.Value = this.s_username;
			s_UserName.Size = 50;
			CollezioneControlli.Add(s_UserName);

			S_Controls.Collections.S_Object s_Cursor = new S_Object();
			s_Cursor.ParameterName = "IO_CURSOR";
			s_Cursor.DbType = CustomDBType.Cursor;
			s_Cursor.Direction = ParameterDirection.Output;
			s_Cursor.Index = CollezioneControlli.Count;
			CollezioneControlli.Add(s_Cursor);

			ApplicationDataLayer.OracleDataLayer _OraDl = new OracleDataLayer(s_ConnStr);
			string s_StrSql = "PACK_APPARECCHIATURE.SP_RICERCAPPARECCHIATURA";
			_Ds = _OraDl.GetRows(CollezioneControlli, s_StrSql).Copy();

			return _Ds;
		}
		public int RicercaApparecchiaturaCount(S_ControlsCollection CollezioneControlli)
		{
			DataSet _Ds;

			S_Controls.Collections.S_Object s_UserName = new S_Object();
			s_UserName.ParameterName = "p_UserName";
			s_UserName.DbType = CustomDBType.VarChar;
			s_UserName.Direction = ParameterDirection.Input;
			s_UserName.Index = CollezioneControlli.Count;
			s_UserName.Value = this.s_username;
			s_UserName.Size = 50;
			CollezioneControlli.Add(s_UserName);

			S_Controls.Collections.S_Object s_Cursor = new S_Object();
			s_Cursor.ParameterName = "IO_CURSOR";
			s_Cursor.DbType = CustomDBType.Cursor;
			s_Cursor.Direction = ParameterDirection.Output;
			s_Cursor.Index = CollezioneControlli.Count;
			CollezioneControlli.Add(s_Cursor);

			ApplicationDataLayer.OracleDataLayer _OraDl = new OracleDataLayer(s_ConnStr);
			string s_StrSql = "PACK_APPARECCHIATURE.SP_RICERCAAPPARECCHIATURACount";
			_Ds = _OraDl.GetRows(CollezioneControlli, s_StrSql).Copy();

			return int.Parse(_Ds.Tables[0].Rows[0][0].ToString());
		}
		public int RicercApparecchiaturaCount(S_ControlsCollection CollezioneControlli)
		{
			DataSet _Ds;

			S_Controls.Collections.S_Object s_UserName = new S_Object();
			s_UserName.ParameterName = "p_UserName";
			s_UserName.DbType = CustomDBType.VarChar;
			s_UserName.Direction = ParameterDirection.Input;
			s_UserName.Index = CollezioneControlli.Count;
			s_UserName.Value = this.s_username;
			s_UserName.Size = 50;
			CollezioneControlli.Add(s_UserName);

			S_Controls.Collections.S_Object s_Cursor = new S_Object();
			s_Cursor.ParameterName = "IO_CURSOR";
			s_Cursor.DbType = CustomDBType.Cursor;
			s_Cursor.Direction = ParameterDirection.Output;
			s_Cursor.Index = CollezioneControlli.Count;
			CollezioneControlli.Add(s_Cursor);

			ApplicationDataLayer.OracleDataLayer _OraDl = new OracleDataLayer(s_ConnStr);
			string s_StrSql = "PACK_APPARECCHIATURE.SP_RICERCAPPARECCHIATURACount";
			_Ds = _OraDl.GetRows(CollezioneControlli, s_StrSql).Copy();

			return int.Parse(_Ds.Tables[0].Rows[0][0].ToString());
		}
		public DataSet RicercaApparecchiaturaExcel(S_ControlsCollection CollezioneControlli)
		{
			DataSet _Ds;

			S_Controls.Collections.S_Object s_UserName = new S_Object();
			s_UserName.ParameterName = "p_UserName";
			s_UserName.DbType = CustomDBType.VarChar;
			s_UserName.Direction = ParameterDirection.Input;
			s_UserName.Index = CollezioneControlli.Count + 1;
			s_UserName.Value = this.s_username;
			s_UserName.Size = 50;
			CollezioneControlli.Add(s_UserName);

			S_Controls.Collections.S_Object s_Cursor = new S_Object();
			s_Cursor.ParameterName = "IO_CURSOR";
			s_Cursor.DbType = CustomDBType.Cursor;
			s_Cursor.Direction = ParameterDirection.Output;
			s_Cursor.Index = CollezioneControlli.Count + 1;
			CollezioneControlli.Add(s_Cursor);

			ApplicationDataLayer.OracleDataLayer _OraDl = new OracleDataLayer(s_ConnStr);
			string s_StrSql = "PACK_APPARECCHIATURE.SP_RICERCAAPPARECCHIATURAExcel";
			_Ds = _OraDl.GetRows(CollezioneControlli, s_StrSql).Copy();

			return _Ds;
		}


		public DataSet RicercaAttPMPExcel(S_ControlsCollection CollezioneControlli)
		{
			DataSet _Ds;

			//			S_Controls.Collections.S_Object s_UserName = new S_Object();
			//			s_UserName.ParameterName = "p_UserName";
			//			s_UserName.DbType = CustomDBType.VarChar;
			//			s_UserName.Direction = ParameterDirection.Input;
			//			s_UserName.Index = CollezioneControlli.Count ;
			//			s_UserName.Value = System.Web.HttpContext.Current.User.Identity.Name;			
			//			s_UserName.Size = 50;
			//			CollezioneControlli.Add(s_UserName);


			S_Controls.Collections.S_Object s_Cursor = new S_Object();
			s_Cursor.ParameterName = "IO_CURSOR";
			s_Cursor.DbType = CustomDBType.Cursor;
			s_Cursor.Direction = ParameterDirection.Output;
			s_Cursor.Index = CollezioneControlli.Count;
			CollezioneControlli.Add(s_Cursor);

			ApplicationDataLayer.OracleDataLayer _OraDl = new OracleDataLayer(s_ConnStr);
			string s_StrSql = "PACK_MAN_PROG.SP_RICERCAATTPIANIFICATE";
			_Ds = _OraDl.GetRows(CollezioneControlli, s_StrSql).Copy();

			return _Ds;
		}

		/// <summary>
		/// Ricerca una determinata apparecchiatura con Piano e Stanza
		/// </summary>
		/// <param name="CollezioneControlli">I parametri che devono essere passati sono:
		/// p_Bl_Id di tipo varchar2,
		///p_campus di tipo  varchar2,
		///p_Servizio di tipo number,
		///p_eqstd di tipo varchar2,
		///p_eqid di tipo Varchar2
		///p_piano integer
		///p_stanza integer
		/// </param>
		/// <returns></returns>
		public DataSet RicercaApparecchiaturaPS(S_ControlsCollection CollezioneControlli)
		{
			DataSet _Ds;

			S_Controls.Collections.S_Object s_UserName = new S_Object();
			s_UserName.ParameterName = "p_UserName";
			s_UserName.DbType = CustomDBType.VarChar;
			s_UserName.Direction = ParameterDirection.Input;
			s_UserName.Index = CollezioneControlli.Count;
			s_UserName.Value = this.s_username;
			s_UserName.Size = 50;
			CollezioneControlli.Add(s_UserName);

			S_Controls.Collections.S_Object s_Cursor = new S_Object();
			s_Cursor.ParameterName = "IO_CURSOR";
			s_Cursor.DbType = CustomDBType.Cursor;
			s_Cursor.Direction = ParameterDirection.Output;
			s_Cursor.Index = CollezioneControlli.Count;
			CollezioneControlli.Add(s_Cursor);

			ApplicationDataLayer.OracleDataLayer _OraDl = new OracleDataLayer(s_ConnStr);
			string s_StrSql = "PACK_APPARECCHIATURE.SP_RICERCAAPPARECCHIATURAPS";
			_Ds = _OraDl.GetRows(CollezioneControlli, s_StrSql).Copy();

			return _Ds;
		}

		public int RicercaApparecchiaturaPSCount(S_ControlsCollection CollezioneControlli)
		{
			DataSet _Ds;

			S_Controls.Collections.S_Object s_UserName = new S_Object();
			s_UserName.ParameterName = "p_UserName";
			s_UserName.DbType = CustomDBType.VarChar;
			s_UserName.Direction = ParameterDirection.Input;
			s_UserName.Index = CollezioneControlli.Count;
			s_UserName.Value = this.s_username;
			s_UserName.Size = 50;
			CollezioneControlli.Add(s_UserName);

			S_Controls.Collections.S_Object s_Cursor = new S_Object();
			s_Cursor.ParameterName = "IO_CURSOR";
			s_Cursor.DbType = CustomDBType.Cursor;
			s_Cursor.Direction = ParameterDirection.Output;
			s_Cursor.Index = CollezioneControlli.Count;
			CollezioneControlli.Add(s_Cursor);

			ApplicationDataLayer.OracleDataLayer _OraDl = new OracleDataLayer(s_ConnStr);
			string s_StrSql = "PACK_APPARECCHIATURE.SP_RICERCA_APP_PS_Count";
			_Ds = _OraDl.GetRows(CollezioneControlli, s_StrSql).Copy();

			return int.Parse(_Ds.Tables[0].Rows[0][0].ToString());
		}
		public DataSet GetSfogliaRDLEQ(S_ControlsCollection CollezioneControlli, int pageIndex, int pageSize)
		{
			DataSet _Ds;

			S_Controls.Collections.S_Object s_IdIn = new S_Object();
			s_IdIn.ParameterName = "p_utente";
			s_IdIn.DbType = CustomDBType.VarChar;
			s_IdIn.Direction = ParameterDirection.Input;
			s_IdIn.Index = CollezioneControlli.Count;
			s_IdIn.Value = System.Web.HttpContext.Current.User.Identity.Name;

			CollezioneControlli.Add(s_IdIn);

			//			S_Controls.Collections.S_Object s_pageindex = new S_Object();
			//			s_pageindex.ParameterName = "p_pageindex";
			//			s_pageindex.DbType = CustomDBType.Integer;
			//			s_pageindex.Direction = ParameterDirection.Input;
			//			s_pageindex.Index = CollezioneControlli.Count + 1;
			//			s_pageindex.Value = pageIndex;
			//
			//			CollezioneControlli.Add(s_pageindex);
			//
			//			S_Controls.Collections.S_Object s_pagesize = new S_Object();
			//			s_pagesize.ParameterName = "p_pagesize";
			//			s_pagesize.DbType = CustomDBType.Integer;
			//			s_pagesize.Direction = ParameterDirection.Input;
			//			s_pagesize.Index = CollezioneControlli.Count + 1;
			//			s_pagesize.Value = pageSize;
			//
			//			CollezioneControlli.Add(s_pagesize);

			S_Controls.Collections.S_Object s_Cursor = new S_Object();
			s_Cursor.ParameterName = "IO_CURSOR";
			s_Cursor.DbType = CustomDBType.Cursor;
			s_Cursor.Direction = ParameterDirection.Output;
			s_Cursor.Index = CollezioneControlli.Count;
			CollezioneControlli.Add(s_Cursor);

			ApplicationDataLayer.OracleDataLayer _OraDl = new OracleDataLayer(s_ConnStr);
			string s_StrSql;
			s_StrSql = "PACK_APPARECCHIATURE.SP_GetSfogliaRDLEQ";
			_Ds = _OraDl.GetRows(CollezioneControlli, s_StrSql).Copy();

			return _Ds;

		}

		public DataSet GetTotRDLEQ(S_ControlsCollection CollezioneControlli, int pageIndex, int pageSize)
		{
			DataSet _Ds;

			S_Controls.Collections.S_Object s_IdIn = new S_Object();
			s_IdIn.ParameterName = "p_utente";
			s_IdIn.DbType = CustomDBType.VarChar;
			s_IdIn.Direction = ParameterDirection.Input;
			s_IdIn.Index = CollezioneControlli.Count + 1;
			s_IdIn.Value = System.Web.HttpContext.Current.User.Identity.Name;

			CollezioneControlli.Add(s_IdIn);

			S_Controls.Collections.S_Object s_pageindex = new S_Object();
			s_pageindex.ParameterName = "p_pageindex";
			s_pageindex.DbType = CustomDBType.Integer;
			s_pageindex.Direction = ParameterDirection.Input;
			s_pageindex.Index = CollezioneControlli.Count + 1;
			s_pageindex.Value = pageIndex;

			CollezioneControlli.Add(s_pageindex);

			S_Controls.Collections.S_Object s_pagesize = new S_Object();
			s_pagesize.ParameterName = "p_pagesize";
			s_pagesize.DbType = CustomDBType.Integer;
			s_pagesize.Direction = ParameterDirection.Input;
			s_pagesize.Index = CollezioneControlli.Count + 1;
			s_pagesize.Value = pageSize;

			CollezioneControlli.Add(s_pagesize);

			S_Controls.Collections.S_Object s_Cursor = new S_Object();
			s_Cursor.ParameterName = "IO_CURSOR";
			s_Cursor.DbType = CustomDBType.Cursor;
			s_Cursor.Direction = ParameterDirection.Output;
			s_Cursor.Index = CollezioneControlli.Count + 1;
			CollezioneControlli.Add(s_Cursor);

			ApplicationDataLayer.OracleDataLayer _OraDl = new OracleDataLayer(s_ConnStr);
			string s_StrSql;
			s_StrSql = "PACK_APPARECCHIATURE.SP_GetTOTRDLEQ";
			_Ds = _OraDl.GetRows(CollezioneControlli, s_StrSql).Copy();

			return _Ds;

		}

		public DataSet GetSfogliaRDLEQ(S_ControlsCollection CollezioneControlli)
		{
			DataSet _Ds;

			S_Controls.Collections.S_Object s_IdIn = new S_Object();
			s_IdIn.ParameterName = "p_utente";
			s_IdIn.DbType = CustomDBType.VarChar;
			s_IdIn.Direction = ParameterDirection.Input;
			s_IdIn.Index = CollezioneControlli.Count + 1;
			s_IdIn.Value = System.Web.HttpContext.Current.User.Identity.Name;

			CollezioneControlli.Add(s_IdIn);

			S_Controls.Collections.S_Object s_Cursor = new S_Object();
			s_Cursor.ParameterName = "IO_CURSOR";
			s_Cursor.DbType = CustomDBType.Cursor;
			s_Cursor.Direction = ParameterDirection.Output;
			s_Cursor.Index = CollezioneControlli.Count + 1;
			CollezioneControlli.Add(s_Cursor);

			ApplicationDataLayer.OracleDataLayer _OraDl = new OracleDataLayer(s_ConnStr);
			string s_StrSql = "PACK_APPARECCHIATURE.SP_GetSfogliaRDLEQ";
			_Ds = _OraDl.GetRows(CollezioneControlli, s_StrSql).Copy();

			return _Ds;

		}

		public override DataSet GetSingleData(int itemId)
		{
			return null;
		}

		#region Metodi Private

		protected override int ExecuteUpdate(S_ControlsCollection CollezioneControlli, ExecuteType Operazione, int itemId)
		{
			return 0;
		}

		#endregion

		public DataSet RicercaStd(S_ControlsCollection CollezioneControlli)
		{
			DataSet _Ds;

			S_Controls.Collections.S_Object s_UserName = new S_Object();
			s_UserName.ParameterName = "p_UserName";
			s_UserName.DbType = CustomDBType.VarChar;
			s_UserName.Direction = ParameterDirection.Input;
			s_UserName.Index = CollezioneControlli.Count;
			s_UserName.Value = this.s_username;
			s_UserName.Size = 50;
			CollezioneControlli.Add(s_UserName);

			S_Controls.Collections.S_Object s_Cursor = new S_Object();
			s_Cursor.ParameterName = "IO_CURSOR";
			s_Cursor.DbType = CustomDBType.Cursor;
			s_Cursor.Direction = ParameterDirection.Output;
			s_Cursor.Index = CollezioneControlli.Count;
			CollezioneControlli.Add(s_Cursor);

			ApplicationDataLayer.OracleDataLayer _OraDl = new OracleDataLayer(s_ConnStr);
			string s_StrSql = "PACK_APPARECCHIATURE.SP_RICERCASTD";
			_Ds = _OraDl.GetRows(CollezioneControlli, s_StrSql).Copy();

			return _Ds;
		}

		public DataSet RicercaStanze(S_ControlsCollection CollezioneControlli)
		{
			DataSet _Ds;


			S_Controls.Collections.S_Object s_Cursor = new S_Object();
			s_Cursor.ParameterName = "IO_CURSOR";
			s_Cursor.DbType = CustomDBType.Cursor;
			s_Cursor.Direction = ParameterDirection.Output;
			s_Cursor.Index = CollezioneControlli.Count;
			CollezioneControlli.Add(s_Cursor);

			ApplicationDataLayer.OracleDataLayer _OraDl = new OracleDataLayer(s_ConnStr);
			string s_StrSql = "PACK_APPARECCHIATURE.SP_GETALLSTANZEPaging";
			_Ds = _OraDl.GetRows(CollezioneControlli, s_StrSql).Copy();

			return _Ds;
		}


		public DataSet RicercaDescStanze(S_ControlsCollection CollezioneControlli)
		{
			DataSet _Ds;


			S_Controls.Collections.S_Object s_Cursor = new S_Object();
			s_Cursor.ParameterName = "IO_CURSOR";
			s_Cursor.DbType = CustomDBType.Cursor;
			s_Cursor.Direction = ParameterDirection.Output;
			s_Cursor.Index = CollezioneControlli.Count;
			CollezioneControlli.Add(s_Cursor);

			ApplicationDataLayer.OracleDataLayer _OraDl = new OracleDataLayer(s_ConnStr);
			string s_StrSql = "PACK_APPARECCHIATURE.SP_GETALLSTANZEProgPaging";
			_Ds = _OraDl.GetRows(CollezioneControlli, s_StrSql).Copy();

			return _Ds;
		}
		public int RicercaStanzeDescCount(S_ControlsCollection CollezioneControlli)
		{
			DataSet _Ds;


			S_Controls.Collections.S_Object s_Cursor = new S_Object();
			s_Cursor.ParameterName = "IO_CURSOR";
			s_Cursor.DbType = CustomDBType.Cursor;
			s_Cursor.Direction = ParameterDirection.Output;
			s_Cursor.Index = CollezioneControlli.Count;
			CollezioneControlli.Add(s_Cursor);

			ApplicationDataLayer.OracleDataLayer _OraDl = new OracleDataLayer(s_ConnStr);
			string s_StrSql = "PACK_APPARECCHIATURE.SP_GETALLSTANZEProgCount";
			_Ds = _OraDl.GetRows(CollezioneControlli, s_StrSql).Copy();

			return int.Parse(_Ds.Tables[0].Rows[0][0].ToString());
		}

		public int RicercaStanzeCount(S_ControlsCollection CollezioneControlli)
		{
			DataSet _Ds;


			S_Controls.Collections.S_Object s_Cursor = new S_Object();
			s_Cursor.ParameterName = "IO_CURSOR";
			s_Cursor.DbType = CustomDBType.Cursor;
			s_Cursor.Direction = ParameterDirection.Output;
			s_Cursor.Index = CollezioneControlli.Count;
			CollezioneControlli.Add(s_Cursor);

			ApplicationDataLayer.OracleDataLayer _OraDl = new OracleDataLayer(s_ConnStr);
			string s_StrSql = "PACK_APPARECCHIATURE.SP_GETALLSTANZECount";
			_Ds = _OraDl.GetRows(CollezioneControlli, s_StrSql).Copy();

			return int.Parse(_Ds.Tables[0].Rows[0][0].ToString());
		}

	}
}
