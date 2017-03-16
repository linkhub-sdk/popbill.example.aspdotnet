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
    public partial class update : System.Web.UI.Page
    {
        public String code;
        public String message;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
            * 1건의 현금영수증을 수정합니다.
            * - [임시저장] 상태의 현금영수증만 수정할 수 있습니다.
            * - 국세청에 신고된 현금영수증은 수정할 수 없으며, 취소 현금영수증을 발행하여
            *   취소처리 할 수 있습니다.
            * - 취소현금영수증 작성방법 안내 - http://blog.linkhub.co.kr/702
            */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 팝빌회원 아이디
            String testUserID = "testkorea";

            // 현금영수증 문서관리번호
            String mgtKey = "20170316-02";


            // 현금영수증 정보 객체
            Cashbill cashbill = new Cashbill();

            // [필수] 문서관리번호, 사업자별로 중복되지 않도록 관리번호 할당
            // 1~24자리 영문,숫자,'-','_' 조합 구성
            cashbill.mgtKey = mgtKey;

            // [필수] 거래유형, {승인거래, 취소거래} 중 기재
            cashbill.tradeType = "승인거래";

            // [필수] 과세형태, { 과세, 비과세 } 중 기재
            cashbill.taxationType = "과세";

            // [필수] 공급가액
            cashbill.supplyCost = "10000";

            // [필수] 세액 
            cashbill.tax = "1000";

            // [필수] 봉사료
            cashbill.serviceFee = "0";

            // [필수] 거래금액 ( 공급가액 + 세액 + 봉사료 ) 
            cashbill.totalAmount = "11000";

            // [필수] 현금영수증 형태, {소득공제용, 지출증빙용} 중 기재
            cashbill.tradeUsage = "소득공제용";

            // [필수] 거래처 식별번호
            // 현금영수증 형태(tradeUsage) - '소득공제용' 인 경우 
            // - 주민등록/휴대폰/카드번호 기재 가능
            // 현금영수증 형태(tradeUsage) - '지출증빙용' 인 경우
            // - 사업자번호/주민등록/휴대폰/카드번호 기재 가능 
            cashbill.identityNum = "0101112222";


            // [필수] 발행자 사업자번호
            cashbill.franchiseCorpNum = testCorpNum;

            // 발행자 상호
            cashbill.franchiseCorpName = "발행자 상호_수정";

            // 발행자 대표자 성명
            cashbill.franchiseCEOName = "발행자 대표자_수정";

            // 발행자 주소
            cashbill.franchiseAddr = "발행자 주소";

            // 발행자 연락처
            cashbill.franchiseTEL = "070-1234-1234";


            // 고객명
            cashbill.customerName = "고객명";

            // 상품명
            cashbill.itemName = "상품명";

            // 주문번호
            cashbill.orderNumber = "주문번호";

            // 고객 메일
            cashbill.email = "test@test.com";

            // 고객 휴대폰번호
            cashbill.hp = "010-111-222";

            // 고객 팩스번호
            cashbill.fax = "070-111-222";

            // 발행시 알림문자 전송여부
            cashbill.smssendYN = false;

            try
            {
                Response response = Global.cashbillService.Update(testCorpNum, mgtKey, cashbill, testUserID);

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
