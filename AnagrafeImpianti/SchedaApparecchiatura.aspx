<%@ Register TagPrefix="cc2" Namespace="Csy.WebControls" Assembly="CsyWebControls" %>
<%@ Page language="c#" Codebehind="SchedaApparecchiatura.aspx.cs" AutoEventWireup="false" Inherits="TheSite.CommonPage.SchedaApparecchiatura" enableViewState="False"%>
<%@ Register TagPrefix="cc1" Namespace="S_Controls" Assembly="S_Controls" %>
<%@ Register TagPrefix="uc1" TagName="PageTitle" Src="../WebControls/PageTitle.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>SchedaApparecchiatura</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<LINK rel="stylesheet" type="text/css" href="../Css/MainSheet.css">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<TABLE id="TableMain" border="0" cellSpacing="0" cellPadding="0" width="100%" align="center">
				<TBODY>
					<TR>
						<TD style="HEIGHT: 50px" align="center"><uc1:pagetitle id="PageTitle1" runat="server"></uc1:pagetitle></TD>
					</TR>
					<TR>
						<TD vAlign="top" align="center">
							<P>&nbsp;
							</P>
							<P></P>
							<asp:panel id="Panel1" runat="server" Width="100%">
								<TABLE id="tblSearch100Dettaglio" border="0" cellSpacing="0" cellPadding="0" width="100%">
									<TR>
										<TD>Codice Componente:</TD>
										<TD>
											<cc1:S_Label id="S_lblcodicecomponente" runat="server"></cc1:S_Label></TD>
										<TD rowSpan="11"><IMG align=right 
            src="PageImage.aspx?<%=Imagename%>&amp;p=y"></TD>
									</TR>
									<TR>
										<TD>Standard Apparecchiatura:</TD>
										<TD>
											<cc1:S_Label id="S_lblstdapparecchiature" runat="server"></cc1:S_Label></TD>
									</TR>
									<TR>
										<TD>Codice Edificio:</TD>
										<TD>
											<cc1:S_Label id="S_lblcodiceedificio" runat="server"></cc1:S_Label></TD>
									</TR>
									<TR>
										<TD>Edificio:</TD>
										<TD>
											<cc1:S_Label id="S_lbledificio" runat="server"></cc1:S_Label></TD>
									</TR>
									<TR>
										<TD>Piano:</TD>
										<TD>
											<cc1:S_Label id="S_lblpiano" runat="server"></cc1:S_Label></TD>
									</TR>
									<TR>
										<TD>Visualizza Stanze del Piano
										</TD>
										<TD><B>
												<P><U>
														<asp:Literal id="LiteralScriptPiano" runat="server"></asp:Literal></U></P>
											</B>
										</TD>
									</TR>
									<TR>
										<TD>Stanza:</TD>
										<TD>
											<cc1:S_Label id="S_lblstanza" runat="server"></cc1:S_Label></TD>
									</TR>
									<TR>
										<TD>Visualizza Apparecchiature Stanza
										</TD>
										<TD><B>
												<P><U>
														<asp:Literal id="LiteralScriptStanza" runat="server"></asp:Literal></U></P>
											</B>
										</TD>
									</TR>
									<TR>
										<TD>Stato:</TD>
										<TD>
											<cc1:S_Label id="S_LblStato" runat="server"></cc1:S_Label></TD>
									</TR>
									<TR>
										<TD>Quantita:</TD>
										<TD>
											<cc1:S_Label id="S_lblqta" runat="server"></cc1:S_Label></TD>
									</TR>
									<TR>
										<TD style="WIDTH: 15%">Macrocomponente:</TD>
										<TD>
											<cc1:S_Label id="S_lbltecnico" runat="server"></cc1:S_Label></TD>
									</TR>
									<TR>
										<TD>Marca:</TD>
										<TD>
											<cc1:S_Label id="S_lblmarca" runat="server"></cc1:S_Label></TD>
									</TR>
									<TR>
										<TD>Modello:</TD>
										<TD>
											<cc1:S_Label id="S_lblmodello" runat="server"></cc1:S_Label></TD>
									</TR>
									<TR>
										<TD>Tipo:</TD>
										<TD>
											<cc1:S_Label id="S_lbltipo" runat="server"></cc1:S_Label></TD>
									</TR>
									<TR>
										<TD>Visualizza Attività
										</TD>
										<TD><B>
												<P><U>
														<asp:Literal id="LiteralScriptAttivita" runat="server"></asp:Literal></U></P>
											</B>
										</TD>
									</TR>
									<TR>
										<TD>Visualizza Documenti Apparato
										</TD>
										<TD><B>
												<P><U>
														<asp:Literal id="LiteralScriptDocumenti" runat="server"></asp:Literal></U></P>
											</B>
										</TD>
									</TR>
								</TABLE>
							</asp:panel>
							<cc2:datapanel id="DatapanelUNI" runat="server" AllowTitleExpandCollapse="True" CollapseImageUrl="../Images/uparrows_trans.gif"
								CssClass="DataPanel75" CollapseText="Espandi/Riduci" ExpandImageUrl="../Images/downarrows_trans.gif"
								ExpandText="Espandi" TitleText="Classificazione UNI " Collapsed="False" TitleStyle-CssClass="TitleSearch">
								<table>
									<TBODY>
										<tr>
											<td>
												Classe Unità Tecnologica
											</td>
											<td>
												<cc1:S_Label id="S_COD_CUT" runat="server"></cc1:S_Label>
											</td>
											<td>
												Descrizione Classe Unità Tecnologica
											</td>
											<td>
												<cc1:S_Label id="S_DESC_CUT" runat="server"></cc1:S_Label>
											</td>
										</tr>
										<tr>
											<td>
												Unità Tecnologica
											</td>
											<td>
												<cc1:S_Label id="S_COD_UT" runat="server"></cc1:S_Label>
											</td>
											<td>
												Descrizione Unità Tecnologica
											</td>
											<td>
												<cc1:S_Label id="S_DESC_UT" runat="server"></cc1:S_Label>
											</td>
										</tr>
					</TR>
					<tr>
						<td>
							Classe Elementi Tecnici
						</td>
						<td>
							<cc1:S_Label id="S_COD_CET" runat="server"></cc1:S_Label>
						</td>
						<td>
							Descrizione Elementi Tecnici
						</td>
						<td>
							<cc1:S_Label id="S_DESC_CET" runat="server"></cc1:S_Label>
						</td>
					</tr>
					<tr>
						<td>
							Codice UNI
						</td>
						<td colspan="3">
							<cc1:S_Label id="S_PRG_UNI" runat="server"></cc1:S_Label>
						</td>
					</tr>
				</TBODY>
			</TABLE>
			</cc2:datapanel>
			<cc2:datapanel id="DataPanelCaratteristiche" runat="server" AllowTitleExpandCollapse="True" CollapseImageUrl="../Images/uparrows_trans.gif"
				CssClass="DataPanel75" CollapseText="Espandi/Riduci" ExpandImageUrl="../Images/downarrows_trans.gif"
				ExpandText="Espandi" TitleText="Caratteristiche Tecniche " Collapsed="False" TitleStyle-CssClass="TitleSearch">
				<asp:datalist id="DataList1" runat="server" Width="100%" RepeatColumns="2" RepeatDirection="Horizontal"
					GridLines="Both" BorderWidth="0px">
					<ItemTemplate>
						<span>
							<%# DataBinder.Eval(Container, "DataItem.tipologia") %>
							:&nbsp;</span> <span>
							<%# DataBinder.Eval(Container, "DataItem.descrizione") %>
							&nbsp;</span>
					</ItemTemplate>
					<HeaderStyle HorizontalAlign="Left"></HeaderStyle>
				</asp:datalist>
			</cc2:datapanel></TD></TR>
			<TR>
				<TD align="left">&nbsp;
					<cc2:datapanel id="DataPanelPassi" runat="server" AllowTitleExpandCollapse="True" CollapseImageUrl="../Images/uparrows_trans.gif"
						CssClass="DataPanel75" CollapseText="Espandi/Riduci" ExpandImageUrl="../Images/downarrows_trans.gif"
						ExpandText="Espandi" TitleText="Manutenzione Generale Apparecchiatura " Collapsed="False" TitleStyle-CssClass="TitleSearch">
						<asp:datalist id="Datalist2" runat="server" Width="100%" RepeatDirection="Horizontal" GridLines="Both"
							BorderWidth="1px" DataKeyField="id">
							<HeaderTemplate>
								<table Width="100%" class="tblSearch100Dettaglio">
									<tr>
										<td>Servizio</td>
										<td>Attivit&#224; MP</td>
										<td>Descrizione</td>
										<td>Frequenza</td>
										<td>Tempo stimato (min)</td>
										<td>Specializzazione Addetto</td>
									</tr>
							</HeaderTemplate>
							<ItemTemplate>
								<tr>
									<td>
										<a runat="server" ID="A1"><img src="../Images/uparrows_trans.gif" runat="server" border="0" id="imageexpand"></a>
										<asp:Label id="Label2" runat="server">
											<%# DataBinder.Eval(Container,"DataItem.pm_group") %>
										</asp:Label></td>
									<td>
										<asp:Label id="Label1" runat="server">
											<%# DataBinder.Eval(Container,"DataItem.pmp_id") %>
										</asp:Label>
									</td>
									<td>
										<asp:Label id="Label3" runat="server">
											<%# DataBinder.Eval(Container,"DataItem.description") %>
										</asp:Label></td>
									<td>
										<asp:Label id="Label4" runat="server">
											<%# DataBinder.Eval(Container,"DataItem.frequenza") %>
										</asp:Label></td>
									<td>
										<asp:Label id="Label5" runat="server">
											<%# DataBinder.Eval(Container,"DataItem.units_hour") %>
										</asp:Label></td>
									<td>
										<asp:Label id="Label6" runat="server">
											<%# DataBinder.Eval(Container,"DataItem.tr_id") %>
										</asp:Label></td>
								</tr>
								<!--<br>-->
								<tr>
									<td colspan="6">
										<div style="display:none;" id="expand" runat="server">
											<asp:Repeater ID="repetarpassi" runat="server">
												<HeaderTemplate>
													<table border="0" width="100%">
												</HeaderTemplate>
												<ItemTemplate>
													<tr valign="middle">
														<td align="right">Passo:
															<%# DataBinder.Eval(Container,"DataItem.passo")%>
														</td>
														<td align="left"><%# DataBinder.Eval(Container,"DataItem.descrizione")%></td>
													</tr>
												</ItemTemplate>
												<FooterTemplate>
													</TABLE>
												</FooterTemplate>
											</asp:Repeater>
										</div>
									</td>
								</tr>
							</ItemTemplate>
							<FooterTemplate>
								</TABLE>
							</FooterTemplate>
						</asp:datalist>
					</cc2:datapanel></TD>
			</TR>
			</TBODY></TABLE>
			<%if(Context.Handler is TheSite.AnagrafeImpianti.NavigazioneApparecchiature){%>
			<table>
				<tr>
					<td><input id="btnh" onclick="javascript:history.back();" value="Indietro" type="button"></td>
				</tr>
			</table>
			<%}else{%>
			<table>
				<tr>
					<td>
						<P><input id="btnclose" onclick="javascript:window.close();" value="Chiudi" type="button"></P>
					</td>
				</tr>
			</table>
			<%}%>
		</form>
		<script language="javascript"> 
