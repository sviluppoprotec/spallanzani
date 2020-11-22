<%@ Register TagPrefix="MessPanel" Namespace="Csy.WebControls" Assembly="CsyWebControls" %>
<%@ Register TagPrefix="cc1" Namespace="S_Controls" Assembly="S_Controls" %>
<%@ Page language="c#" Codebehind="EditUtenti.aspx.cs" AutoEventWireup="false" Inherits="TheSite.Admin.EditUtenti" %>
<%@ Register TagPrefix="uc1" TagName="PageTitle" Src="../WebControls/PageTitle.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>EditUtenti</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="../Css/MainSheet.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body onbeforeunload="parent.left.valorizza()" bottomMargin="0" leftMargin="5" topMargin="0"
		rightMargin="0" MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<TABLE id="TableMain" style="Z-INDEX: 101; LEFT: 0px; WIDTH: 100%; POSITION: absolute; TOP: 0px; HEIGHT: 100%"
				cellSpacing="0" cellPadding="0" width="100%" align="center" border="0">
				<TR>
					<TD style="HEIGHT: 50px" align="center"><uc1:pagetitle id="PageTitle1" title="Gestione Utenti" runat="server"></uc1:pagetitle></TD>
				</TR>
				<TR>
					<TD vAlign="top" align="center" height="95%">
						<TABLE id="tblFormInput" cellSpacing="1" cellPadding="1" align="center">
							<TR>
								<TD style="WIDTH: 5%; HEIGHT: 5%" vAlign="top" align="left"></TD>
								<TD style="HEIGHT: 5%" vAlign="top" align="left"><asp:label id="lblOperazione" runat="server" CssClass="TitleOperazione"></asp:label><MESSPANEL:MESSAGEPANEL id="PanelMess" runat="server" ErrorIconUrl="~/Images/ico_critical.gif" MessageIconUrl="~/Images/ico_info.gif"></MESSPANEL:MESSAGEPANEL></TD>
							</TR>
							<TR>
								<TD style="HEIGHT: 1%" vAlign="top" align="left"></TD>
								<TD style="HEIGHT: 1%" vAlign="top" align="left">
									<hr noShade SIZE="1">
								</TD>
							</TR>
							<TR>
								<TD vAlign="top" align="center"></TD>
								<TD vAlign="top" align="left"><asp:panel id="PanelEdit" runat="server">
										<TABLE id="tblSearch75" cellSpacing="1" cellPadding="2" border="0">
											<TR>
												<TD align="center" colSpan="4"></TD>
											</TR>
											<TR>
												<TD align="right" width="20%">
													<asp:RequiredFieldValidator id="rfvUserName" runat="server" Display="None" ControlToValidate="txtsUserName"
														ErrorMessage="Inserire il nome utente">*</asp:RequiredFieldValidator>Utente</TD>
												<TD width="30%">
													<cc1:s_textbox id="txtsUserName" tabIndex="0" runat="server" MaxLength="50" DBSize="50" width="75%"
														DBDirection="Input" DBParameterName="p_UserName"></cc1:s_textbox></TD>
												<TD align="right" width="20%"></TD>
												<TD width="30%"></TD>
											</TR>
											<TR>
												<TD align="right">Cognome</TD>
												<TD>
													<cc1:s_textbox id="txtsCognome" tabIndex="1" runat="server" MaxLength="50" DBSize="50" width="75%"
														DBParameterName="p_Cognome" DBIndex="1"></cc1:s_textbox></TD>
												<TD align="right">Nome</TD>
												<TD>
													<cc1:s_textbox id="txtsNome" tabIndex="2" runat="server" MaxLength="50" DBSize="50" width="75%"
														DBParameterName="p_Nome" DBIndex="2"></cc1:s_textbox></TD>
											</TR>
											<TR>
												<TD align="right">
													<asp:RegularExpressionValidator id="rgeEmail" runat="server" ControlToValidate="txtsEmail" ErrorMessage="Formato Email non corretto"
														ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>Email</TD>
												<TD>
													<cc1:s_textbox id="txtsEmail" tabIndex="3" runat="server" MaxLength="255" DBSize="255" width="75%"
														DBDirection="Input" DBParameterName="p_Email" DBIndex="3"></cc1:s_textbox></TD>
												<TD align="right">Telefono</TD>
												<TD>
													<cc1:s_textbox id="txtsTelefono" tabIndex="4" runat="server" MaxLength="10" DBSize="10" width="75%"
														DBDirection="Input" DBParameterName="p_Telefono" DBIndex="4"></cc1:s_textbox></TD>
											</TR>
											<TR>
												<TD align="right">Progetto</TD>
												<TD>
													<CC1:S_COMBOBOX id="CmbProgetto" tabIndex="8" runat="server" Width="175px" dbdatatype="Integer"
														dbparametername="p_progetto" dbdirection="Input" dbsize="1" dbindex="7"></CC1:S_COMBOBOX></TD>
												<TD align="right"></TD>
												<TD></TD>
											</TR>
											<TR>
												<TD align="center" colSpan="4"></TD>
											</TR>
											<TR>
												<TD align="right">Password</TD>
												<TD>
													<cc1:s_textbox id="txtsPassword" tabIndex="5" runat="server" MaxLength="50" DBSize="50" width="75%"
														DBDirection="Input" DBParameterName="p_Password" DBIndex="5" TextMode="Password"></cc1:s_textbox></TD>
												<TD align="right">
													<asp:CompareValidator id="cpvPassword" runat="server" Display="None" ControlToValidate="txtsPassword"
														ErrorMessage="Conferma password non coerente" ControlToCompare="txtConfermaPassword">*</asp:CompareValidator>Conferma 
													Password</TD>
												<TD>
													<asp:TextBox id="txtConfermaPassword" tabIndex="6" runat="server" MaxLength="50" TextMode="Password"
														Width="75%"></asp:TextBox></TD>
											</TR>
											<TR>
												<TD align="center" colSpan="4"></TD>
											</TR>
										</TABLE>
									</asp:panel></TD>
							</TR>
							<TR>
								<TD style="HEIGHT: 5%" vAlign="top" align="left"></TD>
								<TD style="HEIGHT: 5%" vAlign="top" align="left">
									<TABLE class="tblFormInputDettaglio" id="tblSearch75Dettaglio" cellSpacing="1" cellPadding="1"
										width="300" border="0">
										<TR>
											<TD align="center" width="40%">Ruoli</TD>
											<TD align="center"></TD>
											<TD align="center">Ruoli Associati</TD>
										</TR>
										<TR>
											<TD align="center"><asp:listbox id="ListBoxLeft" tabIndex="7" runat="server" Width="144px" Enabled="False" Rows="8"></asp:listbox></TD>
											<TD>
												<P align="center"><asp:button id="btnAssocia" tabIndex="8" runat="server" Width="110px" Enabled="False" Text="Aggiungi >>"
														CssClass="btn"></asp:button></P>
												<P align="center"><asp:button id="btnElimina" tabIndex="9" runat="server" Width="110px" Enabled="False" Text="<< Elimina"
														CssClass="btn"></asp:button></P>
											</TD>
											<TD align="center"><asp:listbox id="ListBoxRight" tabIndex="10" runat="server" Width="144px" Enabled="False" Rows="8"></asp:listbox></TD>
										</TR>
										<TR>
											<TD></TD>
											<TD></TD>
											<TD width="40%"></TD>
										</TR>
									</TABLE>
								</TD>
							</TR>
							<TR>
								<TD style="HEIGHT: 4.79%" vAlign="top" align="left"></TD>
								<TD style="HEIGHT: 4.79%" vAlign="top" align="left"><cc1:s_button id="btnsSalva" tabIndex="11" runat="server" Text="Salva" CssClass="btn"></cc1:s_button>&nbsp;
									<cc1:s_button id="btnsElimina" tabIndex="12" runat="server" Text="Elimina" CausesValidation="False"
										CommandType="Delete" CssClass="btn"></cc1:s_button>&nbsp;
									<asp:button id="btnAnnulla" tabIndex="13" runat="server" Text="Annulla" CausesValidation="False"
										CssClass="btn"></asp:button></TD>
							</TR>
							<TR>
								<TD style="HEIGHT: 1%" vAlign="top" align="left"></TD>
								<TD style="HEIGHT: 1%" vAlign="top" align="left">
									<hr noShade SIZE="1">
								</TD>
							</TR>
							<TR>
								<TD style="HEIGHT: 5%" vAlign="top" align="left"></TD>
								<TD style="HEIGHT: 5%" vAlign="top" align="left"><asp:label id="lblFirstAndLast" runat="server"></asp:label>&nbsp;</TD>
							</TR>
						</TABLE>
						<asp:validationsummary id="vlsEdit" runat="server" ShowMessageBox="True" DisplayMode="List" ShowSummary="False"></asp:validationsummary></TD>
				</TR>
			</TABLE>
		</form>
		<script language="javascript">parent.left.calcola();</script>
	</body>
</HTML>
