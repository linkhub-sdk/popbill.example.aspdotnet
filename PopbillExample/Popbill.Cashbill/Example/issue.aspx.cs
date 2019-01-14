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
    public partial class issue : System.Web.UI.Page
    {
        public String code;
        public String message;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 1건의 [임시저장] 현금영수증을 [발행]합니다.
             * - 발행일 기준 오후 5시 이전에 발행된 현금영수증은 다음날 오후 2시에 국세청 전송결과를 확인할 수 있습니다.
             * - 현금영수증 국세청 전송 정책에 대한 정보는 "[현금영수증 API 연동매뉴얼] > 1.3. 국세청 전송정책"을 참조하시기 바랍니다.
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 팝빌회원 아이디
            String testUserID = "testkorea";

            // 현금영수증 문서관리번호
            String mgtKey = "20190114-001";

            // 메모
            String memo = "발행 메모";

            try
            {
                Response response = Global.cashbillService.Issue(testCorpNum, mgtKey, memo, testUserID);

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
