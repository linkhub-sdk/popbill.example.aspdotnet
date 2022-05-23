<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="listPlusFriendID.aspx.cs" Inherits="Popbill.Kakao.Example.listPlusFriendID" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>팝빌 카카오톡 SDK ASP.NET Example</title>
    <link href="../Example.css" rel="stylesheet" type="text/css"/>
</head>
<body>
<div id="content">
    <p class="heading1">Response</p>
    <br/>
    <fieldset class="fieldset1">
        <legend>카카오톡 채널 목록</legend>
        <ul>
            <% if (!String.IsNullOrEmpty(code)) { %>
                <li>Response.code : <%= code %> </li>
                <li>Response.message : <%= message %></li>
            <% } else { %>
                <% foreach (Popbill.Kakao.PlusFriend info in plusFriendList)
                   { %>
                    <fieldset class="fieldset2">
                        <ul>
                            <li> plusFriendID (카카오톡 검색용 아이디 ) : <%= info.plusFriendID %></li>
                            <li> plusFriendName (카카오톡 채널명) : <%= info.plusFriendName %></li>
                            <li> regDT (등록일시) : <%= info.regDT %></li>
                            <li> state (채널 상태) : <%= info.state %></li>
                            <li> stateDT (채널 상태 일시) : <%= info.stateDT %></li>
                        </ul>
                    </fieldset>
                <% } %>
            <% } %>
        </ul>
    </fieldset>
</div>
</body>
</html>
