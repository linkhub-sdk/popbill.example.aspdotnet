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
    public partial class attachStatement : System.Web.UI.Page
    {
        public String code = null;
        public String message = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 1건의 전자명세서를 세금계산서에 첨부합니다.
             */
            
            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 세금계산서 발행유형, SELL-매출, BUY-매입, TRUSTEE-위수탁
            MgtKeyType KeyType = MgtKeyType.SELL;

            // 세금계산서 문서관리번호
            String mgtKey = "20190111-001";

            // 첨부할 명세서 코드 - 121(거래명세서), 122(청구서), 123(견적서), 124(발주서), 125(입금표), 126(영수증)
            int DocItemCode = 121;

            // 첨부할 명세서 관리번호
            String DocMgtKey = "20190111-001";

            try
            {
                Response response = Global.taxinvoiceService.AttachStatement(testCorpNum, KeyType, mgtKey, DocItemCode, DocMgtKey);

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
