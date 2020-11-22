<%@ Register TagPrefix="uc1" TagName="CalendarPicker" Src="../WebControls/CalendarPicker.ascx" %>
<%@ Register TagPrefix="cc1" Namespace="S_Controls" Assembly="S_Controls" %>
<%@ Page language="c#" Codebehind="DescrizioneDoc_Dwf.aspx.cs" AutoEventWireup="false" Inherits="TheSite.Gestione.DescrizioneDoc_Dwf" %>
<%@ Register TagPrefix="uc1" TagName="PageTitle" Src="../WebControls/PageTitle.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>DescrizioneDoc_Dwf</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<LINK rel="stylesheet" type="text/css" href="../Css/MainSheet.css">
		<script language="javascript">
		var NS4 = (navigator.appName == "Netscape" && parseInt(navigator.appVersion) < 5);
		var NSX = (navigator.appName == "Netscape");
		var IE4 = (document.all) ? true : false;
		function valutanumeri(evt)
			{
				var e = evt? evt : window.event; 
				if(!e) return; 
				var key = 0; 
				
				if(IE4==true)
				{
					if (e.keyCode < 48	|| e.keyCode > 57){
						e.keyCode = 0;
						return false;
					}	
		        }
		        
				if (e.keycode) { key = e.keycode; } // for moz/fb, if keycode==0 use 'which' 
				if (typeof(e.which)!= 'undefined') { 
					key = e.which;
					if (key < 48	|| key > 57){
						return false;
					} 
					
				} 
			}
			function nonpaste()
			{
				return false;
			}
			function abilita(sender)
			{
			   document.getElementById('<%=txtNumeroPagina.ClientID%>').disabled=!sender.checked;
			}
		</script>
	</HEAD>
	<body onbeforeunload="parent.left.valorizza()" MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<TABLE style="Z-INDEX: 101; POSITION: absolute; TOP: 8px; LEFT: 8px" id="Table1" border="0"
				cellSpacing="1" cellPadding="1" width="100%">
				<TR>
					<TD align="center"></TD>
					<TD align="center"><uc1:pagetitle id="PageTitle1" runat="server"></uc1:pagetitle></TD>
				</TR>
				<TR>
					<TD width="5%" align="left"></TD>
					<TD width="95%" align="left">
						<HR SIZE="1" width="100%">
						&nbsp;</TD>
				</TR>
				<TR>
					<TD width="5%" align="left"></TD>
					<TD width="95%" align="left">
						<TABLE id="tblSearch100" border="0" cellSpacing="1" cellPadding="1" width="100%">
							<TR>
								<TD style="WIDTH: 128px">Codice Documento:</TD>
								<TD><cc1:s_label id="S_LblCodiceDoc" runat="server"></cc1:s_label></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 128px">Nome del File:</TD>
								<TD><cc1:s_label id="S_LblFileName" runat="server"></cc1:s_label></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 128px">Codice Edificio:
								</TD>
								<TD><cc1:s_label id="S_Lblcodedificio" runat="server"></cc1:s_label></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 128px; HEIGHT: 6px">Piano:</TD>
								<TD style="HEIGHT: 6px"><cc1:s_combobox id="cmbsPiano" runat="server" Width="344px" DBIndex="14" DBParameterName="p_piano_id"
										DBDirection="Input" DBDataType="Integer"></cc1:s_combobox></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 128px">Servizio:</TD>
								<TD><cc1:s_combobox id="cmbsServizio" runat="server" Width="344px" DBIndex="15" DBParameterName="p_servizio_id"
										DBDirection="Input" DBDataType="Integer"></cc1:s_combobox><asp:requiredfieldvalidator id="RequiredFieldValidator1" runat="server" ErrorMessage="Selezionare il Servizio"
										ControlToValidate="cmbsServizio" Display="None"></asp:requiredfieldvalidator></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 128px">Categoria Generale:</TD>
								<TD><cc1:s_combobox id="cmbsCategoriaGenerale" runat="server" Width="344px" AutoPostBack="True"></cc1:s_combobox></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 128px; HEIGHT: 14px">Categoria</TD>
								<TD style="HEIGHT: 14px"><cc1:s_combobox id="cmbsCategoria" runat="server" Width="344px" AutoPostBack="True"></cc1:s_combobox></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 128px">Tipologia del Documento:</TD>
								<TD><cc1:s_combobox id="cmbsTipologiaDocumento" runat="server" Width="344px" AutoPostBack="True"></cc1:s_combobox></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 128px; HEIGHT: 24px">Tipologia del File:</TD>
								<TD style="HEIGHT: 24px"><cc1:s_combobox id="cmbsTipoFile" runat="server" Width="344px"></cc1:s_combobox><asp:requiredfieldvalidator id="RequiredFieldValidator2" runat="server" ErrorMessage="Selezionare la Tipologia File"
										ControlToValidate="cmbsTipoFile" Display="None"></asp:requiredfieldvalidator></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 128px">Descrizione:</TD>
								<TD><cc1:s_textbox id="txtsdescrizione" runat="server" Width="90%" DBDirection="Input"></cc1:s_textbox></TD>
							</TR>
							<TR>
								<TD style="DISPLAY:none">Rinomina il File:</TD>
								<TD style="DISPLAY:none">
									<TABLE id="Table2" border="0" cellSpacing="1" cellPadding="1" width="300">
										<TR>
											<TD><cc1:s_checkbox id="CheckRinomina" runat="server"></cc1:s_checkbox></TD>
											<TD>Numero di Pagina:</TD>
											<TD><cc1:s_textbox id="txtNumeroPagina" runat="server" Width="49px">1</cc1:s_textbox></TD>
										</TR>
									</TABLE>
								</TD>
							</TR>
							<TR>
								<TD style="WIDTH: 128px" colSpan="2">
									<TABLE id="TableVVf" border="0" cellSpacing="1" cellPadding="1" width="400" runat="server">
										<TR>
											<TD style="WIDTH: 145px">N° Fascicolo VVF:<asp:requiredfieldvalidator id="RequiredFieldValidator3" runat="server" ErrorMessage="Inserire il N° Fascicolo"
													ControlToValidate="txtNFascicoloVVF" Display="None">*</asp:requiredfieldvalidator></TD>
											<TD><cc1:s_textbox id="txtNFascicoloVVF" runat="server" Width="224px" DBIndex="2" DBParameterName="p_nfascicolo"
													DBDirection="Input" DBSize="20" MaxLength="20"></cc1:s_textbox></TD>
										</TR>
										<TR>
											<TD style="WIDTH: 145px">Data Rilascio CPI:</TD>
											<TD><uc1:calendarpicker id="CalendarPicker1VVF" runat="server"></uc1:calendarpicker></TD>
										</TR>
										<TR>
											<TD style="WIDTH: 145px">Data Scadenza CPI:</TD>
											<TD><uc1:calendarpicker id="CalendarPicker2VVF" runat="server"></uc1:calendarpicker></TD>
										</TR>
										<TR>
											<TD style="WIDTH: 145px">Data Parere Favorevole:</TD>
											<TD><uc1:calendarpicker id="CalendarPicker3VVF" runat="server"></uc1:calendarpicker></TD>
										</TR>
										<TR>
											<TD style="WIDTH: 145px">Collaudo:</TD>
											<TD><cc1:s_checkbox id="checkCollaudoVVF" runat="server"></cc1:s_checkbox></TD>
										</TR>
									</TABLE>
									<TABLE id="TableISPESL" border="0" cellSpacing="1" cellPadding="1" width="400" runat="server">
										<TR>
											<TD>Matricola ISPELS:<asp:requiredfieldvalidator id="RequiredFieldValidator4" runat="server" ErrorMessage="Inserire la Matricola ISPELS"
													ControlToValidate="txtISPESL" Display="None">*</asp:requiredfieldvalidator></TD>
											<TD><cc1:s_textbox id="txtISPESL" runat="server" Width="224px" DBIndex="7" DBParameterName="p_matricola"
													DBDirection="Input" DBSize="20" MaxLength="20"></cc1:s_textbox></TD>
										</TR>
										<TR>
											<TD>Data Prima Verifica:</TD>
											<TD><uc1:calendarpicker id="CalendarPicker4ISPESL" runat="server"></uc1:calendarpicker></TD>
										</TR>
										<TR>
											<TD>Anno Scadenza:</TD>
											<TD><cc1:s_combobox id="S_CbAnno" runat="server" Width="128px" DBIndex="9" DBParameterName="p_anno"
													DBDirection="Input" DBSize="4"></cc1:s_combobox></TD>
										</TR>
									</TABLE>
								</TD>
							</TR>
							<TR>
								<TD style="WIDTH: 128px; HEIGHT: 21px">File da inviare:
									<asp:requiredfieldvalidator id="RequiredFieldValidator5" runat="server" ErrorMessage="Selezionare il file da Inviare"
										ControlToValidate="Uploader" Display="None">*</asp:requiredfieldvalidator></TD>
								<TD style="HEIGHT: 21px"><INPUT style="WIDTH: 344px; HEIGHT: 18px" id="Uploader" size="28" type="file" runat="server"></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 128px" colSpan="2"></TD>
							</TR>
						</TABLE>
						<TABLE style="WIDTH: 400px; HEIGHT: 27px" id="Table3" border="0" cellSpacing="1" cellPadding="1"
							width="400">
							<TR>
								<TD><cc1:s_button id="btNuovo" runat="server" Width="128px" CausesValidation="False" Text="Nuovo File"
										CssClass="btn"></cc1:s_button></TD>
								<TD><cc1:s_button id="btSalva" runat="server" Width="128px" Text="Salva" CssClass="btn"></cc1:s_button></TD>
								<TD><cc1:s_button id="btBack" runat="server" Width="128px" CausesValidation="False" Text="Indietro"
										CssClass="btn"></cc1:s_button></TD>
							</TR>
						</TABLE>
					</TD>
				</TR>
				<TR>
					<TD align="left"></TD>
					<TD align="left">
						<HR SIZE="1" width="100%">
						<cc1:s_label id="S_Lblerror" runat="server" ForeColor="Red"></cc1:s_label><asp:validationsummary id="ValidationSummary1" runat="server" Width="648px"></asp:validationsummary><cc1:s_label id="lblFirstAndLast" runat="server"></cc1:s_label></TD>
				</TR>
			</TABLE>
		</form>
		<script language="javascript">parent.left.calcola();</script>
	</body>
</HTML>
