<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Popbill.HomeTax.Cashbill._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>팝빌 홈택스 현금영수증 매입/매출 조회 API SDK ASP.NET Example</title>
    <link href="Example.css" rel="stylesheet" type="text/css" />
</head>
	<body>
		<div id="content">

			<p class="heading1">팝빌 홈택스 현금영수증 매입/매출 조회 API SDK ASP.NET Example.</p>

			<br/>

			<fieldset class="fieldset1">
				<legend>팝빌 기본 API</legend>

				<fieldset class="fieldset2">
					<legend>회원사 정보</legend>
					<ul>
						<li><a href="Example/CheckIsMember.aspx">checkIsMember</a> - 연동회원 가입여부 확인</li>
						<li><a href="Example/CheckID.aspx">checkID</a> - 연동회원 아이디 중복 확인</li>
						<li><a href="Example/JoinMember.aspx">joinMember</a> - 연동회원 가입 요청</li>
                        <li><a href="Example/GetChargeInfo.aspx">getChargeInfo</a> - 과금정보 확인</li>
                        <li><a href="Example/GetBalance.aspx">getBalance</a> - 연동회원 잔여포인트 확인</li>
						<li><a href="Example/getPopbillURL.aspx">getPopbillURL</a> - 팝빌 SSO URL</li>
						<li><a href="Example/getPartnerBalance.aspx">getPartnerBalance</a> - 파트너 잔여포인트 확인</li>
						<li><a href="Example/getPartnerURL.aspx">getPartnerURL</a> - 파트너 포인트 충전 URL</li>
						<li><a href="Example/RegistContact.aspx">registContact</a> - 담당자 추가</li>
						<li><a href="Example/ListContact.aspx">listContact</a> - 담당자 목록 확인</li>
						<li><a href="Example/UpdateContact.aspx">updateContact</a> - 담당자 정보 수정</li>
						<li><a href="Example/GetCorpInfo.aspx">getCorpInfo</a> - 회사정보 확인</li>
						<li><a href="Example/UpdateCorpInfo.aspx">updateCorpInfo</a> - 회사정보 수정</li>
					</ul>
				</fieldset>
			</fieldset>

			<br />

			    <fieldset class="fieldset1">
				<legend>홈택스 현금영수증 연계 관련 API</legend>

				<fieldset class="fieldset2">
					<legend>매출/매입 내역 수집</legend>
					<ul>
						<li><a href="Example/RequestJob.aspx">RequestJob</a> - 수집 요청</li>
						<li><a href="Example/GetJobState.aspx">GetJobState</a> - 수집 상태 확인</li>
						<li><a href="Example/ListActiveJob.aspx">ListActiveJob</a> - 수집 상태 목록 확인</li>
					</ul>
				</fieldset>

                <fieldset class="fieldset2">
					<legend>매출/매입 수집 결과 조회</legend>
					<ul>
						<li><a href="Example/Search.aspx">Search</a> - 수집 결과 조회</li>
						<li><a href="Example/Summary.aspx">Summary</a> - 수집 결과 요약정보 조회</li>
					</ul>
				</fieldset>

				<fieldset class="fieldset2">
					<legend>부가기능</legend>
					<ul>
						<li><a href="Example/GetFlatRatePopUpURL.aspx">GetFlatRatePopUpURL</a> - 정액제 서비스 신청 URL</li>
						<li><a href="Example/GetFlatRateState.aspx">GetFlatRateState</a> - 정액제 서비스 상태 확인</li>
						<li><a href="Example/GetCertificatePopUpURL.aspx">GetCertificatePopUpURL</a> - 홈택스연동 인증관리 팝업 URL</li>
						<li><a href="Example/GetCertificateExpireDate.aspx">GetCertificateExpireDate</a> - 홈택스연동 공인인증서 만료일자 확인</li>
					</ul>
				</fieldset>
			</fieldset>
		 </div>
	</body>
</html>
