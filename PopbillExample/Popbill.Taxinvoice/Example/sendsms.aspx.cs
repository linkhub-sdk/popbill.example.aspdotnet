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

namespace Popbill.Taxinvoice.Example
{
    public partial class sendsms : System.Web.UI.Page
    {
        public String code;
        public String message;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 세금계산서와 관련된 안내 SMS(단문) 문자를 재전송하는 함수로, 팝빌 사이트 [문자·팩스] > [문자] > [전송내역] 메뉴에서 전송결과를 확인 할 수 있습니다.
             * - 메시지는 최대 90byte까지 입력 가능하고, 초과한 내용은 자동으로 삭제되어 전송합니다. (한글 최대 45자)\
             * - 함수 호출시 포인트가 과금됩니다.
             * - https://developers.popbill.com/reference/taxinvoice/dotnet/api/etc#SendSMS
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";
            
            // 문서번호 유형, SELL-매출, BUY-매입, TRUSTEE-위수탁
            MgtKeyType KeyType = MgtKeyType.SELL;

            // 세금계산서 문서번호
            String mgtKey = "20220525-001";

            // 발신번호
            String senderNum = "";

            // 수신번호
            String receiverNum = "";

            // 문자메시지 내용, 90byte 초과시 길이가 조정되어 전송됨
            String contents = "알림문자 전송내용, 90byte 초과된 내용은 삭제되어 전송됨";

            // 팝빌회원 아이디
            String testUserID = "testkorea";

            try
            {
                Response response = Global.taxinvoiceService.SendSMS(testCorpNum, KeyType, mgtKey, senderNum, receiverNum, contents, testUserID);

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
