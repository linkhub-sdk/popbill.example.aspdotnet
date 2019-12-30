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

namespace Popbill.EasyFin.Bank.Example
{
    public partial class requestJob : System.Web.UI.Page
    {
        public String code;
        public String message;
        public String jobID;

        protected void Page_Load(object sender, EventArgs e)
        {
            /*
             * 계좌 거래내역 수집을 요청한다
             * - 검색기간은 현재일 기준 90일 이내로만 요청할 수 있다.
             */

            // 팝빌회원 사업자번호
            String testCorpNum = "1234567890";

            // 은행코드
            String BankCode = "0048";

            // 은행 계좌번호
            String AccountNumber = "131020538645";

            // 시작일자, 표시형식(yyyyMMdd)
            String SDate = "20191001";

            // 종료일자, 표시형식(yyyyMMdd)
            String EDate = "20191230";

            try
            {
                jobID = Global.easyFinBankService.RequestJob(testCorpNum, BankCode, AccountNumber, SDate, EDate);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
