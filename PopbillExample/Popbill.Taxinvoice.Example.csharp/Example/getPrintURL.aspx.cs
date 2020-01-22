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
    public partial class getPrintURL : System.Web.UI.Page
    {
        public String code = null;
        public String message = null;
        public String url = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 1건의 전자세금계산서 인쇄팝업 URL을 반환합니다.
             * - 반환된 URL은 보안정책으로 인해 30초의 유효시간을 갖습니다.
             * - https://docs.popbill.com/taxinvoice/dotnet/api#GetPrintURL
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 팝빌회원 아이디
            String testUserID = "testkorea";

            // 세금계산서 발행유형, SELL-매출, BUY-매입, TRUSTEE-위수탁
            MgtKeyType KeyType = MgtKeyType.SELL;

            // 세금계산서 문서관리번호
            String mgtKey = "20190111-001";

            try
            {
                url = Global.taxinvoiceService.GetPrintURL(testCorpNum, KeyType, mgtKey, testUserID);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
