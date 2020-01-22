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

namespace Popbill.EasyFin.Bank.Example
{
    public partial class saveMemo : System.Web.UI.Page
    {
        public String code = null;
        public String message = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
            * 계좌 거래내역에 메모를 저장합니다.
            * - https://docs.popbill.com/easyfinbank/dotnet/api#SaveMemo
            */

            // 팝빌회원 사업자번호
            String testCorpNum = "1234567890";

            // 거래내역아이디, Search API 반환항목중 tid 확인
            String tid = "01912181100000000120191221000001";

            // 메모
            String memo = "20191230-asp 메모";

            try
            {
                Response response = Global.easyFinBankService.SaveMemo(testCorpNum, tid, memo);

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
