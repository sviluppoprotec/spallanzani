<%@ Register TagPrefix="uc1" TagName="PageTitle" Src="../WebControls/PageTitle.ascx" %>
<%@ Register TagPrefix="uc1" TagName="CalendarPicker" Src="../WebControls/CalendarPicker.ascx" %>
<%@ Register TagPrefix="cc2" Namespace="Csy.WebControls" Assembly="CsyWebControls" %>
<%@ Register TagPrefix="cc1" Namespace="S_Controls" Assembly="S_Controls" %>
<%@ Page language="c#" Codebehind="EditCanoni.aspx.cs" AutoEventWireup="false" Inherits="TheSite.Gestione.EditCanoni" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>Aggiorna Centro di Costo</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<LINK rel="stylesheet" type="text/css" href="../Css/MainSheet.css">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<TABLE style="Z-INDEX: 101; POSITION: absolute; WIDTH: 100%; HEIGHT: 100%; TOP: 0px; LEFT: 0px"
				id="TableMain" border="0" cellSpacing="0" cellPadding="0" width="100%" align="center">
				<TBODY>
					<TR>
						<TD style="HEIGHT: 50px" align="center"><uc1:pagetitle id="PageTitle1" runat="server"></uc1:pagetitle></TD>
					</TR>
					<TR height="95%" vAlign="top" align="center">
						<TD>
							<TABLE id="tblFormInput" cellSpacing="1" cellPadding="1" align="center">
								<TBODY>
									<TR>
										<TD style="WIDTH: 5%; HEIGHT: 5%" vAlign="top" align="left"></TD>
										<TD style="HEIGHT: 5%" vAlign="top" align="left"><asp:label id="lblOperazione" runat="server" CssClass="TitleOperazione" Width="512px"></asp:label><cc2:messagepanel id="PanelMess" runat="server" ErrorIconUrl="~/Images/ico_critical.gif" MessageIconUrl="~/Images/ico_info.gif"></cc2:messagepanel></TD>
									</TR>
									<TR>
										<TD style="HEIGHT: 1%" vAlign="top" align="left"></TD>
										<TD style="HEIGHT: 1%" vAlign="top" align="left">
											<hr SIZE="1" noShade>
										</TD>
									</TR>
									<TR>
										<TD vAlign="top" align="center"></TD>
										<TD vAlign="top" align="left"><asp:panel id="PanelEdit" runat="server">
												<TABLE id="tblSearch75" border="0" cellSpacing="1" cellPadding="2">
													<TBODY>
														<TR>
															<TD align="left">Descrizione
																<asp:requiredfieldvalidator id="rfvEqstd" runat="server" ErrorMessage="La Descrizione Breve è obbligatoria"
																	ControlToValidate="txtsdescrizione">*</asp:requiredfieldvalidator></TD>
															<TD>
																<P><cc1:s_textbox id="txtsdescrizione" tabIndex="1" runat="server" Width="396px" MaxLength="255" DBIndex="1"
																		DBParameterName="p_descrizione" DBSize="50" DBDirection="Input" DBDataType="VarChar"></cc1:s_textbox></P>
															</TD>
														<TR>
															<TD>
															Mese
															<TD><asp:dropdownlist id="DropMese" runat="server">
																	<asp:ListItem Value="01">Gennaio</asp:ListItem>
																	<asp:ListItem Value="02">Febbraio</asp:ListItem>
																	<asp:ListItem Value="03">Marzo</asp:ListItem>
																	<asp:ListItem Value="04">Aprile</asp:ListItem>
																	<asp:ListItem Value="05">Maggio</asp:ListItem>
																	<asp:ListItem Value="06">Giugno</asp:ListItem>
																	<asp:ListItem Value="07">Luglio</asp:ListItem>
																	<asp:ListItem Value="08">Agosto</asp:ListItem>
																	<asp:ListItem Value="09">Settembre</asp:ListItem>
																	<asp:ListItem Value="10">Ottobre</asp:ListItem>
																	<asp:ListItem Value="11">Novembre</asp:ListItem>
																	<asp:ListItem Value="12">Dicembre</asp:ListItem>
																</asp:dropdownlist></TD>
														</TR>
														<TR>
															<TD>
															Anno
															<TD><CC1:S_COMBOBOX style="Z-INDEX: 0" id="S_anno" tabIndex="2" runat="server" Width="304px" DBIndex="2"
																	DBSize="10" DBDirection="InputOutput" DBDataType="Integer"></CC1:S_COMBOBOX></TD>
														</TR>
														<TR>
															<TD>Importo Canone €</TD>
															<TD><CC1:S_TEXTBOX style="TEXT-ALIGN: right" id="ImpCons1" runat="server" width="48px" maxlength="8">0</CC1:S_TEXTBOX>,
																<CC1:S_TEXTBOX id="ImpCons2" runat="server" width="27px" maxlength="2">00</CC1:S_TEXTBOX></TD>
														</TR>
														<TR>
															<TD>File Allegato</TD>
															<TD>&nbsp;<INPUT style="WIDTH: 280px; HEIGHT: 18px" id="Uploader" size="27" type="file" name="File1"
																	runat="server"></TD>
														<TR>
															<TD><STRONG></STRONG></TD>
															<TD>&nbsp;
																<asp:hyperlink id="LkCons" runat="server" Target="_blank"></asp:hyperlink>&nbsp;
																<asp:imagebutton id="btImgDeleteCons" runat="server" ImageUrl="../Images/elimina.gif"></asp:imagebutton></TD>
														</TR>
														<tr style="DISPLAY: none">
															<td colSpan="2"><cc1:s_textbox style="Z-INDEX: 0" id="S_TextBox1" tabIndex="1" runat="server" Width="396px" DBDataType="VarChar"></cc1:s_textbox><asp:label id="LbCPnr" runat="server">Label</asp:label></td></TD>
									</TR>
									<tr>
										<td colSpan="2" align="center">Aggiungi Dettaglio Servizi</td>
									</tr>
									<tr>
										<TD>
											Descrizione Servizio</TD>
										<TD><asp:dropdownlist id="Dropdownlist1" runat="server">
												<asp:ListItem Value="A1">A1 Servizio Imp. Climat. Invernale</asp:ListItem>
												<asp:ListItem Value="A2">A2 Servizio Idrico</asp:ListItem>
												<asp:ListItem Value="B1">B1 Servizio Imp. Climat. Estiva </asp:ListItem>
												<asp:ListItem Value="B2">B2 Servizio Imp. Elettrici, Speciali e di Illuminazione</asp:ListItem>
												<asp:ListItem Value="C1">C1 Servizio Imp.Antincendio</asp:ListItem>
												<asp:ListItem Value="C2">C2 Servizio Imp.di Trasporto verticale ed orizzontale</asp:ListItem>
												<asp:ListItem Value="C3">C3 Servizio di minuto Mantenimento Edile</asp:ListItem>
												<asp:ListItem Value="D7">D7 Costituzione e Gestione dell’Anagrafica Tecnica</asp:ListItem>
											</asp:dropdownlist></TD>
									</tr>
									<tr>
									<TR>
										<TD>Importo Canone Servizio&nbsp;€</TD>
										<TD><CC1:S_TEXTBOX style="TEXT-ALIGN: right" id="S_textbox2" runat="server" width="48px" maxlength="8">0</CC1:S_TEXTBOX>,
											<CC1:S_TEXTBOX id="S_textbox3" runat="server" width="27px" maxlength="2">00</CC1:S_TEXTBOX></TD>
									</TR>
									<tr>
										<td colSpan="2"><asp:button id="btn_S_Hlav" runat="server" Width="208px" Text="Aggiungi Dettaglio"></asp:button></td>
									</tr>
									<tr>
										<td colSpan="2">
											<P align="center"><asp:repeater id="Repeater1" Runat="server">
													<HeaderTemplate>
														<table border="1">
															<tr>
																<td><B>Descrizione Servizio</B></td>
																<td><B>Importo Servizio €</B></td>
																<td><B>Elimina</B></td>
															</tr>
													</HeaderTemplate>
													<ItemTemplate>
														<tr>
															<td><%# DataBinder.Eval(Container.DataItem, "descrizione") %></td>
															<td><%# DataBinder.Eval(Container.DataItem, "importo") %></td>
															<td>
																<asp:ImageButton ID="delete1" ImageUrl="../Images/elimina.gif" Runat="server" CommandName="Delete" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "id_canoni_dettaglio")  %>'>
																</asp:ImageButton></td>
														</tr>
													</ItemTemplate>
													<FooterTemplate>
							</TABLE>
							</FooterTemplate> </asp:repeater></P></TD>
					</TR>
					<tr>
						<td colSpan="2"><cc1:s_button style="Z-INDEX: 0" id="btnsSalva" tabIndex="10" runat="server" CssClass="btn" Text="Salva"
								Width="72px"></cc1:s_button><cc1:s_button style="Z-INDEX: 0" id="btnsElimina" tabIndex="11" runat="server" CssClass="btn"
								Width="72px" Text="Elimina" CommandType="Delete" CausesValidation="False"></cc1:s_button><asp:button style="Z-INDEX: 0" id="btnAnnulla" tabIndex="12" runat="server" CssClass="btn" Width="72px"
								Text="Indietro" CausesValidation="False"></asp:button></td>
					</tr>
					<TR>
						<TD style="HEIGHT: 5%" vAlign="top" align="left"><asp:label style="Z-INDEX: 0" id="lblFirstAndLast" runat="server"></asp:label>
							<P><cc1:s_label style="Z-INDEX: 0" id="S_Lblerror" runat="server" ForeColor="Red"></cc1:s_label></P>
						</TD>
						<TD style="HEIGHT: 5%" vAlign="top" align="left">
							<P></P>
							<P>&nbsp;</P>
						</TD>
					</TR>
				</TBODY>
			</TABLE>
			<P>&nbsp;</P>
			</TD></TR></TBODY></TABLE></asp:panel></TD></TR>
			<tr>
				<TD style="HEIGHT: 5%" vAlign="top" align="left"></TD>
				<TD style="HEIGHT: 5%" vAlign="top" align="left">&nbsp;&nbsp;&nbsp;
				</TD>
			</tr>
			<TR>
				<TD style="HEIGHT: 1%" vAlign="top" align="left"></TD>
				<TD style="HEIGHT: 1%" vAlign="top" align="left">
					<hr SIZE="1" noShade>
				</TD>
			</TR>
			</TR></TBODY></TABLE><asp:validationsummary id="vlsEdit" runat="server" ShowMessageBox="True" ShowSummary="False"></asp:validationsummary></TD></TR></TBODY></TABLE></form>
	</body>
</HTML>
