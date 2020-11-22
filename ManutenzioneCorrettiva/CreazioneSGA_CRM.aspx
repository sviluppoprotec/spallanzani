<%@ Page language="c#" Codebehind="CreazioneSGA_CRM.aspx.cs" AutoEventWireup="false" Inherits="TheSite.ManutenzioneCorrettiva.CreazioneSGA_CRM" %>
<%@ Register TagPrefix="uc1" TagName="UserStanze" Src="../WebControls/UserStanze.ascx" %>
<%@ Register TagPrefix="uc1" TagName="CalendarPicker" Src="../WebControls/CalendarPicker.ascx" %>
<%@ Register TagPrefix="MessPanel" Namespace="Csy.WebControls" Assembly="CsyWebControls" %>
<%@ Register TagPrefix="uc1" TagName="CodiceApparecchiature" Src="../WebControls/CodiceApparecchiature.ascx" %>
<%@ Register TagPrefix="cc1" Namespace="S_Controls" Assembly="S_Controls" %>
<%@ Register TagPrefix="uc1" TagName="RichiedentiSollecito" Src="../WebControls/RichiedentiSollecito.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Richiedenti" Src="../WebControls/Richiedenti.ascx" %>
<%@ Register TagPrefix="uc1" TagName="RicercaModulo" Src="../WebControls/RicercaModulo.ascx" %>
<%@ Register TagPrefix="uc1" TagName="PageTitle" Src="../WebControls/PageTitle.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>Creazione Rdl</title>
	</HEAD>
	<BODY bottomMargin="0">
		&nbsp;
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<LINK rel="stylesheet" type="text/css" href="../Css/MainSheet.css">
		<script language="javascript">
	     function ValUrgenza(sender, args)
	     {	
			args.IsValid = true;
			return true;
	     }
		function ManDiff()
		{
		    return true;
			
		}
		function setProg()
		{
			if(document.getElementById('CmbProgetto')==null)
				return;
			var ct=document.getElementById('CmbProgetto').value;
			document.getElementById("<%=RichiedentiSollecito1.idProg.ClientID%>").value=ct;
			document.getElementById("<%=RicercaModulo1.idProg.ClientID%>").value=ct;
		}
		function clearRoom()
		{
			document.getElementById("<%=UserStanze1.s_TxtIdStanza.ClientID%>").value="";
			document.getElementById("<%=UserStanze1.s_TxtDescStanza.ClientID%>").value="";	
		}   
	
  
	
		function iterator(senser)
		{
			var count = document.forms[0].elements.length;
			for (i=0; i<count; i++) 
			{	
				var element = document.forms[0].elements[i]; 
				if(element.type == 'select-one')
				{
					element.disabled=true;
				}
			}	
		}
		
	function ClearApparechiature()
	{
		var ctrltxtapp=document.getElementById('<%=CodiceApparecchiature1.s_CodiceApparecchiatura.ClientID%>');
		if(ctrltxtapp!=null && ctrltxtapp!='undefined')
		{
		  ctrltxtapp.value="";
		  document.getElementById('<%=CodiceApparecchiature1.CodiceHidden.ClientID%>').value="";
		}
	}

	function ControllaBL(nome)
	{
		if (document.getElementById(nome).value == "")				
		{
			alert('Inserire il Codice Edificio');
			return false;
		}
		return true;
	}
	
  function DivSetVisible(state)
  {
	 var DivRef = document.getElementById('pnlShowInfo');
	 var IfrRef = document.getElementById('DivShim');
	 if(state)
	 {
		DivRef.style.display = "block";
		IfrRef.style.width = DivRef.offsetWidth;
		IfrRef.style.height = DivRef.offsetHeight;
		IfrRef.style.top = DivRef.style.top;
		IfrRef.style.left = DivRef.style.left;
		IfrRef.style.zIndex = DivRef.style.zIndex - 1;
		IfrRef.style.display = "block";
	}
	else
	{
		DivRef.style.display = "none";
		IfrRef.style.display = "none";
	}
  }
  
   function EmesseSetVisible(state)
  {
   var DivRef = document.getElementById('PanelEmesse');
   var IfrRef = document.getElementById('DivEmesse');
   if(state)
   {
    DivRef.style.display = "block";
    IfrRef.style.width = DivRef.offsetWidth;
    IfrRef.style.height = DivRef.offsetHeight;
    IfrRef.style.top = DivRef.style.top;
    IfrRef.style.left = DivRef.style.left;
    IfrRef.style.zIndex = DivRef.style.zIndex - 1;
    IfrRef.style.display = "block";
   }
   else
   {
    DivRef.style.display = "none";
    IfrRef.style.display = "none";
   }
   
   
  }
  function visibletextmail(sender,controlid)
  {
       document.getElementById(controlid).disabled=!document.getElementById(sender).checked;       
  }
  	function SoloNumeri()
		{	
			if (event.keyCode < 48	|| event.keyCode > 57)
			{
				event.keyCode = 0;
			}	
		}
		
 		function ControllaOra(orain)
		{
		
			var ora=document.getElementById(orain).value;
			
				if (isNaN(ora))
						document.getElementById(orain).value="00"
				if(ora<0 || ora>23)
				{ 

					alert("Attenzione l'ora deve essere compresa tra 00 e 23");		
					document.getElementById(orain).focus()
					return false;
				}	
				else
				{
					var val = document.getElementById(orain).value;
					if(val.length==1)
						document.getElementById(orain).value="0" + val;
					return true;
				}
		}
		function ControllaMin(min)
		{
			var minuti=parseInt(document.getElementById(min).value);
				if (minuti=="")
						document.getElementById(min).value="00"
				
				
				if(minuti<0 || minuti>59)
				{
					alert("Attenzione i minuti devono essere compresi tra 00 e 59");		
					document.getElementById(min).focus();
					return false;
				}
				else
				{
				var val = document.getElementById(min).value;
					if(val.length==1)
						document.getElementById(min).value="0" + val;
					return true;
				}
			
		}
	function formatNum(obj)

