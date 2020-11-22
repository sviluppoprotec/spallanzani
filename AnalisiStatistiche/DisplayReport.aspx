<%@ Page Language="c#" CodeBehind="DisplayReport.aspx.cs" AutoEventWireup="false" Inherits="TheSite.AnalisiStatistiche.DysplayReport" %>

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
    <script language="javascript">
		/*function PrintWindow()
		{
			if (navigator.appName == "Microsoft Internet Explorer")
			{
    			var PrintCommand = '<O B J E C T ID="PrintCommandObject" WIDTH=0 HEIGHT=0 ';
				PrintCommand += 'CLASSID="CLSID:8856F961-340A-11D0-A96B-00C04FD705A2">';
    			document.body.insertAdjacentHTML('beforeEnd', PrintCommand);
    			PrintCommandObject.ExecWB(6, -1); PrintCommandObject.outerHTML = "";
    		}
			else
			{
			window.print();
			}
		}

		var gAutoPrint = true; // Flag for whether or not to automatically call the print function
		function printSpecial()
		{
			if (document.getElementById != null)
			{
				var html = '\n\n';
				if (document.getElementsByTagName != null)
				{
					var headTags = document.getElementsByTagName("head");
					if (headTags.length > 0)
						html += headTags[0].innerHTML;
				}
				html += '\n< / H E A D >\n< B O D Y>\n';
				var printReadyElem = document.getElementById("printReady");
				if (printReadyElem != null)
				{
					html += printReadyElem.innerHTML; }
				else
				{
					alert("Could not find the printReady section in the HTML");
					return;
				}
				html += '\n</ B Y D O>\n</ T L M H>';
				var printWin = window.open("","printSpecial");
				printWin.document.open();
				printWin.document.write(html);
				printWin.document.close();
				if (gAutoPrint)
					printWin.print();
			}
			else
			{
				alert("Sorry, the print ready feature is only available in modern browsers.");
			}
		}
		*/
    </script>
</head>
<body>
    <form id="FrmReport" method="post" runat="server">
        <table id="tblMain" cellspacing="0" cellpadding="0" width="100%" align="left" border="0">
            <!--TR>
					<TD>
						<INPUT type="button" value="Stampa" onclick="PrintWindow();"> <INPUT type="button" value="printSprcial" onclick="printSpecial();">
					</TD>
				</TR-->
            <tr>
                <td>
                    <cr1:CrystalReportViewer ID="rptEngineOra" runat="server" BorderStyle="None" Width="350px" Height="50px"
                        EnableDrillDown="False" HasDrillUpButton="False" HasSearchButton="False"></cr1:CrystalReportViewer>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
