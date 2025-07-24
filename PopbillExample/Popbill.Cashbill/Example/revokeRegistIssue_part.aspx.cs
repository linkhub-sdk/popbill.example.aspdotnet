using System;
using System.Collections;
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

namespace Popbill.Cashbill.Example
{
    public partial class revokeRegistIssue_part : System.Web.UI.Page
    {
        public String code;
        public String message;
        public String confirmNum;
        public String tradeDate;
        public String tradeDT;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 당초 승인 현금영수증의 취소거래 발행 API 입니다.
             * - https://developers.popbill.com/reference/cashbill/dotnet/api/issue#RevokeRegistIssue
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 문서번호, 최대 24자리, 영문, 숫자 '-', '_'를 조합하여 사업자별로 중복되지 않도록 구성
            String mgtKey = "20220525-001";

            // 원본현금영수증 승인번호, 문서정보 확인(GetInfo API)로 확인가능
            String orgConfirmNum = "TB0000027";

            // 원본현금영수증 거래일자, 문서정보 확인(GetInfo API)로 확인가능
            String orgTradeDate = "20220524";

            // 안내문자 전송여부
            bool smssendYN = false;

            // 메모
            String memo = "부분취소현금영수증 발행메모";

            // 팝빌회원 아이디
            String userId = "testkorea";

            // 부분취소여부 true-부분취소, false-전체취소
            bool isPartCancel = true;

            // 취소사유, 1-거래취소, 2-오류발급취소, 3-기타
            int cancelType = 1;

            // [취소] 공급가액
            String supplyCost = "3000";

            // [취소] 세액
            String tax = "300";

            // [취소] 봉사료
            String serviceFee = "";

            // [취소] 합계금액
            String totalAmount = "3300";

            // 안내메일 제목, 공백처리시 기본양식으로 전송
            String emailSubject = "메일제목 테스트";

            // 거래일시, 날짜(yyyyMMddHHmmss)
            // 당일, 전일만 가능, 미입력시 기본값 발행일시 처리
            String tradeDT = "20221108000000";

            try
            {
                CBIssueResponse response = Global.cashbillService.RevokeRegistIssue(testCorpNum, mgtKey,
                    orgConfirmNum, orgTradeDate, smssendYN, memo, userId ,isPartCancel, cancelType,
                    supplyCost, tax, serviceFee, totalAmount, emailSubject, tradeDT);

                code = response.code.ToString();
                message = response.message;
                confirmNum = response.confirmNum;
                tradeDate = response.tradeDate;
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
