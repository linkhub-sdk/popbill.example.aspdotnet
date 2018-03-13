<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="listPlusFriendID.aspx.cs" Inherits="Popbill.Kakao.Example.listPlusFriendID" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>팝빌 카카오톡 SDK ASP.NET Example</title>
    <link href="../Example.css" rel="stylesheet" type="text/css" />
</head>
    <body>
		<div id = "content">
			<p class = "heading1">Response</p>
			<br/>
			<fieldset class="fieldset1">
				<legend>플러스친구 목록</legend>
				<ul>
					<% if (!String.IsNullOrEmpty(code)) { %>
						<li>Response.code : <%=code %> </li>
						<li>Response.message : <%= message %></li>
					<% } else {	%>
					    <% foreach (Popbill.Kakao.PlusFriend info in plusFriendList ) { %>
					        <fieldset class="fieldset2">
					        <ul>
    						    <li> plusFriendID (플러스친구 아이디 ) : <%= info.plusFriendID %></li>
    						    <li> plusFriendName (플러스친구 이름) : <%= info.plusFriendName %></li>
    						    <li> regDT (등록일시) : <%= info.regDT %></li>
    						</ul>
    						</fieldset>
					    <% } %>
					<% } %>
				</ul>
			</fieldset>
		 </div>
	</body>
</html>
