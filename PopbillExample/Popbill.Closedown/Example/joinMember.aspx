﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="joinMember.aspx.cs" Inherits="Popbill.Closedown.Example.joinMember" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>팝빌 사업자등록상태조회 (휴폐업조회) API SDK ASP.NET Example</title>
    <link href="../Example.css" rel="stylesheet" type="text/css"/>
</head>
<body>
<div id="content">
    <p class="heading1">Response</p>
    <br/>
    <fieldset class="fieldset1">
        <legend>연동회원 가입</legend>
        <ul>
            <li>Response.code : <%= code %></li>
            <li>Response.message :<%= message %></li>
        </ul>
    </fieldset>
</div>
</body>
</html>
