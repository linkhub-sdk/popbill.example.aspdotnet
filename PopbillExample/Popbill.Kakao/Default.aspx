<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Popbill.Kakao._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>팝빌 카카오톡 SDK ASP.NET Example</title>
    <link href="Example.css" rel="stylesheet" type="text/css"/>
</head>
<body>
<div id="content">
    <p class="heading1">팝빌 카카오톡 SDK ASP.NET Example.</p>
    <br/>
    <fieldset class="fieldset1">
        <legend>카카오톡 채널 관리</legend>
        <ul>
            <li><a href="Example/getPlusFriendMgtURL.aspx">getPlusFriendMgtURL</a> - 카카오톡 채널 관리 팝업 URL</li>
            <li><a href="Example/listPlusFriendID.aspx">listPlusFriendID</a> - 카카오톡 채널 목록 확인</li>
        </ul>
    </fieldset>
    <br/>
    <fieldset class="fieldset1">
        <legend>발신번호 관리</legend>
        <ul>
            <li><a href="Example/checkSenderNumber.aspx">checkSenderNumber</a> - 발신번호 등록여부 확인</li>
            <li><a href="Example/getSenderNumberMgtURL.aspx">getSenderNumberMgtURL</a> - 발신번호 관리 팝업 URL</li>
            <li><a href="Example/getSenderNumberList.aspx">getSenderNumberList</a> - 발신번호 목록 확인</li>
        </ul>
    </fieldset>
    <br/>
    <fieldset class="fieldset1">
        <legend>알림톡 템플릿 관리</legend>
        <ul>
            <li><a href="Example/getATSTemplateMgtURL.aspx">getATSTemplateMgtURL</a> - 알림톡 템플릿관리 팝업 URL</li>
            <li><a href="Example/getATSTemplate.aspx">getATSTemplate</a> - 알림톡 템플릿 정보 확인</li>
            <li><a href="Example/listATSTemplate.aspx">listATSTemplate</a> - 알림톡 템플릿 목록 확인</li>
        </ul>
    </fieldset>
    <br/>
    <fieldset class="fieldset1">
        <legend>알림톡 / 친구톡 전송</legend>
        <fieldset class="fieldset2">
            <legend>알림톡 전송</legend>
            <ul>
                <li><a href="Example/sendATS_one.aspx">sendATS</a> - 알림톡 단건 전송</li>
                <li><a href="Example/sendATS_same.aspx">sendATS</a> - 알림톡 동일내용 대량 전송</li>
                <li><a href="Example/sendATS_multi.aspx">sendATS</a> - 알림톡 개별내용 대량 전송</li>
            </ul>
        </fieldset>
        <fieldset class="fieldset2">
            <legend>친구톡 텍스트 전송</legend>
            <ul>
                <li><a href="Example/sendFTS_one.aspx">sendFTS</a> - 친구톡 텍스트 단건 전송</li>
                <li><a href="Example/sendFTS_same.aspx">sendFTS</a> - 친구톡 텍스트 동일내용 대량전송</li>
                <li><a href="Example/sendFTS_multi.aspx">sendFTS</a> - 친구톡 텍스트 개별내용 대량전송</li>
            </ul>
        </fieldset>
        <fieldset class="fieldset2">
            <legend>친구톡 이미지 전송</legend>
            <ul>
                <li><a href="Example/sendFMS_one.aspx">sendFMS</a> - 친구톡 이미지 단건 전송</li>
                <li><a href="Example/sendFMS_same.aspx">sendFMS</a> - 친구톡 이미지 동일내용 대량전송</li>
                <li><a href="Example/sendFMS_multi.aspx">sendFMS</a> - 친구톡 이미지 개별내용 대량전송</li>
            </ul>
        </fieldset>
        <fieldset class="fieldset2">
            <legend>예약전송 취소</legend>
            <ul>
                <li><a href="Example/cancelReserve.aspx">cancelReserve</a> - 예약전송 취소</li>
                <li><a href="Example/cancelReserveRN.aspx">cancelReserveRN</a> - 예약전송 취소 (요청번호 할당)</li>
            </ul>
        </fieldset>
    </fieldset>
    <br/>
    <fieldset class="fieldset1">
        <legend>정보확인</legend>
        <ul>
            <li><a href="Example/getMessages.aspx">getMessages</a> - 알림톡/친구톡 전송내역 확인</li>
            <li><a href="Example/getMessagesRN.aspx">getMessagesRN</a> - 알림톡/친구톡 전송내역 확인 (요청번호 할당)</li>
            <li><a href="Example/search.aspx">search</a> - 전송내역 목록 조회</li>
            <li><a href="Example/getSentListURL.aspx">getSentListURL</a> - 카카오톡 전송내역 팝업 URL</li>
        </ul>
    </fieldset>
    <br/>
    <fieldset class="fieldset1">
        <legend>포인트관리</legend>
        <ul>
            <li><a href="Example/getBalance.aspx">getBalance</a> - 연동회원 잔여포인트 확인</li>
            <li><a href="Example/getChargeURL.aspx">getChargeURL</a> 연동회원 포인트충전 URL</li>
            <li><a href="Example/getPaymentURL.aspx">getPaymentURL</a> - 연동회원 포인트 결제내역 URL</li>
            <li><a href="Example/getUseHistoryURL.aspx">getUseHistoryURL</a> - 연동회원 포인트 사용내역 URL</li>
            <li><a href="Example/getPartnerBalance.aspx">getPartnerBalance</a> - 파트너 잔여포인트 확인</li>
            <li><a href="Example/getPartnerURL.aspx">getPartnerURL</a> - 파트너 포인트충전 URL</li>
            <li><a href="Example/getUnitCost.aspx">getUnitCost</a> - 전송단가 확인</li>
            <li><a href="Example/getChargeInfo.aspx">getChargeInfo</a> - 과금정보 확인</li>
        </ul>
    </fieldset>
    <br/>
    <fieldset class="fieldset1">
        <legend>회원관리</legend>
        <ul>
            <li><a href="Example/checkIsMember.aspx">checkIsMember</a> - 연동회원 가입여부 확인</li>
            <li><a href="Example/checkID.aspx">checkID</a> - 연동회원 아이디 중복 확인</li>
            <li><a href="Example/joinMember.aspx">joinMember</a> - 연동회원사 신규가입</li>
            <li><a href="Example/getAccessURL.aspx">getAccessURL</a> i팝빌 로그인 URL</li>
            <li><a href="Example/registContact.aspx">registContact</a> - 담당자 추가</li>
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
