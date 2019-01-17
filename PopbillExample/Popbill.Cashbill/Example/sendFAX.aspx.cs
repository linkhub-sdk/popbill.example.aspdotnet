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
    public partial class sendFAX : System.Web.UI.Page
    {
        public String code;
        public String message;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 현금영수증을 팩스전송합니다.
             * - 팩스 전송 요청시 포인트가 차감됩니다. (전송실패시 환불처리)
             * - 전송내역 확인은 "팝빌 로그인" > [문자 팩스] > [팩스] > [전송내역] 메뉴에서 전송결과를 확인할 수 있습니다.
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 팝빌회원 아이디
            String testUserID = "testkorea";

            // 현금영수증 문서관리번호
            String mgtKey = "20190114-001";

            // 발신번호
            String sendNum = "070-4304-2991";

            // 수신팩스번호
            String receiverNum = "070-111-222";

            try
            {
                Response response = Global.cashbillService.SendFAX(testCorpNum, mgtKey, sendNum, receiverNum, testUserID);
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
