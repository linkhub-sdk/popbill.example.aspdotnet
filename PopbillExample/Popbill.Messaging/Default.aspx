<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Popbill.Messaging._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>팝빌 문자 SDK ASP.NET Example</title>
    <link href="Example.css" rel="stylesheet" type="text/css" />
</head>
	<body>
		<div id="content">

			<p class="heading1">팝빌 문자메시지 SDK ASP.NET Example.</p>

			<br/>

			<fieldset class="fieldset1">
				<legend>팝빌 기본 API</legend>

				<fieldset class="fieldset2">
					<legend>회원사 정보</legend>
					<ul>
						<li><a href="Example/checkIsMember.aspx">checkIsMember</a> - 연동회원사 가입 여부 확인</li>
						<li><a href="Example/checkID.aspx">checkID</a> - 연동회원 아이디 중복 확인</li>
						<li><a href="Example/joinMember.aspx">joinMember</a> - 연동회원사 가입 요청</li>
                        <li><a href="Example/getChargeInfo.aspx">getChargeInfo</a> - 과금정보 확인</li>
                        <li><a href="Example/getBalance.aspx">getBalance</a> - 연동회원사 잔여포인트 확인</li>
						<li><a href="Example/getPopbillURL.aspx">getPopbillURL</a> - 팝빌 SSO URL</li>
						<li><a href="Example/getPartnerBalance.aspx">getPartnerBalance</a> - 파트너 잔여포인트 확인</li>
						<li><a href="Example/getPartnerURL.aspx">getPartnerURL</a> - 파트너 포인트 충전 URL</li>
						<li><a href="Example/registContact.aspx">registContact</a> - 담당자 추가</li>
						<li><a href="Example/listContact.aspx">listContact</a> - 담당자 목록 확인</li>
						<li><a href="Example/updateContact.aspx">updateContact</a> - 담당자 정보 수정</li>
						<li><a href="Example/getCorpInfo.aspx">GetCorpInfo</a> - 회사정보 확인</li>
						<li><a href="Example/updateCorpInfo.aspx">UpdateCorpInfo</a> - 회사정보 수정</li>
					</ul>
				</fieldset>

			</fieldset>

			<br />

			<fieldset class="fieldset1">
				<legend>문자메시지 관련 API</legend>

				<fieldset class="fieldset2">
					<legend>단문 문자 전송</legend>
					<ul>
						<li><a href="Example/sendSMS.aspx">sendSMS</a> - 단문 문자메시지 1건 전송</li>
						<li><a href="Example/sendSMS_Multi.aspx">sendSMS</a> - 단문 문자메시지 다량(최대1000건) 전송</li>
					</ul>
				</fieldset>

				<fieldset class="fieldset2">
					<legend>장문 문자 전송</legend>
					<ul>
						<li><a href="Example/sendLMS.aspx">sendLMS</a> - 장문 문자메시지 1건 전송</li>
						<li><a href="Example/sendLMS_Multi.aspx">sendLMS</a> - 장문 문자메시지 다량(최대1000건) 전송</li>
					</ul>
				</fieldset>

				<fieldset class="fieldset2">
					<legend>단/장문 문자 자동인식 전송</legend>
					<ul>
						<li><a href="Example/sendXMS.aspx">sendXMS</a> - 단/장문 자동인식 문자메시지 1건 전송</li>
						<li><a href="Example/sendXMS_Multi.aspx">sendXMS</a> - 단/장문 자동인식 문자메시지 다량(최대1000건) 전송</li>
					</ul>
				</fieldset>

				<fieldset class="fieldset2">
					<legend>포토 문자 전송</legend>
					<ul>
						<li><a href="Example/sendMMS.aspx">sendMMS</a> - 포토 문자메시지 1건 전송</li>
						<li><a href="Example/sendMMS_Multi.aspx">sendMMS</a> - 포토 문자메시지 (최대1000건) 전송</li>
					</ul>
				</fieldset>

				<fieldset class="fieldset2">
					<legend>전송결과/예약취소</legend>
					<ul>
						<li><a href="Example/search.aspx">search</a> - 문자전송 목록 조회</li>
						<li><a href="Example/getMessages.aspx">getMessages</a> - 문자메시지 전송결과 확인</li>
						<li><a href="Example/getMessagesRN.aspx">getMessagesRN</a> - 문자메시지 전송결과 확인 (요청번호할당)</li>
						<li><a href="Example/cancelReserve.aspx">cancelReserve</a> - 예약문자 메시지 예약취소</li>			
						<li><a href="Example/cancelReserveRN.aspx">cancelReserveRN</a> - 예약문자 메시지 예약취소 (요청번호할당)</li>
					</ul>
				</fieldset>

				<fieldset class="fieldset2">
					<legend>기타</legend>
					<ul>
						<li><a href="Example/getURL.aspx">getURL</a> - 문자메시지 관련 SSO URL 확인</li>
						<li><a href="Example/getUnitCost.aspx">getUnitCost</a> - 문자 전송 단가 확인</li>
						<li><a href="Example/getAutoDenyList.aspx">getAutoDenyList</a> - 080 수신거부 목록 확인</li>
						<li><a href="Example/getSenderNumberList.aspx">getSenderNumberList</a> - 문자 발신번호 목록 확인</li>
						<li><a href="Example/getStates.aspx">getStates</a> - 전송내역 요약정보 확인</li>
					</ul>
				</fieldset>
			</fieldset>
		 </div>
	</body>
</html>
