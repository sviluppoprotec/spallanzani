<%@ Register TagPrefix="uc1" TagName="PageTitle" Src="../WebControls/PageTitle.ascx" %>
<%@ Page language="c#" Codebehind="GeneraPiano.aspx.cs" AutoEventWireup="false" Inherits="TheSite.ManutenzioneProgrammata.GeneraPiano" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>Genera Piano</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="../Css/MainSheet.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<TABLE id="Table1" style="Z-INDEX: 101; LEFT: 8px; POSITION: absolute; TOP: 8px" cellSpacing="1"
				cellPadding="1" width="100%" border="0">
				<TR>
					<TD align="center"><uc1:pagetitle id="PageTitle1" runat="server"></uc1:pagetitle></TD>
				</TR>
				<TR>
					<TD>
						<TABLE id="Table2" cellSpacing="0" cellPadding="0" width="100%" border="0">
							<TR>
								<TD>Edificio:</TD>
								<TD><asp:dropdownlist id="DrEdifici" runat="server" Width="280px"></asp:dropdownlist></TD>
								<TD>Tipo Documento:</TD>
								<TD><asp:dropdownlist id="DrTipoDocumenti" runat="server" Width="280px">
										<asp:ListItem Value="1">File XLS</asp:ListItem>
										<asp:ListItem Value="2">File A8</asp:ListItem>
									</asp:dropdownlist></TD>
							</TR>
							<TR id="trvi">
								<TD><asp:label id="lblAnno" runat="server">Anno:</asp:label></TD>
								<TD><asp:dropdownlist id="DropAnno" runat="server" Width="128px"></asp:dropdownlist></TD>
								<TD><asp:label id="lblMese" runat="server">Mese:</asp:label></TD>
								<TD><asp:dropdownlist id="DropMese" runat="server" Width="176px">
										<asp:ListItem Value="1">Gennaio</asp:ListItem>
										<asp:ListItem Value="2">Febbraio</asp:ListItem>
										<asp:ListItem Value="3">Marzo</asp:ListItem>
										<asp:ListItem Value="4">Aprile</asp:ListItem>
										<asp:ListItem Value="5">Maggio</asp:ListItem>
										<asp:ListItem Value="6">Giugno</asp:ListItem>
										<asp:ListItem Value="7">Luglio</asp:ListItem>
										<asp:ListItem Value="8">Agosto</asp:ListItem>
										<asp:ListItem Value="9">Settembre</asp:ListItem>
										<asp:ListItem Value="10">Ottobre</asp:ListItem>
										<asp:ListItem Value="11">Novembre</asp:ListItem>
										<asp:ListItem Value="12">Dicembre</asp:ListItem>
									</asp:dropdownlist></TD>
							</TR>
							<TR>
								<TD>Tipo Documentoi:</TD>
								<TD colSpan="3"></TD>
							</TR>
							<TR>
								<TD style="HEIGHT: 23px">Genera il&nbsp;Documento:</TD>
								<TD colSpan="3" style="HEIGHT: 23px">
									<asp:button id="BtInvia" runat="server" Width="152px" Text="Genera Piano"></asp:button></TD>
							</TR>
							<TR>
								<TD></TD>
								<TD colSpan="3"></TD>
							</TR>
						</TABLE>
						<div>&nbsp;</div>
						<div>
							<div><a href="..\Doc_DB\GUIDA RAPIDA PIANI ESEGUITI.pdf" target="_blank"></a></div>
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
