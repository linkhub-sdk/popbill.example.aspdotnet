<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="getEmailPublicKeys.aspx.cs" Inherits="Popbill.Taxinvoice.Example.getEmailPublicKeys" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>팝빌 세금계산서 SDK ASP.NET Example</title>
    <link href="../Example.css" rel="stylesheet" type="text/css" />
</head>
    <body>
		<div id="content">
			<p class="heading1">Response</p>
			<br/>
			<fieldset class="fieldset1">
				<legend>대용량 연계사업자 메일 목록</legend>
				<ul>
					<% if (!String.IsNullOrEmpty(code)) { %>
						<li>Response.code : <%=code %> </li>
						<li>Response.message : <%= message %></li>
					<% } else {	%>
					    <% foreach (Popbill.Taxinvoice.EmailPublicKey info in KeyList ) { %>
					        <fieldset class="fieldset2">
					        <legend>연계사업자 정보</legend>
					            <ul>
    						        <li> confirmNum : <%= info.confirmNum %></li>
    						        <li> email: <%= info.email %></li>
    						    </ul>
    						</fieldset>
					    <% } %>
					<% } %>
				</ul>
			</fieldset>
		 </div>
	</body>
</html>

