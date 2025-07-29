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

namespace Popbill.Fax.Example
{
    public partial class cancelReserve : System.Web.UI.Page
    {
        public String code;
        public String message;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 팝빌에서 반환받은 접수번호로 예약된 팩스를 전송 취소합니다. (예약일시 10분 전까지 가능)
             * - https://developers.popbill.com/reference/fax/dotnet/api/send#CancelReserve
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 팩스전송 요청시 발급받은 접수번호
            String receiptNum = "017032013534100001";
            
            // 팝빌회원 아이디
            String testUserID = "testkorea";

            try
            {
                Response response = Global.faxService.CancelReserve(testCorpNum, receiptNum, testUserID);
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