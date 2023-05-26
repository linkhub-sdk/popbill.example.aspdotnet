<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="getRefundInfo.aspx.cs" Inherits="Popbill.Closedown.Example.getRefundInfo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>팝빌 예금주조회 SDK ASP.NET Example</title>
    <link href="../Example.css" rel="stylesheet" type="text/css"/>
</head>
<body>
<div id="content">
    <p class="heading1">Response</p>
    <br/>
    <fieldset class="fieldset1">
        <legend>환불 신청 상태 조회</legend>
        <ul>
            <% if (!String.IsNullOrEmpty(code)) { %>
                <li>Response.code : <%= code %> </li>
                <li>Response.message : <%= message %></li>
            <% } else { %>
                <li>reqDT : <%= result.reqDT %></li>
                <li>requestPoint : <%= result.requestPoint %></li>
                <li>accountBank : <%= result.accountBank %></li>
                <li>accountNum : <%= result.accountNum %></li>
                <li>accountName : <%= result.accountName %></li>
                <li>state : <%= result.state %></li>
                <li>reason : <%= result.reason %></li>
            <% } %>
        </ul>
    </fieldset>
</div>
</body>
</html>
