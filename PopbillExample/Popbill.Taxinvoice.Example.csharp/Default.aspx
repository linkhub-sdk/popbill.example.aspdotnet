<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Popbill.Taxinvoice.Common" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>팝빌 세금계산서 SDK ASP.NET Example</title>
    <link href="Example.css" rel="stylesheet" type="text/css" />
</head>
<body>
<div id="content">
    <p class="heading1">팝빌 세금계산서 SDK ASP.NET Example</p>
    <br />
    <form id="form1" runat="server">
        <fieldset class="fieldset1">
            <legend>정방행/역발행/위수탁발행</legend>
            <ul>
                <li><a href="Example/checkMgtKeyInUse.aspx">CheckMgtKeyInUse</a> - 관리번호 확인</li>
                <li><a href="Example/registIssue.aspx">RegistIssue</a> - 즉시 발행</li>
                <li><a href="Example/register.aspx">Register</a> - 임시저장</li>
                <li><a href="Example/update.aspx">Update</a> - 수정</li>
                <li><a href="Example/issue.aspx">Issue</a> - 발행</li>
                <li><a href="Example/cancelIssue.aspx">CancelIssue</a> - 발행취소</li>
                <li><a href="Example/send.aspx">Send</a> - [발행예정]</li>
                <li><a href="Example/cancelSend.aspx">CancelSend</a> - [발행예정] 취소</li>
                <li><a href="Example/accept.aspx">Accept</a> - [발행예정] 승인</li>
                <li><a href="Example/deny.aspx">Deny</a> - [발행예정] 거부</li>
                <li><a href="Example/delete.aspx">Delete</a> - 삭제</li>
                <li><a href="Example/registRequest.aspx">RegistRequest</a> - [역발행] 즉시 요청</li>
                <li><a href="Example/request.aspx">Request</a> - 역발행요청</li>
                <li><a href="Example/cancelRequest.aspx">CancelRequest</a> - 역발행요청 취소</li>
                <li><a href="Example/refuse.aspx">Refuse</a> - 역발행요청 거부</li>
            </ul>
        </fieldset>
        <br/>
        <fieldset class="fieldset1">
            <legend>국세청 즉시 전송</legend>
            <ul>
                <li><a href="Example/sendToNTS.aspx">SendToNTS</a> - 국세청 즉시전송</li>
            </ul>
        </fieldset>
        <br/>
        <fieldset class="fieldset1">
            <legend>세금계산서 정보확인</legend>
            <ul>
                <li><a href="Example/getInfo.aspx">GetInfo</a> - 상태 확인</li>
                <li><a href="Example/getInfos.aspx">GetInfos</a> - 상태 대량 확인</li>
                <li><a href="Example/getDetailInfo.aspx">GetDetailInfo</a> - 상세정보 확인</li>
                <li><a href="Example/search.aspx">Search</a> - 목록 조회</li>
                <li><a href="Example/getLogs.aspx">GetLogs</a> - 상태 변경이력 확인</li>
                <li><a href="Example/getURL.aspx">GetURL</a> - 세금계산서 문서함 관련 URL</li>
            </ul>
        </fieldset>
        <br/>
        <fieldset class="fieldset1">
            <legend>세금계산서 보기/인쇄</legend>
            <ul>
                <li><a href="Example/getPopUpURL.aspx">GetPopUpURL</a> - 세금계산서 보기 URL</li>
                <li><a href="Example/getPrintURL.aspx">GetPrintURL</a> - 세금계산서 인쇄 [공급자/공급받는자] URL</li>
                <li><a href="Example/getEPrintURL.aspx">GetEPrintURL</a> - 세금계산서 인쇄 [공급받는자용] URL</li>
                <li><a href="Example/getMassPrintURL.aspx">GetMassPrintURL</a> - (세금계산서 대량 인쇄 URL</li>
                <li><a href="Example/getMailURL.aspx">GetMailURL</a> - 세금계산서 메일링크 URL</li>
            </ul>
        </fieldset>
        <br/>
        <fieldset class="fieldset1">
            <legend>부가기능</legend>
            <ul>
                <li><a href="Example/getAccessURL.aspx">GetAccessURL</a> - 팝빌 로그인 URL</li>
                <li><a href="Example/getSealURL.aspx"> GetSealURL</a> - 인감 및 첨부문서 등록 URL</li>
                <li><a href="Example/attachFile.aspx">AttachFile</a> - 첨부파일 추가</li>
                <li><a href="Example/deleteFile.aspx">DeleteFile</a> - 첨부파일 삭제</li>
                <li><a href="Example/getFiles.aspx">GetFiles</a> - 첨부파일 목록 확인</li>
                <li><a href="Example/sendEmail.aspx">SendEmail</a> - 메일 전송</li>
                <li><a href="Example/sendSMS.aspx">SendSMS</a> - 문자 전송</li>
                <li><a href="Example/sendFAX.aspx">SendFAX</a> - 팩스 전송</li>
                <li><a href="Example/attachStatement.aspx">AttachStatement</a> - 전자명세서 첨부</li>
                <li><a href="Example/detachStatement.aspx">DetachStatement</a> - 전자명세서 첨부해제</li>
                <li><a href="Example/getEmailPublicKeys.aspx">GetEmailPublicKeys</a> - 유통사업자 메일 목록 확인</li>
                <li><a href="Example/assignMgtKey.aspx">AssignMgtKey</a> - 관리번호 할당</li>
                <li><a href="Example/listEmailConfig.aspx">ListEmailConfig</a> - 세금계산서 알림메일 전송목록 조회</li>
                <li><a href="Example/updateEmailConfig.aspx">UpdateEmailConfig</a> - 세금계산서 알림메일 전송설정 수정</li>
            </ul>
        </fieldset>
        <br/>
        <fieldset class="fieldset1">
            <legend>공인인증서 관리</legend>
            <ul>
                <li><a href="Example/getTaxCertURL.aspx">GetTaxCertURL</a> - 공인인증서 등록 URL</li>
                <li><a href="Example/getCertificateExpireDate.aspx">GetCertificateExpireDate</a> - 공인인증서 만료일 확인</li>
                <li><a href="Example/checkCertValidation.aspx">CheckCertValidation</a> - 공인인증서 유효성 확인</li>
            </ul>
        </fieldset>
        <br/>
        <fieldset class="fieldset1">
            <legend>포인트 관리</legend>
            <ul>
                <li><a href="Example/getBalance.aspx">GetBalance</a> - 연동회원 잔여포인트 확인</li>
                <li><a href="Example/getChargeURL.aspx">GetChargeURL</a> - 연동회원 포인트충전 URL</li>
                <li><a href="Example/getPartnerBalance.aspx">GetPartnerBalance</a> - 파트너 잔여포인트 확인</li>
                <li><a href="Example/getPartnerURL.aspx">GetPartnerURL</a> - 파트너 포인트충전 URL</li>
                <li><a href="Example/getUnitCost.aspx">GetUnitCost</a> - 발행 단가 확인</li>
                <li><a href="Example/getChargeInfo.aspx">GetChargeInfo</a> - 과금정보 확인</li>
            </ul>
        </fieldset>
        <br/>
        <fieldset class="fieldset1">
            <legend>회원정보</legend>
            <ul>
                <li><a href="Example/checkIsMember.aspx">CheckIsMember</a> - 연동회원 가입여부 확인</li>
                <li><a href="Example/checkID.aspx">CheckID</a> - 아이디 중복 확인</li>
                <li><a href="Example/joinMember.aspx">JoinMember</a> - 연동회원 신규가입</li>
                <li><a href="Example/getCorpInfo.aspx">GetCorpInfo</a> - 회사정보 확인</li>
                <li><a href="Example/updateCorpInfo.aspx">UpdateCorpInfo</a> - 회사정보 수정</li>
                <li><a href="Example/registContact.aspx">RegistContact</a> - 담당자 등록</li>
                <li><a href="Example/listContact.aspx">ListContact</a> - 담당자 목록 확인</li>
                <li><a href="Example/updateContact.aspx">UpdateContact</a> - 담당자 정보 수정</li>
            </ul>
        </fieldset>
    </form>
</div>
</body>
</html>
