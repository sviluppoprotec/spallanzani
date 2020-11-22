<%@ Page language="c#" Codebehind="Lista_Priorita_tipo.aspx.cs" AutoEventWireup="false" Inherits="TheSite.CommonPage.Lista_Priorita_tipo" %>
<%@ Register TagPrefix="uc1" TagName="GridTitle" Src="../WebControls/GridTitle.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>Lista Tipo Priorità</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<LINK href="../Css/MainSheet.css" type="text/css" rel="stylesheet">
		<script language="javascript">
		function Chiudi()
		{
			var oVDiv=parent.document.getElementById("PopupUrgs").style;
			oVDiv.display = 'none';
		}
		function Popola(sender,e,c)
		{
		    if (parent.document.getElementById("cmbsUrgenza").options.length==0)
		    {
		       alert("Selezionare un Edificio!");
		       Chiudi();
		       return;       
		    }
		   
			parent.document.getElementById("TxtCausa1").innerText=document.getElementById(sender).innerText;
			parent.document.getElementById("hpriotype").value=e;
			parent.document.getElementById("cmbsUrgenza").value=c;
            //parent.document.getElementById("hydUrgenza").value=c;
			Chiudi();       
		}
		</script>
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<TABLE id="Table1" style="Z-INDEX: 101; POSITION: absolute; TOP: 8px; LEFT: 8px" width="100%"
				border="0">
				<TR>
					<TD class="TDCommon">
						<asp:hyperlink id="HyperLink1" runat="server" NavigateUrl="javascript:Chiudi()" Height="16px" Width="56px">
							<img border="0" src="../Images/chiudi.gif" /></asp:hyperlink></TD>
				</TR>
				<TR>
					<TD width="100%" style="HEIGHT: 212px">
						<uc1:GridTitle id="GridTitle1" runat="server"></uc1:GridTitle>
						<asp:DataGrid id="MyDataGrid1" runat="server" Width="100%" BorderColor="Gray" BorderStyle="None"
							BorderWidth="1px" BackColor="White" CellPadding="4" AutoGenerateColumns="False" CssClass="DataGrid"
							AllowPaging="True" GridLines="Vertical" PageSize="15" AllowCustomPaging="True">
							<FooterStyle ForeColor="#003399" BackColor="#99CCCC"></FooterStyle>
							<AlternatingItemStyle CssClass="DataGridAlternatingItemStyle"></AlternatingItemStyle>
							<ItemStyle CssClass="DataGridItemStyle"></ItemStyle>
							<HeaderStyle CssClass="DataGridHeaderStyle"></HeaderStyle>
							<Columns>
								<asp:TemplateColumn>
									<HeaderStyle Width="30px"></HeaderStyle>
									<ItemStyle HorizontalAlign="Center"></ItemStyle>
									<ItemTemplate>
										<a href="" runat="server" id="hrefset"><img border="0" id="imgsele" src="../Images/edit.gif"></a>
									</ItemTemplate>
								</asp:TemplateColumn>
								<asp:BoundColumn DataField="TIPO_URGENZA" HeaderText="Priorità"></asp:BoundColumn>
								<asp:TemplateColumn>
									<HeaderTemplate>
										Tipo Priorita
									</HeaderTemplate>
									<ItemTemplate>
										<span id="descrizP" runat="server">
											<%# DataBinder.Eval(Container.DataItem,"RICH_INTERV_TIPIZ") %>
										</span>
									</ItemTemplate>
								</asp:TemplateColumn>
								<asp:BoundColumn Visible="False" DataField="ID_PRIORITY_TIPS"></asp:BoundColumn>
								<asp:BoundColumn Visible="False" DataField="ID_PRIORITY"></asp:BoundColumn>
							</Columns>
							<PagerStyle HorizontalAlign="Left" CssClass="DataGridPagerStyle" Mode="NumericPages"></PagerStyle>
						</asp:DataGrid>
					</TD>
				</TR>
				<TR>
					<TD class="TDCommon">
						<asp:hyperlink id="HyperLinkChiudi2" runat="server" NavigateUrl="javascript:Chiudi()" Height="16px"
							Width="56px">
							<img border="0" src="../Images/chiudi.gif" /></asp:hyperlink></TD>
				</TR>
			</TABLE>
		</form>
	</body>
</HTML>
