﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registIssue.aspx.cs" Inherits="Popbill.Taxinvoice.Example.registIssue" %>

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
        <legend>전자세금계산서 즉시발행</legend>
        <ul>
            <li>응답코드 (code)  : <%= code %></li>
            <li>응답메시지 (message) : <%= message %></li>
            <% if (!String.IsNullOrEmpty(ntsConfirmNum))      { %>
                <li>국세청승인번호 (ntsConfirmNum) : <%= ntsConfirmNum%></li>
            <% }  %>
        </ul>
    </fieldset>
</div>
</body>
</html>
