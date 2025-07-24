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
             * 현금영수증 다건의 인쇄 팝업 URL을 반환합니다.
             * - https://developers.popbill.com/reference/cashbill/dotnet/api/view#GetMassPrintURL
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 팝빌회원 아이디
            String testUserID = "testkorea";

            List<string> MgtKeyList = new List<string>();

            // 현금영수증 문서번호 배열, 최대 100건.
            MgtKeyList.Add("20220525-001");
            MgtKeyList.Add("20220525-002");

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
