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
using System.IO;

namespace Popbill.Taxinvoice.Example
{
    public partial class getPDF : System.Web.UI.Page
    {
        public String code = null;
        public String message = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 1건의 전자세금계산서를 PDF파일로 저장하기 위한 Byte Array를 반환합니다.
             * - https://docs.popbill.com/taxinvoice/dotnet/api#GetPDF
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 팝빌회원 아이디
            String testUserID = "testkorea";

            // 세금계산서 발행유형, SELL-매출, BUY-매입, TRUSTEE-위수탁
            MgtKeyType KeyType = MgtKeyType.SELL;

            // 세금계산서 문서번호
            String mgtKey = "20201027-001";

            // 저장파일 경로
            String path = @"C:\Users\wjkim\Desktop\Taxinvoice_20201027-001.pdf";

            try
            {
                byte[] btPDF = Global.taxinvoiceService.GetPDF(testCorpNum, KeyType, mgtKey, testUserID);

                using (FileStream fileStream = new FileStream(path, FileMode.Create))
                {
                    fileStream.Write(btPDF, 0, btPDF.Length);

                    fileStream.Close();
                }

                code = 1.ToString();
                message = path;

            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
