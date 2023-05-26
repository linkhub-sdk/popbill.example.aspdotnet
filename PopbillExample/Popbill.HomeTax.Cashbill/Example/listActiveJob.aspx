<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="listActiveJob.aspx.cs" Inherits="Popbill.HomeTax.cashbill.Example.listActiveJob" %>

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
        <legend>수집 상태 목록 확인</legend>
        <ul>
            <% if (!String.IsNullOrEmpty(code)) { %>
                <li>Response.code : <%= code %> </li>
                <li>Response.message : <%= message %></li>
            <% } else { %>
                <% foreach (Popbill.HomeTax.HTCashbillJobState jobState in jobStateList)
                   { %>
                    <fieldset class="fieldset2">
                        <legend>수집 상태</legend>
                        <ul>
                            <li>jobID (작업 아이디) : <%= jobState.jobID %></li>
                            <li>jobState (수집상태) : <%= jobState.jobState %></li>
                            <li>queryType (수집유형) : <%= jobState.queryType %></li>
                            <li>queryDateType (일자유형) : <%= jobState.queryDateType %></li>
                            <li>queryStDate (시작일자) : <%= jobState.queryStDate %></li>
                            <li>queryEnDate (종료일자) : <%= jobState.queryEnDate %></li>
                            <li>errorCode (오류코드) : <%= jobState.errorCode %></li>
                            <li>errorReason (오류메시지) : <%= jobState.errorReason %></li>
                            <li>jobStartDT (작업 시작일시) : <%= jobState.jobStartDT %></li>
                            <li>jobEndDT (작업 종료일시) : <%= jobState.jobEndDT %></li>
                            <li>collectCount (수집개수) : <%= jobState.collectCount %></li>
                            <li>regDT (수집 요청일시) : <%= jobState.regDT %></li>
                        </ul>
                    </fieldset>
                <% } %>
            <% } %>
        </ul>
    </fieldset>
</div>
</body>
</html>
