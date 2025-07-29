<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="getBulkResult.aspx.cs" Inherits="Popbill.Cashbill.Example.getBulkResult" %>

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
        <legend>초대량 접수결과 확인</legend>
        <ul>
            <% if (!String.IsNullOrEmpty(code))
               { %>
                <li>Response.code : <%= code %> </li>
                <li>Response.message : <%= message %></li>
            <% } else { %>
                <li>code (응답코드) : <%= result.code%> </li>
                <li>message (응답메시지) : <%= result.message %> </li>
                <li>submitID (제출아이디) : <%= result.submitID%> </li>
                <li>submitCount (현금영수증 접수 건수) : <%= result.submitCount%> </li>
                <li>successCount (현금영수증 발행 성공 건수) : <%= result.successCount%> </li>
                <li>failCount (현금영수증 발행 실패 건수) : <%= result.failCount%> </li>
                <li>txState (접수상태) : <%= result.txState%> </li>
                <li>txResultCode (접수 결과코드) : <%= result.txResultCode%> </li>
                <li>txStartDT (발행처리 시작일시) : <%= result.txStartDT%> </li>
                <li>txEndDT (발행처리 완료일시) : <%= result.txEndDT%> </li>
                <li>receiptDT (접수일시) : <%= result.receiptDT%> </li>
                <li>receiptID (접수아이디) : <%= result.receiptID%> </li>
                
                <% int i = 1; %>
                <% foreach (Popbill.Cashbill.BulkCashbillIssueResult issueResult in result.issueResult)
                   { %>
                    <fieldset class="fieldset2">
                        <legend>발행결과 [<%= i %>/<%= result.issueResult.Count %>]</legend>
                        <ul>
                            <li>code (응답코드) : <%= issueResult.code%></li>
                            <li>message (응답메시지) : <%= issueResult.message%></li>
                            <li>mgtKey (문서번호) : <%= issueResult.mgtKey%></li>
                            <li>confirmNum (국세청승인번호) : <%= issueResult.confirmNum%></li>
                            <li>tradeDate (거래일자) : <%= issueResult.tradeDate%></li>
                            <li>issueDT (발행일시) : <%= issueResult.issueDT%></li>
                        </ul>
                    </fieldset>
                    <% i++; %>
                <% } %>
            <% } %>
        </ul>
    </fieldset>
</div>
</body>
</html>
