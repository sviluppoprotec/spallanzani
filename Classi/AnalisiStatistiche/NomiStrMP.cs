using System;

namespace TheSite.Classi.AnalisiStatistiche
{
	/// <summary>
	/// Descrizione di riepilogo per NomiStrMP.
	/// </summary>
	public class NomiStrMP
	{
		public NomiStrMP()
		{
			//
			// TODO: aggiungere qui la logica del costruttore
			//
		}

		

		protected string GET_RDL_MESE_RICHIESTA
		{
			get {return "PACK_ANALISI_STATISTICHE_POI.GET_RDL_MESE_RICHIESTA";}
		}
		protected  string GET_RDL_MESE_ASSEGNATA
		{
			get {return "PACK_ANALISI_STATISTICHE_POI.GET_RDL_MESE_ASSEGNATA";}
		}
		protected string GET_RDL_MESE_COMPLETATA
		{
			get {return "PACK_ANALISI_STATISTICHE_POI.GET_RDL_MESE_COMPLETATA";}
		}
		protected string GET_RDL_DITTA_RICHIESTA
		{
			get {return "PACK_ANALISI_STATISTICHE_POI.GET_RDL_DITTA_RICHIESTA";}
		}
		protected string GET_RDL_DITTA_ASSEGNATA
		{
			get {return "PACK_ANALISI_STATISTICHE_POI.GET_RDL_DITTA_ASSEGNATA";}
		}
		protected string GET_RDL_DITTA_COMPLETATA
		{
			get {return "PACK_ANALISI_STATISTICHE_POI.GET_RDL_DITTA_COMPLETATA";}
		}
		protected string GET_RDL_STATO_RICHIESTA
		{
			get {return "PACK_ANALISI_STATISTICHE_POI.GET_RDL_STATO_RICHIESTA";}
		}
		protected string GET_RDL_STATO_ASSEGNATA
		{
			get {return "PACK_ANALISI_STATISTICHE_POI.GET_RDL_STATO_ASSEGNATA";}
		}
		protected string GET_RDL_STATO_COMPLETATA
		{
			get {return "PACK_ANALISI_STATISTICHE_POI.GET_RDL_STATO_COMPLETATA";}
		}
		protected string GET_RDL_SERVIZIO_RICHIESTA
		{
			get {return "PACK_ANALISI_STATISTICHE_POI.GET_RDL_SERVIZIO_RICHIESTA";}
		}
		protected string GET_RDL_SERVIZIO_ASSEGNATA
		{
			get {return "PACK_ANALISI_STATISTICHE_POI.GET_RDL_SERVIZIO_ASSEGNATA";}
		}
		protected string GET_RDL_SERVIZIO_COMPLETATA
		{
			get {return "PACK_ANALISI_STATISTICHE_POI.GET_RDL_SERVIZIO_COMPLETATA";}
		}
		protected string GET_RDL_SERVIZIO_MESI_RICH
		{
			get {return "PACK_ANALISI_STATISTICHE_POI.GET_RDL_SERVIZIO_MESI_RICH";}
		}
		protected string GET_RDL_SERVIZIO_MESI_ASSEGN
		{
			get {return "PACK_ANALISI_STATISTICHE_POI.GET_RDL_SERVIZIO_MESI_ASSEGN";}
		}
		protected string GET_RDL_SERVIZIO_MESI_COMP
		{
			get {return "PACK_ANALISI_STATISTICHE_POI.GET_RDL_SERVIZIO_MESI_COMP";}
		}
		protected string GET_RDL_DITTA_MESI_RICH
		{
			get {return "PACK_ANALISI_STATISTICHE_POI.GET_RDL_DITTA_MESI_RICH";}
		}
		protected string GET_RDL_DITTA_MESI_ASSEGN
		{
			get {return "PACK_ANALISI_STATISTICHE_POI.GET_RDL_DITTA_MESI_ASSEGN";}
		}
		protected string GET_RDL_DITTA_MESI_COMP
		{
			get {return "PACK_ANALISI_STATISTICHE_POI.GET_RDL_DITTA_MESI_COMP";}
		}
		protected string get_giud_ser_tip
		{
			get{return "PACK_ANALISI_STATISTICHE_POI.get_giud_ser_tip";}
		}
		protected string get_giud_serv_mesi
		{
			get{return "PACK_ANALISI_STATISTICHE_POI.get_giud_serv_mesi";}
		}
		protected string get_giudizio_servizio
		{
			get {return "PACK_ANALISI_STATISTICHE_POI.get_giudizio_servizio";}
		}
	
	
		//STORE PROCEDURE DEDICATE PROGRAMMATA
		protected string GET_RDL_MESE_RICHIESTA_MP
		{
			get {return "PACK_ANALISI_STATISTICHE_POI.GET_RDL_MESE_RICHIESTA";}
		}
		protected  string GET_RDL_MESE_ASSEGNATA_MP
		{
			get {return "PACK_ANALISI_STATISTICHE_POI.GET_RDL_MESE_ASSEGNATA";}
		}
		protected string GET_RDL_MESE_COMPLETATA_MP
		{
			get {return "PACK_ANALISI_STATISTICHE_POI.GET_RDL_MESE_COMPLETATA";}
		}
		protected string GET_RDL_DITTA_RICHIESTA_MP
		{
			get {return "PACK_ANALISI_STATISTICHE_POI.GET_RDL_DITTA_RICHIESTA";}
		}
		protected string GET_RDL_DITTA_ASSEGNATA_MP
		{
			get {return "PACK_ANALISI_STATISTICHE_POI.GET_RDL_DITTA_ASSEGNATA";}
		}
		protected string GET_RDL_DITTA_COMPLETATA_MP
		{
			get {return "PACK_ANALISI_STATISTICHE_POI.GET_RDL_DITTA_COMPLETATA";}
		}
		protected string GET_RDL_STATO_RICHIESTA_MP
		{
			get {return "PACK_ANALISI_STATISTICHE_POI.GET_RDL_STATO_RICHIESTA";}
		}
		protected string GET_RDL_STATO_ASSEGNATA_MP
		{
			get {return "PACK_ANALISI_STATISTICHE_POI.GET_RDL_STATO_ASSEGNATA";}
		}
		protected string GET_RDL_STATO_COMPLETATA_MP
		{
			get {return "PACK_ANALISI_STATISTICHE_POI.GET_RDL_STATO_COMPLETATA";}
		}
		protected string GET_RDL_SERVIZIO_RICHIESTA_MP
		{
			get {return "PACK_ANALISI_STATISTICHE_POI.GET_RDL_SERVIZIO_RICHIESTA";}
		}
		protected string GET_RDL_SERVIZIO_ASSEGNATA_MP
		{
			get {return "PACK_ANALISI_STATISTICHE_POI.GET_RDL_SERVIZIO_ASSEGNATA";}
		}
		protected string GET_RDL_SERVIZIO_COMPLETATA_MP
		{
			get {return "PACK_ANALISI_STATISTICHE_POI.GET_RDL_SERVIZIO_COMPLETATA";}
		}
		protected string GET_RDL_SERVIZIO_MESI_RICH_MP
		{
			get {return "PACK_ANALISI_STATISTICHE_POI.GET_RDL_SERVIZIO_MESI_RICH";}
		}
		protected string GET_RDL_SERVIZIO_MESI_ASSEGN_MP
		{
			get {return "PACK_ANALISI_STATISTICHE_POI.GET_RDL_SERVIZIO_MESI_ASSEGN";}
		}
		protected string GET_RDL_SERVIZIO_MESI_COMP_MP
		{
			get {return "PACK_ANALISI_STATISTICHE_POI.GET_RDL_SERVIZIO_MESI_COMP";}
		}
		protected string GET_RDL_DITTA_MESI_RICH_MP
		{
			get {return "PACK_ANALISI_STATISTICHE_POI.GET_RDL_DITTA_MESI_RICH";}
		}
		protected string GET_RDL_DITTA_MESI_ASSEGN_MP
		{
			get {return "PACK_ANALISI_STATISTICHE_POI.GET_RDL_DITTA_MESI_ASSEGN";}
		}
		protected string GET_RDL_DITTA_MESI_COMP_MP
		{
			get {return "PACK_ANALISI_STATISTICHE_POI.GET_RDL_DITTA_MESI_COMP";}
		}
	}

	}

