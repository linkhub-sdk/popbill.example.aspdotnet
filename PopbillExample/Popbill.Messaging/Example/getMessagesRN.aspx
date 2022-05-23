<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="getMessagesRN.aspx.cs" Inherits="Popbill.Message.Example.getMessagesRN" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

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
        <legend>문자전송 결과 조회 (요청번호할당)</legend>
        <ul>
            <% if (!String.IsNullOrEmpty(code)) { %>
                <li>Response.code : <%= code %> </li>
                <li>Response.message : <%= message %></li>
            <% } else { %>
                <% foreach (Popbill.Message.MessageResult msgInfo in result)
                   { %>
                    <fieldset class="fieldset2">
                        <legend>문자 전송 상태정보</legend>
                        <ul>
                            <li>subject (메시지 제목) : <%= msgInfo.subject %></li>
                            <li>content (메시지 내용) : <%= msgInfo.content %></li>
                            <li>sendNum (발신번호) : <%= msgInfo.sendNum %></li>
                            <li>senderName (발신자명) : <%= msgInfo.senderName %></li>
                            <li>receiveNum (수신번호) : <%= msgInfo.receiveNum %></li>
                            <li>receiveName (수신자명) : <%= msgInfo.receiveName %></li>
                            <li>receiptDT (접수시간) : <%= msgInfo.receiptDT %></li>
                            <li>sendDT (발송시간) : <%= msgInfo.sendDT %></li>
                            <li>resultDT (전송결과 수신시간) : <%= msgInfo.resultDT %></li>
                            <li>reserveDT (예약일시) : <%= msgInfo.reserveDT %></li>
                            <li>state (전송 상태코드) : <%= msgInfo.state %></li>
                            <li>result (전송 결과코드) : <%= msgInfo.result %></li>
                            <li>type (메시지 타입) : <%= msgInfo.type %></li>
                            <li>tranNet (전송처리 이동통신사명) : <%= msgInfo.tranNet %></li>
                            <li>receiptNum (접수번호) : <%= msgInfo.receiptNum %></li>
                            <li>requestNum (요청번호) : <%= msgInfo.requestNum %></li>
                            <li>interOPRefKey (파트너 지정키) : <%= msgInfo.interOPRefKey %></li>
                        </ul>
                    </fieldset>
                <% } %>
            <% } %>
        </ul>
    </fieldset>
</div>
</body>
</html>