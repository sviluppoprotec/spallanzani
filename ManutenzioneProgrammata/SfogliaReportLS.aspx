<%@ Register TagPrefix="uc1" TagName="PageTitle" Src="../WebControls/PageTitle.ascx" %>
<%@ Register TagPrefix="uc1" TagName="CalendarPicker" Src="../WebControls/CalendarPicker.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Addetti" Src="../WebControls/Addetti.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Richiedenti" Src="../WebControls/Richiedenti.ascx" %>
<%@ Register TagPrefix="uc1" TagName="RicercaModulo" Src="../WebControls/RicercaModulo.ascx" %>
<%@ Register TagPrefix="cc1" Namespace="S_Controls" Assembly="S_Controls" %>
<%@ Register TagPrefix="uc1" TagName="GridTitle" Src="../WebControls/GridTitle.ascx" %>
<%@ Register TagPrefix="Collapse" Namespace="Csy.WebControls" Assembly="CsyWebControls" %>
<%@ Page language="c#" Codebehind="SfogliaReportLS.aspx.cs" AutoEventWireup="false" Inherits="TheSite.ManutenzioneProgrammata.SfogliaReportLS" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>Sfoglia Rdl SGA DIE</title>
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
					<TD><COLLAPSE:DATAPANEL id="PanelRicerca" runat="server" TitleStyle-CssClass="TitleSearch" CssClass="DataPanel75"
							TitleText="Ricerca" AllowTitleExpandCollapse="True" Collapsed="False" ExpandText="Espandi" CollapseText="Riduci"
							CollapseImageUrl="../Images/up.gif" ExpandImageUrl="../Images/down.gif">
							<TABLE style="WIDTH: 100%; HEIGHT: 184px" id="tblSearch100" border="0" cellSpacing="1"
								cellPadding="2">
								<TR>
									<TD colSpan="4" align="left"></TD>
								</TR>
								<TR>
									<TD width="13%" align="left">Nome Documento:</TD>
									<TD width="30%">
										<asp:TextBox id="txtDescrizione" runat="server" width="272px" MaxLength="255"></asp:TextBox></TD>
									<TD width="15%" align="left"></TD>
									<TD width="30%"></TD>
								</TR>
								<TR>
									<TD align="left">Anno:</TD>
									<TD>
										<asp:dropdownlist style="Z-INDEX: 0" id="DropAnno" runat="server" Width="128px"></asp:dropdownlist></TD>
									<TD align="left"></TD>
									<TD></TD>
								</TR>
								<TR>
									<TD align="left">Mese:</TD>
									<TD>
										<asp:dropdownlist id="cmbsmese" runat="server" Width="99%">
											<asp:ListItem Value="00">Selezionare Mese</asp:ListItem>
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
									<TD align="left"></TD>
									<TD></TD>
								</TR>
								<TR>
									<TD style="HEIGHT: 16px" colSpan="4" align="left"></TD>
								</TR>
								<TR>
									<TD colSpan="3" align="left">
										<cc1:s_button id="btnsRicerca" runat="server" Text="Ricerca"></cc1:s_button>&nbsp;
										<asp:Button id="cmdReset" Text="Reset" Runat="server"></asp:Button>&nbsp;
										<asp:ValidationSummary id="ValidationSummary1" runat="server"></asp:ValidationSummary>
										<asp:Label id="LblMessage" runat="server"></asp:Label></TD>
									<TD align="right"><A class=GuidaLink href="<%= HelpLink %>" 
            target=_blank>Guida</A></TD>
								</TR>
							</TABLE>
						</COLLAPSE:DATAPANEL></TD>
				</TR>
				<TR>
					<TD style="HEIGHT: 72%" vAlign="top" align="center"><uc1:gridtitle id="GridTitle1" runat="server"></uc1:gridtitle><asp:datagrid id="DataGridRicerca" runat="server" CssClass="DataGrid" DataKeyField="id" AllowPaging="True"
							BorderColor="Gray" BorderWidth="1px" GridLines="Vertical" AutoGenerateColumns="False" PageSize="20">
							<FooterStyle ForeColor="#003399" BackColor="#99CCCC"></FooterStyle>
							<AlternatingItemStyle CssClass="DataGridAlternatingItemStyle"></AlternatingItemStyle>
							<ItemStyle CssClass="DataGridItemStyle"></ItemStyle>
							<HeaderStyle CssClass="DataGridHeaderStyle"></HeaderStyle>
							<Columns>
								<asp:BoundColumn Visible="False" DataField="id" HeaderText="ID"></asp:BoundColumn>
								<asp:TemplateColumn HeaderText="Download">
									<HeaderStyle HorizontalAlign="Center" Width="20px" VerticalAlign="Middle">
									</HeaderStyle>
									<ItemStyle HorizontalAlign="Center" VerticalAlign="Middle"></ItemStyle>
									<ItemTemplate>
										<asp:ImageButton id="btScarica" Runat="server" CommandName="Download" ImageUrl="../images/Excel.gif" CommandArgument='<%#  DataBinder.Eval(Container.DataItem,"nomefile")%>'>
										</asp:ImageButton>
									</ItemTemplate>
								</asp:TemplateColumn>
								<asp:BoundColumn DataField="nomefile" HeaderText="Nome File">
									<HeaderStyle Width="50px"></HeaderStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="firstmodified" HeaderText="Data Inserimento" DataFormatString="{0:dd/MM/yyyy HH:mm:ss}"></asp:BoundColumn>
								<asp:BoundColumn DataField="revisione" HeaderText="Revisione"></asp:BoundColumn>
								<asp:BoundColumn DataField="versione" HeaderText="Versione Report"></asp:BoundColumn>
								<asp:BoundColumn DataField="mese" HeaderText="mese"></asp:BoundColumn>
								<asp:BoundColumn DataField="anno" HeaderText="anno"></asp:BoundColumn>
							</Columns>
							<PagerStyle HorizontalAlign="Left" CssClass="DataGridPagerStyle" Mode="NumericPages"></PagerStyle>
						</asp:datagrid></TD>
				</TR>
			</TABLE>
			</TD></TR></TBODY></TABLE></form>
		</TR></TBODY></TABLE></TR></TBODY></TABLE></TR></TBODY></TABLE></FORM>
		<script language="javascript">parent.left.calcola();</script>
	</body>
</HTML>
