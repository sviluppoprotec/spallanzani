<%@ Register TagPrefix="cc2" Namespace="Csy.WebControls" Assembly="CsyWebControls" %>

<%@ Page Language="c#" CodeBehind="SchedaApparecchiatura.aspx.cs" AutoEventWireup="false" Inherits="TheSite.CommonPage.SchedaApparecchiatura" EnableViewState="False" %>

<%@ Register TagPrefix="cc1" Namespace="S_Controls" Assembly="S_Controls" %>
<%@ Register TagPrefix="uc1" TagName="PageTitle" Src="../WebControls/PageTitle.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<html>
<head>
    <title>SchedaApparecchiatura</title>
    <meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
    <meta name="CODE_LANGUAGE" content="C#">
    <meta name="vs_defaultClientScript" content="JavaScript">
    <meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
    <link rel="stylesheet" type="text/css" href="../Css/MainSheet.css">
</head>
<body ms_positioning="GridLayout">
    <form id="Form1" method="post" runat="server">
        <table id="TableMain" border="0" cellspacing="0" cellpadding="0" width="100%" align="center">
            <tbody>
                <tr>
                    <td style="height: 50px" align="center">
                        <uc1:PageTitle ID="PageTitle1" runat="server"></uc1:PageTitle>
                    </td>
                </tr>
                <tr>
                    <td valign="top" align="center">
                        <p>
                            &nbsp;
                        </p>
                        <p></p>
                        <asp:Panel ID="Panel1" runat="server" Width="100%">
                            <table id="tblSearch100Dettaglio" border="0" cellspacing="0" cellpadding="0" width="100%">
                                <tr>
                                    <td>Codice Componente:</td>
                                    <td>
                                        <cc1:S_Label ID="S_lblcodicecomponente" runat="server"></cc1:S_Label></td>
                                    <td rowspan="11">
                                        <img align="right"
                                            src="PageImage.aspx?<%=Imagename%>&amp;p=y"></td>
                                </tr>
                                <tr>
                                    <td>Standard Apparecchiatura:</td>
                                    <td>
                                        <cc1:S_Label ID="S_lblstdapparecchiature" runat="server"></cc1:S_Label></td>
                                </tr>
                                <tr>
                                    <td>Codice Edificio:</td>
                                    <td>
                                        <cc1:S_Label ID="S_lblcodiceedificio" runat="server"></cc1:S_Label></td>
                                </tr>
                                <tr>
                                    <td>Edificio:</td>
                                    <td>
                                        <cc1:S_Label ID="S_lbledificio" runat="server"></cc1:S_Label></td>
                                </tr>
                                <tr>
                                    <td>Piano:</td>
                                    <td>
                                        <cc1:S_Label ID="S_lblpiano" runat="server"></cc1:S_Label></td>
                                </tr>
                                <tr>
                                    <td>Visualizza Stanze del Piano
                                    </td>
                                    <td><b>
                                        <p>
                                            <u>
                                                <asp:Literal ID="LiteralScriptPiano" runat="server"></asp:Literal></u>
                                        </p>
                                    </b>
                                    </td>
                                </tr>
                                <tr>
                                    <td>Stanza:</td>
                                    <td>
                                        <cc1:S_Label ID="S_lblstanza" runat="server"></cc1:S_Label></td>
                                </tr>
                                <tr>
                                    <td>Visualizza Apparecchiature Stanza
                                    </td>
                                    <td><b>
                                        <p>
                                            <u>
                                                <asp:Literal ID="LiteralScriptStanza" runat="server"></asp:Literal></u>
                                        </p>
                                    </b>
                                    </td>
                                </tr>
                                <tr>
                                    <td>Stato:</td>
                                    <td>
                                        <cc1:S_Label ID="S_LblStato" runat="server"></cc1:S_Label></td>
                                </tr>
                                <tr>
                                    <td>Quantita:</td>
                                    <td>
                                        <cc1:S_Label ID="S_lblqta" runat="server"></cc1:S_Label></td>
                                </tr>
                                <tr>
                                    <td style="width: 15%">Macrocomponente:</td>
                                    <td>
                                        <cc1:S_Label ID="S_lbltecnico" runat="server"></cc1:S_Label></td>
                                </tr>
                                <tr>
                                    <td>Marca:</td>
                                    <td>
                                        <cc1:S_Label ID="S_lblmarca" runat="server"></cc1:S_Label></td>
                                </tr>
                                <tr>
                                    <td>Modello:</td>
                                    <td>
                                        <cc1:S_Label ID="S_lblmodello" runat="server"></cc1:S_Label></td>
                                </tr>
                                <tr>
                                    <td>Tipo:</td>
                                    <td>
                                        <cc1:S_Label ID="S_lbltipo" runat="server"></cc1:S_Label></td>
                                </tr>
                                <tr>
                                    <td>Visualizza Attività
                                    </td>
                                    <td><b>
                                        <p>
                                            <u>
                                                <asp:Literal ID="LiteralScriptAttivita" runat="server"></asp:Literal></u>
                                        </p>
                                    </b>
                                    </td>
                                </tr>
                                <tr>
                                    <td>Visualizza Documenti Apparato
                                    </td>
                                    <td><b>
                                        <p>
                                            <u>
                                                <asp:Literal ID="LiteralScriptDocumenti" runat="server"></asp:Literal></u>
                                        </p>
                                    </b>
                                    </td>
                                </tr>
                            </table>
                        </asp:Panel>
                        <cc2:DataPanel ID="DatapanelUNI" runat="server" AllowTitleExpandCollapse="True" CollapseImageUrl="../Images/uparrows_trans.gif"
                            CssClass="DataPanel75" CollapseText="Espandi/Riduci" ExpandImageUrl="../Images/downarrows_trans.gif"
                            ExpandText="Espandi" TitleText="Classificazione UNI " Collapsed="False" TitleStyle-CssClass="TitleSearch">
                            <table>
                                <tbody>
                                    <tr>
                                        <td>Classe Unità Tecnologica
                                        </td>
                                        <td>
                                            <cc1:S_Label ID="S_COD_CUT" runat="server"></cc1:S_Label>
                                        </td>
                                        <td>Descrizione Classe Unità Tecnologica
                                        </td>
                                        <td>
                                            <cc1:S_Label ID="S_DESC_CUT" runat="server"></cc1:S_Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Unità Tecnologica
                                        </td>
                                        <td>
                                            <cc1:S_Label ID="S_COD_UT" runat="server"></cc1:S_Label>
                                        </td>
                                        <td>Descrizione Unità Tecnologica
                                        </td>
                                        <td>
                                            <cc1:S_Label ID="S_DESC_UT" runat="server"></cc1:S_Label>
                                        </td>
                                    </tr>
                </tr>
                <tr>
                    <td>Classe Elementi Tecnici
                    </td>
                    <td>
                        <cc1:S_Label ID="S_COD_CET" runat="server"></cc1:S_Label>
                    </td>
                    <td>Descrizione Elementi Tecnici
                    </td>
                    <td>
                        <cc1:S_Label ID="S_DESC_CET" runat="server"></cc1:S_Label>
                    </td>
                </tr>
                <tr>
                    <td>Codice UNI
                    </td>
                    <td colspan="3">
                        <cc1:S_Label ID="S_PRG_UNI" runat="server"></cc1:S_Label>
                    </td>
                </tr>
            </tbody>
        </table>
        </cc2:datapanel>
			<cc2:DataPanel ID="DataPanelCaratteristiche" runat="server" AllowTitleExpandCollapse="True" CollapseImageUrl="../Images/uparrows_trans.gif"
                CssClass="DataPanel75" CollapseText="Espandi/Riduci" ExpandImageUrl="../Images/downarrows_trans.gif"
                ExpandText="Espandi" TitleText="Caratteristiche Tecniche " Collapsed="False" TitleStyle-CssClass="TitleSearch">
                <asp:DataList ID="DataList1" runat="server" Width="100%" RepeatColumns="2" RepeatDirection="Horizontal"
                    GridLines="Both" BorderWidth="0px">
                    <ItemTemplate>
                        <span>
                            <%# DataBinder.Eval(Container, "DataItem.tipologia") %>
							:&nbsp;</span> <span>
                                <%# DataBinder.Eval(Container, "DataItem.descrizione") %>
							&nbsp;</span>
                    </ItemTemplate>
                    <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                </asp:DataList>
            </cc2:DataPanel>
        </TD></TR>
			<tr>
                <td align="left">&nbsp;
					<cc2:DataPanel ID="DataPanelPassi" runat="server" AllowTitleExpandCollapse="True" CollapseImageUrl="../Images/uparrows_trans.gif"
                        CssClass="DataPanel75" CollapseText="Espandi/Riduci" ExpandImageUrl="../Images/downarrows_trans.gif"
                        ExpandText="Espandi" TitleText="Manutenzione Generale Apparecchiatura " Collapsed="False" TitleStyle-CssClass="TitleSearch">
                        <asp:DataList ID="Datalist2" runat="server" Width="100%" RepeatDirection="Horizontal" GridLines="Both"
                            BorderWidth="1px" DataKeyField="id">
                            <HeaderTemplate>
                                <table width="100%" class="tblSearch100Dettaglio">
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
                                        <a runat="server" id="A1">
                                            <img src="../Images/uparrows_trans.gif" runat="server" border="0" id="imageexpand"></a>
                                        <asp:Label ID="Label2" runat="server">
											<%# DataBinder.Eval(Container,"DataItem.pm_group") %>
                                        </asp:Label></td>
                                    <td>
                                        <asp:Label ID="Label1" runat="server">
											<%# DataBinder.Eval(Container,"DataItem.pmp_id") %>
                                        </asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="Label3" runat="server">
											<%# DataBinder.Eval(Container,"DataItem.description") %>
                                        </asp:Label></td>
                                    <td>
                                        <asp:Label ID="Label4" runat="server">
											<%# DataBinder.Eval(Container,"DataItem.frequenza") %>
                                        </asp:Label></td>
                                    <td>
                                        <asp:Label ID="Label5" runat="server">
											<%# DataBinder.Eval(Container,"DataItem.units_hour") %>
                                        </asp:Label></td>
                                    <td>
                                        <asp:Label ID="Label6" runat="server">
											<%# DataBinder.Eval(Container,"DataItem.tr_id") %>
                                        </asp:Label></td>
                                </tr>
                                <!--<br>-->
                                <tr>
                                    <td colspan="6">
                                        <div style="display: none;" id="expand" runat="server">
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
                        </asp:DataList>
                    </cc2:DataPanel>
                </td>
            </tr>
        </TBODY></TABLE>
			<%if (Context.Handler is TheSite.AnagrafeImpianti.NavigazioneApparecchiature)
                {%>
        <table>
            <tr>
                <td>
                    <input id="btnh" onclick="javascript: history.back();" value="Indietro" type="button"></td>
            </tr>
        </table>
        <%}
        else
        {%>
        <table>
            <tr>
                <td>
                    <p>
                        <input id="btnclose" onclick="javascript: window.close();" value="Chiudi" type="button"></p>
                </td>
            </tr>
        </table>
        <%}%>
    </form>
    <script language="javascript"> 
        function SetStanza(Bl_id, Fl_id, RMid) {
            //document.getElementById('eq_id_sel').value=AppEQ; 
            //alert(RMid);  
            // alert(RMid == "RM019");
            if (RMid == "" || Fl_id == "" || Bl_id == "") {
                alert("Questa Stanza non ha Impianti!");
            }
            else {
                url = "../AnagrafeImpianti/navigazioneappdemo.aspx?FunId=1&var_bl_id=84&var_piani=165&var_stanza=37747&TitoloStanza=miotitolo&FromWebCad=true";
                url = url.replace("165", Fl_id);
                url = url.replace("84", Bl_id);
                url = url.replace("37747", RMid);
                //alert(url);
                //window.open(url,'_blank','width=800,height=600,location=no,scrollbars=yes');
                window.open(url, '_blank', 'width=800,height=600,location=no,scrollbars=yes');
            }

        }

        function fpiano(valuebl, valuePiano, valueRm) {
            //alert(valuebl);
            //alert(valuePiano);
            //alert(valueRm);
            url = "../AnagrafeImpianti/DataRoom.aspx?id_edificio_cad=84&amp;id_piano_cad=165&amp;var_stanza=37748&amp;FromWebCad=true";
            url = url.replace("165", valuePiano);
            url = url.replace("84", valuebl);
            url = url.replace("37748", valueRm);
            window.open(url, '_blank', 'width=800,height=600,location=no,scrollbars=yes');

            //DataRoom.aspx?id_edificio_cad=84&amp;id_piano_cad=165&amp;var_stanza=37748&amp;FromWebCad=true"

        }


        ///  da qui nuove per la definitiva
        function cmbSelezione(num, valueEQ) {
            //var valueEQ;
            //alert(num);
            //valueEQ = document.getElementById('S_lblcodicecomponente').value.toString();
            //alert( valueEQ);
            var url;
            if (valueEQ == "" || valueEQ == null) {
                alert('Selezionare un oggetto dalla pianta prima di aprire la scheda.');
            }
            else {
                if (num == 1) {
                    //	window.open('../AnagrafeImpianti/SchedaApparecchiatura.aspx?eq_id=UTA019','_blank','width=800,height=600,location=no,scrollbars=yes');
                    url = "../AnagrafeImpianti/SchedaApparecchiatura.aspx?eq_id=UTA019";
                    url = url.replace("UTA019", valueEQ);
                    window.open(url, '_blank', 'width=800,height=600,location=no,scrollbars=yes');
                }

                if (num == 2) {
                    //window.open('../AnagrafeImpianti/RichiesteApparecchiatura.aspx?eq_id_char=UTA019','_blank','width=800,height=600,location=no,scrollbars=yes');
                    url = "../AnagrafeImpianti/RichiesteApparecchiatura.aspx?eq_id_char=UTA019&FromWebCad=true";
                    url = url.replace("UTA019", valueEQ);
                    window.open(url, '_blank', 'width=800,height=600,location=no,scrollbars=yes');
                }

                if (num == 3) {
                    //window.open('../AnagrafeImpianti/Eq_DocumentiAllegati.aspx?eq_id=UTA019','_blank','width=800,height=600,location=no,scrollbars=yes');
                    url = "../AnagrafeImpianti/Eq_DocumentiAllegati.aspx?eq_id=UTA019&FromWebCad=true";
                    url = url.replace("UTA019", valueEQ);
                    window.open(url, '_blank', 'width=800,height=600,location=no,scrollbars=yes');
                }
            }

        }


    </script>
</body>
</html>
