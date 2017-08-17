<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Popbill.Cashbill._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>팝빌 현금영수증 SDK ASP.NET Example</title>
    <link href="Example.css" rel="stylesheet" type="text/css" />
</head>
	<body>
		<div id="content">
			<p class="heading1">팝빌 현금영수증 SDK ASP.NET Example.</p>
			<br/>
			<fieldset class="fieldset1">
				<legend>팝빌 기본 API</legend>

				<fieldset class="fieldset2">
					<legend>회원정보</legend>
					<ul>
						<li><a href="Example/checkIsMember.aspx">checkIsMember</a> - 연동회원 가입여부 확인</li>
						<li><a href="Example/checkID.aspx">checkID</a> - 연동회원 아이디 중복 확인</li>
						<li><a href="Example/joinMember.aspx">joinMember</a> - 연동회원 가입 요청</li>
                        <li><a href="Example/getChargeInfo.aspx">getChargeInfo</a> - 과금정보 확인</li>
						<li><a href="Example/getBalance.aspx">getBalance</a> - 연동회원 잔여포인트 확인</li>
						<li><a href="Example/getPartnerBalance.aspx">getPartnerBalance</a> - 파트너 잔여포인트 확인</li>
						<li><a href="Example/getPopbillURL.aspx">getPopbillURL</a> - 팝빌 SSO URL 요청</li>
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
				<legend>현금영수증 관련 API</legend>

				<fieldset class="fieldset2">
					<legend>등록/수정/발행/삭제</legend>
					<ul>
						<li><a href="Example/checkMgtKeyInUse.aspx">checkMgtKeyInUse</a> - 문서관리번호 사용여부 확인</li>
						<li><a href="Example/registIssue.aspx">registIssue</a> - 현금영수증 즉시발행</li>
						<li><a href="Example/register.aspx">register</a> - 현금영수증 임시저장</li>
						<li><a href="Example/update.aspx">update</a> - 현금영수증 수정</li>
						<li><a href="Example/issue.aspx">issue</a> - 현금영수증 발행</li>
						<li><a href="Example/cancelIssue.aspx">cancelIssue</a> - 현금영수증 발행취소</li>
						<li><a href="Example/delete.aspx">delete</a> - 현금영수증 삭제</li>
					</ul>
				</fieldset>
				
				<fieldset class="fieldset2">
					<legend>취소현금영수증 발행</legend>
					<ul>
						<li><a href="Example/revokeRegistIssue.aspx">revokeRegistIssue</a> - 취소현금영수증 즉시발행</li>
						<li><a href="Example/revokeRegister.aspx">revokeRegister</a> - 취소현금영수증 임시저장</li>
						
					</ul>
				</fieldset>

				<fieldset class="fieldset2">
					<legend>정보 확인</legend>
					<ul>
						<li><a href="Example/getInfo.aspx">getInfo</a> - 현금영수증 상태/요약정보 확인</li>
						<li><a href="Example/getInfos.aspx">getInfos</a> - 현금영수증 상태/요약정보 확인 - 대량</li>
						<li><a href="Example/getLogs.aspx">getLogs</a> - 현금영수증 상태변경 이력 확인</li>
						<li><a href="Example/getDetailInfo.aspx">getDetailInfo</a> - 현금영수증 상세정보 확인</li>
						<li><a href="Example/search.aspx">search</a> - 현금영수증 목록조회</li>
					</ul>
				</fieldset>

				<fieldset class="fieldset2">
					<legend>부가기능</legend>
					<ul>
						<li><a href="Example/sendEmail.aspx">sendEmail</a> - 알림메일 전송</li>
						<li><a href="Example/sendSMS.aspx">sendSMS</a> - 알림문자 전송</li>
						<li><a href="Example/sendFAX.aspx">sendFAX</a> - 현금영수증 팩스전송</li>
					</ul>
				</fieldset>

				<fieldset class="fieldset2">
					<legend>팝빌 현금영수증 SSO URL 기능</legend>
					<ul>
						<li><a href="Example/getURL.aspx">getURL</a> - 현금영수증 관련 SSO URL 확인</li>
						<li><a href="Example/getPopUpURL.aspx">getPopUpURL</a> - 현금영수증 보기 팝업 URL</li>
						<li><a href="Example/getPrintURL.aspx">getPrintURL</a> - 현금영수증 인쇄 팝업 URL</li>
						<li><a href="Example/getEPrintURL.aspx">getEPrintURL</a> - 현금영수증 인쇄 팝업 URL - 공급받는자용</li>
						<li><a href="Example/getMassPrintURL.aspx">getMassPrintURL</a> - 현금영수증 인쇄 팝업 URL - 대량 </li>
						<li><a href="Example/getMailURL.aspx">getMailURL</a> - 현금영수증 메일링크 URL</li>
					</ul>
				</fieldset>
				<fieldset class="fieldset2">
					<legend>기타</legend>
					<ul>
						<li><a href="Example/getUnitCost.aspx">getUnitCost</a> - 현금영수증 발행단가 확인</li>
					</ul>
				</fieldset>

			</fieldset>
		 </div>
	</body>
</html>
