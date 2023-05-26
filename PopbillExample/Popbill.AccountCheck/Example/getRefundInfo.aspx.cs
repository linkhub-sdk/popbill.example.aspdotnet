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

namespace Popbill.AccountCheck.Example
{
    public partial class getRefundInfo : System.Web.UI.Page
    {
        public RefundHistory result;
        public String code;
        public String message;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 포인트 환불에 대한 상세정보 1건을 확인합니다.
             * - https://developers.popbill.com/reference/accountcheck/dotnet/api/point#GetRefundInfo
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String CorpNum = "1234567890";

            // 환불코드
            String RefundCode = "023040000017";

            // 팝빌회원 아이디
            String UserID = "testkorea";

            try
            {
                result = Global.accountCheckService.GetRefundInfo(CorpNum, RefundCode, UserID);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}