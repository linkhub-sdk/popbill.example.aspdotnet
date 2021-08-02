<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="getFlatRateState.aspx.cs" Inherits="Popbill.HomeTax.Taxinvoice.Example.getFlatRateState" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>팝빌 홈택스 세금계산서 매입/매출 조회 API SDK ASP.NET Example</title>
    <link href="../Example.css" rel="stylesheet" type="text/css"/>
</head>
<body>
<div id="content">
    <p class="heading1">Response</p>
    <br/>
    <fieldset class="fieldset1">
        <legend>정액제 서비스 상태 확인</legend>
        <ul>
            <% if (!String.IsNullOrEmpty(code)) { %>
                <li>Response.code : <%= code %> </li>
                <li>Response.message : <%= message %></li>
            <% } else { %>
                <li>referenceID (사업자번호) : <%= flatRateInfo.referenceID %></li>
                <li>contactDT (정액제 서비스 시작일시) : <%= flatRateInfo.contractDT %></li>
                <li>useEndDate (정액제 서비스 종료일) : <%= flatRateInfo.useEndDate %></li>
                <li>baseDate (자동연장 결제일) : <%= flatRateInfo.baseDate %></li>
                <li>state (정액제 서비스 상태) : <%= flatRateInfo.state %></li>
                <li>closeRequestYN (정액제 서비스 해지신청 여부) : <%= flatRateInfo.closeRequestYN %></li>
                <li>useRestrictYN (정액제 서비스 사용제한 여부) : <%= flatRateInfo.useRestrictYN %></li>
                <li>closeOnExpired (정액제 서비스 만료시 해지 여부) : <%= flatRateInfo.closeOnExpired %></li>
                <li>unPaidYN (미수금 보유 여부) : <%= flatRateInfo.unPaidYN %></li>
            <% } %>
        </ul>
    </fieldset>
</div>
</body>
</html>
