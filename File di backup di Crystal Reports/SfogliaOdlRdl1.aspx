<%@ Register TagPrefix="uc1" TagName="PageTitle" Src="../WebControls/PageTitle.ascx" %>
<%@ Register TagPrefix="cc2" Namespace="Csy.WebControls" Assembly="CsyWebControls" %>
<%@ Page language="c#" Codebehind="SfogliaOdlRdl1.aspx.cs" AutoEventWireup="false" Inherits="TheSite.ManutenzioneProgrammata.SfogliaOdlRdl1" %>
<%@ Register TagPrefix="uc1" TagName="CodiceApparecchiature" Src="../WebControls/CodiceApparecchiature.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Addetti" Src="../WebControls/Addetti.ascx" %>
<%@ Register TagPrefix="uc1" TagName="GridTitle" Src="../WebControls/GridTitle.ascx" %>
<%@ Register TagPrefix="uc1" TagName="RicercaModulo" Src="../WebControls/RicercaModulo.ascx" %>
<%@ Register TagPrefix="cc1" Namespace="S_Controls" Assembly="S_Controls" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>SfogliaOdlRdl</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<LINK rel="stylesheet" type="text/css" href="../Css/MainSheet.css">
		<SCRIPT language="javascript">
		var NS4 = (navigator.appName == "Netscape" && parseInt(navigator.appVersion) < 5);
		var NSX = (navigator.appName == "Netscape");
		var IE4 = (document.all) ? true : false;
		
			if(self.location==top.location){
			location.href="Default.aspx";
			}
			
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
			<TABLE style="Z-INDEX: 101; POSITION: absolute; TOP: 0px; LEFT: 0px" id="Table1" border="0"
				cellSpacing="1" cellPadding="1" width="100%">
				<TR>
					<TD align="center"><uc1:pagetitle id="PageTitle1" runat="server"></uc1:pagetitle></TD>
				</TR>
				<TR>
					<TD><cc2:datapanel id="DataPanel1" runat="server" TitleStyle-CssClass="TitleSearch" Collapsed="False"
							TitleText="Ricerca" ExpandText="Espandi" ExpandImageUrl="../Images/down.gif" CollapseText="Riduci"
							CssClass="DataPanel75" CollapseImageUrl="../Images/up.gif" AllowTitleExpandCollapse="True">
							<TABLE id="tblSearch100" border="0" cellSpacing="1" cellPadding="1" width="100%">
								<TR>
									<TD colSpan="4">
										<uc1:ricercamodulo id="RicercaModulo1" runat="server"></uc1:ricercamodulo></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 15%; HEIGHT: 21px">Scadenza Da:</TD>
									<TD style="WIDTH: 305px; HEIGHT: 21px">
										<cc1:s_combobox id="cmbsMeseDa" runat="server" DBSize="2" DBDirection="Input" DBParameterName="p_MeseDa"
											DBIndex="1" DBDataType="Integer">
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
										</cc1:s_combobox>
										<cc1:s_combobox id="cmbsAnnoDa" runat="server" DBSize="4" DBDirection="Input" DBParameterName="p_AnnoDa"
											DBIndex="2" DBDataType="Integer"></cc1:s_combobox></TD>
									<TD style="WIDTH: 75px; HEIGHT: 21px">Scadenza A:</TD>
									<TD style="HEIGHT: 21px">
										<cc1:s_combobox id="cmbsMeseA" runat="server" DBSize="2" DBDirection="Input" DBParameterName="p_MeseA"
											DBIndex="3" DBDataType="Integer">
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
										</cc1:s_combobox>
										<cc1:s_combobox id="cmbsAnnoA" runat="server" DBSize="4" DBDirection="Input" DBParameterName="p_AnnoA"
											DBIndex="4" DBDataType="Integer"></cc1:s_combobox></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 15%">Ordine di lavoro:</TD>
									<TD style="WIDTH: 305px">
										<cc1:s_textbox id="txtOrdineLavoro" runat="server" Width="260px"></cc1:s_textbox></TD>
									<TD style="WIDTH: 75px">Stato OdL:</TD>
									<TD>
										<cc1:s_combobox id="cmbsstatolavoro_odl" runat="server" DBSize="5" DBDirection="Input" DBParameterName="p_Ditta"
											DBIndex="5" DBDataType="Integer" Width="224px">
											<asp:ListItem Value="0" Selected="True">- Tutti gli Stati -</asp:ListItem>
											<asp:ListItem Value="1">Completate</asp:ListItem>
											<asp:ListItem Value="2">Da Completare</asp:ListItem>
										</cc1:s_combobox></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 15%; HEIGHT: 8px">Richiesta di lavoro:</TD>
									<TD style="WIDTH: 305px; HEIGHT: 8px">
										<cc1:s_textbox id="txtRichiestaLavoro" runat="server" Width="260px"></cc1:s_textbox></TD>
									<TD style="WIDTH: 75px; HEIGHT: 8px">Stato RdL:</TD>
									<TD style="HEIGHT: 8px">
										<cc1:s_combobox id="cmbsstatolavoro" runat="server" DBSize="5" DBDirection="Input" DBParameterName="p_Ditta"
											DBIndex="5" DBDataType="Integer" Width="224px"></cc1:s_combobox></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 15%; HEIGHT: 17px">Descrizione:</TD>
									<TD style="WIDTH: 305px; HEIGHT: 17px">
										<cc1:s_textbox id="txtDescrizione" runat="server" Width="260px"></cc1:s_textbox></TD>
									<TD style="WIDTH: 75px; HEIGHT: 17px"></TD>
									<TD style="HEIGHT: 17px"></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 15%">Ditta:</TD>
									<TD style="WIDTH: 305px">
										<cc1:s_combobox id="cmbsDitta" runat="server" DBSize="5" DBDirection="Input" DBParameterName="p_Ditta"
											DBIndex="5" DBDataType="Integer" Width="320px"></cc1:s_combobox></TD>
									<TD style="WIDTH: 75px">Addetto:</TD>
									<TD>
										<uc1:addetti id="Addetti1" runat="server"></uc1:addetti></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 15%; HEIGHT: 22px">Servizio:</TD>
									<TD style="WIDTH: 305px; HEIGHT: 22px">
										<cc1:s_combobox id="cmbsServizio" runat="server" DBSize="5" DBDirection="Input" DBParameterName="p_Servizio"
											DBIndex="6" DBDataType="Integer" Width="320px"></cc1:s_combobox></TD>
									<TD style="WIDTH: 75px; HEIGHT: 22px"></TD>
									<TD style="HEIGHT: 22px"></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 15%">Standard Apparecchiature:</TD>
									<TD style="WIDTH: 305px; HEIGHT: 17px">
										<cc1:s_combobox id="cmbsStdApparecchiature" runat="server" DBSize="5" DBDirection="Input" DBParameterName="p_Servizio"
											DBIndex="6" DBDataType="Integer" Width="320px"></cc1:s_combobox></TD>
									<TD style="WIDTH: 75px; HEIGHT: 17px"></TD>
									<TD style="HEIGHT: 17px"></TD>
								</TR>
								<TR>
									<TD colSpan="4">
										<uc1:CodiceApparecchiature id="CodiceApparecchiature1" runat="server"></uc1:CodiceApparecchiature></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 15%" colSpan="4">
										<TABLE style="WIDTH: 392px; HEIGHT: 39px" id="Table2" border="0" cellSpacing="1" cellPadding="1"
											width="392">
											<TR>
												<TD style="WIDTH: 104px">
													<cc1:S_Button id="btRicerca" runat="server" CssClass="btn" Width="96px" Text="Ricerca"></cc1:S_Button></TD>
												<TD>
													<cc1:S_Button id="btUltimo" runat="server" CssClass="btn" Width="96px" Text="Ultimo Mese"></cc1:S_Button></TD>
												<TD>
													<cc1:S_Button id="btReset" runat="server" CssClass="btn" Width="96px" Text="Reset"></cc1:S_Button>&nbsp;<A 
                  class=GuidaLink href="<%= HelpLink %>" 
                target=_blank>Guida</A></TD>
											</TR>
										</TABLE>
									</TD>
								</TR>
							</TABLE>
						</cc2:datapanel></TD>
				</TR>
				<TR>
					<TD><uc1:gridtitle id="GridTitle1" runat="server"></uc1:gridtitle><asp:datagrid id="DataGrid1" runat="server" CssClass="DataGrid" Width="100%" BorderColor="Gray"
							BorderStyle="None" BorderWidth="1px" BackColor="White" CellPadding="4" AutoGenerateColumns="False" AllowPaging="True" GridLines="Vertical" AllowCustomPaging="True">
							<FooterStyle ForeColor="#003399" BackColor="#99CCCC"></FooterStyle>
							<AlternatingItemStyle CssClass="DataGridAlternatingItemStyle"></AlternatingItemStyle>
							<ItemStyle CssClass="DataGridItemStyle"></ItemStyle>
							<HeaderStyle CssClass="DataGridHeaderStyle"></HeaderStyle>
							<Columns>
								<asp:TemplateColumn HeaderText="Ordine di Lavoro">
									<HeaderStyle Width="5%"></HeaderStyle>
									<ItemStyle HorizontalAlign="Center"></ItemStyle>
									<ItemTemplate>
										<asp:LinkButton id=LinkButton1 runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"wo_id") %>' OnCommand="LinkButton1_Click" CommandArgument='<%# DataBinder.Eval(Container.DataItem,"wo_id") %>'>
										</asp:LinkButton>
									</ItemTemplate>
								</asp:TemplateColumn>
								<asp:BoundColumn Visible="False" DataField="Comune" HeaderText="Comune">
									<HeaderStyle Width="5%"></HeaderStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="NomeEdificio" HeaderText="Edificio">
									<HeaderStyle Width="5%"></HeaderStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="IndEdificio" HeaderText="Indirizzo">
									<HeaderStyle Width="10%"></HeaderStyle>
								</asp:BoundColumn>
								<asp:BoundColumn Visible="False" DataField="NOMEEDIFICIO" HeaderText="Den.Edificio">
									<HeaderStyle Width="10%"></HeaderStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="Servizio" HeaderText="Servizio">
									<HeaderStyle Width="5%"></HeaderStyle>
								</asp:BoundColumn>
								<asp:BoundColumn Visible="False" DataField="macro" HeaderText="MC">
									<HeaderStyle Width="3%"></HeaderStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="DATPIAN" HeaderText="Data Sched." DataFormatString="{0:d}">
									<HeaderStyle Width="5%"></HeaderStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="DATA_C" HeaderText="Data Compl." DataFormatString="{0:d}">
									<HeaderStyle Width="5%"></HeaderStyle>
								</asp:BoundColumn>
								<asp:BoundColumn Visible="False" DataField="NOMEDITTA" HeaderText="Ditta">
									<HeaderStyle Width="2%"></HeaderStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="PMPADDETTO" HeaderText="Addetto">
									<HeaderStyle Width="5%"></HeaderStyle>
								</asp:BoundColumn>
								<asp:TemplateColumn HeaderText="Stato OdL">
									<HeaderStyle Width="5%"></HeaderStyle>
									<ItemStyle HorizontalAlign="Center"></ItemStyle>
									<ItemTemplate>
										<asp:LinkButton id=Linkbutton2 runat="server" Text="Da completare" OnCommand="LinkButton2_Click" CommandArgument='<%# DataBinder.Eval(Container.DataItem,"wo_id") %>'>Da completare</asp:LinkButton>
										<asp:Label id="lblComp" Runat="server">Completato</asp:Label>
									</ItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn HeaderText="Download File">
									<HeaderStyle HorizontalAlign="Center" Width="20px" VerticalAlign="Middle"></HeaderStyle>
									<ItemStyle HorizontalAlign="Center" VerticalAlign="Middle"></ItemStyle>
									<ItemTemplate>
										<asp:ImageButton id="btScarica" Runat="server" CommandName="Download" ImageUrl="../images/w1.gif" CommandArgument='<%#  DataBinder.Eval(Container.DataItem,"wo_id")%>'>
										</asp:ImageButton>
									</ItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn HeaderText="Allega File">
									<HeaderStyle HorizontalAlign="Center" Width="20px" VerticalAlign="Middle"></HeaderStyle>
									<ItemStyle HorizontalAlign="Center" VerticalAlign="Middle"></ItemStyle>
									<ItemTemplate>
										<asp:ImageButton id="btAllega" Runat="server" CommandName="Allega" ImageUrl="../images/attach.png" CommandArgument='<%#  DataBinder.Eval(Container.DataItem,"wo_id")%>'>
										</asp:ImageButton>
									</ItemTemplate>
								</asp:TemplateColumn>
							</Columns>
							<PagerStyle HorizontalAlign="Left" CssClass="DataGridPagerStyle" Mode="NumericPages"></PagerStyle>
						</asp:datagrid></TD>
				</TR>
			</TABLE>
		</form>
		<script language="javascript">parent.left.calcola();</script>
	</body>
</HTML>
