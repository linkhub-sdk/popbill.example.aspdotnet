<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="getDetailInfo.aspx.cs" Inherits="Popbill.Cashbill.Example.getDetailInfo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>팝빌 현금영수증 SDK ASP.NET Example</title>
    <link href="../Example.css" rel="stylesheet" type="text/css" />
</head>
	<body>
		<div id="content">
			<p class="heading1">Response</p>
			<br/>
			<fieldset class="fieldset1">
				<legend>현금영수증 상세정보 확인</legend>
				<ul>
					<% if (!String.IsNullOrEmpty(code)) { %>
						<li>Response.code : <%=code %> </li>
						<li>Response.message : <%= message %></li>
					<% } else {	%>					
					    <li>mgtKey (관리번호) : <%= cashbill.mgtKey %></li>
					    <li>orgConfirmNum (원본 현금영수증 국세청승인번호) : <%= cashbill.orgConfirmNum%></li>
					    <li>orgTradeDate (원본 현금영수증 거래일자) : <%= cashbill.orgTradeDate %></li>
					    <li>tradeDate (거래일자) : <%= cashbill.tradeDate%></li>
					    <li>tradeUsage (거래유형) : <%= cashbill.tradeUsage%></li>
					    <li>tradeType (현금영수증 형태) : <%= cashbill.tradeType%></li>
					    <li>taxationType (과세형태) : <%= cashbill.taxationType%></li>
					    <li>supplyCost (공급가액) : <%= cashbill.supplyCost%></li>
					    <li>tax (세액) : <%= cashbill.tax%></li>
					    <li>serviceFee (봉사료) : <%= cashbill.serviceFee%></li>
					    <li>totalAmount (거래금액) : <%= cashbill.totalAmount%></li>
					    <li>franchiseCorpNum (발행자 사업자번호) : <%= cashbill.franchiseCorpNum%></li>
					    <li>franchiseCorpName (발행자 상호) : <%= cashbill.franchiseCorpName%></li>
					    <li>franchiseCEOName (발행자 대표자 성명) : <%= cashbill.franchiseCEOName%></li>
					    <li>franchiseAddr (가맹점 주소) : <%= cashbill.franchiseAddr%></li>
					    <li>franchiseTEL (가맹점 전화번호) : <%= cashbill.franchiseTEL%></li>
					    <li>identityNum (거래처 식별번호) : <%= cashbill.identityNum%></li>
					    <li>customerName (고객명) : <%= cashbill.customerName%></li>
					    <li>itemName (상품명) : <%= cashbill.itemName%></li>
					    <li>orderNumber (가맹점 주문번호) : <%= cashbill.orderNumber%></li>
					    <li>email (고객 이메일) : <%= cashbill.email%></li>
					    <li>hp (고객 휴대폰번호) : <%= cashbill.hp%></li>
					    <li>smssendYN (알림문자 전송여부) : <%= cashbill.smssendYN%></li>
					<% } %>
				</ul>
			</fieldset>
		 </div>
	</body>
</html>
