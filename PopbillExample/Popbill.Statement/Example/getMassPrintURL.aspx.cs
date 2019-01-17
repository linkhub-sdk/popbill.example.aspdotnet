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

namespace Popbill.Statement
{
    public partial class getMassPrintURL : System.Web.UI.Page
    {
        public String code;
        public String message;
        public String url;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 다수건의 전자명세서 인쇄팝업 URL을 반환합니다. (최대 100건)
             * - 보안정책으로 인해 반환된 URL의 유효시간은 30초입니다.
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 팝빌회원 아이디
            String testUserID = "testkorea";

            // 명세서 종류 코드 - 121(거래명세서), 122(청구서), 123(견적서), 124(발주서), 125(입금표), 126(영수증)
            int itemCode = 121;

            List<string> mgtKeyList = new List<string>();

            // 문서관리번호 배열, 최대 100건
            mgtKeyList.Add("20190111-001");
            mgtKeyList.Add("20190111-002");
            mgtKeyList.Add("20190111-003");
            mgtKeyList.Add("20190111-004");
            mgtKeyList.Add("20190111-005");

            try
            {
                url = Global.statementService.GetMassPrintURL(testCorpNum, itemCode, mgtKeyList, testUserID);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;                
            }
        }
    }
}
