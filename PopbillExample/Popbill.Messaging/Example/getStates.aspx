<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="getSenderNumberList.aspx.cs" Inherits="Popbill.Message.Example.getStates" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>팝빌 문자 SDK ASP.NET Example</title>
    <link href="../Example.css" rel="stylesheet" type="text/css" />
</head>
    <body>
		<div id = "content">
			<p class = "heading1">Response</p>
			<br/>
			<fieldset class="fieldset1">
				<legend>전송내역 요약정보 확인</legend>
				<ul>
					<% if (!String.IsNullOrEmpty(code)) { %>
						<li>Response.code : <%=code %> </li>
						<li>Response.message : <%= message %></li>
					<% } else {	%>
					    <% foreach (Popbill.Message.MessageState info in statesList ){ %>
					        <fieldset class="fieldset2">
					        <ul>
    						    <li> rNum (접수번호) : <%= info.rNum%></li>
    						    <li> sn (일련번호) : <%= info.sn%></li>
    						    <li> stat (전송 상태코드) : <%= info.stat%></li>
    						    <li> rlt (전송 결과코드) : <%= info.rlt%></li>
    						    <li> sDT (전송일시) : <%= info.sDT%></li>
    						    <li> rDT (결과코드 수신일시) : <%= info.rDT%></li>
    						    <li> net (전송 이동통신사명) : <%= info.net%></li>
    						</ul>
    						</fieldset>
					    <% } %>
					<% } %>
				</ul>
			</fieldset>
		 </div>
	</body>
</html>
