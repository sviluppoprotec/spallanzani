<%@ Register TagPrefix="Collapse" Namespace="Csy.WebControls" Assembly="CsyWebControls" %>
<%@ Register TagPrefix="cc1" Namespace="S_Controls" Assembly="S_Controls" %>
<%@ Register TagPrefix="uc1" TagName="GridTitle" Src="../WebControls/GridTitle.ascx" %>
<%@ Register TagPrefix="uc1" TagName="PageTitle" Src="../WebControls/PageTitle.ascx" %>
<%@ Page language="c#" Codebehind="Canoni.aspx.cs" AutoEventWireup="false" Inherits="TheSite.Gestione.Canoni" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>Anagrafica Contabilizzazione</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<LINK rel="stylesheet" type="text/css" href="../Css/MainSheet.css">
		<script language="javascript">
	function Pulisci()
	{
		document.getElementById("txtsDescrizione").value=""
		document.getElementById("txtsDescrizioneBreve").value=""		
		
	}
	
		</script>
	</HEAD>
	<body onbeforeunload="parent.left.valorizza()" MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<TABLE style="Z-INDEX: 101; POSITION: absolute; TOP: 0px; LEFT: 0px" id="TableMain" border="0"
				cellSpacing="0" cellPadding="0" width="100%" align="center">
				<TR>
					<TD style="HEIGHT: 50px" align="center"><uc1:pagetitle id="PageTitle1" runat="server"></uc1:pagetitle></TD>
				</TR>
				<TR>
					<TD height="95%" vAlign="top" align="center">
						<TABLE id="tblForm" cellSpacing="1" cellPadding="1" align="center">
							<TR>
								<TD style="HEIGHT: 25%" vAlign="top" align="left"><COLLAPSE:DATAPANEL id="PanelRicerca" runat="server" TitleStyle-CssClass="TitleSearch" CssClass="DataPanel75"
										TitleText="Ricerca" AllowTitleExpandCollapse="True" Collapsed="False" ExpandText="Espandi" CollapseText="Riduci" CollapseImageUrl="../Images/up.gif"
										ExpandImageUrl="../Images/down.gif">
										<TABLE id="tblSearch100" border="0" cellSpacing="0" cellPadding="2">
											<TR>
												<TD style="WIDTH: 119px" width="119" align="left">Descrizione</TD>
												<TD style="WIDTH: 399px" width="399">
													<cc1:s_textbox id="txtsDescrizione" tabIndex="1" runat="server" DBDirection="Input" DBSize="50"
														DBParameterName="p_DESCRIZIONE" width="384px"></cc1:s_textbox></TD>
											</TR>
											<TR>
												<TD>Mese</TD>
												<TD>
													<asp:dropdownlist style="Z-INDEX: 0" id="DropMese" runat="server" Width="128px">
														<asp:ListItem Value="00">-Seleziona Mese-</asp:ListItem>
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
												<TD>
													<CC1:S_COMBOBOX style="Z-INDEX: 0" id="S_anno" tabIndex="2" runat="server" DBDirection="Input" DBSize="10"
														DBParameterName="p_id_servizio" DBIndex="2" DBDataType="Integer" Width="128px"></CC1:S_COMBOBOX></TD>
											</TR>
											<TR>
												<TD style="WIDTH: 522px" colSpan="2" align="left">
													<cc1:s_button id="btnsRicerca" tabIndex="3" runat="server" CssClass="btn" Text="Ricerca"></cc1:s_button>&nbsp;
													<cc1:S_Button id="BtnReset" tabIndex="4" runat="server" CssClass="btn" Text="Reset"></cc1:S_Button></TD>
												<TD align="right"><A class=GuidaLink href="<%= HelpLink %>" 
                  target=_blank>Guida</A></TD>
											</TR>
										</TABLE>
									</COLLAPSE:DATAPANEL></TD>
							</TR>
							<TR>
								<TD style="HEIGHT: 3%" align="center"></TD>
							<TR>
								<TD style="HEIGHT: 72%" vAlign="top" align="center"><uc1:gridtitle id="GridTitle1" runat="server"></uc1:gridtitle><asp:datagrid id="DataGridRicerca" runat="server" CssClass="DataGrid" AllowPaging="True" AutoGenerateColumns="False"
										GridLines="Vertical" BorderWidth="1px" BorderColor="Gray">
										<AlternatingItemStyle CssClass="DataGridAlternatingItemStyle"></AlternatingItemStyle>
										<ItemStyle CssClass="DataGridItemStyle"></ItemStyle>
										<HeaderStyle CssClass="DataGridHeaderStyle"></HeaderStyle>
										<Columns>
											<asp:BoundColumn Visible="False" DataField="id" HeaderText="ID" DataFormatString="{0:C}"></asp:BoundColumn>
											<asp:TemplateColumn>
												<HeaderStyle Width="2%"></HeaderStyle>
												<ItemStyle HorizontalAlign="Center" VerticalAlign="Middle"></ItemStyle>
												<ItemTemplate>
													<asp:ImageButton id="Imagebutton3" Runat=server CommandName="Dettaglio" ImageUrl="~/images/Search16x16_bianca.jpg" CommandArgument='<%# "EditCanoni.aspx?ItemID=" + DataBinder.Eval(Container.DataItem,"ID") + "&FunId=" + FunId + "&TipoOper=read"%>'>
													</asp:ImageButton>
												</ItemTemplate>
											</asp:TemplateColumn>
											<asp:TemplateColumn>
												<HeaderStyle Width="2%"></HeaderStyle>
												<ItemStyle HorizontalAlign="Center" VerticalAlign="Middle"></ItemStyle>
												<ItemTemplate>
													<asp:ImageButton id="Imagebutton2" Runat=server CommandName="Dettaglio" ImageUrl="~/images/edit.gif" CommandArgument='<%# "EditCanoni.aspx?ItemID=" + DataBinder.Eval(Container.DataItem,"ID") + "&FunId=" + FunId + "&TipoOper=write"%>'>
													</asp:ImageButton>
												</ItemTemplate>
											</asp:TemplateColumn>
											<asp:BoundColumn DataField="descrizione" HeaderText="Descrizione">
												<HeaderStyle Width="26%"></HeaderStyle>
											</asp:BoundColumn>
											<asp:BoundColumn DataField="meseanno" HeaderText="Mese/Anno">
												<HeaderStyle Width="35%"></HeaderStyle>
											</asp:BoundColumn>
											<asp:BoundColumn DataField="importo" HeaderText="importo €">
												<HeaderStyle Width="35%"></HeaderStyle>
											</asp:BoundColumn>
											<asp:TemplateColumn HeaderText="Download file">
												<HeaderStyle Width="5%"></HeaderStyle>
												<ItemStyle HorizontalAlign="Center"></ItemStyle>
												<ItemTemplate>
													<asp:LinkButton id=LinkButton1 runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"nomefile") %>' OnCommand="LinkButton1_Click" CommandArgument='<%# DataBinder.Eval(Container.DataItem,"nomefile") %>'>
													</asp:LinkButton>
												</ItemTemplate>
											</asp:TemplateColumn>
										</Columns>
										<PagerStyle Mode="NumericPages"></PagerStyle>
									</asp:datagrid></TD>
							</TR>
						</TABLE>
					</TD>
				</TR>
			</TABLE>
		</form>
		<script language="javascript">parent.left.calcola();</script>
	</body>
</HTML>