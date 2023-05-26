<%@ Page Language="C#" CodeBehind="checkAutoDenyNumber.aspx.cs" Inherits="Popbill.Message.Example.checkAutoDenyNumber" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">

</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>팝빌 문자 SDK ASP.NET Example</title>
    <link href="../Example.css" rel="stylesheet" type="text/css"/>
</head>
<body>
<div id="content">
    <p class="heading1">Response</p>
    <br/>
    <fieldset class="fieldset1">
        <legend>080 번호 확인</legend>
        <ul>
            <% if (!String.IsNullOrEmpty(code)) { %>
                <li>Response.code : <%= code %> </li>
                <li>Response.message : <%= message %></li>
            <% } else { %>
                <li>smsdenyNumber (전용 080 번호) : <%= smsdenyNumber %></li>
                <li>regDT (등록일시) : <%= regDT %></li>
            <% } %>
        </ul>
    </fieldset>
</div>
</body>
</html>