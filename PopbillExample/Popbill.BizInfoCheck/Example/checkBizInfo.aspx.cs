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

namespace Popbill.BizInfoCheck.Example
{
    public partial class checkCorpNum : System.Web.UI.Page
    {
        public String code;
        public String message;
        public BizCheckInfo result;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 사업자번호 1건에 대한 기업정보정보를 확인합니다.
             * - https://developers.popbill.com/reference/bizinfocheck/dotnet/api/check#CheckBizInfo
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 조회할 사업자 등록번호
            String targetCorpNum = "6798700433";

            try
            {
                result = Global.bizInfoCheckService.checkBizInfo(testCorpNum, targetCorpNum);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
