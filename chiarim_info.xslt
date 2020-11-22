<?xml version="1.0" encoding="UTF-8" ?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
<xsl:output indent="yes" omit-xml-declaration="yes" method="xml"/>
    <xsl:template match="data">
     
		<HTML><HEAD>
		<META http-equiv="Content-Type" content="text/html; charset=iso-8859-1"></META>
		<META content="MSHTML 6.00.2900.2627" name="GENERATOR"></META>
		<STYLE>
		</STYLE>
		</HEAD>
		<BODY bgColor="#ffffff">
		<DIV><FONT face="Arial" size="2">
		  Edificio: <b><xsl:value-of select="codedi" /></b> RdL: <b><xsl:value-of select="idrichiesta" /></b>.<br/>
         <b><xsl:value-of select="descrizione" /></b>
         <br/>
         Per ulteriori dettagli si prega di accedere al Sito <a href="http://sir.cofasir.it/ifo">http://sir.cofasir.it/ifo</a>
         <br/>
         Distinti Saluti.
		</FONT></DIV></BODY></HTML>
    </xsl:template>
</xsl:stylesheet>

  