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
    public partial class registDeptUser : System.Web.UI.Page
    {
        public String code;
        public String message;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 팝빌에 현금영수증 전용 부서사용자를 등록합니다.
             * - https://developers.popbill.com/reference/htcashbill/dotnet/api/cert#RegistDeptUser
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 부서사용자 아이디
            String deptUserID = "userid";

            // 부서사용자 비밀번호
            String deptUserPWD = "passwd";

            // 부서사용자 대표자 주민번호
            String identityNum = "";

            // 팝빌회원 아이디
            String userID = "testkorea";

            try
            {
                Response response = Global.htCashbillService.RegistDeptUser(testCorpNum, deptUserID, deptUserPWD, identityNum, userID);

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