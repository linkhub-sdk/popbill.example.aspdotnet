/**
* �˺� �������ȸ API ASP.NET SDK Example
*
* ASP.NET SDK ����ȯ�� ������� �ȳ� : https://docs.popbill.com/closedown/tutorial/dotnet#asp
* ������Ʈ ���� : 2021-08-06
* ����������� ����ó : 1600-9854 / 070-4304-2991
* ����������� �̸��� : code@linkhub.co.kr
*
* <�׽�Ʈ �������� �غ����>
* 1) 30, 33�� ���ο� ����� ��ũ���̵�(LinkID)�� ���Ű(SecretKey)��
*    ��ũ��� ���Խ� ���Ϸ� �߱޹��� ���������� �����Ͽ� �����մϴ�.
* 2) �˺� ���߿� ����Ʈ(test.popbill.com)�� ����ȸ������ �����մϴ�.
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

namespace Popbill.Closedown
{
    public class Global : System.Web.HttpApplication
    {
        // ��ũ���̵�
        private string LinkID = "TESTER";

        // ���Ű
        private string SecretKey = "SwWxqU+0TErBXy/9TVjIPEnI0VTUMMSQZtJf3Ed8q3I=";

        // �������ȸ ���� ��ü ����
        public static ClosedownService closedownService;

        protected void Application_Start(object sender, EventArgs e)
        {
            // �������ȸ  ���� ��ü �ʱ�ȭ
            closedownService = new ClosedownService(LinkID, SecretKey);

            // ����ȯ�� ������, ���߿�(true), �����(false)
            closedownService.IsTest = true;

            // ������ū IP ���ѱ�� ��뿩��, ����(true)
            closedownService.IPRestrictOnOff = true;

            // �˺� API ���� ���� IP ��뿩��(GA), true-���, false-�̻��, �⺻��(false)
            closedownService.UseStaticIP = false;

            // ���ü��� �ð� ��� ���� true-���, false-�̻��, �⺻��(false)
            closedownService.UseLocalTimeYN = true;
        }

    }
}