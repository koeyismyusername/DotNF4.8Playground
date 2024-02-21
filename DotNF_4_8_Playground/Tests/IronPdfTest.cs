using IronPdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNF_4_8_Playground.Tests
{
    public class IronPdfTest : ITestable
    {
        public void Test(TestContext context)
        {
            var renderer = new ChromePdfRenderer();
            var pdf = renderer.RenderHtmlFileAsPdf(@"D:\99_임시저장\tomato_entrustment.html");
            pdf.SaveAs(@"D:\99_임시저장\tomato_entrustment.pdf");
        }
    }
}
