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
    public partial class getInfos : System.Web.UI.Page
    {
        public String code;
        public String message;
        public List<CashbillInfo> cashbillInfoList;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 대량의 현금영수증 상태/요약 정보를 확인합니다. (최대 1000건)
             * - https://docs.popbill.com/cashbill/dotnet/api#GetInfos
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            List<string> MgtKeyList = new List<string>();

            // 현금영수증 문서관리번호 배열, 최대 1000건.
            MgtKeyList.Add("20190114-001");
            MgtKeyList.Add("20190114-002");

            try
            {
                cashbillInfoList = Global.cashbillService.GetInfos(testCorpNum, MgtKeyList);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
