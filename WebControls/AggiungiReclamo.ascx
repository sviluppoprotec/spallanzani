<%@ Control Language="c#" AutoEventWireup="false" Codebehind="AggiungiReclamo.ascx.cs" Inherits="TheSite.WebControls.AggiungiReclamo" TargetSchema="http://schemas.microsoft.com/intellisense/ie5"%>
<INPUT style="WIDTH: 136px; HEIGHT: 22px" id="btsCodice" title="Aggiungi un reclamo alla RDL"
	value="Aggiungi Reclamo" type="button" name="btsCodice" runat="server">
<asp:textbox id="txtWR_ID" runat="server" Width="0px"></asp:textbox>
<div style="BORDER-BOTTOM: #000000 1px solid; POSITION: absolute; BORDER-LEFT: #000000 1px solid; WIDTH: 850px; DISPLAY: none; HEIGHT: 150px; BORDER-TOP: #000000 1px solid; BORDER-RIGHT: #000000 1px solid"
	id="PopupAddReclamo"><IFRAME style="WIDTH: 850px; HEIGHT: 250px" id="addReclamo" src="" frameBorder="no" name="addReclamo">
	</IFRAME>
</div>
