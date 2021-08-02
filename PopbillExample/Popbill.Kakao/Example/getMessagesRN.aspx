<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="getMessagesRN.aspx.cs" Inherits="Popbill.Kakao.Example.getMessagesRN" %>

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
        <legend>알림톡/친구톡 전송결과 확인(요청번호할당)</legend>
        <ul>
            <% if (!String.IsNullOrEmpty(code)) { %>
                <li>Response.code : <%= code %> </li>
                <li>Response.message : <%= message %></li>
            <% } else { %>
                <fieldset class="fieldset2">
                    <legend></legend>
                    <ul>
                        <li> contentType (카카오톡 유형) : <%= sentResult.contentType %></li>
                        <li> templateCode (템플릿 코드) : <%= sentResult.templateCode %></li>
                        <li> plusFriendID (카카오톡 채널 아이디) : <%= sentResult.plusFriendID %></li>
                        <li> sendNum (발신번호) : <%= sentResult.sendNum %></li>
                        <li> altContent (대체문자 내용) : <%= sentResult.altContent %></li>
                        <li> altSendType (대체문자 유형) : <%= sentResult.altSendType %></li>
                        <li> reserveDT (예약일시) : <%= sentResult.reserveDT %></li>
                        <li> adsYN (광고전송 여부) : <%= sentResult.adsYN %></li>
                        <li> imageURL (친구톡 이미지 URL) : <%= sentResult.imageURL %></li>
                        <li> sendCnt (전송건수) : <%= sentResult.sendCnt %></li>
                        <li> successCnt (성공건수) : <%= sentResult.successCnt %></li>
                        <li> failCnt (실패건수) : <%= sentResult.failCnt %></li>
                        <li> altCnt (대체문자 건수) : <%= sentResult.altCnt %></li>
                        <li> cancelCnt (취소건수) : <%= sentResult.cancelCnt %></li>
                    </ul>
                    <% if (sentResult.msgs != null)
                       { %>
                        <% foreach (Popbill.Kakao.KakaoSentDetail detailInfo in sentResult.msgs)
                           { %>
                            <fieldset class="fieldset3">
                                <legend>전송결과 정보</legend>
                                <ul>
                                    <li> state (전송상태 코드) : <%= detailInfo.state %></li>
                                    <li> sendDT (전송일시) : <%= detailInfo.sendDT %></li>
                                    <li> receiveNum (수신번호) : <%= detailInfo.receiveNum %></li>
                                    <li> receiveName (수신자명) : <%= detailInfo.receiveName %></li>
                                    <li> content (알림톡/친구톡 내용) : <%= detailInfo.content %></li>
                                    <li> result (알림톡/친구톡 전송결과 코드) : <%= detailInfo.result %></li>
                                    <li> resultDT (알림톡/친구톡 전송결과 수신일시) : <%= detailInfo.resultDT %></li>
                                    <li> altContent (대체문자 내용) : <%= detailInfo.altContent %></li>
                                    <li> altContentType (대체문자 전송유형) : <%= detailInfo.altContentType %></li>
                                    <li> altSendDT (대체문자 전송일시) : <%= detailInfo.altSendDT %></li>
                                    <li> altResult (대체문자 전송결과 코드) : <%= detailInfo.altResult %></li>
                                    <li> altResultDT (대체문자 전송결과 수신일시) : <%= detailInfo.altResultDT %></li>
                                    <li> receiptNum (접수번호) : <%= detailInfo.receiptNum %></li>
                                    <li> requestNum (요청번호) : <%= detailInfo.requestNum %></li>
                                </ul>
                            </fieldset>
                        <% } %>
                    <% } %>
                    <% if (sentResult.btns != null)
                       { %>
                        <% foreach (Popbill.Kakao.KakaoButton btnInfo in sentResult.btns)
                           { %>
                            <fieldset class="fieldset3">
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
                </fieldset>

            <% } %>
        </ul>
    </fieldset>
</div>
</body>
</html>
