<%@ Register TagPrefix="uc1" TagName="PageTitle" Src="../WebControls/PageTitle.ascx" %>
<%@ Page language="c#" Codebehind="SfogliaRdlOdl_MP1.aspx.cs" AutoEventWireup="false" Inherits="TheSite.ManutenzioneProgrammata.SfogliaRdlOdl_MP1" %>
<%@ Register TagPrefix="uc1" TagName="GridTitle" Src="../WebControls/GridTitle.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>SfogliaRdlOdl_MP1</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="../Css/MainSheet.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body onbeforeunload="parent.left.valorizza()" MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<TABLE id="Table1" style="Z-INDEX: 101; POSITION: absolute; TOP: 0px; LEFT: 0px" cellSpacing="1"
				cellPadding="1" width="100%" border="0">
				<TR>
					<TD align="center"><uc1:pagetitle id="PageTitle1" runat="server"></uc1:pagetitle></TD>
				</TR>
				<TR>
					<TD>
						<TABLE id="Table2" cellSpacing="1" cellPadding="1" width="100%" border="0">
							<TR>
								<TD><asp:datagrid id="DataGrid1" runat="server" GridLines="Vertical" AutoGenerateColumns="False" CellPadding="4"
										BackColor="White" BorderWidth="1px" BorderStyle="None" BorderColor="Gray" Width="100%" CssClass="DataGrid">
										<FooterStyle ForeColor="#003399" BackColor="#99CCCC"></FooterStyle>
										<AlternatingItemStyle CssClass="DataGridAlternatingItemStyle"></AlternatingItemStyle>
										<ItemStyle CssClass="DataGridItemStyle"></ItemStyle>
										<HeaderStyle CssClass="DataGridHeaderStyle"></HeaderStyle>
										<Columns>
											<asp:BoundColumn DataField="wo_id" HeaderText="OdL"></asp:BoundColumn>
											<asp:BoundColumn DataField="nomeedificio" HeaderText="Edificio"></asp:BoundColumn>
											<asp:BoundColumn Visible="False" DataField="DATA_CREAZ" HeaderText="Data Emissione Odl" DataFormatString="{0:d}"></asp:BoundColumn>
											<asp:BoundColumn DataField="DatPian" HeaderText="Data Schedulazione" DataFormatString="{0:d}"></asp:BoundColumn>
											<asp:BoundColumn DataField="SERVIZIO" HeaderText="Servizio"></asp:BoundColumn>
											<asp:BoundColumn DataField="decsrwo" HeaderText="Descrizione"></asp:BoundColumn>
											<asp:BoundColumn DataField="ditta" HeaderText="Ditta"></asp:BoundColumn>
											<asp:BoundColumn DataField="Addetto" HeaderText="Addetto"></asp:BoundColumn>
										</Columns>
									</asp:datagrid></TD>
							</TR>
							<TR>
								<TD align="center">
									<table border="0" width="85%">
										<tr>
											<td width="85%">
												<uc1:GridTitle id="GridTitle1" runat="server"></uc1:GridTitle>
												<asp:datagrid id="DataGrid2" runat="server" GridLines="Vertical" AllowPaging="True" AutoGenerateColumns="False"
													CellPadding="4" BackColor="White" BorderWidth="1px" BorderStyle="None" BorderColor="Gray"
													Width="100%" CssClass="DataGrid">
													<FooterStyle ForeColor="#003399" BackColor="#99CCCC"></FooterStyle>
													<AlternatingItemStyle CssClass="DataGridAlternatingItemStyle"></AlternatingItemStyle>
													<ItemStyle CssClass="DataGridItemStyle"></ItemStyle>
													<HeaderStyle CssClass="DataGridHeaderStyle"></HeaderStyle>
													<Columns>
														<asp:BoundColumn DataField="wr_id" HeaderText="RdL"></asp:BoundColumn>
														<asp:TemplateColumn HeaderText="Codice Procedura">
															<ItemTemplate>
																<a href='DettProcedurePassi.aspx?pmp=<%#  DataBinder.Eval(Container.DataItem,"ID") + "&pmp_id=" + DataBinder.Eval(Container.DataItem,"CodPMP") + "&std=" + DataBinder.Eval(Container.DataItem,"standarApparecchiature")+ "&descserv=" + DataBinder.Eval(Container.DataItem,"servizio") %>'>
																	<%# DataBinder.Eval(Container.DataItem,"CodPMP")%>
																</a>
															</ItemTemplate>
														</asp:TemplateColumn>
														<asp:BoundColumn DataField="descrpmp" HeaderText="Descrizione Procedura"></asp:BoundColumn>
														<asp:BoundColumn DataField="freq" HeaderText="Frequenza"></asp:BoundColumn>
														<asp:BoundColumn DataField="Apparecchiatura" HeaderText="Apparecchiatura"></asp:BoundColumn>
														<asp:TemplateColumn Visible="False" HeaderText="Stato Richiesta">
															<ItemTemplate>
																<asp:LinkButton CommandArgument='<%# DataBinder.Eval(Container.DataItem,"wo_id") %>' OnCommand="lk_Command" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"StatoRdl") %>' ID="Linkbutton2" />
															</ItemTemplate>
														</asp:TemplateColumn>
														<asp:BoundColumn DataField="StatoRdl" HeaderText="Stato RdL"></asp:BoundColumn>
														<asp:BoundColumn DataField="Iniz_Fine_Sched" HeaderText="Inizio-Fine Schedulati"></asp:BoundColumn>
														<asp:BoundColumn DataField="Iniz_Fine_Effett" HeaderText="Inizio-Fine Effettivi"></asp:BoundColumn>
													</Columns>
													<PagerStyle HorizontalAlign="Left" CssClass="DataGridPagerStyle" Mode="NumericPages"></PagerStyle>
												</asp:datagrid>
											</td>
										</tr>
									</table>
									<asp:Button Runat="server" Text="Indietro" ID="btIndietro" CssClass="btn"></asp:Button>
								</TD>
							</TR>
						</TABLE>
					</TD>
				</TR>
			</TABLE>
		</form>
		<script language="javascript">parent.left.calcola();</script>
	</body>
</HTML>
