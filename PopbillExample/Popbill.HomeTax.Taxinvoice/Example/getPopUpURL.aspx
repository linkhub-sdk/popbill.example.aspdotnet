﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="getPopUpURL.aspx.cs" Inherits="Popbill.HomeTax.Taxinvoice.Example.getPopUpURL" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>팝빌 홈택스 세금계산서 매입/매출 조회 API SDK ASP.NET Example</title>
    <link href="../Example.css" rel="stylesheet" type="text/css"/>
</head>
<body>
<div id="content">
    <p class="heading1">Response</p>
    <br/>
    <fieldset class="fieldset1">
        <legend>홈택스 전자세금계산서 팝업 URL</legend>
        <ul>
            <% if (!String.IsNullOrEmpty(code)) { %>
                <li>Response.code : <%= code %> </li>
                <li>Response.message : <%= message %></li>
            <% } else { %>
                <li>url : <%= url %></li>
            <% } %>
        </ul>
    </fieldset>
</div>
</body>
</html>
