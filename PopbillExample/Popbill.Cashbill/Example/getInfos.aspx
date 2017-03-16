<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="getInfos.aspx.cs" Inherits="Popbill.Cashbill.Example.getInfos" %>

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
				<legend>현금영수증 상태/요약정보 확인 - 대량</legend>
				<ul>
					<% if (!String.IsNullOrEmpty(code)) { %>
						<li>Response.code : <%=code %> </li>
						<li>Response.message : <%= message %></li>
					<% } else {	%>
					    <% foreach (Popbill.Cashbill.CashbillInfo cashbillInfo in cashbillInfoList) { %>
					        <fieldset class="fieldset2">
					        <legend>현금영수증 상태/요약정보</legend>
					            <ul>
                                    <li>itemKey (팝빌 관리번호) : <%= cashbillInfo.itemKey %></li>
					                <li>mgtKey (관리번호) : <%= cashbillInfo.mgtKey%></li>
					                <li>tradeDate (거래일자) : <%= cashbillInfo.tradeDate%></li>
					                <li>issueDT (발행일시) : <%= cashbillInfo.issueDT%></li>
					                <li>regDT (등록일시) : <%= cashbillInfo.regDT%></li>
					                <li>taxationType (과세형태) : <%= cashbillInfo.taxationType%></li>
					                <li>totalAmount (거래금액) : <%= cashbillInfo.totalAmount%></li>
					                <li>tradeUsage (거래용도) : <%= cashbillInfo.tradeUsage%></li>
					                <li>tradeType (현금영수증 형태) : <%= cashbillInfo.tradeType%></li>
					                <li>stateCode (상태코드) : <%= cashbillInfo.stateCode%></li>
					                <li>stateDT (상태변경 일시) : <%= cashbillInfo.stateDT%></li>
					                <li>identityNum (거래처 식별번호) : <%= cashbillInfo.identityNum%></li>
					                <li>itemName (상품명) : <%= cashbillInfo.itemName%></li>
					                <li>customerName (고객명) : <%= cashbillInfo.customerName%></li>
					                <li>confirmNum (국세청 승인번호) : <%= cashbillInfo.confirmNum%></li>
					                <li>orgConfirmNum (원본 현금영수증 국세청 승인번호) : <%= cashbillInfo.orgConfirmNum%></li>
					                <li>orgTradeDate (원본 현금영수증 거래일자) : <%= cashbillInfo.orgTradeDate%></li>
					                <li>ntssendDT (국세청 전송일시) : <%= cashbillInfo.ntssendDT%></li>
					                <li>ntsresultDT (국세청 처리결과 수신일시) : <%= cashbillInfo.ntsresultDT%></li>
					                <li>ntsresultCode (국세청 처리결과 상태코드) : <%= cashbillInfo.ntsresultCode%></li>
					                <li>ntsresultMessage (국세청 처리결과 메시지) : <%= cashbillInfo.ntsresultMessage%></li>
					                <li>printYN (인쇄여부) : <%= cashbillInfo.printYN %></li>
    						    </ul>
    						</fieldset>
					    <% } %>
					<% } %>
				</ul>
			</fieldset>
		 </div>
	</body>
</html>
