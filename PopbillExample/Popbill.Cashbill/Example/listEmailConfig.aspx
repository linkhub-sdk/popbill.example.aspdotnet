<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="listEmailConfig.aspx.cs" Inherits="Popbill.Cashbill.Example.listEmailConfig" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>팝빌 현금영수증 SDK ASP.NET Example</title>
    <link href="../Example.css" rel="stylesheet" type="text/css" />
</head>
<body>
<div id="content">
    <p class="heading1">Response</p>
    <br/>
    <fieldset class="fieldset1">
        <legend>알림메일 전송목록 조회 </legend>
        <ul>
            <% if (!String.IsNullOrEmpty(code)) { %>
                <li>Response.code : <%=code %> </li>
                <li>Response.message : <%= message %></li>
            <% } else {	%>
                <% foreach (Popbill.EmailConfig info in emailConfigList) { %>
                    <%if (info.emailType == "CSH_ISSUE") { %> <li> CSH_ISSUE (고객에게 현금영수증이 발행 되었음을 알려주는 메일) : <%= info.sendYN%></li> <%} %>
                <% } %>
            <% } %>
        </ul>
    </fieldset>
 </div>
</body>
</html>