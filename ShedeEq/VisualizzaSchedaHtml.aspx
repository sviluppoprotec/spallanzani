<%@ Page Language="c#" CodeBehind="VisualizzaSchedaHtml.aspx.cs" AutoEventWireup="false" Inherits="TheSite.ShedeEq.VisualizzaSchedaHtml" %>

<%@ Register TagPrefix="cr" Namespace="CrystalDecisions.Web" Assembly="CrystalDecisions.Web, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<html>
<head>
    <title>VisualizzaSchedaHtml</title>
    <meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
    <meta content="C#" name="CODE_LANGUAGE">
    <meta content="JavaScript" name="vs_defaultClientScript">
    <meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
    <link href="../Css/MainSheet.css" type="text/css" rel="stylesheet">
</head>
<body>
    <form id="Form1" method="post" runat="server">
        <table id="TblMain" width="100%">
            <tr>
                <td>
                    <cr:CrystalReportViewer ID="CryVwSchedaEq" runat="server" Width="350px" Height="50px"
                        EnableDrillDown="False" HasDrillUpButton="False" HasSearchButton="False" BorderStyle="None" pagetotreeratio="10"></cr:CrystalReportViewer>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnIndietro" runat="server" Width="150px" CssClass="btn" Text="Nuova Ricerca"></asp:Button></td>
            </tr>
        </table>
    </form>
</body>
</html>
