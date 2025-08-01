﻿using System;
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

namespace Popbill.Cashbill.Example
{
    public partial class search : System.Web.UI.Page
    {
        public String code;
        public String message;
        public CBSearchResult result;

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * 검색조건에 해당하는 현금영수증을 조회합니다. (최대 조회기간 : 6개월)
             * - https://developers.popbill.com/reference/cashbill/dotnet/api/info#Search
             */

            // 팝빌회원 사업자번호, '-' 제외 10자리
            String testCorpNum = "1234567890";

            // 검색일자 유형, R-등록일자, T-거래일자, I-발행일자
            String DType = "T";

            // 시작일자
            String SDate = "20250701";

            // 종료일자
            String EDate = "20250731";

            // 상태코드 배열, 2,3번째 자리에 와일드카드(*) 사용가능
            // - 상태코드에 대한 자세한 사항은 "[현금영수증 API 연동매뉴얼] >
            //   5.1. 현금영수증 상태코드"를 참고하시기 바랍니다.
            String[] State = new String[2];
            State[0] = "3**";

            // 문서형태 배열, N-일반 현금영수증, C-취소 현금영수증
            String[] TradeType = new String[2];
            TradeType[0] = "N";
            TradeType[1] = "C";

            // 거래구분 배열, P-소득공제용, C-지출증빙용
            String[] TradeUsage = new String[2];
            TradeUsage[0] = "P";
            TradeUsage[1] = "C";

            // 거래유형 배열, N-일반, B-도서공연, T-대중교통
            String[] TradeOpt = new String[3];
            TradeOpt[0] = "N";
            TradeOpt[1] = "B";
            TradeOpt[2] = "T";

            // 과세형태 배열, T-과세, N-비과세
            String[] TaxationType = new String[2];
            TaxationType[0] = "T";
            TaxationType[1] = "N";

            // 식별번호 조회, 미기재시 전체조회
            String QString = "";

            // 정렬방향, A-오름차순, D-내림차순
            String Order = "D";

            // 페이지 번호
            int Page = 1;

            // 페이지당 검색개수, 최대 1000개
            int PerPage = 30;

            // 가맹점 종사업장 번호, 다수건 검색시 콤마(",")로 구분. 예) 1234,1000
            String FranchiseTaxRegID = "";

            try
            {
                result = Global.cashbillService.Search(testCorpNum, DType, SDate, EDate, State, TradeType,
                                                  TradeUsage, TradeOpt, TaxationType, QString, Order, Page, PerPage, FranchiseTaxRegID);
            }
            catch (PopbillException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
