<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Popbill.Messaging._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>팝빌 문자 SDK ASP.NET Example</title>
    <link href="Example.css" rel="stylesheet" type="text/css"/>
</head>
<body>
<div id="content">
    <p class="heading1">팝빌 문자메시지 SDK ASP.NET Example.</p>
    <br/>
    <fieldset class="fieldset1">
        <legend>발신번호 사전등록</legend>
        <ul>
            <li><a href="Example/checkSenderNumber.aspx">checkSenderNumber</a> - 발신번호 등록여부 확인</li>
            <li><a href="Example/getSenderNumberMgtURL.aspx">getSenderNumberMgtURL</a> - 발신번호 관리 팝업 URL</li>
            <li><a href="Example/getSenderNumberList.aspx">getSenderNumberList</a> - 발신번호 목록 확인</li>
        </ul>
    </fieldset>
    <br/>
    <fieldset class="fieldset1">
        <legend>문자 전송</legend>
        <ul>
            <li><a href="Example/sendSMS.aspx">sendSMS</a> - 단문 전송</li>
            <li><a href="Example/sendSMS_Multi.aspx">sendSMS</a> - 단문 전송 [대량]</li>
            <li><a href="Example/sendLMS.aspx">sendLMS</a> - 장문 전송</li>
            <li><a href="Example/sendLMS_Multi.aspx">sendLMS</a> - 장문 전송 [대량]</li>
            <li><a href="Example/sendMMS.aspx">sendMMS</a> - 포토 전송</li>
            <li><a href="Example/sendMMS_Multi.aspx">sendMMS</a> - 포토 전송 [대량]</li>
            <li><a href="Example/sendXMS.aspx">sendXMS</a> - 단문/장문 자동인식 전송</li>
            <li><a href="Example/sendXMS_Multi.aspx">sendXMS</a> - 단문/장문 자동인식 전송 [대량]</li>
            <li><a href="Example/cancelReserve.aspx">cancelReserve</a> - 예약전송 취소</li>
            <li><a href="Example/cancelReserveRN.aspx">cancelReserveRN</a> - 예약전송 취소 (요청번호 할당)</li>
            <li><a href="Example/cancelReservebyRCV.aspx">cancelReservebyRCV</a> - 예약전송 취소(접수번호, 수신번호)</li>
            <li><a href="Example/cancelReserveRNbyRCV.aspx">cancelReserveRNbyRCV</a> - 예약전송 취소 (요청번호, 수신번호)</li>
        </ul>
    </fieldset>
    <br/>
    <fieldset class="fieldset1">
        <legend>정보확인</legend>
        <ul>
            <li><a href="Example/getMessages.aspx">getMessages</a> - 전송내역 확인</li>
            <li><a href="Example/getMessagesRN.aspx">getMessagesRN</a> - 전송내역 확인 (요청번호 할당)</li>
            <li><a href="Example/search.aspx">search</a> - 전송내역 목록 조회</li>
            <li><a href="Example/getSentListURL.aspx">getSentListURL</a> - 문자 전송내역 팝업 URL</li>
            <li><a href="Example/getAutoDenyList.aspx">getAutoDenyList</a> - 080 수신거부 목록 확인</li>
        </ul>
    </fieldset>
    <br/>
    <fieldset class="fieldset1">
        <legend>포인트 관리</legend>
        <ul>
            <li><a href="Example/getChargeURL.aspx">getChargeURL</a> - 연동회원 포인트충전 URL</li>
            <li><a href="Example/getBalance.aspx">getBalance</a> - 연동회원 잔여포인트 확인</li>
            <li><a href="Example/getPaymentURL.aspx">getPaymentURL</a> - 연동회원 포인트 결제내역 URL</li>
            <li><a href="Example/getUseHistoryURL.aspx">getUseHistoryURL</a> - 연동회원 포인트 사용내역 URL</li>
            <li><a href="Example/getPartnerBalance.aspx">getPartnerBalance</a> - 파트너 잔여포인트 확인</li>
            <li><a href="Example/getPartnerURL.aspx">getPartnerURL</a> - 파트너 포인트충전 URL</li>
            <li><a href="Example/getUnitCost.aspx">getUnitCost</a> - 전송 단가 확인</li>
            <li><a href="Example/getChargeInfo.aspx">getChargeInfo</a> - 과금정보 확인</li>
        </ul>
    </fieldset>
    <br/>
    <fieldset class="fieldset1">
        <legend>회원정보</legend>
        <ul>
            <li><a href="Example/checkIsMember.aspx">checkIsMember</a> - 연동회원 가입여부 확인</li>
            <li><a href="Example/checkID.aspx">checkID</a> - 아이디 중복 확인</li>
            <li><a href="Example/joinMember.aspx">joinMember</a> - 연동회원 신규가입</li>
            <li><a href="Example/getAccessURL.aspx">getAccessURL</a> - 팝빌 로그인 URL</li>
            <li><a href="Example/registContact.aspx">registContact</a> - 담당자 등록</li>
            <li><a href="Example/getContactInfo.aspx">getContactInfo</a> - 담당자 정보 확인</li>
            <li><a href="Example/listContact.aspx">listContact</a> - 담당자 목록 확인</li>
            <li><a href="Example/updateContact.aspx">updateContact</a> - 담당자 정보 수정</li>
            <li><a href="Example/getCorpInfo.aspx">getCorpInfo</a> - 회사정보 확인</li>
            <li><a href="Example/updateCorpInfo.aspx">updateCorpInfo</a> - 회사정보 수정</li>
        </ul>
    </fieldset>
</div>
</body>
</html>
