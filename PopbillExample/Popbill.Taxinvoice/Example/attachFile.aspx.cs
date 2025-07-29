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
    public partial class attachFile : System.Web.UI.Page
    {
        public String code;
        public String message;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * "임시저장" 상태의 세금계산서에 1개의 파일을 첨부합니다. (최대 5개)
             * - https://developers.popbill.com/reference/taxinvoice/dotnet/api/etc#AttachFile
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 문서번호 유형, SELL-매출, BUY-매입, TRUSTEE-위수탁
            MgtKeyType KeyType = MgtKeyType.SELL;

            // 세금계산서 문서번호
            String mgtKey = "20220525-001";

            // 파일명
            String displayName = "test.jpg";

            // 첨부파일 경로
            String filePath = "C:/popbill.example.aspdotnet/PopbillExample/test.jpg";

            // 팝빌회원 아이디
            String testUserID = "testkorea";

            try
            {
                Response response = Global.taxinvoiceService.AttachFile(testCorpNum, KeyType, mgtKey, displayName, filePath, testUserID);

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
