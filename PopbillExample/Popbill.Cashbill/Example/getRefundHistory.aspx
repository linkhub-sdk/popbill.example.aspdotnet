<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="getRefundHistory.aspx.cs" Inherits="Popbill.Cashbill.Example.getRefundHistory" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>팝빌 예금주조회 SDK ASP.NET Example</title>
    <link href="../Example.css" rel="stylesheet" type="text/css"/>
</head>
<body>
<div id="content">
    <p class="heading1">Response</p>
    <br/>
    <fieldset class="fieldset1">
        <legend>환불 신청 상태 조회</legend>
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

                <% foreach (Popbill.RefundHistory refundHistory in result.list)
                { %>
                    <fieldset class="fieldset2">
                        <legend>환불 내역</legend>
                        <ul>
                            <li>reqDT (신청일시) : <%= refundHistory.reqDT %> </li>
                            <li>requestPoint (환불 신청포인트) : <%= refundHistory.requestPoint %> </li>
                            <li>accountBank (환불계좌 은행명) : <%= refundHistory.accountBank %> </li>
                            <li>accountNum (환불계좌번호) : <%= refundHistory.accountNum %> </li>
                            <li>accountName (환불계좌 예금주명) : <%= refundHistory.accountName %> </li>
                            <li>state (상태): <%= refundHistory.state %> </li>
                            <li>reason (환불사유): <%= refundHistory.reason %> </li>
                        </ul>
                    </fieldset>
                <% } %>
            <% } %>
        </ul>
    </fieldset>
</div>
</body>
</html>
