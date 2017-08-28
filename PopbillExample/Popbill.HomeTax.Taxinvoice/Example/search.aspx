<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="search.aspx.cs" Inherits="Popbill.HomeTax.Taxinvoice.Example.search" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>팝빌 세금계산서 매입/매출 조회 API SDK ASP.NET Example</title>
    <link href="../Example.css" rel="stylesheet" type="text/css" />
</head>
<body>
		<div id="content">
			<p class="heading1">Response</p>
			<br/>
			<fieldset class="fieldset1">
				<legend>전자세금계산서 매입/매출 목록조회</legend>
				<ul>
					<% if (!String.IsNullOrEmpty(code)) { %>
						<li>Response.code : <%=code %> </li>
						<li>Response.message : <%= message %></li>
					<% } else {	%>
					    <li>code (상태코드) : <%=result.code %> </li>
					    <li>message (응답메시지) : <%=result.message %> </li>
					    <li>total (총 검색결과 건수) : <%=result.total %> </li>
					    <li>perPage (페이지당 검색개수) : <%=result.perPage %> </li>
					    <li>pageNum (페이지 번호) : <%=result.pageNum %> </li>
					    <li>pageCount (페이지 개수) : <%=result.pageCount %> </li>
					    
					    <% foreach (Popbill.HomeTax.HTTaxinvoiceAbbr taxinvoiceInfo in result.list) { %>
					        <fieldset class="fieldset2">
					        <legend>세금계산서 정보</legend>
					            <ul>
    						        <li>ntsconfirmNum (국세청승인번호) : <%=taxinvoiceInfo.ntsconfirmNum%></li>
    						        <li>writeDate (작성일자) : <%=taxinvoiceInfo.writeDate%></li>
    						        <li>issueDate (발행일자) : <%=taxinvoiceInfo.issueDate%></li>
    						        <li>sendDate (전송일자) : <%=taxinvoiceInfo.sendDate%></li>
    						        <li>taxType (과세형태) : <%=taxinvoiceInfo.taxType%></li>
    						        <li>purposeType (영수/청구) : <%=taxinvoiceInfo.purposeType%></li>
    						        <li>supplyCostTotal (공급가액 합계) : <%=taxinvoiceInfo.supplyCostTotal%></li>
    						        <li>taxTotal (세액 합계) : <%=taxinvoiceInfo.taxTotal%></li>
    						        <li>totalAmount (합계금액) : <%=taxinvoiceInfo.taxTotal%></li>
    						        <li>remark1 (비고) : <%=taxinvoiceInfo.remark1%></li>
    						        <li>modifyYN (수정 전자세금계산서 여부) : <%=taxinvoiceInfo.modifyYN%></li>
    						        <li>orgNTSConfirmNum (원본 전자세금계산서 국세청 승인번호) : <%=taxinvoiceInfo.orgNTSConfirmNum%></li>
    						        <li>purchaseDate (거래일자) : <%=taxinvoiceInfo.purchaseDate%></li>
    						        <li>itemName (품명) : <%=taxinvoiceInfo.itemName%></li>
    						        <li>spec (규격) : <%=taxinvoiceInfo.spec%></li>
    						        <li>qty (수량) : <%=taxinvoiceInfo.qty%></li>
    						        <li>unitCost (단가) : <%=taxinvoiceInfo.unitCost%></li>
    						        <li>supplyCost (공급가액) : <%=taxinvoiceInfo.supplyCost %></li>
    						        <li>tax (세액) : <%=taxinvoiceInfo.tax %></li>
    						        <li>remark (비고) : <%=taxinvoiceInfo.remark %></li>
    						        <li>invoiceType (구분) : <%=taxinvoiceInfo.invoiceType %></li>
    						    </ul>
    						</fieldset>
					    <% } %>
					<% } %>
				</ul>
			</fieldset>
		 </div>
	</body>
</html>

