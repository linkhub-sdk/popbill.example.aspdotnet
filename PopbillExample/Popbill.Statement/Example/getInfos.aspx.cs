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
    public partial class getInfos : System.Web.UI.Page
    {
        public String code;
        public String message;
        public List<StatementInfo> statementInfoList;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 다수건의 전자명세서 상태 및 요약정보를 확인합니다. (1회 호출에 최대 1,000건 확인 가능)
             * - https://developers.popbill.com/reference/statement/dotnet/api/info#GetInfos
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 명세서 종류 코드 - 121(거래명세서), 122(청구서), 123(견적서), 124(발주서), 125(입금표), 126(영수증)
            int itemCode = 121;

            List<string> MgtKeyList = new List<string>();

            //문서번호 배열, 최대 1000건
            MgtKeyList.Add("20220525-001");
            MgtKeyList.Add("20220525-002");

            try
            {
                statementInfoList = Global.statementService.GetInfos(testCorpNum, itemCode, MgtKeyList);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
