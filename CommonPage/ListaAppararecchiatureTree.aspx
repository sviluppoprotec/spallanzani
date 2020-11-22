<%@ Register TagPrefix="iewc" Namespace="Microsoft.Web.UI.WebControls" Assembly="Microsoft.Web.UI.WebControls" %>
<%@ Page language="c#" Codebehind="ListaAppararecchiatureTree.aspx.cs" AutoEventWireup="false" Inherits="TheSite.CommonPage.ListaAppararecchiatureTree" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>ListaAppararecchiatureTree</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<TABLE style="Z-INDEX: 101; POSITION: absolute; WIDTH: 824px; HEIGHT: 113px; TOP: 8px; LEFT: 8px"
				id="Table1" border="1" cellSpacing="1" cellPadding="1" width="824">
				<TR>
					<TD>
						<asp:Button style="Z-INDEX: 0" id="Button1" runat="server" Text="Button"></asp:Button></TD>
				</TR>
				<TR>
					<TD height=500>
						<iewc:treeview style="Z-INDEX: 0" id="TreeCtrl" runat="server" EnableViewState="False" Height="45px"
							Width="544px"></iewc:treeview></TD>
				</TR>
				<TR>
					<TD>
						<asp:Label style="Z-INDEX: 0" id="Label1" runat="server">Label</asp:Label></TD>
				</TR>
			</TABLE>
		</form>
	</body>
</HTML>
