<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="getPaymentHistory.aspx.cs" Inherits="Popbill.AccountCheck.Example.getPaymentHistory" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>팝빌 기업정보조회 SDK ASP.NET Example</title>
    <link href="../Example.css" rel="stylesheet" type="text/css"/>
</head>
<body>
<div id="content">
    <p class="heading1">Response</p>
    <br/>
    <fieldset class="fieldset1">
        <legend>연동회원 포인트 결제내역 확인</legend>
        <ul>
            <% if (!String.IsNullOrEmpty(code)) { %>
                <li>Response.code : <%= code %> </li>
                <li>Response.message : <%= message %></li>
            <% } else { %>
                <li>code (응답코드) : <%= result.code %></li>
                <li>total (총 검색결과 건수) : <%= result.total %></li>
                <li>perPage (페이지당 검색개수) : <%= result.perPage %></li>
                <li>pageNum (페이지 번호) : <%= result.pageNum %></li>
                <li>pageCount (페이지 개수) : <%= result.pageCount %></li>

                <% foreach (Popbill.PaymentHistory paymentHistory in result.list)
                { %>
                    <fieldset class="fieldset2">
                        <legend>사용 내역</legend>
                        <ul>
                            <li>productType (결제 내용) : <%= paymentHistory.productType %> </li>
                            <li>productName (포인트 증감 유형) : <%= paymentHistory.productName %> </li>
                            <li>settleType (결제유형) : <%= paymentHistory.settleType %> </li>
                            <li>settlerName (담당자명) : <%= paymentHistory.settlerName %> </li>
                            <li>settlerEmail (담당자메일) : <%= paymentHistory.settlerEmail %> </li>
                            <li>settleCost (결제금액): <%= paymentHistory.settleCost %> </li>
                            <li>settlePoint (충전포인트): <%= paymentHistory.settlePoint %> </li>
                            <li>settleState (결제상태): <%= paymentHistory.settleState %> </li>
                            <li>regDT (등록일시): <%= paymentHistory.regDT %> </li>
                            <li>stateDT (상태일시): <%= paymentHistory.stateDT %> </li>
                        </ul>
                    </fieldset>
                <% } %>
            <% } %>
        </ul>
    </fieldset>
</div>
</body>
</html>