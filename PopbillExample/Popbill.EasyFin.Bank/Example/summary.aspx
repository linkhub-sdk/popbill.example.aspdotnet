<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="summary.aspx.cs" Inherits="Popbill.EasyFin.Bank.Example.summary" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>팝빌 계좌조회 API SDK ASP.NET Example</title>
    <link href="../Example.css" rel="stylesheet" type="text/css"/>
</head>
<body>
<div id="content">
    <p class="heading1">Response</p>
    <br/>
    <fieldset class="fieldset1">
        <legend>수집결과 요약정보 확인</legend>
        <ul>
            <% if (!String.IsNullOrEmpty(code)) { %>
                <li>Response.code : <%= code %> </li>
                <li>Response.message : <%= message %></li>
            <% } else { %>
                <li>count (수집 결과 건수) : <%= summaryInfo.count%></li>
                <li>cntAccIn (입금거래 건수) : <%= summaryInfo.cntAccIn%></li>
                <li>cntAccOut (출금거래 건수) : <%= summaryInfo.cntAccOut%></li>
                <li>totalAccIn (입금액 합계) : <%= summaryInfo.totalAccIn%></li>
                <li>totalAccOut (출금액 합계) : <%= summaryInfo.totalAccOut%></li>
            <% } %>
        </ul>
    </fieldset>
</div>
</body>
</html>
