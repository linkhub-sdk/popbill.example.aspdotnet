<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Popbill.Kakao._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>팝빌 카카오톡 SDK ASP.NET Example</title>
    <link href="Example.css" rel="stylesheet" type="text/css" />
</head>
<body>
		<div id="content">
			<p class="heading1">팝빌 카카오톡 SDK ASP.NET Example.</p>
			<br/>

      		<fieldset class="fieldset1">
				<legend>플리스친구 계정관리</legend>
				<ul>
					<li><a href="Example/getURL_PLUSFRIEND.aspx">GetURL</a> - 플러스친구 계정관리 팝업 URL</li>
          			<li><a href="Example/listPlusFriendID.aspx">ListPlusFriendID</a> - 플러스친구 목록 확인</li>
				</ul>
			</fieldset>

			<fieldset class="fieldset1">
				<legend>발신번호 관리</legend>
				<ul>
					<li><a href="Example/getURL_SENDER.aspx">GetURL</a> - 발신번호 관리 팝업 URL</li>
          			<li><a href="Example/getSenderNumberList.aspx">GetSenderNumberList</a> - 발신번호 목록 확인</li>
				</ul>
			</fieldset>

      		<fieldset class="fieldset1">
				<legend>알림톡 템플릿 관리</legend>
				<ul>
					<li><a href="Example/getURL_TEMPLATE.aspx">GetURL</a> - 알림톡 템플릿관리 팝업 URL</li>
          			<li><a href="Example/listATSTemplate.aspx">ListATSTemplate</a> - 알림톡 템플릿 목록 확인</li>
				</ul>
			</fieldset>

		      <fieldset class="fieldset1">
				<legend>알림톡 전송</legend>
				<ul>
					<li><a href="Example/sendATS_one.aspx">SendATS</a> - 알림톡 단건 전송</li>
         			<li><a href="Example/sendATS_same.aspx">SendATS</a> - 알림톡 동일내용 대량 전송</li>
          			<li><a href="Example/sendATS_multi.aspx">SendATS</a> - 알림톡 개별내용 대량 전송</li>
				</ul>
			</fieldset>

      		<fieldset class="fieldset1">
				<legend>친구톡 텍스트 전송</legend>
				<ul>
					<li><a href="Example/sendFTS_one.aspx">SendFTS</a> - 친구톡 텍스트 단건 전송</li>
          			<li><a href="Example/sendFTS_same.aspx">SendFTS</a> - 친구톡 텍스트 동일내용 대량전송</li>
          			<li><a href="Example/sendFTS_multi.aspx">SendFTS</a> - 친구톡 텍스트 개별내용 대량전송</li>
				</ul>
			</fieldset>

      		<fieldset class="fieldset1">
				<legend>친구톡 이미지 전송</legend>
				<ul>
					<li><a href="Example/sendFMS_one.aspx">SendFMS</a> - 친구톡 이미지 단건 전송</li>
          			<li><a href="Example/sendFMS_same.aspx">SendFMS</a> - 친구톡 이미지 동일내용 대량전송</li>
          			<li><a href="Example/sendFMS_multi.aspx">SendFMS</a> - 친구톡 이미지 개별내용 대량전송</li>
				</ul>
			</fieldset>

      		<fieldset class="fieldset1">
				<legend>예약전송 취소</legend>
				<ul>
					<li><a href="Example/cancelReserve.aspx">CancelReserve</a> - 예약전송 취소</li>
				</ul>
			</fieldset>

      		<fieldset class="fieldset1">
				<legend>정보확인</legend>
				<ul>
					<li><a href="Example/getMessages.aspx">GetMessages</a> - 알림톡/친구톡 전송내역 확인</li>
          			<li><a href="Example/search.aspx">Search</a> - 전송내역 목록 조회</li>
          			<li><a href="Example/getURL_BOX.aspx">GetURL</a> - 카카오톡 전송내역 팝업 URL</li>
				</ul>
			</fieldset>

      		<fieldset class="fieldset1">
				<legend>포인트관리</legend>
				<ul>
					<li><a href="Example/getUnitCost.aspx">GetUnitCost</a> - 전송단가 확인</li>
          			<li><a href="Example/getChargeInfo.aspx">GetChargeInfo</a> - 과금정보 확인</li>
          			<li><a href="Example/getBalance.aspx">GetBalance</a> - 연동회원 잔여포인트 확인</li>
          			<li><a href="Example/getPopbillURL_CHRG.aspx">GetPopbillURL</a> - 연동회원 포인트 충전 팝업 URL</li>
          			<li><a href="Example/getPartnerBalance.aspx">GetPartnerBalance</a> - 파트너 잔여포인트 확인</li>
          			<li><a href="Example/getPartnerURL.aspx">GetPartnerURL</a> - 파트너 포인트충전 URL</li>
				</ul>
			</fieldset>

      		<fieldset class="fieldset1">
				<legend>회원관리</legend>
				<ul>
					<li><a href="Example/checkIsMember.aspx">CheckIsMember</a> - 연동회원 가입여부 확인</li>
					<li><a href="Example/checkID.aspx">CheckID</a> - 연동회원 아이디 중복 확인</li>
					<li><a href="Example/joinMember.aspx">JoinMember</a> - 연동회원사 신규가입</li>
          			<li><a href="Example/getPopbillURL_LOGIN.aspx">GetPopbillURL</a> - 팝빌 로그인 URL</li>
          			<li><a href="Example/registContact.aspx">RegistContact</a> - 담당자 추가</li>
					<li><a href="Example/listContact.aspx">ListContact</a> - 담당자 목록 확인</li>
					<li><a href="Example/updateContact.aspx">UpdateContact</a> - 담당자 정보 수정</li>
					<li><a href="Example/getCorpInfo.aspx">GetCorpInfo</a> - 회사정보 확인</li>
					<li><a href="Example/updateCorpInfo.aspx">UpdateCorpInfo</a> - 회사정보 수정</li>
				</ul>
			</fieldset>


		 </div>
	</body>
</html>
