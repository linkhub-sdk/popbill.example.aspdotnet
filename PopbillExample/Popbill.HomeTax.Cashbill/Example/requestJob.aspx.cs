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

namespace Popbill.HomeTax.cashbill.Example
{
    public partial class requestJob : System.Web.UI.Page
    {
        public String code;
        public String message;
        public String jobID;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 홈택스에 신고된 현금영수증 매입/매출 내역 수집을 팝빌에 요청합니다. (조회기간 단위 : 최대 3개월)
             * - https://developers.popbill.com/reference/htcashbill/dotnet/api/job#RequestJob
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 현금영수증 유형 SELL-매출, BUY-매입
            KeyType tiKeyType = KeyType.BUY;

            // 시작일자, 표시형식(yyyyMMdd)
            String SDate = "20220501";

            // 종료일자, 표시형식(yyyyMMdd)
            String EDate = "20220525";

            try
            {
                jobID = Global.htcashbillService.RequestJob(testCorpNum, tiKeyType, SDate, EDate);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
