/**
* �˺� ��������ȸ API ASP.NET SDK Example
*
* ASP.NET SDK ����ȯ�� ������� �ȳ� : https://developers.popbill.com/guide/taxinvoice/dotnet/getting-started/tutorial?fwn=asp
* ������Ʈ ���� : 2022-05-25
* ����������� ����ó : 1600-9854
* ����������� �̸��� : code@linkhubcorp.com
*
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

namespace Popbill.AccountCheck
{
    public class Global : System.Web.HttpApplication
    {

        // ��ũ���̵�
        private string LinkID = "TESTER";

        // ���Ű
        private string SecretKey = "SwWxqU+0TErBXy/9TVjIPEnI0VTUMMSQZtJf3Ed8q3I=";

        // ��������ȸ ���� ��ü ����
        public static AccountCheckService accountCheckService;

        protected void Application_Start(object sender, EventArgs e)
        {
            // ��������ȸ ���� ��ü �ʱ�ȭ
            accountCheckService = new AccountCheckService(LinkID, SecretKey);

            // ����ȯ�� ������, ���߿�(true), �����(false)
            accountCheckService.IsTest = true;

            // ������ū IP ���ѱ�� ��뿩��, ����(true)
            accountCheckService.IPRestrictOnOff = true;

            // �˺� API ���� ���� IP ��뿩��, true-���, false-�̻��, �⺻��(false)
            accountCheckService.UseStaticIP = false;

            // ���ü��� �ð� ��� ���� true-���, false-�̻��, �⺻��(false)
            accountCheckService.UseLocalTimeYN = true;
        }
    }
}