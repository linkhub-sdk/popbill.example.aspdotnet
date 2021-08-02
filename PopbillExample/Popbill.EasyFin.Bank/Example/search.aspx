<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="search.aspx.cs" Inherits="Popbill.EasyFin.Bank.Example.search" %>

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
        <legend>계좌 거래내역 목록조회</legend>
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
                <li>lastScrapDT (최종 조회일시) : <%= result.lastScrapDT %> </li>

                <% foreach (Popbill.EasyFin.EasyFinBankSearchDetail tradeInfo in result.list)
                   { %>
                    <fieldset class="fieldset2">
                        <legend>거래내역</legend>
                        <ul>
                            <li>tid (거래내역 아이디) : <%= tradeInfo.tid%></li>
                            <li>trdate (거래일자) : <%= tradeInfo.trdate%></li>
                            <li>trserial (거래일련번호) : <%= tradeInfo.trserial%></li>
                            <li>trdt (거래일시) : <%= tradeInfo.trdt%></li>
                            <li>accIn (입금액) : <%= tradeInfo.accIn%></li>
                            <li>accOut (출금액) : <%= tradeInfo.accOut%></li>
                            <li>balance (잔액) : <%= tradeInfo.balance%></li>
                            <li>remark1 (비고1) : <%= tradeInfo.remark1%></li>
                            <li>remark2 (비고2) : <%= tradeInfo.remark2%></li>
                            <li>remark3 (비고3) : <%= tradeInfo.remark3%></li>
                            <li>memo (메모) : <%= tradeInfo.memo%></li>
                        </ul>
                    </fieldset>
                <% } %>
            <% } %>
        </ul>
    </fieldset>
</div>
</body>
</html>
