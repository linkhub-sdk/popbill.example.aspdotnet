﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="listBankAccount.aspx.cs" Inherits="Popbill.EasyFin.Bank.Example.listBankAccount" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
	<title>팝빌 계좌조회 API SDK ASP.NET Example</title>
	<link href="../Example.css" rel="stylesheet" type="text/css"/>
</head>
<body>
<div id="content">
	<p class="heading1">Response</p>
	<br/>
	<fieldset class="fieldset1">
		<legend>은행계좌 목록 확인</legend>
		<ul>
			<% if (!String.IsNullOrEmpty(code)) { %>
				<li>Response.code : <%= code %> </li>
				<li>Response.message : <%= message %></li>
			<% } else { %>
				<% foreach (Popbill.EasyFin.EasyFinBankAccount bankAccount in bankAccountList)
				   { %>
					<fieldset class="fieldset2">
						<legend>은행 계좌정보</legend>
						<ul>
							<li>accountNumber (계좌번호) : <%= bankAccount.accountNumber%></li>
							<li>bankCode (은행코드) : <%= bankAccount.bankCode%></li>
							<li>accountName (계좌 별칭) : <%= bankAccount.accountName%></li>
							<li>accountType (계좌 유형) : <%= bankAccount.accountType%></li>
							<li>state (계좌 정액제 상태) : <%= bankAccount.state.ToString()%></li>
							<li>regDT (등록일시) : <%= bankAccount.regDT%></li>
							<li>memo (메모) : <%= bankAccount.memo%></li>
						</ul>
					</fieldset>
				<% } %>
			<% } %>
		</ul>
	</fieldset>
</div>
</body>
</html>
