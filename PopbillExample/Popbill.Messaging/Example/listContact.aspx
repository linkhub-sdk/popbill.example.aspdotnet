<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="listContact.aspx.cs" Inherits="Popbill.Message.Example.listContact" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>팝빌 문자 SDK ASP.NET Example</title>
    <link href="../Example.css" rel="stylesheet" type="text/css" />
</head>
    <body>
		<div id="content">
			<p class="heading1">Response</p>
			<br/>
			<fieldset class="fieldset1">
				<legend>담당자 목록 확인</legend>
				<ul>
					<% if (!String.IsNullOrEmpty(code)) { %>
						<li>Response.code : <%=code %> </li>
						<li>Response.message : <%= message %></li>
					<% } else {	%>
					    <% foreach (Popbill.Contact contactInfo in contactList) { %>
					        <fieldset class="fieldset2">
					        <legend>담당자 정보</legend>
					            <ul>
    						        <li> id (담당자 아이디) : <%= contactInfo.id %></li>
    						        <li> personName (담당자명) : <%= contactInfo.personName %></li>
    						        <li> email (이메일) : <%= contactInfo.email %></li>
    						        <li> hp (휴대폰번호) : <%= contactInfo.hp %></li>
    						        <li> fax (팩스번호) : <%= contactInfo.fax %></li>
    						        <li> tel (연락처) : <%= contactInfo.tel %></li>
    						        <li> mgrYN (관리자 여부) : <%= contactInfo.mgrYN %></li>
    						        <li> regDT (등록일시) : <%= contactInfo.regDT %></li>
    						        <li> searchAllAllowYN (회사조회 여부) : <%= contactInfo.searchAllAllowYN %></li>
    						        <li> mgrYN (관리자여부) : <%= contactInfo.mgrYN %></li>
    						        <li> state (상태) : <%= contactInfo.state %></li>
    						    </ul>
    						</fieldset>
					    <% } %>
					<% } %>
				</ul>
			</fieldset>
		 </div>
	</body>
</html>
