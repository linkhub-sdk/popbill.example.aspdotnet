<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="requestJob.aspx.cs" Inherits="Popbill.HomeTax.Taxinvoice.Example.requestJob" %>

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
		<legend>수집 요청</legend>
		<ul>
			<% if (!String.IsNullOrEmpty(code)) { %>
				<li>Response.code : <%= code %> </li>
				<li>Response.message : <%= message %></li>
			<% } else { %>
				<li>jobID (작업아이디) : <%= jobID %></li>
			<% } %>
		</ul>
	</fieldset>
</div>
</body>
</html>
