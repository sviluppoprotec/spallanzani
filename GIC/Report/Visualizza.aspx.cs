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
using GIC.Report.UserControl;
using TheSite.GIC.App_Code;

namespace GIC.Report
{
	/// <summary>
	/// Descrizione di riepilogo per Visualizza.
	/// </summary>
	public class Visualizza : System.Web.UI.Page
	{
		protected ConsultazioniDataGrid ConsultazioniDataGrid1;
		private void Page_Load(object sender, System.EventArgs e)
		{
			ConsultazioniDataGrid1.IdQuery=Convert.ToInt32(Request.QueryString["idquery"]);
			ConsultazioniDataGrid1.DysplayGrid();
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
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion
	}
}
