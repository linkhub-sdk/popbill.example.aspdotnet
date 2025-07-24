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

namespace Popbill.HomeTax.Cashbill.Example
{
    public partial class getFlatRateState : System.Web.UI.Page
    {
        public String code;
        public String message;
        public HTFlatRate flatRateInfo;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 홈택스수집 정액제 서비스 상태를 확인합니다.
             * - https://developers.popbill.com/reference/htcashbill/dotnet/common-api/point#GetFlatRateState
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            try
            {
                flatRateInfo = Global.htCashbillService.GetFlatRateState(testCorpNum);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
