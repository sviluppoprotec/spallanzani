<%@ Register TagPrefix="uc1" TagName="PageTitle" Src="../WebControls/PageTitle.ascx" %>
<%@ Register TagPrefix="cc2" Namespace="Csy.WebControls" Assembly="CsyWebControls" %>
<%@ Register TagPrefix="uc1" TagName="CodiceApparecchiature" Src="../WebControls/CodiceApparecchiature.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Addetti" Src="../WebControls/Addetti.ascx" %>
<%@ Register TagPrefix="uc1" TagName="GridTitle" Src="../WebControls/GridTitle.ascx" %>
<%@ Register TagPrefix="uc1" TagName="RicercaModulo" Src="../WebControls/RicercaModulo.ascx" %>
<%@ Register TagPrefix="cc1" Namespace="S_Controls" Assembly="S_Controls" %>
<%@ Page language="c#" Codebehind="SfogliaMP.aspx.cs" AutoEventWireup="false" Inherits="TheSite.ManutenzioneProgrammata.SfogliaMP" %>
<%@ Register TagPrefix="uc1" TagName="CalendarPicker" Src="../WebControls/CalendarPicker.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>SfogliaMP</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="../Css/MainSheet.css" type="text/css" rel="stylesheet">
		<SCRIPT language="javascript">
		var NS4 = (navigator.appName == "Netscape" && parseInt(navigator.appVersion) < 5);
		var NSX = (navigator.appName == "Netscape");
		var IE4 = (document.all) ? true : false;
		
			if(self.location==top.location){
			location.href="Default.aspx";
			}
			
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
		</SCRIPT>
	</HEAD>
	<body onbeforeunload="parent.left.valorizza()" MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<TABLE id="Table1" style="Z-INDEX: 101; POSITION: absolute; TOP: 0px; LEFT: 0px" cellSpacing="1"
				cellPadding="1" width="100%" border="0">
				<TR>
					<TD align="center"><uc1:pagetitle id="PageTitle1" runat="server"></uc1:pagetitle></TD>
				</TR>
				<TR>
					<TD><cc2:datapanel id="DataPanel1" runat="server" AllowTitleExpandCollapse="True" CollapseImageUrl="../Images/up.gif"
							CssClass="DataPanel75" CollapseText="Riduci" ExpandImageUrl="../Images/down.gif" ExpandText="Espandi"
							TitleText="Ricerca" Collapsed="False" TitleStyle-CssClass="TitleSearch">
							<TABLE id="tblSearch100" border="0" cellSpacing="1" cellPadding="1" width="100%">
								<TR>
									<TD colSpan="4">
										<uc1:ricercamodulo id="RicercaModulo1" runat="server"></uc1:ricercamodulo></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 15%; HEIGHT: 21px">&nbsp;Data Da:</TD>
									<TD style="WIDTH: 305px; HEIGHT: 21px">
										<uc1:CalendarPicker id="CalendarPicker1" runat="server"></uc1:CalendarPicker></TD>
									<TD style="WIDTH: 75px; HEIGHT: 21px">Data&nbsp;A:</TD>
									<TD style="HEIGHT: 21px">
										<uc1:CalendarPicker id="CalendarPicker2" runat="server"></uc1:CalendarPicker></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 15%; HEIGHT: 22px">Servizio:</TD>
									<TD style="WIDTH: 305px; HEIGHT: 22px">
										<cc1:s_combobox id="cmbsServizio" runat="server" Width="320px" DBDataType="Integer" DBIndex="6"
											DBParameterName="p_Servizio" DBDirection="Input" DBSize="5"></cc1:s_combobox></TD>
									<TD style="WIDTH: 75px; HEIGHT: 22px"></TD>
									<TD style="HEIGHT: 22px"></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 15%; HEIGHT: 22px">Standard Apparecchiature:</TD>
									<TD style="WIDTH: 305px; HEIGHT: 22px">
										<cc1:s_combobox id="cmbsStdApparecchiature" runat="server" Width="320px" DBDataType="Integer" DBIndex="6"
											DBParameterName="p_Servizio" DBDirection="Input" DBSize="5"></cc1:s_combobox></TD>
									<TD style="WIDTH: 75px; HEIGHT: 22px"></TD>
									<TD style="HEIGHT: 22px"></TD>
								</TR>
								<TR>
									<TD colSpan="4">
										<uc1:CodiceApparecchiature id="CodiceApparecchiature1" runat="server"></uc1:CodiceApparecchiature></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 15%" colSpan="4">
										<TABLE style="WIDTH: 392px; HEIGHT: 39px" id="Table2" border="0" cellSpacing="1" cellPadding="1"
											width="392">
											<TR>
												<TD style="WIDTH: 104px">
													<cc1:S_Button id="btRicerca" runat="server" CssClass="btn" Width="96px" Text="Ricerca"></cc1:S_Button></TD>
												<TD></TD>
												<TD>
													<cc1:S_Button id="btReset" runat="server" CssClass="btn" Width="96px" Text="Reset"></cc1:S_Button>&nbsp;
												</TD>
											</TR>
										</TABLE>
									</TD>
								</TR>
							</TABLE>
						</cc2:datapanel></TD>
				</TR>
				<TR>
					<TD></TD>
				</TR>
			</TABLE>
		</form>
		<script language="javascript">parent.left.calcola();</script>
	</body>
</HTML>
