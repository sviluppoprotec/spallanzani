<%@ Register TagPrefix="uc1" TagName="PageTitle" Src="../WebControls/PageTitle.ascx" %>
<%@ Register TagPrefix="uc1" TagName="CalendarPicker" Src="../WebControls/CalendarPicker.ascx" %>
<%@ Register TagPrefix="uc1" TagName="RicercaModulo" Src="../WebControls/RicercaModulo.ascx" %>
<%@ Register TagPrefix="cc2" Namespace="Csy.WebControls" Assembly="CsyWebControls" %>
<%@ Register TagPrefix="uc1" TagName="GridTitle" Src="../WebControls/GridTitle.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Addetti" Src="../WebControls/Addetti.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Richiedenti" Src="../WebControls/Richiedenti.ascx" %>
<%@ Register TagPrefix="cc1" Namespace="S_Controls" Assembly="S_Controls" %>
<%@ Page language="c#" Codebehind="GestioneCompleta.aspx.cs" AutoEventWireup="false" Inherits="TheSite.ManutenzioneCorrettiva.GestioneCompleta" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>Gestione Completamento</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="../Css/MainSheet.css" type="text/css" rel="stylesheet">
		<SCRIPT language="javascript">
		var NS4 = (navigator.appName == "Netscape" && parseInt(navigator.appVersion) < 5);
		var NSX = (navigator.appName == "Netscape");
		var IE4 = (document.all) ? true : false;
		
			
			
			function valutanumeri(evt)
			{
				var e = evt? evt : window.event; 
				if(!e) return; 
				var key = 0; 
				
				if(IE4==true)
				{
					if (e.keyCode < 48	|| e.keyCode > 57){
						e.keyCode = 0;
						return false;
					}	
		        }
		        
				if (e.keycode) { key = e.keycode; } // for moz/fb, if keycode==0 use 'which' 
				if (typeof(e.which)!= 'undefined') { 
					key = e.which;
					if (key < 48	|| key > 57){
						return false;
					} 
					
				} 
			}
			function nonpaste()
			{
				return false;
			}
		</SCRIPT>
	</HEAD>
	<body onbeforeunload="parent.left.valorizza()" MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<TABLE id="Table1" style="Z-INDEX: 101; POSITION: absolute; TOP: 8px; LEFT: 8px" cellSpacing="1"
				cellPadding="1" width="100%" border="0">
				<TR>
					<TD align="center"><uc1:pagetitle id="PageTitle1" runat="server"></uc1:pagetitle></TD>
				</TR>
				<TR>
					<TD>
						<cc2:datapanel id="DataPanel1" runat="server" TitleStyle-CssClass="TitleSearch" CssClass="DataPanel75"
							TitleText="Ricerca" AllowTitleExpandCollapse="True" Collapsed="False" ExpandText="Espandi"
							CollapseText="Riduci" CollapseImageUrl="../Images/up.gif" ExpandImageUrl="../Images/down.gif">
							<TABLE id="Table3" border="0" cellSpacing="1" cellPadding="1" width="100%">
								<TR>
									<TD colSpan="5">
										<uc1:RicercaModulo id="RicercaModulo1" runat="server"></uc1:RicercaModulo></TD>
								</TR>
								<TR>
									<TD width="15%">Richiesta:</TD>
									<TD width="30%">
										<cc1:S_TextBox id="S_Txtrichiesta" runat="server" Width="252px"></cc1:S_TextBox></TD>
									<TD width="15%"></TD>
									<TD width="30%"></TD>
									<TD></TD>
								</TR>
								<TR>
									<TD style="HEIGHT: 25px">Data Da:</TD>
									<TD style="HEIGHT: 25px">
										<uc1:CalendarPicker id="CalendarPicker1" runat="server"></uc1:CalendarPicker></TD>
									<TD style="HEIGHT: 25px">Data A:</TD>
									<TD style="HEIGHT: 25px">
										<uc1:CalendarPicker id="CalendarPicker2" runat="server"></uc1:CalendarPicker>
										<asp:CompareValidator id="CompareValidator1" runat="server" ErrorMessage="Data non valida!" Operator="GreaterThanEqual"
											Type="Date"></asp:CompareValidator></TD>
									<TD style="HEIGHT: 25px"></TD>
								</TR>
								<TR>
									<TD>Ordine di Lavoro:</TD>
									<TD>
										<cc1:S_TextBox id="S_Ttxtordinelavoro" runat="server" Width="252px"></cc1:S_TextBox></TD>
									<TD>Richiedente:</TD>
									<TD>
										<uc1:Richiedenti id="Richiedenti1" runat="server"></uc1:Richiedenti></TD>
									<TD></TD>
								</TR>
								<TR>
									<TD>Operatore:</TD>
									<TD>
										<cc1:S_TextBox id="S_Txtoperatore" runat="server" Width="252px"></cc1:S_TextBox></TD>
									<TD>Addetto:</TD>
									<TD>
										<uc1:Addetti id="Addetti1" runat="server"></uc1:Addetti></TD>
									<TD></TD>
								</TR>
								<TR>
									<TD>Ditta:</TD>
									<TD>
										<cc1:S_ComboBox id="S_cbditta" runat="server" Width="252px"></cc1:S_ComboBox></TD>
									<TD>Gruppo:</TD>
									<TD>
										<cc1:S_ComboBox id="S_cbgruppo" runat="server" Width="252px"></cc1:S_ComboBox></TD>
									<TD></TD>
								</TR>
								<TR>
									<TD>Descrizione:</TD>
									<TD>
										<cc1:S_TextBox id="S_Txtdescrizione" runat="server" Width="252px"></cc1:S_TextBox></TD>
									<TD>Urgenza:</TD>
									<TD>
										<cc1:S_ComboBox id="S_Cburgenza" runat="server" Width="252px"></cc1:S_ComboBox></TD>
									<TD style="HEIGHT: 18px"></TD>
								</TR>
								<TR>
									<TD style="HEIGHT: 14px">Servizio:</TD>
									<TD style="HEIGHT: 14px">
										<cc1:S_ComboBox id="cmbsServizio" runat="server" Width="252px"></cc1:S_ComboBox></TD>
									<TD style="HEIGHT: 14px">Tipo Manutenzione:</TD>
									<TD style="HEIGHT: 14px">
										<cc1:S_ComboBox id="cmbTipoManutenzione" runat="server" Width="252px">
											<asp:ListItem Value="0">Selezionare Tipo Manutenzione</asp:ListItem>
											<asp:ListItem Value="1">Manutenzione Correttiva</asp:ListItem>
											<asp:ListItem Value="3">Manutenzione Straordinaria</asp:ListItem>
										</cc1:S_ComboBox></TD>
									<TD style="HEIGHT: 14px"></TD>
								</TR>
								<TR>
									<TD colSpan="3" align="left">
										<cc1:S_Button id="S_btMostra" runat="server" ToolTip="Avvia la ricerca" Text="Ricerca"></cc1:S_Button>&nbsp;
										<cc1:S_Button id="S_Btreset" runat="server" ToolTip="Svuota i campi di ricercca" Text="Reset"></cc1:S_Button></TD>
									<TD align="right"><A class=GuidaLink href="<%= HelpLink %>" 
            target=_blank>Guida</A></TD>
								</TR>
							</TABLE>
						</cc2:datapanel></TD>
				</TR>
				<tr>
					<TD style="HEIGHT: 3%" align="center"></TD>
				</tr>
				<TR>
					<TD width="100%"><uc1:gridtitle id="GridTitle1" runat="server"></uc1:gridtitle><asp:datagrid id="DataGrid1" runat="server" CssClass="DataGrid" Width="100%" BorderColor="Gray"
							BorderStyle="None" BorderWidth="1px" BackColor="White" CellPadding="4" AutoGenerateColumns="False" AllowPaging="True" GridLines="Vertical" AllowCustomPaging="True">
							<FooterStyle ForeColor="#003399" BackColor="#99CCCC"></FooterStyle>
							<AlternatingItemStyle CssClass="DataGridAlternatingItemStyle"></AlternatingItemStyle>
							<ItemStyle CssClass="DataGridItemStyle"></ItemStyle>
							<HeaderStyle CssClass="DataGridHeaderStyle"></HeaderStyle>
							<Columns>
								<asp:TemplateColumn>
									<HeaderStyle Width="3%"></HeaderStyle>
									<ItemStyle HorizontalAlign="Center" VerticalAlign="Middle"></ItemStyle>
									<ItemTemplate>
										<asp:ImageButton id="lnkDett" Runat=server CommandName="Dettaglio" ImageUrl="../images/edit.gif" CommandArgument='<%# "CompletaRdl1.aspx?wr_id=" + DataBinder.Eval(Container.DataItem,"var_wr_wr_id")%>'>
										</asp:ImageButton>
									</ItemTemplate>
								</asp:TemplateColumn>
								<asp:BoundColumn DataField="var_bl_id" HeaderText="EDIF."></asp:BoundColumn>
								<asp:BoundColumn DataField="IndEdificio" HeaderText="Indirizzo"></asp:BoundColumn>
								<asp:BoundColumn DataField="var_wr_wr_id" HeaderText="Rdl"></asp:BoundColumn>
								<asp:BoundColumn DataField="var_wr_wo_id" HeaderText="Odl"></asp:BoundColumn>
								<asp:BoundColumn DataField="status" HeaderText="Stato Rdl"></asp:BoundColumn>
								<asp:BoundColumn DataField="desc_priority" HeaderText="Urgenza"></asp:BoundColumn>
								<asp:BoundColumn DataField="var_wrcf_date_assigned" HeaderText="Data Richiesta" DataFormatString="{0:d}"></asp:BoundColumn>
								<asp:BoundColumn DataField="date_wo" HeaderText="Data Emissione" DataFormatString="{0:d}"></asp:BoundColumn>
								<asp:BoundColumn Visible="False" DataField="var_ditta" HeaderText="Ditta"></asp:BoundColumn>
								<asp:BoundColumn DataField="var_wr_date_assigned" HeaderText="Data Pianificata" DataFormatString="{0:d}"></asp:BoundColumn>
								<asp:TemplateColumn Visible="False" HeaderText="Annotazioni Aggiuntive">
									<ItemTemplate>
										<span title='<%#DataBinder.Eval(Container.DataItem,"var_wrcf_comments") %>'>
											<%# evalLenght(DataBinder.Eval(Container.DataItem,"var_wrcf_comments")) %>
										</span>
									</ItemTemplate>
								</asp:TemplateColumn>
								<asp:BoundColumn Visible="False" DataField="TipoManutenzione" HeaderText="Tipo Manutenzione"></asp:BoundColumn>
								<asp:BoundColumn DataField="var_wr_descrizione" HeaderText="Descrizione"></asp:BoundColumn>
							</Columns>
							<PagerStyle HorizontalAlign="Left" CssClass="DataGridPagerStyle" Mode="NumericPages"></PagerStyle>
						</asp:datagrid></TD>
				</TR>
			</TABLE>
		</form>
		<script language="javascript">parent.left.calcola();</script>
	</body>
</HTML>
