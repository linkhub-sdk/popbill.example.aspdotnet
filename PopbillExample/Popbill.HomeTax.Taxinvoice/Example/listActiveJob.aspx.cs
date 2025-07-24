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
             * [RequestJob – 수집 요청] API를 호출하고 반환 받은 작업아이디(JobID) 목록의 수집 상태를 확인합니다.
             * - https://developers.popbill.com/reference/httaxinvoice/dotnet/api/job#ListActiveJob
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
