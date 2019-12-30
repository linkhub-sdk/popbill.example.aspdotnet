<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="getJobState.aspx.cs" Inherits="Popbill.EasyFin.Bank.Example.getJobState" %>

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
		<legend>수집 상태 확인</legend>
		<ul>
			<% if (!String.IsNullOrEmpty(code)) { %>
				<li>Response.code : <%= code %> </li>
				<li>Response.message : <%= message %></li>
			<% } else { %>
				<li>jobID (작업 아이디) : <%= result.jobID %></li>
				<li>jobState (수집상태) : <%= result.jobState %></li>
				<li>startDate (시작일자) : <%= result.startDate %></li>
				<li>endDate (종료일자) : <%= result.endDate %></li>
				<li>errorCode (오류코드) : <%= result.errorCode %></li>
				<li>errorReason (오류메시지) : <%= result.errorReason %></li>
				<li>jobStartDT (작업 시작일시) : <%= result.jobStartDT %></li>
				<li>jobEndDT (작업 종료일시) : <%= result.jobEndDT %></li>
				<li>regDT (수집 요청일시) : <%= result.regDT %></li>
			<% } %>
		</ul>
	</fieldset>
</div>
</body></html>
