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

namespace Popbill.Taxinvoice
{
    public partial class getLogs : System.Web.UI.Page
    {
        public String code = null;
        public String message = null;
        public List<TaxinvoiceLog> logList = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 세금계산서 상태 변경이력을 확인합니다.
             * - 상태 변경이력 확인(GetLogs API) 응답항목에 대한 자세한 정보는
             *   "[전자세금계산서 API 연동매뉴얼] > 3.5.5 상태 변경이력 확인" 을 참조하시기 바랍니다.
             */


            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 세금계산서 발행유형, SELL-매출, BUY-매입, TRUSTEE-위수탁
            MgtKeyType KeyType = MgtKeyType.SELL;

            // 세금계산서 문서관리번호
            String mgtKey = "20190111-001";

            try
            {
                logList = Global.taxinvoiceService.GetLogs(testCorpNum, KeyType, mgtKey);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
