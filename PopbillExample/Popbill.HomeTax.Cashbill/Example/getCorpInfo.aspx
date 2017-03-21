<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="getChargeInfo.aspx.cs" Inherits="Popbill.HomeTax.Cashbill.Example.getCorpInfo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head  runat="server">
    <title>팝빌 현금영수증 매입/매출 조회 API SDK ASP.NET Example</title>
    <link href="../Example.css" rel="stylesheet" type="text/css" />
</head>
	<body>
		<div id="content">
			<p class="heading1">Response</p>
			<br/>
			<fieldset class="fieldset1">
				<legend>회사정보 확인</legend>
				<ul>
					<% if (!String.IsNullOrEmpty(code)) { %>
						<li>Response.code : <%=code %> </li>
						<li>Response.message : <%= message %></li>
					<% } else {	%>
						<li>ceoname (대표자 성명) : <%=corpInfo.ceoname %></li>
						<li>corpName (상호) : <%=corpInfo.corpName %></li>
						<li>addr (주소) : <%=corpInfo.addr %></li>
						<li>bizType (업태) : <%=corpInfo.bizType %></li>
						<li>bizClass (종목) : <%=corpInfo.bizClass %></li>
					<% } %>
				</ul>
			</fieldset>
		 </div>
	</body>
</html>
