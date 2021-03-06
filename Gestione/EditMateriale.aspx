<%@ Register TagPrefix="uc1" TagName="PageTitle" Src="../WebControls/PageTitle.ascx" %>
<%@ Page language="c#" Codebehind="EditMateriale.aspx.cs" AutoEventWireup="false" Inherits="TheSite.Gestione.EditMateriale" %>
<%@ Register TagPrefix="uc1" TagName="CalendarPicker" Src="../WebControls/CalendarPicker.ascx" %>
<%@ Register TagPrefix="cc2" Namespace="Csy.WebControls" Assembly="CsyWebControls" %>
<%@ Register TagPrefix="cc1" Namespace="S_Controls" Assembly="S_Controls" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>EditMateriale</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="../Css/MainSheet.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body onbeforeunload="parent.left.valorizza()" MS_POSITIONING="GridLayout">
		<script language="javascript">
	
	
	
		</script>
		<form id="Form1" method="post" runat="server">
			<TABLE id="TableMain" style="Z-INDEX: 101; POSITION: absolute; WIDTH: 100%; HEIGHT: 100%; TOP: 0px; LEFT: 0px"
				cellSpacing="0" cellPadding="0" width="100%" align="center" border="0">
				<TR>
					<TD style="HEIGHT: 50px" align="center"><uc1:pagetitle id="PageTitle1" runat="server"></uc1:pagetitle></TD>
				</TR>
				<TR vAlign="top" align="center" height="95%">
					<TD>
						<TABLE id="tblFormInput" cellSpacing="1" cellPadding="1" align="center">
							<TBODY>
								<TR>
									<TD style="WIDTH: 5%; HEIGHT: 5%" vAlign="top" align="left"></TD>
									<TD style="HEIGHT: 5%" vAlign="top" align="left">
										<asp:label id="lblOperazione" runat="server" CssClass="TitleOperazione" Width="512px"></asp:label><cc2:messagepanel id="PanelMess" runat="server" ErrorIconUrl="~/Images/ico_critical.gif" MessageIconUrl="~/Images/ico_info.gif"></cc2:messagepanel></TD>
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
												<TBODY>
													<TR>
														<TD align="left">Codice Materiale&nbsp;
															<asp:RequiredFieldValidator id="rfvCodMat" runat="server" ControlToValidate="txtCodMateriale" ErrorMessage="Inserire il Codice!">*</asp:RequiredFieldValidator></TD>
														<TD>
															<cc1:S_TextBox id="txtCodMateriale" tabIndex="1" runat="server" DBIndex="0" DBParameterName="p_codice"
																DBSize="16" DBDirection="Input"></cc1:S_TextBox></TD>
													</TR>
													<TR>
														<TD align="left">Descrizione
															<asp:RequiredFieldValidator id="rfvDescrizione" runat="server" ControlToValidate="txtDescMateriale" ErrorMessage="Inserire la Descrizione!">*</asp:RequiredFieldValidator></TD>
									</TD>
									<TD>
										<cc1:S_TextBox id="txtDescMateriale" tabIndex="2" runat="server" Width="90%" DBIndex="1" DBParameterName="p_descrizione"
											DBSize="50" DBDirection="Input" DBDataType="VarChar"></cc1:S_TextBox></TD>
								</TR>
								<TR>
									<TD style="align: 'left'">Prezzo</TD>
									<TD>
										<asp:TextBox id="txtPrezzoIntero" style="TEXT-ALIGN: right" runat="server" Width="10%" MaxLength="8"
											tabIndex="3">0</asp:TextBox>,
										<asp:TextBox id="txtPrezzoDecimale" style="TEXT-ALIGN: left" runat="server" Width="5%" MaxLength="2"
											tabIndex="4">00</asp:TextBox>
										<asp:regularexpressionvalidator id="regIntero" ControlToValidate="txtPrezzoIntero" ErrorMessage="Controlare dati inseriti nella prima parte del campo Prezzo!"
											ValidationExpression="^[0-9]*$" Runat="server">*</asp:regularexpressionvalidator>
										<asp:regularexpressionvalidator id="regDecimale" ControlToValidate="txtPrezzoDecimale" ErrorMessage="Controlare dati inseriti nella seconda parte del campo Prezzo!"
											ValidationExpression="^[0-9]*$" Runat="server">*</asp:regularexpressionvalidator></TD>
					</TD>
				<TR>
					<TD align="left">Unit� di Misura
						<asp:RequiredFieldValidator id="rfvUnita" runat="server" ErrorMessage="Selezionare l'Unit� di Misura!" ControlToValidate="cmbUnita"
							InitialValue="0">*</asp:RequiredFieldValidator></TD>
					<TD>
						<P>&nbsp;</P>
						<P>
							<cc1:S_ComboBox style="Z-INDEX: 0" id="cmbUnita" tabIndex="5" runat="server" Width="248px" DBDirection="Input"
								DBSize="10" DBParameterName="p_unita" DBIndex="2" DBDataType="Integer"></cc1:S_ComboBox></P>
					</TD>
				</TR>
				<tr>
					<td align="left">Magazzino</td>
					<td>
						<cc1:S_ComboBox style="Z-INDEX: 0" id="cmbmagazzino" tabIndex="6" runat="server" Width="248px" DBDirection="Input"
							DBSize="10" DBParameterName="p_id_magazzino" DBIndex="4" DBDataType="Integer"></cc1:S_ComboBox></td>
				</tr>
			</TABLE>
			</asp:panel></TD></TR>
			<tr>
				<TD style="HEIGHT: 5%" vAlign="top" align="left"></TD>
				<TD style="HEIGHT: 5%" vAlign="top" align="left"><cc1:s_button id="btnsSalva" tabIndex="10" runat="server" Text="Salva" CssClass="btn"></cc1:s_button>&nbsp;
					<cc1:s_button id="btnsElimina" tabIndex="11" runat="server" Text="Elimina" CommandType="Delete"
						CausesValidation="False" CssClass="btn"></cc1:s_button>&nbsp;
					<asp:button id="btnAnnulla" tabIndex="12" runat="server" Text="Annulla" CausesValidation="False"
						CssClass="btn"></asp:button></TD>
			</tr>
			<TR>
				<TD style="HEIGHT: 5%" vAlign="top" align="left"></TD>
				<TD style="HEIGHT: 5%" vAlign="top" align="left"><asp:label id="lblFirstAndLast" runat="server"></asp:label>&nbsp;
				</TD>
			</TR>
			</TBODY></TABLE>
			<asp:validationsummary id="vlsEdit" runat="server" ShowMessageBox="True" ShowSummary="False"></asp:validationsummary></TD></TR></TBODY></TABLE></form>
		<script language="javascript">parent.left.calcola();</script>
	</body>
</HTML>
