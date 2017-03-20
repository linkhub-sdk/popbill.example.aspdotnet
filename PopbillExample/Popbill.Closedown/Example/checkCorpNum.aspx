<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="checkCorpNum.aspx.cs" Inherits="Popbill.Closedown.Example.checkCorpNum" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>팝빌 휴폐업조회 API SDK ASP.NET Example</title>
    <link href="../Example.css" rel="stylesheet" type="text/css" />
</head>
	<body>
		<div id="content">
			<p class="heading1">Response</p>
			<br/>
			<fieldset class="fieldset1">
				<legend>휴폐업조회 - 단건</legend>
				<ul>
					<% if (!String.IsNullOrEmpty(code)) { %>
						<li>Response.code : <%=code %> </li>
						<li>Response.message : <%= message %></li>
					<% } else {	%>
						<li>corpNum (사업자번호) : <%= result.corpNum%></li>
						<li>type (사업자유형) : <%= result.type %></li>
						<li>state (휴폐업상태) : <%= result.state %></li>
						<li>stateDate (휴폐업일자) : <%= result.stateDate %></li>
						<li>checkDate (국세청 확인일자) : <%= result.checkDate %></li>
					<% } %>
				</ul>
			</fieldset>
		 </div>
	</body>
</html>
