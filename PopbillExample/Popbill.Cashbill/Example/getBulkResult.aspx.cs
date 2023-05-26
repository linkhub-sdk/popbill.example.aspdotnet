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
    public partial class getBulkResult : System.Web.UI.Page
    {
        public String code;
        public String message;
        public BulkCashbillResult result = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 접수시 기재한 SubmitID를 사용하여 현금영수증 접수결과를 확인합니다.
             * - 개별 현금영수증 처리상태는 접수상태(txState)가 완료(2) 시 반환됩니다.
             * - https://developers.popbill.com/reference/cashbill/dotnet/api/issue#GetBulkResult
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 초대량 발행 접수시 기재한 제출아이디
            String submitID = "20221108-BULK";

            try
            {
                result = Global.cashbillService.GetBulkResult(testCorpNum, submitID);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
