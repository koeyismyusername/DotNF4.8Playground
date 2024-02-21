using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DotNF_4_8_Playground.Tests
{
    public class NRecoPdfGeneratorTest : ITestable
    {
        public void Test(TestContext context)
        {
            var client = new WebClient();
            var htmlToPdf = new NReco.PdfGenerator.HtmlToPdfConverter();

            //var htmlBytes = client.DownloadData(@"https://beta.etomato.com/ContractFiles/entrustment/tomato_entrustment.html");
            //var htmlStr = Encoding.UTF8.GetString(htmlBytes);
            var htmlStr = client.DownloadString(@"https://beta.etomato.com/ContractFiles/entrustment/tomato_entrustment.html");

            htmlToPdf.GeneratePdf(htmlStr, null, @"D:/99_임시저장/tomato_entrustment.pdf");
        }
    }
}
