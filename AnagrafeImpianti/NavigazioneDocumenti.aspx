<%@ Register TagPrefix="uc1" TagName="RicercaModulo" Src="../WebControls/RicercaModulo.ascx" %>
<%@ Register TagPrefix="uc1" TagName="PageTitle" Src="../WebControls/PageTitle.ascx" %>
<%@ Register TagPrefix="cc2" Namespace="Csy.WebControls" Assembly="CsyWebControls" %>
<%@ Page language="c#" Codebehind="NavigazioneDocumenti.aspx.cs" AutoEventWireup="false" Inherits="TheSite.AnagrafeImpianti.NavigazioneDocumenti" %>
<%@ Register TagPrefix="uc1" TagName="GridTitle" Src="../WebControls/GridTitle.ascx" %>
<%@ Register TagPrefix="cc1" Namespace="S_Controls" Assembly="S_Controls" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>NavigazioneDocumenti</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="../Css/MainSheet.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body onbeforeunload="parent.left.valorizza()" MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<TABLE id="Table1" style="Z-INDEX: 101; POSITION: absolute; TOP: 8px; LEFT: 8px" cellSpacing="1"
				cellPadding="1" width="100%" border="0">
				<TBODY>
					<TR>
						<TD align="center"><uc1:pagetitle id="PageTitle1" runat="server"></uc1:pagetitle></TD>
					</TR>
					<TR>
						<TD><cc2:datapanel id="DataPanel1" runat="server" TitleStyle-CssClass="TitleSearch" Collapsed="False"
								TitleText="Ricerca" ExpandText="Espandi" ExpandImageUrl="../Images/down.gif" CollapseText="Espandi/Riduci"
								CssClass="DataPanel75" CollapseImageUrl="../Images/up.gif" AllowTitleExpandCollapse="True">
								<TABLE id="tblSearch100" border="0" cellSpacing="0" cellPadding="0" width="100%">
									<TBODY>
										<TR>
											<TD colSpan="2" align="center">
												<uc1:RicercaModulo id="RicercaModulo1" runat="server"></uc1:RicercaModulo>
												
            </TD></TR>
        <TR style="DISPLAY: none">
          <TD style="WIDTH: 139px; HEIGHT: 27px">Piano:</TD>
          <TD><cc1:s_combobox id=cmbsPiano runat="server" DBDataType="Integer" Width="448px" DBDirection="Input" DBParameterName="p_piano_id" DBIndex="2"></cc1:s_combobox></TD></TR>
        <TR>
          <TD style="WIDTH: 139px">Nome File:</TD>
          <TD><cc1:S_TextBox id=S_txtnomefile runat="server" Width="448px" DBDirection="Input" DBParameterName="p_nomefile" DBIndex="3" DBSize="250"></cc1:S_TextBox></TD></TR>
        <TR>
          <TD style="WIDTH: 139px; HEIGHT: 12px">Descrizione File:</TD>
          <TD style="HEIGHT: 12px">
            <P><cc1:S_TextBox id=S_txtdescrizione runat="server" Width="448px" DBDirection="Input" DBParameterName="p_desc_file" DBIndex="4" DBSize="250"></cc1:S_TextBox></P></TD></TR>
        <TR>
          <TD style="WIDTH: 139px; HEIGHT: 27px">Categoria:</TD>
          <TD style="HEIGHT: 27px"><cc1:S_ComboBox id=S_CbCategoria runat="server" DBDataType="Integer" Width="392px" DBDirection="Input" DBParameterName="p_categoria" DBIndex="5" DBSize="0"></cc1:S_ComboBox></TD></TR>
        <TR>
          <TD style="WIDTH: 139px; HEIGHT: 27px">Tipologia File:</TD>
          <TD style="HEIGHT: 27px"><cc1:S_ComboBox id=S_CmbTipologia runat="server" DBDataType="Integer" Width="392px" DBDirection="Input" DBParameterName="p_tipo" DBIndex="6" DBSize="0"></cc1:S_ComboBox></TD></TR>
        <TR>
          <TD style="WIDTH: 139px" colSpan=2></TD></TR>
        <TR>
          <TD style="WIDTH: 241px" colSpan=2>
            <TABLE style="HEIGHT: 21px" id=Table2 border=0 cellSpacing=0 
            cellPadding=0 width=568>
              <TBODY>
              <TR>
                <TD style="WIDTH: 268px" align=right><cc1:S_Button id=S_btRicerca runat="server" CssClass="btn" Width="130px" Text="Mostra Dettagli"></cc1:S_Button></TD>
                <TD align=left>&nbsp;&nbsp; <cc1:S_Button id=S_btReset runat="server" CssClass="btn" Width="130px" Text="Reset" CausesValidation="False"></cc1:S_Button></TD>
                <TD align=right><A class=GuidaLink href="<%= HelpLink %>" 
                  target=_blank>Guida</A></TD></TR></TBODY></TABLE></TD></TR></TBODY></TABLE></cc2:datapanel></TD></TR>
  <TR designtimesp="30552">
    <TD designtimesp="30553"><uc1:gridtitle id=GridTitle1 designtimesp="30554" runat="server"></uc1:gridtitle><asp:datagrid id=DataGrid1 designtimesp="30555" runat="server" CssClass="DataGrid" Width="100%" BorderColor="Gray" BorderStyle="None" BorderWidth="1px" BackColor="White" CellPadding="4" AutoGenerateColumns="False" AllowPaging="True" GridLines="Vertical" AllowCustomPaging="True">
								<FooterStyle ForeColor="#003399" BackColor="#99CCCC"></FooterStyle>
								<AlternatingItemStyle CssClass="DataGridAlternatingItemStyle"></AlternatingItemStyle>
								<ItemStyle CssClass="DataGridItemStyle"></ItemStyle>
								<HeaderStyle CssClass="DataGridHeaderStyle"></HeaderStyle>
								<Columns>
									<asp:TemplateColumn>
										<HeaderStyle Width="30px"></HeaderStyle>
										<ItemStyle HorizontalAlign="Center"></ItemStyle>
										<ItemTemplate>
											<asp:ImageButton ImageUrl="../Images/edit.gif" Runat=server OnCommand="imageButton_Click" CommandArgument='<%# DataBinder.Eval(Container.DataItem,"var_afm_dwgs_dwg_name") %>' ID="Imagebutton1">
											</asp:ImageButton>
										</ItemTemplate>
									</asp:TemplateColumn>
									<asp:BoundColumn DataField="bl_id" HeaderText="Cod.Edificio"></asp:BoundColumn>
									<asp:BoundColumn DataField="var_afm_dwgs_servizio" HeaderText="Servizio"></asp:BoundColumn>
									<asp:BoundColumn DataField="var_afm_dwgs_dwg_name" HeaderText="Nome File"></asp:BoundColumn>
									<asp:BoundColumn DataField="var_afm_dwgs_tipo" HeaderText="Tipo"></asp:BoundColumn>
									<asp:BoundColumn DataField="var_afm_dwgs_title" HeaderText="Descrizione"></asp:BoundColumn>
								</Columns>
								<PagerStyle HorizontalAlign="Left" cssclass="DataGridPagerStyle" Mode="NumericPages"></PagerStyle>
							</asp:datagrid></TD></TR></TBODY></TABLE><asp:validationsummary style="Z-INDEX: 102; POSITION: absolute; TOP: 632px; LEFT: 16px" id=vlsEdit designtimesp="30556" runat="server" ShowMessageBox="True" DisplayMode="List" ShowSummary="False"></asp:validationsummary></FORM></TR></TBODY></TABLE></TR></TBODY></TABLE></TR></TBODY></TABLE></FORM>
<SCRIPT language=javascript designtimesp="30557">parent.left.calcola();</SCRIPT>
</BODY></HTML>
