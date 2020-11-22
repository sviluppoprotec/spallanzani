<%@ Register TagPrefix="MessagePanel1" Namespace="Csy.WebControls" Assembly="CsyWebControls" %>
<%@ Register TagPrefix="cc1" Namespace="S_Controls" Assembly="S_Controls" %>
<%@ Register TagPrefix="uc1" TagName="PageTitle" Src="../WebControls/PageTitle.ascx" %>
<%@ Register TagPrefix="MessPanel" Namespace="Csy.WebControls" Assembly="CsyWebControls" %>
<%@ Register TagPrefix="uc1" TagName="CalendarPicker" Src="../WebControls/CalendarPicker.ascx" %>
<%@ Register TagPrefix="uc1" TagName="RicercaModulo" Src="../WebControls/RicercaModulo.ascx" %>
<%@ Page language="c#" Codebehind="INSCP.aspx.cs" AutoEventWireup="false" Inherits="TheSite.GestioneControlliPeriodici.INSCP" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<TITLE>EditUtenti</TITLE>
		<META name="vs_showGrid" content="False">
		<META name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<META name="CODE_LANGUAGE" content="C#">
		<META name="vs_defaultClientScript" content="JavaScript">
		<META name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<LINK rel="stylesheet" type="text/css" href="../Css/MainSheet.css">
		<SCRIPT language="javascript" src="../Js/CommonScript.js"></SCRIPT>
		<SCRIPT>
			function controllaValori(){
				var LbCPnr= document.getElementById('LbCPnr');
				var txtsCP= document.getElementById('txtsCP');
				var edificio= document.getElementById('RicercaModulo1_txtsCodEdificio');
				
				var cmbs_Frequenza= document.getElementById('cmbs_Frequenza');
				var CalendarPicker1= document.getElementById('CalendarPicker1_S_TxtDatecalendar');
				var CalendarPicker3= document.getElementById('CalendarPicker3_S_TxtDatecalendar');
				var txtsNoteCompletamento= document.getElementById('txtsNoteCompletamento');
				
				if(txtsCP.value==''){
					alert('Controllo Periodico obbligatorio');
					document.getElementById('txtsCP').focus()
					return false;
				}
				if(edificio.value==''){
					alert('Edificio obbligatorio');
					edificio.focus()
					return false;
				}
				if(cmbs_Frequenza.value==''){
					alert('Frequenza obbligatoria');
					document.getElementById('cmbs_Frequenza').focus()
					return false;
				}
				if(CalendarPicker1.value==''){
					alert('Data Prevista obbligatoria');
					document.getElementById('CalendarPicker1_S_TxtDatecalendar').focus()
					return false;
				}
					
				if(CalendarPicker3.value=='' && txtsNoteCompletamento.value!=''){
					alert('Note Completamento valorizzabile solo se valorizzata la Data Fine');
					document.getElementById('txtsNoteCompletamento').focus()
					return false;
				}
				return true;
				//document.getElementById('Form1').submit();
			}
		</SCRIPT>
	</HEAD>
	<body bottomMargin="0" leftMargin="5" rightMargin="0" topMargin="0" ms_positioning="GridLayout">
		<FORM id="Form1" onsubmit="return controllaValori()" method="post" runat="server">
			<TABLE style="Z-INDEX: 101; POSITION: absolute; WIDTH: 100%; HEIGHT: 100%; TOP: 0px; LEFT: 0px"
				id="TableMain" border="0" cellSpacing="0" cellPadding="0" width="100%" align="center">
				<TBODY>
					<TR>
						<TD style="HEIGHT: 50px" align="center"><UC1:PAGETITLE id="PageTitle1" runat="server"></UC1:PAGETITLE></TD>
					</TR>
					<TR>
						<TD height="95%" vAlign="top" align="center">
							<TABLE id="tblFormInput" cellSpacing="1" cellPadding="1" align="center">
								<TBODY>
									<TR>
										<TD style="WIDTH: 5%; HEIGHT: 4.68%" vAlign="top" align="left"></TD>
										<TD style="HEIGHT: 4.68%" vAlign="top" align="left"><MESSPANEL:MESSAGEPANEL id="PanelMess" runat="server" messageiconurl="~/Images/ico_info.gif" erroriconurl="~/Images/ico_critical.gif"
												width="136px"></MESSPANEL:MESSAGEPANEL></TD>
									</TR>
									<TR>
										<TD style="HEIGHT: 0.96%" vAlign="top" align="left"></TD>
										<TD style="HEIGHT: 0.96%" vAlign="top" align="left"><HR SIZE="1" noShade>
										</TD>
									</TR>
									<TR>
										<TD vAlign="top" align="center"></TD>
										<TD vAlign="top" align="left"><ASP:PANEL id="PanelEdit" runat="server">
												<TABLE id="tblSearch100" border="1" cellSpacing="0" cellPadding="2">
													<TBODY>
														<TR>
															<TD width="20%" align="left">Controllo Periodico NR:&nbsp;</TD>
															<TD style="WIDTH: 405px" width="405"><ASP:LABEL id="LbCPnr" runat="server" Height="14px" Width="112px"></ASP:LABEL></TD>
															<ASP:LABEL id="lblOdl" runat="server"></ASP:LABEL></TD>
									</TR>
									<TR>
										<TD width="20%" align="left">Controllo Periodico:</TD>
										<TD colSpan="3"><CC1:S_TEXTBOX id="txtsCP" tabIndex="2" runat="server" width="90%" dbsize="255" dbdirection="Input"
												maxlength="1000" dbindex="3" TextMode="MultiLine"></CC1:S_TEXTBOX></TD>
									</TR>
									<tr>
										<td colSpan="2"><uc1:ricercamodulo id="RicercaModulo1" runat="server"></uc1:ricercamodulo></td>
									</tr>
									<TR>
										<TD width="20%" align="left">Frequenza Controllo Periodico:&nbsp;</TD>
										<TD colSpan="3"><CC1:S_COMBOBOX id="cmbs_Frequenza" runat="server" Width="312px"></CC1:S_COMBOBOX></TD>
									</TR>
									<tr>
										<TD>
											Descrizione Servizio:</TD>
										<TD><asp:dropdownlist id="Dropdownlist1" runat="server">
												<asp:ListItem Value="A1">A1 Servizio Imp. Climat. Invernale</asp:ListItem>
												<asp:ListItem Value="A2">A2 Servizio Idrico</asp:ListItem>
												<asp:ListItem Value="B1">B1 Servizio Imp. Climat. Estiva </asp:ListItem>
												<asp:ListItem Value="B2">B2 Servizio Imp. Elettrici, Speciali e di Illuminazione</asp:ListItem>
												<asp:ListItem Value="C1">C1 Servizio Imp.Antincendio</asp:ListItem>
												<asp:ListItem Value="C2">C2 Servizio Imp.di Trasporto verticale ed orizzontale</asp:ListItem>
												<asp:ListItem Value="C3">C3 Servizio di minuto Mantenimento Edile</asp:ListItem>
												<asp:ListItem Value="D7">D7 Costituzione e Gestione dell’Anagrafica Tecnica</asp:ListItem>
											</asp:dropdownlist></TD>
									</tr>
									<TR>
										<TD align="left">Data&nbsp;Prevista :</TD>
										<TD style="WIDTH: 405px"><UC1:CALENDARPICKER id="CalendarPicker1" runat="server"></UC1:CALENDARPICKER></TD>
									</TR>
									<TR>
										<TD align="left">Data&nbsp;Completamento :</TD>
										<TD style="WIDTH: 405px"><UC1:CALENDARPICKER id="CalendarPicker3" runat="server"></UC1:CALENDARPICKER></TD>
									</TR>
									<TR>
										<TD width="20%" align="left">Note Completamento:</TD>
										<TD colSpan="3"><CC1:S_TEXTBOX id="txtsNoteCompletamento" tabIndex="2" runat="server" width="90%" dbsize="255"
												dbdirection="Input" maxlength="1000" dbindex="3" TextMode="MultiLine" dbparametername="pIndirizzo"></CC1:S_TEXTBOX></TD>
									</TR>
									<TR>
										<td colSpan="2">
											<table>
												<TBODY>
													<tr>
														<TD style="WIDTH: 128px; HEIGHT: 21px">File da inviare:
														</TD>
														<TD style="HEIGHT: 21px"><INPUT style="WIDTH: 344px; HEIGHT: 18px" id="Uploader" size="28" type="file" name="Uploader"
																runat="server"></TD>
													</tr>
													<TR>
														<TD style="WIDTH: 128px" colSpan="2"></TD>
													</TR>
													<TR>
														<TD style="WIDTH: 144px"><STRONG></STRONG></TD>
														<TD colSpan="5">&nbsp;
															<asp:hyperlink id="LkCons" runat="server" Target="_blank"></asp:hyperlink>&nbsp;
															<asp:imagebutton id="btImgDeleteCons" runat="server" ImageUrl="../Images/elimina.gif"></asp:imagebutton></TD>
													</TR>
												</TBODY>
											</table>
										</td>
									</TR>
								</TBODY>
							</TABLE>
							</ASP:PANEL></TD>
					</TR>
					<TR>
						<TD style="HEIGHT: 4.53%" vAlign="top" align="left"></TD>
						<TD style="HEIGHT: 4.53%" vAlign="top" align="left"><CC1:S_BUTTON id="btnSalva" tabIndex="11" runat="server" Width="100px" text="Salva" cssclass="btn"></CC1:S_BUTTON>&nbsp;&nbsp;&nbsp;
							<INPUT style="WIDTH: 100px" class="btn" onclick="javascript:history.back();" value="Annulla"
								type="button"> &nbsp;&nbsp;&nbsp;&nbsp;
							<CC1:S_BUTTON id="btnCancella" tabIndex="11" runat="server" Width="100px" text="Cancella" cssclass="btn"></CC1:S_BUTTON></TD>
					</TR>
					<TR>
						<TD style="HEIGHT: 5%" vAlign="top" align="left"></TD>
						<TD style="HEIGHT: 5%" vAlign="top" align="left"><ASP:LABEL id="lblFirstAndLast" runat="server"></ASP:LABEL>&nbsp;</TD>
					</TR>
					<TR>
						<TD align="left"></TD>
						<TD align="left">
							<HR SIZE="1" width="100%">
							<cc1:s_label id="S_Lblerror" runat="server" ForeColor="Red"></cc1:s_label><asp:validationsummary id="ValidationSummary1" runat="server" Width="648px"></asp:validationsummary><cc1:s_label id="S_label1" runat="server"></cc1:s_label></TD>
					</TR>
				</TBODY>
			</TABLE>
			<ASP:VALIDATIONSUMMARY id="vlsEdit" runat="server" showsummary="False" displaymode="List" showmessagebox="True"></ASP:VALIDATIONSUMMARY></TD></TR></TBODY></TABLE></FORM>
		</TR></TBODY></TABLE></TR></TBODY></TABLE></TR></TBODY></TABLE></TR></TBODY></TABLE></FORM>
	</body>
</HTML>
