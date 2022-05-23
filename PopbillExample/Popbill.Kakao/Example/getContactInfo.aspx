<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="getContactInfo.aspx.cs" Inherits="Popbill.Kakao.Example.getContactInfo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<<head id="Head1" runat="server">
    <title>팝빌 세금계산서 SDK ASP.NET Example</title>
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
                <li> id (담당자 아이디) : <%= contactInfo.id %></li>
                <li> personName (담당자명) : <%= contactInfo.personName %></li>
                <li> tel (연락처) : <%= contactInfo.tel %></li>
                <li> email (이메일) : <%= contactInfo.email %></li>
                <li> regDT (등록일시) : <%= contactInfo.regDT %></li>
                <li> searchRole (담당자 권한) : <%= contactInfo.searchRole%></li>
                <li> mgrYN (관리자 여부) : <%= contactInfo.mgrYN %></li>
                <li> state (상태) : <%= contactInfo.state %></li>
            <% } %>
        </ul>
    </fieldset>
</div>
</body>
</html>
