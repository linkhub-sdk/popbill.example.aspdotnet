﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="getFaxResult.aspx.cs" Inherits="Popbill.Fax.Example.getFaxResult" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>팝빌 팩스 SDK ASP.NET Example</title>
    <link href="../Example.css" rel="stylesheet" type="text/css"/>
</head>
<body>
<div id="content">
    <p class="heading1">Response</p>
    <br/>
    <fieldset class="fieldset1">
        <legend>팩스전송 결과 조회</legend>
        <ul>
            <% if (!String.IsNullOrEmpty(code)) { %>
                <li>Response.code : <%= code %> </li>
                <li>Response.message : <%= message %></li>
            <% } else { %>
                <% foreach (Popbill.Fax.FaxResult faxInfo in result)
                   { %>
                    <fieldset class="fieldset2">
                        <legend>팩스 전송 상태정보</legend>
                        <ul>
                            <li>state (상태코드) : <%= faxInfo.state %></li>
                            <li>result (결과코드) : <%= faxInfo.result %></li>
                            <li>title (팩스제목) : <%= faxInfo.title %></li>
                            <li>sendNum (발신번호) : <%= faxInfo.sendNum %></li>
                            <li>receiveNum (수신번호) : <%= faxInfo.receiveNum %></li>
                            <li>receiveNumType (수신번호 유형) : <%= faxInfo.receiveNumType%></li>
                            <li>receiveName (수신자명) : <%= faxInfo.receiveName %></li>
                            <li>sendPageCnt (전체 페이지수) : <%= faxInfo.sendPageCnt %></li>
                            <li>successPageCnt (성공 페이지수) : <%= faxInfo.successPageCnt %></li>
                            <li>failPageCnt (실패 페이지수) : <%= faxInfo.failPageCnt %></li>
                            <li>cancelPageCnt (취소 페이지수) : <%= faxInfo.cancelPageCnt %></li>
                            <li>reserveDT (예약일시) : <%= faxInfo.reserveDT %></li>
                            <li>receiptDT (접수일시) : <%= faxInfo.receiptDT %></li>
                            <li>sendDT (전송일시) : <%= faxInfo.sendDT %></li>
                            <li>resultDT (전송결과 수신일시) : <%= faxInfo.resultDT %></li>
                            <li>
                                fileNames (전송 파일명 리스트) :
                                <% foreach (String fileName in faxInfo.fileNames)
                                   { %>
                                    <%= fileName %>
                                <% } %>
                            </li>
                            <li>receiptNum (접수번호) : <%= faxInfo.receiptNum %></li>
                            <li>requestNum (요청번호) : <%= faxInfo.requestNum %></li>
                            <li>interOPRefKey (파트너 지정키) : <%= faxInfo.interOPRefKey %></li>
                            <li>chargePageCnt (과금 페이지수) : <%= faxInfo.chargePageCnt %></li>
                            <li>refundPageCnt (환불 페이지수) : <%= faxInfo.refundPageCnt %></li>
                            <li>tiffFileSize (변환파일용량(단위 : byte)) : <%= faxInfo.tiffFileSize %></li>
                        </ul>
                    </fieldset>
                <% } %>
            <% } %>
        </ul>
    </fieldset>
</div>
</body>
</html>
