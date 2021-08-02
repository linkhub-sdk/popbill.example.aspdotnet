<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="getDetailInfo.aspx.cs" Inherits="Popbill.Cashbill.Example.getDetailInfo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>팝빌 현금영수증 SDK ASP.NET Example</title>
    <link href="../Example.css" rel="stylesheet" type="text/css"/>
</head>
<body>
<div id="content">
    <p class="heading1">Response</p>
    <br/>
    <fieldset class="fieldset1">
        <legend>현금영수증 상세정보 확인</legend>
        <ul>
            <% if (!String.IsNullOrEmpty(code)) { %>
                <li>Response.code : <%= code %> </li>
                <li>Response.message : <%= message %></li>
            <% } else { %>
                <li>mgtKey (문서번호) : <%= cashbill.mgtKey %></li>
                <li>orgConfirmNum (원본 현금영수증 국세청승인번호) : <%= cashbill.orgConfirmNum %></li>
                <li>orgTradeDate (원본 현금영수증 거래일자) : <%= cashbill.orgTradeDate %></li>
                <li>tradeDate (거래일자) : <%= cashbill.tradeDate %></li>
                <li>tradeType (문서형태) : <%= cashbill.tradeType %></li>
                <li>tradeUsage (거래구분) : <%= cashbill.tradeUsage %></li>
                <li>tradeOpt (거래유형) : <%= cashbill.tradeOpt %></li>
                <li>taxationType (과세형태) : <%= cashbill.taxationType %></li>
                <li>totalAmount (거래금액) : <%= cashbill.totalAmount %></li>
                <li>supplyCost (공급가액) : <%= cashbill.supplyCost %></li>
                <li>tax (부가세) : <%= cashbill.tax %></li>
                <li>serviceFee (봉사료) : <%= cashbill.serviceFee %></li>
                <li>franchiseCorpNum (가맹점 사업자번호) : <%= cashbill.franchiseCorpNum %></li>
                <li>franchiseCorpName (가맹점 상호) : <%= cashbill.franchiseCorpName %></li>
                <li>franchiseCEOName (가맹점 대표자 성명) : <%= cashbill.franchiseCEOName %></li>
                <li>franchiseAddr (가맹점 주소) : <%= cashbill.franchiseAddr %></li>
                <li>franchiseTEL (가맹점 전화번호) : <%= cashbill.franchiseTEL %></li>
                <li>identityNum (식별번호) : <%= cashbill.identityNum %></li>
                <li>customerName (주문자명) : <%= cashbill.customerName %></li>
                <li>itemName (주문상품명) : <%= cashbill.itemName %></li>
                <li>orderNumber (주문번호) : <%= cashbill.orderNumber %></li>
                <li>email (주문자 이메일) : <%= cashbill.email %></li>
                <li>hp (주문자 휴대폰번호) : <%= cashbill.hp %></li>
                <li>smssendYN (알림문자 전송여부) : <%= cashbill.smssendYN %></li>
                <li>cancelType (취소사유) : <%= cashbill.cancelType %></li>
            <% } %>
        </ul>
    </fieldset>
</div>
</body>
</html>
