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
    public partial class getPaymentHistory : System.Web.UI.Page
    {
        public PaymentHistoryResult result;
        public String code;
        public String message;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 연동회원의 포인트 결제내역을 확인합니다.
             * - https://developers.popbill.com/reference/httaxinvoice/dotnet/common-api/point#GetPaymentHistory
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String CorpNum = "1234567890";

            // 조회 기간의 시작일자 (형식 : yyyyMMdd)
            String SDate = "20230501";

            // 조회 기간의 종료일자 (형식 : yyyyMMdd)
            String EDate = "20230530";

            // 목록 페이지번호 (기본값 1)
            int Page = 1;

            // 페이지당 표시할 목록 개수 (기본값 500, 최대 1,000)
            int PerPage = 500;

            // 팝빌회원 아이디
            String UserID = "testkorea";

            try
            {
                result = Global.htTaxinvoiceService.GetPaymentHistory(CorpNum, SDate, EDate, Page, PerPage, UserID);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}