function SetStanza(Bl_id,Fl_id,RMid)	{
//document.getElementById('eq_id_sel').value=AppEQ; 
//alert(RMid);  
// alert(RMid == "RM019");
if (RMid=="" || Fl_id=="" || Bl_id=="")
           { 
              alert("Questa Stanza non ha Impianti!");
           }  
           else { 
url = "../AnagrafeImpianti/navigazioneappdemo.aspx?FunId=1&var_bl_id=84&var_piani=165&var_stanza=37747&TitoloStanza=miotitolo&FromWebCad=true";
          url=url.replace("165",Fl_id);
         url=url.replace("84",Bl_id);
         url=url.replace("37747",RMid);
         //alert(url);
 //window.open(url,'_blank','width=800,height=600,location=no,scrollbars=yes');
                window.open(url,'_blank','width=800,height=600,location=no,scrollbars=yes');
           }

}

function fpiano(valuebl,valuePiano, valueRm)
{
//alert(valuebl);
//alert(valuePiano);
//alert(valueRm);
url = "../AnagrafeImpianti/DataRoom.aspx?id_edificio_cad=84&amp;id_piano_cad=165&amp;var_stanza=37748&amp;FromWebCad=true";
         url=url.replace("165",valuePiano);
         url=url.replace("84",valuebl);
         url=url.replace("37748",valueRm);
		 window.open(url,'_blank','width=800,height=600,location=no,scrollbars=yes');
		 
		 //DataRoom.aspx?id_edificio_cad=84&amp;id_piano_cad=165&amp;var_stanza=37748&amp;FromWebCad=true"

}


