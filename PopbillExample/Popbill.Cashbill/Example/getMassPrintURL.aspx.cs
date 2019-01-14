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

namespace Popbill.Cashbill.Example
{
    public partial class getMassPrintURL : System.Web.UI.Page
    {
        public String code;
        public String message;
        public String url;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 대량의 현금영수증 인쇄팝업 URL을 반환합니다. (최대 100건)
             * 보안정책으로 인해 반환된 URL의 유효시간은 30초입니다.
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 팝빌회원 아이디
            String testUserID = "testkorea";

            List<string> MgtKeyList = new List<string>();

            // 현금영수증 문서관리번호 배열, 최대 100건.
            MgtKeyList.Add("20190114-001");
            MgtKeyList.Add("20190114-002");
            MgtKeyList.Add("20190114-003");
            MgtKeyList.Add("20190114-004");
            MgtKeyList.Add("20190114-005");
            MgtKeyList.Add("20190114-006");

            try
            {
                url = Global.cashbillService.GetMassPrintURL(testCorpNum, MgtKeyList, testUserID);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
