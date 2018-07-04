<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="resendFAXRN_multi.aspx.cs" Inherits="Popbill.Fax.Example.resendFAXRN_multi" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>팝빌 팩스 SDK ASP.NET Example</title>
    <link href="../Example.css" rel="stylesheet" type="text/css" />
</head>
    <body>
		<div id="content">
			<p class="heading1">Response</p>
			<br/>
			<fieldset class="fieldset1">
				<legend>팩스 동보 재전송 (요청번호할당)</legend>
				<ul>
					<% if (!String.IsNullOrEmpty(code)) { %>
						<li>Response.code : <%=code %> </li>
						<li>Response.message : <%= message %></li>
					<% } else {	%>
						<li>receiptNum(접수번호) : <%= receiptNum %></li>
					<% } %>
				</ul>
			</fieldset>
		 </div>
	</body>
</html>

