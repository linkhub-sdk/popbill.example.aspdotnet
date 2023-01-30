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

namespace Popbill.Taxinvoice
{
    public partial class updateCorpInfo : System.Web.UI.Page
    {
        public String code = null;
        public String message = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 연동회원의 회사정보를 수정합니다.
             * - https://developers.popbill.com/reference/taxinvoice/dotnet/api/member#UpdateCorpInfo
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 팝빌회원 아이디
            String testUserID = "testkorea";

            CorpInfo corpInfo = new CorpInfo();

            // 대표자성명(최대 100자)
            corpInfo.ceoname = "대표자명 테스트";

            // 상호(최대 200자)
            corpInfo.corpName = "업체명";

            // 주소(최대 100자)
            corpInfo.addr = "주소정보 수정";

            // 업태(최대 100자)
            corpInfo.bizType = "업태정보 수정";

            // 종목(최대 100자)
            corpInfo.bizClass = "종목 수정";

            try
            {
                Response response = Global.taxinvoiceService.UpdateCorpInfo(testCorpNum, corpInfo, testUserID);
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
