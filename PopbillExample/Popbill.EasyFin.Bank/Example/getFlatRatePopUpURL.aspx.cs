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

namespace Popbill.EasyFin.Bank.Example
{
    public partial class getFlatRatePopUpURL : System.Web.UI.Page
    {
        public String code;
        public String message;
        public String url;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
            * 계좌조회 정액제 서비스 신청 페이지의 팝업 URL을 반환합니다.
            * - 반환되는 URL은 보안정책상 30초의 유효시간을 갖으며, 이 시간 초과후에는 URL을 사용해도 정상적인 페이지에 접근할 수 없습니다.
            * - https://developers.popbill.com/reference/easyfinbank/dotnet/api/point#GetFlatRatePopUpURL
            */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 팝빌회원 아이디
            String testUserID = "testkorea";

            try
            {
                url = Global.easyFinBankService.GetFlatRatePopUpURL(testCorpNum, testUserID);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
