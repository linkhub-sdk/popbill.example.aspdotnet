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
    public partial class register : System.Web.UI.Page
    {
        public String code;
        public String message;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 1건의 현금영수증을 [임시저장]합니다.
             * - [임시저장] 상태의 현금영수증은 발행(Issue API)을 호출해야만 국세청에 전송됩니다.
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 팝빌회원 아이디
            String testUserID = "testkorea";

            // 현금영수증 문서번호
            String mgtKey = "20220525-011";

            // 현금영수증 정보 객체
            Cashbill cashbill = new Cashbill();

            // [필수] 문서번호, 최대 24자리, 영문, 숫자 '-', '_'를 조합하여 사업자별로 중복되지 않도록 구성
            cashbill.mgtKey = mgtKey;

            // [필수] 문서형태, {승인거래, 취소거래} 중 기재
            cashbill.tradeType = "승인거래";

            // [필수] 거래구분, {소득공제용, 지출증빙용} 중 기재
            cashbill.tradeUsage = "소득공제용";

            // [필수] 거래유형, {일반, 도서공연, 대중교통} 중 기재
            cashbill.tradeOpt = "일반";

            // [필수] 과세형태, { 과세, 비과세 } 중 기재
            cashbill.taxationType = "과세";

            // [필수] 거래금액 ( 공급가액 + 세액 + 봉사료 ) 
            cashbill.totalAmount = "11000";

            // [필수] 공급가액
            cashbill.supplyCost = "10000";

            // [필수] 부가세
            cashbill.tax = "1000";

            // [필수] 봉사료
            cashbill.serviceFee = "0";

            // [필수] 가맹점 사업자번호
            cashbill.franchiseCorpNum = testCorpNum;

            // 가맹점 종사업장 식별번호
            cashbill.franchiseTaxRegID = "";

            // 가맹점 상호
            cashbill.franchiseCorpName = "발행자 상호";

            // 가맹점 대표자 성명
            cashbill.franchiseCEOName = "발행자 대표자";

            // 가맹점 주소
            cashbill.franchiseAddr = "발행자 주소";

            // 가맹점 전화번호
            cashbill.franchiseTEL = "070-1234-1234";

            // [필수] 식별번호
            // 거래구분(tradeUsage) - '소득공제용' 인 경우 
            // - 주민등록/휴대폰/카드번호 기재 가능
            // 거래구분(tradeUsage) - '지출증빙용' 인 경우
            // - 사업자번호/주민등록/휴대폰/카드번호 기재 가능 
            cashbill.identityNum = "0101112222";

            // 주문자명
            cashbill.customerName = "고객명";

            // 주문상품명
            cashbill.itemName = "상품명";

            // 주문번호
            cashbill.orderNumber = "주문번호";

            // 주문자 메일
            // 팝빌 개발환경에서 테스트하는 경우에도 안내 메일이 전송되므로,
            // 실제 거래처의 메일주소가 기재되지 않도록 주의
            cashbill.email = "test@test.com";

            // 주문자 휴대폰
            cashbill.hp = "010-111-222";

            // 주문자 팩스번호
            cashbill.fax = "02-111-222";

            // 발행시 알림문자 전송여부
            cashbill.smssendYN = false;

            try
            {
                Response response = Global.cashbillService.Register(testCorpNum, cashbill, testUserID);

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
