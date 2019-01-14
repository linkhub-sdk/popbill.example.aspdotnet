using System;
using System.Collections;
using System.Collections.Generic;
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
    public partial class listActiveJob : System.Web.UI.Page
    {
        public String code;
        public String message;
        public List<HTTaxinvoiceJobState> jobStateList;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 수집 요청건들에 대한 상태 목록을 확인합니다.
             * - 수집 요청 작업아이디(JobID)의 유효시간은 1시간 입니다.
             * - 응답항목에 관한 정보는 "[홈택스 전자(세금)계산서 연계 API 연동매뉴얼]
             *   > 3.2.3. ListActiveJob (수집 상태 목록 확인)" 을 참고하시기 바랍니다.
             */


            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            try
            {
                jobStateList = Global.htTaxinvoiceService.ListActiveJob(testCorpNum);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
