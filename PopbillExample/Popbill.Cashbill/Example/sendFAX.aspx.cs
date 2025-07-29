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
             * 현금영수증을 팩스로 전송하는 함수로, 팝빌 사이트 [ 팩스 > 결과 > 전송결과 ] 메뉴에서 전송결과를 확인할 수 있습니다.
             * - https://developers.popbill.com/reference/cashbill/dotnet/api/etc#SendFAX
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 현금영수증 문서번호
            String mgtKey = "20220525-001";

            // 발신번호
            String sendNum = "";

            // 수신팩스번호
            String receiverNum = "";

            // 팝빌회원 아이디
            String testUserID = "testkorea";

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
