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
    public partial class cancelIssue : System.Web.UI.Page
    {
        public String code;
        public String message;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * [발행완료] 상태의 현금영수증을 [발행취소]합니다.
             * - 발행취소는 국세청 전송전에만 가능합니다.
             * - 발행취소된 형금영수증은 국세청에 전송되지 않습니다.
             * - https://docs.popbill.com/cashbill/dotnet/api#CancelIssue
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 팝빌회원 아이디
            String testUserID = "testkorea";

            // 현금영수증 문서관리번호
            String mgtKey = "20190114-001";

            // 메모
            String memo = "발행취소 메모";

            try
            {
                Response response = Global.cashbillService.CancelIssue(testCorpNum, mgtKey, memo, testUserID);

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
