﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="checkCertValidation.aspx.cs" Inherits="Popbill.HomeTax.Cashbill.Example.checkCertValidation" %>

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
        <legend>홈택스 공인인증서 로그인 테스트</legend>
        <ul>
            <li>Response.code : <%= code %></li>
            <li>Response.message : <%= message %></li>
        </ul>
    </fieldset>
</div>
</body>
</html>

