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

namespace Popbill.Fax.Example
{
    public partial class getFaxResultRN : System.Web.UI.Page
    {
        public String code;
        public String message;
        public List<FaxResult> result;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 팩스전송요청시 할당한 전송요청번호(requestNum)으로 전송결과를 확인합니다
             * - 응답항목에 대한 자세한 사항은 "[팩스 API 연동매뉴얼] >  3.3.2 GetFaxDetailRN (전송내역 및 전송상태 확인 - 요청번호 할당)을 참조하시기 바랍니다.
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 팩스 전송시 기재한 요청번호
            String requestNum = "20190114-001";

            try
            {
                result = Global.faxService.GetFaxResultRN(testCorpNum, requestNum);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}