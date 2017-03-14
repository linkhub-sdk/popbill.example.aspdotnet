<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="getChargeInfo.aspx.cs" Inherits="Popbill.Taxinvoice.Example.getChargeInfo" %>

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
				<legend>회사정보 확인</legend>
				<ul>
					<% if (!String.IsNullOrEmpty(code)) { %>
						<li>Response.code : <%=code %> </li>
						<li>Response.message : <%= message %></li>
					<% } else {	%>
						<li>unitCost (발행단가) : <%= chrgInfo.unitCost %></li>
						<li>chargeMethod (과금유형) : <%= chrgInfo.chargeMethod %></li>
						<li>rateSystem (과금제도) : <%= chrgInfo.rateSystem %></li>
					<% } %>
				</ul>
			</fieldset>
		 </div>
	</body>
</html>
