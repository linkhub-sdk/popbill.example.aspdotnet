﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Popbill.BizInfoCheck._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>팝빌 기업정보조회 API SDK ASP.NET Example</title>
    <link href="./Example.css" rel="stylesheet" type="text/css" />
</head>
<body>
<div id="content">
    <p class="heading1">팝빌 기업정보조회 SDK ASP.NET Example.</p>
    <br/>
    <fieldset class="fieldset1">
        <legend>기업정보조회</legend>
        <ul>
            <li><a href="Example/checkBizInfo.aspx">checkBizInfo</a> - 기업정보조회</li>
        </ul>
    </fieldset>
    <br/>
    <fieldset class="fieldset1">
        <legend>포인트 관리</legend>
        <ul>
            <li><a href="Example/getBalance.aspx">getBalance</a> - 연동회원 잔여포인트 확인</li>
            <li><a href="Example/getChargeURL.aspx">getChargeURL</a> - 연동회원 포인트충전 URL</li>
            <li><a href="Example/getPaymentURL.aspx">getPaymentURL</a> - 연동회원 포인트 결제내역 URL</li>
            <li><a href="Example/getUseHistoryURL.aspx">getUseHistoryURL</a> - 연동회원 포인트 사용내역 URL</li>
            <li><a href="Example/getPartnerBalance.aspx">getPartnerBalance</a> - 파트너 잔여포인트 확인</li>
            <li><a href="Example/getPartnerURL.aspx">getPartnerURL</a> - 파트너 포인트충전 URL</li>
            <li><a href="Example/getUnitCost.aspx">getUnitCost</a> - 전송 단가 확인</li>
            <li><a href="Example/getChargeInfo.aspx">getChargeInfo</a> - 과금정보 확인</li>
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
            <li><a href="Example/getCorpInfo.aspx">getCorpInfo</a> - 회사정보 확인</li>
            <li><a href="Example/updateCorpInfo.aspx">updateCorpInfo</a> - 회사정보 수정</li>
            <li><a href="Example/registContact.aspx">registContact</a> - 담당자 등록</li>
            <li><a href="Example/deleteContact.aspx">deleteContact</a> - 담당자 삭제</li>
            <li><a href="Example/getContactInfo.aspx">getContactInfo</a> - 담당자 정보 확인</li>
            <li><a href="Example/listContact.aspx">listContact</a> - 담당자 목록 확인</li>
            <li><a href="Example/updateContact.aspx">updateContact</a> - 담당자 정보 수정</li>
            <li><a href="Example/getAccessURL.aspx">getAccessURL</a> - 팝빌 로그인 URL</li>
            <li><a href="Example/quitMember.aspx">quitMember</a> - 팝빌 회원 탈퇴</li>
        </ul>
    </fieldset>
</div>
</body>
</html>
