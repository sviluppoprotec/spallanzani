<%@ Page language="c#" Codebehind="Allegawo.aspx.cs" AutoEventWireup="false" Inherits="TheSite.ManutenzioneProgrammata.Allegawo" %>
<%@ Register TagPrefix="uc1" TagName="PageTitle" Src="../WebControls/PageTitle.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>Aggiornamento Ordine di Lavoro</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<LINK rel="stylesheet" type="text/css" href="../Css/MainSheet.css">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<TABLE id="Table1" border="0" cellSpacing="0" cellPadding="0" width="100%">
				<TBODY>
					<TR>
						<TD align="center"><uc1:pagetitle id="PageTitle1" runat="server"></uc1:pagetitle></TD>
					</TR>
					<TR>
						<TD><INPUT style="WIDTH: 392px; HEIGHT: 18px" id="UploadFile" size="46" type="file" name="UploadFile"
								runat="server">&nbsp;
							<asp:button id="BtUpload" runat="server" Text="Invia il File..."></asp:button></TD>
					</TR>
					<TR>
						<TD style="HEIGHT: 14px"><b>File Allegato:</b>
							<asp:label id="lblfileAllegato" runat="server" Font-Bold="True"></asp:label>
							<asp:button style="Z-INDEX: 0" id="Button1" runat="server" Text="Elimina File Allegato" Visible="False"></asp:button></TD>
					</TR>
					<tr>
						<td style="DISPLAY:none">
							<asp:label id="lblestfile" runat="server" Font-Bold="True" Visible="False" style="Z-INDEX: 101; POSITION: absolute; TOP: 104px; LEFT: 104px"></asp:label>
						</td>
					</tr>
				</TBODY>
			</TABLE>
		</form>
	</body>
</HTML>
