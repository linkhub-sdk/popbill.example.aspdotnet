<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="getAutoDenyList.aspx.cs" Inherits="Popbill.Message.Example.getAutoDenyList" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>팝빌 문자 SDK ASP.NET Example</title>
    <link href="../Example.css" rel="stylesheet" type="text/css" />
</head>
    <body>
		<div id = "content">
			<p class = "heading1">Response</p>
			<br/>
			<fieldset class="fieldset1">
				<legend>080 수신거부 목록</legend>
				<ul>
					<% if (!String.IsNullOrEmpty(code)) { %>
						<li>Response.code : <%=code %> </li>
						<li>Response.message : <%= message %></li>
					<% } else {	%>
					    <% foreach (Popbill.Message.AutoDeny info in autoDenyList ) { %>
					        <fieldset class="fieldset2">
					        <ul>
    						    <li> number(수신거부번호) : <%= info.number %></li>
    						    <li> regDT(등록일시) : <%= info.regDT %></li>
    						</ul>
    						</fieldset>
					    <% } %>
					<% } %>
				</ul>
			</fieldset>
		 </div>
	</body>
</html>
