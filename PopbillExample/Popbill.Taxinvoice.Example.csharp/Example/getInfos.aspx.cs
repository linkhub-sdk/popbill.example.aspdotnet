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

namespace Popbill.Taxinvoice.Example
{
    public partial class getInfos : System.Web.UI.Page
    {
        public String code = null;
        public String message = null;
        public List<TaxinvoiceInfo> taxinvoiceInfoList = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
            * 대량의 세금계산서 상태/요약 정보를 확인합니다. (최대 1000건)
            * - 세금계산서 상태정보(GetInfos API) 응답항목에 대한 자세한 정보는 "[전자세금계산서 API 연동매뉴얼]
            * > 4.2. (세금)계산서 상태정보 구성" 을 참조하시기 바랍니다.
            */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 세금계산서 발행유형, SELL-매출, BUY-매입, TRUSTEE-위수탁
            MgtKeyType KeyType = MgtKeyType.SELL;

            List<string> MgtKeyList = new List<string>();

            //  조회할 세금계산서 문서관리번호 배열, (최대 1000건)
            MgtKeyList.Add("20170314-01");
            MgtKeyList.Add("20170314-02");
            MgtKeyList.Add("20170314-03");

            try
            {
                taxinvoiceInfoList = Global.taxinvoiceService.GetInfos(testCorpNum, KeyType, MgtKeyList);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
