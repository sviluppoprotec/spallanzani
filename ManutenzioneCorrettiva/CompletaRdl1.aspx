<%@ Register TagPrefix="uc1" TagName="CalendarPicker" Src="../WebControls/CalendarPicker.ascx" %>
<%@ Register TagPrefix="cc1" Namespace="S_Controls" Assembly="S_Controls" %>
<%@ Register TagPrefix="cc2" Namespace="Csy.WebControls" Assembly="CsyWebControls" %>
<%@ Register TagPrefix="uc1" TagName="PageTitle" Src="../WebControls/PageTitle.ascx" %>
<%@ Register TagPrefix="uc1" TagName="VisualizzaSolleciti" Src="../WebControls/VisualizzaSolleciti.ascx" %>
<%@ Register TagPrefix="uc1" TagName="AggiungiSollecito" Src="../WebControls/AggiungiSollecito.ascx" %>
<%@ Page language="c#" Codebehind="CompletaRdl1.aspx.cs" AutoEventWireup="false" Inherits="TheSite.ManutenzioneCorrettiva.CompletaRdl1" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>Completamento Richiesta</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<LINK rel="stylesheet" type="text/css" href="../Css/MainSheet.css">
		<SCRIPT language="javascript" src="../images/cal/popcalendar.js"></SCRIPT>
		<SCRIPT language="javascript" src="jscompleta.js"></SCRIPT>
	</HEAD>
	<body onbeforeunload="closewin();" MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<TABLE style="Z-INDEX: 101; POSITION: absolute; TOP: 8px; LEFT: 8px" id="Table1" border="0"
				cellSpacing="1" cellPadding="1" width="100%">
				<TR>
					<TD align="center"><uc1:pagetitle id="PageTitle1" runat="server"></uc1:pagetitle></TD>
				</TR>
				<TR>
					<TD>
						<TABLE id="Table2" border="0" cellSpacing="1" cellPadding="1" width="100%">
							<TBODY>
								<TR>
									<TD><cc2:datapanel id="PanelGeneral" runat="server" cssclass="DataPanel75" allowtitleexpandcollapse="True"
											collapseimageurl="../Images/up.gif" collapsetext="Riduci" expandimageurl="../Images/down.gif"
											expandtext="Espandi" titletext="Dati della Richiesta" collapsed="False" titlestyle-cssclass="TitleSearch">
											<TABLE id="tblSearch100" border="0" cellSpacing="0" cellPadding="0" width="100%">
												<TR>
													<TD style="HEIGHT: 12px" width="20%"><B>RDL N°</B></TD>
													<TD style="WIDTH: 169px; HEIGHT: 12px">
														<ASP:LABEL id="LblRdl" runat="server" width="174px"></ASP:LABEL></TD>
													<TD style="HEIGHT: 12px"><B><INPUT style="WIDTH: 16px; HEIGHT: 18px" id="hidBl_id" size="1" type="hidden" name="hidBl_id"
																runat="server"><INPUT style="WIDTH: 16px; HEIGHT: 18px" id="HPageBack" size="1" type="hidden" name="HPageBack"
																runat="server"><INPUT style="WIDTH: 16px; HEIGHT: 18px" id="HSga" size="1" type="hidden" name="HSga" runat="server"><INPUT style="WIDTH: 16px; HEIGHT: 18px" id="HPrj" size="1" type="hidden" name="HPrj" runat="server"></B></TD>
													<TD style="HEIGHT: 12px"></TD>
												</TR>
												<TR>
													<TD style="HEIGHT: 12px"><B>Nominativo Richiedente:</B></TD>
													<TD style="WIDTH: 169px; HEIGHT: 12px">
														<ASP:LABEL id="lblRichiedente" runat="server" width="174px"></ASP:LABEL></TD>
													<TD style="HEIGHT: 12px"><B>Operatore:</B></TD>
													<TD style="HEIGHT: 12px">
														<ASP:LABEL id="lblOperatore" runat="server" width="128px"></ASP:LABEL></TD>
												</TR>
												<TR>
													<TD><B>Telefono Richiedente:</B></TD>
													<TD>
														<ASP:LABEL id="lbltelefonoric" runat="server" width="174px"></ASP:LABEL></TD>
													<TD style="HEIGHT: 29px"><B>Data Richiesta:</B></TD>
													<TD style="HEIGHT: 29px">
														<ASP:LABEL id="lblDataRichiesta" runat="server" width="128px"></ASP:LABEL></TD>
												</TR>
												<TR>
													<TD><B>Gruppo Richiedente:</B></TD>
													<TD style="WIDTH: 169px">
														<ASP:LABEL id="lblGruppo" runat="server" width="174px"></ASP:LABEL></TD>
													<TD><B>Orario Richiesta:</B></TD>
													<TD>
														<ASP:LABEL id="lblOraRichiesta" runat="server" width="128px"></ASP:LABEL></TD>
												</TR>
												<TR>
													<TD><B>Email Richiedente:</B></TD>
													<TD style="WIDTH: 169px">
														<ASP:LABEL id="lblemailric" runat="server" width="174px"></ASP:LABEL></TD>
													<TD><B>Stanza Richiedente:</B></TD>
													<TD>
														<ASP:LABEL id="lblstanzaric" runat="server" width="128px"></ASP:LABEL></TD>
												</TR>
												<TR>
													<TD><B>Edificio:</B></TD>
													<TD colSpan="3">
														<ASP:LABEL id="lblfabbricato" runat="server" width="472px"></ASP:LABEL>
														<ASP:TEXTBOX id="txtHidBl" runat="server" width="0px"></ASP:TEXTBOX></TD>
												</TR>
												<TR>
													<TD><B>Piano:</B></TD>
													<TD style="WIDTH: 169px">
														<ASP:LABEL id="lblPiano" runat="server" width="174px"></ASP:LABEL></TD>
													<TD><B>Stanza:</B></TD>
													<TD>
														<ASP:LABEL id="lblStanza" runat="server" width="174px"></ASP:LABEL></TD>
												</TR>
												<TR>
													<TD><B>Telefono:</B></TD>
													<TD colSpan="3">
														<ASP:LABEL id="lblTelefono" runat="server" width="174px"></ASP:LABEL></TD>
												<TR>
													<TD><B>Note:</B></TD>
													<TD colSpan="3">
														<ASP:LABEL id="lblNote" runat="server" width="472px"></ASP:LABEL>
														<ASP:LABEL id="presidio" runat="server" width="0px" Height="0px"></ASP:LABEL></TD>
												</TR>
												<TR>
													<TD style="HEIGHT: 24px"><B>Servizio:</B></TD>
													<TD style="HEIGHT: 24px" colSpan="3">
														<CC1:S_COMBOBOX id="cmbsServizio" runat="server" width="480px" autopostback="True"></CC1:S_COMBOBOX></TD>
												</TR>
												<TR>
													<TD style="HEIGHT: 19px"><B>Standard Apparecchiatura:</B></TD>
													<TD style="HEIGHT: 19px" colSpan="3">
														<CC1:S_COMBOBOX id="cmdsStdApparecchiatura" runat="server" width="480px" dbdatatype="Integer" AutoPostBack="True"
															dbindex="1" dbdirection="Input" dbparametername="p_eqstd_id" dbsize="10"></CC1:S_COMBOBOX></TD>
												</TR>
												<TR>
													<TD><B>Apparecchiatura:</B></TD>
													<TD colSpan="3">
														<CC1:S_COMBOBOX id="cmbEQ" runat="server" width="480px" dbdatatype="Integer" dbindex="1" dbdirection="Input"
															dbparametername="p_id_eq" dbsize="10"></CC1:S_COMBOBOX></TD>
												</TR>
												<TR>
													<TD><B>Descrizione Intervento/Note:</B></TD>
													<TD colSpan="3">
														<CC1:S_TEXTBOX id="txtsDescrizione" runat="server" width="480px" textmode="MultiLine" height="34px"></CC1:S_TEXTBOX></TD>
												</TR>
												<TR>
													<TD><B>Causa Presunta Guasto/Anomalia:</B></TD>
													<TD colSpan="3">
														<CC1:S_TEXTBOX id="txtCausa" runat="server" width="480px" textmode="MultiLine" height="34px" MaxLength="408"></CC1:S_TEXTBOX></TD>
												</TR>
												<TR>
													<TD><B>Effetto del Guasto/Anomalia:</B></TD>
													<TD colSpan="3">
														<CC1:S_TEXTBOX id="txtEffettoGuasto" runat="server" width="480px" textmode="MultiLine" height="34px"
															MaxLength="408"></CC1:S_TEXTBOX>
														<uc1:VisualizzaSolleciti id="VisualizzaSolleciti1" runat="server"></uc1:VisualizzaSolleciti></TD>
												</TR>
											</TABLE>
										</cc2:datapanel></TD>
								</TR>
								<TR>
									<TD><cc2:datapanel id="Datapanel1" runat="server" cssclass="DataPanel75" allowtitleexpandcollapse="True"
											collapseimageurl="../Images/up.gif" collapsetext="Riduci" expandimageurl="../Images/down.gif"
											expandtext="Espandi" titletext="Report Lavoro SGA" collapsed="False" titlestyle-cssclass="TitleSearch"
											Visible="False">
											<TABLE id="Table3" border="0" cellSpacing="1" cellPadding="1" width="100%">
												<TR>
													<TD style="HEIGHT: 38px" colSpan="3">
														<TABLE style="WIDTH: 528px; HEIGHT: 100%" id="Table18" border="0" cellSpacing="0" cellPadding="0"
															width="528">
														</TABLE>
													</TD>
												</TR>
												<TR id="trprev1">
													<TD style="WIDTH: 139px"><B>Importo Presunto:</B></TD>
													<TD>
														<TABLE style="WIDTH: 528px; HEIGHT: 100%">
															<TR>
																<TD>
																	<CC1:S_TEXTBOX style="TEXT-ALIGN: right" id="txtImp1" runat="server" width="48px" maxlength="8">0</CC1:S_TEXTBOX>,
																	<CC1:S_TEXTBOX id="txtImp1_1" runat="server" width="27px" maxlength="2">00</CC1:S_TEXTBOX></TD>
																<TD><B>Oltre Iva:</B></TD>
																<TD>
																	<CC1:S_TEXTBOX style="TEXT-ALIGN: right" id="txtPercentuale1" runat="server" width="24px" maxlength="2"></CC1:S_TEXTBOX><B>%</B></TD>
															</TR>
														</TABLE>
													</TD>
												<TR id="trprev2">
													<TD style="WIDTH: 139px"><B>Importo Forfettario:</B></TD>
													<TD>,
														<TABLE style="WIDTH: 528px; HEIGHT: 100%" id="Table19">
															<TR>
																<TD>
																	<CC1:S_TEXTBOX style="TEXT-ALIGN: right" id="txtImp2" runat="server" width="48px" maxlength="8">0</CC1:S_TEXTBOX>,
																	<CC1:S_TEXTBOX id="txtImp2_1" runat="server" width="27px" maxlength="2">00</CC1:S_TEXTBOX></TD>
																<TD><B>Oltre Iva:</B></TD>
																<TD><B>
																		<CC1:S_TEXTBOX style="TEXT-ALIGN: right" id="txtPercentuale2" runat="server" width="24px" maxlength="2"></CC1:S_TEXTBOX>%</B></TD>
															</TR>
														</TABLE>
													</TD>
												</TR>
												<TR id="trprev3">
													<TD style="WIDTH: 139px" class="sga"><B class="blueoverline">Modalita di Pagameno:</B></TD>
													<TD colSpan="3">
														<CC1:S_TEXTBOX id="txtModalitaPagamento" runat="server" width="480px" textmode="MultiLine" height="34px"
															MaxLength="112"></CC1:S_TEXTBOX></TD>
												</TR>
											</TABLE>
										</cc2:datapanel></TD>
								</TR>
								<TR>
									<TD><cc2:datapanel id="Datapanel2" runat="server" cssclass="DataPanel75" allowtitleexpandcollapse="True"
											collapseimageurl="../Images/up.gif" collapsetext="Riduci" expandimageurl="../Images/down.gif"
											expandtext="Espandi" titletext="Documentazione in allegato" collapsed="False" titlestyle-cssclass="TitleSearch"><INPUT style="WIDTH: 392px; HEIGHT: 18px" id="UploadFile" size="46" type="file" name="UploadFile"
												runat="server">&nbsp; <asp:button id="BtUpload" runat="server" Text="Invia il File..."></asp:button><asp:repeater id="rpdc" Runat="server">
												<HeaderTemplate>
													<table border="0">
														<tr>
															<td>Nome Documento</td>
															<td>Download del Documento</td>
															<td>Elimina</td>
														</tr>
												</HeaderTemplate>
												<ItemTemplate>
													<tr>
														<td><%# DataBinder.Eval(Container.DataItem, "Nome_Doc") %></td>
														<td><asp:Label Runat="server" ID="lbln"></asp:Label></td>
														<td><asp:ImageButton ID="delete"  ImageUrl="../Images/elimina.gif" Runat="server" CommandName="Delete"  CommandArgument='<%# DataBinder.Eval(Container.DataItem, "id_file") + "," + DataBinder.Eval(Container.DataItem, "Nome_Doc") %>'></asp:ImageButton></td>
													</tr>
												</ItemTemplate>
												<FooterTemplate>
						</TABLE>
						</FooterTemplate> </asp:repeater></cc2:datapanel></TD>
				</TR>
				<tr>
					<TD><cc2:datapanel id="Datapanel6" runat="server" cssclass="DataPanel75" allowtitleexpandcollapse="True"
							collapseimageurl="../Images/up.gif" collapsetext="Riduci" expandimageurl="../Images/down.gif"
							expandtext="Espandi" titletext="Preventivo RdL" collapsed="False" titlestyle-cssclass="TitleSearch">
							<TABLE id="TablePrev" border="0" cellSpacing="1" cellPadding="1" width="100%">
								<TR>
									<TD><STRONG>Preventivo N°:</STRONG></TD>
									<TD style="WIDTH: 241px">
										<asp:textbox id="TxtNumPreventivo" runat="server" MaxLength="8"></asp:textbox></TD>
									<TD style="WIDTH: 141px" align="right"><STRONG>Importo Preventivo: &nbsp;</STRONG></TD>
									<TD>
										<CC1:S_TEXTBOX style="TEXT-ALIGN: right" id="txtImpPrev1" runat="server" width="48px" maxlength="8">0</CC1:S_TEXTBOX>,
										<CC1:S_TEXTBOX id="txtImpPrev2" runat="server" width="27px" maxlength="2">00</CC1:S_TEXTBOX></TD>
								</TR>
								<TR>
									<TD><STRONG>File Preventivo:</STRONG></TD>
									<TD colSpan="3"><INPUT style="WIDTH: 392px; HEIGHT: 18px" id="FilePreventivo" size="46" type="file" name="File1"
											runat="server">&nbsp;
										<asp:button id="BtInviaPreventivo" runat="server" Text="Salva il Preventivo"></asp:button></TD>
								</TR>
								<TR>
									<TD></TD>
									<TD colSpan="3">
										<asp:hyperlink id="LkPrev" runat="server"></asp:hyperlink>&nbsp;
										<asp:imagebutton id="btImgDelete" runat="server" ImageUrl="../Images/elimina.gif"></asp:imagebutton></TD>
								</TR>
							</TABLE>
						</cc2:datapanel></TD>
				</tr>
				<TR>
					<TD><cc2:datapanel id="Datapanel3" runat="server" cssclass="DataPanel75" allowtitleexpandcollapse="True"
							collapseimageurl="../Images/up.gif" collapsetext="Riduci" expandimageurl="../Images/down.gif"
							expandtext="Espandi" titletext="Emissione Ordine - Report SGA" collapsed="False" titlestyle-cssclass="TitleSearch">
							<TABLE id="Table4" border="0" cellSpacing="1" cellPadding="1" width="100%">
								<TR>
									<TD><STRONG>Ordine:</STRONG></TD>
									<TD style="WIDTH: 241px"><asp:label id="LblOrdine" runat="server" Font-Bold="True"></asp:label></TD>
									<TD style="WIDTH: 141px"></TD>
									<TD></TD>
								</TR>
								<TR>
									<TD><STRONG>Urgenza:</STRONG></TD>
									<TD colSpan="3"><CC1:S_COMBOBOX id="cmbsUrgenza" runat="server" width="400px"></CC1:S_COMBOBOX></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 139px; HEIGHT: 38px" vAlign="middle" align="left"><B>Tipo 
											Manutenzione:</B></TD>
									<TD style="WIDTH: 241px; HEIGHT: 27px"><CC1:S_COMBOBOX id="cmbsTipoManutenzione" runat="server" width="196px"></CC1:S_COMBOBOX></TD>
									<TD style="HEIGHT: 27px" vAlign="middle"><B>Programmabilità Intervento:</B></TD>
									<TD style="HEIGHT: 27px"><CC1:S_COMBOBOX id="cmbsTipoIntrevento" runat="server" width="200px" DBDirection="Input" DBDataType="VarChar"></CC1:S_COMBOBOX></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 11.3%"><B class="blueoverline">Soluzione Proposta:</B></TD>
									<TD colSpan="3"><CC1:S_TEXTBOX id="txtSoluzioneProposta" runat="server" width="480px" textmode="MultiLine" height="34px"
											MaxLength="408"></CC1:S_TEXTBOX></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 139px"><B class="blueoverline">Note SGA:</B></TD>
									<TD colSpan="3"><CC1:S_TEXTBOX id="txtNoteSga" runat="server" width="480px" textmode="MultiLine" height="34px"
											MaxLength="408"></CC1:S_TEXTBOX></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 139px"><STRONG>SGA:</STRONG></TD>
									<TD colSpan="3"><asp:label id="lblSGA" runat="server" Font-Bold="True"></asp:label>&nbsp;
										<asp:label id="LblDataInvioSga" runat="server" Font-Bold="True"></asp:label></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 139px"></TD>
									<TD style="WIDTH: 241px"><asp:button id="BtSalvaSGA" runat="server" Text="Salva/Invia SGA" Width="120px"></asp:button>&nbsp;&nbsp;
									</TD>
									<TD></TD>
									<TD></TD>
								</TR>
								<TR>
									<TD><STRONG>Ditta Esecutrice:</STRONG></TD>
									<TD style="WIDTH: 241px"><CC1:S_COMBOBOX id="cmbsDitta" runat="server" width="196px" autopostback="True"></CC1:S_COMBOBOX></TD>
									<TD style="WIDTH: 141px" align="left"><STRONG>Addetto: &nbsp;</STRONG></TD>
									<TD><CC1:S_COMBOBOX id="cmbsAddetto" runat="server" width="273px"></CC1:S_COMBOBOX></TD>
								</TR>
								<TR>
									<TD><B>Sopralluogo effettuato in data:</B></TD>
									<TD>
										<uc1:CalendarPicker id="CalendarPicker5" runat="server"></uc1:CalendarPicker>
										<CC1:S_COMBOBOX style="Z-INDEX: 0" id="S_COMBOBOX6" runat="server" dbdatatype="Integer">
											<asp:ListItem Value="00">00</asp:ListItem>
											<asp:ListItem Value="01">01</asp:ListItem>
											<asp:ListItem Value="02">02</asp:ListItem>
											<asp:ListItem Value="03">03</asp:ListItem>
											<asp:ListItem Value="04">04</asp:ListItem>
											<asp:ListItem Value="05">05</asp:ListItem>
											<asp:ListItem Value="06">06</asp:ListItem>
											<asp:ListItem Value="07">07</asp:ListItem>
											<asp:ListItem Value="08">08</asp:ListItem>
											<asp:ListItem Value="09">09</asp:ListItem>
											<asp:ListItem Value="10">10</asp:ListItem>
											<asp:ListItem Value="11">11</asp:ListItem>
											<asp:ListItem Value="12">12</asp:ListItem>
											<asp:ListItem Value="13">13</asp:ListItem>
											<asp:ListItem Value="14">14</asp:ListItem>
											<asp:ListItem Value="15">15</asp:ListItem>
											<asp:ListItem Value="16">16</asp:ListItem>
											<asp:ListItem Value="17">17</asp:ListItem>
											<asp:ListItem Value="18">18</asp:ListItem>
											<asp:ListItem Value="19">19</asp:ListItem>
											<asp:ListItem Value="20">20</asp:ListItem>
											<asp:ListItem Value="21">21</asp:ListItem>
											<asp:ListItem Value="22">22</asp:ListItem>
											<asp:ListItem Value="23">23</asp:ListItem>
										</CC1:S_COMBOBOX>
										<CC1:S_COMBOBOX style="Z-INDEX: 0" id="S_COMBOBOX5" runat="server" width="40px" dbdatatype="Integer">
											<asp:ListItem Value="00">00</asp:ListItem>
											<asp:ListItem Value="01">01</asp:ListItem>
											<asp:ListItem Value="02">02</asp:ListItem>
											<asp:ListItem Value="03">03</asp:ListItem>
											<asp:ListItem Value="04">04</asp:ListItem>
											<asp:ListItem Value="05">05</asp:ListItem>
											<asp:ListItem Value="06">06</asp:ListItem>
											<asp:ListItem Value="07">07</asp:ListItem>
											<asp:ListItem Value="08">08</asp:ListItem>
											<asp:ListItem Value="09">09</asp:ListItem>
											<asp:ListItem Value="10">10</asp:ListItem>
											<asp:ListItem Value="11">11</asp:ListItem>
											<asp:ListItem Value="12">12</asp:ListItem>
											<asp:ListItem Value="13">13</asp:ListItem>
											<asp:ListItem Value="14">14</asp:ListItem>
											<asp:ListItem Value="15">15</asp:ListItem>
											<asp:ListItem Value="16">16</asp:ListItem>
											<asp:ListItem Value="17">17</asp:ListItem>
											<asp:ListItem Value="18">18</asp:ListItem>
											<asp:ListItem Value="19">19</asp:ListItem>
											<asp:ListItem Value="20">20</asp:ListItem>
											<asp:ListItem Value="21">21</asp:ListItem>
											<asp:ListItem Value="22">22</asp:ListItem>
											<asp:ListItem Value="23">23</asp:ListItem>
											<asp:ListItem Value="24">24</asp:ListItem>
											<asp:ListItem Value="25">25</asp:ListItem>
											<asp:ListItem Value="26">26</asp:ListItem>
											<asp:ListItem Value="27">27</asp:ListItem>
											<asp:ListItem Value="28">28</asp:ListItem>
											<asp:ListItem Value="29">29</asp:ListItem>
											<asp:ListItem Value="30">30</asp:ListItem>
											<asp:ListItem Value="31">31</asp:ListItem>
											<asp:ListItem Value="32">32</asp:ListItem>
											<asp:ListItem Value="33">33</asp:ListItem>
											<asp:ListItem Value="34">34</asp:ListItem>
											<asp:ListItem Value="35">35</asp:ListItem>
											<asp:ListItem Value="36">36</asp:ListItem>
											<asp:ListItem Value="37">37</asp:ListItem>
											<asp:ListItem Value="38">38</asp:ListItem>
											<asp:ListItem Value="39">39</asp:ListItem>
											<asp:ListItem Value="40">40</asp:ListItem>
											<asp:ListItem Value="41">41</asp:ListItem>
											<asp:ListItem Value="42">42</asp:ListItem>
											<asp:ListItem Value="43">43</asp:ListItem>
											<asp:ListItem Value="44">44</asp:ListItem>
											<asp:ListItem Value="45">45</asp:ListItem>
											<asp:ListItem Value="46">46</asp:ListItem>
											<asp:ListItem Value="47">47</asp:ListItem>
											<asp:ListItem Value="48">48</asp:ListItem>
											<asp:ListItem Value="49">49</asp:ListItem>
											<asp:ListItem Value="50">50</asp:ListItem>
											<asp:ListItem Value="51">51</asp:ListItem>
											<asp:ListItem Value="52">52</asp:ListItem>
											<asp:ListItem Value="53">53</asp:ListItem>
											<asp:ListItem Value="54">54</asp:ListItem>
											<asp:ListItem Value="55">55</asp:ListItem>
											<asp:ListItem Value="56">56</asp:ListItem>
											<asp:ListItem Value="57">57</asp:ListItem>
											<asp:ListItem Value="58">58</asp:ListItem>
											<asp:ListItem Value="59">59</asp:ListItem>
										</CC1:S_COMBOBOX></TD>
									<TD><B>Note del Sopralluogo:</B></TD>
									<TD>
										<CC1:S_TEXTBOX id="txtSeguito4" runat="server" width="264px" maxlength="61"></CC1:S_TEXTBOX></TD>
								</TR>
								<tr>
									<TD style="HEIGHT: 16px" colSpan="2"><STRONG>Data Prevista Inizio Lavori:</STRONG></TD>
									<TD style="HEIGHT: 16px" colSpan="2"><STRONG>Data Prevista Fine Lavori:</STRONG></TD>
								</tr>
								<TR>
									<TD><uc1:calendarpicker id="CalendarPicker6" runat="server"></uc1:calendarpicker></TD>
									<TD>Ora<CC1:S_COMBOBOX style="Z-INDEX: 0" id="cmbOra1" runat="server" dbdatatype="Integer">
											<asp:ListItem Value="00">00</asp:ListItem>
											<asp:ListItem Value="01">01</asp:ListItem>
											<asp:ListItem Value="02">02</asp:ListItem>
											<asp:ListItem Value="03">03</asp:ListItem>
											<asp:ListItem Value="04">04</asp:ListItem>
											<asp:ListItem Value="05">05</asp:ListItem>
											<asp:ListItem Value="06">06</asp:ListItem>
											<asp:ListItem Value="07">07</asp:ListItem>
											<asp:ListItem Value="08">08</asp:ListItem>
											<asp:ListItem Value="09">09</asp:ListItem>
											<asp:ListItem Value="10">10</asp:ListItem>
											<asp:ListItem Value="11">11</asp:ListItem>
											<asp:ListItem Value="12">12</asp:ListItem>
											<asp:ListItem Value="13">13</asp:ListItem>
											<asp:ListItem Value="14">14</asp:ListItem>
											<asp:ListItem Value="15">15</asp:ListItem>
											<asp:ListItem Value="16">16</asp:ListItem>
											<asp:ListItem Value="17">17</asp:ListItem>
											<asp:ListItem Value="18">18</asp:ListItem>
											<asp:ListItem Value="19">19</asp:ListItem>
											<asp:ListItem Value="20">20</asp:ListItem>
											<asp:ListItem Value="21">21</asp:ListItem>
											<asp:ListItem Value="22">22</asp:ListItem>
											<asp:ListItem Value="23">23</asp:ListItem>
										</CC1:S_COMBOBOX>
										<CC1:S_COMBOBOX style="Z-INDEX: 0" id="cmbMin2" runat="server" dbdatatype="Integer">
											<asp:ListItem Value="00">00</asp:ListItem>
											<asp:ListItem Value="01">01</asp:ListItem>
											<asp:ListItem Value="02">02</asp:ListItem>
											<asp:ListItem Value="03">03</asp:ListItem>
											<asp:ListItem Value="04">04</asp:ListItem>
											<asp:ListItem Value="05">05</asp:ListItem>
											<asp:ListItem Value="06">06</asp:ListItem>
											<asp:ListItem Value="07">07</asp:ListItem>
											<asp:ListItem Value="08">08</asp:ListItem>
											<asp:ListItem Value="09">09</asp:ListItem>
											<asp:ListItem Value="10">10</asp:ListItem>
											<asp:ListItem Value="11">11</asp:ListItem>
											<asp:ListItem Value="12">12</asp:ListItem>
											<asp:ListItem Value="13">13</asp:ListItem>
											<asp:ListItem Value="14">14</asp:ListItem>
											<asp:ListItem Value="15">15</asp:ListItem>
											<asp:ListItem Value="16">16</asp:ListItem>
											<asp:ListItem Value="17">17</asp:ListItem>
											<asp:ListItem Value="18">18</asp:ListItem>
											<asp:ListItem Value="19">19</asp:ListItem>
											<asp:ListItem Value="20">20</asp:ListItem>
											<asp:ListItem Value="21">21</asp:ListItem>
											<asp:ListItem Value="22">22</asp:ListItem>
											<asp:ListItem Value="23">23</asp:ListItem>
											<asp:ListItem Value="24">24</asp:ListItem>
											<asp:ListItem Value="25">25</asp:ListItem>
											<asp:ListItem Value="26">26</asp:ListItem>
											<asp:ListItem Value="27">27</asp:ListItem>
											<asp:ListItem Value="28">28</asp:ListItem>
											<asp:ListItem Value="29">29</asp:ListItem>
											<asp:ListItem Value="30">30</asp:ListItem>
											<asp:ListItem Value="31">31</asp:ListItem>
											<asp:ListItem Value="32">32</asp:ListItem>
											<asp:ListItem Value="33">33</asp:ListItem>
											<asp:ListItem Value="34">34</asp:ListItem>
											<asp:ListItem Value="35">35</asp:ListItem>
											<asp:ListItem Value="36">36</asp:ListItem>
											<asp:ListItem Value="37">37</asp:ListItem>
											<asp:ListItem Value="38">38</asp:ListItem>
											<asp:ListItem Value="39">39</asp:ListItem>
											<asp:ListItem Value="40">40</asp:ListItem>
											<asp:ListItem Value="41">41</asp:ListItem>
											<asp:ListItem Value="42">42</asp:ListItem>
											<asp:ListItem Value="43">43</asp:ListItem>
											<asp:ListItem Value="44">44</asp:ListItem>
											<asp:ListItem Value="45">45</asp:ListItem>
											<asp:ListItem Value="46">46</asp:ListItem>
											<asp:ListItem Value="47">47</asp:ListItem>
											<asp:ListItem Value="48">48</asp:ListItem>
											<asp:ListItem Value="49">49</asp:ListItem>
											<asp:ListItem Value="50">50</asp:ListItem>
											<asp:ListItem Value="51">51</asp:ListItem>
											<asp:ListItem Value="52">52</asp:ListItem>
											<asp:ListItem Value="53">53</asp:ListItem>
											<asp:ListItem Value="54">54</asp:ListItem>
											<asp:ListItem Value="55">55</asp:ListItem>
											<asp:ListItem Value="56">56</asp:ListItem>
											<asp:ListItem Value="57">57</asp:ListItem>
											<asp:ListItem Value="58">58</asp:ListItem>
											<asp:ListItem Value="59">59</asp:ListItem>
										</CC1:S_COMBOBOX></TD>
									<TD><uc1:calendarpicker style="Z-INDEX: 0" id="CalendarPicker2" runat="server"></uc1:calendarpicker></TD>
									<TD>Ora<CC1:S_COMBOBOX style="Z-INDEX: 0" id="cmborafinelav" runat="server" dbdatatype="Integer">
											<asp:ListItem Value="00">00</asp:ListItem>
											<asp:ListItem Value="01">01</asp:ListItem>
											<asp:ListItem Value="02">02</asp:ListItem>
											<asp:ListItem Value="03">03</asp:ListItem>
											<asp:ListItem Value="04">04</asp:ListItem>
											<asp:ListItem Value="05">05</asp:ListItem>
											<asp:ListItem Value="06">06</asp:ListItem>
											<asp:ListItem Value="07">07</asp:ListItem>
											<asp:ListItem Value="08">08</asp:ListItem>
											<asp:ListItem Value="09">09</asp:ListItem>
											<asp:ListItem Value="10">10</asp:ListItem>
											<asp:ListItem Value="11">11</asp:ListItem>
											<asp:ListItem Value="12">12</asp:ListItem>
											<asp:ListItem Value="13">13</asp:ListItem>
											<asp:ListItem Value="14">14</asp:ListItem>
											<asp:ListItem Value="15">15</asp:ListItem>
											<asp:ListItem Value="16">16</asp:ListItem>
											<asp:ListItem Value="17">17</asp:ListItem>
											<asp:ListItem Value="18">18</asp:ListItem>
											<asp:ListItem Value="19">19</asp:ListItem>
											<asp:ListItem Value="20">20</asp:ListItem>
											<asp:ListItem Value="21">21</asp:ListItem>
											<asp:ListItem Value="22">22</asp:ListItem>
											<asp:ListItem Value="23">23</asp:ListItem>
										</CC1:S_COMBOBOX>
										<CC1:S_COMBOBOX style="Z-INDEX: 0" id="cmbminfinelav" runat="server" dbdatatype="Integer">
											<asp:ListItem Value="00">00</asp:ListItem>
											<asp:ListItem Value="01">01</asp:ListItem>
											<asp:ListItem Value="02">02</asp:ListItem>
											<asp:ListItem Value="03">03</asp:ListItem>
											<asp:ListItem Value="04">04</asp:ListItem>
											<asp:ListItem Value="05">05</asp:ListItem>
											<asp:ListItem Value="06">06</asp:ListItem>
											<asp:ListItem Value="07">07</asp:ListItem>
											<asp:ListItem Value="08">08</asp:ListItem>
											<asp:ListItem Value="09">09</asp:ListItem>
											<asp:ListItem Value="10">10</asp:ListItem>
											<asp:ListItem Value="11">11</asp:ListItem>
											<asp:ListItem Value="12">12</asp:ListItem>
											<asp:ListItem Value="13">13</asp:ListItem>
											<asp:ListItem Value="14">14</asp:ListItem>
											<asp:ListItem Value="15">15</asp:ListItem>
											<asp:ListItem Value="16">16</asp:ListItem>
											<asp:ListItem Value="17">17</asp:ListItem>
											<asp:ListItem Value="18">18</asp:ListItem>
											<asp:ListItem Value="19">19</asp:ListItem>
											<asp:ListItem Value="20">20</asp:ListItem>
											<asp:ListItem Value="21">21</asp:ListItem>
											<asp:ListItem Value="22">22</asp:ListItem>
											<asp:ListItem Value="23">23</asp:ListItem>
											<asp:ListItem Value="24">24</asp:ListItem>
											<asp:ListItem Value="25">25</asp:ListItem>
											<asp:ListItem Value="26">26</asp:ListItem>
											<asp:ListItem Value="27">27</asp:ListItem>
											<asp:ListItem Value="28">28</asp:ListItem>
											<asp:ListItem Value="29">29</asp:ListItem>
											<asp:ListItem Value="30">30</asp:ListItem>
											<asp:ListItem Value="31">31</asp:ListItem>
											<asp:ListItem Value="32">32</asp:ListItem>
											<asp:ListItem Value="33">33</asp:ListItem>
											<asp:ListItem Value="34">34</asp:ListItem>
											<asp:ListItem Value="35">35</asp:ListItem>
											<asp:ListItem Value="36">36</asp:ListItem>
											<asp:ListItem Value="37">37</asp:ListItem>
											<asp:ListItem Value="38">38</asp:ListItem>
											<asp:ListItem Value="39">39</asp:ListItem>
											<asp:ListItem Value="40">40</asp:ListItem>
											<asp:ListItem Value="41">41</asp:ListItem>
											<asp:ListItem Value="42">42</asp:ListItem>
											<asp:ListItem Value="43">43</asp:ListItem>
											<asp:ListItem Value="44">44</asp:ListItem>
											<asp:ListItem Value="45">45</asp:ListItem>
											<asp:ListItem Value="46">46</asp:ListItem>
											<asp:ListItem Value="47">47</asp:ListItem>
											<asp:ListItem Value="48">48</asp:ListItem>
											<asp:ListItem Value="49">49</asp:ListItem>
											<asp:ListItem Value="50">50</asp:ListItem>
											<asp:ListItem Value="51">51</asp:ListItem>
											<asp:ListItem Value="52">52</asp:ListItem>
											<asp:ListItem Value="53">53</asp:ListItem>
											<asp:ListItem Value="54">54</asp:ListItem>
											<asp:ListItem Value="55">55</asp:ListItem>
											<asp:ListItem Value="56">56</asp:ListItem>
											<asp:ListItem Value="57">57</asp:ListItem>
											<asp:ListItem Value="58">58</asp:ListItem>
											<asp:ListItem Value="59">59</asp:ListItem>
										</CC1:S_COMBOBOX></TD>
								</TR>
								<TR>
									<TD colSpan="4"></TD>
								</TR>
								<TR>
									<TD colSpan="4"><ASP:LABEL id="LblMessaggio" runat="server" width="560px"></ASP:LABEL></TD>
								</TR>
								<TR>
									<TD colSpan="4" align="center">
										<asp:button style="Z-INDEX: 0" id="Button2" runat="server" Text="Chiudi" Width="135px"></asp:button><asp:button id="btRifiuta" runat="server" Text="Rifiuta" Width="135px"></asp:button>&nbsp;
										<asp:button id="btSospendi" runat="server" Text="Sospendi" Width="135px"></asp:button>&nbsp;
										<asp:button id="btApprova" runat="server" Text="Approva/Emetti" Width="135px"></asp:button>&nbsp;
									</TD>
								</TR>
							</TABLE></TD>
				</TR>
			</TABLE>
			</cc2:datapanel></TD></TR>
			<TR>
				<TD><cc2:datapanel id="Datapanel5" runat="server" cssclass="DataPanel75" allowtitleexpandcollapse="True"
						collapseimageurl="../Images/up.gif" collapsetext="Riduci" expandimageurl="../Images/down.gif"
						expandtext="Espandi" titletext="Consuntivo Economico" collapsed="false" titlestyle-cssclass="TitleSearch">
						<TABLE border="0" cellSpacing="1" cellPadding="1" width="100%">
							<TR>
								<TD style="WIDTH: 144px" colSpan="6">
									<TABLE style="WIDTH: 616px; HEIGHT: 33px" id="Table12" border="0" cellSpacing="0" cellPadding="0"
										width="616">
										<TR>
											<TD><STRONG>Consuntivo Nr:</STRONG></TD>
											<TD colSpan="3">
												<CC1:S_TEXTBOX id="txtnrconsuntivo" runat="server" Height="22px" MaxLength="250" Width="283px"
													TextMode="MultiLine"></CC1:S_TEXTBOX></TD>
										</TR>
									</TABLE>
								</TD>
							</TR>
							<TR>
								<TD style="WIDTH: 144px" colSpan="6"></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 144px" colSpan="6">
									<TABLE style="WIDTH: 800px; HEIGHT: 40px" id="Table10" border="0" cellSpacing="0" cellPadding="0"
										width="800">
										<TR>
											<TD style="WIDTH: 150px"><STRONG>Importo a Consuntivo:</STRONG></TD>
											<TD style="WIDTH: 91px">&nbsp;
												<CC1:S_TEXTBOX style="TEXT-ALIGN: right" id="ImpCons1" runat="server" width="48px" maxlength="8">0</CC1:S_TEXTBOX>,
												<CC1:S_TEXTBOX id="ImpCons2" runat="server" width="27px" maxlength="2">00</CC1:S_TEXTBOX></TD>
											<TD style="WIDTH: 139px"><STRONG>File Consuntivo PDF:</STRONG></TD>
											<TD>&nbsp;<INPUT style="WIDTH: 280px; HEIGHT: 18px" id="FileConsuntivo" size="27" type="file" name="File1"
													runat="server">
												<asp:button style="Z-INDEX: 0" id="BtInviaCons" runat="server" Text="Invia il File..." Width="88px"></asp:button></TD>
										</TR>
									</TABLE>
								</TD>
							</TR>
							<TR>
								<TD style="WIDTH: 144px"><STRONG></STRONG></TD>
								<TD colSpan="5">&nbsp;
									<asp:hyperlink id="LkCons" runat="server"></asp:hyperlink>&nbsp;
									<asp:imagebutton id="btImgDeleteCons" runat="server" ImageUrl="../Images/elimina.gif"></asp:imagebutton></TD>
							</TR>
							<TR>
								<TD>
									<TABLE id="Table11" border="0" cellSpacing="0" cellPadding="0" width="300">
										<TR>
											<TD colSpan="2"><B>Centro di Costo:</B></TD>
											<TD></TD>
											<TD>
												<asp:DropDownList style="Z-INDEX: 0" id="cmbCdC" runat="server" Width="250px"></asp:DropDownList></TD>
										</TR>
									</TABLE>
								</TD>
							</TR>
						</TABLE>
					</cc2:datapanel></TD>
			</TR>
			<TR>
				<TD><cc2:datapanel id="Datapanel4" runat="server" cssclass="DataPanel75" allowtitleexpandcollapse="True"
						collapseimageurl="../Images/up.gif" collapsetext="Riduci" expandimageurl="../Images/down.gif"
						expandtext="Espandi" titletext="Completamento Ordine" collapsed="False" titlestyle-cssclass="TitleSearch">
      <TABLE border="0" cellSpacing="1" cellPadding="1" width="100%">
							<TBODY>
								<TR>
									<TD><STRONG>Stato Richiesta:</STRONG></TD>
									<TD colSpan="3"><CC1:S_COMBOBOX id="cmbsstatolavoro" runat="server" width="255px"></CC1:S_COMBOBOX></TD>
								</TR>
								<TR id="trsosp">
									<TD><STRONG>Sospesa per:</STRONG></TD>
									<TD colSpan="3"><CC1:S_TEXTBOX id="txtsAnnotazioni" runat="server" width="480px" textmode="MultiLine" height="34px"
											MaxLength="2000"></CC1:S_TEXTBOX></TD>
								</TR>
								<TR>
									<TD><STRONG>Buono Lavoro Esterno:</STRONG></TD>
									<TD colSpan="3"><asp:textbox id="txtBuonoLavoroEster" runat="server" MaxLength="32"></asp:textbox></TD>
								</TR>
								<TR>
									<TD colSpan="4">
										<TABLE style="HEIGHT: 68px" id="Table13" border="0" cellSpacing="0" cellPadding="0" width="900">
											<TR>
												<TD><B>Data Inizio Lavori:</B></TD>
												<TD><B>Data Provvisoria Fine Lavori:</B></TD>
												<TD><B>Data Fine Lavori:</B></TD>
											</TR>
											<TR>
												<TD>
													<TABLE id="Table5" border="0" cellSpacing="1" cellPadding="1" width="100%">
														<TR>
															<TD><uc1:calendarpicker id="CalendarPicker7" runat="server"></uc1:calendarpicker></TD>
															<TD><STRONG><SPAN class="die"><SPAN class="blueoverline">Ora</SPAN></SPAN>
																	<CC1:S_COMBOBOX id="OraIni" runat="server" dbdatatype="Integer">
																		<asp:ListItem Value="00">00</asp:ListItem>
																		<asp:ListItem Value="01">01</asp:ListItem>
																		<asp:ListItem Value="02">02</asp:ListItem>
																		<asp:ListItem Value="03">03</asp:ListItem>
																		<asp:ListItem Value="04">04</asp:ListItem>
																		<asp:ListItem Value="05">05</asp:ListItem>
																		<asp:ListItem Value="06">06</asp:ListItem>
																		<asp:ListItem Value="07">07</asp:ListItem>
																		<asp:ListItem Value="08">08</asp:ListItem>
																		<asp:ListItem Value="09">09</asp:ListItem>
																		<asp:ListItem Value="10">10</asp:ListItem>
																		<asp:ListItem Value="11">11</asp:ListItem>
																		<asp:ListItem Value="12">12</asp:ListItem>
																		<asp:ListItem Value="13">13</asp:ListItem>
																		<asp:ListItem Value="14">14</asp:ListItem>
																		<asp:ListItem Value="15">15</asp:ListItem>
																		<asp:ListItem Value="16">16</asp:ListItem>
																		<asp:ListItem Value="17">17</asp:ListItem>
																		<asp:ListItem Value="18">18</asp:ListItem>
																		<asp:ListItem Value="19">19</asp:ListItem>
																		<asp:ListItem Value="20">20</asp:ListItem>
																		<asp:ListItem Value="21">21</asp:ListItem>
																		<asp:ListItem Value="22">22</asp:ListItem>
																		<asp:ListItem Value="23">23</asp:ListItem>
																	</CC1:S_COMBOBOX></STRONG>:
																<CC1:S_COMBOBOX id="MinitiIni" runat="server" width="40px" dbdatatype="Integer">
																	<asp:ListItem Value="00">00</asp:ListItem>
																	<asp:ListItem Value="01">01</asp:ListItem>
																	<asp:ListItem Value="02">02</asp:ListItem>
																	<asp:ListItem Value="03">03</asp:ListItem>
																	<asp:ListItem Value="04">04</asp:ListItem>
																	<asp:ListItem Value="05">05</asp:ListItem>
																	<asp:ListItem Value="06">06</asp:ListItem>
																	<asp:ListItem Value="07">07</asp:ListItem>
																	<asp:ListItem Value="08">08</asp:ListItem>
																	<asp:ListItem Value="09">09</asp:ListItem>
																	<asp:ListItem Value="10">10</asp:ListItem>
																	<asp:ListItem Value="11">11</asp:ListItem>
																	<asp:ListItem Value="12">12</asp:ListItem>
																	<asp:ListItem Value="13">13</asp:ListItem>
																	<asp:ListItem Value="14">14</asp:ListItem>
																	<asp:ListItem Value="15">15</asp:ListItem>
																	<asp:ListItem Value="16">16</asp:ListItem>
																	<asp:ListItem Value="17">17</asp:ListItem>
																	<asp:ListItem Value="18">18</asp:ListItem>
																	<asp:ListItem Value="19">19</asp:ListItem>
																	<asp:ListItem Value="20">20</asp:ListItem>
																	<asp:ListItem Value="21">21</asp:ListItem>
																	<asp:ListItem Value="22">22</asp:ListItem>
																	<asp:ListItem Value="23">23</asp:ListItem>
																	<asp:ListItem Value="24">24</asp:ListItem>
																	<asp:ListItem Value="25">25</asp:ListItem>
																	<asp:ListItem Value="26">26</asp:ListItem>
																	<asp:ListItem Value="27">27</asp:ListItem>
																	<asp:ListItem Value="28">28</asp:ListItem>
																	<asp:ListItem Value="29">29</asp:ListItem>
																	<asp:ListItem Value="30">30</asp:ListItem>
																	<asp:ListItem Value="31">31</asp:ListItem>
																	<asp:ListItem Value="32">32</asp:ListItem>
																	<asp:ListItem Value="33">33</asp:ListItem>
																	<asp:ListItem Value="34">34</asp:ListItem>
																	<asp:ListItem Value="35">35</asp:ListItem>
																	<asp:ListItem Value="36">36</asp:ListItem>
																	<asp:ListItem Value="37">37</asp:ListItem>
																	<asp:ListItem Value="38">38</asp:ListItem>
																	<asp:ListItem Value="39">39</asp:ListItem>
																	<asp:ListItem Value="40">40</asp:ListItem>
																	<asp:ListItem Value="41">41</asp:ListItem>
																	<asp:ListItem Value="42">42</asp:ListItem>
																	<asp:ListItem Value="43">43</asp:ListItem>
																	<asp:ListItem Value="44">44</asp:ListItem>
																	<asp:ListItem Value="45">45</asp:ListItem>
																	<asp:ListItem Value="46">46</asp:ListItem>
																	<asp:ListItem Value="47">47</asp:ListItem>
																	<asp:ListItem Value="48">48</asp:ListItem>
																	<asp:ListItem Value="49">49</asp:ListItem>
																	<asp:ListItem Value="50">50</asp:ListItem>
																	<asp:ListItem Value="51">51</asp:ListItem>
																	<asp:ListItem Value="52">52</asp:ListItem>
																	<asp:ListItem Value="53">53</asp:ListItem>
																	<asp:ListItem Value="54">54</asp:ListItem>
																	<asp:ListItem Value="55">55</asp:ListItem>
																	<asp:ListItem Value="56">56</asp:ListItem>
																	<asp:ListItem Value="57">57</asp:ListItem>
																	<asp:ListItem Value="58">58</asp:ListItem>
																	<asp:ListItem Value="59">59</asp:ListItem>
																</CC1:S_COMBOBOX></TD>
														</TR>
													</TABLE>
												</TD>
												<TD>
													<TABLE id="Table14" border="0" cellSpacing="1" cellPadding="1" width="100%">
														<TR>
															<TD style="WIDTH: 163px"><uc1:calendarpicker id="CalendarPicker10" runat="server"></uc1:calendarpicker></TD>
															<TD><STRONG><SPAN class="die"><SPAN class="blueoverline">Ora</SPAN></SPAN>
																	<CC1:S_COMBOBOX id="S_COMBOBOX2" runat="server" dbdatatype="Integer">
																		<asp:ListItem Value="00">00</asp:ListItem>
																		<asp:ListItem Value="01">01</asp:ListItem>
																		<asp:ListItem Value="02">02</asp:ListItem>
																		<asp:ListItem Value="03">03</asp:ListItem>
																		<asp:ListItem Value="04">04</asp:ListItem>
																		<asp:ListItem Value="05">05</asp:ListItem>
																		<asp:ListItem Value="06">06</asp:ListItem>
																		<asp:ListItem Value="07">07</asp:ListItem>
																		<asp:ListItem Value="08">08</asp:ListItem>
																		<asp:ListItem Value="09">09</asp:ListItem>
																		<asp:ListItem Value="10">10</asp:ListItem>
																		<asp:ListItem Value="11">11</asp:ListItem>
																		<asp:ListItem Value="12">12</asp:ListItem>
																		<asp:ListItem Value="13">13</asp:ListItem>
																		<asp:ListItem Value="14">14</asp:ListItem>
																		<asp:ListItem Value="15">15</asp:ListItem>
																		<asp:ListItem Value="16">16</asp:ListItem>
																		<asp:ListItem Value="17">17</asp:ListItem>
																		<asp:ListItem Value="18">18</asp:ListItem>
																		<asp:ListItem Value="19">19</asp:ListItem>
																		<asp:ListItem Value="20">20</asp:ListItem>
																		<asp:ListItem Value="21">21</asp:ListItem>
																		<asp:ListItem Value="22">22</asp:ListItem>
																		<asp:ListItem Value="23">23</asp:ListItem>
																	</CC1:S_COMBOBOX></STRONG>:
																<CC1:S_COMBOBOX id="S_COMBOBOX1" runat="server" width="40px" dbdatatype="Integer">
																	<asp:ListItem Value="00">00</asp:ListItem>
																	<asp:ListItem Value="01">01</asp:ListItem>
																	<asp:ListItem Value="02">02</asp:ListItem>
																	<asp:ListItem Value="03">03</asp:ListItem>
																	<asp:ListItem Value="04">04</asp:ListItem>
																	<asp:ListItem Value="05">05</asp:ListItem>
																	<asp:ListItem Value="06">06</asp:ListItem>
																	<asp:ListItem Value="07">07</asp:ListItem>
																	<asp:ListItem Value="08">08</asp:ListItem>
																	<asp:ListItem Value="09">09</asp:ListItem>
																	<asp:ListItem Value="10">10</asp:ListItem>
																	<asp:ListItem Value="11">11</asp:ListItem>
																	<asp:ListItem Value="12">12</asp:ListItem>
																	<asp:ListItem Value="13">13</asp:ListItem>
																	<asp:ListItem Value="14">14</asp:ListItem>
																	<asp:ListItem Value="15">15</asp:ListItem>
																	<asp:ListItem Value="16">16</asp:ListItem>
																	<asp:ListItem Value="17">17</asp:ListItem>
																	<asp:ListItem Value="18">18</asp:ListItem>
																	<asp:ListItem Value="19">19</asp:ListItem>
																	<asp:ListItem Value="20">20</asp:ListItem>
																	<asp:ListItem Value="21">21</asp:ListItem>
																	<asp:ListItem Value="22">22</asp:ListItem>
																	<asp:ListItem Value="23">23</asp:ListItem>
																	<asp:ListItem Value="24">24</asp:ListItem>
																	<asp:ListItem Value="25">25</asp:ListItem>
																	<asp:ListItem Value="26">26</asp:ListItem>
																	<asp:ListItem Value="27">27</asp:ListItem>
																	<asp:ListItem Value="28">28</asp:ListItem>
																	<asp:ListItem Value="29">29</asp:ListItem>
																	<asp:ListItem Value="30">30</asp:ListItem>
																	<asp:ListItem Value="31">31</asp:ListItem>
																	<asp:ListItem Value="32">32</asp:ListItem>
																	<asp:ListItem Value="33">33</asp:ListItem>
																	<asp:ListItem Value="34">34</asp:ListItem>
																	<asp:ListItem Value="35">35</asp:ListItem>
																	<asp:ListItem Value="36">36</asp:ListItem>
																	<asp:ListItem Value="37">37</asp:ListItem>
																	<asp:ListItem Value="38">38</asp:ListItem>
																	<asp:ListItem Value="39">39</asp:ListItem>
																	<asp:ListItem Value="40">40</asp:ListItem>
																	<asp:ListItem Value="41">41</asp:ListItem>
																	<asp:ListItem Value="42">42</asp:ListItem>
																	<asp:ListItem Value="43">43</asp:ListItem>
																	<asp:ListItem Value="44">44</asp:ListItem>
																	<asp:ListItem Value="45">45</asp:ListItem>
																	<asp:ListItem Value="46">46</asp:ListItem>
																	<asp:ListItem Value="47">47</asp:ListItem>
																	<asp:ListItem Value="48">48</asp:ListItem>
																	<asp:ListItem Value="49">49</asp:ListItem>
																	<asp:ListItem Value="50">50</asp:ListItem>
																	<asp:ListItem Value="51">51</asp:ListItem>
																	<asp:ListItem Value="52">52</asp:ListItem>
																	<asp:ListItem Value="53">53</asp:ListItem>
																	<asp:ListItem Value="54">54</asp:ListItem>
																	<asp:ListItem Value="55">55</asp:ListItem>
																	<asp:ListItem Value="56">56</asp:ListItem>
																	<asp:ListItem Value="57">57</asp:ListItem>
																	<asp:ListItem Value="58">58</asp:ListItem>
																	<asp:ListItem Value="59">59</asp:ListItem>
																</CC1:S_COMBOBOX></TD>
														</TR>
													</TABLE>
												</TD>
												<TD>
													<TABLE id="Table6" border="0" cellSpacing="1" cellPadding="1" width="100%">
														<TR>
															<TD style="WIDTH: 137px"><uc1:calendarpicker id="CalendarPicker8" runat="server"></uc1:calendarpicker></TD>
															<TD><STRONG><SPAN class="die"><SPAN class="blueoverline">Ora</SPAN></SPAN>
																	<CC1:S_COMBOBOX id="OraFine" runat="server" dbdatatype="Integer">
																		<asp:ListItem Value="00">00</asp:ListItem>
																		<asp:ListItem Value="01">01</asp:ListItem>
																		<asp:ListItem Value="02">02</asp:ListItem>
																		<asp:ListItem Value="03">03</asp:ListItem>
																		<asp:ListItem Value="04">04</asp:ListItem>
																		<asp:ListItem Value="05">05</asp:ListItem>
																		<asp:ListItem Value="06">06</asp:ListItem>
																		<asp:ListItem Value="07">07</asp:ListItem>
																		<asp:ListItem Value="08">08</asp:ListItem>
																		<asp:ListItem Value="09">09</asp:ListItem>
																		<asp:ListItem Value="10">10</asp:ListItem>
																		<asp:ListItem Value="11">11</asp:ListItem>
																		<asp:ListItem Value="12">12</asp:ListItem>
																		<asp:ListItem Value="13">13</asp:ListItem>
																		<asp:ListItem Value="14">14</asp:ListItem>
																		<asp:ListItem Value="15">15</asp:ListItem>
																		<asp:ListItem Value="16">16</asp:ListItem>
																		<asp:ListItem Value="17">17</asp:ListItem>
																		<asp:ListItem Value="18">18</asp:ListItem>
																		<asp:ListItem Value="19">19</asp:ListItem>
																		<asp:ListItem Value="20">20</asp:ListItem>
																		<asp:ListItem Value="21">21</asp:ListItem>
																		<asp:ListItem Value="22">22</asp:ListItem>
																		<asp:ListItem Value="23">23</asp:ListItem>
																	</CC1:S_COMBOBOX></STRONG>:
																<CC1:S_COMBOBOX id="MinutiFine" runat="server" width="40px" dbdatatype="Integer">
																	<asp:ListItem Value="00">00</asp:ListItem>
																	<asp:ListItem Value="01">01</asp:ListItem>
																	<asp:ListItem Value="02">02</asp:ListItem>
																	<asp:ListItem Value="03">03</asp:ListItem>
																	<asp:ListItem Value="04">04</asp:ListItem>
																	<asp:ListItem Value="05">05</asp:ListItem>
																	<asp:ListItem Value="06">06</asp:ListItem>
																	<asp:ListItem Value="07">07</asp:ListItem>
																	<asp:ListItem Value="08">08</asp:ListItem>
																	<asp:ListItem Value="09">09</asp:ListItem>
																	<asp:ListItem Value="10">10</asp:ListItem>
																	<asp:ListItem Value="11">11</asp:ListItem>
																	<asp:ListItem Value="12">12</asp:ListItem>
																	<asp:ListItem Value="13">13</asp:ListItem>
																	<asp:ListItem Value="14">14</asp:ListItem>
																	<asp:ListItem Value="15">15</asp:ListItem>
																	<asp:ListItem Value="16">16</asp:ListItem>
																	<asp:ListItem Value="17">17</asp:ListItem>
																	<asp:ListItem Value="18">18</asp:ListItem>
																	<asp:ListItem Value="19">19</asp:ListItem>
																	<asp:ListItem Value="20">20</asp:ListItem>
																	<asp:ListItem Value="21">21</asp:ListItem>
																	<asp:ListItem Value="22">22</asp:ListItem>
																	<asp:ListItem Value="23">23</asp:ListItem>
																	<asp:ListItem Value="24">24</asp:ListItem>
																	<asp:ListItem Value="25">25</asp:ListItem>
																	<asp:ListItem Value="26">26</asp:ListItem>
																	<asp:ListItem Value="27">27</asp:ListItem>
																	<asp:ListItem Value="28">28</asp:ListItem>
																	<asp:ListItem Value="29">29</asp:ListItem>
																	<asp:ListItem Value="30">30</asp:ListItem>
																	<asp:ListItem Value="31">31</asp:ListItem>
																	<asp:ListItem Value="32">32</asp:ListItem>
																	<asp:ListItem Value="33">33</asp:ListItem>
																	<asp:ListItem Value="34">34</asp:ListItem>
																	<asp:ListItem Value="35">35</asp:ListItem>
																	<asp:ListItem Value="36">36</asp:ListItem>
																	<asp:ListItem Value="37">37</asp:ListItem>
																	<asp:ListItem Value="38">38</asp:ListItem>
																	<asp:ListItem Value="39">39</asp:ListItem>
																	<asp:ListItem Value="40">40</asp:ListItem>
																	<asp:ListItem Value="41">41</asp:ListItem>
																	<asp:ListItem Value="42">42</asp:ListItem>
																	<asp:ListItem Value="43">43</asp:ListItem>
																	<asp:ListItem Value="44">44</asp:ListItem>
																	<asp:ListItem Value="45">45</asp:ListItem>
																	<asp:ListItem Value="46">46</asp:ListItem>
																	<asp:ListItem Value="47">47</asp:ListItem>
																	<asp:ListItem Value="48">48</asp:ListItem>
																	<asp:ListItem Value="49">49</asp:ListItem>
																	<asp:ListItem Value="50">50</asp:ListItem>
																	<asp:ListItem Value="51">51</asp:ListItem>
																	<asp:ListItem Value="52">52</asp:ListItem>
																	<asp:ListItem Value="53">53</asp:ListItem>
																	<asp:ListItem Value="54">54</asp:ListItem>
																	<asp:ListItem Value="55">55</asp:ListItem>
																	<asp:ListItem Value="56">56</asp:ListItem>
																	<asp:ListItem Value="57">57</asp:ListItem>
																	<asp:ListItem Value="58">58</asp:ListItem>
																	<asp:ListItem Value="59">59</asp:ListItem>
																</CC1:S_COMBOBOX></TD>
														</TR>
													</TABLE>
												</TD>
											</TR>
											<tr>
												<TD><B>Note Aggiuntive:</B>
													<asp:textbox id="txtNoteAggiuntive" runat="server" Visible="True" Width="168px"></asp:textbox></TD>
												<TD>
													<asp:button id="btn_S_Hlav" runat="server" Text="Salva Date Completamento" Width="208px"></asp:button>
												</TD>
											</tr>
										</TABLE>
										<P align="center"><asp:repeater id="Repeater1" Runat="server">
												<HeaderTemplate>
													<table border="1">
														<tr>
															<td><B>Data Inizio Lavori</B></td>
															<td><B>Data Provvisoria Fine Lavori</B></td>
															<td><B>Data Fine Lavori</B></td>
															<td><B>h lavorate</B></td>
															<td><B>note aggiuntive</B></td>
															<td><B>Elimina</B></td>
														</tr>
												</HeaderTemplate>
												<ItemTemplate>
													<tr>
														<td><%# DataBinder.Eval(Container.DataItem, "Date_start") %></td>
														<td><%# DataBinder.Eval(Container.DataItem, "date_est_completion") %></td>
														<td><%# DataBinder.Eval(Container.DataItem, "Date_end") %></td>
														<td><%# DataBinder.Eval(Container.DataItem, "hlav") %></td>
														<td><%# DataBinder.Eval(Container.DataItem, "note_aggiuntive") %></td>
														<td><asp:ImageButton ID="delete1"  ImageUrl="../Images/elimina.gif" Runat="server" CommandName="Delete"  CommandArgument='<%# DataBinder.Eval(Container.DataItem, "id_wr_h_lav")  %>'></asp:ImageButton></td>
													</tr>
												</ItemTemplate>
												<FooterTemplate>
						</TABLE>
											</FooterTemplate> </asp:repeater></P>
											<P>&nbsp;</P></TD>
			</TR>
			<tr>
				<TD>
					<ASP:LABEL id="lblhlav" runat="server" Font-Bold="True"></ASP:LABEL>
				</TD>
				<td colspan="3"></td>
			</tr>
			<TR>
				<TD>
					<P><STRONG>Stato Intervento:</STRONG></P>
				</TD>
				<TD colspan="3"><asp:dropdownlist id="cmbStatoIntervento" runat="server" width="255px">
						<asp:ListItem Value="1">Risolutivo</asp:ListItem>
						<asp:ListItem Value="2">Tampone</asp:ListItem>
					</asp:dropdownlist></TD>
			</TR>
			<TR>
				<TD><STRONG>Note Completamento:</STRONG></TD>
				<TD colSpan="3"><CC1:S_TEXTBOX id="txtNoteCompletamento" runat="server" width="480px" textmode="MultiLine" height="34px"
						MaxLength="215"></CC1:S_TEXTBOX></TD>
			</TR>
			<TR>
				<TD><STRONG></STRONG></TD>
				<TD colSpan="3"><CC1:S_TEXTBOX id="cmbDescrizioneIntervento" runat="server" width="480px" textmode="MultiLine"
						height="34px" MaxLength="256" Visible="False"></CC1:S_TEXTBOX></TD>
			</TR>
			<TR id="trsod">
				<TD><STRONG>Livello Soddisfazione:</STRONG></TD>
				<TD colSpan="3"><ASP:RADIOBUTTONLIST id="RdListLivello" runat="server" Width="500px" repeatdirection="Horizontal">
						<asp:ListItem Value="4" Selected="True">Non dichiarato</asp:ListItem>
						<asp:ListItem Value="1">Non Soddisfatto</asp:ListItem>
						<asp:ListItem Value="2">Soddisfatto</asp:ListItem>
						<asp:ListItem Value="3">Pienamente Soddisfatto</asp:ListItem>
					</ASP:RADIOBUTTONLIST></TD>
			</TR>
			</TBODY></TABLE></cc2:datapanel></TD></TR>
			<TR>
				<TD align="center">
					<div id="azioni" class="DataPanel75" runat="server">
						<TABLE border="0" width="100%">
							<TR>
								<TD class="TitleSearch" colSpan="4">Operazioni</TD>
							</TR>
							<TR>
								<TD><asp:button id="BtSalva" runat="server" Text="Salva" Width="135px"></asp:button></TD>
								<TD><asp:button id="BtDIE" runat="server" Text="Salva/Invia DIE" Width="135px"></asp:button></TD>
								<TD><asp:button id="btFoglio" runat="server" Visible="False" Text="Foglio Prestazioni" Width="135px"></asp:button></TD>
								<TD><asp:button id="btFoglioPdf" runat="server" Text="Foglio Prestazioni PDF" Width="135px"></asp:button></TD>
							</TR>
							<TR>
								<TD><asp:button id="btChiudi" runat="server" Text="Chiudi" Width="135px"></asp:button></TD>
								<TD><uc1:aggiungisollecito id="AggiungiSollecito1" runat="server"></uc1:aggiungisollecito></TD>
								<TD></TD>
								<TD>
									<asp:button Visible="false" style="Z-INDEX: 0" id="Button3" runat="server" Text="Report OdL" Width="135px"></asp:button></TD>
							</TR>
						</TABLE>
					</div>
				</TD>
			</TR>
			</TBODY></TABLE>&nbsp;
		</form>
	</body>
</HTML>
