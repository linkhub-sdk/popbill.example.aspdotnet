/**
* 팝빌 팩스 API .NET SDK ASP.NET Example
* ASP.NET 연동 튜토리얼 안내 : https://developers.popbill.com/guide/fax/dotnet/getting-started/tutorial?fwn=asp
*
* 업데이트 일자 : 2024-02-26
* 연동기술지원 연락처 : 1600-9854
* 연동기술지원 이메일 : code@linkhubcorp.com
*         
* <테스트 연동개발 준비사항>
* 1) API Key 변경 (연동신청 시 메일로 전달된 정보)
*     - LinkID : 링크허브에서 발급한 링크아이디
*     - SecretKey : 링크허브에서 발급한 비밀키
* 2) SDK 환경설정 옵션 설정
*     - IsTest : 연동환경 설정, true-테스트, false-운영(Production), (기본값:true)
*     - IPRestrictOnOff : 인증토큰 IP 검증 설정, true-사용, false-미사용, (기본값:true)
*     - UseStaticIP : 통신 IP 고정, true-사용, false-미사용, (기본값:false)
*     - UseLocalTimeYN : 로컬시스템 시간 사용여부, true-사용, false-미사용, (기본값:true)
* 3) 발신번호 사전등록을 합니다. (등록방법은 사이트/API 두가지 방식이 있습니다.)
*    - 1. 팝빌 사이트 로그인 > [문자/팩스] > [팩스] > [발신번호 사전등록] 메뉴에서 등록
*    - 2. getSenderNumberMgtURL API를 통해 반환된 URL을 이용하여 발신번호 등록
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

namespace Popbill.Fax
{
    public class Global : System.Web.HttpApplication
    {
        // 링크아이디
        private string LinkID = "TESTER";

        // 비밀키
        private string SecretKey = "SwWxqU+0TErBXy/9TVjIPEnI0VTUMMSQZtJf3Ed8q3I=";

        // 팩스 서비스 객체 선언
        public static FaxService faxService;

        protected void Application_Start(object sender, EventArgs e)
        {
            // 팩스 서비스 객체 초기화
            faxService = new FaxService(LinkID, SecretKey);

            // 연동환경 설정, true-테스트, false-운영(Production), (기본값:true)
            faxService.IsTest = true;

            // 인증토큰 IP 검증 설정, true-사용, false-미사용, (기본값:true)
            faxService.IPRestrictOnOff = true;

            // 통신 IP 고정, true-사용, false-미사용, (기본값:false)
            faxService.UseStaticIP = false;

            // 로컬시스템 시간 사용여부, true-사용, false-미사용, (기본값:true)
            faxService.UseLocalTimeYN = true;
        }
    }
}