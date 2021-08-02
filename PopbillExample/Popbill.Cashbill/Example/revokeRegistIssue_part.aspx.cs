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

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 취소 현금영수증을 발행하며 취소 현금영수증의 금액은 원본 금액을 넘을 수 없습니다.
             * - 현금영수증 국세청 전송 정책 : https://docs.popbill.com/cashbill/ntsSendPolicy?lang=dotnet
             * - https://docs.popbill.com/cashbill/dotnet/api#RevokeRegistIssue
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 팝빌회원 아이디
            String testUserID = "testkorea";

            // [필수] 문서번호, 최대 24자리, 영문, 숫자 '-', '_'를 조합하여 사업자별로 중복되지 않도록 구성
            String mgtKey = "20210702-011";

            // 원본현금영수증 승인번호, 문서정보 확인(GetInfo API)로 확인가능
            String orgConfirmNum = "548757045";

            // 원본현금영수증 거래일자, 문서정보 확인(GetInfo API)로 확인가능
            String orgTradeDate = "20210701";

            // 안내문자 전송여부
            bool smssendYN = false;

            // 메모
            String memo = "부분취소현금영수증 발행메모";

            
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

            try
            {
                Response response = Global.cashbillService.RevokeRegistIssue(testCorpNum, mgtKey,
                    orgConfirmNum, orgTradeDate, smssendYN, memo, testUserID, isPartCancel, cancelType, 
                    supplyCost, tax, serviceFee, totalAmount);

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
