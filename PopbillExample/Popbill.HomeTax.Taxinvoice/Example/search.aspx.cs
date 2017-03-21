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

namespace Popbill.HomeTax.Taxinvoice.Example
{
    public partial class search : System.Web.UI.Page
    {
        public String code;
        public String message;
        public HTTaxinvoiceSearch result;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
            * 검색조건을 사용하여 수집결과를 조회합니다.
            * - 응답항목에 관한 정보는 "[홈택스 전자(세금)계산서 연계 API 연동매뉴얼]
            *   > 3.3.1. Search (수집 결과 조회)" 을 참고하시기 바랍니다.
            */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 팝빌회원 아이디
            String testUserID = "testkorea";

            // 수집 요청(requestJob API)시 반환반은 작업아이디(jobID)
            String jobID = "017032109000000001";
           
            // 문서형태 배열, N-일반 전자세금계산서, M-수정 전자세금계산서
            String[] Type = { "N", "M" };

            // 과세형태, T-과세, N-면세, Z-영세 
            String[] TaxType = { "T", "N", "Z" };

            // 영수/청구, R-영수, C-청구, N-없음
            String[] PurposeType = { "R", "C", "N" };

            // 종사업장유무, 공백-전체조회 0-종사업장번호 없는 경우 조회, 1-종사업장번호 조건에 따라 조회
            String TaxRegIDYN = "";

            // 종사업장번호 사업자 유형, S-공급자, B-공급받는자, T-수탁자
            String TaxRegIDType = "S";

            // 종사업장번호, 콤마(",")로 구분하여 구성 ex) "0001,1234"
            String TaxRegID = "";

            // 페이지번호
            int Page = 1;

            // 페이지당 목록개수, 최대 1000건
            int PerPage = 10;

            // 정렬방향 D-내림차순, A-오름차순
            String Order = "D";

            try
            {
                result = Global.htTaxinvoiceService.Search(testCorpNum, jobID, Type, TaxType,
                        PurposeType, TaxRegIDYN, TaxRegIDType, TaxRegID, Page, PerPage, Order, testUserID);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
