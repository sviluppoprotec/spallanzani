<%@ Register TagPrefix="cc2" Namespace="S_Controls" Assembly="S_Controls" %>
<%@ Register TagPrefix="uc1" TagName="CalendarPicker" Src="../WebControls/CalendarPicker.ascx" %>
<%@ Page language="c#" Codebehind="Ricerca_e_Stampa_.aspx.cs" AutoEventWireup="false" Inherits="StampaRapportiPDF_new.Pagine.Ricerca_e_Stampa_" %>
<%@ Register TagPrefix="uc1" TagName="GridTitle" Src="../WebControls/GridTitle.ascx" %>
<%@ Register TagPrefix="uc1" TagName="PageTitle" Src="../WebControls/PageTitle.ascx" %>
<%@ Register TagPrefix="cc1" Namespace="Csy.WebControls" Assembly="CsyWebControls" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<TITLE>Ricerca_e_Stampa</TITLE>
		<META content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<META content="C#" name="CODE_LANGUAGE">
		<META content="JavaScript" name="vs_defaultClientScript">
		<META content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="../../Css/MainSheet.css" type="text/css" rel="stylesheet">
		<SCRIPT language="javascript">
			function SelCheckbox(){
				for (i=0;i<document.all.length;i++)	{
					if (document.all(i).type == 'checkbox')	{
						if (document.getElementById("ChkSelTutti").checked==true){
							nome=document.all(i).id;	
							if (nome.substring(0,15)=='DataGridRicerca'){	
								if(document.all(i).disabled==false){
									document.all(i).checked=true;}
								}
							}			
						else
						{
							nome=document.all(i).id;	
							if (nome.substring(0,15)=='DataGridRicerca')
							{	
								if(document.all(i).disabled==false)
								{
									document.all(i).checked=false;
								}
							}
						}								
					}
				}
			}
		function abilitaBottoni()
		{
			alert('ciao');
		}
		function AbilitaDataUlteriore()
		{
			document.getElementById("cldpkDaCompletamento_S_TxtDatecalendar").disabled = false;
			document.getElementById("cldpkDaCompletamento_btCalendar").disabled = false;
			
			document.getElementById("cldpkACompletamento_S_TxtDatecalendar").disabled = false;
			document.getElementById("cldpkACompletamento_btCalendar").disabled = false;
			
			
		}
		function DisabilitaDataUlteriore()
		{
			document.getElementById("cldpkDaCompletamento_S_TxtDatecalendar").disabled = true;
			document.getElementById("cldpkDaCompletamento_btCalendar").disabled = true;
			
			document.getElementById("cldpkACompletamento_S_TxtDatecalendar").disabled = true;
			document.getElementById("cldpkACompletamento_btCalendar").disabled = true;
		
		}
		
		</SCRIPT>
	</HEAD>
	<BODY>
		<FORM id="Form1" method="post" runat="server">
			<TABLE id="TableMain" cellpadding="0" width="100%" align="center" border="0">
				<TBODY>
					<TR>
						<TD title="Stampa Rapportini" align="center"><UC1:PAGETITLE id="PgTlStampaPdf" runat="server"></UC1:PAGETITLE></TD>
					</TR>
					<TR>
						<TD valign="top" align="center">
							<TABLE id="tblForm" cellspacing="0" cellpadding="0" width="100%" align="center">
								<TBODY>
									<TR>
										<TD valign="top" align="left"><CC1:DATAPANEL id="DataPanelRicerca" runat="server" allowtitleexpandcollapse="True" collapseimageurl="../Images/up.gif"
												cssclass="DataPanel75" collapsetext="Riduci" expandimageurl="../Images/down.gif" expandtext="Espandi" titletext="Ricerca "
												collapsed="False" titlestyle-cssclass="TitleSearch">
												<TABLE id="RicercaMain" border="0" cellSpacing="0" cellPadding="0" width="100%">
													<TR style="DISPLAY: none">
														<TD style="WIDTH: 122px; HEIGHT: 19px" width="122"></TD>
														<TD style="WIDTH: 27px; HEIGHT: 19px" align="left"></TD>
														<TD style="HEIGHT: 19px" align="left"></TD>
														<TD style="WIDTH: 16px; HEIGHT: 19px" align="left"></TD>
														<TD style="HEIGHT: 19px" align="left"></TD>
														<TD style="HEIGHT: 19px" align="left">
															<CC2:S_LABEL id="S_lblComune" runat="server">Comune</CC2:S_LABEL></TD>
														<TD style="HEIGHT: 19px" align="left">
															<CC2:S_COMBOBOX id="S_cmbComune" runat="server" width="280px"></CC2:S_COMBOBOX></TD>
													</TR>
													<TR>
														<TD style="WIDTH: 122px" align="left">
															<CC2:S_LABEL id="S_lblDataAssegnazione" runat="server">Data assegnazione</CC2:S_LABEL></TD>
														<TD style="WIDTH: 27px" align="left">
															<CC2:S_LABEL id="S_lblDa1" runat="server" width="24px">Da</CC2:S_LABEL></TD>
														<TD align="left">&nbsp;
															<UC1:CALENDARPICKER id="cldpkDaAssegnazione" runat="server"></UC1:CALENDARPICKER>
															<ASP:COMPAREVALIDATOR id="cmpVldDaAssegnazione" runat="server" errormessage="La data iniziale dell' intervallo temporale selezionato deve essere minore di quella finale."
																type="Date" operator="LessThanEqual">*</ASP:COMPAREVALIDATOR></TD>
														<TD style="WIDTH: 16px" align="left">
															<CC2:S_LABEL id="S_lblA1" runat="server">A</CC2:S_LABEL></TD>
														<TD align="left">&nbsp;
															<UC1:CALENDARPICKER id="cldpkAAssegnazione" runat="server"></UC1:CALENDARPICKER>
															<ASP:COMPAREVALIDATOR id="cmpVldAAssegnazione" runat="server" type="Date" operator="GreaterThanEqual">*</ASP:COMPAREVALIDATOR></TD>
														<TD align="left">
															<CC2:S_LABEL id="S_lblEdificio" runat="server">Edificio</CC2:S_LABEL></TD>
														<TD align="left">
															<CC2:S_COMBOBOX id="S_cmbEdificio" runat="server" width="280px"></CC2:S_COMBOBOX></TD>
													</TR>
													<TR>
														<TD style="WIDTH: 150px; HEIGHT: 33px" colSpan="2" align="left">
															<CC2:S_OPTIONBUTTON id="S_optSolNonComp" runat="server" groupname="gr1" text="Non completate" checked="True"></CC2:S_OPTIONBUTTON></TD>
														<TD style="HEIGHT: 33px" align="left">
															<CC2:S_OPTIONBUTTON id="S_optSolComp" runat="server" groupname="gr1" text="Completate"></CC2:S_OPTIONBUTTON></TD>
														<TD style="HEIGHT: 33px" colSpan="2" align="left">
															<CC2:S_OPTIONBUTTON id="S_optDataComp" runat="server" groupname="gr1" text="Data di completamento "></CC2:S_OPTIONBUTTON></TD>
														<TD style="HEIGHT: 33px" align="left">
															<CC2:S_LABEL id="S_lblDitta" runat="server">Ditta</CC2:S_LABEL></TD>
														<TD style="HEIGHT: 33px" align="left">
															<CC2:S_COMBOBOX id="S_cmbDitta" runat="server" width="280px"></CC2:S_COMBOBOX></TD>
													</TR>
													<TR>
														<TD style="WIDTH: 122px; HEIGHT: 51px" align="left">
															<CC2:S_LABEL id="S_lblDataCompletamento" runat="server">Data completamento</CC2:S_LABEL></TD>
														<TD style="WIDTH: 27px; HEIGHT: 51px" align="left">
															<CC2:S_LABEL id="S_lblDa2" runat="server">Da</CC2:S_LABEL></TD>
														<TD style="HEIGHT: 51px" align="left">&nbsp;
															<UC1:CALENDARPICKER id="cldpkDaCompletamento" runat="server"></UC1:CALENDARPICKER>
															<ASP:COMPAREVALIDATOR id="cmpVldDaCompletamento" runat="server" errormessage="La data iniziale dell' intervallo temporale selezionato deve essere minore di quella finale."
																type="Date" operator="LessThanEqual">*</ASP:COMPAREVALIDATOR></TD>
														<TD style="WIDTH: 16px; HEIGHT: 51px" align="left">
															<CC2:S_LABEL id="S_lblA2" runat="server">A</CC2:S_LABEL></TD>
														<TD style="HEIGHT: 51px" align="left">&nbsp;
															<UC1:CALENDARPICKER id="cldpkACompletamento" runat="server"></UC1:CALENDARPICKER>
															<ASP:COMPAREVALIDATOR id="cmpVldACompletamento" runat="server" type="Date" operator="GreaterThanEqual">*</ASP:COMPAREVALIDATOR></TD>
														<TD style="HEIGHT: 51px" align="left">
															<CC2:S_LABEL id="S_lblCategoria" runat="server">Servizio</CC2:S_LABEL></TD>
														<TD style="HEIGHT: 37px" align="left">
															<CC2:S_COMBOBOX id="S_cmbCategoria" runat="server" width="280px"></CC2:S_COMBOBOX></TD>
													</TR>
													<TR>
														<TD style="WIDTH: 122px; HEIGHT: 19px" align="left">
															<CC2:S_BUTTON id="S_btnRicerca" runat="server" cssclass="btn" width="100px" text="Ricerca"></CC2:S_BUTTON></TD>
														<TD style="WIDTH: 27px; HEIGHT: 19px" align="left"></TD>
														<TD style="HEIGHT: 19px" align="right"></TD>
														<TD style="WIDTH: 16px; HEIGHT: 19px" align="left"></TD>
														<TD style="HEIGHT: 19px" align="left"></TD>
														<TD style="HEIGHT: 19px" align="left">
															<CC2:S_LABEL id="S_lblAddetto" runat="server">Addetto</CC2:S_LABEL></TD>
														<TD style="HEIGHT: 19px" align="left">
															<CC2:S_COMBOBOX id="S_cmbAddetto" runat="server" width="280px"></CC2:S_COMBOBOX></TD>
													</TR>
												</TABLE>
											</CC1:DATAPANEL></TD>
									</TR>
								</TBODY>
							</TABLE>
						</TD>
					</TR>
					<TR>
						<TD>
							<TABLE id="tblDatagrid" width="100%" align="left">
								<TBODY>
									<TR>
										<TD valign="top" align="center"><UC1:GRIDTITLE id="gridtleDataGridRicerca" runat="server"></UC1:GRIDTITLE><ASP:DATAGRID id="DataGridRicerca" runat="server" cssclass="DataGrid" bordercolor="Gray" borderwidth="1px"
												gridlines="Vertical" allowpaging="True" autogeneratecolumns="False" PageSize="50">
												<AlternatingItemStyle CssClass="DataGridAlternatingItemStyle"></AlternatingItemStyle>
												<ItemStyle CssClass="DataGridItemStyle"></ItemStyle>
												<HeaderStyle CssClass="DataGridHeaderStyle"></HeaderStyle>
												<Columns>
													<asp:TemplateColumn HeaderText="&lt;input id='ChkSelTutti' type='Checkbox' onclick='SelCheckbox()'&gt;">
														<HeaderStyle HorizontalAlign="Center" Width="3%" VerticalAlign="Middle"></HeaderStyle>
														<ItemStyle HorizontalAlign="Center" VerticalAlign="Middle"></ItemStyle>
														<ItemTemplate>
															<ASP:CHECKBOX id="ChkSel" runat="server"></ASP:CHECKBOX>
														</ItemTemplate>
													</asp:TemplateColumn>
													<asp:BoundColumn DataField="wo_id" HeaderText="Odl">
														<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
														<ItemStyle HorizontalAlign="Right"></ItemStyle>
													</asp:BoundColumn>
													<asp:BoundColumn DataField="city_id" HeaderText="Comune">
														<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
														<ItemStyle HorizontalAlign="Left"></ItemStyle>
													</asp:BoundColumn>
													<asp:BoundColumn DataField="bl_id" HeaderText="cod. Edificio">
														<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
														<ItemStyle HorizontalAlign="Left"></ItemStyle>
													</asp:BoundColumn>
													<asp:BoundColumn DataField="indirizzo" HeaderText="Indirizzo">
														<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
														<ItemStyle HorizontalAlign="Left"></ItemStyle>
													</asp:BoundColumn>
													<asp:BoundColumn DataField="contact_name" HeaderText="Ditta">
														<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
														<ItemStyle HorizontalAlign="Left"></ItemStyle>
													</asp:BoundColumn>
													<asp:BoundColumn DataField="prob_type" HeaderText="Categoria">
														<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
														<ItemStyle HorizontalAlign="Left"></ItemStyle>
													</asp:BoundColumn>
													<asp:BoundColumn DataField="nomecognome" HeaderText="Addetto">
														<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
														<ItemStyle HorizontalAlign="Left"></ItemStyle>
													</asp:BoundColumn>
													<asp:BoundColumn DataField="data_completamento" HeaderText="Data Compl.">
														<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
														<ItemStyle HorizontalAlign="Left"></ItemStyle>
													</asp:BoundColumn>
												</Columns>
												<PagerStyle HorizontalAlign="Left" CssClass="DataGridPagerStyle" Mode="NumericPages"></PagerStyle>
											</ASP:DATAGRID></TD>
									</TR>
									<TR>
										<TD>
											<TABLE>
												<TBODY>
													<TR>
														<TD align="left"><CC2:S_OPTIONBUTTON id="S_optRptCorto" runat="server" text="Report Corto" groupname="grrpt" Visible="False"></CC2:S_OPTIONBUTTON></TD>
													</TR>
													<TR>
														<TD align="left"><CC2:S_OPTIONBUTTON id="S_optLungo" runat="server" text="Report Lungo" groupname="grrpt" Visible="False"
																Checked="True"></CC2:S_OPTIONBUTTON></TD>
													</TR>
												</TBODY>
											</TABLE>
										</TD>
									</TR>
									<TR>
										<TD style="HEIGHT: 49px">
											<TABLE align="center">
												<TBODY>
													<TR>
														<TD align="left"><CC2:S_BUTTON id="S_btnConfermaSel" runat="server" width="120px" text="Conferma Selezione" cssclass="btn"></CC2:S_BUTTON></TD>
														<TD align="left"><CC2:S_BUTTON id="S_btnSelezionaTutto" runat="server" width="120px" text="Seleziona Tutto" cssclass="btn"></CC2:S_BUTTON></TD>
														<TD align="left"><CC2:S_BUTTON id="S_btnDeselezioneTutto" runat="server" width="120px" text="Deseleziona Tutto"
																cssclass="btn"></CC2:S_BUTTON></TD>
														<TD align="left"><CC2:S_BUTTON id="S_btnStampa" runat="server" width="120px" text="Crea File  Pdf" enabled="False"
																cssclass="btn"></CC2:S_BUTTON></TD>
														<TD align="left"><CC2:S_BUTTON id="S_btnDownLoad" runat="server" width="120px" text="Pagina Download" cssclass="btn"></CC2:S_BUTTON></TD>
														<TD align="left"><CC2:S_BUTTON id="S_btnReset" runat="server" width="120px" text="Reset" cssclass="btn"></CC2:S_BUTTON></TD>
														<TD align="left"><A class=GuidaLink href="../<%= HelpLink %>" 
                  target=_blank>Guida</A></TD>
													</TR>
													<TR>
														<TD align="left"><ASP:LABEL id="lblElementiSelezionati" runat="server"></ASP:LABEL>
														</TD>
														<TD align="left"></TD>
													</TR>
												</TBODY>
											</TABLE>
										</TD>
									</TR>
									<TR>
										<TD align="left" colspan="6"><ASP:LABEL id="lblMessaggio" runat="server"></ASP:LABEL><ASP:VALIDATIONSUMMARY id="ValidationSummary1" runat="server"></ASP:VALIDATIONSUMMARY></TD>
									</TR>
								</TBODY>
							</TABLE>
							<SCRIPT language="javascript">
		
		if(document.getElementById("S_optDataComp").checked == false)
		{
			document.getElementById("cldpkDaCompletamento_S_TxtDatecalendar").disabled = true;
			document.getElementById("cldpkDaCompletamento_btCalendar").disabled = true;
			
			document.getElementById("cldpkACompletamento_S_TxtDatecalendar").disabled = true;
			document.getElementById("cldpkACompletamento_btCalendar").disabled = true;
		}

							</SCRIPT>
						</TD>
					</TR>
				</TBODY>
			</TABLE>
		</FORM>
	</BODY>
</HTML>
