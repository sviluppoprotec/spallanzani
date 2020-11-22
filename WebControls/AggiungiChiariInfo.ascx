<%@ Control Language="c#" AutoEventWireup="false" Codebehind="AggiungiChiariInfo.ascx.cs" Inherits="TheSite.WebControls.AggiungiChiariInfo" TargetSchema="http://schemas.microsoft.com/intellisense/ie5"%>
<INPUT id="btsCodice" title="Aggiungi un Chiarimento-Informazione alla RDL" style="Z-INDEX: 0; WIDTH: 208px; HEIGHT: 40px"
	type="button" value="Aggiungi Chiarimento Informazioni" runat="server" NAME="btsCodice">
<asp:textbox id="txtWR_ID" runat="server" Width="0px"></asp:textbox>
<div id="PopupAddChiariInfo" style="BORDER-BOTTOM: #000000 1px solid; POSITION: absolute; BORDER-LEFT: #000000 1px solid; WIDTH: 850px; DISPLAY: none; HEIGHT: 150px; BORDER-TOP: #000000 1px solid; BORDER-RIGHT: #000000 1px solid">
	<IFRAME id="addChiariInfo" name="addChiariInfo" src="" frameBorder="no" style="WIDTH:850px; HEIGHT:250px">
	</IFRAME>
</div>
