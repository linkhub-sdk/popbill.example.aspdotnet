<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="listContact.aspx.cs" Inherits="Popbill.HomeTax.Taxinvoice.Example.listContact" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>팝빌 홈택스 세금계산서 매입/매출 조회 API SDK ASP.NET Example</title>
    <link href="../Example.css" rel="stylesheet" type="text/css"/>
</head>
<body>
<div id="content">
    <p class="heading1">Response</p>
    <br/>
    <fieldset class="fieldset1">
        <legend>담당자 목록 확인</legend>
        <ul>
            <% if (!String.IsNullOrEmpty(code)) { %>
                <li>Response.code : <%= code %> </li>
                <li>Response.message : <%= message %></li>
            <% } else { %>
                <% foreach (Popbill.Contact contactInfo in contactList)
                   { %>
                    <fieldset class="fieldset2">
                        <legend>담당자 정보</legend>
                        <ul>
                            <li> id (담당자 아이디) : <%= contactInfo.id %></li>
                            <li> personName (담당자명) : <%= contactInfo.personName %></li>
                            <li> tel (연락처) : <%= contactInfo.tel %></li>
                            <li> email (이메일) : <%= contactInfo.email %></li>
                            <li> regDT (등록일시) : <%= contactInfo.regDT %></li>
                            <li> searchRole (담당자 권한) : <%= contactInfo.searchRole %></li>
                            <li> mgrYN (관리자여부) : <%= contactInfo.mgrYN %></li>
                            <li> state (상태) : <%= contactInfo.state %></li>
                        </ul>
                    </fieldset>
                <% } %>
            <% } %>
        </ul>
    </fieldset>
</div>
</body>
</html>
