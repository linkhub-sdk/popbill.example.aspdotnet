<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="getSendToNTSConfig.aspx.cs" Inherits="Popbill.Taxinvoice.Example.getSendToNTSConfig" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>팝빌 세금계산서 SDK ASP.NET Example</title>
    <link href="../Example.css" rel="stylesheet" type="text/css"/>
</head>
<body>
<div id="content">
    <p class="heading1">Response</p>
    <br/>
    <fieldset class="fieldset1">
        <legend>국세청 전송 옵션 설정 상태 확인</legend>
        <ul>
            <% if (!String.IsNullOrEmpty(code)) { %>
                <li>Response.code : <%= code %> </li>
                <li>Response.message : <%= message %></li>
            <% } else { %>
                <li>sendToNTSConfig : <%= sendToNTSConfig %></li>
                <li>True(발행 즉시 전송) False(익일 자동 전송)</li>
            <% } %>
        </ul>
    </fieldset>
</div>
</body>
</html>
