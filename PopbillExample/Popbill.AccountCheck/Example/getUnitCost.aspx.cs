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
    public partial class getUnitCost : System.Web.UI.Page
    {
        public String code;
        public String message;
        public float unitCost;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 예금주 조회시 과금되는 포인트 단가를 확인합니다.
             * - https://docs.popbill.com/accountcheck/dotnet/api#GetUnitCost
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 서비스 유형, 성명 / 실명 중 택 1
            String serivceType = "성명";

            // 팝빌회원 아이디
            String userID = "testkorea";

            try
            {
                unitCost = Global.accountCheckService.GetUnitCost(testCorpNum, serivceType, userID);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