///  da qui nuove per la definitiva
function cmbSelezione(num,valueEQ)	{
//var valueEQ;
//alert(num);
//valueEQ = document.getElementById('S_lblcodicecomponente').value.toString();
//alert( valueEQ);
 var url;		
if (valueEQ=="" || valueEQ==null  )
{
alert('Selezionare un oggetto dalla pianta prima di aprire la scheda.');
}
else
{
		if (num==1)
		{
	//	window.open('../AnagrafeImpianti/SchedaApparecchiatura.aspx?eq_id=UTA019','_blank','width=800,height=600,location=no,scrollbars=yes');
		 url = "../AnagrafeImpianti/SchedaApparecchiatura.aspx?eq_id=UTA019";
         url=url.replace("UTA019",valueEQ);
		 window.open(url,'_blank','width=800,height=600,location=no,scrollbars=yes');
		}

		if (num==2)
		{
		//window.open('../AnagrafeImpianti/RichiesteApparecchiatura.aspx?eq_id_char=UTA019','_blank','width=800,height=600,location=no,scrollbars=yes');
	     url = "../AnagrafeImpianti/RichiesteApparecchiatura.aspx?eq_id_char=UTA019&FromWebCad=true";
         url=url.replace("UTA019",valueEQ);
		 window.open(url,'_blank','width=800,height=600,location=no,scrollbars=yes');
		}

		if (num==3)
		{
		//window.open('../AnagrafeImpianti/Eq_DocumentiAllegati.aspx?eq_id=UTA019','_blank','width=800,height=600,location=no,scrollbars=yes');
		 url = "../AnagrafeImpianti/Eq_DocumentiAllegati.aspx?eq_id=UTA019&FromWebCad=true";
         url=url.replace("UTA019",valueEQ);
		 window.open(url,'_blank','width=800,height=600,location=no,scrollbars=yes');
		}
  }

}


		</script>
	</body>
</HTML>
