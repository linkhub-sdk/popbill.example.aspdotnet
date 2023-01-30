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

namespace Popbill.EasyFin.Bank.Example
{
    public partial class listActiveJob : System.Web.UI.Page
    {
        public String code;
        public String message;
        public List<EasyFinBankJobState> jobStateList;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 수집 요청(RequestJob API) 함수를 통해 반환 받은 작업아이디의 목록을 확인합니다.
             * - 수집 요청 후 1시간이 경과한 수집 요청건은 상태정보가 반환되지 않습니다.
             * - https://developers.popbill.com/reference/easyfinbank/dotnet/api/job#ListActiveJob
             */


            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            try
            {
                jobStateList = Global.easyFinBankService.ListACtiveJob(testCorpNum);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
