<%@ Register TagPrefix="uc1" TagName="PageTitle" Src="../WebControls/PageTitle.ascx" %>
<%@ Page language="c#" Codebehind="GeneraReportLS.aspx.cs" AutoEventWireup="false" Inherits="TheSite.ManutenzioneProgrammata.GeneraReportLS" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>Genera Piano</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<LINK rel="stylesheet" type="text/css" href="../Css/MainSheet.css">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<TABLE style="Z-INDEX: 101; POSITION: absolute; TOP: 8px; LEFT: 8px" id="Table1" border="0"
				cellSpacing="1" cellPadding="1" width="100%">
				<TR>
					<TD align="center"><uc1:pagetitle id="PageTitle1" runat="server"></uc1:pagetitle></TD>
				</TR>
				<TR>
					<TD>
						<TABLE id="Table2" border="0" cellSpacing="0" cellPadding="0" width="100%">
							<TR id="trvi">
								<TD><asp:label id="lblAnno" runat="server">Anno:</asp:label></TD>
								<TD><asp:dropdownlist id="DropAnno" runat="server" Width="128px"></asp:dropdownlist></TD>
								<TD><asp:label id="lblMese" runat="server">Mese:</asp:label></TD>
								<TD><asp:dropdownlist id="DropMese" runat="server" Width="176px">
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
							<tr>
								<TD style="HEIGHT: 23px">
								Versione Report:
								<td style="HEIGHT: 23px" colSpan="3"><asp:dropdownlist id="DropFile" runat="server" Width="176px">
										<asp:ListItem Value="0">Revisione</asp:ListItem>
										<asp:ListItem Value="1">Definitiva</asp:ListItem>
									</asp:dropdownlist></td>
							</tr>
							<TR>
								<TD style="HEIGHT: 23px">Report&nbsp;da inviare:
								</TD>
								<TD colSpan="3"><INPUT style="WIDTH: 344px; HEIGHT: 18px" id="Uploader" size="28" type="file" name="Uploader"
										runat="server">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
									<asp:button style="Z-INDEX: 0" id="Button1" runat="server" Width="152px" Text="Upload Report"></asp:button><asp:label style="Z-INDEX: 0" id="Lblins" runat="server" Width="270px" Height="15px">Label</asp:label></TD>
							<TR>
								<TD style="HEIGHT: 23px">Genera il&nbsp;Report Anno/Mese Selezionati:</TD>
								<TD style="HEIGHT: 23px" colSpan="3"><asp:button id="BtInvia" runat="server" Width="152px" Text="Download Report"></asp:button></TD>
							</TR>
						</TABLE>
						<DIV>&nbsp;</DIV>
						<div>
							<div><A href="..\Doc_DB\GUIDA RAPIDA PIANI ESEGUITI.pdf" target="_blank"></A></div>
						</div>
					</TD>
				</TR>
				<TR>
					<TD><asp:label id="lblMessage" runat="server" ForeColor="Red"></asp:label></TD>
				</TR>
				<TR>
					<TD></TD>
				</TR>
				<TR>
					<TD></TD>
				</TR>
			</TABLE>
		</form>
	</body>
</HTML>
