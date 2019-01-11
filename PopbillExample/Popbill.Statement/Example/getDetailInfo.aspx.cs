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

namespace Popbill.Statement.Example
{
    public partial class getDetailInfo : System.Web.UI.Page
    {
        public String code;
        public String message;
        public Statement statement;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 전자명세서 1건의 상세정보를 조회합니다.
             * - 응답항목에 대한 자세한 사항은 "[전자명세서 API 연동매뉴얼] > 4.1.
             *   전자명세서 구성" 을 참조하시기 바랍니다.
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 명세서 종류 코드 - 121(거래명세서), 122(청구서), 123(견적서), 124(발주서), 125(입금표), 126(영수증)
            int itemCode = 121;

            // 전자명세서 문서관리번호
            String mgtKey = "20190111-001";

            try
            {
                statement = Global.statementService.GetDetailInfo(testCorpNum, itemCode, mgtKey);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}