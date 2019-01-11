<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="getFiles.aspx.cs" Inherits="Popbill.Statement.Example.getFiles" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title>팝빌 전자명세서 SDK ASP.NET Example</title>
	<link href="../Example.css" rel="stylesheet" type="text/css"/>
</head>
<body>
<div id="content">
	<p class="heading1">Response</p>
	<br/>
	<fieldset class="fieldset1">
		<legend>첨부파일 목록 확인</legend>
		<ul>
			<% if (!String.IsNullOrEmpty(code)) { %>
				<li>Response.code : <%= code %> </li>
				<li>Response.message : <%= message %></li>
			<% } else { %>
				<% foreach (Popbill.Statement.AttachedFile fileInfo in fileList)
				   { %>
					<fieldset class="fieldset2">
						<legend>첨부파일 정보</legend>
						<ul>
							<li>serialNum (일련번호) : <%= fileInfo.serialNum %></li>
							<li>attachedFile (파일아이디) : <%= fileInfo.attachedFile %></li>
							<li>displayName (첨부파일명) : <%= fileInfo.displayName %></li>
							<li>regDT (첨부일시) : <%= fileInfo.regDT %></li>
						</ul>
					</fieldset>
				<% } %>
			<% } %>
		</ul>
	</fieldset>
</div>
</body>
</html>
