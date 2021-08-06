<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Popbill.HomeTax.Taxinvoice._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>팝빌 홈택스 세금계산서 매입/매출 조회 API SDK ASP.NET Example</title>
    <link href="Example.css" rel="stylesheet" type="text/css" />
</head>
<body>
<div id="content">
    <p class="heading1">팝빌 홈택스 세금계산서 매입/매출 조회 API SDK ASP.NET Example.</p>
    <br/>
    <fieldset class="fieldset1">
        <legend>홈택스 전자세금계산서 매입/매출 내역 수집</legend>
        <ul>
            <li><a href="Example/requestJob.aspx">requestJob</a> - 수집 요청</li>
            <li><a href="Example/getJobState.aspx">getJobState</a> - 수집 상태 확인</li>
            <li><a href="Example/listActiveJob.aspx">listActiveJob</a> - 수집 상태 목록 확인</li>
        </ul>
    </fieldset>
    <br/>
    <fieldset class="fieldset1">
        <legend>홈택스 전자세금계산서 매입/매출 내역 수집 결과 조회</legend>
        <ul>
            <li><a href="Example/search.aspx">search</a> - 수집 결과 조회</li>
            <li><a href="Example/summary.aspx">summary</a> - 수집 결과 요약정보 조회</li>
            <li><a href="Example/getTaxinvoice.aspx">getTaxinvoice</a> - 상세정보 확인 - JSON</li>
            <li><a href="Example/getXML.aspx">getXML</a> - 상세정보 확인 - XML</li>
            <li><a href="Example/getPopUpURL.aspx">getPopUpURL</a> - 홈택스 전자세금계산서 보기 팝업 URL</li>
            <li><a href="Example/getPrintURL.aspx">getPrintURL</a> - 홈택스 전자세금계산서 인쇄 팝업 URL</li>
        </ul>
    </fieldset>
    <br/>
    <fieldset class="fieldset1">
        <legend>홈택스연동 인증 관리</legend>
        <ul>
            <li><a href="Example/getCertificatePopUpURL.aspx">getCertificatePopUpURL</a> - 홈택스연동 인증 관리 팝업 URL</li>
            <li><a href="Example/getCertificateExpireDate.aspx">getCertificateExpireDate</a> - 홈택스연동 공인인증서 만료일자 확인</li>
            <li><a href="Example/checkCertValidation.aspx">checkCertValidation</a> - 홈택스 공인인증서 로그인 테스트</li>
            <li><a href="Example/registDeptUser.aspx">registDeptUser</a> - 부서사용자 계정등록</li>
            <li><a href="Example/checkDeptUser.aspx">checkDeptUser</a> - 부서사용자 등록정보 확인</li>
            <li><a href="Example/checkLoginDeptUser.aspx">checkLoginDeptUser</a> - 부서사용자 로그인 테스트</li>
            <li><a href="Example/deleteDeptUser.aspx">deleteDeptUser</a> - 부서사용자 등록정보 삭제</li>
        </ul>
    </fieldset>
    <br/>
    <fieldset class="fieldset1">
        <legend>포인트 관리 / 정액제 신청</legend>
        <ul>
            <li><a href="Example/getBalance.aspx">getBalance</a> - 연동회원 잔여포인트 확인</li>
            <li><a href="Example/getChargeURL.aspx">getChargeURL</a> - 연동회원 포인트충전 URL</li>
            <li><a href="Example/getPaymentURL.aspx">getPaymentURL</a> - 연동회원 포인트 결제내역 URL</li>
            <li><a href="Example/getUseHistoryURL.aspx">getUseHistoryURL</a> - 연동회원 포인트 사용내역 URL</li>
            <li><a href="Example/getPartnerBalance.aspx">getPartnerBalance</a> - 파트너 잔여포인트 확인</li>
            <li><a href="Example/getPartnerURL.aspx">getPartnerURL</a> - 파트너 포인트충전 URL</li>
            <li><a href="Example/getChargeInfo.aspx">getChargeInfo</a> - 과금정보 확인</li>
            <li><a href="Example/getFlatRatePopUpURL.aspx">getFlatRatePopUpURL</a> - 정액제 서비스 신청 URL</li>
            <li><a href="Example/getFlatRateState.aspx">getFlatRateState</a> - 정액제 서비스 상태 확인</li>
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
            <li><a href="Example/listContact.aspx">listContact</a> - 담당자 목록 확인</li>
            <li><a href="Example/updateContact.aspx">updateContact</a> - 담당자 정보 수정</li>
        </ul>
    </fieldset>
</div>
</body>
</html>
