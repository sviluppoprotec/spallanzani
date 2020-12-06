<%@ Page Language="c#" CodeBehind="Default.aspx.cs" AutoEventWireup="false" Inherits="TheSite._Default" AspCompat="True" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<html>
<head>
    <title><%= TheSite.Classi.Helper.GetApplicationName()%></title>
    <meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
    <meta name="CODE_LANGUAGE" content="C#">
    <meta name="vs_defaultClientScript" content="JavaScript">
    <meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
</head>

<script language="javascript"> 
    //SetApparato('GRF022')
    function SetApparato(AppEQ) {
        // alert(AppEQ);
        // document.getElementById('eq_id_sel').value=AppEQ; 
        var DocUrl = document.URL;
        HostUrl = DocUrl.replace("default.aspx", "").replace("Default.aspx", "");
        //alert(HostUrl);
        //var ele = window.parent.frames['rbottom'].document.getElementById('eq_id_sel');
        //ele.value=AppEQ;
        //alert(ele.value);
        var url;
        if (AppEQ == "" || AppEQ == null) {
            alert('Selezionare un oggetto dalla pianta prima di aprire la scheda.');
        }
        else {
            //	window.open('../AnagrafeImpianti/SchedaApparecchiatura.aspx?eq_id=UTA019','_blank','width=800,height=600,location=no,scrollbars=yes');
            //  url = "http://sir.cofasir.it/ifo/AnagrafeImpianti/SchedaApparecchiatura.aspx?eq_id=IFOVLM_E01_004_PIVE_0005";
            url = "../AnagrafeImpianti/SchedaApparecchiatura.aspx?eq_id=IFOVLM_E01_004_PIVE_0005";
            //  "../AnagrafeImpianti/SchedaApparecchiatura.aspx?eq_id=UTA019";
            url = url.replace("../", HostUrl);
            url = url.replace("IFOVLM_E01_004_PIVE_0005", AppEQ);
            window.open(url, '_blank', 'width=800,height=600,location=no,scrollbars=yes');
        }
    }

    function SetStanza(Bl_id, Fl_id, RMid) {
        var DocUrl = document.URL;
        HostUrl = DocUrl.replace("default.aspx", "").replace("Default.aspx", "");

        var nbl;
        var blParts = Bl_id.split(' ');
        nbl = blParts[1] && blParts[1] || Bl_id;
        /*if(Bl_id!="GAIPO")
        {
        nbl=Bl_id;}
        else
        {nbl="GAIPO"}*/

        url = "../AnagrafeImpianti/navigazioneappdemo.aspx?FunId=1&bl=84&fl=165&rm=37747&TitoloStanza=miotitolo&FromWebCad=true";
        url = url.replace("../", HostUrl);
        url = url.replace("84", nbl);
        url = url.replace("165", Fl_id);
        url = url.replace("37747", RMid);
        //alert(url);
        if (url == "") {
            alert("Questa Stanza non ha Impianti!");
        }
        else {
            //url=url.replace("../","http://sir.cofasir.it/pui/");
            window.open(url, '_blank', 'width=800,height=600,location=no,scrollbars=yes');
        }

    }

    function mio(AppEQ) {
        //AppEQ='GRF022'; 
        alert(AppEQ);
        //  alert('in defsaul');
        //document.getElementById('eq_id_sel').value=AppEQ; 
        url = "../AnagrafeImpianti/SchedaApparecchiatura.aspx?eq_id=UTA019";
        // url=url.replace("UTA019",valueEQ);
        //alert(url);
        window.open(url, '_blank', 'width=800,height=600,location=no,scrollbars=yes');

        SetStanza(AppEQ);

    }

</script>



<frameset cols="162,*" border="0" framespacing="0" frameborder="0">
    <frame name="left" src="<%=url1%>" scrolling="auto" noresize>
    <frame name="rbottom" src="<%=url%>">
    <noframes>
        <pre id="p2">
================================================================
ISTRUZIONI PER IL COMPLETAMENTO DELLA PAGINA CON FRAME CON GERARCHIA NIDIFICATA
1. Aggiungere l'URL della pagina src="" per il frame "left".
2. Aggiungere l'URL della pagina src="" per il frame "rtop".
3. Aggiungere l'URL della pagina src="" per il frame "rbottom".
4. Aggiungere un elemento BASE target="rtop" al tag HEAD della 
	pagina "left", in modo da impostare "rtop" come frame predefinito   
	per la visualizzazione delle pagine a cui fanno riferimento i collegamenti. 
5. Aggiungere un elemento BASE target="rbottom" al tag HEAD della 
	pagina "rtop", in modo da impostare "rbottom" come frame predefinito   
	per la visualizzazione delle pagine a cui fanno riferimento i collegamenti. 
================================================================
</pre>
        <p id="p1">
            Questa pagina HTML con frame visualizza più pagine Web. Per visualizzarla, è 
				necessario un browser che supporti HTML versione 4.0 o successiva.
        </p>
    </noframes>
</frameset>
</html>
