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

namespace Popbill.Taxinvoice.Example
{
    public partial class getTaxCertURL : System.Web.UI.Page
    {
        public String code = null;
        public String message = null;
        public String url  = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 팝빌 회원의 공인인증서를 등록하는 팝업 URL을 반환합니다.
             * 반환된 URL의 유지시간은 30초이며, 제한된 시간 이후에는 정상적으로 처리되지 않습니다.
             * -팝빌에 등록된 공인인증서가 유효하지 않은 경우 (비밀번호 변경, 인증서 재발급/갱신, 만료일 경과)
             *  인증서를 재등록해야 정상적으로 전자세금계산서 발행이 가능합니다.
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 팝빌회원 아이디
            String testUserID = "testkorea";

            try
            {
                url = Global.taxinvoiceService.GetTaxCertURL(testCorpNum, testUserID);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
