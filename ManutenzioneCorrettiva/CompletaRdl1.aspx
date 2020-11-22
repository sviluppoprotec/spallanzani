<%@ Register TagPrefix="uc1" TagName="UserStanzeRic" Src="../WebControls/UserStanzeRic.ascx" %>
<%@ Register TagPrefix="uc1" TagName="RicercaModulo" Src="../WebControls/RicercaModulo.ascx" %>
<%@ Page language="c#" Codebehind="CompletaRdl1.aspx.cs" AutoEventWireup="false" Inherits="TheSite.ManutenzioneCorrettiva.CompletaRdl1" %>
<%@ Register TagPrefix="uc1" TagName="UserStanze" Src="../WebControls/UserStanze.ascx" %>
<%@ Register TagPrefix="uc1" TagName="AggiungiSollecito" Src="../WebControls/AggiungiSollecito.ascx" %>
<%@ Register TagPrefix="uc1" TagName="AggiungiChiariInfo" Src="../WebControls/AggiungiChiariInfo.ascx" %>
<%@ Register TagPrefix="uc1" TagName="AggiungiReclamo" Src="../WebControls/AggiungiReclamo.ascx" %>
<%@ Register TagPrefix="uc1" TagName="PageTitle" Src="../WebControls/PageTitle.ascx" %>
<%@ Register TagPrefix="cc2" Namespace="Csy.WebControls" Assembly="CsyWebControls" %>
<%@ Register TagPrefix="cc1" Namespace="S_Controls" Assembly="S_Controls" %>
<%@ Register TagPrefix="uc1" TagName="CalendarPicker" Src="../WebControls/CalendarPicker.ascx" %>
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
				<TBODY>
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
														<TD style="HEIGHT: 12px" width="20%"><B>RdL nr°:</B></TD>
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
														<TD style="DISPLAY: none"><B>Data Richiesta:</B></TD>
														<TD style="DISPLAY: none">
															<ASP:LABEL id="lblDataRichiesta" runat="server" width="128px"></ASP:LABEL></TD>
													</TR>
													<TR>
														<TD><B>Gruppo Richiedente:</B></TD>
														<TD style="WIDTH: 169px">
															<ASP:LABEL id="lblGruppo" runat="server" width="174px"></ASP:LABEL></TD>
														<TD style="DISPLAY: none"><B>Orario Richiesta:</B></TD>
														<TD style="DISPLAY: none">
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
														<TD><B>Telefono Richiedente:</B></TD>
														<TD colSpan="3">
															<ASP:LABEL id="lblTelefono" runat="server" width="174px"></ASP:LABEL></TD>
													<TR>
														<TD style="HEIGHT: 13px"><B>Note Richiedente:</B></TD>
														<TD style="HEIGHT: 13px" colSpan="3">
															<ASP:LABEL id="lblNote" runat="server" width="472px"></ASP:LABEL>
															<ASP:LABEL id="presidio" runat="server" width="0px" Height="0px"></ASP:LABEL></TD>
													</TR>
													<TR>
														<TD><B>Edificio:</B></TD>
														<TD colSpan="3">
															<ASP:LABEL id="lblfabbricato" runat="server" width="472px"></ASP:LABEL>
															<ASP:TEXTBOX id="txtHidBl" runat="server" width="0px"></ASP:TEXTBOX>
															<cc1:s_label id="S_Lblcodedificio1" runat="server"></cc1:s_label></TD>
													</TR>
													<TR>
													<TR style="DISPLAY: none">
														<TD colSpan="4">
															<uc1:RicercaModulo id="RicercaModulo1" runat="server"></uc1:RicercaModulo></TD>
													</TR>
													<TR>
														<TD><B>Piano:</B></TD>
														<TD colSpan="3">
															<CC1:S_COMBOBOX style="Z-INDEX: 0" id="S_PIANO" runat="server" width="480px" autopostback="True"></CC1:S_COMBOBOX></TD>
													</TR>
													<TR>
														<TD><B>Macroarea:</B></TD>
														<TD colSpan="3">
															<CC1:S_COMBOBOX style="Z-INDEX: 0" id="S_macroarea" runat="server" width="480px" autopostback="True"></CC1:S_COMBOBOX></TD>
													</TR>
													<TR>
														<TD><B>Stanza:</B></TD>
														<TD>
															<uc1:UserStanzeRic id="UserStanzeRic1" runat="server"></uc1:UserStanzeRic></TD>
													</TR>
													<TR>
														<TD style="HEIGHT: 24px"><B>Servizio:</B></TD>
														<TD style="HEIGHT: 24px" colSpan="3">
															<CC1:S_COMBOBOX id="cmbsServizio" runat="server" width="480px" autopostback="True"></CC1:S_COMBOBOX></TD>
													</TR>
													<TR>
														<TD style="HEIGHT: 19px"><B>Standard Apparecchiatura:</B></TD>
														<TD style="HEIGHT: 19px" colSpan="3">
															<CC1:S_COMBOBOX id="cmdsStdApparecchiatura" runat="server" width="480px" AutoPostBack="True" dbindex="1"
																dbdirection="Input" dbparametername="p_eqstd_id" dbsize="10" dbdatatype="Integer"></CC1:S_COMBOBOX></TD>
													</TR>
													<TR>
														<TD><B>Apparecchiatura:</B></TD>
														<TD colSpan="3">
															<CC1:S_COMBOBOX id="cmbEQ" runat="server" width="480px" dbindex="1" dbdirection="Input" dbparametername="p_id_eq"
																dbsize="10" dbdatatype="Integer"></CC1:S_COMBOBOX></TD>
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
																MaxLength="408"></CC1:S_TEXTBOX></TD>
													</TR>
													<TR>
														<TD><B>Data e Ora Richiesta:</B></TD>
														<TD colSpan="3">
															<uc1:CalendarPicker id="CalendarPicker1" runat="server"></uc1:CalendarPicker>&nbsp;
															<CC1:S_COMBOBOX style="Z-INDEX: 0" id="S_COMBOBOX4" runat="server" dbdatatype="Integer">
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
															<CC1:S_COMBOBOX style="Z-INDEX: 0" id="S_COMBOBOX3" runat="server" dbdatatype="Integer">
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
					<TR>
						<TD><cc2:datapanel id="Datapanel1" runat="server" cssclass="DataPanel75" allowtitleexpandcollapse="True"
								collapseimageurl="../Images/up.gif" collapsetext="Riduci" expandimageurl="../Images/down.gif"
								expandtext="Espandi" titletext="Solleciti" collapsed="False" titlestyle-cssclass="TitleSearch"><asp:repeater id="Repeater1" Runat="server">
									<HeaderTemplate>
										<table border="1" class="btbal">
											<tr>
												<td><b>Sollecito</b></td>
												<td><b>Richiedente</b></td>
												<td><b>Data Sollecito</b></td>
											</tr>
									</HeaderTemplate>
									<ItemTemplate>
										<tr>
											<td><%# DataBinder.Eval(Container.DataItem, "descrizione") %></td>
											<td><%# DataBinder.Eval(Container.DataItem, "richiedente") %></td>
											<td><%# DataBinder.Eval(Container.DataItem, "data_sollecito") %></td>
										</tr>
									</ItemTemplate>
									<FooterTemplate>
			</TABLE>
			</FooterTemplate> </asp:repeater></cc2:datapanel></TD></TR>
			<TR>
				<TD><cc2:datapanel id="Datapanel7" runat="server" cssclass="DataPanel75" allowtitleexpandcollapse="True"
						collapseimageurl="../Images/up.gif" collapsetext="Riduci" expandimageurl="../Images/down.gif"
						expandtext="Espandi" titletext="Reclami" collapsed="False" titlestyle-cssclass="TitleSearch">
						<asp:repeater id="Repeater2" Runat="server">
							<HeaderTemplate>
								<table border="1" class="btbal">
									<tr>
										<td><b>Reclamo</b></td>
										<td><b>Richiedente</b></td>
										<td><b>Data Reclamo</b></td>
									</tr>
							</HeaderTemplate>
							<ItemTemplate>
								<tr>
									<td><%# DataBinder.Eval(Container.DataItem, "descrizione") %></td>
									<td><%# DataBinder.Eval(Container.DataItem, "richiedente") %></td>
									<td><%# DataBinder.Eval(Container.DataItem, "data_reclamo") %></td>
								</tr>
							</ItemTemplate>
							<FooterTemplate>
								</TABLE>
							</FooterTemplate>
						</asp:repeater>
					</cc2:datapanel></TD>
			</TR>
			<TR>
				<TD><cc2:datapanel id="Datapanel8" runat="server" cssclass="DataPanel75" allowtitleexpandcollapse="True"
						collapseimageurl="../Images/up.gif" collapsetext="Riduci" expandimageurl="../Images/down.gif"
						expandtext="Espandi" titletext="Chiarimento/Informazione" collapsed="False" titlestyle-cssclass="TitleSearch">
						<asp:repeater id="Repeater3" Runat="server">
							<HeaderTemplate>
								<table border="1" class="btbal">
									<tr>
										<td><b>Chiarimento/Informazione</b></td>
										<td><b>Richiedente</b></td>
										<td><b>Data Richiesta</b></td>
									</tr>
							</HeaderTemplate>
							<ItemTemplate>
								<tr>
									<td><%# DataBinder.Eval(Container.DataItem, "descrizione") %></td>
									<td><%# DataBinder.Eval(Container.DataItem, "richiedente") %></td>
									<td><%# DataBinder.Eval(Container.DataItem, "data_chiarim_inform") %></td>
								</tr>
							</ItemTemplate>
							<FooterTemplate>
								</TABLE>
							</FooterTemplate>
						</asp:repeater>
					</cc2:datapanel></TD>
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
								<TD style="WIDTH: 141px" align="right"><STRONG>Imp. Preventivo €: &nbsp;</STRONG></TD>
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
								<TD colSpan="3"><CC1:S_TEXTBOX id="txtSoluzioneProposta" runat="server" width="480px" height="34px" textmode="MultiLine"
										MaxLength="408"></CC1:S_TEXTBOX></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 139px"><B class="blueoverline">Note SGA:</B></TD>
								<TD colSpan="3"><CC1:S_TEXTBOX id="txtNoteSga" runat="server" width="480px" height="34px" textmode="MultiLine"
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
								<TD><STRONG><STRONG>Addetto-Ditta Esecutrice:&nbsp;&nbsp;</STRONG></STRONG></TD>
								<TD style="WIDTH: 241px">
									<CC1:S_COMBOBOX style="Z-INDEX: 0" id="cmbsAddetto" runat="server" width="408px"></CC1:S_COMBOBOX></TD>
								<TD style="WIDTH: 141px" align="left"><STRONG>&nbsp;&nbsp;</STRONG></TD>
								<TD></TD>
							</TR>
							<tr>
								<td><B>Data Sopralluogo:</B></td>
								<td colSpan="3"></td>
							</tr>
							<tr>
								<TD><uc1:calendarpicker id="CalendarPicker4" runat="server"></uc1:calendarpicker></TD>
								<td>Ora<CC1:S_COMBOBOX style="Z-INDEX: 0" id="OraSopralluogo" runat="server" dbdatatype="Integer">
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
									<CC1:S_COMBOBOX style="Z-INDEX: 0" id="MinutiSopralluogo" runat="server" width="40px" dbdatatype="Integer">
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
									</CC1:S_COMBOBOX></td>
								<td colSpan="3"></td>
							</tr>
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
								<TD colSpan="4"><ASP:LABEL id="LblMessaggio" runat="server" width="560px" Visible="False"></ASP:LABEL></TD>
							</TR>
							<TR>
								<TD colSpan="4" align="center">
									<asp:button style="Z-INDEX: 0" id="Button1" runat="server" Text="Chiudi" Width="135px"></asp:button><asp:button id="btRifiuta" runat="server" Text="Rifiuta" Width="135px"></asp:button>&nbsp;
									<asp:button id="btSospendi" runat="server" Text="Sospendi" Width="135px"></asp:button>&nbsp;
									<asp:button id="btApprova" runat="server" Text="Approva/Emetti" Width="135px"></asp:button>&nbsp;
								</TD>
							</TR>
						</TABLE></TD>
			</TR>
			</TBODY></TABLE></cc2:datapanel></TD></TR>
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
											<TD>
												<CC1:S_OPTIONBUTTON id="OptAMisura" tabIndex="4" runat="server" Visible="False" groupname="Grkind" text="A Misura"
													Checked="True"></CC1:S_OPTIONBUTTON></TD>
											<TD style="WIDTH: 106px">
												<CC1:S_OPTIONBUTTON id="OptAForfait" tabIndex="4" runat="server" Visible="False" groupname="Grkind"
													text="A Forfait"></CC1:S_OPTIONBUTTON></TD>
											<TD class="die"><STRONG class="blueoverline"></STRONG></TD>
											<TD></TD>
										</TR>
									</TABLE>
								</TD>
							</TR>
							<TR>
								<TD style="WIDTH: 144px" colSpan="6">
									<TABLE style="WIDTH: 488px; HEIGHT: 88px" id="Table9" class="btbal" border="0" cellSpacing="0"
										cellPadding="0" width="488">
										<TR>
											<TD style="WIDTH: 60px"></TD>
											<TD style="WIDTH: 138px"><STRONG>Costo Materiali</STRONG></TD>
											<TD style="WIDTH: 143px"><STRONG><STRONG><STRONG>Costo Personale</STRONG></STRONG></STRONG></TD>
											<TD><STRONG>Sub Totali</STRONG></TD>
										</TR>
										<TR>
											<TD style="WIDTH: 60px"><STRONG>Manuale</STRONG></TD>
											<TD style="WIDTH: 138px" class="BbR">
												<CC1:S_TEXTBOX style="TEXT-ALIGN: right" id="txtCostiMateriali1" runat="server" width="48px" maxlength="8">0</CC1:S_TEXTBOX>,
												<CC1:S_TEXTBOX id="txtCostiMateriali2" runat="server" width="27px" maxlength="2">00</CC1:S_TEXTBOX></TD>
											<TD style="WIDTH: 143px" class="BbR">
												<CC1:S_TEXTBOX style="TEXT-ALIGN: right" id="txtCostiPersonale1" runat="server" width="48px" maxlength="8">0</CC1:S_TEXTBOX>,
												<CC1:S_TEXTBOX id="txtCostiPersonale2" runat="server" width="27px" maxlength="2">00</CC1:S_TEXTBOX></TD>
											<TD class="BbR">
												<CC1:S_TEXTBOX style="TEXT-ALIGN: right" id="txtCostiTotale1" runat="server" width="48px" maxlength="8">0</CC1:S_TEXTBOX>,
												<CC1:S_TEXTBOX id="txtCostiTotale2" runat="server" width="27px" maxlength="2">00</CC1:S_TEXTBOX></TD>
										</TR>
										<TR>
											<TD style="WIDTH: 60px"><STRONG>A Misura</STRONG></TD>
											<TD style="WIDTH: 138px" class="BbR">
												<ASP:LABEL id="lblCostoMateriali" runat="server"></ASP:LABEL>€<INPUT id=btOpenMat title="Apre i Costi Materiali" onclick="OpenMateriali(<%=wr_id.ToString()%>);" value=... type=button name=btOpenMat></TD>
											<TD style="WIDTH: 143px" class="BbR">
												<ASP:LABEL id="lblCostiPersonale" runat="server"></ASP:LABEL>€<INPUT id=btnPersonale title="Apre i Costi Addetti" onclick="OpenPopUpAddetti(<%=wr_id.ToString()%>);" value=... type=button name=Button1></TD>
											<TD class="BbR">
												<ASP:LABEL id="LblTotale" runat="server"></ASP:LABEL>€</TD>
										</TR>
										<TR>
											<TD style="WIDTH: 60px"><STRONG>Totale</STRONG></TD>
											<TD style="WIDTH: 138px">
												<ASP:LABEL id="LblTotMateriali" runat="server"></ASP:LABEL>€</TD>
											<TD style="WIDTH: 143px">
												<ASP:LABEL id="LblTotPersonale" runat="server"></ASP:LABEL>€</TD>
											<TD>
												<ASP:LABEL id="LblTotGenerale" runat="server"></ASP:LABEL>€</TD>
										</TR>
									</TABLE>
								</TD>
							</TR>
							<TR>
								<TD><B>Imp. a Consuntivo €:</B></TD>
								<TD>
									<CC1:S_TEXTBOX style="TEXT-ALIGN: right" id="ImpCons1" runat="server" width="48px" maxlength="8">0</CC1:S_TEXTBOX>,
									<CC1:S_TEXTBOX id="ImpCons2" runat="server" width="27px" maxlength="2">00</CC1:S_TEXTBOX></TD>
								<TD><B>File Consuntivo PDF:</B>
								</TD>
								<TD><INPUT style="WIDTH: 280px; HEIGHT: 18px" id="FileConsuntivo" size="27" type="file" name="File1"
										runat="server">
								</TD>
								<TD>
									<asp:button style="Z-INDEX: 0" id="BtInviaCons" runat="server" Text="Invia il File..." Width="88px"></asp:button></TD>
								<TD></TD>
							</TR>
							<TR>
								<TD colSpan="3"></TD>
								<TD>
									<asp:hyperlink style="Z-INDEX: 0" id="LkCons" runat="server"></asp:hyperlink>
									<asp:imagebutton style="Z-INDEX: 0" id="btImgDeleteCons" runat="server" ImageUrl="../Images/elimina.gif"></asp:imagebutton></TD>
								<TD colSpan="2"></TD>
							</TR>
							<TR>
								<TD><B>Note Consuntivo:</B>
								</TD>
								<TD>
									<CC1:S_TEXTBOX style="Z-INDEX: 0" id="TxtAForfait" runat="server" Height="28px" MaxLength="250"
										Width="297px" TextMode="MultiLine"></CC1:S_TEXTBOX></TD>
								<TD colSpan="4">&nbsp;&nbsp;&nbsp;
								</TD>
							</TR>
							<TR>
								<TD><B>Centro di Costo: </B>
								</TD>
								<TD>
									<asp:DropDownList style="Z-INDEX: 0" id="cmbCdC" runat="server" Width="296px"></asp:DropDownList></TD>
								<TD><B>Nr Ordinativo Principale di Fornitura:</B></TD>
								<TD>
									<asp:TextBox style="Z-INDEX: 0" id="txtord" runat="server" MaxLength="32" Width="279px"></asp:TextBox></TD>
								<TD colSpan="2"></TD>
							</TR>
						</TABLE>
					</cc2:datapanel></TD>
			</TR>
			<TR>
				<TD><cc2:datapanel id="Datapanel4" runat="server" cssclass="DataPanel75" allowtitleexpandcollapse="True"
						collapseimageurl="../Images/up.gif" collapsetext="Riduci" expandimageurl="../Images/down.gif"
						expandtext="Espandi" titletext="Completamento Ordine" collapsed="False" titlestyle-cssclass="TitleSearch">
						<TABLE border="0" cellSpacing="1" cellPadding="1" width="100%">
							<TR>
								<TD style="WIDTH: 144px" width="144"><STRONG>Stato Richiesta:</STRONG></TD>
								<TD style="WIDTH: 329px">
									<CC1:S_COMBOBOX id="cmbsstatolavoro" runat="server" width="255px"></CC1:S_COMBOBOX></TD>
								<TD style="WIDTH: 112px"></TD>
								<TD></TD>
							</TR>
							<TR id="trsosp">
								<TD style="WIDTH: 144px; HEIGHT: 15px"><STRONG>Sospesa per:</STRONG></TD>
								<TD style="WIDTH: 485px; HEIGHT: 15px" colSpan="3">
									<CC1:S_TEXTBOX id="txtsAnnotazioni" runat="server" width="480px" textmode="MultiLine" height="34px"
										MaxLength="2000"></CC1:S_TEXTBOX></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 144px"><STRONG>Buono Lavoro Esterno:</STRONG></TD>
								<TD style="WIDTH: 329px">
									<asp:TextBox id="txtBuonoLavoroEster" runat="server" MaxLength="32"></asp:TextBox></TD>
								<TD style="WIDTH: 114px"></TD>
								<TD></TD>
							</TR>
							<TR>
								<TD><STRONG>Classificazione Intervento:</STRONG>
								</TD>
								<TD>
									<CC1:S_COMBOBOX id="S_tipintervento" runat="server" dbdatatype="Integer">
										<asp:ListItem Value="A1">A1-Servizio Imp. Climat. Invernale</asp:ListItem>
										<asp:ListItem Value="A2">A2-Servizio Idrico</asp:ListItem>
										<asp:ListItem Value="B1">B1-Servizio Imp. Climat. Estiva</asp:ListItem>
										<asp:ListItem Value="B2">B2-Servizio Imp. Elettrici, Speciali e di Illuminazione</asp:ListItem>
										<asp:ListItem Value="C1">C1-Servizio Imp.Antincendio</asp:ListItem>
										<asp:ListItem Value="C2">C2-Servizio Imp.di Trasporto verticale ed orizzontale</asp:ListItem>
										<asp:ListItem Value="C3">C3-Servizio di minuto Mantenimento Edile</asp:ListItem>
										<asp:ListItem Value="NC">Non Classificato</asp:ListItem>
									</CC1:S_COMBOBOX></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 144px" colSpan="4">
									<TABLE style="HEIGHT: 68px" id="Table13" border="0" cellSpacing="0" cellPadding="0" width="900">
										<TR>
											<TD class="die"><STRONG class="blueoverline">Data Inizio Lavori:</STRONG></TD>
											<TD class="die"><STRONG class="blueoverline" title="data di completamente dell’intervento a tampone per la risoluzione del guasto">Data 
													Provvisoria Fine Lavori:</STRONG></TD>
											<TD class="die"><STRONG class="blueoverline">Data Fine Lavori:</STRONG></TD>
										</TR>
										<TR>
											<TD>
												<TABLE id="Table5" border="0" cellSpacing="1" cellPadding="1" width="100%">
													<TR>
														<TD>
															<uc1:CalendarPicker id="CalendarPicker7" runat="server"></uc1:CalendarPicker></TD>
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
														<TD style="WIDTH: 163px">
															<uc1:CalendarPicker id="CalendarPicker10" runat="server"></uc1:CalendarPicker></TD>
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
														<TD style="WIDTH: 137px">
															<uc1:CalendarPicker id="CalendarPicker8" runat="server"></uc1:CalendarPicker></TD>
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
									</TABLE>
								</TD>
							</TR>
							<TR>
								<TD style="WIDTH: 144px">
									<P><STRONG>Stato Intervento:</STRONG></P>
								</TD>
								<TD style="WIDTH: 329px">
									<asp:DropDownList id="cmbStatoIntervento" runat="server" width="255px">
										<asp:ListItem Value="1">Risolutivo</asp:ListItem>
										<asp:ListItem Value="2">Tampone</asp:ListItem>
									</asp:DropDownList></TD>
								<TD colSpan="2">
									<asp:CheckBox id="CkDisser" runat="server" Text="Creato Disservizio" Visible="False"></asp:CheckBox></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 144px" class="die"><STRONG class="blueoverline"></STRONG></TD>
								<TD style="WIDTH: 329px" colSpan="3">
									<TABLE id="Table16" border="0" cellSpacing="0" cellPadding="0" width="300">
										<TR>
											<TD>
												<asp:TextBox id="txtOperazioneN" runat="server" MaxLength="9" Visible="False"></asp:TextBox></TD>
											<TD></TD>
											<TD>
												<CC1:S_COMBOBOX id="CmbMese" runat="server" width="196px" Visible="False">
													<asp:ListItem Value="0">- Nessun Mese Selezionato -</asp:ListItem>
													<asp:ListItem Value="1">Gennaio</asp:ListItem>
													<asp:ListItem Value="2">Febbraio</asp:ListItem>
													<asp:ListItem Value="3">Marzo</asp:ListItem>
													<asp:ListItem Value="4">Aprile</asp:ListItem>
													<asp:ListItem Value="5">Maggio</asp:ListItem>
													<asp:ListItem Value="6">Giugno</asp:ListItem>
													<asp:ListItem Value="7">Luglio</asp:ListItem>
													<asp:ListItem Value="8">Agosto</asp:ListItem>
													<asp:ListItem Value="9">Settembre</asp:ListItem>
													<asp:ListItem Value="10">Ottobre</asp:ListItem>
													<asp:ListItem Value="11">Novembre</asp:ListItem>
													<asp:ListItem Value="12">Dicembre</asp:ListItem>
												</CC1:S_COMBOBOX></TD>
										</TR>
									</TABLE>
								</TD>
							</TR>
							<TR>
								<TD style="WIDTH: 144px"><STRONG>Note Completamento:</STRONG></TD>
								<TD style="WIDTH: 329px" colSpan="3">
									<CC1:S_TEXTBOX id="txtNoteCompletamento" runat="server" width="480px" textmode="MultiLine" height="34px"
										MaxLength="215"></CC1:S_TEXTBOX></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 144px" class="die"><STRONG class="blueoverline"></STRONG></TD>
								<TD style="WIDTH: 329px" class="die" colSpan="3">
									<TABLE style="WIDTH: 544px; HEIGHT: 42px" id="Table15" border="0" cellSpacing="0" cellPadding="0"
										width="544">
										<TR>
											<TD class="die">
												<asp:CheckBox id="Ck1" runat="server" Text="Gli apparati sono perfettamente funzionanti" Visible="False"
													CssClass="blueoverline"></asp:CheckBox></TD>
											<TD class="die">
												<asp:CheckBox id="Ck2" runat="server" Text="L'installazione è conforme alle norme vigenti" Visible="False"
													CssClass="blueoverline"></asp:CheckBox></TD>
										</TR>
									</TABLE>
								</TD>
							</TR>
							<TR>
								<TD style="WIDTH: 144px" class="die"><STRONG class="blueoverline"></STRONG></TD>
								<TD style="WIDTH: 329px" colSpan="3">
									<CC1:S_TEXTBOX id="cmbDescrizioneIntervento" runat="server" width="480px" textmode="MultiLine"
										height="34px" MaxLength="256" Visible="False"></CC1:S_TEXTBOX></TD>
							</TR>
							<TR id="trsod">
								<TD style="WIDTH: 144px"><STRONG>Livello Soddisfazione:</STRONG></TD>
								<TD style="WIDTH: 329px" colSpan="3">
									<ASP:RADIOBUTTONLIST id="RdListLivello" runat="server" Width="500px" repeatdirection="Horizontal">
										<asp:ListItem Value="4" Selected="True">Non dichiarato</asp:ListItem>
										<asp:ListItem Value="1">Non Soddisfatto</asp:ListItem>
										<asp:ListItem Value="2">Soddisfatto</asp:ListItem>
										<asp:ListItem Value="3">Pienamente Soddisfatto</asp:ListItem>
									</ASP:RADIOBUTTONLIST></TD>
							</TR>
						</TABLE>
					</cc2:datapanel></TD>
			</TR>
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
								<TD><uc1:aggiungichiariinfo style="Z-INDEX: 0" id="AggiungiChiariInfo" runat="server"></uc1:aggiungichiariinfo></TD>
								<TD><asp:button id="btFoglioPdf" runat="server" Text="Foglio Prestazioni PDF" Width="135px"></asp:button></TD>
							</TR>
							<TR>
								<TD><asp:button id="btChiudi" runat="server" Text="Chiudi" Width="135px"></asp:button></TD>
								<TD><uc1:aggiungisollecito id="AggiungiSollecito" runat="server"></uc1:aggiungisollecito></TD>
								<TD><uc1:aggiungireclamo style="Z-INDEX: 0" id="AggiungiReclamo" runat="server"></uc1:aggiungireclamo></TD>
								<TD><asp:button style="Z-INDEX: 0" id="btFoglio" runat="server" Text="Report OdL" Width="135px"></asp:button></TD>
							</TR>
						</TABLE>
					</div>
				</TD>
			</TR>
			</TBODY></TABLE>&nbsp;
		</form>
	</body>
</HTML>
