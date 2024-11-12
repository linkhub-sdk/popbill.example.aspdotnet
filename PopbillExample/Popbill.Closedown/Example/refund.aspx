<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="refund.aspx.cs" Inherits="Popbill.Closedown.Example.refund" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>팝빌 사업자등록상태조회 (휴폐업조회) SDK ASP.NET Example</title>
    <link href="../Example.css" rel="stylesheet" type="text/css"/>
</head>
<body>
<div id="content">
    <p class="heading1">Response</p>
    <br/>
    <fieldset class="fieldset1">
        <legend>연동회원 포인트 환불신청</legend>
        <ul>
            <li>code(응답코드) : <%= code %></li>
            <li>message(응답메시지) : <%= message %></li>
            <% if (!String.IsNullOrEmpty(refundCode))
               { %>
                <li>refundCode(환불코드) : <%= refundCode %></li>
            <% } %>
        </ul>
    </fieldset>
</div>
</body>
</html>
