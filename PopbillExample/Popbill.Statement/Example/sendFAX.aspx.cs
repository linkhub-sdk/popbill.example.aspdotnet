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

namespace Popbill.Statement
{
    public partial class sendFAX : System.Web.UI.Page
    {
        public String code;
        public String message;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 전자명세서를 팩스로 전송하는 함수로, 팝빌 사이트 [문자·팩스] > [팩스] > [전송내역] 메뉴에서 전송결과를 확인 할 수 있습니다.
             * - 팩스 전송 요청시 포인트가 차감됩니다. (전송실패시 환불처리)
             * - https://docs.popbill.com/statement/dotnet/api#SendFAX
             */


            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 팝빌회원 아이디
            String testUserID = "testkorea";

            // 명세서 종류 코드 - 121(거래명세서), 122(청구서), 123(견적서), 124(발주서), 125(입금표), 126(영수증)
            int itemcode = 121;

            // 전자명세서 문서번호
            String mgtKey = "20220525-001";

            // 발신번호
            String senderNum = "";

            // 수신번호
            String receiverNum = "";

            try
            {
                Response response = Global.statementService.SendFAX(testCorpNum, itemcode, mgtKey, senderNum, receiverNum, testUserID);

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
