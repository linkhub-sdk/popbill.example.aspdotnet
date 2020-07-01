<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="checkAccountInfo.aspx.cs" Inherits="Popbill.AccountCheck.Example.checkAccountInfo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
	<title>팝빌 예금주조회 API SDK ASP.NET Example</title>
	<link href="../Example.css" rel="stylesheet" type="text/css"/>
</head>
<body>
<div id="content">
	<p class="heading1">Response</p>
	<br/>
	<fieldset class="fieldset1">
		<legend>예금주조회</legend>
		<ul>
			<% if (!String.IsNullOrEmpty(code)) { %>
				<li>Response.code : <%= code %> </li>
				<li>Response.message : <%= message %></li>
			<% } else { %>
				<li>bankCode (기관코드) : <%= result.bankCode %></li>
                <li>accountNumber (계좌번호) : <%= result.accountNumber %></li>
                <li>accountName (예금주 성명) : <%= result.accountName %></li>
                <li>checkDate (확인일시) : <%= result.checkDate %></li>
                <li>resultCode (응답코드) : <%= result.resultCode %></li>
                <li>resultMessage (응답메시지) : <%= result.resultMessage %></li>
			<% } %>
		</ul>
	</fieldset>
</div>
</body>