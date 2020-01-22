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

namespace Popbill.Cashbill.Example
{
    public partial class checkMgtKeyInUse : System.Web.UI.Page
    {
        public String code;
        public String message;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
            * 현금영수증 관리번호 중복여부를 확인합니다.
            * - 관리번호는 1~24자리로 숫자, 영문 '-', '_' 조합으로 사업자별로 중복되지 않도록 구성해야합니다.
            * - https://docs.popbill.com/cashbill/dotnet/api#CheckMgtKeyInUse
            */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 현금영수증 문서관리번호
            String mgtKey = "20190114-001";

            try
            {
                bool InUse = Global.cashbillService.CheckMgtKeyInUse(testCorpNum, mgtKey);

                message = InUse ? "사용중" : "미사용중";
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;                
            }
        }
    }
}
