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
    public partial class getMailURL : System.Web.UI.Page
    {
        public String code = null;
        public String message = null;
        public String url = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 안내메일과 관련된 전자세금계산서를 확인 할 수 있는 상세 페이지의 팝업 URL을 반환하며, 해당 URL은 메일 하단의 "전자세금계산서 보기" 버튼의 링크와 같습니다.
             * - 함수 호출로 반환 받은 URL에는 유효시간이 없습니다.
             * - https://docs.popbill.com/taxinvoice/dotnet/api#GetMailURL
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 팝빌회원 아이디
            String testUserID = "testkorea";

            // 세금계산서 발행유형, SELL-매출, BUY-매입, TRUSTEE-위수탁
            MgtKeyType KeyType = MgtKeyType.SELL;

            // 세금계산서 문서번호
            String mgtKey = "20220525-001";

            try
            {
                url = Global.taxinvoiceService.GetMailURL(testCorpNum, KeyType, mgtKey, testUserID);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
