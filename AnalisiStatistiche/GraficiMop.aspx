<%@ Register TagPrefix="uc1" TagName="PageTitle" Src="../WebControls/PageTitle.ascx" %>
<%@ Register TagPrefix="cc2" Namespace="Csy.WebControls" Assembly="CsyWebControls" %>

<%@ Page Language="c#" CodeBehind="GraficiMop.aspx.cs" AutoEventWireup="false" Inherits="TheSite.AnalisiStatistiche.GraficiMop" %>

<%@ Register TagPrefix="uc1" TagName="CalendarPicker" Src="../WebControls/CalendarPicker.ascx" %>
<%@ Register TagPrefix="cc1" Namespace="S_Controls" Assembly="S_Controls" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<html>
<head>
    <title>Report Manutenzione Programmata</title>
    <meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
    <meta content="C#" name="CODE_LANGUAGE">
    <meta content="JavaScript" name="vs_defaultClientScript">
    <meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
    <link href="../Css/MainSheet.css" type="text/css" rel="stylesheet">
    <script language="jscript">
        function superClear() {
            document.getElementById("ifrReport").src = "about:blank"
        }
    </script>
</head>
<body>
    <form id="Form1" method="post" runat="server">
        <table id="TableMain" cellspacing="0" cellpadding="0" width="100%" align="center" border="0">
            <tbody>
                <tr>
                    <td title="Data Di Richiesta" align="center">
                        <uc1:PageTitle ID="PageTitleReport" runat="server"></uc1:PageTitle>
                    </td>
                </tr>
                <tr>
                    <td valign="top" align="center">
                        <table id="tblForm" cellspacing="0" cellpadding="0" width="100%" align="center">
                            <tbody>
                                <tr>
                                    <td valign="top" align="left">
                                        <cc2:DataPanel ID="DataPanelRicerca" runat="server" TitleStyle-CssClass="TitleSearch" Collapsed="False"
                                            TitleText="Ricerca " ExpandText="Espandi" ExpandImageUrl="../Images/down.gif" CollapseText="Riduci"
                                            CssClass="DataPanel75" CollapseImageUrl="../Images/up.gif" AllowTitleExpandCollapse="True">
                                            <table id="TabellaRicercaMaster" cellspacing="0" cellpadding="0" width="100%" border="0">
                                                <tr>
                                                    <td>
                                                        <table id="tblSearch100" cellspacing="1" cellpadding="1" width="100%" border="0">
                                                            <tr>
                                                                <td style="height: 10px" align="left" width="10%">Da</td>
                                                                <td style="height: 10px" align="left" width="40%">
                                                                    <uc1:CalendarPicker ID="DataPkInit" runat="server"></uc1:CalendarPicker>
                                                                    <asp:CompareValidator ID="ValidatorDataInit" TabIndex="11" runat="server" Operator="LessThanEqual" Type="Date"
                                                                        ErrorMessage="La data iniziale dell' intervallo temporale selezionato deve essere minore di quella finale.">*</asp:CompareValidator></td>
                                                                <td style="height: 10px" align="left" width="10%">A</td>
                                                                <td style="height: 10px" align="left" width="40%">
                                                                    <uc1:CalendarPicker ID="DataPkEnd" runat="server"></uc1:CalendarPicker>
                                                                    <asp:CompareValidator ID="ValidatorDataEnd" TabIndex="12" runat="server" Operator="GreaterThanEqual" Type="Date">*</asp:CompareValidator>
                                                                    <script language="javascript">
                                                                        if (<%=status%> == 0) {
                                                                            document.getElementById("<%=DataPkInit.Datazione.ClientID%>").value ="<%=VarDataInit%>";
                                                                                document.getElementById("<%=DataPkEnd.Datazione.ClientID%>").value ="<%=VarDataEnd%>";
                                                                        };
                                                                    </script>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td align="center" colspan="4">
                                                                    <table id="tblRadiobtn" cellspacing="1" cellpadding="1" width="20%" align="center" border="0">
                                                                        <tr>
                                                                            <td nowrap align="left">
                                                                                <cc1:S_OptionButton ID="S_OptBtnDataAssegnazione" TabIndex="1" runat="server" Text="Data Di Assegnazione"
                                                                                    GroupName="GrSelection" Checked="True"></cc1:S_OptionButton></td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td nowrap align="left">
                                                                                <cc1:S_OptionButton ID="S_OptBtnDataChiusura" TabIndex="2" runat="server" Text="Data Di Chiusura" GroupName="GrSelection"></cc1:S_OptionButton></td>
                                                                        </tr>
                                                                    </table>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <table id="tblSearch102" cellspacing="1" cellpadding="1" width="100%" border="0">
                                                            <tr>
                                                                <td align="right" width="10%">
                                                                    <img src="../Images/Pie.png">
                                                                </td>
                                                                <td align="left" width="20%">
                                                                    <cc1:S_OptionButton ID="S_OptBtnRdlMese" TabIndex="3" runat="server" Text="Rdl Per Mese" GroupName="Grkind"
                                                                        Checked="True"></cc1:S_OptionButton></td>
                                                                <td align="center" width="7%">
                                                                    <img src="../Images/GraficiIstogramma.png">
                                                                </td>
                                                                <td align="left" width="26%">
                                                                    <cc1:S_OptionButton ID="S_OptBtnRdlServizioMesi" TabIndex="5" runat="server" Text="Rdl Per Servizio Nei Mesi"
                                                                        GroupName="Grkind"></cc1:S_OptionButton></td>
                                                                <td align="center" width="7%">
                                                                    <img src="../Images/Pie.png">
                                                                </td>
                                                                <td align="left" width="20%">
                                                                    <cc1:S_OptionButton ID="S_OptBtnRdlStato" TabIndex="7" runat="server" Text="Rdl Per Stato" GroupName="Grkind"></cc1:S_OptionButton></td>
                                                            </tr>
                                                            <tr>
                                                                <td align="right" width="10%">
                                                                    <img src="../Images/Pie.png">
                                                                </td>
                                                                <td align="left" width="20%">
                                                                    <cc1:S_OptionButton ID="S_OptBtnRdlDitta" TabIndex="4" runat="server" Text="Rdl Per Ditta" GroupName="Grkind"></cc1:S_OptionButton></td>
                                                                <td align="center" width="7%">
                                                                    <img src="../Images/GraficiIstogramma.png">
                                                                </td>
                                                                <td align="left" width="26%">
                                                                    <cc1:S_OptionButton ID="S_OptBtnRdlDittaMesi" TabIndex="6" runat="server" Text="Rdl Per Ditta Nei Mesi"
                                                                        GroupName="Grkind"></cc1:S_OptionButton></td>
                                                                <td align="center" width="7%">
                                                                    <img src="../Images/Pie.png">
                                                                </td>
                                                                <td align="left" width="20%">
                                                                    <cc1:S_OptionButton ID="S_OptBtnRdlServizio" TabIndex="7" runat="server" Text="Rdl Per Servizio" GroupName="Grkind"></cc1:S_OptionButton></td>
                                                            </tr>
                                                            <tr>
                                                                <td align="center" colspan="6">
                                                                    <table id="tblSubmit" cellspacing="1" cellpadding="1" width="20%" align="center" border="0">
                                                                        <tr>
                                                                            <td nowrap align="left">
                                                                                <cc1:S_Button ID="S_BtnSubmit" TabIndex="9" Visible="false" runat="server" CssClass="btn" Text="Genera il Report in Html"
                                                                                    Width="150px"></cc1:S_Button></td>
                                                                            <td>
                                                                                <asp:Button ID="btnReportPdf" runat="server" CssClass="btn" Text="Genera il Report in Pdf" Width="150px"></asp:Button></td>
                                                                            <td nowrap align="left">
                                                                                <input class="btn" style="width: 150px" onclick="superClear();" tabindex="10" type="reset"
                                                                                    value="Reset">
                                                                            </td>
                                                                            <td nowrap align="right">&nbsp; <a class="GuidaLink"
                                                                                href="<%= HelpLink %>"
                                                                                target="_blank">Guida</a></td>
                                                                        </tr>
                                                                    </table>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                        <asp:ValidationSummary ID="ValidationSummary1" TabIndex="10" runat="server"></asp:ValidationSummary>
                                                    </td>
                                                </tr>
                                            </table>
                                        </cc2:DataPanel>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <table id="DysplayGrafico" height="1200" cellspacing="0" cellpadding="0" align="left" border="0"
                                            width="100%">
                                            <tbody>
                                                <tr>
                                                    <td>
                                                        <iframe class="fram" id="ifrReport" name="ifrReport" frameborder="no" width="100%" scrolling="no"
                                                            height="100%" title="Display Report" tabindex="0" src="about:blank"></iframe>
                                                        <script language="javascript">
                                                            document.getElementById("ifrReport").src ='<%=urlRpt%>'
                                                        </script>
                                                    </td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </td>
                </tr>
            </tbody>
        </table>
    </form>
</body>
</html>
