<%@ Register TagPrefix="uc1" TagName="CalendarPicker" Src="../WebControls/CalendarPicker.ascx" %>
<%@ Page language="c#" Codebehind="NavigazioneAttivitapmp.aspx.cs" AutoEventWireup="false" Inherits="TheSite.ManutenzioneProgrammata.NavigazioneAttivitapmp" %>
<%@ Register TagPrefix="uc1" TagName="UserStanzeRic" Src="../WebControls/UserStanzeRic.ascx" %>
<%@ Register TagPrefix="uc1" TagName="RicercaModulo" Src="../WebControls/RicercaModulo.ascx" %>
<%@ Register TagPrefix="uc1" TagName="PageTitle" Src="../WebControls/PageTitle.ascx" %>
<%@ Register TagPrefix="uc1" TagName="CodiceApparecchiature" Src="../WebControls/CodiceApparecchiature.ascx" %>
<%@ Register TagPrefix="Collapse" Namespace="Csy.WebControls" Assembly="CsyWebControls" %>
<%@ Register TagPrefix="cc1" Namespace="S_Controls" Assembly="S_Controls" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>Navigazione Attività PMP </title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="../Css/MainSheet.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body onbeforeunload="parent.left.valorizza()" MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<TABLE id="TableMain" style="Z-INDEX: 101; POSITION: absolute; TOP: 8px; LEFT: 8px" cellSpacing="0"
				cellPadding="0" width="100%" align="center" border="0">
				<TR>
					<TD style="HEIGHT: 50px" align="center"><uc1:pagetitle id="PageTitle1" runat="server"></uc1:pagetitle></TD>
				</TR>
				<TR>
					<TD vAlign="top" align="left"><COLLAPSE:DATAPANEL id="PanelRicerca" runat="server" TitleStyle-CssClass="TitleSearch" Collapsed="False"
							TitleText="Ricerca" ExpandText="Espandi" ExpandImageUrl="../Images/down.gif" CollapseText="Espandi/Riduci" CssClass="DataPanel75"
							CollapseImageUrl="../Images/up.gif" AllowTitleExpandCollapse="True">
							<TABLE id="tblSearch100" border="0" cellSpacing="1" cellPadding="1">
								<TR>
									<TD vAlign="top" colSpan="4" align="center">
										<P>
											<uc1:RicercaModulo id="RicercaModulo1" runat="server"></uc1:RicercaModulo></P>
									</TD>
								</TR>
								<TR>
									<TD style="WIDTH: 15%"></TD>
									<TD style="HEIGHT: 28px"></TD>
									<TD colSpan="2"></TD>
								</TR>
								<TR>
									<TD style="HEIGHT: 13px"><SPAN>Servizio: </SPAN>
									</TD>
									<TD style="HEIGHT: 13px" colSpan="3">
										<cc1:S_ComboBox id="cmbsServizio" runat="server" Width="392px" AutoPostBack="True"></cc1:S_ComboBox></TD>
								</TR>
								<TR>
									<TD style="HEIGHT: 28px"><SPAN>Std. Apparecchiatura:</SPAN>
									</TD>
									<TD style="HEIGHT: 28px" colSpan="3">
										<cc1:S_ComboBox id="cmbsApparecchiatura" runat="server" Width="392px"></cc1:S_ComboBox></TD>
								</TR>
								<TR>
									<TD colSpan="4">
										<uc1:CodiceApparecchiature id="CodiceApparecchiature1" runat="server"></uc1:CodiceApparecchiature></TD>
								</TR>
								<TR>
								<TR>
									<TD style="HEIGHT: 28px"><SPAN>Data Da:</SPAN></TD>
									<TD style="HEIGHT: 28px">
										<uc1:CalendarPicker id="CalendarPicker1" runat="server"></uc1:CalendarPicker></TD>
									<TD style="HEIGHT: 28px"><SPAN>Data A:</SPAN></TD>
									<TD style="HEIGHT: 28px">
										<uc1:CalendarPicker id="CalendarPicker2" runat="server"></uc1:CalendarPicker></TD>
								</TR>
								<TR>
									<TD colSpan="4">&nbsp;
										<P></P>
										<TABLE style="HEIGHT: 19px" id="Table1" border="0" cellSpacing="0" cellPadding="0" width="100%">
											<TR>
												<TD colSpan="4" align="center">
													<TABLE id="Table3" border="0" cellSpacing="1" cellPadding="1" width="100%">
														<TR>
															<TD></TD>
															<TD>
																<cc1:S_Button id="btReset" runat="server" CssClass="btn" Width="95px" Text="Reset" CausesValidation="False"></cc1:S_Button></TD>
															<TD>
																<cc1:S_Button id="S_Button1" runat="server" CssClass="btn" Width="134px" Text="Esporta in excel"></cc1:S_Button></TD>
															<TD></TD>
															<TD title="L'estrazione è sensibile ai criteri di filtro selezionati"></TD>
															<TD></TD>
															<TD><A class=GuidaLink href="<%= HelpLink %>" 
                        target=_blank>Guida</A></TD>
														</TR>
													</TABLE>
												</TD>
											</TR>
										</TABLE>
									</TD>
								</TR>
							</TABLE>
						</COLLAPSE:DATAPANEL></TD>
				</TR>
				<TR vAlign="top">
					<TD vAlign="top"></TD>
				</TR>
			</TABLE>
		</form>
		</TD></TR></TBODY></TABLE>
		<script language="javascript">parent.left.calcola();</script>
	</body>
</HTML>
