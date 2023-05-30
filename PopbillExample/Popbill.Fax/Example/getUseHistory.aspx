<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="getUseHistory.aspx.cs" Inherits="Popbill.Fax.Example.getUseHistory" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>팝빌 팩스 SDK ASP.NET Example</title>
    <link href="../Example.css" rel="stylesheet" type="text/css"/>
</head>
<body>
<div id="content">
    <p class="heading1">Response</p>
    <br/>
    <fieldset class="fieldset1">
        <legend>연동회원 포인트 사용내역 확인</legend>
        <ul>
            <% if (!String.IsNullOrEmpty(code)) { %>
                <li>Response.code : <%= code %> </li>
                <li>Response.message : <%= message %></li>
            <% } else { %>
                <li>code (응답코드) : <%= result.code %></li>
                <li>total (총 검색결과 건수) : <%= result.total %></li>
                <li>perPage (페이지당 검색개수) : <%= result.perPage %></li>
                <li>pageNum (페이지 번호) : <%= result.pageNum %></li>
                <li>pageCount (페이지 개수) : <%= result.pageCount %></li>

                <% foreach (Popbill.UseHistory useHistory in result.list)
                { %>
                    <fieldset class="fieldset2">
                        <legend>사용 내역</legend>
                        <ul>
                            <li>itemCode (서비스 코드) : <%= useHistory.itemCode %> </li>
                            <li>txType (포인트 증감 유형) : <%= useHistory.txType %> </li>
                            <li>txPoint (증감 포인트) : <%= useHistory.txPoint %> </li>
                            <li>balance (잔여포인트) : <%= useHistory.balance %> </li>
                            <li>txDT (포인트 증감 일시) : <%= useHistory.txDT %> </li>
                            <li>userID (담당자 아이디): <%= useHistory.userID %> </li>
                            <li>userName (담당자명): <%= useHistory.userName %> </li>
                        </ul>
                    </fieldset>
                <% } %>
            <% } %>
        </ul>
    </fieldset>
</div>
</body>
</html>
