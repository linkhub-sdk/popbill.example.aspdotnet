<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Popbill.Cashbill._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>팝빌 현금영수증 SDK ASP.NET Example</title>
    <link href="Example.css" rel="stylesheet" type="text/css" />
</head>
<body>
<div id="content">
    <p class="heading1">팝빌 현금영수증 SDK ASP.NET Example.</p>
    <br/>
    <fieldset class="fieldset1">
        <legend>현금영수증 발행</legend>
        <ul>
            <li><a href="Example/checkMgtKeyInUse.aspx">checkMgtKeyInUse</a> -관리번호 확인</li>
            <li><a href="Example/registIssue.aspx">registIssue</a> -즉시발행</li>
            <li><a href="Example/register.aspx">register</a> -임시저장</li>
            <li><a href="Example/update.aspx">update</a> -수정</li>
            <li><a href="Example/issue.aspx">issue</a> -발행</li>
            <li><a href="Example/cancelIssue.aspx">cancelIssue</a> -발행취소</li>
            <li><a href="Example/delete.aspx">delete</a> -삭제</li>
        </ul>
    </fieldset>
    <br/>
    <fieldset class="fieldset1">
        <legend>취소현금영수증 발행</legend>
        <ul>
            <li><a href="Example/revokeRegistIssue.aspx">revokeRegistIssue</a> -즉시발행</li>
            <li><a href="Example/revokeRegistIssue_part.aspx">revokeRegistIssue_part</a> -부분) 즉시발행</li>
            <li><a href="Example/revokeRegister.aspx">revokeRegister</a> -임시저장</li>
            <li><a href="Example/revokeRegister_part.aspx">revokeRegister_part</a> -부분) 임시저장</li>
        </ul>
    </fieldset>
    <br/>
    <fieldset class="fieldset1">
        <legend>현금영수증 정보확인</legend>
        <ul>
            <li><a href="Example/getInfo.aspx">getInfo</a> -상태확인</li>
            <li><a href="Example/getInfos.aspx">getInfos</a> -상태 대량 확인</li>
            <li><a href="Example/getDetailInfo.aspx">getDetailInfo</a> -상세정보 확인</li>
            <li><a href="Example/search.aspx">search</a> -목록 조회</li>
            <li><a href="Example/getLogs.aspx">getLogs</a> -상태 변경이력 확인</li>
            <li><a href="Example/getURL.aspx">getURL</a> -현금영수증 문서함 관련 URL</li>
        </ul>
    </fieldset>
    <br/>
    <fieldset class="fieldset1">
        <legend>현금영수증 보기/인쇄</legend>
        <ul>
            <li><a href="Example/getPopUpURL.aspx">getPopUpURL</a> -현금영수증 보기 URL</li>
            <li><a href="Example/getPrintURL.aspx">getPrintURL</a> -현금영수증 인쇄 URL</li>
            <li><a href="Example/getMassPrintURL.aspx">getMassPrintURL</a> -현금영수증 대량 인쇄 URL</li>
            <li><a href="Example/getMailURL.aspx">getMailURL</a> -현금영수증 메일링크 URL</li>
        </ul>
    </fieldset>
    <br/>
    <fieldset class="fieldset1">
        <legend>부가기능</legend>
        <ul>
            <li><a href="Example/getAccessURL.aspx">getAccessURL</a> -팝빌 로그인 URL</li>
            <li><a href="Example/sendEmail.aspx">sendEmail</a> -메일 전송</li>
            <li><a href="Example/sendSMS.aspx">sendSMS</a> -문자 전송</li>
            <li><a href="Example/sendFAX.aspx">sendFAX</a> -팩스 전송</li>
            <li><a href="Example/listEmailConfig.aspx">listEmailConfig</a> -현금영수증 알림메일 전송목록 조회</li>
            <li><a href="Example/updateEmailConfig.aspx">updateEmailConfig</a> -현금영수증 알림메일 전송설정 수정</li>
        </ul>
    </fieldset>
    <br/>
    <fieldset class="fieldset1">
        <legend>포인트관리</legend>
        <ul>
            <li><a href="Example/getBalance.aspx">getBalance</a> -연동회원 잔여포인트 확인</li>
            <li><a href="Example/getChargeURL.aspx">getChargeURL</a> -연동회원 포인트충전 URL</li>
            <li><a href="Example/getPartnerBalance.aspx">getPartnerBalance</a> -파트너 잔여포인트 확인</li>
            <li><a href="Example/getPartnerURL.aspx">getPartnerURL</a> -파트너 포인트충전 URL</li>
            <li><a href="Example/getUnitCost.aspx">getUnitCost</a> -발행 단가 확인</li>
            <li><a href="Example/getChargeInfo.aspx">getChargeInfo</a> -과금정보 확인</li>
        </ul>
    </fieldset>
    <br/>
    <fieldset class="fieldset1">
        <legend>회원정보</legend>
        <ul>
            <li><a href="Example/checkIsMember.aspx">checkIsMember</a> -연동회원 가입여부 확인</li>
            <li><a href="Example/checkID.aspx">checkID</a> -아이디 중복 확인</li>
            <li><a href="Example/joinMember.aspx">joinMember</a> -연동회원 신규가입</li>
            <li><a href="Example/getCorpInfo.aspx">getCorpInfo</a> -회사정보 확인</li>
            <li><a href="Example/updateCorpInfo.aspx">updateCorpInfo</a> -회사정보 수정</li>
            <li><a href="Example/registContact.aspx">registContact</a> -담당자 등록</li>
            <li><a href="Example/listContact.aspx">listContact</a> -담당자 목록 확인</li>
            <li><a href="Example/updateContact.aspx">updateContact</a> -담당자 정보 수정</li>
        </ul>
    </fieldset>
</div>
</body>
</html>
