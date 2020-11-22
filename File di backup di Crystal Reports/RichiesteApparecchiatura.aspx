<%@ Page language="c#" Codebehind="RichiesteApparecchiatura.aspx.cs" AutoEventWireup="false" Inherits="TheSite.AnagrafeImpianti.RichiesteApparecchiatura" %>
<%@ Register TagPrefix="uc1" TagName="CalendarPicker" Src="../WebControls/CalendarPicker.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Addetti" Src="../WebControls/Addetti.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Richiedenti" Src="../WebControls/Richiedenti.ascx" %>
<%@ Register TagPrefix="uc1" TagName="RicercaModulo" Src="../WebControls/RicercaModulo.ascx" %>
<%@ Register TagPrefix="uc1" TagName="PageTitle" Src="../WebControls/PageTitle.ascx" %>
<%@ Register TagPrefix="cc1" Namespace="S_Controls" Assembly="S_Controls" %>
<%@ Register TagPrefix="uc1" TagName="GridTitle" Src="../WebControls/GridTitle.ascx" %>
<%@ Register TagPrefix="Collapse" Namespace="Csy.WebControls" Assembly="CsyWebControls" %>
<%@ Register TagPrefix="iewc" Namespace="Microsoft.Web.UI.WebControls" Assembly="Microsoft.Web.UI.WebControls" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<TITLE>SfogliaRdl</TITLE>
		<META content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<META content="C#" name="CODE_LANGUAGE">
		<META content="JavaScript" name="vs_defaultClientScript">
		<META content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="../Css/MainSheet.css" type="text/css" rel="stylesheet">
		<SCRIPT language="javascript">
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
			
		  //Impedisce di scatenare qualsiasi l'evento sulla pagina alla pressione del tasto invio
	   function valutaenter(evt)
			{
				var e = evt? evt : window.event; 
				if(!e) return; 
				var key = 0; 
				
				if(IE4==true)
				{
					if (e.keyCode ==13){
						e.keyCode = 0;
						return false;
					}	
		        }
		        
				if (e.keycode) { key = e.keycode; } // for moz/fb, if keycode==0 use 'which' 
				if (typeof(e.which)!= 'undefined') { 
					key = e.which;
					if (key ==13){
						return false;
					} 
					
				} 
			}
		
		</SCRIPT>
	</HEAD>
	<body onkeypress="if (valutaenter(event) == false) { return false; }" bottommargin="0"
		leftmargin="5" topmargin="0" rightmargin="0" ms_positioning="GridLayout">
		<FORM id="Form1" method="post" runat="server">
			<TABLE id="TableMain" style="Z-INDEX: 101; POSITION: absolute; TOP: 0px; LEFT: 0px" cellspacing="0"
				cellpadding="0" width="100%" align="center" border="0">
				<TBODY>
					<TR>
						<TD style="HEIGHT: 50px" align="center"><UC1:PAGETITLE id="PageTitle1" title="Sfoglia RdL e Odl" runat="server"></UC1:PAGETITLE></TD>
					</TR>
					<TR>
						<TD>
							<TABLE>
								<TR>
									<TD>&nbsp;&nbsp;<B>Codice Componente:</B></TD>
									<TD><CC1:S_LABEL id="S_lblcodicecomponente" runat="server"></CC1:S_LABEL></TD>
									<TD>&nbsp;&nbsp;<B>Standard:</B></TD>
									<TD><CC1:S_LABEL id="S_lblstdapparecchiature" runat="server"></CC1:S_LABEL></TD>
								<TR>
									<TD>&nbsp;&nbsp;<B>Codice Edificio:</B></TD>
									<TD><CC1:S_LABEL id="S_lblcodiceedificio" runat="server"></CC1:S_LABEL></TD>
									<TD>&nbsp;&nbsp;<B>Edificio:</B></TD>
									<TD><CC1:S_LABEL id="S_lbledificio" runat="server"></CC1:S_LABEL></TD>
								</TR>
							</TABLE>
						</TD>
					</TR>
					<TR>
						<TD valign="top" align="center" height="95%">
							<TABLE id="tblForm" cellspacing="1" cellpadding="1" align="center">
								<TBODY>
									<TR>
										<TD style="HEIGHT: 25%" valign="top" align="left"><COLLAPSE:DATAPANEL id="PanelRicerca" runat="server" titlestyle-cssclass="TitleSearch" cssclass="DataPanel75"
												titletext="Ricerca" allowtitleexpandcollapse="True" collapsed="False" expandtext="Espandi" collapsetext="Riduci" collapseimageurl="../Images/up.gif"
												expandimageurl="../Images/down.gif">
												<TABLE id="tblSearch100" border="0" cellSpacing="1" cellPadding="2">
													<TR>
														<TD style="HEIGHT: 25px" width="13%" align="left">Richiesta di Lavoro:</TD>
														<TD style="WIDTH: 259px; HEIGHT: 25px" width="259">
															<CC1:S_TEXTBOX id="txtsRichiesta" runat="server" dbindex="2" dbdatatype="Integer" maxlength="10"
																dbsize="255" width="100px" dbdirection="Input" dbparametername="p_Wr_Id"></CC1:S_TEXTBOX></TD>
														<TD style="HEIGHT: 25px" width="15%" align="left">Addetto:</TD>
														<TD style="HEIGHT: 25px" width="30%">
															<UC1:ADDETTI id="Addetti1" runat="server"></UC1:ADDETTI></TD>
													</TR>
													<TR>
														<TD style="HEIGHT: 29px" align="left">Da:</TD>
														<TD style="WIDTH: 259px; HEIGHT: 29px">
															<UC1:CALENDARPICKER id="CalendarPicker1" runat="server"></UC1:CALENDARPICKER></TD>
														<TD style="HEIGHT: 29px" align="left">A:</TD>
														<TD style="HEIGHT: 29px">
															<UC1:CALENDARPICKER id="CalendarPicker2" runat="server"></UC1:CALENDARPICKER>
															<ASP:COMPAREVALIDATOR id="CompareValidator1" runat="server" errormessage="Data non valida!" operator="GreaterThanEqual"
																type="Date"></ASP:COMPAREVALIDATOR></TD>
													</TR>
													<TR>
														<TD align="left">Ordine di Lavoro:</TD>
														<TD style="WIDTH: 259px">
															<CC1:S_TEXTBOX id="txtsOrdine" runat="server" maxlength="10" dbsize="255" width="100px" dbdirection="Input"
																dbparametername="p_Wr_Id"></CC1:S_TEXTBOX></TD>
														<TD align="left">Stato Richiesta:</TD>
														<TD>
															<CC1:S_COMBOBOX id="cmbsStatus" runat="server" width="99%"></CC1:S_COMBOBOX></TD>
													</TR>
													<TR>
														<TD style="HEIGHT: 16px" colSpan="4" align="left"></TD>
													</TR>
													<TR>
														<TD colSpan="3" align="left">
															<CC1:S_BUTTON id="btnsRicerca" runat="server" cssclass="btn" text="Ricerca"></CC1:S_BUTTON>&nbsp;<INPUT class="btn" value="Reset" type="reset">&nbsp;&nbsp;
															<CC1:S_BUTTON id="cmdExcel" tabIndex="2" runat="server" cssclass="btn" text="Esporta"></CC1:S_BUTTON>
															<ASP:BUTTON id="cmdReset" runat="server" cssclass="btn" text="Indietro"></ASP:BUTTON></TD>
														<TD align="right"><A class=GuidaLink href="<%= HelpLink %>" 
                  target=_blank>Guida</A></TD>
													</TR>
												</TABLE>
											</COLLAPSE:DATAPANEL></TD>
									</TR>
									<TR>
										<TD valign="top" align="center" width="100%">
									<TR>
										<TD><IEWC:TABSTRIP id="TabStrip1" runat="server" width="100%" autopostback="True" tabdefaultstyle="background-color:darkgray;font-family:verdana;font-weight:bold;font-size:8pt;color:#ffffff;width:79;height:21;text-align:center;border-style:outset;border-width:1;"
												tabhoverstyle="background-color:#777777;border-style:inset;border-width:1;" tabselectedstyle="background-color:#ffffff;color:#000000;border-style:inset;">
												<IEWC:TAB text="Tutte le Manutenzioni"></IEWC:TAB>
												<IEWC:TAB text="Manutenzione su Richiesta"></IEWC:TAB>
												<IEWC:TAB text="Manutenzione Programmata"></IEWC:TAB>
												<IEWC:TAB text="Manutenzione Straordinaria"></IEWC:TAB>
											</IEWC:TABSTRIP></TD>
									</TR>
						</TD>
					</TR>
					<TR>
						<TD valign="top" align="center" width="100%"><UC1:GRIDTITLE id="GridTitle1" runat="server"></UC1:GRIDTITLE><ASP:DATAGRID id="DataGridRicerca" runat="server" cssclass="DataGrid" allowpaging="True" bordercolor="Gray"
								borderwidth="1px" gridlines="Vertical" autogeneratecolumns="False">
								<AlternatingItemStyle CssClass="DataGridAlternatingItemStyle"></AlternatingItemStyle>
								<ItemStyle CssClass="DataGridItemStyle"></ItemStyle>
								<HeaderStyle CssClass="DataGridHeaderStyle"></HeaderStyle>
								<Columns>
									<asp:BoundColumn DataField="WR_ID" HeaderText="RdL"></asp:BoundColumn>
									<asp:BoundColumn Visible="False" DataField="DATA_WR" HeaderText="Data Creazione" DataFormatString="{0:d}"></asp:BoundColumn>
									<asp:BoundColumn DataField="WO_ID" HeaderText="OdL"></asp:BoundColumn>
									<asp:BoundColumn DataField="PIANIFICATA" HeaderText="Data Pianificata" DataFormatString="{0:d}"></asp:BoundColumn>
									<asp:BoundColumn DataField="COMPLETATA" HeaderText="Data Fine Lavori" DataFormatString="{0:d}"></asp:BoundColumn>
									<asp:BoundColumn DataField="STATO" HeaderText="Stato Richiesta"></asp:BoundColumn>
									<asp:BoundColumn DataField="DESCRIZIONE" HeaderText="Descrizione"></asp:BoundColumn>
									<asp:BoundColumn DataField="ADDETTO" HeaderText="Addetto"></asp:BoundColumn>
									<asp:BoundColumn DataField="Manutenzione" HeaderText="Manutenzione"></asp:BoundColumn>
								</Columns>
								<PagerStyle HorizontalAlign="Left" CssClass="DataGridPagerStyle" Mode="NumericPages"></PagerStyle>
							</ASP:DATAGRID></TD>
					</TR>
				</TBODY>
			</TABLE>
			</TD></TR></TBODY></TABLE></FORM>
		</TD></TR></TBODY></TABLE></TR></TBODY></TABLE></TR></TBODY></TABLE></FORM>
		<script language="javascript">
		//parent.left.calcola();
		//<body   onbeforeunload="parent.left.valorizza()" onkeypress="if (valutaenter(event) == false) { return false; }"
		</script>
	</body>
</HTML>
