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
using System.Text;
using System.IO;
using System.Web.Mail;
using System.Configuration;
using ICSharpCode;
using ICSharpCode.SharpZipLib;
using ICSharpCode.SharpZipLib.Zip;
using ApplicationDataLayer.DBType;
using MyCollection;
using ExcelPMP;
using PMPExcel;
using System.Threading;

namespace TheSite.ManutenzioneProgrammata
{
    /// <summary>
    /// Descrizione di riepilogo per SfogliaPiani.
    /// </summary>
    public class SfogliaPiani : System.Web.UI.Page
    {
        protected Csy.WebControls.DataPanel PanelRicerca;
        protected S_Controls.S_Button btnsRicerca;
        protected System.Web.UI.WebControls.Button cmdReset;
        protected System.Web.UI.WebControls.ValidationSummary ValidationSummary1;
        protected System.Web.UI.WebControls.DropDownList cmbStato;
        protected System.Web.UI.WebControls.DropDownList cmbsTipoDocumenti;
        protected System.Web.UI.WebControls.TextBox txtDescrizione;
        protected System.Web.UI.WebControls.DataGrid DataGridRicerca;
        protected WebControls.CalendarPicker CalendarPicker1;
        protected WebControls.CalendarPicker CalendarPicker2;
        protected WebControls.RicercaModulo RicercaModulo1;
        protected WebControls.PageTitle PageTitle1;
        protected WebControls.GridTitle GridTitle1;
        protected System.Web.UI.WebControls.DropDownList DropAnno;
        Classi.ManProgrammata.RecuperoDocPmp _RecuproDocPmp = new Classi.ManProgrammata.RecuperoDocPmp();
        TheSite.Classi.ManProgrammata.InvioDocPmP _inviodoc = new TheSite.Classi.ManProgrammata.InvioDocPmP();
        protected System.Web.UI.WebControls.Label LblMessage;
        public static string HelpLink = string.Empty;

        private void Page_Load(object sender, System.EventArgs e)
        {



            if (!IsPostBack)
            {
                Classi.SiteModule _SiteModule = (Classi.SiteModule)HttpContext.Current.Items["SiteModule"];
                HelpLink = _SiteModule.HelpLink;
                this.PageTitle1.Title = _SiteModule.ModuleTitle;
                BindStato();
                GridTitle1.hplsNuovo.Visible = false;
            }
            // Inserire qui il codice utente necessario per inizializzare la pagina.
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
            this.btnsRicerca.Click += new System.EventHandler(this.btnsRicerca_Click);
            this.cmdReset.Click += new System.EventHandler(this.cmdReset_Click);
            this.DataGridRicerca.ItemCommand += new System.Web.UI.WebControls.DataGridCommandEventHandler(this.DataGridRicerca_ItemCommand);
            this.DataGridRicerca.PageIndexChanged += new System.Web.UI.WebControls.DataGridPageChangedEventHandler(this.DataGridRicerca_PageIndexChanged);
            this.DataGridRicerca.ItemDataBound += new System.Web.UI.WebControls.DataGridItemEventHandler(this.DataGridRicerca_ItemDataBound);
            this.Load += new System.EventHandler(this.Page_Load);

        }
        #endregion



        private void btnsRicerca_Click(object sender, System.EventArgs e)
        {
            Ricerca();
        }
        private void Ricerca()
        {
            LblMessage.Text = "";
            DataGridRicerca.CurrentPageIndex = 0;
            RicercaPiani();
        }

