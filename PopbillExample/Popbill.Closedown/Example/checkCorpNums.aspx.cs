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

namespace Popbill.Closedown.Example
{
    public partial class checkCorpNums : System.Web.UI.Page
    {
        public String code;
        public String message;
        public List<CorpState> corpStateList;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 다수건의 사업자번호에 대한 휴폐업정보를 확인합니다. (최대 1,000건)
             * - https://docs.popbill.com/closedown/dotnet/api#CheckCorpNums
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 조회할 사업자번호 배열, 최대 1000건
            List<String> CorpNumList = new List<string>();

            CorpNumList.Add("1312746743");
            CorpNumList.Add("1231212312");
            CorpNumList.Add("6798700433");

            try
            {
                corpStateList = Global.closedownService.checkCorpNums(testCorpNum, CorpNumList);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
