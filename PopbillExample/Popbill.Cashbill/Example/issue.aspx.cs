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
    public partial class issue : System.Web.UI.Page
    {
        public String code;
        public String message;
        public String confirmNum;
        public String tradeDate;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 1건의 [임시저장] 현금영수증을 [발행]합니다.
             * - 현금영수증 국세청 전송 정책 : https://docs.popbill.com/cashbill/ntsSendPolicy?lang=dotnet
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 팝빌회원 아이디
            String testUserID = "testkorea";

            // 현금영수증 문서번호
            String mgtKey = "20220525-001";

            // 메모
            String memo = "발행 메모";

            try
            {
                CBIssueResponse response = Global.cashbillService.Issue(testCorpNum, mgtKey, memo, testUserID);

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
