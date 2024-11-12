<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="checkCorpNum.aspx.cs" Inherits="Popbill.Closedown.Example.checkCorpNum" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>팝빌 사업자등록상태조회 (휴폐업조회) API SDK ASP.NET Example</title>
    <link href="../Example.css" rel="stylesheet" type="text/css"/>
</head>
<body>
<div id="content">
    <p class="heading1">Response</p>
    <br/>
    <fieldset class="fieldset1">
        <legend>사업자등록상태조회 (휴폐업조회) - 단건</legend>
        <ul>
            <% if (!String.IsNullOrEmpty(code)) { %>
                <li>Response.code : <%= code %> </li>
                <li>Response.message : <%= message %></li>
            <% } else { %>
                <li>corpNum (사업자번호) : <%= result.corpNum %></li>
                <li>taxType (사업자 과세유형) : <%= result.taxType%></li>
                <li>typeDate (과세유형 전환일자) : <%= result.typeDate %></li>
                <li>state (휴폐업상태) : <%= result.state %></li>
                <li>stateDate (휴폐업일자) : <%= result.stateDate %></li>
                <li>checkDate (국세청 확인일자) : <%= result.checkDate %></li>
            <% } %>
            <p class="info">> state (휴폐업상태) : null-알수없음, 0-등록되지 않은 사업자번호, 1-사업중, 2-폐업, 3-휴업</p>
            <p class="info">> taxType (사업자 과세유형) : null-알수없음, 10-일반과세자, 20-면세과세자, 30-간이과세자, 31-간이과세자(세금계산서 발급사업자), 40-비영리법인, 국가기관</p>
            <br/>
        </ul>
    </fieldset>
</div>
</body>
</html>
