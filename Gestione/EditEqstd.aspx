<%@ Register TagPrefix="cc1" Namespace="S_Controls" Assembly="S_Controls" %>
<%@ Register TagPrefix="cc2" Namespace="Csy.WebControls" Assembly="CsyWebControls" %>
<%@ Register TagPrefix="uc1" TagName="CalendarPicker" Src="../WebControls/CalendarPicker.ascx" %>
<%@ Page language="c#" Codebehind="EditEqstd.aspx.cs" AutoEventWireup="false" Inherits="TheSite.Gestione.EditEqstd" %>
<%@ Register TagPrefix="uc1" TagName="PageTitle" Src="../WebControls/PageTitle.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>EditEqstd</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<LINK rel="stylesheet" type="text/css" href="../Css/MainSheet.css">
	</HEAD>
	<body onbeforeunload="parent.left.valorizza()" MS_POSITIONING="GridLayout">
		<script language="javascript">
	
	
	
		</script>
		<form id="Form1" method="post" runat="server">
			<TABLE style="Z-INDEX: 101; POSITION: absolute; WIDTH: 100%; HEIGHT: 100%; TOP: 0px; LEFT: 0px"
				id="TableMain" border="0" cellSpacing="0" cellPadding="0" width="100%" align="center">
				<TR>
					<TD style="HEIGHT: 50px" align="center"><uc1:pagetitle id="PageTitle1" runat="server"></uc1:pagetitle></TD>
				</TR>
				<TR height="95%" vAlign="top" align="center">
					<TD>
						<TABLE id="tblFormInput" cellSpacing="1" cellPadding="1" align="center">
							<TBODY>
								<TR>
									<TD style="WIDTH: 5%; HEIGHT: 5%" vAlign="top" align="left"></TD>
									<TD style="HEIGHT: 5%" vAlign="top" align="left"><asp:label id="lblOperazione" runat="server" Width="512px" CssClass="TitleOperazione"></asp:label><cc2:messagepanel id="PanelMess" runat="server" MessageIconUrl="~/Images/ico_info.gif" ErrorIconUrl="~/Images/ico_critical.gif"></cc2:messagepanel></TD>
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
														<TD style="WIDTH: 178px; HEIGHT: 24px" align="left">Standard Apparecchiatura&nbsp;
															<asp:requiredfieldvalidator id="rfvEqstd" runat="server" ErrorMessage="Inserire lo standard" ControlToValidate="txtseq_std">*</asp:requiredfieldvalidator></TD>
														<TD style="HEIGHT: 24px"><cc1:s_textbox id="txtseq_std" tabIndex="1" runat="server" DBDirection="Input" DBSize="16" DBParameterName="p_eq_std"
																DBIndex="0"></cc1:s_textbox></TD>
													</TR>
													<TR>
														<TD style="WIDTH: 178px; HEIGHT: 23px" align="left">Descrizione</TD>
														<TD style="HEIGHT: 23px"><cc1:s_textbox id="txtsdescrizione" tabIndex="2" runat="server" Width="472px" DBDirection="Input"
																DBSize="100" DBParameterName="p_descrizione" DBIndex="1" DBDataType="VarChar"></cc1:s_textbox></TD>
													</TR>
													<TR>
														<TD style="WIDTH: 178px; HEIGHT: 17px" align="left">Servizio
															<asp:requiredfieldvalidator id="RequiredFieldValidator1" runat="server" ErrorMessage="Inserire il servizio"
																ControlToValidate="cmbservizio" InitialValue="0">*</asp:requiredfieldvalidator></TD>
														<TD style="HEIGHT: 17px"><cc1:s_combobox id="cmbservizio" tabIndex="3" runat="server" Width="280px" DBDirection="Input" DBSize="10"
																DBParameterName="p_servizio_id" DBIndex="2" DBDataType="Integer" AutoPostBack="True"></cc1:s_combobox></TD>
													</TR>
													<TR>
														<TD style="WIDTH: 178px; HEIGHT: 23px" align="left">Progressivo UNI</TD>
														<TD style="HEIGHT: 23px"><cc1:s_textbox id="S_UNI1" tabIndex="4" runat="server" Width="300px" DBDirection="Input" DBSize="100"
																DBParameterName="p_uni1" DBIndex="3" DBDataType="VarChar"></cc1:s_textbox></TD>
													</TR>
													<TR>
														<TD style="WIDTH: 178px; HEIGHT: 23px" align="left">Codice Cut</TD>
														<TD style="HEIGHT: 23px"><cc1:s_textbox id="S_UNI2" tabIndex="5" runat="server" Width="300px" DBDirection="Input" DBSize="100"
																DBParameterName="p_uni2" DBIndex="4" DBDataType="VarChar"></cc1:s_textbox></TD>
													</TR>
								</TR>
								<TR>
									<TD style="WIDTH: 178px; HEIGHT: 23px" align="left">Descrizione Cut</TD>
									<TD style="HEIGHT: 23px"><cc1:s_textbox id="S_UNI3" tabIndex="6" runat="server" Width="300px" DBDirection="Input" DBSize="100"
											DBParameterName="p_uni3" DBIndex="5" DBDataType="VarChar"></cc1:s_textbox></TD>
								</TR>
				</TR>
				<TR>
					<TD style="WIDTH: 178px; HEIGHT: 23px" align="left">Codice&nbsp;Ut</TD>
					<TD style="HEIGHT: 23px"><cc1:s_textbox id="S_UNI4" tabIndex="7" runat="server" Width="300px" DBDirection="Input" DBSize="100"
							DBParameterName="p_uni4" DBIndex="6" DBDataType="VarChar"></cc1:s_textbox></TD>
				</TR>
				</TR></TR>
				<TR>
					<TD style="WIDTH: 178px; HEIGHT: 23px" align="left">Descrizione Ut</TD>
					<TD style="HEIGHT: 23px"><cc1:s_textbox id="S_UNI5" tabIndex="8" runat="server" Width="300px" DBDirection="Input" DBSize="100"
							DBParameterName="p_uni5" DBIndex="7" DBDataType="VarChar"></cc1:s_textbox></TD>
				</TR>
				</TR></TR>
				<TR>
					<TD style="WIDTH: 178px; HEIGHT: 23px" align="left">Codice Cet</TD>
					<TD style="HEIGHT: 23px"><cc1:s_textbox id="S_UNI6" tabIndex="9" runat="server" Width="300px" DBDirection="Input" DBSize="100"
							DBParameterName="p_uni6" DBIndex="8" DBDataType="VarChar"></cc1:s_textbox></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 178px; HEIGHT: 23px" align="left">Descrizione Cet</TD>
					<TD style="HEIGHT: 23px"><cc1:s_textbox id="S_UNI7" tabIndex="10" runat="server" Width="300px" DBDirection="Input" DBSize="100"
							DBParameterName="p_uni7" DBIndex="9" DBDataType="VarChar"></cc1:s_textbox></TD>
				</TR>
			</TABLE>
			</asp:panel></TD></TR>
			<tr>
				<TD style="HEIGHT: 5%" vAlign="top" align="left"></TD>
				<TD style="HEIGHT: 5%" vAlign="top" align="left"><cc1:s_button id="btnsSalva" tabIndex="11" runat="server" CssClass="btn" Text="Salva"></cc1:s_button>&nbsp;
					<cc1:s_button id="btnsElimina" tabIndex="12" runat="server" CssClass="btn" Text="Elimina" CausesValidation="False"
						CommandType="Delete"></cc1:s_button>&nbsp;
					<asp:button id="btnAnnulla" tabIndex="13" runat="server" CssClass="btn" Text="Annulla" CausesValidation="False"></asp:button></TD>
			</tr>
			<TR>
				<TD style="HEIGHT: 1%" vAlign="top" align="left"></TD>
				<TD style="HEIGHT: 1%" vAlign="top" align="left">
					<hr SIZE="1" noShade>
				</TD>
			</TR>
			</TR>
			<TR>
				<TD style="HEIGHT: 5%" vAlign="top" align="left"></TD>
				<TD style="HEIGHT: 5%" vAlign="top" align="left"><asp:label id="lblFirstAndLast" runat="server"></asp:label>&nbsp;
				</TD>
			</TR>
			</TBODY></TABLE><asp:validationsummary id="vlsEdit" runat="server" ShowSummary="False" ShowMessageBox="True"></asp:validationsummary></TD></TR></TBODY></TABLE></form>
		<script language="javascript">parent.left.calcola();</script>
	</body>
</HTML>
