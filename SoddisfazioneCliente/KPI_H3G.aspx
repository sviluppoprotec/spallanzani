<%@ Page language="c#" Codebehind="KPI_H3G.aspx.cs" AutoEventWireup="false" Inherits="TheSite.SoddisfazioneCliente.KPI_H3G" %>
<%@ Register TagPrefix="uc1" TagName="PageTitle" Src="../WebControls/PageTitle.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>KPI_H3G</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<link href="../Css/MainSheet.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<TABLE id="tb1" style="Z-INDEX: 101; LEFT: 8px; POSITION: absolute; TOP: 8px" cellSpacing="1"
				cellPadding="1" width="100%" border="0">
				<TR>
					<TD align="center"><uc1:pagetitle id="PageTitle1" runat="server"></uc1:pagetitle></TD>
				</TR>
				<TR>
					<TD>
						<div><fieldset><legend>Tempi di Intervento</legend>
								<div>&nbsp;</div>
								<div>Mese:&nbsp;<asp:DropDownList ID="drMese1" Runat="server">
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
									</asp:DropDownList>
									&nbsp; Anno:&nbsp;<asp:DropDownList ID="drAnno1" Runat="server"></asp:DropDownList>
									&nbsp;<asp:Button Runat="server" ID="bt1" Text="Download Tempi Intervento" Width="280px"></asp:Button>
								</div>
							</fieldset>
						</div>
						<div>&nbsp;</div>
						<div>
							<fieldset><legend>Tempi di Intervento Porte REI - Estintori</legend>
								<div>&nbsp;</div>
								<div>Mese:&nbsp;<asp:DropDownList ID="drMese2" Runat="server">
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
									</asp:DropDownList>
									&nbsp; Anno:&nbsp;<asp:DropDownList ID="drAnno2" Runat="server"></asp:DropDownList>
									&nbsp;<asp:Button Runat="server" ID="bt2" Text="Download Tempi Rei - Estintori" Width="280px"></asp:Button>
								</div>
							</fieldset>
						</div>
						<div>&nbsp;</div>
						<div>
							<fieldset><legend>Attività Programmi Manutenzione</legend>
								<div>&nbsp;</div>
								<div>Mese:&nbsp;<asp:DropDownList ID="drMese3" Runat="server">
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
									</asp:DropDownList>
									&nbsp; Anno:&nbsp;<asp:DropDownList ID="drAnno3" Runat="server"></asp:DropDownList>
									&nbsp;<asp:Button Runat="server" ID="bt3" Text="Download Attività P. Manutenzione" Width="280px"></asp:Button>
								</div>
							</fieldset>
						</div>
						<div>
							<fieldset><legend>Estrazione Attività</legend>
								<div>&nbsp;</div>
								<div>
									Procedura&nbsp;<asp:DropDownList ID="DrProcedura" Runat="server"></asp:DropDownList>
									Edificio&nbsp;<asp:DropDownList ID="DrEdi" Runat="server"></asp:DropDownList>
									Mese:&nbsp;<asp:DropDownList ID="DrMese4" Runat="server">
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
									</asp:DropDownList>
									&nbsp; Anno:&nbsp;<asp:DropDownList ID="DrAnno4" Runat="server"></asp:DropDownList>
									&nbsp;<asp:Button Runat="server" ID="bt4" Text="Download Attività" Width="120px"></asp:Button>
								</div>
							</fieldset>
						</div>
					</TD>
				</TR>
			</TABLE>
		</form>
	</body>
</HTML>
