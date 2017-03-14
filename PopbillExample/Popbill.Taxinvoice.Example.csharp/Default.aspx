<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Popbill.Taxinvoice.Common" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>팝빌 세금계산서 SDK ASP.NET Example</title>
    <link href="Example.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <div id="content">
        <p class="heading1">팝빌 세금계산서 SDK ASP.NET Example</p>
        <br />
        <form id="form1" runat="server">        
        	<fieldset class="fieldset1">
				<legend>팝빌 기본 API</legend>

				<fieldset class="fieldset2">
					<legend>회원사 정보</legend>
					<ul>
					    <li><a href="Example/checkIsMember.aspx">checkIsMember</a> - 연동회원 가입여부 확인</li>
					    <li><a href="Example/checkID.aspx">checkID</a> - 연동회원 아이디 중복 확인</li>
					    <li><a href="Example/joinMember.aspx">joinMember</a> - 연동회원 가입 요청</li>
					    <li><a href="Example/getChargeInfo.aspx">getChargeInfo</a> - 과금정보 확인</li>
					    <li><a href="Example/getBalance.aspx">getBalance</a> - 연동회원 잔여포인트 확인</li>
					    <li><a href="Example/getPartnerBalance.aspx">getPartnerBalance</a> - 파트너 잔여포인트 확인</li>
					    <li><a href="Example/getPopbillURL.aspx">getPopbillURL</a> - 팝빌 SSO URL(로그인, 포인트 충전, 공인인증서등록) 확인</li>
					    <li><a href="Example/registContact.aspx">registContact</a> - 담당자 추가</li>
					    <li><a href="Example/listContact.aspx">listContact</a> - 담당자 목록 확인</li>
					    <li><a href="Example/updateContact.aspx">updateContact</a> - 담당자 정보 수정</li>
					    <li><a href="Example/getCorpInfo.aspx">getCorpInfo</a> - 회사정보 확인</li>
					    <li><a href="Example/updateCorpInfo.aspx">updateCorpInfo</a> - 회사정보 수정</li>
					</ul>
				</fieldset>
			</fieldset>		
			<br />

			<fieldset class="fieldset1">
				<legend>전자세금계산서 관련 API</legend>

				<fieldset class="fieldset2">
					<legend>등록/수정/확인/삭제</legend>
					<ul>
						<li><a href="Example/checkMgtKeyInUse.aspx">checkMgtKeyInUse</a> - 세금계산서 관리번호 사용여부 확인</li>
                        <li><a href="Example/registIssue.aspx">registIssue</a> - 세금계산서 즉시발행</li>
						<li><a href="Example/register.aspx">register</a> - 세금계산서 임시저장</li>
						<li><a href="Example/update.aspx">update</a> - 세금계산서 수정</li>
						<li><a href="Example/getInfo.aspx">getInfo</a> - 세금계산서 상태/요약 정보 확인</li>
						<li><a href="Example/getInfos.aspx">getInfos</a> - 세금계산서 상태/요약 정보 확인 - 대량</li>
						<li><a href="Example/getDetailInfo.aspx">getDetailInfo</a> - 세금계산서 상세 정보 확인</li>
						<li><a href="Example/delete.aspx">delete</a> - 세금계산서 삭제</li>
						<li><a href="Example/getLogs.aspx">getLogs</a> - 세금계산서 문서 상태변경 이력</li>
						<li><a href="Example/search.aspx">search</a> - 세금계산서 기간조회</li>
						<li><a href="Example/attachFile.aspx">attachFile</a> - 세금계산서 첨부파일 추가</li>
						<li><a href="Example/getFiles.aspx">getFiles</a> - 세금계산서 첨부파일 목록확인</li>
						<li><a href="Example/deleteFile.aspx">deleteFile</a> - 세금계산서 첨부파일 삭제</li>
					</ul>
				</fieldset>

				<fieldset class="fieldset2">
					<legend>처리 프로세스</legend>
					<ul>
						<li><a href="Example/send.aspx">send</a> - 세금계산서 발행예정</li>
						<li><a href="Example/cancelSend.aspx">cancelSend</a> - 발행예정 취소</li>
						<li><a href="Example/accept.aspx">accept</a> - 발행예정 승인</li>
						<li><a href="Example/deny.aspx">deny</a> - 발행예정 거부</li>
						<li><a href="Example/issue.aspx">issue</a> - 세금계산서 발행</li>
						<li><a href="Example/cancelIssue.aspx">cancelIssue</a> - 세금계산서 발행취소</li>
						<li><a href="Example/Request.aspx">request</a> - 세금계산서 역발행요청</li>
						<li><a href="Example/CancelRequest.aspx">cancelRequest</a> - 역발행 세금계산서 취소</li>
						<li><a href="Example/refuse.aspx">refuse</a> -  역발행 세금계산서 거부</li>
						<li><a href="Example/sendToNTS.aspx">sendToNTS</a> - 국세청 즉시전송</li>
					</ul>
				</fieldset>

				<fieldset class="fieldset2">
					<legend>부가 기능</legend>
					<ul>
						<li><a href="Example/sendEmail.aspx">sendEmail</a> - 발행 안내메일 전송</li>
						<li><a href="Example/sendSMS.aspx">sendSMS</a> - 알림문자 전송</li>
						<li><a href="Example/sendFAX.aspx">sendFAX</a> - 세금계산서 팩스 전송</li>
						<li><a href="Example/attachStatement.aspx">attachStatement</a> - 전자명세서 첨부</li>
						<li><a href="Example/detachStatement.aspx">detachStatement</a> - 전자명세서 첨부해제</li>
					</ul>
				</fieldset>

				<fieldset class="fieldset2">
					<legend>팝빌 세금계산서 SSO URL 기능</legend>
					<ul>
						<li><a href="Example/getURL.aspx">getURL</a> - 세금계산서 관련 SSO URL 확인</li>
						<li><a href="Example/getPopUpURL.aspx">getPopUpURL</a> - 세금계산서 보기 팝업 URL</li>
						<li><a href="Example/getPrintURL.aspx">getPrintURL</a> - 세금계산서 인쇄 팝업 URL</li>
						<li><a href="Example/getMassPrintURL.aspx">getMassPrintURL</a> - 세금계산서 인쇄 팝업 URL - 대량 (최대 100건))</li>
						<li><a href="Example/getEPrintURL.aspx">getEPrintURL</a> - 세금계산서 인쇄 팝업 URL - 공급받는자</li>
						<li><a href="Example/getMailURL.aspx">getMailURL</a> - 세금계산서 공급받는자 메일링크 URL</li>
					</ul>
				</fieldset>

				<fieldset class="fieldset2">
					<legend>기타</legend>
					<ul>
						<li><a href="Example/getUnitCost.aspx">getUnitCost</a> - 세금계산서 발행 단가 확인</li>
						<li><a href="Example/getCertificateExpireDate.aspx">getCertificateExpireDate</a> - 공인인증서 만료일시 확인</li>
						<li><a href="Example/getEmailPublicKeys.aspx">getEmailPublicKeys</a> - 대용량 연계사업자 이메일 목록 확인</li>
					</ul>
				</fieldset>
			</fieldset>
				        
        </form>
    </div>
</body>
</html>
