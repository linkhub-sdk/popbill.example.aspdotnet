<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Common.aspx.cs" Inherits="Popbill.Taxinvoice.Common" %>

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
        </form>
    </div>
</body>
</html>
