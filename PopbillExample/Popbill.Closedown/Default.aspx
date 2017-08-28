<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Popbill.Closedown._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>팝빌 휴폐업조회 API SDK ASP.NET Example</title>
    <link href="./Example.css" rel="stylesheet" type="text/css" />
</head>
	<body>
		<div id="content">
			<p class="heading1">팝빌 휴폐업조회 SDK ASP.NET Example.</p>
			<br/>

			<fieldset class="fieldset1">
				<legend>팝빌 기본 API</legend>

				<fieldset class="fieldset2">
					<legend>회원정보</legend>
					<ul>
						<li><a href="Example/CheckIsMember.aspx">checkIsMember</a> - 연동회원 가입 여부 확인</li>
						<li><a href="Example/CheckID.aspx">checkID</a> - 연동회원 아이디 중복 확인</li>
						<li><a href="Example/JoinMember.aspx">joinMember</a> - 연동회원 가입 요청</li>
                        <li><a href="Example/GetChargeInfo.aspx">GetChargeInfo</a> - 과금정보 확인</li>
						<li><a href="Example/GetBalance.aspx">GetBalance</a> - 연동회원 잔여포인트 확인</li>
						<li><a href="Example/getPopbillURL.aspx">getPopbillURL</a> - 팝빌 SSO URL</li>
						<li><a href="Example/getPartnerBalance.aspx">getPartnerBalance</a> - 파트너 잔여포인트 확인</li>
						<li><a href="Example/getPartnerURL.aspx">getPartnerURL</a> - 파트너 포인트 충전 URL</li>
						<li><a href="Example/GetUnitCost.aspx">getUnitCost</a> - 조회단가 확인</li>
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
				<legend>휴폐업조회 관련 API</legend>

				<fieldset class="fieldset2">
					<legend>휴폐업조회 </legend>
					<ul>
						<li><a href="Example/CheckCorpNum.aspx">checkCorpNum</a> - 휴폐업조회 (단건)</li>
						<li><a href="Example/CheckCorpNums.aspx">checkCorpNums</a> - 휴폐업조회 (대량)</li>
					</ul>
				</fieldset>
			</fieldset>
		 </div>
	</body>
</html>
