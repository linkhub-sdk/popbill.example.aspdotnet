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

namespace Popbill.Taxinvoice
{
    public partial class send : System.Web.UI.Page
    {
        public String code = null;
        public String message = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
            * 1건의 [임시저장] 상태의 세금계산서를 [발행예정] 처리합니다.
            * - 발행예정이란 공급자와 공급받는자 사이에 세금계산서 확인 후 발행하는
            *   방법입니다.
            * - "[전자세금계산서 API 연동매뉴얼] > 1.3.1. 정발행 프로세스 흐름도
            *   > 다. 임시저장 발행예정" 의 프로세스를 참조하시기 바랍니다.
            */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 팝빌회원 아이디
            String testUserID = "testkorea";

            // 세금계산서 발행유형, SELL-매출, BUY-매입, TRUSTEE-위수탁
            MgtKeyType KeyType = MgtKeyType.SELL;

            // 세금계산서 문서관리번호
            String mgtKey = "20170314-05";

            // 메모
            String Memo = "발행예정 메모";

            // 발행예정 메일제목, 공백으로 처리시 기본메일 제목으로 전송
            String EmailSubject = "";

            try
            {
                Response response = Global. taxinvoiceService.Send(testCorpNum, KeyType, mgtKey, Memo, EmailSubject, testUserID);

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
