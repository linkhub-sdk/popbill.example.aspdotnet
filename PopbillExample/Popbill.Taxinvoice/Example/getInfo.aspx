﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="getInfo.aspx.cs" Inherits="Popbill.Taxinvoice.Example.getInfo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>팝빌 세금계산서 SDK ASP.NET Example</title>
    <link href="../Example.css" rel="stylesheet" type="text/css"/>
</head>
<body>
<div id="content">
    <p class="heading1">Response</p>
    <br/>
    <fieldset class="fieldset1">
        <legend>세금계산서 상태/요약정보 확인 - 단건</legend>
        <ul>
            <% if (!String.IsNullOrEmpty(code)) { %>
                <li>Response.code : <%= code %> </li>
                <li>Response.message : <%= message %></li>
            <% } else { %>
                <li>itemKey (팝빌번호) : <%= taxinvoiceInfo.itemKey %></li>
                <li>taxType (과세형태) : <%= taxinvoiceInfo.taxType %></li>
                <li>writeDate (작성일자) : <%= taxinvoiceInfo.writeDate %></li>
                <li>regDT (임시저장 일자) : <%= taxinvoiceInfo.regDT %></li>
                <li>issueType (발행형태) : <%= taxinvoiceInfo.issueType %></li>
                <li>supplyCostTotal (공급가액 합계): <%= taxinvoiceInfo.supplyCostTotal %></li>
                <li>taxTotal (세액 합계) : <%= taxinvoiceInfo.taxTotal %></li>
                <li>purposeType (영수/청구) : <%= taxinvoiceInfo.purposeType %></li>
                
                <li>issueDT (발행일시) : <%= taxinvoiceInfo.issueDT %></li>
                <li>lateIssueYN (지연발행 여부) : <%= taxinvoiceInfo.lateIssueYN %></li>
                <li>openYN (개봉 여부) : <%= taxinvoiceInfo.openYN %></li>
                <li>openDT (개봉 일시) : <%= taxinvoiceInfo.openDT %></li>
                <li>stateMemo (상태메모) : <%= taxinvoiceInfo.stateMemo %></li>
                <li>stateCode (상태코드) : <%= taxinvoiceInfo.stateCode %></li>
                <li>stateDT (상태변경일시) : <%= taxinvoiceInfo.stateDT %></li>
                
                <li>ntsconfirmNum (국세청승인번호) : <%= taxinvoiceInfo.ntsconfirmNum %></li>
                <li>ntsresult (국세청 전송결과) : <%= taxinvoiceInfo.ntsresult %></li>
                <li>ntssendDT (국세청 전송일시) : <%= taxinvoiceInfo.ntssendDT %></li>
                <li>ntsresultDT (국세청 결과 수신일시) : <%= taxinvoiceInfo.ntsresultDT %></li>
                <li>ntssendErrCode (국세청 결과코드) : <%= taxinvoiceInfo.ntssendErrCode %></li>
                <li>modifyCode (수정 사유코드) : <%= taxinvoiceInfo.modifyCode %></li>
                <li>interOPYN (연동문서 여부) : <%= taxinvoiceInfo.interOPYN %></li>
                
                <li>invoicerCorpName (공급자 상호) : <%= taxinvoiceInfo.invoicerCorpName %></li>
                <li>invoicerCorpNum (공급자 사업자번호) : <%= taxinvoiceInfo.invoicerCorpNum %></li>
                <li>invoicerMgtKey (공급자 문서번호) : <%= taxinvoiceInfo.invoicerMgtKey %></li>
                <li>invoicerPrintYN (공급자 인쇄여부) : <%= taxinvoiceInfo.invoicerPrintYN %></li>
                
                <li>invoiceeCorpName (공급받는자 상호) : <%= taxinvoiceInfo.invoiceeCorpName %></li>
                <li>invoiceeCorpNum (공급받는자 사업자번호) : <%= taxinvoiceInfo.invoiceeCorpNum %></li>
                <li>invoiceeMgtKey (공급받는자 문서번호) : <%= taxinvoiceInfo.invoiceeMgtKey %></li>
                <li>invoiceePrintYN (공급받는자 인쇄여부) : <%= taxinvoiceInfo.invoiceePrintYN %></li>
                <li>closeDownState (공급받는자 휴폐업상태) : <%= taxinvoiceInfo.closeDownState %></li>
                <li>closeDownStateDate (공급받는자 휴폐업일자) : <%= taxinvoiceInfo.closeDownStateDate %></li>
            <% } %>
        </ul>
    </fieldset>
</div>
</body>
</html>
