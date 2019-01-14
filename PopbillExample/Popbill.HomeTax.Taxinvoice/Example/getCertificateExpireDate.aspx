<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="getCertificateExpireDate.aspx.cs" Inherits="Popbill.HomeTax.Taxinvoice.getCertificateExpireDate" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
	<title>팝빌 세금계산서 매입/매출 조회 API SDK ASP.NET Example</title>
	<link href="../Example.css" rel="stylesheet" type="text/css"/>
</head>
<body>
<div id="content">
	<p class="heading1">Response</p>
	<br/>
	<fieldset class="fieldset1">
		<legend>홈택스연계 공인인증서 만료일자 확인</legend>
		<ul>
			<% if (!String.IsNullOrEmpty(code)) { %>
				<li>Response.code : <%= code %> </li>
				<li>Response.message : <%= message %></li>
			<% } else { %>
				<li>expireDate (홈택스 공인인증서 만료일자) : <%= expireDate %></li>
			<% } %>
		</ul>
	</fieldset>
</div>
</body>
</html>
