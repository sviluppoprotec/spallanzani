<%@ Register TagPrefix="cc1" Namespace="S_Controls" Assembly="S_Controls" %>
<%@ Control Language="c#" AutoEventWireup="false" Codebehind="PMPCP.ascx.cs" Inherits="TheSite.WebControls.PMPCP" TargetSchema="http://schemas.microsoft.com/intellisense/ie5"%>
<cc1:S_TextBox id="txtmatricola" runat="server" Width="450px"></cc1:S_TextBox>&nbsp;<INPUT id="btnsRicercamatricola" title="Fare Click per effettuare la Ricerca sui Controlli Periodici" type="button"
				value="Ricerca Controlli Periodici"  onclick="ShowFramePMPCP('<%=idTextRicMat%>','idric',event,'<%=idModuloMat%>');"class=btn>
<div id="Popupmatricole" style="BORDER-BOTTOM: #000000 1px solid; POSITION: absolute; BORDER-LEFT: #000000 1px solid; WIDTH: 500px; DISPLAY: none; HEIGHT: 200px; BORDER-TOP: #000000 1px solid; BORDER-RIGHT: #000000 1px solid">
	<iframe id="docmatricole" style="WIDTH: 100%; HEIGHT: 138px" name="docmatricole" src=""
		frameBorder="no" width="100%"></iframe>
</div>
