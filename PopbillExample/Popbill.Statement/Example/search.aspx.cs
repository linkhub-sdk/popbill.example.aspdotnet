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

namespace Popbill.Statement.Example
{
    public partial class search : System.Web.UI.Page
    {
        public String code;
        public String message;
        public DocSearchResult result = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 검색조건에 해당하는 전자명세서를 조회합니다. (조회기간 단위 : 최대 6개월)
             * - https://developers.popbill.com/reference/statement/dotnet/api/info#Search
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 검색일자 유형 ("R" , "W" , "I" 중 택 1)
            // - R = 등록일자 , W = 작성일자 , I = 발행일자
            String DType = "W";

            // 시작일자, 날짜형식(yyyyMMdd)
            String SDate = "20220501";

            // 종료일자, 날짜형식(yyyyMMdd)
            String EDate = "20220531";

            // 전자명세서 상태코드 배열 (2,3번째 자리에 와일드카드(*) 사용 가능)
            // - 미입력시 전체조회
            String[] State = new String[4];
            State[0] = "100";
            State[1] = "2**";
            State[2] = "3**";
            State[3] = "4**";

            // 전자명세서 문서유형 배열 (121 , 122 , 123 , 124 , 125 , 126 중 선택. 다중 선택 가능)
            // 121 = 명세서 , 122 = 청구서 , 123 = 견적서
            // 124 = 발주서 , 125 = 입금표 , 126 = 영수증
            int[] ItemCode = { 121, 122, 123, 124, 125, 126 };

            // 거래처 조회, 거래처 등록번호, 상호 조회, 미기재시 전체조회
            String QString = "";

            // 정렬방향, A-오름차순, D-내림차순
            String Order = "D";

            // 페이지 번호
            int Page = 1;

            // 페이지당 목록개수, 최대 1000개
            int PerPage = 15;

            try
            {
                result = Global.statementService.Search(testCorpNum, DType, SDate, EDate,
                    State, ItemCode, QString, Order, Page, PerPage);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
