<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Popbill.Fax._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>팝빌 팩스 SDK ASP.NET Example</title>
    <link href="./Example.css" rel="stylesheet" type="text/css" />
</head>
	<body>
		<div id="content">

			<p class="heading1">팝빌 팩스 SDK ASP.NET Example.</p>

			<br/>

			<fieldset class="fieldset1">
				<legend>팝빌 기본 API</legend>

				<fieldset class="fieldset2">
					<legend>회원사 정보</legend>
					<ul>
						<li><a href="Example/CheckIsMember.aspx">checkIsMember</a> - 연동회원사 가입 여부 확인</li>
						<li><a href="Example/CheckID.aspx">checkID</a> - 연동회원 아이디 중복 확인</li>
						<li><a href="Example/JoinMember.aspx">joinMember</a> - 연동회원사 가입 요청</li>
                        <li><a href="Example/GetChargeInfo.aspx">getChargeInfo</a> - 과금정보 확인</li>
                        <li><a href="Example/GetBalance.aspx">getBalance</a> - 연동회원사 잔여포인트 확인</li>
						<li><a href="Example/getPopbillURL.aspx">getPopbillURL</a> - 팝빌 SSO URL</li>
						<li><a href="Example/getPartnerBalance.aspx">getPartnerBalance</a> - 파트너 잔여포인트 확인</li>
						<li><a href="Example/getPartnerURL.aspx">getPartnerURL</a> - 파트너 포인트 충전 URL</li>
						<li><a href="Example/RegistContact.aspx">registContact</a> - 담당자 추가</li>
						<li><a href="Example/ListContact.aspx">listContact</a> - 담당자 목록 확인</li>
						<li><a href="Example/UpdateContact.aspx">updateContact</a> - 담당자 정보 수정</li>
						<li><a href="Example/GetCorpInfo.aspx">GetCorpInfo</a> - 회사정보 확인</li>
						<li><a href="Example/UpdateCorpInfo.aspx">UpdateCorpInfo</a> - 회사정보 수정</li>
					</ul>
				</fieldset>

			</fieldset>
			<br />
			<fieldset class="fieldset1">
				<legend>팩스 관련 API</legend>

				<fieldset class="fieldset2">
					<legend>팩스 전송</legend>
					<ul>
						<li><a href="Example/SendFAX.aspx">sendFAX</a> - 팩스 전송. 1파일 1건 전송</li>
						<li><a href="Example/SendFAX_Multi.aspx">sendFAX_Multi</a> - 팩스 전송. 1파일 동보 전송(수신번호 최대 1000개)</li>
                        <li><a href="Example/ResendFAX.aspx">ResendFAX</a> - 팩스 재전송</li>
                        <li><a href="Example/ResendFAX_Multi.aspx">ResendFAX_Multi</a> - 팩스 동보 재전송</li>
					</ul>
				</fieldset>

				<fieldset class="fieldset2">
					<legend>전송결과/예약취소</legend>
					<ul>
						<li><a href="Example/GetFaxResult.aspx">getFaxDetail</a> - 팩스전송 전송결과 확인</li>
						<li><a href="Example/Search.aspx">search</a> - 팩스전송 목록조회</li>
						<li><a href="Example/CancelReserve.aspx">cancelReserve</a> - 예약전송 팩스 취소</li>
					</ul>
				</fieldset>

				<fieldset class="fieldset2">
					<legend>기타</legend>
					<ul>
						<li><a href="Example/GetURL.aspx">getURL</a> - 팩스 API 관련 팝업 URL</li>
						<li><a href="Example/GetUnitCost.aspx">getUnitCost</a> - 팩스 전송단가 확인</li>
						<li><a href="Example/GetSenderNumberList.aspx">getSenderNumberList</a> - 팩스 발신번호 목록 확인</li>
					</ul>
				</fieldset>
			</fieldset>
		 </div>
	</body>
</html>
