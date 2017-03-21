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
    public partial class getTaxinvoice : System.Web.UI.Page
    {
        public String code;
        public String message;
        public HTTaxinvoice taxinvoiceInfo;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
            * 수집된 전자(세금)계산서 1건의 상세정보를 확인합니다.
            * - 응답항목에 관한 정보는 "[홈택스 전자(세금)계산서 연계 API 연동매뉴얼]
            *   > 4.1.2. GetTaxinvoice 응답전문 구성" 을 참고하시기 바랍니다.
            */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 조회할 전자세금계산서 국세청 승인번호
            String ntsConfirmNum = "20170317410002030000017f";

            // 팝빌회원 아이디
            String testUserID = "testkorea";

            try
            {
                taxinvoiceInfo = Global.htTaxinvoiceService.GetTaxinvoice(testCorpNum, ntsConfirmNum, testUserID);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
