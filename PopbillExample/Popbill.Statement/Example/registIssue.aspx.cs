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

namespace Popbill.Statement.Example
{
    public partial class registIssue : System.Web.UI.Page
    {
        public String code;
        public String message;
        public String invoiceNum = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 작성된 전자명세서 데이터를 팝빌에 저장과 동시에 발행하여, "발행완료" 상태로 처리합니다.
             * - 팝빌 사이트 [전자명세서] > [환경설정] > [전자명세서 관리] 메뉴의 발행시 자동승인 옵션 설정을 통해 전자명세서를 "발행완료" 상태가 아닌 "승인대기" 상태로 발행 처리 할 수 있습니다.
             * - https://docs.popbill.com/statement/dotnet/api#RegistIssue
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 팝빌회원 아이디
            String testUserID = "testkorea";

            // 맞춤양식코드, 미기재시 기본양식으로 처리
            String formCode = "";

            // 명세서 코드 - 121(거래명세서), 122(청구서), 123(견적서), 124(발주서), 125(입금표), 126(영수증)
            int itemCode = 121;

            // 전자명세서 문서번호, 최대 24자리, 영문, 숫자 '-', '_'를 조합하여 사업자별로 중복되지 않도록 구성
            String mgtKey = "20220525-002";

            // 즉시발행 메모
            String memo = "즉시발행 메모";

            // 안내메일 제목, 공백처리시 기본양식으로 전송
            String emailSubject = "메일 제목 테스트";


            // 전자명세서 객체
            Statement statement = new Statement();

            // 기재상 작성일자 날짜형식(yyyyMMdd)
            statement.writeDate = "20220525";

            // {영수, 청구, 없음} 중 기재
            statement.purposeType = "영수";

            // 과세형태, {과세, 영세, 면세} 중 기재
            statement.taxType = "과세";

            // 맞춤양식코드, 기본값을 공백('')으로 처리하면 기본양식으로 처리.
            statement.formCode = formCode;

            // 명세서 코드
            statement.itemCode = itemCode;

            // 문서번호, 최대 24자리, 영문, 숫자 '-', '_'를 조합하여 사업자별로 중복되지 않도록 구성
            statement.mgtKey = mgtKey;


            /**************************************************************************
             *                          발신자 정보                                   *
             **************************************************************************/

            // 발신자 사업자번호
            statement.senderCorpNum = testCorpNum;

            // 종사업장 식별번호. 필요시 기재. 형식은 숫자 4자리.
            statement.senderTaxRegID = "";

            // 발신자 상호
            statement.senderCorpName = "발신자 상호";

            // 발신자 대표자 성명
            statement.senderCEOName = "발신자 대표자 성명";

            // 발신자 주소
            statement.senderAddr = "발신자 주소";

            // 발신자 종목
            statement.senderBizClass = "발신자 종목";

            // 발신자 업태
            statement.senderBizType = "발신자 업태,업태2";

            // 발신자 담당자 성명
            statement.senderContactName = "발신자 담당자명";

            // 발신자 메일주소
            statement.senderEmail = "";

            // 발신자 연락처
            statement.senderTEL = "";

            // 발신자 휴대폰번호
            statement.senderHP = "";


            /**************************************************************************
             *                             수신자 정보                                *
             **************************************************************************/

            // 수신자 사업자번호
            statement.receiverCorpNum = "8888888888";

            // 수신자 상호
            statement.receiverCorpName = "수신자 상호";

            // 수신자 대표자 성명
            statement.receiverCEOName = "수신자 대표자 성명";

            // 수신자 주소
            statement.receiverAddr = "수신자 주소";

            // 수신자 종목
            statement.receiverBizClass = "수신자 종목";

            // 수신자 업태
            statement.receiverBizType = "수신자 업태";

            // 수신자 담당자 성명
            statement.receiverContactName = "수신자 담당자명";

