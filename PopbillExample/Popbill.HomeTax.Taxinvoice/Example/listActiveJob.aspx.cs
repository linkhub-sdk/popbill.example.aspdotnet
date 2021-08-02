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
             * 전자세금계산서 매입/매출 내역 수집요청에 대한 상태 목록을 확인합니다.
             * - 수집 요청 후 1시간이 경과한 수집 요청건은 상태정보가 반환되지 않습니다.
             * - https://docs.popbill.com/httaxinvoice/dotnet/api#ListActiveJob
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
