<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="getTaxinvoice.aspx.cs" Inherits="Popbill.HomeTax.Taxinvoice.Example.getTaxinvoice" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title>팝빌 세금계산서 매입/매출 조회 API SDK ASP.NET Example</title>
	<link href="../Example.css" rel="stylesheet" type="text/css"/>
</head>
<body>
<div id="content">
	<p class="heading1">Response</p>
	<br/>
	<fieldset class="fieldset1">
		<legend>세금계산서 상세정보 확인</legend>
		<ul>
			<% if (!String.IsNullOrEmpty(code)) { %>
				<li>Response.code : <%= code %> </li>
				<li>Response.message : <%= message %></li>
			<% } else { %>
				<li>writeDate (작성일자) : <%= taxinvoiceInfo.writeDate %></li>
				<li>issueDT (발행일시) : <%= taxinvoiceInfo.issueDT %></li>
				<li>invoiceType (세금계산서 종류) : <%= taxinvoiceInfo.invoiceType %></li>
				<li>taxType (과세형태) : <%= taxinvoiceInfo.taxType %></li>
				<li>taxTotal (세액 합계) : <%= taxinvoiceInfo.taxTotal %></li>
				<li>supplyCostTotal (공급가액 합계) : <%= taxinvoiceInfo.supplyCostTotal %></li>
				<li>totalAmount (합계금액) : <%= taxinvoiceInfo.totalAmount %></li>
				<li>purposeType (영수/청구) : <%= taxinvoiceInfo.purposeType %></li>
				<li>serialNum (일련번호) : <%= taxinvoiceInfo.serialNum %></li>
				<li>cash (현금) : <%= taxinvoiceInfo.cash %></li>
				<li>chkBill (수표) : <%= taxinvoiceInfo.chkBill %></li>
				<li>credit (외상) : <%= taxinvoiceInfo.credit %></li>
				<li>note (어음) : <%= taxinvoiceInfo.note %></li>
				<li>remark1 (비고1) : <%= taxinvoiceInfo.remark1 %></li>
				<li>remark2 (비고2) : <%= taxinvoiceInfo.remark2 %></li>
				<li>remark3 (비고3) : <%= taxinvoiceInfo.remark3 %></li>
				<li>ntsconfirmNum (국세청승인번호) : <%= taxinvoiceInfo.ntsconfirmNum %></li>
				<li>modifyCode (수정 사유코드) : <%= taxinvoiceInfo.modifyCode %></li>
				<li>orgNTSConfirmNum (원본 국세청승인번호) : <%= taxinvoiceInfo.orgNTSConfirmNum %></li>
				<li>invoicerCorpNum (공급자 사업자번호) : <%= taxinvoiceInfo.invoicerCorpNum %></li>
				<li>invoicerMgtKey (공급자 관리번호) : <%= taxinvoiceInfo.invoicerMgtKey %></li>
				<li>invoicerTaxRegID (공급자 종사업장번호) : <%= taxinvoiceInfo.invoicerTaxRegID %></li>
				<li>invoicerCorpName (공급자 상호) : <%= taxinvoiceInfo.invoicerCorpName %></li>
				<li>invoicerCEOName (공급자 대표자 성명) : <%= taxinvoiceInfo.invoicerCEOName %></li>
				<li>invoicerAddr (공급자 주소) : <%= taxinvoiceInfo.invoicerAddr %></li>
				<li>invoicerBizType (공급자 업태) : <%= taxinvoiceInfo.invoicerBizType %></li>
				<li>invoicerBizClass (공급자 종목) : <%= taxinvoiceInfo.invoicerBizClass %></li>
				<li>invoicerContactName (공급자 담당자 성명) : <%= taxinvoiceInfo.invoicerContactName %></li>
				<li>invoicerTEL (공급자 담당자 연락처) : <%= taxinvoiceInfo.invoicerTEL %></li>
				<li>invoicerEmail (공급자 담당자 이메일) : <%= taxinvoiceInfo.invoicerEmail %></li>

				<li>invoiceeCorpNum (공급받는자 사업자번호) : <%= taxinvoiceInfo.invoiceeCorpNum %></li>
				<li>invoiceeType (공급받는자 구분) : <%= taxinvoiceInfo.invoiceeType %></li>
				<li>invoiceeMgtKey (공급받는자 관리번호) : <%= taxinvoiceInfo.invoiceeMgtKey %></li>
				<li>invoiceeTaxRegID (공급받는자 종사업장번호) : <%= taxinvoiceInfo.invoiceeTaxRegID %></li>
				<li>invoiceeCorpName (공급받는자 상호) : <%= taxinvoiceInfo.invoiceeCorpName %></li>
				<li>invoiceeCEOName (공급받는자 대표자 성명) : <%= taxinvoiceInfo.invoiceeCEOName %></li>
				<li>invoiceeAddr (공급받는자 주소) : <%= taxinvoiceInfo.invoiceeAddr %></li>
				<li>invoiceeBizType (공급받는자 업태) : <%= taxinvoiceInfo.invoiceeBizType %></li>
				<li>invoiceeBizClass (공급받는자 종목) : <%= taxinvoiceInfo.invoiceeBizClass %></li>
				<li>invoiceeContactName1 (공급받는자 담당자 성명) : <%= taxinvoiceInfo.invoiceeContactName1 %></li>
				<li>invoiceeTEL1 (공급받는자 담당자 연락처) : <%= taxinvoiceInfo.invoiceeTEL1 %></li>
				<li>invoiceeEmail1 (공급받는자 담당자 이메일) : <%= taxinvoiceInfo.invoiceeEmail1 %></li>

				<% foreach (Popbill.HomeTax.HTTaxinvoiceDetail detailInfo in taxinvoiceInfo.detailList)
				   { %>
					<fieldset class="fieldset2">
						<legend>세금계산서 상세항목 정보</legend>
						<ul>
							<li>serialNum (일련번호) : <%= detailInfo.serialNum %></li>
							<li>purchaseDT (거래일자) : <%= detailInfo.purchaseDT %></li>
							<li>itemName (품명) : <%= detailInfo.itemName %></li>
							<li>spec (규격) : <%= detailInfo.spec %></li>
							<li>qty (수량) : <%= detailInfo.qty %></li>
							<li>unitCost (단가) : <%= detailInfo.unitCost %></li>
							<li>supplyCost (공급가액) : <%= detailInfo.supplyCost %></li>
							<li>tax (세액) : <%= detailInfo.tax %></li>
							<li>remark (비고) : <%= detailInfo.remark %></li>
						</ul>
					</fieldset>
				<% } %>

			<% } %>
		</ul>
	</fieldset>
</div>
</body>
</html>
