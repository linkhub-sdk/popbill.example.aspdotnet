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
    public partial class getInfo : System.Web.UI.Page
    {
        public String code;
        public String message;
        public CashbillInfo cashbillInfo;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
            * 1건의 현금영수증 상태/요약 정보를 확인합니다.
            * - 응답항목에 대한 자세한 정보는 "[현금영수증 API 연동매뉴얼] > 4.2.
            *   현금영수증 상태정보 구성"을 참조하시기 바랍니다.
            */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 현금영수증 문서관리번호
            String mgtKey = "20170316-02";

            try
            {
                cashbillInfo = Global.cashbillService.GetInfo(testCorpNum, mgtKey);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
