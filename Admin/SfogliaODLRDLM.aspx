<%@ Register TagPrefix="uc1" TagName="GridTitle" Src="../WebControls/GridTitle.ascx" %>
<%@ Page language="c#" Codebehind="SfogliaODLRDLM.aspx.cs" AutoEventWireup="false" Inherits="TheSite.AnagrafeImpianti.SfogliaODLRDLM" %>
<%@ Register TagPrefix="uc1" TagName="CalendarPicker" Src="../WebControls/CalendarPicker.ascx" %>
<%@ Register TagPrefix="uc1" TagName="PageTitle" Src="../WebControls/PageTitle.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>SfogliaRdlOdl_MP1</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<LINK rel="stylesheet" type="text/css" href="../Css/MainSheet.css">
	</HEAD>
	<body onbeforeunload="parent.left.valorizza()" MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<TABLE style="Z-INDEX: 101; POSITION: absolute; TOP: 0px; LEFT: 0px" id="Table1" border="0"
				cellSpacing="1" cellPadding="1" width="100%">
				<TR>
					<TD align="center"><uc1:pagetitle id="PageTitle1" runat="server"></uc1:pagetitle></TD>
				</TR>
				<tr>
					<td>
						<table id="Tabledate" border="0" cellSpacing="1" cellPadding="1" width="100%">
							<TR>
								<TD><B>Codice Componente:</B></TD>
								<TD><asp:Label id="S_lblcodicecomponente" runat="server"></asp:Label>
								</TD>
								<TD>
									<B>Standard:</B></TD>
								<TD><asp:Label id="S_lblstdapparecchiature" runat="server"></asp:Label></TD>
							<TR>
								<TD><B>Codice Edificio:</B></TD>
								<TD><asp:Label id="S_lblcodiceedificio" runat="server"></asp:Label></TD>
								<TD><B>Edificio:</B></TD>
								<TD><asp:Label id="S_lbledificio" runat="server"></asp:Label></TD>
							</TR>
							<tr>
								<td><B>Data Inizio Prevista Da:</B>
								</td>
								<td><uc1:calendarpicker id="CalendarPicker1" runat="server"></uc1:calendarpicker></td>
								<td><B>Data Fine Prevista A:</B>
								</td>
								<td><uc1:calendarpicker id="CalendarPicker2" runat="server"></uc1:calendarpicker></td>
							</tr>
							<tr>
								<td colSpan="4"></td>
							</tr>
							<tr>
								<td><asp:button id="Button1" runat="server" Width="128px" Text="Ricerca"></asp:button></td>
								<td>
									<asp:Button id="Button2" runat="server" Text="Indietro" Width="128px"></asp:Button>
									<INPUT style="WIDTH: 16px; HEIGHT: 18px" id="HPageBack" size="1" type="hidden" name="HPageBack"
										runat="server">
								</td>
								<td></td>
								<td></td>
							</tr>
						</table>
					</td>
				</tr>
				<TR>
					<TD>
						<TABLE id="Table2" border="0" cellSpacing="1" cellPadding="1" width="100%">
							<TR>
								<TD></TD>
							</TR>
							<TR>
								<TD align="center">
									<table border="0" width="85%">
										<tr>
											<td width="85%"><uc1:gridtitle id="GridTitle1" runat="server"></uc1:gridtitle><asp:datagrid id="DataGrid2" runat="server" CssClass="DataGrid" Width="100%" BorderColor="Gray"
													BorderStyle="None" BorderWidth="1px" BackColor="White" CellPadding="4" AutoGenerateColumns="False" AllowPaging="True" GridLines="Vertical" PageSize="25">
													<FooterStyle ForeColor="#003399" BackColor="#99CCCC"></FooterStyle>
													<AlternatingItemStyle CssClass="DataGridAlternatingItemStyle"></AlternatingItemStyle>
													<ItemStyle CssClass="DataGridItemStyle"></ItemStyle>
													<HeaderStyle CssClass="DataGridHeaderStyle"></HeaderStyle>
													<Columns>
														<asp:BoundColumn DataField="wr_id" HeaderText="RdL"></asp:BoundColumn>
														<asp:BoundColumn DataField="wo_id" HeaderText="OdL"></asp:BoundColumn>
														<asp:BoundColumn DataField="manutenzione" HeaderText="Manutenzione"></asp:BoundColumn>
														<asp:BoundColumn DataField="descrpmp" HeaderText="Descrizione Attivit&#224;"></asp:BoundColumn>
														<asp:TemplateColumn HeaderText="Cod.Proc. MP">
															<ItemTemplate>
																<a href='DettProcedurePassi.aspx?pmp=<%#  DataBinder.Eval(Container.DataItem,"ID") + "&pmp_id=" + DataBinder.Eval(Container.DataItem,"CodPMP")%>'>
																	<%# DataBinder.Eval(Container.DataItem,"CodPMP")%>
																</a>
															</ItemTemplate>
														</asp:TemplateColumn>
														<asp:BoundColumn DataField="Apparecchiatura" HeaderText="Apparecchiatura"></asp:BoundColumn>
														<asp:BoundColumn DataField="StatoRdl" HeaderText="Stato RdL"></asp:BoundColumn>
														<asp:BoundColumn DataField="Iniz_Fine_Sched" HeaderText="Inizio-Fine Previsti"></asp:BoundColumn>
														<asp:BoundColumn DataField="Iniz_Fine_Effett" HeaderText="Inizio-Fine Effettivi"></asp:BoundColumn>
														<asp:TemplateColumn HeaderText="Download File">
															<HeaderStyle HorizontalAlign="Center" Width="20px" VerticalAlign="Middle"></HeaderStyle>
															<ItemStyle HorizontalAlign="Center" VerticalAlign="Middle"></ItemStyle>
															<ItemTemplate>
																<asp:ImageButton id="btScarica" Runat="server" CommandName="Download" ImageUrl="../images/w1.gif" CommandArgument='<%#  DataBinder.Eval(Container.DataItem,"wo_id")%>'>
																</asp:ImageButton>
															</ItemTemplate>
														</asp:TemplateColumn>
														<asp:BoundColumn Visible="False" DataField="tipomanutenzione_id" HeaderText="tipomanutenzione_id"></asp:BoundColumn>
														<asp:BoundColumn Visible="False" DataField="filename" HeaderText="filename"></asp:BoundColumn>
													</Columns>
													<PagerStyle HorizontalAlign="Left" CssClass="DataGridPagerStyle" Mode="NumericPages"></PagerStyle>
												</asp:datagrid></td>
										</tr>
									</table>
								</TD>
							</TR>
						</TABLE>
					</TD>
				</TR>
				<tr>
					<td>&nbsp;</td>
				</tr>
			</TABLE>
		</form>
		<script language="javascript">parent.left.calcola();</script>
	</body>
</HTML>
