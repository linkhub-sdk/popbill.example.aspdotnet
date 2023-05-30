<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="quitMember.aspx.cs" Inherits="Popbill.EasyFin.Bank.Example.quitMember" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>팝빌 계좌조회 SDK ASP.NET Example</title>
    <link href="../Example.css" rel="stylesheet" type="text/css"/>
</head>
<body>
<div id="content">
    <p class="heading1">Response</p>
    <br/>
    <fieldset class="fieldset1">
        <legend>팝빌 회원 탈퇴</legend>
        <ul>
            <li>code (응답코드) : <%= code %> </li>
            <li>message (응답메시지) : <%= message %> </li>
        </ul>
    </fieldset>
</div>
</body>
</html>