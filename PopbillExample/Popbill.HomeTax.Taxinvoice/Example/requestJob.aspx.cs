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

namespace Popbill.HomeTax.Taxinvoice.Example
{
    public partial class requestJob : System.Web.UI.Page
    {
        public String code;
        public String message;
        public String jobID;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 홈택스에 신고된 전자세금계산서 매입/매출 내역 수집을 팝빌에 요청합니다. (조회기간 단위 : 최대 3개월)
             * - 주기적으로 자체 DB에 세금계산서 정보를 INSERT 하는 경우, 조회할 일자 유형(DType) 값을 "S"로 하는 것을 권장합니다.
             * - https://docs.popbill.com/httaxinvoice/dotnet/api#RequestJob
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 전자(세금)계산서 유형 SELL-매출, BUY-매입, TRUSTEE-수탁
            KeyType tiKeyType = KeyType.SELL;

            // 일자유형, W-작성일자, I-발행일자, S-전송일자
            String DType = "S";

            // 시작일자, 표시형식(yyyyMMdd)
            String SDate = "20220501";

            // 종료일자, 표시형식(yyyyMMdd)
            String EDate = "20220525";

            // 팝빌회원 아이디
            String userID = "testkorea";

            try
            {
                jobID = Global.htTaxinvoiceService.RequestJob(testCorpNum, tiKeyType, DType, SDate, EDate, userID);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
