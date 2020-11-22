<%@ Register TagPrefix="uc1" TagName="PageTitle" Src="../WebControls/PageTitle.ascx" %>
<%@ Register TagPrefix="uc1" TagName="GridTitle" Src="../WebControls/GridTitle.ascx" %>
<%@ Register TagPrefix="cc1" Namespace="S_Controls" Assembly="S_Controls" %>
<%@ Register TagPrefix="uc1" TagName="RicercaModulo" Src="../WebControls/RicercaModulo.ascx" %>
<%@ Register TagPrefix="Collapse" Namespace="Csy.WebControls" Assembly="CsyWebControls" %>
<%@ Page language="c#" Codebehind="CP.aspx.cs" AutoEventWireup="false" Inherits="TheSite.GestioneControlliPeriodici.CP" %>
<%@ Register TagPrefix="uc1" TagName="CalendarPicker" Src="../WebControls/CalendarPicker.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>Settori</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="../Css/MainSheet.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body onbeforeunload="parent.left.valorizza()" MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<TABLE id="TableMain" style="Z-INDEX: 101; POSITION: absolute; TOP: 0px; LEFT: 0px" cellSpacing="0"
				cellPadding="0" width="100%" align="center" border="0">
				<TR>
					<TD style="HEIGHT: 50px" align="center"><uc1:pagetitle id="PageTitle1" runat="server"></uc1:pagetitle></TD>
				</TR>
				<TR>
					<TD vAlign="top" align="center" height="95%">
						<TABLE id="tblForm" cellSpacing="1" cellPadding="1" align="center">
							<TR>
								<TD style="HEIGHT: 25%" vAlign="top" align="left"><COLLAPSE:DATAPANEL id="PanelRicerca" runat="server" ExpandImageUrl="../Images/downarrows_trans.gif"
										CollapseImageUrl="../Images/uparrows_trans.gif" CollapseText="Riduci" ExpandText="Espandi" Collapsed="False" AllowTitleExpandCollapse="True" TitleText="Ricerca"
										CssClass="DataPanel75" TitleStyle-CssClass="TitleSearch">
										<TABLE id="tblSearch100" border="0" cellSpacing="0" cellPadding="2">
											<TBODY>
												<TR>
													<TD colspan="4">
														<TABLE style="WIDTH: 100%" id="TableRicercaModulo" border="0" cellSpacing="1" cellPadding="1">
															<TR>
																<TD><uc1:ricercamodulo id="RicercaModulo1" runat="server"></uc1:ricercamodulo></TD>
															</TR>
														</TABLE>
													</TD>
												</TR>
												<TR>
													<TD width="20%" align="left">Nr Controllo</TD>
													<TD width="30%">
														<cc1:s_textbox id="txtsCodice" runat="server" DBParameterName="p_id_wr_cp" DBDirection="Input"
															width="208px" DBSize="15" MaxLength="15"></cc1:s_textbox></TD>
													<TD width="20%" align="left">Descrizione</TD>
													<TD width="30%">
														<cc1:s_textbox id="txtsDescrizione" tabIndex="2" runat="server" DBParameterName="p_Descrizione"
															DBDirection="Input" width="288px" DBSize="255" MaxLength="255" DBIndex="1"></cc1:s_textbox></TD>
												</TR>
												<TR>
													<TD width="20%" align="left">Data Ricerca Inizio</TD>
													<TD width="30%">
														<uc1:CalendarPicker id="CalendarPicker1" runat="server"></uc1:CalendarPicker></TD>
													<TD width="20%" align="left">Data Ricerca Completamento</TD>
													<TD width="30%">
														<uc1:CalendarPicker id="CalendarPicker2" runat="server"></uc1:CalendarPicker></TD>
												</TR>
												<TR>
													<TD width="20%" align="left">Stato Controllo</TD>
													<TD width="30%">
														<asp:dropdownlist id="ListCompl" runat="server" Width="256px">
															<asp:ListItem Value="1">Controlli Non Completati\Completati </asp:ListItem>
															<asp:ListItem Value="2">Controlli Non Completati</asp:ListItem>
															<asp:ListItem Value="3">Controlli Completati</asp:ListItem>
														</asp:dropdownlist></TD>
								</TD>
								<TD width="20%" align="left">Nome File</TD>
								<TD width="30%">
									<cc1:s_textbox id="nomeFile" runat="server" DBParameterName="nomeFile" DBDirection="Input" width="208px"
										DBSize="15" MaxLength="15"></cc1:s_textbox>
								</TD>
								<TD width="20%" align="left"></TD>
								<TD width="30%"></TD>
							</TR>
							<TR>
								<TD colSpan="3" align="left">
									<cc1:s_button id="btnsRicerca" runat="server" CssClass="btn" Text="Ricerca"></cc1:s_button>&nbsp;
									<asp:Button id="BtnReset" runat="server" CssClass="btn" Text="Reset"></asp:Button></TD>
								<TD align="right"><A class=GuidaLink href="<%= HelpLink %>" 
                  target=_blank>Guida</A></TD>
							</TR>
						</TABLE>
						</COLLAPSE:DATAPANEL></TD>
				</TR>
				<TR>
					<TD style="HEIGHT: 3%" align="center"></TD>
				<TR>
					<TD style="HEIGHT: 72%" vAlign="top" align="center"><uc1:gridtitle id="GridTitle1" runat="server"></uc1:gridtitle><asp:datagrid id="DataGridRicerca" runat="server" CssClass="DataGrid" BorderColor="Gray" BorderWidth="1px"
							GridLines="Vertical" AutoGenerateColumns="False" AllowPaging="True">
							<AlternatingItemStyle CssClass="DataGridAlternatingItemStyle"></AlternatingItemStyle>
							<ItemStyle CssClass="DataGridItemStyle"></ItemStyle>
							<HeaderStyle CssClass="DataGridHeaderStyle"></HeaderStyle>
							<Columns>
								<asp:BoundColumn Visible="False" DataField="id" HeaderText="ID"></asp:BoundColumn>
								<asp:TemplateColumn>
									<HeaderStyle Width="3%"></HeaderStyle>
									<ItemStyle HorizontalAlign="Center" VerticalAlign="Middle"></ItemStyle>
									<ItemTemplate>
										<asp:ImageButton id="Imagebutton2" Runat=server CommandName="Dettaglio" ImageUrl="~/images/edit.gif" CommandArgument='<%# "INSCP.aspx?ItemID=" + DataBinder.Eval(Container.DataItem,"ID") + "&FunId=" + FunId + "&TipoOper=write"%>'>
										</asp:ImageButton>
									</ItemTemplate>
								</asp:TemplateColumn>
								<asp:BoundColumn DataField="id" HeaderText="Nr Controllo">
									<HeaderStyle Width="5%"></HeaderStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="descrizione" HeaderText="Descrizione Controllo">
									<HeaderStyle Width="65%"></HeaderStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="nomefilecp" HeaderText="File Allegato"></asp:BoundColumn>
								<asp:BoundColumn DataField="data_inizio_prevista" HeaderText="Data Prevista" DataFormatString="{0:d}">
									<HeaderStyle Width="15%"></HeaderStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="data_completamento_fine" HeaderText="Data Completamento" DataFormatString="{0:d}">
									<HeaderStyle Width="15%"></HeaderStyle>
								</asp:BoundColumn>
							</Columns>
							<PagerStyle Mode="NumericPages"></PagerStyle>
						</asp:datagrid></TD>
				</TR>
			</TABLE>
			</TD></TR></TBODY></TABLE>
		</form>
		<script language="javascript">parent.left.calcola();</script>
	</body>
</HTML>
