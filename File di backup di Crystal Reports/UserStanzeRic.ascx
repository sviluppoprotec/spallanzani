<%@ Control Language="c#" AutoEventWireup="false" Codebehind="UserStanzeRic.ascx.cs" Inherits="TheSite.WebControls.UserStanzeRic" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<%@ Register TagPrefix="cc1" Namespace="S_Controls" Assembly="S_Controls" %>
<script language="javascript">
		/*	function checkApparecchiatura()
			{
				var app = document.getElementById(idthis + "_S_txtcodapparecchiatura").value;
				if( (app == "") 	||	
					(app.length<3) 	||
					(app.indexOf("_") <0 )
				)
				{
					alert("Inserire almeno un _ e due caratteri, es. _BR");
					return false;
				}
				else{return true;}		
			}	
			if (!checkApparecchiatura()) return;
			*/	
</script>
<TABLE id="Table1" cellSpacing="0" cellPadding="0" width="100%" border="0">
	<TR>
		<TD>
			<cc1:S_TextBox id="s_txtDescStanza" runat="server" Width="344px"></cc1:S_TextBox>&nbsp;
			<INPUT id="bt_codapparecchiatura" style="WIDTH: 32px; HEIGHT: 25px" type="button" value="..."
				onclick="ShowFramest('1',event);" class="btn">&nbsp;
			<asp:TextBox id="TxtIdStanza" Width="0px" runat="server" Height="0px"></asp:TextBox>
		</TD>
	</TR>
</TABLE>
<div id="PopupAppst" style="BORDER-BOTTOM: #000000 1px solid; POSITION: absolute; BORDER-LEFT: #000000 1px solid; WIDTH: 592px; DISPLAY: none; HEIGHT: 274px; BORDER-TOP: #000000 1px solid; BORDER-RIGHT: #000000 1px solid"><iframe id="docstanza" style="WIDTH: 100.54%; HEIGHT: 272px" name="docstanza" src="" frameBorder="no"
		width="100%"> </iframe>
</div>
