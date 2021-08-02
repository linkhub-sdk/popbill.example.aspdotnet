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

namespace Popbill.Cashbill.Example
{
    public partial class getPDF : System.Web.UI.Page
    {
        public String code = null;
        public String message = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 1건의 현금영수증를 PDF파일로 저장하기 위한 Byte Array를 반환합니다.
             * - https://docs.popbill.com/cashbill/dotnet/api#GetPDF
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 팝빌회원 아이디
            String testUserID = "testkorea";

            // 현금영수증 문서번호
            String mgtKey = "20210701-001 ";

            // 저장파일 경로
            String path = @"C:\Users\wjkim\Desktop\CashBill_20210701-001.pdf";

            try
            {
                byte[] btPDF = Global.cashbillService.GetPDF(testCorpNum, mgtKey, testUserID);

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
