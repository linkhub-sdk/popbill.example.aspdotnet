﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="listEmailConfig.aspx.cs" Inherits="Popbill.Taxinvoice.Example.listEmailConfig" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>팝빌 세금계산서 SDK ASP.NET Example</title>
    <link href="../Example.css" rel="stylesheet" type="text/css" />
</head>
<body>
<div id="content">
    <p class="heading1">Response</p>
    <br/>
    <fieldset class="fieldset1">
        <legend>알림메일 전송목록 조회 </legend>
        <ul>
            <% if (!String.IsNullOrEmpty(code)) { %>
                <li>Response.code : <%=code %> </li>
                <li>Response.message : <%= message %></li>
            <% } else {	%>
                <% foreach (Popbill.EmailConfig info in emailConfigList) { %>
                    <%if (info.emailType == "TAX_ISSUE_INVOICER" ) { %> <li> [정발행] TAX_ISSUE_INVOICER (공급자에게 전자세금계산서 발행 메일) : <%= info.sendYN%></li> <%} %>
                    <%if (info.emailType == "TAX_CHECK" ) { %> <li> [정발행] TAX_CHECK (공급자에게 전자세금계산서 수신확인 메일) : <%= info.sendYN%></li> <%} %>
                    <%if (info.emailType == "TAX_CANCEL_ISSUE" ) { %> <li> [정발행] TAX_CANCEL_ISSUE (공급받는자에게 전자세금계산서 발행취소 메일) : <%= info.sendYN%></li> <%} %>
                    <%if (info.emailType == "TAX_REQUEST" ) { %> <li> [역발행] TAX_REQUEST (공급자에게 세금계산서를 발행요청 메일) : <%= info.sendYN%></li> <%} %>
                    <%if (info.emailType == "TAX_CANCEL_REQUEST" ) { %> <li> [역발행] TAX_CANCEL_REQUEST (공급받는자에게 세금계산서 취소 메일) : <%= info.sendYN%></li> <%} %>
                    <%if (info.emailType == "TAX_REFUSE" ) { %> <li> [역발행] TAX_REFUSE (공급받는자에게 세금계산서 거부 메일) : <%= info.sendYN%></li> <%} %>
                    <%if (info.emailType == "TAX_REVERSE_ISSUE" ) { %> <li> [역발행] TAX_REVERSE_ISSUE (공급받는자에게 세금계산서 발행 메일) : <%= info.sendYN%></li> <%} %>
                    <%if (info.emailType == "TAX_TRUST_ISSUE" ) { %> <li> [위수탁발행] TAX_TRUST_ISSUE (공급받는자에게 전자세금계산서 발행 메일) : <%= info.sendYN%></li> <%} %>
                    <%if (info.emailType == "TAX_TRUST_ISSUE_TRUSTEE" ) { %> <li> [위수탁발행] TAX_TRUST_ISSUE_TRUSTEE (수탁자에게 전자세금계산서 발행 메일) : <%= info.sendYN%></li> <%} %>
                    <%if (info.emailType == "TAX_TRUST_ISSUE_INVOICER" ) { %> <li> [위수탁발행] TAX_TRUST_ISSUE_INVOICER (공급자에게 전자세금계산서 발행 메일) : <%= info.sendYN%></li> <%} %>
                    <%if (info.emailType == "TAX_TRUST_CANCEL_ISSUE" ) { %> <li> [위수탁발행] TAX_TRUST_CANCEL_ISSUE (공급받는자에게 전자세금계산서 발행취소 메일) : <%= info.sendYN%></li> <%} %>
                    <%if (info.emailType == "TAX_TRUST_CANCEL_ISSUE_INVOICER" ) { %> <li> [위수탁발행] TAX_TRUST_CANCEL_ISSUE_INVOICER (공급자에게 전자세금계산서 발행취소 메일) : <%= info.sendYN%></li> <%} %>
                    <%if (info.emailType == "TAX_CLOSEDOWN" ) { %> <li> [처리결과] TAX_CLOSEDOWN (거래처의 사업자등록상태(휴폐업) 확인 메일) : <%= info.sendYN%></li> <%} %>
                    <%if (info.emailType == "TAX_NTSFAIL_INVOICER" ) { %> <li> [처리결과] TAX_NTSFAIL_INVOICER (전자세금계산서 국세청 전송실패 안내) : <%= info.sendYN%></li> <%} %>
                    <%if (info.emailType == "ETC_CERT_EXPIRATION" ) { %> <li> [정기발송] ETC_CERT_EXPIRATION (팝빌에서 이용중인 공인인증서의 갱신 메일) : <%= info.sendYN%></li> <%} %>
                <% } %>
            <% } %>
        </ul>
    </fieldset>
 </div>
</body>
</html>
