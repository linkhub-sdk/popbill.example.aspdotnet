<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Popbill.Taxinvoice.Common" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>팝빌 세금계산서 SDK ASP.NET Example</title>
    <link href="Example.css" rel="stylesheet" type="text/css"/>
</head>
<body>
<div id="content">
    <p class="heading1">팝빌 세금계산서 SDK ASP.NET Example</p>
    <br/>
    <form id="form1" runat="server">
        <fieldset class="fieldset1">
            <legend>정발행/역발행/위수탁발행</legend>
            <ul>
                <li><a href="Example/checkMgtKeyInUse.aspx">checkMgtKeyInUse</a> - 관리번호 확인</li>
                <li><a href="Example/registIssue.aspx">registIssue</a> - 즉시 발행</li>
                <li><a href="Example/register.aspx">register</a> - 임시저장</li>
                <li><a href="Example/update.aspx">update</a> - 수정</li>
                <li><a href="Example/issue.aspx">issue</a> - 발행</li>
                <li><a href="Example/cancelIssue.aspx">cancelIssue</a> - 발행취소</li>
                <li><a href="Example/send.aspx">send</a> - [발행예정]</li>
                <li><a href="Example/cancelSend.aspx">cancelSend</a> - [발행예정] 취소</li>
                <li><a href="Example/accept.aspx">accept</a> - [발행예정] 승인</li>
                <li><a href="Example/deny.aspx">deny</a> - [발행예정] 거부</li>
                <li><a href="Example/delete.aspx">delete</a> - 삭제</li>
                <li><a href="Example/registRequest.aspx">registRequest</a> - [역발행] 즉시 요청</li>
                <li><a href="Example/request.aspx">request</a> - 역발행요청</li>
                <li><a href="Example/cancelRequest.aspx">cancelRequest</a> - 역발행요청 취소</li>
                <li><a href="Example/refuse.aspx">refuse</a> - 역발행요청 거부</li>
            </ul>
        </fieldset>
        <br/>
        <fieldset class="fieldset1">
            <legend>국세청 즉시 전송</legend>
            <ul>
                <li><a href="Example/sendToNTS.aspx">sendToNTS</a> - 국세청 즉시전송</li>
            </ul>
        </fieldset>
        <br/>
        <fieldset class="fieldset1">
            <legend>세금계산서 정보확인</legend>
            <ul>
                <li><a href="Example/getInfo.aspx">getInfo</a> - 상태 확인</li>
                <li><a href="Example/getInfos.aspx">getInfos</a> - 상태 대량 확인</li>
                <li><a href="Example/getDetailInfo.aspx">getDetailInfo</a> - 상세정보 확인</li>
                <li><a href="Example/search.aspx">search</a> - 목록 조회</li>
                <li><a href="Example/getLogs.aspx">getLogs</a> - 상태 변경이력 확인</li>
                <li><a href="Example/getURL.aspx">getURL</a> - 세금계산서 문서함 관련 URL</li>
            </ul>
        </fieldset>
        <br/>
        <fieldset class="fieldset1">
            <legend>세금계산서 보기/인쇄</legend>
            <ul>
                <li><a href="Example/getPopUpURL.aspx">getPopUpURL</a> - 세금계산서 보기 URL</li>
                <li><a href="Example/getPrintURL.aspx">getPrintURL</a> - 세금계산서 인쇄 [공급자/공급받는자] URL</li>
                <li><a href="Example/getEPrintURL.aspx">getEPrintURL</a> - 세금계산서 인쇄 [공급받는자용] URL</li>
                <li><a href="Example/getMassPrintURL.aspx">getMassPrintURL</a> - 세금계산서 대량 인쇄 URL</li>
                <li><a href="Example/getMailURL.aspx">getMailURL</a> - 세금계산서 메일링크 URL</li>
            </ul>
        </fieldset>
        <br/>
        <fieldset class="fieldset1">
            <legend>부가기능</legend>
            <ul>
                <li><a href="Example/getAccessURL.aspx">getAccessURL</a> - 팝빌 로그인 URL</li>
                <li><a href="Example/getSealURL.aspx">getSealURL</a> - 인감 및 첨부문서 등록 URL</li>
                <li><a href="Example/attachFile.aspx">attachFile</a> - 첨부파일 추가</li>
                <li><a href="Example/deleteFile.aspx">deleteFile</a> - 첨부파일 삭제</li>
                <li><a href="Example/getFiles.aspx">getFiles</a> - 첨부파일 목록 확인</li>
                <li><a href="Example/sendEmail.aspx">sendEmail</a> - 메일 전송</li>
                <li><a href="Example/sendSMS.aspx">sendSMS</a> - 문자 전송</li>
                <li><a href="Example/sendFAX.aspx">sendFAX</a> - 팩스 전송</li>
                <li><a href="Example/attachStatement.aspx">attachStatement</a> - 전자명세서 첨부</li>
                <li><a href="Example/detachStatement.aspx">detachStatement</a> - 전자명세서 첨부해제</li>
                <li><a href="Example/getEmailPublicKeys.aspx">getEmailPublicKeys</a> - 유통사업자 메일 목록 확인</li>
                <li><a href="Example/assignMgtKey.aspx">assignMgtKey</a> - 관리번호 할당</li>
                <li><a href="Example/listEmailConfig.aspx">listEmailConfig</a> - 세금계산서 알림메일 전송목록 조회</li>
                <li><a href="Example/updateEmailConfig.aspx">updateEmailConfig</a> - 세금계산서 알림메일 전송설정 수정</li>
            </ul>
        </fieldset>
        <br/>
        <fieldset class="fieldset1">
            <legend>공인인증서 관리</legend>
            <ul>
                <li><a href="Example/getTaxCertURL.aspx">getTaxCertURL</a> - 공인인증서 등록 URL</li>
                <li><a href="Example/getCertificateExpireDate.aspx">getCertificateExpireDate</a> - 공인인증서 만료일 확인</li>
                <li><a href="Example/checkCertValidation.aspx">checkCertValidation</a> - 공인인증서 유효성 확인</li>
            </ul>
        </fieldset>
        <br/>
        <fieldset class="fieldset1">
            <legend>포인트 관리</legend>
            <ul>
                <li><a href="Example/getBalance.aspx">getBalance</a> - 연동회원 잔여포인트 확인</li>
                <li><a href="Example/getChargeURL.aspx">getChargeURL</a> - 연동회원 포인트충전 URL</li>
                <li><a href="Example/getPartnerBalance.aspx">getPartnerBalance</a> - 파트너 잔여포인트 확인</li>
                <li><a href="Example/getPartnerURL.aspx">getPartnerURL</a> - 파트너 포인트충전 URL</li>
                <li><a href="Example/getUnitCost.aspx">getUnitCost</a> - 발행 단가 확인</li>
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
                <li><a href="Example/getCorpInfo.aspx">getCorpInfo</a> - 회사정보 확인</li>
                <li><a href="Example/updateCorpInfo.aspx">updateCorpInfo</a> - 회사정보 수정</li>
                <li><a href="Example/registContact.aspx">registContact</a> - 담당자 등록</li>
                <li><a href="Example/listContact.aspx">listContact</a> - 담당자 목록 확인</li>
                <li><a href="Example/updateContact.aspx">updateContact</a> - 담당자 정보 수정</li>
            </ul>
        </fieldset>
    </form>
</div>
</body>
</html>
