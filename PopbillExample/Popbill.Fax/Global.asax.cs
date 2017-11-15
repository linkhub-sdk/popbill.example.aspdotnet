﻿/**
* 팝빌 팩스 API ASP.NET SDK Example
*
* ASP.NET SDK 연동환경 설정방법 안내 : http://blog.linkhub.co.kr/4022/
* 업테이트 일자 : 2017-11-14
* 연동기술지원 연락처 : 1600-9854 / 070-4304-2991
* 연동기술지원 이메일 : code@linkhub.co.kr
*
* <테스트 연동개발 준비사항>
* 1) 30, 33번 라인에 선언된 링크아이디(LinkID)와 비밀키(SecretKey)를
*    링크허브 가입시 메일로 발급받은 인증정보를 참조하여 변경합니다.
* 2) 팝빌 개발용 사이트(test.popbill.com)에 연동회원으로 가입합니다.
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

            // 연동환경 설정값, 개발용(true), 상업용(false)
            faxService.IsTest = true;
        }
    }
}