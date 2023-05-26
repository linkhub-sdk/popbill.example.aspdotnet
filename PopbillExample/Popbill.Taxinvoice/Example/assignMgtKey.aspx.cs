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
    public partial class assignMgtKey : System.Web.UI.Page
    {
        public String code;
        public String message;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 팝빌 사이트를 통해 발행하여 문서번호가 부여되지 않은 세금계산서에 문서번호를 할당합니다.
             * - https://developers.popbill.com/reference/taxinvoice/dotnet/api/etc#AssignMgtKey
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";
            // 세금계산서 유형 SELL-매출, BUY-매입, TRUSTEE-위수탁
            MgtKeyType KeyType = MgtKeyType.SELL;

            // 세금계산서 팝빌번호, 목록조회(Search) API의 반환항목중 ItemKey 참조
            String itemKey = "021041823580800001";

            // 할당할 문서관호, 최대 24자리, 영문, 숫자 '-', '_'를 조합하여 사업자별로 중복되지 않도록 구성
            String mgtKey = "20220525-001";

            try
            {
                Response response = Global.taxinvoiceService.AssignMgtKey(testCorpNum, KeyType, itemKey, mgtKey);

                code = response.code.ToString();
                message = response.message;
            }
            catch(PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }

        }
    }
}
