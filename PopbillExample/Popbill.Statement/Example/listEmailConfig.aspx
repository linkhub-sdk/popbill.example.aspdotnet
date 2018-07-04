<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="listEmailConfig.aspx.cs" Inherits="Popbill.Statement.Example.listEmailConfig" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>팝빌 전자명세서 SDK ASP.NET Example</title>
    <link href="../Example.css" rel="stylesheet" type="text/css" />
</head>
    <body>
		<div id="content">
			<p class="heading1">Response</p>
			<br/>
			<fieldset class="fieldset1">
				<legend>알림메일 전송목록 조회 </legend>
				<ul>
					<% if (!String.IsNullOrEmpty(code)) { %>
						<li>Response.code : <%=code %> </li>
						<li>Response.message : <%= message %></li>
					<% } else {	%>
				        <% foreach (Popbill.EmailConfig info in emailConfigList) { %>
			                <%if (info.emailType == "SMT_ISSUE") { %> <li> SMT_ISSUE (공급받는자에게 전자명세서가 발행 되었음을 알려주는 메일) : <%= info.sendYN%></li> <%} %>
			                <%if (info.emailType == "SMT_ACCEPT") { %> <li> SMT_ACCEPT (공급자에게 전자명세서가 승인 되었음을 알려주는 메일) : <%= info.sendYN%></li> <%} %>
                            <%if (info.emailType == "SMT_DENY" ) { %> <li> SMT_DENY (공급자게에 전자명세서가 거부 되었음을 알려주는 메일)  : <%= info.sendYN%></li> <%} %>
                            <%if (info.emailType == "SMT_CANCEL" ) { %> <li> SMT_CANCEL (공급받는자게에 전자명세서가 취소 되었음을 알려주는 메일) : <%= info.sendYN%></li> <%} %>
                            <%if (info.emailType == "SMT_CANCEL_ISSUE" ) { %> <li> SMT_CANCEL_ISSUE (공급받는자에게 전자명세서가 발행취소 되었음을 알려주는 메일) : <%= info.sendYN%></li> <%} %>
				        <% } %>
					<% } %>
				</ul>
			</fieldset>
		 </div>
	</body>
</html>