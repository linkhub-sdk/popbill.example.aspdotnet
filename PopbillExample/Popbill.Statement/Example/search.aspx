﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="search.aspx.cs" Inherits="Popbill.Statement.Example.search" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
	<title>팝빌 전자명세서 SDK ASP.NET Example</title>
	<link href="../Example.css" rel="stylesheet" type="text/css"/>
</head>
<body>
<div id="content">
	<p class="heading1">Response</p>
	<br/>
	<fieldset class="fieldset1">
		<legend>전자명세서 목록조회</legend>
		<ul>
			<% if (!String.IsNullOrEmpty(code)) { %>
				<li>Response.code : <%= code %> </li>
				<li>Response.message : <%= message %></li>
			<% } else { %>
				<li>code (상태코드) : <%= result.code %> </li>
				<li>message (응답메시지) : <%= result.message %> </li>
				<li>total (총 검색결과 건수) : <%= result.total %> </li>
				<li>perPage (페이지당 검색개수) : <%= result.perPage %> </li>
				<li>pageNum (페이지 번호) : <%= result.pageNum %> </li>
				<li>pageCount (페이지 개수) : <%= result.pageCount %> </li>

				<% foreach (Popbill.Statement.StatementInfo statementInfo in result.list)
				   { %>
					<fieldset class="fieldset2">
						<legend>전자명세서 상태/요약 정보</legend>
						<ul>
							<li>itemCode (문서종류코드) : <%= statementInfo.itemCode %></li>
							<li>itemKey (아이템키) : <%= statementInfo.itemKey %></li>
							<li>invoiceNum (문서고유번호) : <%= statementInfo.invoiceNum %></li>
							<li>mgtKey (문서번호) : <%= statementInfo.mgtKey %></li>
							<li>taxType (세금형태) : <%= statementInfo.taxType %></li>
							<li>writeDate (작성일자) : <%= statementInfo.writeDate %></li>
							<li>regDT (등록일시) : <%= statementInfo.regDT %></li>
							<li>senderCorpName (발행자 상호) : <%= statementInfo.senderCorpName %></li>
							<li>senderCorpNum (발행자 사업자번호) : <%= statementInfo.senderCorpNum %></li>
							<li>senderPrintYN (발행자 인쇄여부) : <%= statementInfo.senderPrintYN %></li>
							<li>receiverCorpName (수신자 상호) : <%= statementInfo.receiverCorpName %></li>
							<li>receiverCorpNum (수신자 사업자번호) : <%= statementInfo.receiverCorpNum %></li>
							<li>receiverPrintYN (수신자 인쇄여부) : <%= statementInfo.receiverPrintYN %></li>
							<li>supplyCostTotal (공급가액 합계) : <%= statementInfo.supplyCostTotal %></li>
							<li>taxTotal (세액 합계) : <%= statementInfo.taxTotal %></li>
							<li>purposeType (영수/청구) : <%= statementInfo.purposeType %></li>
							<li>issueDT (발행일시) : <%= statementInfo.issueDT %></li>
							<li>stateCode (상태코드) : <%= statementInfo.stateCode %></li>
							<li>stateDT (상태 변경일시) : <%= statementInfo.stateDT %></li>
							<li>stateMemo (상태메모) : <%= statementInfo.stateMemo %></li>
							<li>openYN (개봉 여부) : <%= statementInfo.openYN %></li>
							<li>openDT (개봉 일시) : <%= statementInfo.openDT %></li>
						</ul>
					</fieldset>
				<% } %>
			<% } %>
		</ul>
	</fieldset>
</div>
</body>
</html>
