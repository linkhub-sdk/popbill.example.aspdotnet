<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="getContactInfo.aspx.cs" Inherits="Popbill.Fax.Example.getContactInfo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>팝빌 팩스 SDK ASP.NET Example</title>
    <link href="../Example.css" rel="stylesheet" type="text/css"/>
</head>
<body>
<div id="content">
    <p class="heading1">Response</p>
    <br/>
    <fieldset class="fieldset1">
        <legend>담당자 정보 확인</legend>
        <ul>
            <% if (!String.IsNullOrEmpty(code)) { %>
                <li>Response.code : <%= code %> </li>
                <li>Response.message : <%= message %></li>
            <% } else { %>
                <li> id (아이디) : <%= contactInfo.id %></li>
                <li> personName (담당자 성명) : <%= contactInfo.personName %></li>
                <li> tel (담당자 휴대폰) : <%= contactInfo.tel %></li>
                <li> email (담당자 메일) : <%= contactInfo.email %></li>
                <li> regDT (등록일시) : <%= contactInfo.regDT %></li>
                <li> searchRole (권한) : <%= contactInfo.searchRole%></li>
                <li> mgrYN (역할) : <%= contactInfo.mgrYN %></li>
                <li> state (계정상태) : <%= contactInfo.state %></li>
            <% } %>
        </ul>
    </fieldset>
</div>
</body>
</html>
