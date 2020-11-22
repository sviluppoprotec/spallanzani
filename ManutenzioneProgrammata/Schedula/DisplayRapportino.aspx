<%@ Register TagPrefix="cr" Namespace="CrystalDecisions.Web" Assembly="CrystalDecisions.Web, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" %>

<%@ Page Language="c#" CodeBehind="DisplayRapportino.aspx.cs" AutoEventWireup="false" Inherits="TheSite.ManutenzioneProgrammata.Schedula.DisplayRapportino" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<html>
<head>
    <title>DisplayRapportino</title>
    <meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
    <meta name="CODE_LANGUAGE" content="C#">
    <meta name="vs_defaultClientScript" content="JavaScript">
    <meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
</head>
<body onbeforeunload="parent.left.valorizza()">
    <form id="Form1" method="post" runat="server">
        <table>
            <tr>
                <td align="left">
                    <cr:CrystalReportViewer ID="CRView" runat="server" HasDrillUpButton="False" Width="350px"
                        Height="50px"></cr:CrystalReportViewer>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="txtTipo" runat="server" Visible="False"></asp:TextBox>
                    <asp:TextBox ID="txtHid" runat="server" Visible="False"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="height: 3px"></td>
            </tr>
            <tr>
                <td></td>
            </tr>
            <tr>
                <td></td>
            </tr>
            <tr>
                <td></td>
            </tr>
            <tr>
                <td></td>
            </tr>
        </table>
    </form>
    <script language="javascript">parent.left.calcola();</script>
</body>
</html>
