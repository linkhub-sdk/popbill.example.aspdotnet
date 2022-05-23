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
    public partial class getDetailInfo : System.Web.UI.Page
    {
        public String code;
        public String message;
        public Cashbill cashbill;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 현금영수증 1건의 상세정보를 확인합니다.
             * - https://docs.popbill.com/cashbill/dotnet/api#GetDetailInfo
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 현금영수증 문서번호
            String mgtKey = "20220525-001";

            try
            {
                cashbill = Global.cashbillService.GetDetailInfo(testCorpNum, mgtKey);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
