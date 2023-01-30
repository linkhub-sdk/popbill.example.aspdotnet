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
             * 다수건의 현금영수증 상태 및 요약 정보를 확인합니다. (1회 호출 시 최대 1,000건 확인 가능)
             * - 리턴값 'CashbillInfo'의 변수 'stateCode'를 통해 현금영수증의 상태코드를 확인합니다.
             * - https://developers.popbill.com/reference/cashbill/dotnet/api/info#GetInfos
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            List<string> MgtKeyList = new List<string>();

            // 현금영수증 문서번호 배열, 최대 1000건.
            MgtKeyList.Add("20220525-001");
            MgtKeyList.Add("20220525-002");

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
