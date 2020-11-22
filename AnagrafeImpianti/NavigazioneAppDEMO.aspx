<%@ Page language="c#" Codebehind="NavigazioneAppDEMO.aspx.cs" AutoEventWireup="false" Inherits="TheSite.AnagrafeImpianti.NavigazioneAppDEMO" %>
<%@ Register TagPrefix="cc1" Namespace="S_Controls" Assembly="S_Controls" %>
<%@ Register TagPrefix="Collapse" Namespace="Csy.WebControls" Assembly="CsyWebControls" %>
<%@ Register TagPrefix="uc1" TagName="GridTitle" Src="../WebControls/GridTitle.ascx" %>
<%@ Register TagPrefix="uc1" TagName="PageTitle" Src="../WebControls/PageTitle.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<TITLE>NavigazioneApparechiature</TITLE>
		<META content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<META content="C#" name="CODE_LANGUAGE">
		<META content="JavaScript" name="vs_defaultClientScript">
		<META content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="../Css/MainSheet.css" type="text/css" rel="stylesheet">
		<SCRIPT language="javascript">
			function valorizza(){
					if (parent.left != null){
					parent.left.valorizza();
				}
			}		
		</SCRIPT>
	</HEAD>
	<BODY onbeforeunload="valorizza()" ms_positioning="GridLayout">
		<FORM id="Form1" method="post" runat="server">
			<TABLE id="TableMain" style="Z-INDEX: 101; POSITION: absolute; TOP: 8px; LEFT: 8px" cellspacing="0"
				cellpadding="0" width="100%" align="center" border="0">
				<TBODY>
					<TR>
						<TD style="HEIGHT: 50px" align="center">
							<UC1:PAGETITLE id="PageTitle1" runat="server"></UC1:PAGETITLE></TD>
					</TR>
					<tr>
						<td>
							<table>
								<TBODY>
									<tr>
										<td style="HEIGHT: 8px">Stanza nr:
										</td>
										<td style="HEIGHT: 8px">
											<asp:Label id="lblNrstanza" runat="server" Font-Bold="True"></asp:Label>
										</td>
										<td style="HEIGHT: 8px">Stanza:
										</td>
										<td style="HEIGHT: 8px"><asp:Label style="Z-INDEX: 0" id="lblDescstanza" runat="server" Font-Bold="True"></asp:Label>
										</td>
									</tr>
									<tr>
										<td style="HEIGHT: 16px">Edificio:
										</td>
										<td style="HEIGHT: 16px">
											<asp:Label id="lblEdificio" runat="server" Font-Bold="True" style="Z-INDEX: 0"></asp:Label>
										</td>
										<td style="HEIGHT: 16px">Piano:
										</td>
										<td style="HEIGHT: 16px">
											<asp:Label style="Z-INDEX: 0" id="lblPiano" runat="server" Font-Bold="True"></asp:Label>
										</td>
									</tr>
									<tr>
										<td>Superficie mq:
										</td>
										<td>
											<asp:Label style="Z-INDEX: 0" id="lblArea" runat="server" Font-Bold="True"></asp:Label>
										</td>
										<td>Altezza m:
										</td>
										<td><asp:Label style="Z-INDEX: 0" id="lblAltezza" runat="server" Font-Bold="True"></asp:Label>
										</td>
									</tr>
									<tr>
										<td>
											Macroarea&nbsp;stanza:
										</td>
										<td>
											<asp:Label style="Z-INDEX: 0" id="lblCategoria" runat="server" Font-Bold="True"></asp:Label>
										</td>
										<td>Destinazione uso stanza:
										</td>
										<td>
											<asp:Label style="Z-INDEX: 0" id="lblDestuso" runat="server" Font-Bold="True"></asp:Label>
										</td>
									</tr>
									<tr>
										<td>Finiture Pavimento:
										</td>
										<td>
											<asp:Label style="Z-INDEX: 0" id="lblPavimento" runat="server" Font-Bold="True"></asp:Label>
										</td>
										<td>Finiture Pareti:
										</td>
										<td>
											<asp:Label style="Z-INDEX: 0" id="lblPareti" runat="server" Font-Bold="True"></asp:Label>
										</td>
									</tr>
									<tr>
										<td>Finiture Soffitto:
										</td>
										<td>
											<asp:Label style="Z-INDEX: 0" id="lblSoffitto" runat="server" Font-Bold="True"></asp:Label>
										</td>
										<td>
										</td>
										<td>
										</td>
									</tr>
								</TBODY>
							</table>
						</td>
					</tr>
					<TR valign="top">
						<TD valign="top">
							<UC1:GRIDTITLE id="GridTitle1" runat="server"></UC1:GRIDTITLE>
							<ASP:DATAGRID id="MyDataGrid1" runat="server" width="100%" bordercolor="Gray" borderstyle="None"
								borderwidth="1px" backcolor="White" cellpadding="4" autogeneratecolumns="False" cssclass="DataGrid"
								allowpaging="True" gridlines="Vertical" pagesize="20">
								<FOOTERSTYLE forecolor="#003399" backcolor="#99CCCC"></FOOTERSTYLE>
								<ALTERNATINGITEMSTYLE cssclass="DataGridAlternatingItemStyle"></ALTERNATINGITEMSTYLE>
								<ITEMSTYLE cssclass="DataGridItemStyle"></ITEMSTYLE>
								<HEADERSTYLE cssclass="DataGridHeaderStyle"></HEADERSTYLE>
								<COLUMNS>
									<ASP:BOUNDCOLUMN datafield="bl_id" headertext="Cod.Edificio"></ASP:BOUNDCOLUMN>
									<ASP:BOUNDCOLUMN datafield="eq_id" headertext="Cod. Apparecchiatura"></ASP:BOUNDCOLUMN>
									<ASP:BOUNDCOLUMN datafield="std" headertext="Std. Apparecchiatura"></ASP:BOUNDCOLUMN>
									<ASP:BOUNDCOLUMN datafield="descrizione" headertext="Servizio"></ASP:BOUNDCOLUMN>
								</COLUMNS>
								<PAGERSTYLE horizontalalign="Left" forecolor="Black" backcolor="Silver" mode="NumericPages"></PAGERSTYLE>
							</ASP:DATAGRID>
							<!--<ASP:BUTTON id="BntIndietro" runat="server" text="Indietro"></ASP:BUTTON>-->
						</TD>
					</TR>
					<tr>
						<td><input id="btnclose" onclick="javascript:window.close();" value="Chiudi" type="button">
						</td>
					</tr>
				</TBODY>
			</TABLE>
		</FORM>
		<SCRIPT language="javascript">
		if (parent.left != null){
			parent.left.calcola();
		}
		</SCRIPT>
	</BODY>
</HTML>
