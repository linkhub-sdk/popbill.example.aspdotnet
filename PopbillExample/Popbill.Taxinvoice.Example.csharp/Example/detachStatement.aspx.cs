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
    public partial class detachStatement : System.Web.UI.Page
    {
        public String code = null;
        public String message = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 세금계산서에 첨부된 전자명세서를 해제합니다.
             * - https://docs.popbill.com/taxinvoice/dotnet/api#DetachStatement
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 세금계산서 발행유형, SELL-매출, BUY-매입, TRUSTEE-위수탁
            MgtKeyType KeyType = MgtKeyType.SELL;

            // 세금계산서 문서번호
            String mgtKey = "20210701-05";

            // 첨부해제 할 명세서 종류 코드
            int DocItemCode = 121;

            // 첨부해제 할 명세서 문서번호
            String DocMgtKey = "20210701-S01";

            try
            {
                Response response = Global.taxinvoiceService.DetachStatement(testCorpNum, KeyType, mgtKey, DocItemCode, DocMgtKey);
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
