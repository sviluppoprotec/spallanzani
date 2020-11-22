<%@ Register TagPrefix="uc1" TagName="PageTitle" Src="../WebControls/PageTitle.ascx" %>
<%@ Page language="c#" Codebehind="Completa_WO1.aspx.cs" AutoEventWireup="false" Inherits="TheSite.ManutenzioneProgrammata.Completa_WO1" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>Aggiornamento Ordine di Lavoro</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="../Css/MainSheet.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<TABLE id="Table1" cellSpacing="0" cellPadding="0" width="100%" border="0">
				<TBODY>
					<TR>
						<TD align="center">
							<uc1:PageTitle id="PageTitle1" runat="server"></uc1:PageTitle></TD>
					</TR>
					<TR>
						<TD>
							<asp:Repeater id="RepeaterMaster" runat="server">
								<ItemTemplate>
									<tr>
										<td>
											<b>Aggiornamento ordine di lavoro N.<%# DataBinder.Eval(Container.DataItem,"Key") %></b>
											<asp:repeater id="RepeaterDettail" runat="server">
												<HEADERTEMPLATE>
													<table id="tablelladettail" border="1" width="100%" cellSpacing="0" cellPadding="0" style="TABLE-LAYOUT: auto; BORDER-COLLAPSE: collapse">
														<tr bgcolor="Gray" style="FONT-WEIGHT: bold; COLOR: white">
															<td width="5%">
																RDL
															</td>
															<td width="10%">
																Inizio-Fine Schedulati
															</td>
															<td width="10%">
																Inizio-Fine Effettivi
															</td>
															<td width="10%">
																Codice Procedura
															</td>
															<td width="20%">
																Descrizione Procedura
															</td>
															<td width="5%">
																Frequenza
															</td>										
															<td width="15%">
																Apparecchiatura
															</td>
															<td width="15%">
																Stato Richiesta
															</td>
									</tr>
									</HEADERTEMPLATE>
									<ITEMTEMPLATE>
										<tr>
											<td><%# DataBinder.Eval(Container.DataItem,"wr_id") %>
											</td>
											<td><%# DataBinder.Eval(Container.DataItem,"Date_Schedulate") %>
											</td>
											<td><%# DataBinder.Eval(Container.DataItem,"Date_Effettive") %>
											</td>
											<td><%# DataBinder.Eval(Container.DataItem,"Cod_Proc") %>
											</td>
											<td><%# DataBinder.Eval(Container.DataItem,"Descr") %>
											</td>
											<td><%# DataBinder.Eval(Container.DataItem,"frequenza") %>
											</td>
											<td><%# DataBinder.Eval(Container.DataItem,"Apparecchiatura") %>
											</td>
											<td><%# DataBinder.Eval(Container.DataItem,"Stato") %>
											</td>
										</tr>
									</ITEMTEMPLATE>
									<ALTERNATINGITEMTEMPLATE>
										<tr>
											<td bgcolor="whitesmoke"><%# DataBinder.Eval(Container.DataItem,"wr_id") %>
											</td>
											<td bgcolor="whitesmoke"><%# DataBinder.Eval(Container.DataItem,"Date_Schedulate") %>
											</td>
											<td bgcolor="whitesmoke"><%# DataBinder.Eval(Container.DataItem,"Date_Effettive") %>
											</td>
											<td bgcolor="whitesmoke"><%# DataBinder.Eval(Container.DataItem,"Cod_Proc") %>
											</td>
											<td bgcolor="whitesmoke"><%# DataBinder.Eval(Container.DataItem,"Descr") %>
											</td>
											<td bgcolor="whitesmoke"><%# DataBinder.Eval(Container.DataItem,"frequenza") %>
											</td>
											<td bgcolor="whitesmoke"><%# DataBinder.Eval(Container.DataItem,"Apparecchiatura") %>
											</td>
											<td bgcolor="whitesmoke"><%# DataBinder.Eval(Container.DataItem,"Stato") %>
											</td>
										</tr>
									</ALTERNATINGITEMTEMPLATE>
									<FOOTERTEMPLATE>
			</TABLE>
			</FooterTemplate> </asp:Repeater> </td> </tr> </ItemTemplate>
			<HeaderTemplate>
				<table id="tablellaMaster" width="100%">
			</HeaderTemplate>
			<FooterTemplate>
			</TABLE>
			
</FooterTemplate>
			</asp:Repeater></TD></TR></TBODY></TABLE>
		</form>
	</body>
</HTML>
