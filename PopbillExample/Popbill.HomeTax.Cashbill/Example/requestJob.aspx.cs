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

namespace Popbill.HomeTax.Cashbill.Example
{
    public partial class requestJob : System.Web.UI.Page
    {
        public String code;
        public String message;
        public String jobID;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 홈택스에 신고된 현금영수증 매입/매출 내역 수집을 팝빌에 요청합니다.
             * - 수집 요청후 반환받은 작업아이디(JobID)의 유효시간은 1시간 입니다.
             * - https://docs.popbill.com/htcashbill/dotnet/api#RequestJob
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 현금영수증 유형 SELL-매출, BUY-매입
            KeyType tiKeyType = KeyType.BUY;

            // 시작일자, 표시형식(yyyyMMdd)
            String SDate = "20210701";

            // 종료일자, 표시형식(yyyyMMdd)
            String EDate = "20210730";

            try
            {
                jobID = Global.htCashbillService.RequestJob(testCorpNum, tiKeyType, SDate, EDate);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
