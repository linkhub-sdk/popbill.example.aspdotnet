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

namespace Popbill.AccountCheck.Example
{
    public partial class getChargeInfo : System.Web.UI.Page
    {
        public String code;
        public String message;
        public ChargeInfo chrgInfo = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 예금주조회 API 서비스 과금정보를 확인합니다.
             * - https://developers.popbill.com/reference/accountcheck/dotnet/api/point#GetChargeInfo
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 서비스 유형(성명/실명)
            String serivceType = "성명";

            // 팝빌회원 아이디
            String userID = "testkorea";

            try
            {
                chrgInfo = Global.accountCheckService.GetChargeInfo(testCorpNum, userID, serivceType);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
