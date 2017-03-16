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

namespace Popbill.Statement.Example
{
    public partial class getLogs : System.Web.UI.Page
    {
        public String code;
        public String message;
        public List<StatementLog> logList;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
            * 전자명세서 상태 변경이력을 확인합니다.
            * - 상태 변경이력 확인(GetLogs API) 응답항목에 대한 자세한 정보는
            *   "[전자명세서 API 연동매뉴얼] > 3.3.4 GetLogs (상태 변경이력 확인)"
            *   을 참조하시기 바랍니다.
            */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 명세서 종류 코드 - 121(거래명세서), 122(청구서), 123(견적서) 124(발주서), 125(입금표), 126(영수증)
            int itemcode = 121;

            // 전자명세서 문서관리번호
            String mgtKey = "20170315-06";

            try
            {
                logList = Global.statementService.GetLogs(testCorpNum, itemcode, mgtKey);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
