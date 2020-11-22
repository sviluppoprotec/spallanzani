<%@ Page language="c#" Codebehind="Pagina_Download_.aspx.cs" enableEventValidation="false" AutoEventWireup="false" Inherits="StampaRapportiPDF_new.Pagine.Pagina_Download_" %>
<%@ Register TagPrefix="cc1" Namespace="S_Controls" Assembly="S_Controls" %>
<%@ Register TagPrefix="uc1" TagName="GridTitle" Src="../WebControls/GridTitle.ascx" %>
<%@ Register TagPrefix="cc2" Namespace="Csy.WebControls" Assembly="CsyWebControls" %>
<%@ Register TagPrefix="uc1" TagName="PageTitle" Src="../WebControls/PageTitle.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<TITLE>Pagina_Download</TITLE>
		<META content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<META content="C#" name="CODE_LANGUAGE">
		<META content="JavaScript" name="vs_defaultClientScript">
		<META content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="../../Css/MainSheet.css" type="text/css" rel="stylesheet">
	</HEAD>
	<BODY>
		<FORM id="Form1" method="post" runat="server">
			<TABLE id="tblMain" width="100%">
				<TBODY>
					<TR>
						<TD align="center" colspan="2"><UC1:PAGETITLE id="pgtlDownoloadStampe" runat="server"></UC1:PAGETITLE></TD>
					</TR>
					<TR>
						<TD colspan="2"></TD>
					</TR>
					<TR>
						<TD valign="top" align="center" colspan="2"><UC1:GRIDTITLE id="GridTitleDownLoad" runat="server"></UC1:GRIDTITLE><ASP:DATAGRID id="DataGridRicerca" runat="server" cssclass="DataGrid" autogeneratecolumns="False"
								allowpaging="True" gridlines="Vertical" borderwidth="1px" bordercolor="Gray" PageSize="25">
								<AlternatingItemStyle CssClass="DataGridAlternatingItemStyle"></AlternatingItemStyle>
								<ItemStyle CssClass="DataGridItemStyle"></ItemStyle>
								<HeaderStyle CssClass="DataGridHeaderStyle"></HeaderStyle>
								<Columns>
									<asp:TemplateColumn Visible="False">
										<HeaderStyle Width="1%"></HeaderStyle>
										<ItemStyle HorizontalAlign="Center" VerticalAlign="Middle"></ItemStyle>
										<ItemTemplate>
											<ASP:IMAGEBUTTON id="imgBtnVisualizza" runat="server" imageurl="../images/eye.gif" OnCommand="imgBtnVisualizza_Click" CommandArgument='<%# DataBinder.Eval(Container.DataItem,"nome_file")  %>'>
											</ASP:IMAGEBUTTON>
										</ItemTemplate>
									</asp:TemplateColumn>
									<asp:TemplateColumn>
										<HeaderStyle Width="1%"></HeaderStyle>
										<ItemStyle HorizontalAlign="Center" VerticalAlign="Middle"></ItemStyle>
										<ItemTemplate>
											<ASP:IMAGEBUTTON id="imgBtnDownLoad" runat="server" imageurl="../images/salva.gif" oncommand="imgBtnDownLoad_Click" CommandArgument='<%# DataBinder.Eval(Container.DataItem,"nome_file") %>'>
											</ASP:IMAGEBUTTON>
										</ItemTemplate>
									</asp:TemplateColumn>
									<asp:TemplateColumn>
										<HeaderStyle Width="1%"></HeaderStyle>
										<ItemStyle HorizontalAlign="Center" VerticalAlign="Middle"></ItemStyle>
										<ItemTemplate>
											<ASP:IMAGEBUTTON id="imgBtnElimina" runat="server" imageurl="../images/elimina.gif" OnCommand="imgBtnElimina_Click" CommandArgument='<%# DataBinder.Eval(Container.DataItem,"id") + "," + DataBinder.Eval(Container.DataItem,"nome_file") %>'>
											</ASP:IMAGEBUTTON>
										</ItemTemplate>
									</asp:TemplateColumn>
									<asp:TemplateColumn>
										<HeaderStyle Width="3%"></HeaderStyle>
										<ItemStyle HorizontalAlign="Center" VerticalAlign="Middle"></ItemStyle>
										<ItemTemplate>
											<ASP:IMAGEBUTTON id="lnkDett" runat="server" OnCommand="lnkDett_Click" imageurl="../images/Search16x16_bianca.JPG" commandargument= '<%# DataBinder.Eval(Container.DataItem,"id") %>'>
											</ASP:IMAGEBUTTON>
										</ItemTemplate>
									</asp:TemplateColumn>
									<asp:BoundColumn Visible="False" DataField="id" HeaderText="id"></asp:BoundColumn>
									<asp:BoundColumn DataField="data_created" HeaderText="Data di stampa report">
										<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
										<ItemStyle Wrap="False" HorizontalAlign="Left"></ItemStyle>
									</asp:BoundColumn>
									<asp:BoundColumn DataField="tipologia_report" HeaderText="Tipologia report">
										<HeaderStyle Wrap="False" HorizontalAlign="Center"></HeaderStyle>
										<ItemStyle Wrap="False" HorizontalAlign="Left"></ItemStyle>
									</asp:BoundColumn>
									<asp:BoundColumn DataField="DATA_ASS_IN_OUT" HeaderText="Data ass.ne iniziale-finale">
										<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
										<ItemStyle Wrap="False" HorizontalAlign="Left"></ItemStyle>
									</asp:BoundColumn>
									<asp:BoundColumn Visible="False" DataField="comune" HeaderText="Comune">
										<HeaderStyle Wrap="False" HorizontalAlign="Center"></HeaderStyle>
										<ItemStyle Wrap="False" HorizontalAlign="Left"></ItemStyle>
									</asp:BoundColumn>
									<asp:BoundColumn DataField="edificio" HeaderText="Edificio">
										<HeaderStyle Wrap="False" HorizontalAlign="Center"></HeaderStyle>
										<ItemStyle Wrap="False" HorizontalAlign="Left"></ItemStyle>
									</asp:BoundColumn>
									<asp:BoundColumn DataField="intervallo_odl_selezionati" HeaderText="Intervallo Odl">
										<HeaderStyle Wrap="False" HorizontalAlign="Center"></HeaderStyle>
										<ItemStyle Wrap="False" HorizontalAlign="Left"></ItemStyle>
									</asp:BoundColumn>
									<asp:BoundColumn DataField="ditta" HeaderText="Ditta">
										<HeaderStyle Wrap="False" HorizontalAlign="Center"></HeaderStyle>
										<ItemStyle Wrap="False" HorizontalAlign="Left"></ItemStyle>
									</asp:BoundColumn>
									<asp:BoundColumn DataField="categoria" HeaderText="Categoria">
										<HeaderStyle Wrap="False" HorizontalAlign="Center"></HeaderStyle>
										<ItemStyle Wrap="False" HorizontalAlign="Left"></ItemStyle>
									</asp:BoundColumn>
									<asp:BoundColumn DataField="addetto" HeaderText="Addetto">
										<HeaderStyle Wrap="False" HorizontalAlign="Center"></HeaderStyle>
										<ItemStyle Wrap="False" HorizontalAlign="Left"></ItemStyle>
									</asp:BoundColumn>
									<asp:BoundColumn DataField="COMPLETATE" HeaderText="Completate">
										<HeaderStyle Wrap="False" HorizontalAlign="Center"></HeaderStyle>
										<ItemStyle Wrap="False" HorizontalAlign="Left"></ItemStyle>
									</asp:BoundColumn>
									<asp:BoundColumn DataField="DIMENSIONEFILE_PDF_ZIP" HeaderText="Dim. file Pdf/Zip(byte)">
										<HeaderStyle Wrap="False" HorizontalAlign="Center"></HeaderStyle>
										<ItemStyle Wrap="False" HorizontalAlign="Right"></ItemStyle>
									</asp:BoundColumn>
								</Columns>
								<PagerStyle HorizontalAlign="Left" CssClass="DataGridPagerStyle" Mode="NumericPages"></PagerStyle>
							</ASP:DATAGRID></TD>
					</TR>
					<TR>
						<TD align="left" width="15%"><CC1:S_BUTTON id="S_btnRicerca" runat="server" text="Pagina Ricerca e  Stampa" width="160px" cssclass="btn"></CC1:S_BUTTON></TD>
						<TD align="left"><CC1:S_BUTTON id="S_btnEliminaTiitiFile" runat="server" text="Elimina Tutti I File" width="160px"
								cssclass="btn"></CC1:S_BUTTON>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<A 
      class=GuidaLink href="../<%= HelpLink %>" 
  target=_blank>Guida</A></TD>
					</TR>
				</TBODY>
			</TABLE>
			<TABLE>
				<TBODY>
					<TR>
						<TD><ASP:LABEL id="lblId" runat="server"></ASP:LABEL></TD>
					</TR>
				</TBODY>
			</TABLE>
			<TABLE>
				<TBODY>
					<TR>
						<TD><ASP:PANEL id="pnlShowInfo" runat="server" cssclass="ShowInfoPanel350" visible="False">
								<TABLE width="100%" height="100%">
									<TR>
										<TD class="TitleSearch" height="15" vAlign="top" colSpan="2" align="right">
											<ASP:LINKBUTTON id="lnkChiudi" runat="server" cssclass="LabelChiudi" causesvalidation="False">Chiudi</ASP:LINKBUTTON></TD>
									</TR>
									<TR>
										<TD vAlign="top">
											<TABLE id="tblFrequenze" class="BordiTabella" border="1" cellSpacing="0" cellPadding="2">
												<TR>
													<TD colSpan="2">
														<ASP:LABEL id="lblIntestazione" runat="server" font-size="Larger" forecolor="#000099">Scheda di dettaglio rapportino interventi MAnutenzione Programmata</ASP:LABEL></TD>
												</TR>
												<TR>
													<TD>
														<ASP:LABEL id="lblC11" runat="server">Data di creazione</ASP:LABEL></TD>
													<TD align="right">&nbsp;
														<ASP:LABEL id="lblDataDiCreazione" runat="server"></ASP:LABEL></TD>
												</TR>
												<TR>
													<TD>
														<ASP:LABEL id="LABEL18" runat="server">Tipologia Report</ASP:LABEL></TD>
													<TD>
														<ASP:LABEL id="lblTipologiaReport" runat="server"></ASP:LABEL>&nbsp;</TD>
												</TR>
												<TR>
													<TD>
														<ASP:LABEL id="LABEL19" runat="server">Edificio</ASP:LABEL></TD>
													<TD>
														<ASP:LABEL id="lblEdificio" runat="server"></ASP:LABEL>&nbsp;</TD>
												</TR>
												<TR>
													<TD>
														<ASP:LABEL id="LABEL20" runat="server">Comune</ASP:LABEL></TD>
													<TD>
														<ASP:LABEL id="lblComune" runat="server"></ASP:LABEL>&nbsp;</TD>
												</TR>
												<TR>
													<TD>
														<ASP:LABEL id="LABEL21" runat="server">Intervallo Odl</ASP:LABEL></TD>
													<TD>
														<ASP:LABEL id="lblIntervalloOdl" runat="server"></ASP:LABEL>&nbsp;</TD>
												</TR>
												<TR>
													<TD>
														<ASP:LABEL id="LABEL22" runat="server">Ditta</ASP:LABEL></TD>
													<TD>
														<ASP:LABEL id="lblDitta" runat="server"></ASP:LABEL>&nbsp;</TD>
												</TR>
												<TR>
													<TD>
														<ASP:LABEL id="LABEL23" runat="server">Categoria</ASP:LABEL></TD>
													<TD>
														<ASP:LABEL id="lblCategoria" runat="server"></ASP:LABEL>&nbsp;</TD>
												</TR>
												<TR>
													<TD>
														<ASP:LABEL id="LABEL24" runat="server">Addetto</ASP:LABEL></TD>
													<TD>
														<ASP:LABEL id="lblAddetto" runat="server"></ASP:LABEL>&nbsp;</TD>
												</TR>
												<TR>
													<TD>
														<ASP:LABEL id="LABEL25" runat="server">Solo non completate</ASP:LABEL></TD>
													<TD>
														<ASP:LABEL id="lblSoloNonCompletate" runat="server"></ASP:LABEL>&nbsp;</TD>
												</TR>
												<TR>
													<TD>
														<ASP:LABEL id="LABEL26" runat="server">Solo completate</ASP:LABEL></TD>
													<TD>
														<ASP:LABEL id="lblSoloCompletate" runat="server"></ASP:LABEL>&nbsp;</TD>
												</TR>
												<TR>
													<TD>
														<ASP:LABEL id="Label1" runat="server">Solo completate con filtro </ASP:LABEL></TD>
													<TD>
														<ASP:LABEL id="lblSoloCompletateConFiltro" runat="server"></ASP:LABEL>&nbsp;</TD>
												</TR>
												<TR>
													<TD>
														<ASP:LABEL id="LABEL27" runat="server">Dimensione file Pdf(byte)</ASP:LABEL></TD>
													<TD align="right">&nbsp;
														<ASP:LABEL id="lblDimensioneFilePdf" runat="server"></ASP:LABEL></TD>
												</TR>
												<TR>
													<TD>
														<ASP:LABEL id="LABEL28" runat="server">Dimensione file Zip(byte)</ASP:LABEL></TD>
													<TD align="right">&nbsp;
														<ASP:LABEL id="lblDimensioneFileZip" runat="server"></ASP:LABEL></TD>
												</TR>
												<TR>
													<TD>
														<ASP:LABEL id="LABEL29" runat="server">Data assegnazione iniziale</ASP:LABEL></TD>
													<TD align="right">&nbsp;
														<ASP:LABEL id="lblDataAssegnazioneIniziale" runat="server"></ASP:LABEL></TD>
												</TR>
												<TR>
													<TD>
														<ASP:LABEL id="LABEL30" runat="server">Data assegnazione finale</ASP:LABEL></TD>
													<TD align="right">&nbsp;
														<ASP:LABEL id="lblDataAssegnazioneFinale" runat="server"></ASP:LABEL></TD>
												</TR>
												<TR>
													<TD>
														<ASP:LABEL id="LABEL31" runat="server">Data completamento iniziale</ASP:LABEL></TD>
													<TD align="right">&nbsp;
														<ASP:LABEL id="lblDataCompletamentoIniziale" runat="server"></ASP:LABEL></TD>
												</TR>
												<TR>
													<TD>
														<ASP:LABEL id="LABEL32" runat="server">Data completamento finale</ASP:LABEL></TD>
													<TD align="right">&nbsp;
														<ASP:LABEL id="lblDataCompletamentoFinale" runat="server"></ASP:LABEL></TD>
												</TR>
											</TABLE>
										</TD>
									</TR>
								</TABLE>
							</ASP:PANEL></TD>
					</TR>
				</TBODY>
			</TABLE>
		</FORM>
	</BODY>
</HTML>
