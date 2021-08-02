﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="search.aspx.cs" Inherits="Popbill.Message.Example.search" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>팝빌 문자 SDK ASP.NET Example</title>
    <link href="../Example.css" rel="stylesheet" type="text/css"/>
</head>
<body>
<div id="content">
    <p class="heading1">Response</p>
    <br/>
    <fieldset class="fieldset1">
        <legend>문자전송 목록조회</legend>
        <ul>
            <% if (!String.IsNullOrEmpty(code)) { %>
                <li>Response.code : <%= code %> </li>
                <li>Response.message : <%= message %></li>
            <% } else { %>
                <li>code (상태코드) : <%= result.code %> </li>
                <li>message (응답메시지) : <%= result.message %> </li>
                <li>total (총 검색결과 건수) : <%= result.total %> </li>
                <li>perPage (페이지당 검색개수) : <%= result.perPage %> </li>
                <li>pageNum (페이지 번호) : <%= result.pageNum %> </li>
                <li>pageCount (페이지 개수) : <%= result.pageCount %> </li>
                <% foreach (Popbill.Message.MessageResult msgInfo in result.list)
                   { %>
                    <fieldset class="fieldset2">
                        <legend>문자 전송 상태정보</legend>
                        <ul>
                            <li>state (전송 상태코드) : <%= msgInfo.state %></li>
                            <li>result (이동통신사 처리결과 코드) : <%= msgInfo.result %></li>
                            <li>subject (메시지 제목) : <%= msgInfo.subject %></li>
                            <li>content (메시지 내용) : <%= msgInfo.content %></li>
                            <li>sendNum (발신번호) : <%= msgInfo.sendNum %></li>
                            <li>receiveNum (수신번호) : <%= msgInfo.receiveNum %></li>
                            <li>receiveName (수신자명) : <%= msgInfo.receiveName %></li>
                            <li>receiptDT (접수시간) : <%= msgInfo.receiptDT %></li>
                            <li>sendDT (발송시간) : <%= msgInfo.sendDT %></li>
                            <li>resultDT (전송결과 수신시간) : <%= msgInfo.resultDT %></li>
                            <li>reserveDT (예약일시) : <%= msgInfo.reserveDT %></li>
                            <li>type (메시지 타입) : <%= msgInfo.type %></li>
                            <li>tranNet (전송처리 이동통신사명) : <%= msgInfo.tranNet %></li>
                            <li>receiptNum (접수번호) : <%= msgInfo.receiptNum %></li>
                            <li>requestNum (요청번호) : <%= msgInfo.requestNum %></li>
                        </ul>
                    </fieldset>
                <% } %>
            <% } %>
        </ul>
    </fieldset>
</div>
</body>
</html>
