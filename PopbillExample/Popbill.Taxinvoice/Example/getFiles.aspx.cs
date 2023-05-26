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
    public partial class getFiles : System.Web.UI.Page
    {
        public String code;
        public String message;
        public List<AttachedFile> fileList = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
            * 세금계산서에 첨부된 파일목록을 확인합니다.
            * - 응답항목 중 파일아이디(AttachedFile) 항목은 파일삭제(DeleteFile API) 호출시 이용할 수 있습니다.
            * - https://developers.popbill.com/reference/taxinvoice/dotnet/api/etc#GetFiles
            */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 세금계산서 문서번호
            String mgtKey = "20220525-001";

            // 세금계산서 발행유형, SELL-매출, BUY-매입, TRUSTEE-위수탁
            MgtKeyType KeyType = MgtKeyType.SELL;

            try
            {
                fileList = Global.taxinvoiceService.GetFiles(testCorpNum, KeyType, mgtKey);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}