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
    public partial class search : System.Web.UI.Page
    {
        public String code;
        public String message;
        public TISearchResult result = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 검색조건에 해당하는 세금계산서를 조회합니다. (조회기간 단위 : 최대 6개월)
             * - https://developers.popbill.com/reference/taxinvoice/dotnet/api/info#Search
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 팝빌회원 아이디
            String testUserID = "testkorea";

            // 세금계산서 유형, SELL-매출, BUY-매입, TRUSTEE-위수탁
            MgtKeyType KeyType = MgtKeyType.SELL;

            // 일자 유형 ("R" , "W" , "I" 중 택 1)
            // └ R = 등록일자 , W = 작성일자 , I = 발행일자
            String DType = "W";

            // 시작일자, 날자형식(yyyyMMdd)
            String SDate = "20220501";

            // 종료일자, 날자형식(yyyyMMdd)
            String EDate = "20220531";

            // 상태코드 배열 (2,3번째 자리에 와일드카드(*) 사용 가능)
            // - 미입력시 전체조회
            String[] State = new String[3];
            State[0] = "3**";
            State[1] = "4**";
            State[2] = "6**";

            // 문서 유형 배열 ("N" , "M" 중 선택, 다중 선택 가능)
            // - N = 일반 세금계산서 , M = 수정 세금계산서
            // - 미입력시 전체조회
            String[] Type = new String[2];
            Type[0] = "N";
            Type[1] = "M";

            // 과세형태 배열 ("T" , "N" , "Z" 중 선택, 다중 선택 가능)
            // - T = 과세 , N = 면세 , Z = 영세
            // - 미입력시 전체조회
            String[] TaxType = new String[3];
            TaxType[0] = "T";
            TaxType[1] = "N";
            TaxType[2] = "Z";

            // 발행형태 배열 ("N" , "R" , "T" 중 선택, 다중 선택 가능)
            // - N = 정발행 , R = 역발행 , T = 위수탁발행
            // - 미입력시 전체조회
            String[] IssueType = new String[3];
            IssueType[0] = "N";
            IssueType[1] = "R";
            IssueType[2] = "T";

            // 등록유형 배열 ("P" , "H" 중 선택, 다중 선택 가능)
            // - P = 팝빌, H = 홈택스 또는 외부ASP
            // - 미입력시 전체조회
            String[] RegType = new String[2];
            RegType[0] = "P";
            RegType[1] = "H";

            // 공급받는자 휴폐업상태 배열 ("N" , "0" , "1" , "2" , "3" , "4" 중 선택, 다중 선택 가능)
            // - N = 미확인 , 0 = 미등록 , 1 = 사업 , 2 = 폐업 , 3 = 휴업 , 4 = 확인실패
            // - 미입력시 전체조회
            String[] CloseDownState = new String[5];
            CloseDownState[0] = "N";
            CloseDownState[1] = "0";
            CloseDownState[2] = "1";
            CloseDownState[3] = "2";
            CloseDownState[4] = "3";

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

            // 지연발행 여부 (null , true , false 중 택 1)
            // - null = 전체조회 , true = 지연발행 , false = 정상발행
            bool? LateOnly = null;

            // 거래처 상호 / 사업자번호 (사업자) / 주민등록번호 (개인) / "9999999999999" (외국인) 중 검색하고자 하는 정보 입력
            // - 사업자번호 / 주민등록번호는 하이픈('-')을 제외한 숫자만 입력
            // - 미입력시 전체조회
            String QString = "";

            // 문서번호 또는 국세청승인번호 조회
            String MgtKey = "";

            // 정렬방향, A-오름차순, D-내림차순
            String Order = "D";

            // 페이지번호
            int Page = 1;

            // 페이지당 검색개수, 최대 1000건
            int PerPage = 10;

            // 연동문서 여부 (null , "0" , "1" 중 택 1)
            // - null = 전체조회 , 0 = 일반문서 , 1 = 연동문서
            // - 일반문서 : 세금계산서 작성 시 API가 아닌 팝빌 사이트를 통해 등록한 문서
            // - 연동문서 : 세금계산서 작성 시 API를 통해 등록한 문서
            String InterOPYN = "";

            try
            {
                result = Global.taxinvoiceService.Search(testCorpNum, KeyType, DType, SDate, EDate, State,
                                    Type, TaxType, IssueType, LateOnly, TaxRegIDYN, TaxRegIDType, TaxRegID, QString,
                                    Order, Page, PerPage, InterOPYN, testUserID, RegType, CloseDownState, MgtKey);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }

        }
    }
}
