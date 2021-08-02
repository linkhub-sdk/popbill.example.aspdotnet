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

namespace Popbill.Taxinvoice
{
    public partial class search : System.Web.UI.Page
    {
        public String code = null;
        public String message = null;
        public TISearchResult result = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 검색조건에 해당하는 세금계산서를 조회합니다.
             * - https://docs.popbill.com/taxinvoice/dotnet/api#Search
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 팝빌회원 아이디
            String testUserID = "testkorea";

            // 세금계산서 유형, SELL-매출, BUY-매입, TRUSTEE-위수탁
            MgtKeyType KeyType = MgtKeyType.SELL;

            // [필수] 일자유형, R-등록일자, I-발행일자, W-작성일자 중 1개기입
            String DType = "W";

            // [필수] 시작일자, 날자형식(yyyyMMdd)
            String SDate = "20210701";

            // [필수] 종료일자, 날자형식(yyyyMMdd)
            String EDate = "20210730";

            // 상태코드 배열, 미기재시 전체 상태조회, 문서상태 값 3자리의 배열, 2,3번째 자리에 와일드카드 가능
            String[] State = new String[3];
            State[0] = "3**";
            State[1] = "4**";
            State[2] = "6**";

            // 문서유형 배열, N-일반세금계산서, M-수정세금계산서
            String[] Type = new String[2];
            Type[0] = "N";
            Type[1] = "M";

            // 과세형태 배열, T-과세, N-면세, Z-영세 
            String[] TaxType = new String[3];
            TaxType[0] = "T";
            TaxType[1] = "N";
            TaxType[2] = "Z";
            
            // 발행형태 배열, N-정발행, R-역발행, T-위수탁
            String[] IssueType = new String[3];
            IssueType[0] = "N";
            IssueType[1] = "R";
            IssueType[2] = "T";

            // 등록유형 배열, P-팝빌, H-홈택스 또는 외부ASP
            String[] RegType = new String[2];
            RegType[0] = "P";
            RegType[1] = "H";

            // 공급받는자 휴폐업상태 배열, N-미확인, 0-미등록, 1-사업중, 2-폐업, 3-휴업
            String[] CloseDownState = new String[5];
            CloseDownState[0] = "N";
            CloseDownState[1] = "0";
            CloseDownState[2] = "1";
            CloseDownState[3] = "2";
            CloseDownState[4] = "3";

            // 종사업장 유무, 공백-전체조회, 0-종사업장 없는 문서 조회, 1-종사업장번호 조건에 따라 조회
            String TaxRegIDYN = "";

            // 종사업장번호 유형, S-공급자, B-공급받는자, T-수탁자
            String TaxRegIDType = "S";

            // 종사업장번호, 콤마(",")로 구분하여 구성 ex) "0001,1234"
            String TaxRegID = "";

            // 지연발행 여부, 미기재시 전체, true-지연발행분 조회, false-정상발행분 조회
            bool? LateOnly = null;

            // 거래처 조회, 거래처 사업자등록번호 또는 상호명 기재, 미기재시 전체조회 
            String QString = "";

            // 문서번호 또는 국세청승인번호 조회
            String MgtKey = "";

            // 정렬방향, A-오름차순, D-내림차순
            String Order = "D";

            // 페이지번호
            int Page = 1;

            // 페이지당 검색개수, 최대 1000건
            int PerPage = 10;

            // 일반/연동 문서구분, 공백-전체조회, 0-일반문서 조회, 1-연동문서 조회
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
