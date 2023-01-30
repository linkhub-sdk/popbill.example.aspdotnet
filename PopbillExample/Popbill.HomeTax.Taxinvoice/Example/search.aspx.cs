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
             * 수집 상태 확인(GetJobState API) 함수를 통해 상태 정보가 확인된 작업아이디를 활용하여 수집된 전자세금계산서 매입/매출 내역을 조회합니다.
             * - https://developers.popbill.com/reference/httaxinvoice/dotnet/api/search#Search
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 팝빌회원 아이디
            String testUserID = "";

            // 수집 요청(requestJob API)시 반환반은 작업아이디(jobID)
            String jobID = "019102318000000002";

            // 문서형태 배열 ("N" 와 "M" 중 선택, 다중 선택 가능)
            // └ N = 일반 , M = 수정
            // - 미입력 시 전체조회
            String[] Type = { "N", "M" };

            // 과세형태 배열 ("T" , "N" , "Z" 중 선택, 다중 선택 가능)
            // └ T = 과세, N = 면세, Z = 영세
            // - 미입력 시 전체조회
            String[] TaxType = { "T", "N", "Z" };

            // 발행목적 배열 ("R" , "C", "N" 중 선택, 다중 선택 가능)
            // └ R = 영수, C = 청구, N = 없음
            // - 미입력 시 전체조회
            String[] PurposeType = { "R", "C", "N" };

            // 종사업장번호 유무 (null , "0" , "1" 중 택 1)
            // - null = 전체 , 0 = 없음, 1 = 있음
            String TaxRegIDYN = "";

            // 종사업장번호의 주체 ("S" , "B" , "T" 중 택 1)
            // └ S = 공급자 , B = 공급받는자 , T = 수탁자
            // - 미입력시 전체조회
            String TaxRegIDType = "S";

            // 종사업장번호
            // 다수기재시 콤마(",")로 구분하여 구성 ex ) "0001,0002"
            // - 미입력시 전체조회
            String TaxRegID = "";

            // 페이지번호
            int Page = 1;

            // 페이지당 목록개수, 최대 1000건
            int PerPage = 10;

            // 정렬방향 D-내림차순, A-오름차순
            String Order = "D";

            // 거래처 상호 / 사업자번호 (사업자) / 주민등록번호 (개인) / "9999999999999" (외국인) 중 검색하고자 하는 정보 입력
            // - 사업자번호 / 주민등록번호는 하이픈('-')을 제외한 숫자만 입력
            // - 미입력시 전체조회
            String SearchString = "";

            try
            {
                result = Global.htTaxinvoiceService.Search(testCorpNum, jobID, Type, TaxType,
                        PurposeType, TaxRegIDYN, TaxRegIDType, TaxRegID, Page, PerPage, Order,
                        testUserID, SearchString);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
