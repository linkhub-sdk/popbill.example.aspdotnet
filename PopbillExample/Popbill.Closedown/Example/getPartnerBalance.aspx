<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="getChargeInfo.aspx.cs" Inherits="Popbill.Closedown.Example.getPartnerBalance" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>팝빌 사업자등록상태조회 (휴폐업조회) API SDK ASP.NET Example</title>
    <link href="../Example.css" rel="stylesheet" type="text/css"/>
</head>
<body>
<div id="content">
    <p class="heading1">Response</p>
    <br/>
    <fieldset class="fieldset1">
        <legend>파트너 잔여포인트 확인</legend>
        <ul>
            <% if (!String.IsNullOrEmpty(code)) { %>
                <li>Response.code : <%= code %> </li>
                <li>Response.message : <%= message %></li>
            <% } else { %>
                <li>remainPoint (잔여포인트) : <%= remainPoint %></li>
            <% } %>
        </ul>
    </fieldset>
</div>
</body>
</html>