        private void RicercaPiani()
        {
            //DataGridRicerca.CurrentPageIndex =0;
            DataGridRicerca.Visible = true;
            //	GridTitle1.Visible=true;
            //	DataGridRicerca.Visible=false;
            //	Gridtitle2.Visible=false;

            S_ControlsCollection _SCollection = new S_ControlsCollection();

            S_Controls.Collections.S_Object s_p_BL_ID = new S_Object();
            s_p_BL_ID.ParameterName = "p_BL_ID";
            s_p_BL_ID.DbType = CustomDBType.Integer;
            s_p_BL_ID.Direction = ParameterDirection.Input;
            s_p_BL_ID.Index = _SCollection.Count;
            if (RicercaModulo1.Idbl == "")
                s_p_BL_ID.Value = DBNull.Value;
            else
                s_p_BL_ID.Value = RicercaModulo1.Idbl;
            _SCollection.Add(s_p_BL_ID);

            S_Controls.Collections.S_Object s_p_NOME_DOC = new S_Object();
            s_p_NOME_DOC.ParameterName = "p_NOME_DOC";
            s_p_NOME_DOC.DbType = CustomDBType.VarChar;
            s_p_NOME_DOC.Direction = ParameterDirection.Input;
            s_p_NOME_DOC.Size = 225;
            s_p_NOME_DOC.Index = _SCollection.Count;
            if (txtDescrizione.Text == "")
                s_p_NOME_DOC.Value = DBNull.Value;
            else
                s_p_NOME_DOC.Value = txtDescrizione.Text;
            _SCollection.Add(s_p_NOME_DOC);


            S_Controls.Collections.S_Object s_p_ID_STATO = new S_Object();
            s_p_ID_STATO.ParameterName = "p_ID_STATO";
            s_p_ID_STATO.DbType = CustomDBType.Integer;
            s_p_ID_STATO.Direction = ParameterDirection.Input;
            s_p_ID_STATO.Index = _SCollection.Count;
            if (cmbStato.SelectedIndex == 0)
                s_p_ID_STATO.Value = DBNull.Value;
            else
                s_p_ID_STATO.Value = Convert.ToInt32(cmbStato.SelectedIndex);
            _SCollection.Add(s_p_ID_STATO);

            S_Controls.Collections.S_Object s_p_DATA_INVIO = new S_Object();
            s_p_DATA_INVIO.ParameterName = "p_DATA_INVIO";
            s_p_DATA_INVIO.DbType = CustomDBType.VarChar;
            s_p_DATA_INVIO.Direction = ParameterDirection.Input;
            s_p_DATA_INVIO.Size = 225;
            s_p_DATA_INVIO.Index = _SCollection.Count;
            if (CalendarPicker1.Datazione.Text == "")
                s_p_DATA_INVIO.Value = DBNull.Value;
            else
                s_p_DATA_INVIO.Value = CalendarPicker1.Datazione.Text;
            _SCollection.Add(s_p_DATA_INVIO);

            S_Controls.Collections.S_Object s_p_DATA_INSERIMENTo = new S_Object();
            s_p_DATA_INSERIMENTo.ParameterName = "p_DATA_INSERIMENTo";
            s_p_DATA_INSERIMENTo.DbType = CustomDBType.VarChar;
            s_p_DATA_INSERIMENTo.Direction = ParameterDirection.Input;
            s_p_DATA_INSERIMENTo.Size = 225;
            s_p_DATA_INSERIMENTo.Index = _SCollection.Count;
            if (CalendarPicker2.Datazione.Text == "")
                s_p_DATA_INSERIMENTo.Value = DBNull.Value;
            else
                s_p_DATA_INSERIMENTo.Value = CalendarPicker2.Datazione.Text;
            _SCollection.Add(s_p_DATA_INSERIMENTo);

            S_Controls.Collections.S_Object s_p_anno = new S_Object();
            s_p_anno.ParameterName = "p_anno";
            s_p_anno.DbType = CustomDBType.VarChar;
            s_p_anno.Direction = ParameterDirection.Input;
            s_p_anno.Size = 225;
            s_p_anno.Index = _SCollection.Count;
            s_p_anno.Value = Convert.ToInt32(DropAnno.SelectedValue);
            _SCollection.Add(s_p_anno);


            DataSet _MyDs = _RecuproDocPmp.GetPiani(_SCollection, cmbsTipoDocumenti.SelectedValue);

            if (_MyDs.Tables[0].Rows.Count == 0)
            {
                DataGridRicerca.CurrentPageIndex = 0;
                GridTitle1.DescriptionTitle = "Nessun dato trovato.";
            }
            else
            {
                GridTitle1.DescriptionTitle = "";
                this.GridTitle1.NumeroRecords = _MyDs.Tables[0].Rows.Count.ToString();
            }
            this.DataGridRicerca.DataSource = _MyDs.Tables[0];
            this.DataGridRicerca.DataBind();
        }

