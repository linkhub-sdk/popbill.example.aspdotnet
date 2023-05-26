<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Popbill.Fax._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>팝빌 팩스 SDK ASP.NET Example</title>
    <link href="./Example.css" rel="stylesheet" type="text/css"/>
</head>
<body>
<div id="content">
    <p class="heading1">팝빌 팩스 SDK ASP.NET Example.</p>
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
        <legend>팩스 전송</legend>
        <ul>
            <li><a href="Example/sendFAX.aspx">sendFAX</a> - 팩스 전송</li>
            <li><a href="Example/sendFAX_Multi.aspx">sendFAX</a> - 팩스 동보전송</li>
            <li><a href="Example/resendFAX.aspx">resendFAX</a> - 팩스 재전송</li>
            <li><a href="Example/resendFAXRN.aspx">resendFAX</a> - 팩스 재전송 (요청번호 할당)</li>
            <li><a href="Example/resendFAX_Multi.aspx">resendFAX</a> - 팩스 동보재전송</li>
            <li><a href="Example/resendFAXRN_Multi.aspx">resendFAX</a> - 팩스 동보재전송 (요청번호 할당)</li>
            <li><a href="Example/cancelReserve.aspx">cancelReserve</a> - 예약전송 취소</li>
            <li><a href="Example/cancelReserveRN.aspx">cancelReserveRN</a> - 예약전송 취소 (요청번호 할당)</li>
        </ul>
    </fieldset>
    <br/>
    <fieldset class="fieldset1">
        <legend>정보확인</legend>
        <ul>
            <li><a href="Example/getFaxResult.aspx">getFaxResult</a> - 전송내역 및 전송상태 확인</li>
            <li><a href="Example/getFaxResultRN.aspx">getFaxResultRN</a> - 전송내역 및 전송상태 확인 (요청번호 할당)</li>
            <li><a href="Example/search.aspx">search</a> - 전송내역 목록 조회</li>
            <li><a href="Example/getSentListURL.aspx">getSentListURL</a> - 팩스 전송내역 팝업 URL</li>
            <li><a href="Example/getPreviewURL.aspx">getPreviewURL</a> - 팩스 미리보기 팝업 URL</li>
        </ul>
    </fieldset>
    <br/>
    <fieldset class="fieldset1">
        <legend>포인트 관리</legend>
        <ul>
            <li><a href="Example/getChargeURL.aspx">getChargeURL</a> - 연동회원 포인트충전 URL</li>
            <li><a href="Example/getChargeInfo.aspx">getChargeInfo</a> - 과금정보 확인</li>
            <li><a href="Example/getUnitCost.aspx">getUnitCost</a> - 전송 단가 확인</li>
            <li><a href="Example/getBalance.aspx">getBalance</a> - 연동회원 잔여포인트 확인</li>
            <li><a href="Example/getPaymentURL.aspx">getPaymentURL</a> - 연동회원 포인트 결제내역 URL</li>
            <li><a href="Example/getUseHistoryURL.aspx">getUseHistoryURL</a> - 연동회원 포인트 사용내역 URL</li>
            <li><a href="Example/getPartnerBalance.aspx">getPartnerBalance</a> - 파트너 잔여포인트 확인</li>
            <li><a href="Example/getPartnerURL.aspx">getPartnerURL</a> - 파트너 포인트충전 URL</li>
            <li><a href="Example/paymentRequest.aspx">paymentRequest</a> - 연동회원 무통장 입금신청</li>
            <li><a href="Example/getSettleResult.aspx">getSettleResult</a> - 연동회원 무통장 입금신청 정보확인</li>
            <li><a href="Example/getPaymentHistory.aspx">getPaymentHistory</a> - 연동회원 포인트 결제내역 확인</li>
            <li><a href="Example/getUseHistory.aspx">getUseHistory</a> - 연동회원 포인트 사용내역 확인</li>
            <li><a href="Example/refund.aspx">refund</a> - 연동회원 포인트 환불신청</li>
            <li><a href="Example/getRefundHistory.aspx">getRefundHistory</a> - 연동회원 포인트 환불내역 확인</li>
            <li><a href="Example/getRefundInfo.aspx">getRefundInfo</a> - 환불 신청 상태 조회</li>
            <li><a href="Example/getRefundableBalance.aspx">getRefundableBalance</a> - 환불 가능 포인트 조회</li>
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
            <li><a href="Example/quitMember.aspx">quitMember</a> - 팝빌 회원 탈퇴</li>
        </ul>
    </fieldset>
</div>
</body>
</html>
