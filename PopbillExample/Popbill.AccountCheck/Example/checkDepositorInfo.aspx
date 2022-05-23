﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="checkDepositorInfo.aspx.cs" Inherits="Popbill.AccountCheck.Example.checkDepositorInfo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>팝빌 예금주조회 API SDK ASP.NET Example</title>
    <link href="../Example.css" rel="stylesheet" type="text/css"/>
</head>
<body>
<div id="content">
    <p class="heading1">Response</p>
    <br/>
    <fieldset class="fieldset1">
        <legend>계좌실명조회</legend>
        <ul>
            <% if (!String.IsNullOrEmpty(code)) { %>
                <li>Response.code : <%= code %> </li>
                <li>Response.message : <%= message %></li>
            <% } else { %>
                <li>result (응답코드) : <%= result.result %></li>
                <li>resultMessage (응답메시지) : <%= result.resultMessage %></li>
                <li>accountName (예금주 성명) : <%= result.accountName %></li>
                <li>bankCode (기관코드) : <%= result.bankCode %></li>
                <li>accountNumber (계좌번호) : <%= result.accountNumber %></li>
                <li>identityNumType (등록번호 유형) : <%= result.identityNumType%></li>
                <li>identityNum (등록번호) : <%= result.identityNum%></li>
                <li>checkDate (확인일시) : <%= result.checkDate %></li>
            <% } %>
        </ul>
    </fieldset>
</div>
</body>
</html>