        private void BindStato()
        {
            DropAnno.Items.Clear();
            ListItem item = null;
            for (int i = 2008; i <= 2020; i++)
            {
                item = new ListItem(i.ToString(), i.ToString());
                DropAnno.Items.Add(item);

            }
            DropAnno.SelectedValue = System.DateTime.Today.Year.ToString();
            this.cmbStato.Items.Clear();

            DataSet Ds = _RecuproDocPmp.GetAllStato();

            if (Ds.Tables[0].Rows.Count > 0)
            {
                this.cmbStato.DataSource = Classi.GestoreDropDownList.ItemBlankDataSource(
                    Ds.Tables[0], "descrizione", "id", "- Selezionare uno Stato -", "");
                this.cmbStato.DataTextField = "descrizione";
                this.cmbStato.DataValueField = "id";
                this.cmbStato.DataBind();
            }
            else
            {
                string s_Messagggio = "- Nessuna Gruppo -";
                this.cmbStato.Items.Add(Classi.GestoreDropDownList.ItemMessaggio(s_Messagggio, String.Empty));
            }

        }

        private void DataGridRicerca_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
        {
            DataGridRicerca.CurrentPageIndex = e.NewPageIndex;
            RicercaPiani();

        }

        private void DataGridRicerca_ItemCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
        {
            if (e.CommandName == "Download")
            {

                string PathDir = Server.MapPath("../Doc_DB");
                PathDir = PathDir + @"\Manutenzione Programmata";//Manutenzione Programmata


                string PathDirAnnuale = PathDir + @"\PAM" + DropAnno.SelectedValue;//Cartella del Piano annuale

                string PathDirMensile = PathDir + @"\PMP" + DropAnno.SelectedValue;//Cartella de Piano Mensile

                string DestPath = "";
                if (cmbsTipoDocumenti.SelectedValue == "2")//Piano mensile
                {

                    PathDirMensile = PathDirMensile + @"\" + e.CommandArgument.ToString().Split(',')[1];//Cartella de Piano Mensile

                    DestPath = PathDirMensile;
                }
                else//Piano Annuale
                {
                    DestPath = PathDirAnnuale;
                }
                string FileName = DestPath + @"\" + e.CommandArgument.ToString().Split(',')[0];

                Response.Clear();
                Response.ContentType = "application/xls";
                Response.AddHeader("content-disposition", "inline; filename=" + Path.GetFileName(FileName));

                Response.WriteFile(FileName);
            }

            if (e.CommandName == "Esegui")
            {
                int key = int.Parse(DataGridRicerca.DataKeys[e.Item.ItemIndex].ToString());
                string PathDir = Server.MapPath("../Doc_DB");
                PathDir = PathDir + @"\Manutenzione Programmata";//Manutenzione Programmata
                string PathDirMensile = PathDir + @"\PMP" + DropAnno.SelectedValue;//Cartella de Piano Mensile
                string DestPath = "";
                PathDirMensile = PathDirMensile + @"\" + e.CommandArgument.ToString().Split(',')[1];//Cartella de Piano Mensile
                DestPath = PathDirMensile;
                string FileName = DestPath + @"\" + e.CommandArgument.ToString().Split(',')[0];
                CheckBox ck = (CheckBox)e.Item.Cells[7].FindControl("ckEma");
                EseguiPiano(FileName, key, ck.Checked);

            }

            if (e.CommandName == "Accetta")
            {
                int key = int.Parse(DataGridRicerca.DataKeys[e.Item.ItemIndex].ToString());
                string PathDir = Server.MapPath("../Doc_DB");
                PathDir = PathDir + @"\Manutenzione Programmata";//Manutenzione Programmata
                string PathDirMensile = PathDir + @"\PMP" + DropAnno.SelectedValue;//Cartella de Piano Mensile
                string DestPath = "";
                PathDirMensile = PathDirMensile + @"\" + e.CommandArgument.ToString().Split(',')[1];//Cartella de Piano Mensile
                DestPath = PathDirMensile;
                string FileName = DestPath + @"\" + e.CommandArgument.ToString().Split(',')[0];
                CheckBox ck = (CheckBox)e.Item.Cells[7].FindControl("ckEma");
                AccettaPiano(FileName, key, ck.Checked);

            }
        }

        private void cmdReset_Click(object sender, System.EventArgs e)
        {
            string varapp = "";
            if (Request.QueryString["FunId"] != null)
                varapp = "FunId=" + Request.QueryString["FunId"];

            if (Request["VarApp"] != null)
                varapp += "&VarApp=" + Request["VarApp"];

            Server.Transfer("SfogliaPiani.aspx?" + varapp);
        }

