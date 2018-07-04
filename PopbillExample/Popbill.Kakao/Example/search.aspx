<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="search.aspx.cs" Inherits="Popbill.Kakao.Example.search" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>팝빌 카카오톡 SDK ASP.NET Example</title>
    <link href="../Example.css" rel="stylesheet" type="text/css" />
</head>
<body>
		<div id="content">
			<p class="heading1">Response</p>
			<br/>
			<fieldset class="fieldset1">
				<legend>카카오톡 전송내역 목록조회</legend>
				<ul>
					<% if (!String.IsNullOrEmpty(code)) { %>
						<li>Response.code : <%=code %> </li>
						<li>Response.message : <%= message %></li>
					<% } else {	%>
					    <li>code (상태코드) : <%=result.code %> </li>
					    <li>message (응답메시지) : <%=result.message %> </li>
					    <li>total (총 검색결과 건수) : <%=result.total %> </li>
					    <li>perPage (페이지당 검색개수) : <%=result.perPage %> </li>
					    <li>pageNum (페이지 번호) : <%=result.pageNum %> </li>
					    <li>pageCount (페이지 개수) : <%=result.pageCount %> </li>
					    
					    <% foreach (Popbill.Kakao.KakaoSentDetail sentInfo in result.list) { %>
					        <fieldset class="fieldset2">
					        <legend>카카오톡 전송 상태정보</legend>
					            <ul>
    						        <li>state (전송상태 코드) : <%= sentInfo.state%></li>
    						        <li>sendDT (전송일시) : <%= sentInfo.sendDT%></li>
    						        <li>result (전송결과 코드) : <%= sentInfo.result%></li>
    						        <li>resultDT (전송결과 수신일시) : <%= sentInfo.resultDT%></li>
    						        <li>contentType (카카오톡 유형) : <%= sentInfo.contentType%></li>
    						        <li>receiveNum (수신번호) : <%= sentInfo.receiveNum%></li>
    						        <li>receiveName (수신자명) : <%= sentInfo.receiveName%></li>
    						        <li>content (알림톡/친구톡 내용) : <%= sentInfo.content%></li>
    						        <li>altContentType (대체문자 전송타입) : <%= sentInfo.altContentType%></li>
    						        <li>altSendDT (대체문자 전송일시) : <%= sentInfo.altSendDT%></li>
    						        <li>altResult (대체문자 전송결과 코드) : <%= sentInfo.altResult%></li>
    						        <li>altResultDT (대체문자 전송결과 수신일시) : <%= sentInfo.altResultDT%></li>
    						        <li>receiptNum (접수번호) : <%= sentInfo.receiptNum%></li>
    						        <li>requestNum (요청번호) : <%= sentInfo.requestNum%></li>
    						    </ul>
    						</fieldset>
					    <% } %>
					<% } %>
				</ul>
			</fieldset>
		 </div>
	</body>
</html>
