<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="getDetailInfo.aspx.cs" Inherits="Popbill.Statement.Example.getDetailInfo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>팝빌 전자명세서 SDK ASP.NET Example</title>
    <link href="../Example.css" rel="stylesheet" type="text/css"/>
</head>
<body>
<div id="content">
    <p class="heading1">Response</p>
    <br/>
    <fieldset class="fieldset1">
        <legend>전자명세서 상세정보 확인</legend>
        <ul>
            <% if (!String.IsNullOrEmpty(code)) { %>
                <li>Response.code : <%= code %> </li>
                <li>Response.message : <%= message %></li>
            <% } else { %>
                <li> itemCode(명세서 코드) : <%= statement.itemCode %> </li>
                <li> mgtKey(문서번호) : <%= statement.mgtKey %> </li>
                <li> invoiceNum(팝빌부여 문서고유번호) : <%= statement.invoiceNum %> </li>
                <li> formCode(맞춤양식 코드) : <%= statement.formCode %> </li>
                <li> writeDate(작성일자) : <%= statement.writeDate %> </li>
                <li> taxType(세금형태) : <%= statement.taxType %> </li>
                <li> senderCorpNum(발신자 사업자번호) : <%= statement.senderCorpNum %> </li>
                <li> senderTaxRegID(발신자 종사업장번호) : <%= statement.senderTaxRegID %> </li>
                <li> senderCorpName(발신자 상호) : <%= statement.senderCEOName %> </li>
                <li> senderCEOName(발신자 대표자성명) : <%= statement.senderCEOName %> </li>
                <li> senderAddr(발신자 주소) : <%= statement.senderAddr %> </li>
                <li> senderBizClass(발신자 종목) : <%= statement.senderBizClass %> </li>
                <li> senderBizType(발신자 업태) : <%= statement.senderBizType %> </li>
                <li> senderContactName(발신자 담당자명) : <%= statement.senderContactName %> </li>
                <li> senderTEL(발신자 연락처) : <%= statement.senderTEL %> </li>
                <li> senderHP(발신자 휴대폰번호) : <%= statement.senderHP %> </li>
                <li> senderEmail(발신자 메일주소) : <%= statement.senderEmail %> </li>
                <li> receiverCorpNum(수신자 사업자번호) : <%= statement.receiverCorpNum %> </li>
                <li> receiverTaxRegID(수신자 종사업장번호) : <%= statement.receiverTaxRegID %> </li>
                <li> receiverCorpName(수신자 상호) : <%= statement.receiverCorpName %> </li>
                <li> receiverCEOName(수신자 대표자성명) : <%= statement.receiverCEOName %> </li>
                <li> receiverAddr(수신자 주소) : <%= statement.receiverAddr %> </li>
                <li> receiverBizClass(수신자 종목) : <%= statement.receiverBizClass %> </li>
                <li> receiverBizType(수신자 업태) : <%= statement.receiverBizType %> </li>
                <li> receiverContactName(수신자 담당자명) : <%= statement.receiverContactName %> </li>
                <li> receiverTEL(수신자 연락처) : <%= statement.receiverTEL %> </li>
                <li> receiverHP(수신자 휴대폰번호) : <%= statement.receiverHP %> </li>
                <li> receiverEmail(수신자 메일주소) : <%= statement.receiverEmail %> </li>
                <li> totalAmount(합계금액) : <%= statement.totalAmount %> </li>
                <li> supplyCostTotal(공급가액 합계) : <%= statement.supplyCostTotal %> </li>
                <li> taxTotal(세액 합계) : <%= statement.taxTotal %> </li>
                <li> purposeType(영수/청구) : <%= statement.purposeType %> </li>
                <li> serialNum(기재상 일련번호) : <%= statement.serialNum %> </li>
                <li> remark1(비고1) : <%= statement.remark1 %> </li>
                <li> remark2(비고2) : <%= statement.remark2 %> </li>
                <li> remark3(비고3) : <%= statement.remark3 %> </li>
                <li> businessLicenseYN(사업자등록증 첨부여부) : <%= statement.businessLicenseYN %> </li>
                <li> bankBookYN(통장사본 첨부여부) : <%= statement.bankBookYN %> </li>
                <li> smssendYN(알림문자 전송여부) : <%= statement.smssendYN %> </li>
                <li> autoacceptYN(발행시 자동승인 여부) : <%= statement.autoacceptYN %> </li>
                
                <% foreach (Popbill.Statement.StatementDetail detail in statement.detailList)
                   { %>
                    <fieldset class="fieldset2">
                        <legend>전자명세서 품목(항목) 정보</legend>
                        <ul>
                            <li>serialNum (일련번호) : <%= detail.serialNum %></li>
                            <li>purchaseDT (거래일자) : <%= detail.purchaseDT %></li>
                            <li>itemName (품명) : <%= detail.itemName %></li>
                            <li>spec (규격) : <%= detail.spec %></li>
                            <li>qty (수량) : <%= detail.qty %></li>
                            <li>unitCost (단가) : <%= detail.unitCost %></li>
                            <li>supplyCost (공급가액) : <%= detail.supplyCost %></li>
                            <li>tax (세액) : <%= detail.tax %></li>
                            <li>remark (비고) : <%= detail.remark %></li>
                        </ul>
                    </fieldset>
                <% } %>
            <% } %>
        </ul>
    </fieldset>
</div>
</body>
</html>