        private void DataGridRicerca_ItemDataBound(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.AlternatingItem || e.Item.ItemType == ListItemType.Item)
            {
                if (cmbsTipoDocumenti.SelectedValue != "2") return;
                string tipo_doc = ((DataRowView)e.Item.DataItem)["tipo_doc"].ToString();
                if (tipo_doc == "xls")
                {
                    string MaxStato = ((DataRowView)e.Item.DataItem)["MaxStato"].ToString();
                    string Stato = ((DataRowView)e.Item.DataItem)["ID_STATO"].ToString();
                    if (MaxStato == "1" && Stato == MaxStato)//E' in stato proposto e pu� essere Accettato
                    {
                        LinkButton bt = (LinkButton)e.Item.Cells[7].FindControl("btconv");
                        bt.CommandName = "Accetta";
                        bt.CommandArgument = ((DataRowView)e.Item.DataItem)["nome_doc"].ToString() + "," + ((DataRowView)e.Item.DataItem)["COD"].ToString();
                        bt.Text = "Accetta il Piano";
                        bt.Attributes.Add("onclick", "return confirm('ATTENZIONE! Accettare il piano selezionato!')");
                        bt.Visible = true;
                        CheckBox ck = (CheckBox)e.Item.Cells[7].FindControl("ckEma");
                        ck.Visible = true;
                        //e.Item.Cells[7].Controls.Add(bt);
                        //e.Item.Cells[7].Text="Accetta il Piano";
                    }
                    if (MaxStato == "3" && Stato == MaxStato)//E' in stato Accettato e pu� essere Eseguito
                    {
                        //						e.Item.Cells[7].Text="Esegui il Piano";
                        LinkButton bt = (LinkButton)e.Item.Cells[7].FindControl("btconv");
                        bt.CommandName = "Esegui";
                        bt.CommandArgument = ((DataRowView)e.Item.DataItem)["nome_doc"].ToString() + "," + ((DataRowView)e.Item.DataItem)["COD"].ToString();
                        bt.Text = "Esegui il Piano";
                        bt.Attributes.Add("onclick", "return confirm('ATTENZIONE! Eseguire il piano selezionato!')");
                        bt.Visible = true;
                        CheckBox ck = (CheckBox)e.Item.Cells[7].FindControl("ckEma");
                        ck.Visible = true;
                        //e.Item.Cells[7].Controls.Add(bt);
                    }
                }
                //e.Item.DataItem
            }
        }

        /// <summary>
        /// Recupero il codice dell'edificio ed il progetto a cui � assegnato
        /// </summary>
        private GetDatiEdif GetEdifiProgetto(int id)
        {
            GetDatiEdif dati = new GetDatiEdif();
            DataSet Ds = _RecuproDocPmp.GetInfoDoc(id);
            DataRow riga = Ds.Tables[0].Rows[0];
            dati.CodEdificio = riga["bl_id"].ToString();
            dati.IdProgetto = int.Parse(riga["id_progetto"].ToString());
            dati.IdEdi = int.Parse(riga["id"].ToString());
            dati.Mese = int.Parse(riga["Mese"].ToString());
            dati.Anno = int.Parse(riga["Anno"].ToString());
            dati.Denominazione = riga["denominazione"].ToString();
            return dati;
        }

        private void AccettaPiano(string FileName, int key, bool InviaMail)
        {
            GetDatiEdif dati = GetEdifiProgetto(key);

            bool Ok = UpdatePMP(FileName, PMPExcel.UpdateType.AccettatoDB);

            if (Ok == false) return;

            DocPmP p = new DocPmP();

            string Out = Path.GetDirectoryName(FileName);
            string FileExcel = "";
            string FileExcelA8 = "";

            //CREAZIONE DEL FILE EXCEL PME
            FileExcel = p.CreaFileXLS(Out, dati.CodEdificio, dati.Mese, dati.Anno);

            //			if(dati.IdProgetto==1)
            //				FileExcelA8=p.CreaFileA8(Out,dati.CodEdificio,dati.Mese,dati.Anno);

            SaveDoc(FileExcel, FileExcelA8, 3, dati.IdEdi, dati.Mese, dati.Anno);
            if (InviaMail)
            {
                string FileZip = p.CreaFileZip(FileExcel, FileExcelA8);
                SendMailSfoglia s = new SendMailSfoglia(false, FileZip, dati, LblMessage.Text);
                s.Send();
                //				//Invio della Mail in modalit� asincrona
                //				Thread t = new Thread(new ThreadStart(s.Send));
                //				t.Start();
            }
            Ricerca();
        }

