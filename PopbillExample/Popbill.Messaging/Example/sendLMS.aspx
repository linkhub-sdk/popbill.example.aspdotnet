﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sendLMS.aspx.cs" Inherits="Popbill.Message.Example.sendLMS" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>팝빌 문자 SDK ASP.NET Example</title>
    <link href="../Example.css" rel="stylesheet" type="text/css"/>
</head>
<body>
<div id="content">
    <p class="heading1">Response</p>
    <br/>
    <fieldset class="fieldset1">
        <legend>장문 문자메시지 1건 전송</legend>
        <ul>
            <% if (!String.IsNullOrEmpty(code)) { %>
                <li>Response.code : <%= code %> </li>
                <li>Response.message : <%= message %></li>
            <% } else { %>
                <li>receiptNum(접수번호) : <%= receiptNum %></li>
            <% } %>
        </ul>
    </fieldset>
</div>
</body>
</html>