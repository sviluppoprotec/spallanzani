<%@ Page language="c#" Codebehind="ins_doc_normativi.aspx.cs" AutoEventWireup="false" Inherits="TheSite.GestioneControlliPeriodici.ins_doc_normativi" %>
<%@ Register TagPrefix="uc1" TagName="CalendarPicker" Src="../WebControls/CalendarPicker.ascx" %>
<%@ Register TagPrefix="MessPanel" Namespace="Csy.WebControls" Assembly="CsyWebControls" %>
<%@ Register TagPrefix="uc1" TagName="PageTitle" Src="../WebControls/PageTitle.ascx" %>
<%@ Register TagPrefix="cc1" Namespace="S_Controls" Assembly="S_Controls" %>
<%@ Register TagPrefix="MessagePanel1" Namespace="Csy.WebControls" Assembly="CsyWebControls" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<TITLE>Inserimento Documenti Normativi</TITLE>
		<META name="vs_showGrid" content="False">
		<META name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<META name="CODE_LANGUAGE" content="C#">
		<META name="vs_defaultClientScript" content="JavaScript">
		<META name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<LINK rel="stylesheet" type="text/css" href="../Css/MainSheet.css">
		<SCRIPT language="javascript" src="../Js/CommonScript.js"></SCRIPT>
		<SCRIPT>
			function controllaValori(){

				var txtsNomeDoc = document.getElementById('txtsNomeDoc');
				var txtsDescDoc = document.getElementById('txtsDescDoc');
				var txtsNormaApp = document.getElementById('txtsNormaApp');
				var txtsVersDoc = document.getElementById('txtsVersDoc');
				var Uploader = document.getElementById('Uploader');
				var LkCons = document.getElementById('LkCons');
				
				if(txtsNomeDoc.value==''){
					alert('Nome Documento Normativo obbligatorio');
					document.getElementById('txtsNomeDoc').focus()
					return false;
				}
				if(txtsDescDoc.value==''){
					alert('Descrizione Documento obbligatorio');
					document.getElementById('txtsDescDoc').focus()
					return false;
				}
				if(txtsNormaApp.value==''){
					alert('Norma di Appartenenza obbligatorio');
					document.getElementById('txtsNormaApp').focus()
					return false;
				}
				if(Uploader.value==''&& LkCons.innerText==''){
					alert('File obbligatorio');
					document.getElementById('Uploader').focus()
					return false;
				}
				if(txtsVersDoc.value==''){
					alert('Versione Documento obbligatorio');
					document.getElementById('txtsVersDoc').focus()
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
							<TABLE style="WIDTH: 68.46%; HEIGHT: 441px" id="tblFormInput" cellSpacing="1" cellPadding="1"
								align="center">
								<TBODY>
									<TR>
										<TD style="HEIGHT: 4.68%" vAlign="top" align="left"><MESSPANEL:MESSAGEPANEL id="PanelMess" runat="server" messageiconurl="~/Images/ico_info.gif" erroriconurl="~/Images/ico_critical.gif"
												width="136px"></MESSPANEL:MESSAGEPANEL></TD>
									</TR>
									<TR>
										<TD style="HEIGHT: 0.96%" vAlign="top" align="left"><HR SIZE="1" noShade>
										</TD>
									</TR>
									<TR>
										<TD style="HEIGHT: 263px" vAlign="top" align="left"><ASP:PANEL id="PanelEdit" runat="server" Height="256px">
												<TABLE id="tblSearch100" border="1" cellSpacing="0" cellPadding="2">
													<TR>
														<TD width="190" align="left">Nome Documento</TD>
														<TD>
															<cc1:s_textbox style="Z-INDEX: 0" id="txtsNomeDoc" runat="server" width="208px" DBParameterName="nome_doc"
																DBDirection="Input" DBSize="15" MaxLength="15"></cc1:s_textbox></TD>
													</TR>
													<TR>
														<TD width="190" align="left">Descrizione Documento</TD>
														<TD colSpan="3">
															<CC1:S_TEXTBOX id="txtsDescDoc" tabIndex="2" runat="server" width="441px" Height="48px" DBParameterName="desc_doc"
																dbsize="255" dbdirection="Input" maxlength="1000" dbindex="3" TextMode="MultiLine"></CC1:S_TEXTBOX></TD>
													</TR>
													<TR>
														<TD width="190" align="left">Norma di Appartenenza</TD>
														<TD>
															<cc1:s_textbox id="txtsNormaApp" runat="server" width="208px" DBParameterName="p_norma_appartenenza"
																DBDirection="Input" DBSize="15" MaxLength="15"></cc1:s_textbox></TD>
													</TR>
													<TR>
														<TD vAlign="top" width="190">File da inviare:
														</TD>
														<TD>
															<TABLE>
																<TR>
																	<TD style="HEIGHT: 21px"><INPUT style="WIDTH: 344px; HEIGHT: 18px" id="Uploader" size="28" type="file" name="Uploader"
																			runat="server"></TD>
																</TR>
																<TR>
																	<TD style="WIDTH: 128px" colSpan="2"></TD>
																</TR>
																<TR>
																	<TD style="WIDTH: 144px"><STRONG></STRONG></TD>
																	<TD colSpan="5">&nbsp;
																		<asp:hyperlink id="LkCons" runat="server" Target="_blank"></asp:hyperlink>&nbsp;
																		<DIV style="DISPLAY: none">
																			<asp:imagebutton id="btImgDeleteCons" runat="server" ImageUrl="../Images/elimina.gif"></asp:imagebutton></DIV>
																	</TD>
																	<DIV></DIV>
																</TR>
															</TABLE>
														</TD>
													</TR>
													<TR>
														<TD width="190" align="left">Versione Documento</TD>
														<TD>
															<cc1:s_textbox style="Z-INDEX: 0" id="txtsVersDoc" runat="server" width="208px" DBParameterName="versione_doc"
																DBDirection="Input" DBSize="15" MaxLength="15"></cc1:s_textbox></TD>
													</TR>
													<TR>
														<TD style="HEIGHT: 4.53%" vAlign="top" colSpan="2" align="left">
															<CC1:S_BUTTON id="btnSalva" tabIndex="11" runat="server" text="Salva" cssclass="btn" Width="100px"></CC1:S_BUTTON>&nbsp;&nbsp;&nbsp;
															<CC1:S_BUTTON id="btnAnnulla" tabIndex="11" runat="server" text="Annulla" cssclass="btn" Width="100px"></CC1:S_BUTTON>&nbsp;&nbsp;&nbsp;
															<CC1:S_BUTTON id="btnCancella" tabIndex="11" runat="server" text="Cancella" cssclass="btn" Width="100px"></CC1:S_BUTTON></TD>
													</TR>
												</TABLE>
											</ASP:PANEL></TD>
									</TR>
									<TR>
										<TD style="HEIGHT: 5%" vAlign="top" align="left"><ASP:LABEL id="lblFirstAndLast" runat="server"></ASP:LABEL>&nbsp;</TD>
									</TR>
									<TR>
										<TD align="left"><cc1:s_label id="S_Lblerror" runat="server" ForeColor="Red"></cc1:s_label><asp:validationsummary id="ValidationSummary1" runat="server" Width="648px"></asp:validationsummary><cc1:s_label id="S_label1" runat="server"></cc1:s_label></TD>
									</TR>
								</TBODY>
							</TABLE>
							<ASP:VALIDATIONSUMMARY id="vlsEdit" runat="server" showmessagebox="True" displaymode="List" showsummary="False"></ASP:VALIDATIONSUMMARY></TD>
					</TR>
				</TBODY>
			</TABLE>
		</FORM>
	</body>
</HTML>
