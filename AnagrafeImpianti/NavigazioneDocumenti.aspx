<%@ Register TagPrefix="uc1" TagName="RicercaModulo" Src="../WebControls/RicercaModulo.ascx" %>
<%@ Register TagPrefix="uc1" TagName="PageTitle" Src="../WebControls/PageTitle.ascx" %>
<%@ Register TagPrefix="cc2" Namespace="Csy.WebControls" Assembly="CsyWebControls" %>

<%@ Page Language="c#" CodeBehind="NavigazioneDocumenti.aspx.cs" AutoEventWireup="false" Inherits="TheSite.AnagrafeImpianti.NavigazioneDocumenti" %>

<%@ Register TagPrefix="uc1" TagName="GridTitle" Src="../WebControls/GridTitle.ascx" %>
<%@ Register TagPrefix="cc1" Namespace="S_Controls" Assembly="S_Controls" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<html>
<head>
    <title>NavigazioneDocumenti</title>
    <meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
    <meta content="C#" name="CODE_LANGUAGE">
    <meta content="JavaScript" name="vs_defaultClientScript">
    <meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
    <link href="../Css/MainSheet.css" type="text/css" rel="stylesheet">
</head>
<body onbeforeunload="parent.left.valorizza()" ms_positioning="GridLayout">
    <form id="Form1" method="post" runat="server">
        <table id="Table1" style="z-index: 101; position: absolute; top: 8px; left: 8px" cellspacing="1"
            cellpadding="1" width="100%" border="0">
            <tbody>
                <tr>
                    <td align="center">
                        <uc1:PageTitle ID="PageTitle1" runat="server"></uc1:PageTitle>
                    </td>
                </tr>
                <tr>
                    <td>
                        <cc2:DataPanel ID="DataPanel1" runat="server" TitleStyle-CssClass="TitleSearch" Collapsed="False"
                            TitleText="Ricerca" ExpandText="Espandi" ExpandImageUrl="../Images/down.gif" CollapseText="Espandi/Riduci"
                            CssClass="DataPanel75" CollapseImageUrl="../Images/up.gif" AllowTitleExpandCollapse="True">
                            <table id="tblSearch100" border="0" cellspacing="0" cellpadding="0" width="100%">
                                <tbody>
                                    <tr>
                                        <td colspan="2" align="center">
                                            <uc1:RicercaModulo ID="RicercaModulo1" runat="server"></uc1:RicercaModulo>

                                        </td>
                                    </tr>
                                    <tr style="display: none">
                                        <td style="width: 139px; height: 27px">Piano:</td>
                                        <td>
                                            <cc1:S_ComboBox ID="cmbsPiano" runat="server" DBDataType="Integer" Width="448px" DBDirection="Input" DBParameterName="p_piano_id" DBIndex="2"></cc1:S_ComboBox></td>
                                    </tr>
                                    <tr>
                                        <td style="width: 139px">Nome File:</td>
                                        <td>
                                            <cc1:S_TextBox ID="S_txtnomefile" runat="server" Width="448px" DBDirection="Input" DBParameterName="p_nomefile" DBIndex="3" DBSize="250"></cc1:S_TextBox></td>
                                    </tr>
                                    <tr>
                                        <td style="width: 139px; height: 12px">Descrizione File:</td>
                                        <td style="height: 12px">
                                            <p>
                                                <cc1:S_TextBox ID="S_txtdescrizione" runat="server" Width="448px" DBDirection="Input" DBParameterName="p_desc_file" DBIndex="4" DBSize="250"></cc1:S_TextBox></p>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="width: 139px; height: 27px">Categoria:</td>
                                        <td style="height: 27px">
                                            <cc1:S_ComboBox ID="S_CbCategoria" runat="server" DBDataType="Integer" Width="392px" DBDirection="Input" DBParameterName="p_categoria" DBIndex="5" DBSize="0"></cc1:S_ComboBox></td>
                                    </tr>
                                    <tr>
                                        <td style="width: 139px; height: 27px">Tipologia File:</td>
                                        <td style="height: 27px">
                                            <cc1:S_ComboBox ID="S_CmbTipologia" runat="server" DBDataType="Integer" Width="392px" DBDirection="Input" DBParameterName="p_tipo" DBIndex="6" DBSize="0"></cc1:S_ComboBox></td>
                                    </tr>
                                    <tr>
                                        <td style="width: 139px" colspan="2"></td>
                                    </tr>
                                    <tr>
                                        <td style="width: 241px" colspan="2">
                                            <table style="height: 21px" id="Table2" border="0" cellspacing="0"
                                                cellpadding="0" width="568">
                                                <tbody>
                                                    <tr>
                                                        <td style="width: 268px" align="right">
                                                            <cc1:S_Button ID="S_btRicerca" runat="server" CssClass="btn" Width="130px" Text="Mostra Dettagli"></cc1:S_Button></td>
                                                        <td align="left">&nbsp;&nbsp;
                                                            <cc1:S_Button ID="S_btReset" runat="server" CssClass="btn" Width="130px" Text="Reset" CausesValidation="False"></cc1:S_Button></td>
                                                        <td align="right"><a class="GuidaLink" href="<%= HelpLink %>"
                                                            target="_blank">Guida</a></td>
                                                    </tr>
                                                </tbody>
                                            </table>
                                        </td>
                                    </tr>
                                </tbody>
                            </table>
                        </cc2:DataPanel>
                    </td>
                </tr>
                <tr designtimesp="30552">
                    <td designtimesp="30553">
                        <uc1:GridTitle ID="GridTitle1" designtimesp="30554" runat="server"></uc1:GridTitle>
                        <asp:DataGrid ID="DataGrid1" designtimesp="30555" runat="server" CssClass="DataGrid" Width="100%" BorderColor="Gray" BorderStyle="None" BorderWidth="1px" BackColor="White" CellPadding="4" AutoGenerateColumns="False" AllowPaging="True" GridLines="Vertical" AllowCustomPaging="True">
                            <FooterStyle ForeColor="#003399" BackColor="#99CCCC"></FooterStyle>
                            <AlternatingItemStyle CssClass="DataGridAlternatingItemStyle"></AlternatingItemStyle>
                            <ItemStyle CssClass="DataGridItemStyle"></ItemStyle>
                            <HeaderStyle CssClass="DataGridHeaderStyle"></HeaderStyle>
                            <Columns>
                                <asp:TemplateColumn>
                                    <HeaderStyle Width="30px"></HeaderStyle>
                                    <ItemStyle HorizontalAlign="Center"></ItemStyle>
                                    <ItemTemplate>
                                        <asp:ImageButton ImageUrl="../Images/edit.gif" runat="server" OnCommand="imageButton_Click" CommandArgument='<%# DataBinder.Eval(Container.DataItem,"var_afm_dwgs_dwg_name") %>' ID="Imagebutton1"></asp:ImageButton>
                                    </ItemTemplate>
                                </asp:TemplateColumn>
                                <asp:BoundColumn DataField="bl_id" HeaderText="Cod.Edificio"></asp:BoundColumn>
                                <asp:BoundColumn DataField="var_afm_dwgs_servizio" HeaderText="Servizio"></asp:BoundColumn>
                                <asp:BoundColumn DataField="var_afm_dwgs_dwg_name" HeaderText="Nome File"></asp:BoundColumn>
                                <asp:BoundColumn DataField="var_afm_dwgs_tipo" HeaderText="Tipo"></asp:BoundColumn>
                                <asp:BoundColumn DataField="var_afm_dwgs_title" HeaderText="Descrizione"></asp:BoundColumn>
                            </Columns>
                            <PagerStyle HorizontalAlign="Left" CssClass="DataGridPagerStyle" Mode="NumericPages"></PagerStyle>
                        </asp:DataGrid></td>
                </tr>
            </tbody>
        </table>
        <asp:ValidationSummary Style="z-index: 102; position: absolute; top: 632px; left: 16px" ID="vlsEdit" designtimesp="30556" runat="server" ShowMessageBox="True" DisplayMode="List" ShowSummary="False"></asp:ValidationSummary>
    </form>
    </TR></TBODY></TABLE></TR></TBODY></TABLE></TR></TBODY></TABLE></FORM>
    <script language="javascript" designtimesp="30557">parent.left.calcola();</script>
</body>
</html>
