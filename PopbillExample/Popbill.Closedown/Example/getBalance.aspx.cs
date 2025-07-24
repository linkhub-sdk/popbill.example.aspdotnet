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

namespace Popbill.Closedown.Example
{
    public partial class getBalance : System.Web.UI.Page
    {
        public String code;
        public String message;
        public String remainPoint = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 연동회원의 잔여포인트를 확인합니다.
             * - 과금방식이 파트너과금인 경우 파트너 잔여포인트 확인(GetPartnerBalance API) 함수를 통해 확인하시기 바랍니다.
             * - https://developers.popbill.com/reference/closedown/dotnet/common-api/point#GetBalance
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            try
            {
                double response = Global.closedownService.GetBalance(testCorpNum);

                remainPoint = response.ToString();
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
