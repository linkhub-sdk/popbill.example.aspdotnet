﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace Popbill.Taxinvoice
{
    public partial class register : System.Web.UI.Page
    {
        public String code = null;
        public String message = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 작성된 세금계산서 데이터를 팝빌에 저장합니다.
             * - "임시저장" 상태의 세금계산서는 발행(Issue) 함수를 호출하여 "발행완료" 처리한 경우에만 국세청으로 전송됩니다.
             * - 정발행 시 임시저장(Register)과 발행(Issue)을 한번의 호출로 처리하는 즉시발행(RegistIssue API) 프로세스 연동을 권장합니다.
             * - 역발행 시 임시저장(Register)과 역발행요청(Request)을 한번의 호출로 처리하는 즉시요청(RegistRequest API) 프로세스 연동을 권장합니다.
             * - 세금계산서 파일첨부 기능을 구현하는 경우, 임시저장(Register API) -> 파일첨부(AttachFile API) -> 발행(Issue API) 함수를 차례로 호출합니다.
             * - 임시저장된 세금계산서는 팝빌 사이트 '임시문서함'에서 확인 가능합니다.
             * - https://docs.popbill.com/taxinvoice/dotnet/api#Register
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 세금계산서 문서번호, 최대 24자리, 영문, 숫자 '-', '_'를 조합하여 사업자별로 중복되지 않도록 구성
            String mgtKey = "20220525-002";

            // 세금계산서 정보 객체
            Taxinvoice taxinvoice = new Taxinvoice();

            // 기재상 작성일자, 날자형식(yyyyMMdd)
            taxinvoice.writeDate = "20220525";

            // 과금방향, {정과금, 역과금}중 선택
            // - 정과금(공급자과금), 역과금(공급받는자과금)
            // - 역과금은 역발행 세금계산서를 발행하는 경우만 가능
            taxinvoice.chargeDirection = "정과금";

            // 발행형태, {정발행, 역발행, 위수탁} 중 기재
            taxinvoice.issueType = "정발행";

            // {영수, 청구, 없음} 중 기재
            taxinvoice.purposeType = "영수";

            // 과세형태, {과세, 영세, 면세} 중 기재
            taxinvoice.taxType = "과세";


            /*****************************************************************
             *                         공급자 정보                           *
             *****************************************************************/

            // 공급자 사업자번호, '-' 제외 10자리
            taxinvoice.invoicerCorpNum = testCorpNum;

            // 공급자 종사업장 식별번호. 필요시 기재. 형식은 숫자 4자리.
            taxinvoice.invoicerTaxRegID = "";

            // 공급자 상호
            taxinvoice.invoicerCorpName = "공급자 상호";

            // 공급자 문서번호, 최대 24자리, 영문, 숫자 '-', '_'를 조합하여 사업자별로 중복되지 않도록 구성
            taxinvoice.invoicerMgtKey = mgtKey;

            // 공급자 대표자 성명
            taxinvoice.invoicerCEOName = "공급자 대표자 성명";

            // 공급자 주소
            taxinvoice.invoicerAddr = "공급자 주소";

            // 공급자 종목
            taxinvoice.invoicerBizClass = "공급자 종목";

            // 공급자 업태
            taxinvoice.invoicerBizType = "공급자 업태,업태2";

            // 공급자 담당자 성명
            taxinvoice.invoicerContactName = "공급자 담당자명";

            // 공급자 담당자 메일주소
            taxinvoice.invoicerEmail = "";

            // 공급자 담당자 연락처
            taxinvoice.invoicerTEL = "";

            // 공급자 담당자 휴대폰번호
            taxinvoice.invoicerHP = "";

            // 발행 안내 문자 전송여부 (true / false 중 택 1)
            // └ true = 전송 , false = 미전송
            // └ 공급받는자 (주)담당자 휴대폰번호 {invoiceeHP1} 값으로 문자 전송
            // - 전송 시 포인트 차감되며, 전송실패시 환불처리
            taxinvoice.invoicerSMSSendYN = false;


            /*********************************************************************
             *                         공급받는자 정보                           *
             *********************************************************************/

            // 공급받는자 구분, {사업자, 개인, 외국인} 중 기재
            taxinvoice.invoiceeType = "사업자";

            // 공급받는자 사업자번호
            // - {invoiceeType}이 "사업자" 인 경우, 사업자번호 (하이픈 ('-') 제외 10자리)
            // - {invoiceeType}이 "개인" 인 경우, 주민등록번호 (하이픈 ('-') 제외 13자리)
            // - {invoiceeType}이 "외국인" 인 경우, "9999999999999" (하이픈 ('-') 제외 13자리)
            taxinvoice.invoiceeCorpNum = "8888888888";

            // 공급받는자 상호
            taxinvoice.invoiceeCorpName = "공급받는자 상호";

            // [역발행시 필수] 공급받는자 문서번호, 최대 24자리, 영문, 숫자 '-', '_'를 조합하여 사업자별로 중복되지 않도록 구성
            taxinvoice.invoiceeMgtKey = "";

            // 공급받는자 대표자 성명
            taxinvoice.invoiceeCEOName = "공급받는자 대표자 성명";

            // 공급받는자 주소
            taxinvoice.invoiceeAddr = "공급받는자 주소";

            // 공급받는자 종목
            taxinvoice.invoiceeBizClass = "공급받는자 종목";

            // 공급받는자 업태
            taxinvoice.invoiceeBizType = "공급받는자 업태";

            // 공급받는자 담당자 연락처
            taxinvoice.invoiceeTEL1 = "";

            // 공급받는자 담당자명
            taxinvoice.invoiceeContactName1 = "공급받는자 담당자명";

            // 공급받는자 담당자 메일주소
            // 팝빌 개발환경에서 테스트하는 경우에도 안내 메일이 전송되므로,
            // 실제 거래처의 메일주소가 기재되지 않도록 주의
            taxinvoice.invoiceeEmail1 = "";

            // 공급받는자 담당자 휴대폰번호
            taxinvoice.invoiceeHP1 = "";

            // 역발행 안내 문자 전송여부 (true / false 중 택 1)
            // └ true = 전송 , false = 미전송
            // └ 공급자 담당자 휴대폰번호 {invoicerHP} 값으로 문자 전송
            // - 전송 시 포인트 차감되며, 전송실패시 환불처리
            taxinvoice.invoiceeSMSSendYN = false;


            /*********************************************************************
             *                          세금계산서 정보                          *
             *********************************************************************/

            // 공급가액 합계
            taxinvoice.supplyCostTotal = "100000";

            // 세액 합계
            taxinvoice.taxTotal = "10000";

            // 합계금액,  공급가액 합계 + 세액 합계
            taxinvoice.totalAmount = "110000";

            // 기재상 일련번호 항목
            taxinvoice.serialNum = "123";

            // 기재상 현금 항목
            taxinvoice.cash = "";

            // 기재상 수표 항목
            taxinvoice.chkBill = "";

            // 기재상 어음 항목
            taxinvoice.note = "";

            // 기재상 외상미수금 항목
            taxinvoice.credit = "";

            // 기재상 비고 항목
            taxinvoice.remark1 = "비고1";
            taxinvoice.remark2 = "비고2";
            taxinvoice.remark3 = "비고3";

            // 기재상 권 항목, 최대값 32767
            // 미기재시 taxinvoice.kwon = null;
            taxinvoice.kwon = 1;

            // 기재상 호 항목, 최대값 32767
            // 미기재시 taxinvoice.ho = null;
            taxinvoice.ho = 1;

            // 사업자등록증 이미지 첨부여부 (true / false 중 택 1)
            // └ true = 첨부 , false = 미첨부(기본값)
            // - 팝빌 사이트 또는 인감 및 첨부문서 등록 팝업 URL (GetSealURL API) 함수를 이용하여 등록
            taxinvoice.businessLicenseYN = false;

            // 통장사본 이미지 첨부여부 (true / false 중 택 1)
            // └ true = 첨부 , false = 미첨부(기본값)
            // - 팝빌 사이트 또는 인감 및 첨부문서 등록 팝업 URL (GetSealURL API) 함수를 이용하여 등록
            taxinvoice.bankBookYN = false;


            /**************************************************************************
             *        수정세금계산서 정보 (수정세금계산서 작성시에만 기재
             * - 수정세금계산서 관련 정보는 연동매뉴얼 또는 개발가이드 링크 참조
             * - [참고] 수정세금계산서 작성방법 안내 - https://docs.popbill.com/taxinvoice/modify?lang=dotnet
             *************************************************************************/

            // 수정사유코드, 1~6까지 선택기재.
            taxinvoice.modifyCode = null;

            // 수정세금계산서 작성시 원본세금계산서의 국세청승인번호 기재
            taxinvoice.orgNTSConfirmNum = "";

            /**************************************************************************
             *                         상세항목(품목) 정보                            *
             * - 상세항목 정보는 세금계산서 필수기재사항이 아니므로 작성하지 않더라도 *
             *   세금계산서 발행이 가능합니다.                                        *
             * - 최대 99건까지 작성가능                                               *
             **************************************************************************/

            taxinvoice.detailList = new List<TaxinvoiceDetail>();

            TaxinvoiceDetail detail = new TaxinvoiceDetail();

            detail.serialNum = 1; // 일련번호, 1부터 순차기재
            detail.purchaseDT = "20220525"; // 거래일자
            detail.itemName = "품목명"; // 품목명
            detail.spec = "규격"; // 규격
            detail.qty = "1"; // 수량
            detail.unitCost = "50000"; // 단가
            detail.supplyCost = "50000"; // 공급가액
            detail.tax = "5000"; // 세액
            detail.remark = "품목비고"; // 비고

            taxinvoice.detailList.Add(detail);

            detail = new TaxinvoiceDetail();

            detail.serialNum = 2; // 일련번호, 1부터 순차기재
            detail.purchaseDT = "20220525"; // 거래일자
            detail.itemName = "품목명"; // 품목명
            detail.spec = "규격"; // 규격
            detail.qty = "1"; // 수량
            detail.unitCost = "50000"; // 단가
            detail.supplyCost = "50000"; // 공급가액
            detail.tax = "5000"; // 세액
            detail.remark = "품목비고"; // 비고

            taxinvoice.detailList.Add(detail);


            /*************************************************************************
            *                           추가담당자 정보                              *
            * - 세금계산서 발행안내 메일을 수신받을 공급받는자 담당자가 다수인 경우  *
            *   담당자 정보를 추가하여 발행안내메일을 다수에게 전송할 수 있습니다.   *
            * - 최대 5개까지 기재가능                                                *
            *************************************************************************/

            taxinvoice.addContactList = new List<TaxinvoiceAddContact>();

            TaxinvoiceAddContact addContact = new TaxinvoiceAddContact();

            addContact.serialNum = 1; // 일련번호, 1부터 순차기재
            addContact.email = ""; // 추가담당자 메일주소
            addContact.contactName = "추가담당자명"; // 추가담당자 성명

            taxinvoice.addContactList.Add(addContact);

            TaxinvoiceAddContact addContact2 = new TaxinvoiceAddContact();

            addContact2.serialNum = 2; // 일련번호, 1부터 순차기재
            addContact2.email = ""; // 추가담당자 메일주소
            addContact2.contactName = "추가담당자명"; // 추가담당자 성명

            taxinvoice.addContactList.Add(addContact2);

            try
            {
                Response response = Global.taxinvoiceService.Register(testCorpNum, taxinvoice);

                code = response.code.ToString();
                message = response.message;
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
