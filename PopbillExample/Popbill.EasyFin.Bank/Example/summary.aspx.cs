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
    public partial class summary : System.Web.UI.Page
    {
        public String code;
        public String message;
        public EasyFinBankSummary summaryInfo;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 금융기관에서 수집된 계좌 거래내역의 입금 및 출금 합계정보를 제공합니다.
             * - https://developers.popbill.com/reference/easyfinbank/dotnet/api/search#Summary
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 수집 요청(requestJob API)시 반환반은 작업아이디(jobID)
            String jobID = "019123013000000002";

            // 거래유형 배열, I-입금, O-출금
            String[] TradeType = { "I", "O" };

            // "입·출금액" / "메모" / "비고" 중 검색하고자 하는 값 입력
            // - 메모 = 거래내역 메모저장(SaveMemo)을 사용하여 저장한 값
            // - 비고 = EasyFinBankSearchDetail의 remark1, remark2, remark3 값
            // - 미입력시 전체조회
            String SearchString = "";

            try
            {
                summaryInfo = Global.easyFinBankService.Summary(testCorpNum, jobID,
                    TradeType, SearchString);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