{
	val=document.getElementById(obj).value;
	if(val=="")
		document.getElementById(obj).value="00";
	//if(val.length==1)	
	//	document.getElementById(obj).value=val+"0";
}

function NascondiASeguito(p)
{
	if(p=='1')
	{
				crtls=document.getElementById('aseguito1').style; 
				crtls.display="block";
				crtls=document.getElementById('aseguito2').style; 
				crtls.display="block";
				crtls=document.getElementById('aseguito3').style; 
				crtls.display="block";
				crtls=document.getElementById('aseguito4').style; 
				crtls.display="block";
				crtls=document.getElementById('aseguito5').style; 
				crtls.display="block";
	}
	
	if(p=='2')
	{
				crtls=document.getElementById('aseguito1').style; 
				crtls.display="none";
				crtls=document.getElementById('aseguito2').style; 
				crtls.display="none";
				crtls=document.getElementById('aseguito3').style; 
				crtls.display="none";
				crtls=document.getElementById('aseguito4').style; 
				crtls.display="none";
				crtls=document.getElementById('aseguito5').style; 
				crtls.display="none";

	}
	
}
function $get(ct)
{
 return document.getElementById(ct);
}

function bloccachk(chk)
{
var ctrl;
var crtls;
ctrl=!document.getElementById(chk).checked
	switch (chk)
	{
		case"ChkConduzione":
			$get('OraConduzione').disabled=ctrl;
			$get("MinutiConduzione").disabled=ctrl;
			$get("CPConduzioneData_S_TxtDatecalendar").disabled=ctrl;
			$get("CPConduzioneData_btCalendar").disabled=ctrl;
		break;
		case"ChkSopralluogo":
			$get('TxtSopralluogo').disabled=ctrl;
			$get("CPSopralluogoDie_S_TxtDatecalendar").disabled=ctrl;
			$get("CPSopralluogoDie_btCalendar").disabled=ctrl;
			$get("CPSopralluogoData_S_TxtDatecalendar").disabled=ctrl;
			$get("CPSopralluogoData_btCalendar").disabled=ctrl;
			$get('TxtASeguito4').disabled=ctrl;
		break;
	}
}

