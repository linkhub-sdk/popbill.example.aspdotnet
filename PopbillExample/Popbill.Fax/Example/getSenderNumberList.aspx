<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="getSenderNumberList.aspx.cs" Inherits="Popbill.Fax.Example.getSenderNumberList" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
	<title>팝빌 팩스 SDK ASP.NET Example</title>
	<link href="../Example.css" rel="stylesheet" type="text/css"/>
</head>
<body>
<div id="content">
	<p class="heading1">Response</p>
	<br/>
	<fieldset class="fieldset1">
		<legend>발신번호 목록</legend>
		<ul>
			<% if (!String.IsNullOrEmpty(code)) { %>
				<li>Response.code : <%= code %> </li>
				<li>Response.message : <%= message %></li>
			<% } else { %>
				<% foreach (Popbill.Fax.SenderNumber info in senderNumberList)
				   { %>
					<fieldset class="fieldset2">
						<ul>
							<li> number (발신번호) : <%= info.number %></li>
							<li> representYN (대표번호 지정여부) : <%= info.representYN %></li>
							<li> state (등록상태) : <%= info.state %></li>
							<li> memo (메모) : <%= info.memo %></li>
						</ul>
					</fieldset>
				<% } %>
			<% } %>
		</ul>
	</fieldset>
</div>
</body>
</html>
