﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="checkID.aspx.cs" Inherits="Popbill.AccountCheck.Example.checkID" %>

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
        <legend>팝빌 회원아이디 중복 확인</legend>
        <ul>
            <li>Response.code : <%= code %></li>
            <li>Response.message : <%= message %></li>
        </ul>
    </fieldset>
</div>
</body>
</html>