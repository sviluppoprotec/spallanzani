<%@ Page language="c#" Codebehind="EliminaVista.aspx.cs" AutoEventWireup="false" Inherits="TheSite.GIC.Report.EliminaVista" %>
<%@ Register TagPrefix="uc1" TagName="PageTitle" Src="../../WebControls/PageTitle.ascx" %>
<!DOCTYPE html public "-//w3c//dtd html 4.0 transitional//en" >
<HTML>
	<HEAD>
		<TITLE>NuovoSchema</TITLE>
		<META content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<META content="C#" name="CODE_LANGUAGE">
		<META content="JavaScript" name="vs_defaultClientScript">
		<META content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="../style/StyleSheetReport.css" type="text/css" rel="stylesheet">
		<LINK href="../../Css/MainSheet.css" type="text/css" rel="stylesheet">
	</HEAD>
	<BODY>
		<FORM id="Form1" method="post" runat="server">
			<TABLE id="TableMain" style="Z-INDEX: 101; POSITION: absolute; WIDTH: 100%; HEIGHT: 100%; TOP: 0px; LEFT: 0px"
				cellspacing="0" cellpadding="0" width="100%" align="center" border="0">
				<TR>
					<TD style="HEIGHT: 50px" align="center">
						<UC1:PAGETITLE id="PageTitle1" runat="server"></UC1:PAGETITLE></TD>
				</TR>
				<TR valign="top" align="center" height="95%">
					<TD>
						<TABLE id="tblFormInput" cellspacing="1" cellpadding="1" align="center">
							<TBODY>
								<TR>
									<TD style="WIDTH: 5%; HEIGHT: 5%" valign="top" align="left"></TD>
									<TD style="HEIGHT: 5%" valign="top" align="left"><ASP:LABEL id="lblOperazione" runat="server" width="512px" cssclass="TitleOperazione">Insedrisci Nuova Vista</ASP:LABEL></TD>
								</TR>
								<TR>
									<TD style="HEIGHT: 1%" valign="top" align="left">
									</TD>
									<TD style="HEIGHT: 1%" valign="top" align="left">
										<HR noshade size="1">
									</TD>
								</TR>
								<TR>
									<TD valign="top" align="center"></TD>
									<TD valign="top" align="left">
										<ASP:PANEL id="PanelEdit" runat="server">
											<TABLE id="tblSearch75" border="0" cellSpacing="1" cellPadding="2">
												<TR>
													<TD style="WIDTH: 178px; HEIGHT: 24px" align="left">&nbsp;</TD>
													<TD style="HEIGHT: 24px"></TD>
												</TR>
												<TR>
													<TD style="WIDTH: 178px; HEIGHT: 23px" align="left">
														<ASP:LABEL id="lblNomeVista" runat="server">Nome Vista</ASP:LABEL>
														<ASP:REQUIREDFIELDVALIDATOR id="rfvCodMat" runat="server" controltovalidate="txtNomeVista" errormessage="Inserire il nome della vista">*</ASP:REQUIREDFIELDVALIDATOR></TD>
													<TD style="HEIGHT: 23px">
														<ASP:TEXTBOX id="txtNomeVista" runat="server" width="200px" readonly="True" height="20px"></ASP:TEXTBOX></TD>
												</TR>
												<TR>
													<TD style="WIDTH: 178px; HEIGHT: 23px" align="left">
														<ASP:LABEL id="lblDescrtizione" runat="server">Descrizione</ASP:LABEL>
														<ASP:REQUIREDFIELDVALIDATOR id="rfvDescrizione" runat="server" controltovalidate="txtDescrizione" errormessage="Inserire la Descrizione!">*</ASP:REQUIREDFIELDVALIDATOR></TD>
													<TD style="HEIGHT: 23px">
														<ASP:TEXTBOX id="txtDescrizione" runat="server" width="200px" readonly="True" height="20px"></ASP:TEXTBOX></TD>
												<TR>
													<TD style="WIDTH: 178px; HEIGHT: 17px" align="left"></TD>
													<TD style="HEIGHT: 17px"></TD>
												</TR>
											</TABLE>
										</ASP:PANEL>
									</TD>
								</TR>
								<TR>
									<TD style="HEIGHT: 5%" valign="top" align="left"></TD>
									<TD style="HEIGHT: 5%" valign="top" align="left">&nbsp;
										<ASP:BUTTON id="btnElimina" runat="server" text="Elimina" cssclass="btn" width="100px" causesvalidation="False"></ASP:BUTTON>&nbsp;&nbsp;
										<ASP:BUTTON id="btnAnnulla" tabindex="12" runat="server" text="Annulla" causesvalidation="False"
											cssclass="btn" width="100px"></ASP:BUTTON></TD>
								</TR>
								<TR>
									<TD style="HEIGHT: 1%" valign="top" align="left"></TD>
									<TD style="HEIGHT: 1%" valign="top" align="left">
										<HR noshade size="1">
									</TD>
								</TR>
				</TR>
				<TR>
					<TD style="HEIGHT: 5%" valign="top" align="left"></TD>
					<TD style="HEIGHT: 5%" valign="top" align="left"><ASP:LABEL id="lblFirstAndLast" runat="server"></ASP:LABEL>&nbsp;
					</TD>
				</TR>
			</TABLE>
			<ASP:VALIDATIONSUMMARY id="vlsEdit" runat="server" showmessagebox="True" showsummary="False"></ASP:VALIDATIONSUMMARY></TD></TR></TBODY></TABLE></FORM>
	</BODY>
</HTML>
