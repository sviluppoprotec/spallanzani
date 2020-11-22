<%@ Page Language="c#" CodeBehind="DisplayReportGiudizio.aspx.cs" AutoEventWireup="false" Inherits="TheSite.AnalisiStatistiche.DysplayReportGiudizio" %>

<%@ Register TagPrefix="cr1" Namespace="CrystalDecisions.Web" Assembly="CrystalDecisions.Web, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" %>
<%@ Register TagPrefix="uc1" TagName="CalendarPicker" Src="../WebControls/CalendarPicker.ascx" %>
<%@ Register TagPrefix="cc1" Namespace="S_Controls" Assembly="S_Controls" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<html>
<head>
    <title>DysplayReport</title>
    <meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
    <meta content="C#" name="CODE_LANGUAGE">
    <meta content="JavaScript" name="vs_defaultClientScript">
    <meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
</head>
<body ms_positioning="GridLayout">
    <form id="FrmReport" method="post" runat="server">
        <table id="tblMain" cellspacing="0" cellpadding="0" width="100%" align="left" border="0">
            <tr>
                <td colspan="3">
                    <cr1:CrystalReportViewer ID="rptEngineOra" runat="server" BorderStyle="None" Width="350px" Height="50px"
                        EnableDrillDown="False" HasDrillUpButton="False" HasSearchButton="False"></cr1:CrystalReportViewer>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
