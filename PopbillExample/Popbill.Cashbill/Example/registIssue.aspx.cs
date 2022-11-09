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
    public partial class registIssue : System.Web.UI.Page
    {
        public String code;
        public String message;
        public String confirmNum;
        public String tradeDate;
        public String tradeDT;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 현금영수증 데이터를 팝빌에 전송하여 발행합니다.
             * - 현금영수증 국세청 전송 정책 : https://docs.popbill.com/cashbill/ntsSendPolicy?lang=dotnet
             * - https://docs.popbill.com/cashbill/dotnet/api#RegistIssue
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 팝빌회원 아이디
            String testUserID = "testkorea";

            // 현금영수증 문서번호
            String mgtKey = "20221108_ASP_001";

            // 메모
            String memo = "즉시발행 메모";

            // 안내메일 제목, 공백처리시 기본양식으로 전송
            String emailSubject = "";


            // 현금영수증 정보 객체
            Cashbill cashbill = new Cashbill();

            // 문서번호, 최대 24자리, 영문, 숫자 '-', '_'를 조합하여 사업자별로 중복되지 않도록 구성
            cashbill.mgtKey = mgtKey;

            // 문서형태, {승인거래, 취소거래} 중 기재
            cashbill.tradeType = "승인거래";

            // 거래구분, {소득공제용, 지출증빙용} 중 기재
            cashbill.tradeUsage = "소득공제용";

            // 거래유형, {일반, 도서공연, 대중교통} 중 기재
            // - 미입력시 기본값 "일반" 처리
            cashbill.tradeOpt = "일반";

            // 과세형태, { 과세, 비과세 } 중 기재
            cashbill.taxationType = "과세";

            // 거래금액 ( 공급가액 + 세액 + 봉사료 )
            cashbill.totalAmount = "11000";

            // 공급가액
            cashbill.supplyCost = "10000";

            // 부가세
            cashbill.tax = "1000";

            // 봉사료
            cashbill.serviceFee = "0";

            // 가맹점 사업자번호
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
            cashbill.franchiseTEL = "";

            // 식별번호, 거래구분에 따라 작성
            // └ 소득공제용 - 주민등록/휴대폰/카드번호(현금영수증 카드)/자진발급용 번호(010-000-1234) 기재가능
            // └ 지출증빙용 - 사업자번호/주민등록/휴대폰/카드번호(현금영수증 카드) 기재가능
            // └ 주민등록번호 13자리, 휴대폰번호 10~11자리, 카드번호 13~19자리, 사업자번호 10자리 입력 가능
            cashbill.identityNum = "0100001234";

            // 주문자명
            cashbill.customerName = "고객명";

            // 주문상품명
            cashbill.itemName = "상품명";

            // 주문번호
            cashbill.orderNumber = "주문번호";

            // 주문자 메일
            // 팝빌 개발환경에서 테스트하는 경우에도 안내 메일이 전송되므로,
            // 실제 거래처의 메일주소가 기재되지 않도록 주의
            cashbill.email = "";

            // 주문자 휴대폰
            // - {smssendYN} 의 값이 true 인 경우 아래 휴대폰번호로 안내 문자 전송
            cashbill.hp = "";

            // 주문자 팩스번호
            cashbill.fax = "";

            // 발행시 알림문자 전송여부
            cashbill.smssendYN = false;

            // 거래일시, 날짜(yyyyMMddHHmmss)
            // 당일, 전일만 가능, 미입력시 기본값 발행일시 처리
            cashbill.tradeDT = "20221108000000";

            try
            {
                CBIssueResponse response = Global.cashbillService.RegistIssue(testCorpNum, cashbill, memo, testUserID, emailSubject);

                code = response.code.ToString();
                message = response.message;
                confirmNum = response.confirmNum;
                tradeDate = response.tradeDate;
                tradeDT = response.tradeDT;
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
