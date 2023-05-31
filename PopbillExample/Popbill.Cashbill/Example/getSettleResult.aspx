<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="getSettleResult.aspx.cs" Inherits="Popbill.Cashbill.Example.getSettleResult" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>팝빌 현금영수증 SDK ASP.NET Example</title>
    <link href="../Example.css" rel="stylesheet" type="text/css"/>
</head>
<body>
<div id="content">
    <p class="heading1">Response</p>
    <br/>
    <fieldset class="fieldset1">
        <legend>연동회원 무통장 입금신청 정보확인</legend>
        <ul>
            <% if (!String.IsNullOrEmpty(code)) { %>
                <li>Response.code : <%= code %> </li>
                <li>Response.message : <%= message %></li>
            <% } else { %>
                <li>productType (결제 내용) : <%= result.productType %> </li>
                <li>productName (결제 상품명): <%= paymentHistory.productName %> </li>
                <li>settleType (결제유형) : <%= result.settleType %> </li>
                <li>settlerName (담당자명) : <%= result.settlerName %> </li>
                <li>settlerEmail (담당자메일) : <%= result.settlerEmail %> </li>
                <li>settleCost (결제금액): <%= result.settleCost %> </li>
                <li>settlePoint (충전포인트): <%= result.settlePoint %> </li>
                <li>settleState (결제상태): <%= result.settleState %> </li>
                <li>regDT (등록일시): <%= result.regDT %> </li>
                <li>stateDT (상태일시): <%= result.stateDT %> </li>
            <% } %>
        </ul>
    </fieldset>
</div>
</body>
</html>