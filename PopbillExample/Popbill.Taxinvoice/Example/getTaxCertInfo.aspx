<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="getTaxCertInfo.aspx.cs" Inherits="Popbill.Taxinvoice.Example.getTaxCertInfo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>팝빌 세금계산서 SDK ASP.NET Example</title>
    <link href="../Example.css" rel="stylesheet" type="text/css"/>
</head>
<body>
<div id="content">
    <p class="heading1">Response</p>
    <br/>
    <fieldset class="fieldset1">
        <legend>인증서 정보 확인</legend>
        <ul>
            <% if (!String.IsNullOrEmpty(code)) { %>
                <li>Response.code : <%= code %> </li>
                <li>Response.message : <%= message %></li>
            <% } else { %>
                <li> regDT (등록일시) : <%= TaxinvoiceCertificate.regDT %></li>
                <li> expireDT (만료일시) : <%= TaxinvoiceCertificate.expireDT %></li>
                <li> issuerDN (인증서 발급자 DN) : <%= TaxinvoiceCertificate.issuerDN %></li>
                <li> subjectDN (등록된 인증서 DN) : <%= TaxinvoiceCertificate.subjectDN %></li>
                <li> issuerName (인증서 종류) : <%= TaxinvoiceCertificate.issuerName %></li>
                <li> oid (OID) : <%= TaxinvoiceCertificate.oid %></li>
                <li> regContactName (등록 담당자 성명) : <%= TaxinvoiceCertificate.regContactName %></li>
                <li> regContactID (등록 담당자 아이디) : <%= TaxinvoiceCertificate.regContactID %></li>
                
            <% } %>
        </ul>
    </fieldset>
</div>
</body>
</html>
