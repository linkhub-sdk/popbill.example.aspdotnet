<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="getDetailInfo.aspx.cs" Inherits="Popbill.Taxinvoice.Example.getDetailInfo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>팝빌 세금계산서 SDK ASP.NET Example</title>
    <link href="../Example.css" rel="stylesheet" type="text/css" />
</head>
	<body>
		<div id="content">
			<p class="heading1">Response</p>
			<br/>
			<fieldset class="fieldset1">
				<legend>전자세금계산서 상세정보 확인</legend>
				<ul>
					<% if (!String.IsNullOrEmpty(code)) { %>
						<li>Response.code : <%=code %> </li>
						<li>Response.message : <%= message %></li>
					<% } else {	%>
						<li>ntsconfirmNum (국세청승인번호) : <%=taxinvoice.ntsconfirmNum%></li>
						<li>issueType (발행형태) : <%=taxinvoice.issueType%></li>
						<li>taxType (과세형태) : <%=taxinvoice.taxType%></li>
						<li>issueTiming (발행시점) : <%=taxinvoice.issueTiming%></li>
						<li>chargeDirection (과금방향) : <%=taxinvoice.chargeDirection%></li>
						
						<li>writeDate (작성일자) : <%=taxinvoice.writeDate%></li>
						<li>purposeType (영수/청구) : <%=taxinvoice.purposeType%></li>
						<li>supplyCostTotal (공급가액 합계) : <%=taxinvoice.supplyCostTotal%></li>
						<li>taxTotal (세액 합계) : <%=taxinvoice.taxTotal%></li>
						<li>totalAmount (합계금액) : <%=taxinvoice.totalAmount%></li>
						
						<li>invoicerMgtKey (공급자 관리번호) : <%=taxinvoice.invoicerMgtKey%></li>
						<li>invoicerCorpNum (공급자 사업자번호) : <%=taxinvoice.invoicerCorpNum%></li>
						<li>invoicerTaxRegID (공급자 종사업장 식별번호) : <%=taxinvoice.invoicerTaxRegID%></li>
						<li>invoicerCorpName (공급자 상호) : <%=taxinvoice.invoicerCorpName%></li>
						<li>invoicerCEOName (공급자 대표자 성명) : <%=taxinvoice.invoicerCEOName%></li>
						<li>invoicerAddr (공급자 주소) : <%=taxinvoice.invoicerAddr%></li>
						<li>invoicerBizClass (공급자 업종) : <%=taxinvoice.invoicerBizClass%></li>
						<li>invoicerBizType (공급자 업태) : <%=taxinvoice.invoicerBizType%></li>
						<li>invoicerContactName (담당자 성명) : <%=taxinvoice.invoicerContactName%></li>
						<li>invoicerTEL (담당자 연락처) : <%=taxinvoice.invoicerTEL%></li>
						<li>invoicerHP (담당자 휴대폰번호) : <%=taxinvoice.invoicerHP%></li>
						<li>invoicerEmail (담당자 이메일) : <%=taxinvoice.invoicerEmail%></li>
						
						<li>invoiceeMgtKey (공급받는자 관리번호) : <%=taxinvoice.invoiceeMgtKey%></li>
						<li>invoiceeType (공급받는자 구분) : <%=taxinvoice.invoiceeType%></li>
						<li>invoiceeCorpNum (공급받는자 사업자번호) : <%=taxinvoice.invoiceeCorpNum%></li>
						<li>invoiceeTaxRegID (공급받는자 종사업장 식별번호) : <%=taxinvoice.invoiceeTaxRegID%></li>
						<li>invoiceeCorpName (공급받는자 상호) : <%=taxinvoice.invoiceeCorpName%></li>
						<li>invoiceeCEOName (공급받는자 대표자 성명) : <%=taxinvoice.invoiceeCEOName%></li>
						<li>invoiceeAddr (공급받는자 주소) : <%=taxinvoice.invoiceeAddr%></li>
						<li>invoiceeBizType (공급받는자 업태) : <%=taxinvoice.invoiceeBizType%></li>
						<li>invoiceeBizClass (공급받는자 종목) : <%=taxinvoice.invoiceeBizClass%></li>
						<li>invoiceeContactName1 (공급받는자 담당자 성명) : <%=taxinvoice.invoiceeContactName1%></li>
						<li>invoiceeTEL1 (공급받는자 담당자 연락처) : <%=taxinvoice.invoiceeTEL1 %></li>
						<li>invoiceeHP1 (공급받는자 담당자 휴대폰번호) : <%=taxinvoice.invoiceeHP1 %></li>
						<li>invoiceeEmail1 (공급받는자 담당자 이메일) : <%=taxinvoice.invoiceeEmail1 %></li>
						<li>invoiceeEmail1 (공급받는자 담당자 이메일) : <%=taxinvoice.invoiceeEmail1 %></li>
						
						<li>closeDownState (공급받는자 휴폐업 상태) : <%=taxinvoice.closeDownState%></li>
						<li>closeDownStateDate (공급받는자 휴폐업 상태) : <%=taxinvoice.closeDownStateDate%></li>
						
						
						<li>serialNum (일련번호) : <%=taxinvoice.serialNum%></li>
						<li>kwon (권) : <%=taxinvoice.kwon%></li>
						<li>ho (호) : <%=taxinvoice.ho%></li>
						<li>cash (현금) : <%=taxinvoice.cash%></li>
						<li>chkBill (수표) : <%=taxinvoice.chkBill%></li>
						<li>credit (외상) : <%=taxinvoice.credit%></li>
						<li>note (어음) : <%=taxinvoice.note%></li>
						<li>remark1 (비고1) : <%=taxinvoice.remark1%></li>
						<li>remark2 (비고2) : <%=taxinvoice.remark2%></li>
						<li>remark3 (비고3) : <%=taxinvoice.remark3%></li>
						
						<li>modifyCode (수정사유코드) : <%=taxinvoice.modifyCode%></li>
						<li>originalTaxinvoiceKey (원본 팝빌 관리번호) : <%=taxinvoice.originalTaxinvoiceKey%></li>
						<li>orgNTSConfirmNum (원본 팝빌 관리번호) : <%=taxinvoice.orgNTSConfirmNum%></li>
						
						<% foreach (Popbill.Taxinvoice.TaxinvoiceDetail detail in taxinvoice.detailList) { %>
					        <fieldset class="fieldset2">
					        <legend>세금계산서 품목(항목) 정보</legend>
					            <ul>
                                    <li>serialNum (일련번호) : <%=detail.serialNum %></li>
                                    <li>purchaseDT (거래일자) : <%=detail.purchaseDT %></li>
                                    <li>itemName (품명) : <%=detail.itemName %></li>
                                    <li>spec (규격) : <%=detail.spec %></li>
                                    <li>qty (수량) : <%=detail.qty %></li>
                                    <li>unitCost (단가) : <%=detail.unitCost %></li>
                                    <li>supplyCost (공급가액) : <%=detail.supplyCost %></li>
                                    <li>tax (세액) : <%=detail.tax %></li>
                                    <li>remark (비고) : <%=detail.remark %></li>
    						    </ul>
    						</fieldset>
					    <% } %>
					    
					    <% foreach (Popbill.Taxinvoice.TaxinvoiceAddContact  contact in taxinvoice.addContactList) { %>
					        <fieldset class="fieldset2">
					        <legend>추가담당자 정보</legend>
					            <ul>
                                    <li>serialNum (일련번호) : <%=contact.serialNum %></li>
                                    <li>contactName (담당자 성명) : <%=contact.contactName %></li>
                                    <li>email (이메일주소) : <%=contact.email %></li>
    						    </ul>
    						</fieldset>
					    <% } %>
					<% } %>
				</ul>
			</fieldset>
		 </div>
	</body>
</html>

