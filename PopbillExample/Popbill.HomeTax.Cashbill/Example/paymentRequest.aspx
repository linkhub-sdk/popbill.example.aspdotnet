﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="paymentRequest.aspx.cs" Inherits="Popbill.HomeTax.Cashbill.Example.paymentRequest" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>팝빌 홈택스 현금영수증 SDK ASP.NET Example</title>
    <link href="../Example.css" rel="stylesheet" type="text/css"/>
</head>
<body>
<div id="content">
    <p class="heading1">Response</p>
    <br/>
    <fieldset class="fieldset1">
        <legend>연동회원 무통장 입금신청</legend>
        <ul>
            <li>code (응답코드) : <%= code %> </li>
            <li>message (응답메시지) : <%= message %> </li>
            <% if (!String.IsNullOrEmpty(settleCode))
               { %>
                   <li>settleCode (정산코드) : <%= settleCode %> </li>
            <% } %>
        </ul>
    </fieldset>
</div>
</body>
</html>