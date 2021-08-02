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

namespace Popbill.Cashbill.Example
{
    public partial class revokeRegister : System.Web.UI.Page
    {
        public String code;
        public String message;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
              * 1건의 취소현금영수증을 [임시저장]합니다.
              * - [임시저장] 상태의 현금영수증은 발행(Issue API)을 호출해야만 국세청에 전송됩니다.
              */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // [필수] 문서번호, 최대 24자리, 영문, 숫자 '-', '_'를 조합하여 사업자별로 중복되지 않도록 구성
            String mgtKey = "20210702-001";

            // 원본현금영수증 승인번호, 문서정보 확인(GetInfo API)로 확인가능
            String orgConfirmNum = "548757045";

            // 원본현금영수증 거래일자, 문서정보 확인(GetInfo API)로 확인가능
            String orgTradeDate = "20210701";

            try
            {
                Response response = Global.cashbillService.RevokeRegister(testCorpNum, mgtKey, orgConfirmNum, orgTradeDate);

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
