<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="getATSTemplate.aspx.cs" Inherits="Popbill.Kakao.Example.getATSTemplate" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>팝빌 카카오톡 SDK ASP.NET Example</title>
    <link href="../Example.css" rel="stylesheet" type="text/css"/>
</head>
<body>
<div id="content">
    <p class="heading1">Response</p>
    <br/>
    <fieldset class="fieldset1">
        <legend>알림톡 템플릿 정보 확인</legend>
        <ul>
            <% if (!String.IsNullOrEmpty(code)) { %>
                <li>Response.code : <%= code %> </li>
                <li>Response.message : <%= message %></li>
            <% } else { %>
                <li> templateCode (템플릿 코드) : <%= templateInfo.templateCode %></li>
                <li> templateName (템플릿 제목) : <%= templateInfo.templateName%></li>
                <li> template (템플릿 내용) : <%= templateInfo.template%></li>
                <li> plusFriendID (검색용 아이디) : <%= templateInfo.plusFriendID%></li>
                <li> ads (광고 메시지) : <%= templateInfo.ads%></li>
                <li> appendix (부가 메시지) : <%= templateInfo.appendix%></li>
                <li> secureYN (보안템플릿 여부) : <%= templateInfo.secureYN %></li>
                <li> state (템플릿 상태) : <%= templateInfo.state %></li>
                <li> stateDT (템플릿 상태 일시) : <%= templateInfo.stateDT %></li>
                <% if (templateInfo.btns != null)
                { %>
                    <% foreach (Popbill.Kakao.KakaoButton btnInfo in templateInfo.btns)
                       { %>
                        <fieldset class="fieldset2">
                             <legend>버튼정보</legend>
                             <ul>
                                 <li> n (버튼명) : <%= btnInfo.n %></li>
                                 <li> t (버튼유형) : <%= btnInfo.t %></li>
                                 <li> u1 (버튼링크1) : <%= btnInfo.u1 %></li>
                                 <li> u2 (버튼링크2) : <%= btnInfo.u2 %></li>
                             </ul>
                         </fieldset>
                   <% } %>
                <% } %>
            <% } %>
        </ul>
    </fieldset>
</div>
</body>
</html>
