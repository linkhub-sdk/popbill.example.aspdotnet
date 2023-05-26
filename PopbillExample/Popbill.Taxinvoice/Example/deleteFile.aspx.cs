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
    public partial class deleteFile : System.Web.UI.Page
    {
        public String code;
        public String message;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * "임시저장" 상태의 세금계산서에 첨부된 1개의 파일을 삭제합니다.
             * - 파일을 식별하는 파일아이디는 첨부파일 목록(GetFiles API) 를 호출하여 확인합니다.
             * - https://developers.popbill.com/reference/taxinvoice/dotnet/api/etc#DeleteFile
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 팝빌회원 아이디
            String testUserID = "testkorea";

            // 세금계산서 발행유형, SELL-매출, BUY-매입, TRUSTEE-위수탁
            MgtKeyType KeyType = MgtKeyType.SELL;

            // 세금계산서 문서번호
            String mgtKey = "20220525-001";

            // 파일아이디, 첨부파일 목록(GetFileList API) 의 응답항목 중 파일아이디(AttachedFile) 값
            String fileID = "";

            try
            {
                Response response = Global.taxinvoiceService.DeleteFile(testCorpNum, KeyType, mgtKey, fileID, testUserID);

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