        private void EseguiPiano(string FileName, int key, bool InviaMail)
        {
            GetDatiEdif dati = GetEdifiProgetto(key);

            bool Ok = UpdatePMP(FileName, PMPExcel.UpdateType.EseguitoDB);

            if (Ok == false) return;

            DocPmP p = new DocPmP();

            string Out = Path.GetDirectoryName(FileName);
            string FileExcel = "";
            string FileExcelA8 = "";

            //CREAZIONE DEL FILE EXCEL PME
            FileExcel = p.CreaFileXLS(Out, dati.CodEdificio, dati.Mese, dati.Anno);

            //			if(dati.IdProgetto==1)
            //				FileExcelA8=p.CreaFileA8(Out,dati.CodEdificio,dati.Mese,dati.Anno);

            SaveDoc(FileExcel, FileExcelA8, 5, dati.IdEdi, dati.Mese, dati.Anno);

            if (InviaMail)
            {
                string FileZip = p.CreaFileZip(FileExcel, FileExcelA8);
                SendMailSfoglia s = new SendMailSfoglia(true, FileZip, dati, LblMessage.Text);
                s.Send();
                //Invio della Mail in modalit� asincrona
                //				Thread t = new Thread(new ThreadStart(s.Send));
                //				t.Start();
            }

            Ricerca();
        }

        private void SaveDoc(string FileExcel, string FileA8, int Stato, int bl_id, int Mese, int Anno)
        {

            for (int i = 1; i <= 1; i++)
            {
                S_ControlsCollection _SCollection = new S_ControlsCollection();

                S_Controls.Collections.S_Object s_p_ID = new S_Object();
                s_p_ID.ParameterName = "p_Id";
                s_p_ID.DbType = CustomDBType.Integer;
                s_p_ID.Direction = ParameterDirection.Input;
                s_p_ID.Index = _SCollection.Count;
                s_p_ID.Value = DBNull.Value;
                _SCollection.Add(s_p_ID);

                S_Controls.Collections.S_Object s_p_BL_ID = new S_Object();
                s_p_BL_ID.ParameterName = "p_bl_Id";
                s_p_BL_ID.DbType = CustomDBType.Integer;
                s_p_BL_ID.Direction = ParameterDirection.Input;
                s_p_BL_ID.Index = _SCollection.Count;
                s_p_BL_ID.Value = bl_id;
                _SCollection.Add(s_p_BL_ID);

                S_Controls.Collections.S_Object s_p_NOME_DOC = new S_Object();
                s_p_NOME_DOC.ParameterName = "p_NOME_DOC";
                s_p_NOME_DOC.DbType = CustomDBType.VarChar;
                s_p_NOME_DOC.Direction = ParameterDirection.Input;
                s_p_NOME_DOC.Size = 225;
                s_p_NOME_DOC.Index = _SCollection.Count;
                //				if(i==0)
                s_p_NOME_DOC.Value = System.IO.Path.GetFileName(FileExcel);
                //				else
                //					s_p_NOME_DOC.Value=System.IO.Path.GetFileName(FileA8);
                _SCollection.Add(s_p_NOME_DOC);

                S_Controls.Collections.S_Object s_p_ID_STATO = new S_Object();
                s_p_ID_STATO.ParameterName = "p_ID_STATO";
                s_p_ID_STATO.DbType = CustomDBType.Integer;
                s_p_ID_STATO.Direction = ParameterDirection.Input;
                s_p_ID_STATO.Index = _SCollection.Count;
                s_p_ID_STATO.Value = Stato;
                _SCollection.Add(s_p_ID_STATO);

                S_Controls.Collections.S_Object s_p_DATA_INVIO = new S_Object();
                s_p_DATA_INVIO.ParameterName = "p_DATA_INVIO";
                s_p_DATA_INVIO.DbType = CustomDBType.VarChar;
                s_p_DATA_INVIO.Direction = ParameterDirection.Input;
                s_p_DATA_INVIO.Size = 225;
                s_p_DATA_INVIO.Index = _SCollection.Count;
                //				if (CKMail.Checked==true)
                //					s_p_DATA_INVIO.Value= System.DateTime.Now.ToString().Replace('.',':');	
                //				else
                s_p_DATA_INVIO.Value = DBNull.Value;
                _SCollection.Add(s_p_DATA_INVIO);

                S_Controls.Collections.S_Object s_p_DATA_INSERIMENTo = new S_Object();
                s_p_DATA_INSERIMENTo.ParameterName = "p_DATA_INSERIMENTo";
                s_p_DATA_INSERIMENTo.DbType = CustomDBType.VarChar;
                s_p_DATA_INSERIMENTo.Direction = ParameterDirection.Input;
                s_p_DATA_INSERIMENTo.Size = 225;
                s_p_DATA_INSERIMENTo.Index = _SCollection.Count;
                s_p_DATA_INSERIMENTo.Value = System.DateTime.Now.ToString().Replace('.', ':');
                _SCollection.Add(s_p_DATA_INSERIMENTo);

                S_Controls.Collections.S_Object s_p_anno = new S_Object();
                s_p_anno.ParameterName = "p_anno";
                s_p_anno.DbType = CustomDBType.Integer;
                s_p_anno.Direction = ParameterDirection.Input;
                s_p_anno.Size = 225;
                s_p_anno.Index = _SCollection.Count;
                s_p_anno.Value = Anno.ToString();
                _SCollection.Add(s_p_anno);

                S_Controls.Collections.S_Object s_p_note = new S_Object();
                s_p_note.ParameterName = "p_note1";
                s_p_note.DbType = CustomDBType.VarChar;
                s_p_note.Direction = ParameterDirection.Input;
                s_p_note.Size = 225;
                s_p_note.Index = _SCollection.Count;
                s_p_note.Value = ""; ;
                _SCollection.Add(s_p_note);

                S_Controls.Collections.S_Object s_p_mese = new S_Object();
                s_p_mese.ParameterName = "p_mese";
                s_p_mese.DbType = CustomDBType.Integer;
                s_p_mese.Direction = ParameterDirection.Input;
                s_p_mese.Size = 225;
                s_p_mese.Index = _SCollection.Count;
                s_p_mese.Value = Mese.ToString();
                _SCollection.Add(s_p_mese);

                //				if(i==0)
                //				{
                if (File.Exists(FileExcel))
                    _inviodoc.SaveMesi(_SCollection);
                //				}
                //				else
                //				{
                //					if (File.Exists(FileA8)) 
                //						_inviodoc.SaveMesi(_SCollection);
                //				}
            }
        }



