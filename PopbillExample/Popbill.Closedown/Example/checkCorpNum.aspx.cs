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
    public partial class checkCorpNum : System.Web.UI.Page
    {
        public String code;
        public String message;
        public CorpState result;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 사업자번호 1건에 대한 휴폐업정보를 확인합니다.
             * - https://docs.popbill.com/closedown/dotnet/api#CheckCorpNum
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 조회할 사업자 등록번호
            String targetCorpNum = "6798700433";

            // 팝빌회원 아이디
            String userID = "testkorea";

            try
            {
                result = Global.closedownService.checkCorpNum(testCorpNum, targetCorpNum, userID);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
