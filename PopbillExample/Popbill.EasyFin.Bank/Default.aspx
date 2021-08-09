<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Popbill.EasyFin.Bank._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>팝빌 계좌조회 API SDK ASP.NET Example</title>
    <link href="Example.css" rel="stylesheet" type="text/css" />
</head>
<body>
<div id="content">
    <p class="heading1">팝빌 계좌조회 API SDK ASP.NET Example.</p>
    <br/>
    <fieldset class="fieldset1">
        <legend>계좌관리</legend>
        <ul>
            <li><a href="Example/registBankAccount.aspx">registBankAccount</a> - 계좌 등록</li>
            <li><a href="Example/updateBankAccount.aspx">updateBankAccount</a> - 계좌정보 수정</li>
            <li><a href="Example/getBankAccountInfo.aspx">getBankAccountInfo</a> - 계좌정보 확인</li>
            <li><a href="Example/listBankAccount.aspx">listBankAccount</a> - 계좌 목록 확인</li>
            <li><a href="Example/GetBankAccountMgtURL.aspx">getBankAccountMgtURL</a> - 계좌 관리 팝업 URL</li>
            <li><a href="Example/closeBankAccount.aspx">closeBankAccount</a> - 계좌 정액제 해지요청</li>
            <li><a href="Example/revokeCloseBankAccount.aspx">revokeCloseBankAccount</a> - 계좌 정액제 해지요청 취소</li>
            <li><a href="Example/deleteBankAccount.aspx">deleteBankAccount</a> - 종량제 계좌 삭제</li>
        </ul>
    </fieldset>
    <br/>
    <fieldset class="fieldset1">
        <legend>계좌 거래내역 수집</legend>
        <ul>
            <li><a href="Example/requestJob.aspx">requestJob</a> - 수집 요청</li>
            <li><a href="Example/getJobState.aspx">getJobState</a> - 수집 상태 확인</li>
            <li><a href="Example/listActiveJob.aspx">listActiveJob</a> - 수집 상태 목록 확인</li>
        </ul>
    </fieldset>
    <br/>
    <fieldset class="fieldset1">
        <legend>계좌 거래내역 관리</legend>
        <ul>
            <li><a href="Example/search.aspx">search</a> - 수집 결과 조회</li>
            <li><a href="Example/summary.aspx">summary</a> - 수집 결과 요약정보 조회</li>
        </ul>
    </fieldset>
    
    <br/>
    <fieldset class="fieldset1">
        <legend>포인트 관리 / 정액제 신청</legend>
        <ul>
            <li><a href="Example/getFlatRatePopUpURL.aspx">getFlatRatePopUpURL</a> - 정액제 서비스 신청 URL</li>
            <li><a href="Example/getFlatRateState.aspx">getFlatRateState</a> - 정액제 서비스 상태 확인</li>
            <li><a href="Example/getBalance.aspx">getBalance</a> - 연동회원 잔여포인트 확인</li>
            <li><a href="Example/getChargeURL.aspx">getChargeURL</a> - 연동회원 포인트충전 URL</li>
            <li><a href="Example/getPaymentURL.aspx">getPaymentURL</a> - 연동회원 포인트 결제내역 URL</li>
            <li><a href="Example/getUseHistoryURL.aspx">getUseHistoryURL</a> - 연동회원 포인트 사용내역 URL</li>
            <li><a href="Example/getPartnerBalance.aspx">getPartnerBalance</a> - 파트너 잔여포인트 확인</li>
            <li><a href="Example/getPartnerURL.aspx">getPartnerURL</a> - 파트너 포인트충전 URL</li>
            <li><a href="Example/getChargeInfo.aspx">getChargeInfo</a> - 과금정보 확인</li>
        </ul>
    </fieldset>
    <br/>
    <fieldset class="fieldset1">
        <legend>회원정보</legend>
        <ul>
            <li><a href="Example/getAccessURL.aspx">getAccessURL</a> - 팝빌 로그인 URL</li>
            <li><a href="Example/checkIsMember.aspx">checkIsMember</a> - 연동회원 가입여부 확인</li>
            <li><a href="Example/checkID.aspx">checkID</a> - 아이디 중복 확인</li>
            <li><a href="Example/joinMember.aspx">joinMember</a> - 연동회원 신규가입</li>
            <li><a href="Example/getCorpInfo.aspx">getCorpInfo</a> - 회사정보 확인</li>
            <li><a href="Example/updateCorpInfo.aspx">updateCorpInfo</a> - 회사정보 수정</li>
            <li><a href="Example/registContact.aspx">registContact</a> - 담당자 등록</li>
            <li><a href="Example/getContactInfo.aspx">getContactInfo</a> - 담당자 정보 확인</li>
            <li><a href="Example/listContact.aspx">listContact</a> - 담당자 목록 확인</li>
            <li><a href="Example/updateContact.aspx">updateContact</a> - 담당자 정보 수정</li>
        </ul>
    </fieldset>
</div>
</body>
</html>
