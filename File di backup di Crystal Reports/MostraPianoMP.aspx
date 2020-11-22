<%@ Page Language="c#" CodeBehind="MostraPianoMP.aspx.cs" AutoEventWireup="false" Inherits="TheSite.ManutenzioneProgrammata.MostraPianoMP" %>

<%@ Register TagPrefix="cr" Namespace="CrystalDecisions.Web" Assembly="CrystalDecisions.Web, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<html>
<head>
    <title>MostraPianoMP</title>
    <meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
    <meta content="C#" name="CODE_LANGUAGE">
    <meta content="JavaScript" name="vs_defaultClientScript">
    <meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
</head>
<body>
    <form id="Form1" method="post" runat="server">
        <table>
            <tr>
                <td>
                    <cr:CrystalReportViewer ID="crlRptPianoMp" runat="server" Width="350px" Height="50px"></cr:CrystalReportViewer>
                </td>
            </tr>
            <tr>
                <td></td>
            </tr>
        </table>
    </form>
</body>
</html>
