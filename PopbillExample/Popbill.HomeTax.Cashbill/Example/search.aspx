<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="search.aspx.cs" Inherits="Popbill.HomeTax.Cashbill.Example.search" %>

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
        <legend>현금영수증 매입/매출 목록조회</legend>
        <ul>
            <% if (!String.IsNullOrEmpty(code)) { %>
                <li>Response.code : <%= code %> </li>
                <li>Response.message : <%= message %></li>
            <% } else { %>
                <li>code (상태코드) : <%= result.code %> </li>
                <li>message (응답메시지) : <%= result.message %> </li>
                <li>total (총 검색결과 건수) : <%= result.total %> </li>
                <li>perPage (페이지당 검색개수) : <%= result.perPage %> </li>
                <li>pageNum (페이지 번호) : <%= result.pageNum %> </li>
                <li>pageCount (페이지 개수) : <%= result.pageCount %> </li>

                <% foreach (Popbill.HomeTax.HTCashbill cashbillInfo in result.list)
                   { %>
                    <fieldset class="fieldset2">
                        <legend>현금영수증 정보</legend>
                        <ul>
                            <li>ntsconfirmNum (국세청 승인번호) : <%= cashbillInfo.ntsconfirmNum %></li>
                            <li>tradeDate (거래일자) : <%= cashbillInfo.tradeDate %></li>
                            <li>tradeDT (거래일시) : <%= cashbillInfo.tradeDT %></li>
                            <li>tradeType (문서형태) : <%= cashbillInfo.tradeType %></li>
                            <li>tradeUsage (거래구분) : <%= cashbillInfo.tradeUsage %></li>
                            <li>totalAmount (거래금액) : <%= cashbillInfo.totalAmount %></li>
                            <li>supplyCost (공급가액) : <%= cashbillInfo.supplyCost %></li>
                            <li>tax (부가세) : <%= cashbillInfo.tax %></li>
                            <li>serviceFee (봉사료) : <%= cashbillInfo.serviceFee %></li>
                            <li>invoiceType (매입/매출) : <%= cashbillInfo.invoiceType %></li>
                            <li>franchiseCorpNum (발행자 사업자번호) : <%= cashbillInfo.franchiseCorpNum %></li>
                            <li>franchiseCorpName (발행자 상호) : <%= cashbillInfo.franchiseCorpName %></li>
                            <li>franchiseCorpType (발행자 사업자유형) : <%= cashbillInfo.franchiseCorpType %></li>
                            <li>identityNum (식별번호) : <%= cashbillInfo.identityNum %></li>
                            <li>identityNumType (식별번호유형) : <%= cashbillInfo.identityNumType %></li>
                            <li>customerName (고객명) : <%= cashbillInfo.customerName %></li>
                            <li>cardOwnerName (카드소유자명) : <%= cashbillInfo.cardOwnerName %></li>
                            <li>deductionType (공제유형) : <%= cashbillInfo.deductionType %></li>
                        </ul>
                    </fieldset>
                <% } %>
            <% } %>
        </ul>
    </fieldset>
</div>
</body>
</html>