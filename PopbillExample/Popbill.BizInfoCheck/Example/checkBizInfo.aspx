<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="checkBizInfo.aspx.cs" Inherits="Popbill.BizInfoCheck.Example.checkBizInfo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>팝빌 기업정보조회 API SDK ASP.NET Example</title>
    <link href="../Example.css" rel="stylesheet" type="text/css"/>
</head>
<body>
<div id="content">
    <p class="heading1">Response</p>
    <br/>
    <fieldset class="fieldset1">
        <legend>기업정보조회</legend>
        <ul>
            <% if (!String.IsNullOrEmpty(code)) { %>
                <li>Response.code : <%= code %> </li>
                <li>Response.message : <%= message %></li>
            <% } else { %>
                <li>corpNum (사업자번호) : <%= result.corpNum%></li>
                <li>companyRegNum (법인번호): <%=result.companyRegNum%></li>
                <li>checkDT (확인일시) : <%=result.checkDT%></li>
                <li>corpName (상호): <%=result.corpName%></li>
                <li>corpCode (기업형태코드): <%=result.corpCode%></li>
                <li>corpScaleCode (기업규모코드): <%=result.corpScaleCode%></li>
                <li>personCorpCode (개인법인코드): <%=result.personCorpCode%></li>
                <li>headOfficeCode (본점지점코드) : <%=result.headOfficeCode%></li>
                <li>industryCode (산업코드) : <%=result.industryCode%></li>
                <li>establishCode (설립구분코드) : <%=result.establishCode%></li>
                <li>establishDate (설립일자) : <%=result.establishDate%></li>
                <li>CEOName (대표자명) : <%=result.ceoname%></li>
                <li>workPlaceCode (사업장구분코드): <%=result.workPlaceCode%></li>
                <li>addrCode (주소구분코드) : <%=result.addrCode%></li>
                <li>zipCode (우편번호) : <%=result.zipCode%></li>
                <li>addr (주소) : <%=result.addr%></li>
                <li>addrDetail (상세주소) : <%=result.addrDetail%></li>
                <li>enAddr (영문주소) : <%=result.enAddr%></li>
                <li>bizClass (업종) : <%=result.bizClass%></li>
                <li>bizType (업태) : <%=result.bizType%></li>
                <li>result (결과코드) : <%=result.result%></li>
                <li>resultMessage (결과메시지) : <%=result.resultMessage%></li>
                <li>closeDownTaxType (사업자과세유형) : <%=result.closeDownTaxType%></li>
                <li>closeDownTaxTypeDate (과세유형전환일자):<%=result.closeDownTaxTypeDate%></li>
                <li>closeDownState (휴폐업상태) : <%=result.closeDownState%></li>
                <li>closeDownStateDate (휴폐업일자) : <%=result.closeDownStateDate%></li>	
            <% } %>
        </ul>
    </fieldset>
</div>
</body>
</html>
