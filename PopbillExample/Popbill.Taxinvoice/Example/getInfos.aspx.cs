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
        public String code;
        public String message;
        public List<TaxinvoiceInfo> taxinvoiceInfoList = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 다수건의 세금계산서 상태 및 요약 정보를 확인합니다. (1회 호출 시 최대 1,000건 확인 가능)
             * - https://developers.popbill.com/reference/taxinvoice/dotnet/api/info#GetInfos
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 문서번호 유형, SELL-매출, BUY-매입, TRUSTEE-위수탁
            MgtKeyType KeyType = MgtKeyType.SELL;

            List<string> MgtKeyList = new List<string>();

            //  조회할 세금계산서 문서번호 배열, (최대 1000건)
            MgtKeyList.Add("20220525-001");
            MgtKeyList.Add("20220525-002");

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
