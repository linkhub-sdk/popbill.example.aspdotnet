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

namespace Popbill.HomeTax.Taxinvoice.Example
{
    public partial class getPopUpURL : System.Web.UI.Page
    {
        public String code = null;
        public String message = null;
        public String url = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
            * 세금계산서 1건의 팝업 보기 URL을 반환합니다.. 
            * - 반환된 URL은 보안정책에 따라 30초의 유효시간을 갖습니다.
            */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 조회할 전자세금계산서 국세청승인번호
            String NTSConfirmNum = "201610314100020300002777";

            try
            {
                url = Global.htTaxinvoiceService.GetPopUpURL(testCorpNum, NTSConfirmNum);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
