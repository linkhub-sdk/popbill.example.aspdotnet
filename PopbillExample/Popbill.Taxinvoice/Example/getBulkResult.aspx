<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="getBulkResult.aspx.cs" Inherits="Popbill.Taxinvoice.Example.getBulkResult" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>팝빌 세금계산서 SDK ASP.NET Example</title>
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
                <li>code (상태코드) : <%= result.code%> </li>
                <li>message (응답메시지) : <%= result.message %> </li>
                <li>submitID (제출아이디) : <%= result.submitID%> </li>
                <li>submitCount (세금계산서 접수 건수) : <%= result.submitCount%> </li>
                <li>successCount (세금계산서 발행 성공 건수) : <%= result.successCount%> </li>
                <li>failCount (세금계산서 발행 실패 건수) : <%= result.failCount%> </li>
                <li>txState (접수상태코드) : <%= result.txState%> </li>
                <li>txResultCode (접수 결과코드) : <%= result.txResultCode%> </li>
                <li>txStartDT (발행처리 시작일시) : <%= result.txStartDT%> </li>
                <li>txEndDT (발행처리 완료일시) : <%= result.txEndDT%> </li>
                <li>receiptDT (접수일시) : <%= result.receiptDT%> </li>
                <li>receiptID (접수아이디) : <%= result.receiptID%> </li>
                <% int i = 1; %>
                <% foreach (Popbill.Taxinvoice.BulkTaxinvoiceIssueResult issueResult in result.issueResult)
                   { %>
                    <fieldset class="fieldset2">
                        <legend>발행결과 [<%= i %>/<%= result.issueResult.Count %>]</legend>
                        <ul>
                            <li>code (응답코드) : <%= issueResult.code%></li>
                            <li>ntsconfirmNum (국세청승인번호) : <%= issueResult.ntsconfirmNum%></li>
                            <li>invoicerMgtKey (공급자 문서번호) : <%= issueResult.invoicerMgtKey%></li>
                            <li>message (응답메시지) : <%= issueResult.message %></li>
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
