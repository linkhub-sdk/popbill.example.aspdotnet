<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="search.aspx.cs" Inherits="Popbill.Cashbill.Example.search" %>

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
        <legend>현금영수증 목록조회</legend>
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

                <% foreach (Popbill.Cashbill.CashbillInfo cashbillInfo in result.list)
                   { %>
                    <fieldset class="fieldset2">
                        <legend>현금영수증 상태/요약 정보</legend>
                        <ul>
                            <li>itemKey (팝빌 식별번호) : <%= cashbillInfo.itemKey %></li>
                            <li>mgtKey (문서번호) : <%= cashbillInfo.mgtKey %></li>
                            
                            <li>tradeDate (거래일자) : <%= cashbillInfo.tradeDate %></li>
                            <li>tradeDT (거래일시) : <%= cashbillInfo.tradeDT %></li>
                            <li>tradeType (문서형태) : <%= cashbillInfo.tradeType %></li>
                            <li>tradeUsage (거래구분) : <%= cashbillInfo.tradeUsage %></li>
                            <li>tradeOpt (거래유형) : <%= cashbillInfo.tradeOpt %></li>
                            <li>taxationType (과세형태) : <%= cashbillInfo.taxationType %></li>
                            
                            <li>totalAmount (거래금액) : <%= cashbillInfo.totalAmount %></li>
                            <li>supplyCost (공급가액) : <%= cashbillInfo.supplyCost%></li>
                            <li>tax (부가세) : <%= cashbillInfo.tax%></li>
                            <li>serviceFee (봉사료) : <%= cashbillInfo.serviceFee%></li>
                            
                            <li>issueDT (발행일시) : <%= cashbillInfo.issueDT %></li>
                            <li>regDT (등록일시) : <%= cashbillInfo.regDT %></li>
                            
                            <li>stateCode (상태코드) : <%= cashbillInfo.stateCode %></li>
                            <li>stateMemo (상태메모) : <%= cashbillInfo.stateMemo %></li>
                            <li>stateDT (상태변경 일시) : <%= cashbillInfo.stateDT %></li>
                            
                            <li>identityNum (식별번호) : <%= cashbillInfo.identityNum %></li>
                            <li>itemName (주문상품명) : <%= cashbillInfo.itemName %></li>
                            <li>customerName (구매자 성명) : <%= cashbillInfo.customerName %></li>
                            <li>email (구매자 메일) : <%= cashbillInfo.email %></li>
                            <li>hp (구매자 휴대폰) : <%= cashbillInfo.hp %></li>
                            
                            <li>confirmNum (국세청승인번호) : <%= cashbillInfo.confirmNum %></li>
                            <li>orgConfirmNum (당초 승인 현금영수증 국세청승인번호) : <%= cashbillInfo.orgConfirmNum %></li>
                            <li>orgTradeDate (당초 승인 현금영수증 거래일자) : <%= cashbillInfo.orgTradeDate %></li>
                            
                            <li>ntssendDT (국세청 전송일시) : <%= cashbillInfo.ntssendDT %></li>
                            <li>ntsresultDT (국세청 처리결과 수신일시) : <%= cashbillInfo.ntsresultDT %></li>
                            <li>ntsresultCode (국세청 결과코드) : <%= cashbillInfo.ntsresultCode %></li>
                            <li>ntsresultMessage (국세청 결과메시지) : <%= cashbillInfo.ntsresultMessage %></li>
                            <li>printYN (인쇄여부) : <%= cashbillInfo.printYN %></li>
                            <li>interOPYN (연동문서여부) : <%= cashbillInfo.interOPYN %></li>
                        </ul>
                    </fieldset>
                <% } %>
            <% } %>
        </ul>
    </fieldset>
</div>
</body>
</html>