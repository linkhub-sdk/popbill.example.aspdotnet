<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="summary.aspx.cs" Inherits="Popbill.HomeTax.Cashbill.Example.summary" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>팝빌 홈택스 현금영수증 매입/매출 조회 API SDK ASP.NET Example</title>
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
                <li>count (수집 결과 건수) : <%= summaryInfo.count %></li>
                <li>supplyCostTotal (공급가액 합계) : <%= summaryInfo.supplyCostTotal %></li>
                <li>taxTotal (세액 합계) : <%= summaryInfo.taxTotal %></li>
                <li>serviceFeeTotal (봉사료 합계) : <%= summaryInfo.serviceFeeTotal %></li>
                <li>amountTotal (합계 금액) : <%= summaryInfo.amountTotal %></li>
            <% } %>
        </ul>
    </fieldset>
</div>
</body>
</html>