        private bool UpdatePMP(string FileName, PMPExcel.UpdateType updatetype)
        {
            string ConnectionStr = System.Configuration.ConfigurationSettings.AppSettings["ConnectionString"];
            PMPExcel.PMPExcel exc = new PMPExcel.PMPExcel(FileName, updatetype, Context.User.Identity.Name, ConnectionStr);
            try
            {
                StringBuilder sb = exc.ReadDocument();
                LblMessage.Text = sb.ToString().Replace("\n", "</br>");
                return exc.IsValid;
            }
            catch (Exception x)
            {
                LblMessage.Text = x.Message;
                return false;
            }
            finally
            {
                if (exc != null)
                    ((IDisposable)exc).Dispose();

            }
        }
    }
    public class SendMailSfoglia
    {
        private bool _IsEseguito = false;

        private string FileZipMail;
        private GetDatiEdif infoEdi;
        private string _Message;
        TheSite.Classi.ManProgrammata.InvioDocPmP _inviodoc = new TheSite.Classi.ManProgrammata.InvioDocPmP();

        public SendMailSfoglia(bool IsEseguito, string _FileZipMail, GetDatiEdif _infoEdi, string Message)
        {
            _IsEseguito = IsEseguito;
            _Message = Message;
            FileZipMail = _FileZipMail;
            infoEdi = _infoEdi;
        }

        #region Invio Mail
        public void Send()
        {

            DataSet _Ds;
            if (_IsEseguito)//Eseguito
                _Ds = _inviodoc.GetDestinatari(infoEdi.IdEdi, true);
            else
                _Ds = _inviodoc.GetDestinatari(infoEdi.IdEdi, false);

            DataColumn dc = new DataColumn("IsExecute", System.Type.GetType("System.Int32"));
            dc.DefaultValue = 0;
            DataTable dt = _Ds.Tables[0];
            dt.Columns.Add(dc);

            bool flag_mail = false;
            string MailUser = _inviodoc.GetMailByUser();
            foreach (DataRow riga in dt.Rows)
            {
                if (MailUser.Trim().ToLower() == riga["email"].ToString().Trim().ToLower())
                {
                    flag_mail = true;
                    riga["IsExecute"] = 1;
                    break;
                }
            }

            if (flag_mail == false && MailUser != "")
            {
                DataRow riga = dt.NewRow();
                riga["email"] = MailUser;
                riga["IsExecute"] = 1;
                dt.Rows.Add(riga);
            }
            dt.AcceptChanges();

            int Count = 0;
            string Dest = "";
            string AllDest = "";
            foreach (DataRow RigaDest in dt.Rows)
                if (RigaDest["id_utente"].ToString() == "")
                    AllDest += RigaDest["email"].ToString() + "; ";

            foreach (DataRow riga in dt.Rows)
            {


                if (riga["id_utente"].ToString() != "")
                {
                    Dest = riga["email"].ToString();
                }
                else
                {
                    Count++;
                    if (Count > 1) continue;
                    if (Count == 1) Dest = AllDest;
                }


                MailMessage mailMessage = new MailMessage();
                mailMessage.BodyFormat = MailFormat.Html;
                mailMessage.BodyEncoding = System.Text.Encoding.UTF8;
                mailMessage.From = ConfigurationSettings.AppSettings["MailFrom"].ToString();
                mailMessage.To = Dest;
                mailMessage.Cc = "ssys@cft-sir.it";
                Dest = "";


                string Body = "";

                //					if (cmbsTipoDocumenti.SelectedValue=="2")//Piani Mensili
                if (1 == 1)//Piani Mensili
                {
                    string TipoPiano = "";
                    if (_IsEseguito)
                        TipoPiano = "Eseguito";
                    else
                        TipoPiano = "Accettato";

                    mailMessage.Subject = string.Format("Programma Mensile " + TipoPiano + " mese " + GetMese(infoEdi.Mese) + " " + infoEdi.Anno.ToString().Substring(2) + " Sede: " + infoEdi.Denominazione + " Data invio: {0} Ora: {1}", DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString());

                    string Destinatari = "";
                    foreach (DataRow riga2 in dt.Rows)
                        Destinatari += riga2["email"].ToString() + "; ";


                    Body = "<!DOCTYPE HTML PUBLIC \"-//W3C//DTD HTML 4.0 Transitional//EN\">";
                    Body += "<HTML><HEAD><META http-equiv=Content-Type content=\"text/html; charset=iso-8859-1\">";
                    Body += "<BODY bgColor=#ffffff><DIV>Altri destinatari: " + Destinatari + "</DIV>";
                    Body += "<DIV>E' stato inserito un nuovo documento del Piano Mensile " + TipoPiano + " relativo alla sede " + infoEdi.Denominazione;
                    Body += "	del mese di " + GetMese(infoEdi.Mese) + " " + infoEdi.Anno.ToString() + "</DIV>";
                    Body += "<DIV>con le seguenti annotazioni:</DIV><DIV></DIV>";

                    Body += "<DIV>&nbsp;</DIV>";


                    if (riga["IsExecute"].ToString() == "1")
                    {
                        Body += "</br>Rapporto del File inviato:</br>";
                        Body += _Message;
                    }
                    Body += "<DIV>SIR Cofathec Servizi S.p.a.</DIV><DIV>&nbsp;</DIV></BODY></HTML>";

                    mailMessage.Body = Body;

                    //mailMessage.Fields["http://schemas.microsoft.com/cdo/configuration/smtpauthenticate"] = 1;
                    mailMessage.Fields["http://schemas.microsoft.com/cdo/configuration/sendusername"] = ConfigurationSettings.AppSettings["usersmtp"].ToString();
                    mailMessage.Fields["http://schemas.microsoft.com/cdo/configuration/sendpassword"] = ConfigurationSettings.AppSettings["pwdsmtp"].ToString();

                    if (File.Exists(FileZipMail))
                    {
                        MailAttachment attach = new MailAttachment(FileZipMail);
                        mailMessage.Attachments.Add(attach);
                    }
                    SmtpMail.SmtpServer = ConfigurationSettings.AppSettings["SmtpServer2"].ToString();
                    SmtpMail.Send(mailMessage);
                }
                else//Piano annuale
                {

                    //						string Lk="";
                    //						string Lk1="";
                    //						
                    //					
                    //
                    //						string CodiceEdi=DrEdifici.Items[DrEdifici.SelectedIndex].Text.Substring(1,DrEdifici.Items[DrEdifici.SelectedIndex].Text.IndexOf("-")-1);
                    //						mailMessage.Subject =  string.Format(DrTipoDocumenti.Items[DrTipoDocumenti.SelectedIndex].Text +  " anno " + DropAnno.Items[DropAnno.SelectedIndex].Text.Substring(2) + " Sede: " + CodiceEdi + " Data invio: {0} Ora: {1}",DateTime.Now.ToLongDateString(),DateTime.Now.ToLongTimeString());
                    //					
                    //						string Destinatari="";
                    //						foreach(DataRow riga2 in  dt.Rows)
                    //							Destinatari+=riga2["email"].ToString() + "; ";
                    //						Body="<!DOCTYPE HTML PUBLIC \"-//W3C//DTD HTML 4.0 Transitional//EN\">";
                    //						Body+="<HTML><HEAD><META http-equiv=Content-Type content=\"text/html; charset=iso-8859-1\">";
                    //						Body+="<BODY bgColor=#ffffff><DIV>Altri destinatari: " +Destinatari + "</DIV>";
                    //						Body+="<DIV>E' stato inserito un nuovo documento del " + DrTipoDocumenti.Items[DrTipoDocumenti.SelectedIndex].Text + " relativo alla sede " + DrEdifici.Items[DrEdifici.SelectedIndex].Text;
                    //						Body+="	" + DropAnno.Items[DropAnno.SelectedIndex].Text +"</DIV>";
                    //						Body+="<DIV>con le seguenti annotazioni:</DIV><DIV>" + TxtAnnotazioni.Text + "</DIV>";
                    //						Body+=Lk1;
                    //						Body+=Lk;
                    //						Body+="<DIV>&nbsp;</DIV>";
                    //
                    //					
                    //						if(riga["IsExecute"].ToString()=="1")
                    //						{
                    //							Body+="</br>Rapporto del File inviato:</br>";
                    //							Body+=lblMessage.Text;
                    //						}
                    //						Body+="<DIV>SIR Cofathec Servizi S.p.a.</DIV><DIV>&nbsp;</DIV></BODY></HTML>";
                    //
                    //						mailMessage.Body = Body;
                    //						if (File.Exists(FileZipMail))
                    //						{
                    //							MailAttachment attach = new MailAttachment(FileZipMail);
                    //							mailMessage.Attachments.Add(attach);
                    //						}
                    //
                    //						mailMessage.Fields["http://schemas.microsoft.com/cdo/configuration/smtpauthenticate"] = 1;
                    //						mailMessage.Fields["http://schemas.microsoft.com/cdo/configuration/sendusername"] = ConfigurationSettings.AppSettings["usersmtp"].ToString(); 
                    //						mailMessage.Fields["http://schemas.microsoft.com/cdo/configuration/sendpassword"] = ConfigurationSettings.AppSettings["pwdsmtp"].ToString();
                    //
                    //						SmtpMail.SmtpServer = ConfigurationSettings.AppSettings["SmtpServer2"].ToString();
                    //						SmtpMail.Send(mailMessage);

                }
            }//Ciclo for
        }

        private string GetMese(int mese)
        {

            if (mese == 1) return "GENNAIO";
            if (mese == 2) return "FEBBRAIO";
            if (mese == 3) return "MARZO";
            if (mese == 4) return "APRILE";
            if (mese == 5) return "MAGGIO";
            if (mese == 6) return "GIUGNO";
            if (mese == 7) return "LUGLIO";
            if (mese == 8) return "AGOSTO";
            if (mese == 9) return "SETTEMBRE";
            if (mese == 10) return "OTTOBRE";
            if (mese == 11) return "NOVEMBRE";
            if (mese == 12) return "DICEMBRE";

            return "";
        }

        #endregion

    }
    public class GetDatiEdif
    {
        public string CodEdificio = "";
        public string Denominazione = "";
        public int IdProgetto;
        public int IdEdi;
        public int Mese;
        public int Anno;
    }
}