            // 수신자 메일주소
            // 팝빌 개발환경에서 테스트하는 경우에도 안내 메일이 전송되므로,
            // 실제 거래처의 메일주소가 기재되지 않도록 주의
            statement.receiverEmail = "";

            /**************************************************************************
             *                         전자명세서 기재항목                            *
             **************************************************************************/

            // 공급가액 합계
            statement.supplyCostTotal = "200000";

            // 세액 합계
            statement.taxTotal = "20000";

            // 합계금액
            statement.totalAmount = "220000";

            // 기재상 일련번호 항목
            statement.serialNum = "123";

            // 기재상 비고 항목
            statement.remark1 = "비고1";
            statement.remark2 = "비고2";
            statement.remark3 = "비고3";

            // 사업자등록증 이미지 첨부여부 (true / false 중 택 1)
            // └ true = 첨부 , false = 미첨부(기본값)
            // - 팝빌 사이트 또는 인감 및 첨부문서 등록 팝업 URL (GetSealURL API) 함수를 이용하여 등록
            statement.businessLicenseYN = false;

            // 통장사본 이미지 첨부여부 (true / false 중 택 1)
            // └ true = 첨부 , false = 미첨부(기본값)
            // - 팝빌 사이트 또는 인감 및 첨부문서 등록 팝업 URL (GetSealURL API) 함수를 이용하여 등록
            statement.bankBookYN = false;

            statement.detailList = new List<StatementDetail>();

            StatementDetail detail = new StatementDetail();

            detail.serialNum = 1; // 일련번호, 1부터 순차기재, 최대 99
            detail.purchaseDT = "20220525"; // 거래일자
            detail.itemName = "품목명"; // 품목명
            detail.spec = "규격"; // 규격
            detail.qty = "1"; // 수량
            detail.unitCost = "100000"; // 단가
            detail.supplyCost = "100000"; // 공급가액
            detail.tax = "10000"; // 세액
            detail.remark = "품목비고"; // 비고
            detail.spare1 = "spare1"; //여분1
            detail.spare1 = "spare2"; //여분2
            detail.spare1 = "spare3"; //여분3
            detail.spare1 = "spare4"; //여분4
            detail.spare1 = "spare5"; //여분5

            statement.detailList.Add(detail);

            detail = new StatementDetail();

            detail.serialNum = 2; // 일련번호, 1부터 순차기재, 최대 99
            detail.purchaseDT = "20220525"; // 거래일자
            detail.itemName = "품목명"; // 품목명
            detail.spec = "규격"; // 규격
            detail.qty = "1"; // 수량
            detail.unitCost = "100000"; // 단가
            detail.supplyCost = "100000"; // 공급가액
            detail.tax = "10000"; // 세액
            detail.remark = "품목비고"; // 비고
            detail.spare1 = "spare1"; //여분1
            detail.spare1 = "spare2"; //여분2
            detail.spare1 = "spare3"; //여분3
            detail.spare1 = "spare4"; //여분4
            detail.spare1 = "spare5"; //여분5

            statement.detailList.Add(detail);


            /************************************************************
             * 전자명세서 추가속성
             * - 추가속성에 관한 자세한 사항은 "[전자명세서 API 연동매뉴얼] >
             *   5.2. 기본양식 추가속성 테이블"을 참조하시기 바랍니다.
             * - https://docs.popbill.com/statement/propertyBag?lang=dotnet
             ************************************************************/
            statement.propertyBag = new propertyBag();

            statement.propertyBag.Add("Balance", "15000"); // 전잔액
            statement.propertyBag.Add("Deposit", "5000"); // 입금액
            statement.propertyBag.Add("CBalance", "20000"); // 현잔액

            try
            {
                STMIssueResponse response = Global.statementService.RegistIssue(testCorpNum, statement, memo, testUserID, emailSubject);
                code = response.code.ToString();
                message = response.message;
                invoiceNum = response.invoiceNum;
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
