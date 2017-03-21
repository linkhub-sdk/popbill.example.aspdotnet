/**
* 팜빌 전자세금계산서 API ASP.NET SDK Example
*
* ASP.NET SDK 연동환경 설정방법 안내 : http://blog.linkhub.co.kr/4022/
* 업테이트 일자 : 2017-03-15
* 연동기술지원 연락처 : 1600-8539 / 070-4304-2991
* 연동기술지원 이메일 : code@linkhub.co.kr
*
* <테스트 연동개발 준비사항>
* 1) 24, 27번 라인에 선언된 링크아이디(LinkID)와 비밀키(SecretKey)를
*    링크허브 가입시 메일로 발급받은 인증정보를 참조하여 변경합니다.
* 2) 팝빌 개발용 사이트(test.popbill.com)에 연동회원으로 가입합니다.
* 3) 전자세금계산서 발행을 위해 공인인증서를 등록합니다.
*    - 팝빌사이트 로그인 > [전자세금계산서] > [환경설정]
*      > [공인인증서 관리]
*    - 공인인증서 등록 팝업 URL (GetPopbillURL API)을 이용하여 등록
*/

using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Xml.Linq;

namespace Popbill.Taxinvoice
{
    public class Global : System.Web.HttpApplication
    {
        // 링크아이디
        private string LinkID = "TESTER";

        // 비밀키
        private string SecretKey = "SwWxqU+0TErBXy/9TVjIPEnI0VTUMMSQZtJf3Ed8q3I=";

        // 세금계산서 서비스 객체 선언
        public static TaxinvoiceService taxinvoiceService;

        protected void Application_Start(object sender, EventArgs e)
        {
            // 세금계산서 서비스 객체 초기화
            taxinvoiceService = new TaxinvoiceService(LinkID, SecretKey);

            // 연동환경 설정값, 개발용(true), 상업용(false)
            taxinvoiceService.IsTest = true;
        }
    }
}