function apriGuidaUrgenze(prj)
{
	if(prj==1)//h3g
		var param="../Doc_Db/DOmUrgenzaH3g-2.pdf"; 			
	else
		var param="../Doc_Db/DOmUrgenza-Vod.pdf";
	window.open(param,'hlp','width=800,height=400 ,toolbar=no, location=no,status=no,menubar=no,scrollbars=no,resizable=yes');
	return false;
}	

		</script>
		<form id="Form1" method="post" runat="server">
			<TABLE style="Z-INDEX: 101; POSITION: absolute; WIDTH: 100%; HEIGHT: 100%; TOP: 0px; LEFT: 0px"
				id="TableMain" border="0" cellSpacing="0" cellPadding="0" width="100%" align="center">
				<TBODY>
					<tr>
						<TD style="HEIGHT: 50px" align="center"><uc1:pagetitle id="PageTitle1" title="Inserimento Richieste" runat="server"></uc1:pagetitle></TD>
					</tr>
					<tr>
						<td>
							<hr SIZE="1" noShade>
							<div>&nbsp;<asp:label id="lblProgetto" runat="server">Progetto: </asp:label><asp:dropdownlist id="CmbProgetto" runat="server" Width="216px"></asp:dropdownlist></div>
						</td>
					</tr>
					<tr>
						<TD height="100%" vAlign="top" align="left">
							<TABLE id="tblBlSearch" border="0" cellSpacing="1" cellPadding="1">
								<tr>
									<td>
										<div id="PanelRichiedente">
											<TABLE style="WIDTH: 100%" id="TableRichiedente" border="0" cellSpacing="1" cellPadding="1">
												<TR>
													<TD><uc1:richiedentisollecito id="RichiedentiSollecito1" runat="server"></uc1:richiedentisollecito><asp:requiredfieldvalidator id="rfvRichiedenteNome" runat="server" ErrorMessage="Indicare il Nome del Richiedente">*</asp:requiredfieldvalidator><asp:requiredfieldvalidator id="rfvRichiedenteCognome" runat="server" ErrorMessage="Indicare il Cognome del Richiedente">*</asp:requiredfieldvalidator></TD>
												</TR>
											</TABLE>
										</div>
									</td>
								</tr>
								<TR>
									<TD>
										<TABLE style="WIDTH: 100%" id="TableRicercaModulo" border="0" cellSpacing="1" cellPadding="1">
											<TR>
												<TD><uc1:ricercamodulo id="RicercaModulo1" runat="server"></uc1:ricercamodulo><asp:requiredfieldvalidator id="rfvEdificio" runat="server" ErrorMessage="Selezionare un Edificio">*</asp:requiredfieldvalidator></TD>
											</TR>
										</TABLE>
									</TD>
								</TR>
								<TR>
									<TD>Descrizione Intervento Richiesto:</TD>
								</TR>
								<TR>
									<TD>
										<TABLE style="WIDTH: 100%" class="tblSearch100Dettaglio" border="0" cellSpacing="0" cellPadding="0">
											<TR>
												<TD width="10%">Telefono</TD>
												<TD width="20%" align="left"><asp:textbox id="txtsTelefonoRichiedente" runat="server" MaxLength="50"></asp:textbox></TD>
												<TD class="Comm" width="10%"><span class="blueoverline">Nota/Ambiente</span></TD>
												<TD width="40%" align="left"><asp:textbox id="txtsNota" runat="server" Width="100%" MaxLength="2000" TextMode="MultiLine"
														Rows="2"></asp:textbox></TD>
											</TR>
											<tr>
												<TD width="10%">Piano</TD>
												<TD width="20%" align="left"><asp:dropdownlist id="cmbsPiano" runat="server" Width="200px"></asp:dropdownlist></TD>
												<TD width="10%">Stanza</TD>
												<TD width="10%" colSpan="2"><uc1:userstanze id="UserStanze1" runat="server"></uc1:userstanze></TD>
											</tr>
										</TABLE>
									</TD>
								</TR>
								<TR>
									<TD><asp:linkbutton id="lkbNonEmesse" runat="server" CausesValidation="False" CssClass="LabelInfo">Richieste non Emesse</asp:linkbutton></TD>
								</TR>
								<TR>
									<TD>
										<div style="Z-INDEX: 100; POSITION: absolute; BACKGROUND-COLOR: gainsboro; DISPLAY: none; COLOR: #ffffff"
											id="pnlShowInfo" runat="server">
											<TABLE width="100%" height="100%">
												<TR>
													<TD class="TitleSearch" vAlign="top" align="right"><asp:linkbutton id="lnkChiudi" runat="server" CausesValidation="False" CssClass="LabelChiudi">Chiudi</asp:linkbutton></TD>
												</TR>
												<TR>
													<TD><asp:datagrid id="DataGridRicerca" runat="server" CssClass="DataGrid" PageSize="5" BorderColor="Gray"
															BorderWidth="1px" AutoGenerateColumns="False" GridLines="Vertical" AllowPaging="True">
															<AlternatingItemStyle CssClass="DataGridAlternatingItemStyle"></AlternatingItemStyle>
															<ItemStyle CssClass="DataGridItemStyle"></ItemStyle>
															<HeaderStyle CssClass="DataGridHeaderStyle"></HeaderStyle>
															<Columns>
																<asp:BoundColumn Visible="False" DataField="ID" HeaderText="ID"></asp:BoundColumn>
																<asp:TemplateColumn>
																	<HeaderStyle Width="3%"></HeaderStyle>
																	<ItemStyle HorizontalAlign="Center" VerticalAlign="Middle"></ItemStyle>
																	<ItemTemplate>
																		<asp:ImageButton CausesValidation=False id="lnkNonEmesse" Runat=server CommandName="NonEmesse" ImageUrl="~/images/edit.gif" CommandArgument='<%# "CompletaRdl.aspx?wr_id=" + DataBinder.Eval(Container.DataItem,"ID")%>'>
																		</asp:ImageButton>
																	</ItemTemplate>
																</asp:TemplateColumn>
																<asp:BoundColumn DataField="ID" HeaderText="N. RDL"></asp:BoundColumn>
																<asp:BoundColumn DataField="bl" HeaderText="EDIFICIO"></asp:BoundColumn>
																<asp:BoundColumn DataField="Data" HeaderText="DATA RICHIESTA" DataFormatString="{0:g}"></asp:BoundColumn>
																<asp:BoundColumn DataField="status" HeaderText="STATO"></asp:BoundColumn>
																<asp:BoundColumn DataField="Descrizione" HeaderText="DESCRIZIONE"></asp:BoundColumn>
																<asp:BoundColumn DataField="Richiedente" HeaderText="RICHIEDENTE"></asp:BoundColumn>
															</Columns>
															<PagerStyle Mode="NumericPages"></PagerStyle>
														</asp:datagrid></TD>
												</TR>
											</TABLE>
										</div>
										<iframe style="POSITION: absolute; DISPLAY: none" id="DivShim" tabIndex="0" src="javascript:false;"
											frameBorder="0" scrolling="no"></iframe>
									</TD>
								</TR>
								<TR>
									<TD><asp:linkbutton id="LinkApprovate" runat="server" CausesValidation="False" CssClass="LabelInfo">Richieste Approvate</asp:linkbutton></TD>
								</TR>
								<TR>
									<TD>
										<div style="Z-INDEX: 100; POSITION: absolute; BACKGROUND-COLOR: gainsboro; DISPLAY: none; COLOR: #ffffff"
											id="PanelEmesse" runat="server">
											<TABLE width="100%" height="100%">
												<TR>
													<TD class="TitleSearch" vAlign="top" align="right"><asp:linkbutton id="LinkChiudi2" runat="server" CausesValidation="False" CssClass="LabelChiudi">Chiudi</asp:linkbutton></TD>
												</TR>
												<TR>
													<TD><asp:datagrid id="DatagridEmesse" runat="server" CssClass="DataGrid" PageSize="5" BorderColor="Gray"
															BorderWidth="1px" AutoGenerateColumns="False" GridLines="Vertical" AllowPaging="True">
															<AlternatingItemStyle CssClass="DataGridAlternatingItemStyle"></AlternatingItemStyle>
															<ItemStyle CssClass="DataGridItemStyle"></ItemStyle>
															<HeaderStyle CssClass="DataGridHeaderStyle"></HeaderStyle>
															<Columns>
																<asp:BoundColumn Visible="False" DataField="ID" HeaderText="ID"></asp:BoundColumn>
																<asp:TemplateColumn>
																	<HeaderStyle Width="3%"></HeaderStyle>
																	<ItemStyle HorizontalAlign="Center" VerticalAlign="Middle"></ItemStyle>
																	<ItemTemplate>
																		<asp:ImageButton CausesValidation=False id="lnlEmesse" Runat=server CommandName="Emesse" ImageUrl="~/images/edit.gif" CommandArgument='<%# "CompletaRdl.aspx?wr_id=" + DataBinder.Eval(Container.DataItem,"ID") + "&c=true"%>'>
																		</asp:ImageButton>
																	</ItemTemplate>
																</asp:TemplateColumn>
																<asp:BoundColumn DataField="ID" HeaderText="N. RDL"></asp:BoundColumn>
																<asp:BoundColumn DataField="bl" HeaderText="EDIFICIO"></asp:BoundColumn>
																<asp:BoundColumn DataField="Data" HeaderText="DATA RICHIESTA" DataFormatString="{0:g}"></asp:BoundColumn>
																<asp:BoundColumn DataField="status" HeaderText="STATO"></asp:BoundColumn>
																<asp:BoundColumn DataField="Descrizione" HeaderText="DESCRIZIONE"></asp:BoundColumn>
																<asp:BoundColumn DataField="Richiedente" HeaderText="RICHIEDENTE"></asp:BoundColumn>
															</Columns>
															<PagerStyle Mode="NumericPages"></PagerStyle>
														</asp:datagrid></TD>
												</TR>
											</TABLE>
										</div>
										<iframe style="POSITION: absolute; DISPLAY: none" id="DivEmesse" src="javascript:false;"
											frameBorder="0" scrolling="no"></iframe>
									</TD>
								</TR>
								<TR>
									<TD><asp:button id="btsCodice" runat="server" Width="153" text="Visualizza ReperibilitÓ" Height="22"></asp:button><BR>
										<asp:textbox id="txtBL_ID" runat="server" Width="0px"></asp:textbox>
										<div style="BORDER-BOTTOM: #000000 1px solid; POSITION: absolute; BORDER-LEFT: #000000 1px solid; WIDTH: 100%; DISPLAY: none; HEIGHT: 200%; BORDER-TOP: #000000 1px solid; BORDER-RIGHT: #000000 1px solid"
											id="PopupRep"><IFRAME id="docRep" src="" frameBorder="no" width="100%" name="docRep"></IFRAME>
										</div>
									</TD>
								</TR>
								<TR>
									<TD>
										<div id="PanelServizio">
											<TABLE style="WIDTH: 100%" id="Table2" border="0" cellSpacing="1" cellPadding="1">
												<tr>
													<td style="HEIGHT: 16px" width="15%"><b>NR.CRM</b>
													</td>
													<td><asp:textbox id="txt_CRM" runat="server" Width="100px"></asp:textbox></td>
												</tr>
												<TR>
													<TD style="HEIGHT: 16px" width="15%">Servizio</TD>
													<TD style="HEIGHT: 16px" colSpan="5"><asp:dropdownlist id="cmbsServizio" runat="server" Width="350px" AutoPostBack="True"></asp:dropdownlist><asp:requiredfieldvalidator id="RequiredfieldvalidatorServ" runat="server" ErrorMessage="Selezionare un servizio"
															ControlToValidate="cmbsServizio" InitialValue="0">*</asp:requiredfieldvalidator></TD>
												</TR>
												<TR>
													<TD width="15%"><SPAN>Std. Apparecchiatura</SPAN></TD>
													<TD colSpan="5"><asp:dropdownlist id="cmbsApparecchiatura" runat="server" Width="350px" AutoPostBack="True"></asp:dropdownlist></TD>
												</TR>
											</TABLE>
										</div>
									</TD>
								</TR>
								<TR>
									<TD>
										<TABLE style="WIDTH: 100%" id="TableRicercaApparecchiatura" border="0" cellSpacing="1"
											cellPadding="1">
											<TR>
												<TD><uc1:codiceapparecchiature id="CodiceApparecchiature1" runat="server"></uc1:codiceapparecchiature></TD>
											</TR>
										</TABLE>
									</TD>
								</TR>
								<TR>
									<TD>
										<div id="PanelProblema">
											<TABLE style="WIDTH: 100%" id="TableProblema" border="0" cellSpacing="1" cellPadding="1">
												<TR>
													<TD width="15%">Urgenza</TD>
													<TD><asp:dropdownlist id="cmbsUrgenza" runat="server" Width="400px"></asp:dropdownlist></TD>
												</TR>
												<TR>
													<TD width="15%">Descrizione Problema/Note</TD>
													<TD><asp:textbox id="txtsProblema" runat="server" Width="100%" TextMode="MultiLine" Rows="4" Height="34px"></asp:textbox></TD>
												</TR>
											</TABLE>
										</div>
									</TD>
								</TR>
								<TR>
									<TD class="SGA"><B class="blueoverline">Tipo Manutenzione:&nbsp;&nbsp; </B>
										<asp:dropdownlist id="cmbsTipoManutenzione" runat="server" width="196px"></asp:dropdownlist></TD>
								</TR>
								<TR>
									<TD class="SGA">
										<div><span class="blueoverline">ProgrammabilitÓ Intervento:&nbsp;</span><asp:dropdownlist id="cmbsTipoIntrevento" runat="server" width="224px"></asp:dropdownlist></div>
									</TD>
								</TR>
								<!--
								<TR>
									<TD class="Comm"><STRONG class="blueoverline">A Seguito di:</STRONG></TD>
								</TR>
								-->
								<TR style="DISPLAY: none">
									<TD>
										<div id="aseguito1">
											<ul>
												<li>
													<TABLE style="WIDTH: 600px; HEIGHT: 40px" id="Table70" class="BordiCellaR" border="0" cellSpacing="0"
														cellPadding="0" width="448">
														<TR>
															<TD style="WIDTH: 160px" class="SGA"><asp:checkbox id="ChkConduzione" runat="server" CssClass="blueoverline" Text="Conduzione"></asp:checkbox></TD>
															<TD class="SGA"><SPAN class="blueoverline">In data:</SPAN></TD>
															<TD><UC1:CALENDARPICKER id="CPConduzioneData" runat="server"></UC1:CALENDARPICKER></TD>
															<TD><SPAN class="SGA"><SPAN class="blueoverline">Ora:</SPAN></SPAN>
																<asp:dropdownlist id="OraConduzione" runat="server">
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
																</asp:dropdownlist>:
																<asp:dropdownlist id="MinutiConduzione" runat="server" width="40px">
																	<asp:ListItem Value="00">00</asp:ListItem>
																	<asp:ListItem Value="15">15</asp:ListItem>
																	<asp:ListItem Value="30">30</asp:ListItem>
																	<asp:ListItem Value="45">45</asp:ListItem>
																</asp:dropdownlist></TD>
														</TR>
													</TABLE>
												</li>
											</ul>
										</div>
										<div id="aseguito2">
											<ul>
												<li>
													<TABLE style="WIDTH: 600px; HEIGHT: 40px" class="BordiCellaR" border="0" cellSpacing="0"
														cellPadding="0" width="448">
														<TR>
															<TD style="WIDTH: 160px"><asp:dropdownlist id="CmbASeguito" runat="server" width="224px"></asp:dropdownlist></TD>
															<TD class="Comm"><span class="blueoverline">DIE</span></TD>
															<TD><asp:textbox id="TxtASeguito1" runat="server" MaxLength="11"></asp:textbox></TD>
															<TD id="data" class="Comm"><span class="blueoverline">Del</span>
															</TD>
															<TD id="lbl"><UC1:CALENDARPICKER id="CPAseguito" runat="server"></UC1:CALENDARPICKER></TD>
														</TR>
													</TABLE>
												</li>
											</ul>
										</div>
										<div id="aseguito3">
											<ul>
												<li>
													<TABLE style="WIDTH: 600px; HEIGHT: 40px" border="0" cellSpacing="0" cellPadding="0" width="448">
														<TR>
															<TD style="WIDTH: 160px" class="sga"><asp:checkbox id="ChkSopralluogo" runat="server" CssClass="blueoverline" Text="Richiesta di sopralluogo e valutazione tecnico economica"></asp:checkbox></SPAN></TD>
															<TD class="SGA"><SPAN class="blueoverline">N░</SPAN>
																<asp:textbox id="TxtSopralluogo" runat="server" MaxLength="11"></asp:textbox></TD>
															<TD class="SGA"><SPAN class="blueoverline">Del</SPAN></TD>
															<TD><UC1:CALENDARPICKER id="CPSopralluogoDie" runat="server"></UC1:CALENDARPICKER></TD>
														</TR>
													</TABLE>
													<TABLE style="WIDTH: 600px; HEIGHT: 40px" id="Table15" class="BordiCellaR" border="0" cellSpacing="0"
														cellPadding="0" width="448">
														<TR>
															<TD style="WIDTH: 160px" class="SGA"><span class="blueoverline">Sopralluogo effettuato 
																	in data</span></TD>
															<TD><UC1:CALENDARPICKER id="CPSopralluogoData" runat="server"></UC1:CALENDARPICKER></TD>
															<TD class="SGA"><span class="blueoverline">Da</span><asp:textbox id="TxtASeguito4" runat="server" MaxLength="61"></asp:textbox></TD>
														</TR>
													</TABLE>
												</li>
											</ul>
										</div>
									</TD>
								</TR>
								<TR>
									<TD class="SGA">
										<div id="aseguito4"><span class="blueoverline">Causa presunta guasto/anomalia</span><asp:textbox id="TxtCausa" runat="server" Width="100%" MaxLength="408" TextMode="MultiLine" Rows="4"
												Height="34px"></asp:textbox></div>
									</TD>
								</TR>
								<TR>
									<TD class="SGA">
										<div id="aseguito5"><span class="blueoverline">Effetto del guasto</span>
											<asp:textbox id="TxtGuasto" runat="server" Width="100%" MaxLength="408" TextMode="MultiLine"
												Rows="4" Height="34px"></asp:textbox></div>
									</TD>
								</TR>
								<tr>
									<td>
										<table style="WIDTH: 344px; HEIGHT: 26px" border="0" cellSpacing="0" cellPadding="0">
											<TR>
												<TD style="WIDTH: 37px">Email:</TD>
												<TD style="WIDTH: 72px" width="72"><asp:checkbox id="chksSendMail" runat="server" Text="[Si/No]"></asp:checkbox>
												<TD width="15%">Destinatari:</TD>
												<TD><asp:textbox id="txtsMittente" runat="server" Width="100%" ToolTip="Gli indirizzi mail devono essere separati da ;"></asp:textbox></TD>
											</TR>
										</table>
									</td>
								</tr>
								<TR>
									<TD>
										<TABLE style="WIDTH: 408px; HEIGHT: 24px" border="0" cellSpacing="0" cellPadding="0" width="408">
											<TR>
												<TD>Richiesta:&nbsp;</TD>
												<TD><UC1:CALENDARPICKER id="CalendarPicker1" runat="server"></UC1:CALENDARPICKER></TD>
												<TD>Ora:</TD>
												<TD><asp:textbox id="txtsorain" runat="server" Width="30px">00</asp:textbox>:
													<asp:textbox id="txtsorainmin" runat="server" Width="30px">00</asp:textbox>&nbsp;</TD>
											</TR>
										</TABLE>
									</TD>
								</TR>
								<TR>
									<TD>
										<div><cc1:s_button id="btnsSalva" tabIndex="2" runat="server" Text="Salva"></cc1:s_button>&nbsp;<asp:button id="cmdReset" CausesValidation="False" Text="Reset" Runat="server"></asp:button>
											<cc1:s_button id="btnsChiudi" runat="server" CausesValidation="False" Text="Chiudi"></cc1:s_button><a 
            class=GuidaLink href="<%= HelpLink %>" target=_blank 
            >Guida</a>
											<asp:customvalidator id="Cv1" runat="server" ControlToValidate="cmbsUrgenza" ClientValidationFunction="ValUrgenza"></asp:customvalidator></div>
									</TD>
								</TR>
								<TR>
									<TD>
										<div><asp:label id="lblFirstAndLast" runat="server"></asp:label>&nbsp;
											<MESSPANEL:MESSAGEPANEL id="PanelMess" runat="server" ErrorIconUrl="~/Images/ico_critical.gif" MessageIconUrl="~/Images/ico_info.gif"></MESSPANEL:MESSAGEPANEL></div>
									</TD>
								</TR>
								<TR>
									<TD>
										<div><asp:validationsummary id="vlsEdit" runat="server" ShowMessageBox="True" DisplayMode="List" ShowSummary="False"></asp:validationsummary></div>
									</TD>
								</TR>
							</TABLE>
						</TD>
					</tr>
				</TBODY>
			</TABLE>
		</form>
	</BODY>
</HTML>
