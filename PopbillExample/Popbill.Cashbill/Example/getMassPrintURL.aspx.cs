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
             * 다수건의 현금영수증을 인쇄하기 위한 페이지의 팝업 URL을 반환합니다. (최대 100건)
             * 반환되는 URL은 보안 정책상 30초 동안 유효하며, 시간을 초과한 후에는 해당 URL을 통한 페이지 접근이 불가합니다.
             * - https://docs.popbill.com/cashbill/dotnet/api#GetMassPrintURL
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 팝빌회원 아이디
            String testUserID = "testkorea";

            List<string> MgtKeyList = new List<string>();

            // 현금영수증 문서번호 배열, 최대 100건.
            MgtKeyList.Add("20210701-001");
            MgtKeyList.Add("20210701-002");
            MgtKeyList.Add("20210701-003");
            MgtKeyList.Add("20210701-004");
            MgtKeyList.Add("20210701-005");
            MgtKeyList.Add("20210701-006");

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
