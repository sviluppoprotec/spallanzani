<%@ Register TagPrefix="uc1" TagName="PageTitle" Src="../WebControls/PageTitle.ascx" %>
<%@ Register TagPrefix="uc1" TagName="GridTitle" Src="../WebControls/GridTitle.ascx" %>
<%@ Register TagPrefix="cc1" Namespace="S_Controls" Assembly="S_Controls" %>
<%@ Register TagPrefix="uc1" TagName="RicercaModulo" Src="../WebControls/RicercaModulo.ascx" %>
<%@ Register TagPrefix="Collapse" Namespace="Csy.WebControls" Assembly="CsyWebControls" %>
<%@ Page language="c#" Codebehind="ric_doc_normativi.aspx.cs" AutoEventWireup="false" Inherits="TheSite.GestioneControlliPeriodici.ric_doc_normativi" %>
<%@ Register TagPrefix="uc1" TagName="CalendarPicker" Src="../WebControls/CalendarPicker.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>Settori</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<LINK rel="stylesheet" type="text/css" href="../Css/MainSheet.css">
	</HEAD>
	<body>
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
										TitleText="Ricerca" AllowTitleExpandCollapse="True" Collapsed="False" ExpandText="Espandi" CollapseText="Riduci" CollapseImageUrl="../Images/uparrows_trans.gif"
										ExpandImageUrl="../Images/downarrows_trans.gif">
										<TABLE id="tblSearch100" border="0" cellSpacing="0" cellPadding="2">
											<TR>
												<TD width="190" align="left">Nome Documento</TD>
												<TD>
													<cc1:s_textbox style="Z-INDEX: 0" id="txtsNomeDoc" runat="server" DBParameterName="nome_doc" DBDirection="Input"
														width="208px" DBSize="15" MaxLength="15"></cc1:s_textbox></TD>
											</TR>
											<TR>
												<TD width="190" align="left">Descrizione Documento</TD>
												<TD colSpan="3">
													<CC1:S_TEXTBOX id="txtsDescDoc" tabIndex="2" runat="server" DBParameterName="desc_doc" width="441px"
														Height="48px" TextMode="MultiLine" dbindex="3" maxlength="1000" dbdirection="Input" dbsize="255"></CC1:S_TEXTBOX></TD>
											</TR>
											<TR>
												<TD width="190" align="left">Norma di Appartenenza</TD>
												<TD>
													<cc1:s_textbox id="txtsNormaApp" runat="server" DBParameterName="p_norma_appartenenza" DBDirection="Input"
														width="208px" DBSize="15" MaxLength="15"></cc1:s_textbox></TD>
											</TR>
											<TR>
												<TD vAlign="top" width="190">File da inviare:
												</TD>
												<TD>
													<cc1:s_textbox id="nomeFile" runat="server" DBParameterName="nomeFile" DBDirection="Input" width="208px"
														DBSize="15" MaxLength="15"></cc1:s_textbox></TD>
											</TR>
											<TR>
												<TD width="190" align="left">Versione Documento</TD>
												<TD>
													<cc1:s_textbox style="Z-INDEX: 0" id="txtsVersDoc" runat="server" DBParameterName="versione_doc"
														DBDirection="Input" width="208px" DBSize="15" MaxLength="15"></cc1:s_textbox></TD>
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
								<TD style="HEIGHT: 72%" vAlign="top" align="center"><uc1:gridtitle id="GridTitle1" runat="server"></uc1:gridtitle><asp:datagrid id="DataGridRicerca" runat="server" CssClass="DataGrid" AllowPaging="True" AutoGenerateColumns="False"
										GridLines="Vertical" BorderWidth="1px" BorderColor="Gray">
										<AlternatingItemStyle CssClass="DataGridAlternatingItemStyle"></AlternatingItemStyle>
										<ItemStyle CssClass="DataGridItemStyle"></ItemStyle>
										<HeaderStyle CssClass="DataGridHeaderStyle"></HeaderStyle>
										<Columns>
											<asp:BoundColumn Visible="False" DataField="id_doc_norm" HeaderText="ID"></asp:BoundColumn>
											<asp:TemplateColumn HeaderText="Download">
												<HeaderStyle HorizontalAlign="Center" Width="20px" VerticalAlign="Middle"></HeaderStyle>
												<ItemStyle HorizontalAlign="Center" VerticalAlign="Middle"></ItemStyle>
												<ItemTemplate>
													<asp:ImageButton id="btScarica" Runat="server" CommandName="Download" ImageUrl="../images/down.gif" CommandArgument='<%#  DataBinder.Eval(Container.DataItem,"file_name") + "," + DataBinder.Eval(Container.DataItem,"ID_DOC_NORM")%>'>
													</asp:ImageButton>
												</ItemTemplate>
											</asp:TemplateColumn>
											<asp:TemplateColumn>
												<HeaderStyle Width="3%"></HeaderStyle>
												<ItemStyle HorizontalAlign="Center" VerticalAlign="Middle"></ItemStyle>
												<ItemTemplate>
													<asp:ImageButton id="Imagebutton2" Runat=server CommandName="Dettaglio" ImageUrl="~/images/edit.gif" CommandArgument='<%# "ins_doc_normativi.aspx?ItemID=" + DataBinder.Eval(Container.DataItem,"ID_DOC_NORM") + "&FunId=" + FunId + "&TipoOper=write"%>'>
													</asp:ImageButton>
												</ItemTemplate>
											</asp:TemplateColumn>
											<asp:BoundColumn DataField="nome_doc" HeaderText="Nome Documento">
												<HeaderStyle Width="5%"></HeaderStyle>
											</asp:BoundColumn>
											<asp:BoundColumn DataField="desc_doc" HeaderText="Descrizione Documento">
												<HeaderStyle Width="65%"></HeaderStyle>
											</asp:BoundColumn>
											<asp:BoundColumn DataField="norma_apparenza" HeaderText="Norma Appartenenza"></asp:BoundColumn>
											<asp:BoundColumn DataField="file_name" HeaderText="File Allegato">
												<HeaderStyle Width="15%"></HeaderStyle>
											</asp:BoundColumn>
											<asp:BoundColumn DataField="versione_doc" HeaderText="Versione">
												<HeaderStyle Width="15%"></HeaderStyle>
											</asp:BoundColumn>
											<asp:BoundColumn Visible="False" DataField="file_name" HeaderText="file_name"></asp:BoundColumn>
										</Columns>
										<PagerStyle Mode="NumericPages"></PagerStyle>
									</asp:datagrid></TD>
							</TR>
						</TABLE>
					</TD>
				</TR>
			</TABLE>
		</form>
	</body>
</HTML>
