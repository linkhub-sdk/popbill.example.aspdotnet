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

namespace Popbill.Taxinvoice.Example
{
    public partial class checkMgtKeyInUse : System.Web.UI.Page
    {
        public String code = null;
        public String message = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
            * 세금계산서 문서관리번호 중복여부를 확인합니다.
            * - 관리번호는 1~24자리로 숫자, 영문 '-', '_' 조합으로 사업자별로 중복되지 않도록 구성해야 합니다.
            */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 조회할 세금계산서 문서관리번호
            // 1~24자리 숫자, 영문, '-', '_' 조합으로 사업자별로 중복되지 않도록 구성
            String mgtKey = "20170307-01";

            // 세금계산서 발행유형, SELL-매출, BUY-매입, TRUSTEE-위수탁
            MgtKeyType KeyType = MgtKeyType.SELL;

            try
            {
                bool InUse = Global.taxinvoiceService.CheckMgtKeyInUse(testCorpNum, KeyType, mgtKey);

                message = InUse ? "사용중" : "미사용중";
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
