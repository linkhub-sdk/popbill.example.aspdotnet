<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="getLogs.aspx.cs" Inherits="Popbill.Statement.Example.getLogs" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>팝빌 전자명세서 SDK ASP.NET Example</title>
    <link href="../Example.css" rel="stylesheet" type="text/css"/>
</head>
<body>
<div id="content">
    <p class="heading1">Response</p>
    <br/>
    <fieldset class="fieldset1">
        <legend>전자명세서 상태변경 이력</legend>
        <ul>
            <% if (!String.IsNullOrEmpty(code)) { %>
                <li>Response.code : <%= code %> </li>
                <li>Response.message : <%= message %></li>
            <% } else { %>
                <% foreach (Popbill.Statement.StatementLog logInfo in logList)
                   { %>
                    <fieldset class="fieldset2">
                        <legend>전자명세서 상태변경 이력</legend>
                        <ul>
                            <li>docLogType (로그타입) : <%= logInfo.docLogType %></li>
                            <li>log (이력정보) : <%= logInfo.log %></li>
                            <li>procType (처리형태) : <%= logInfo.procType %></li>
                            <li>procCorpName (처리담당자) : <%= logInfo.procCorpName %></li>
                            <li>procMemo (처리메모) : <%= logInfo.procMemo %></li>
                            <li>regDT (등록일시) : <%= logInfo.regDT %></li>
                            <li>ip (아이피) : <%= logInfo.ip %></li>
                        </ul>
                    </fieldset>
                <% } %>
            <% } %>
        </ul>
    </fieldset>
</div>
</body>
</html>
