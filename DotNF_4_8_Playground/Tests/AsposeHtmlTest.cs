using Aspose.Html;
using Aspose.Html.Converters;
using Aspose.Html.Saving;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNF_4_8_Playground.Tests
{
    public class AsposeHtmlTest : ITestable
    {
        public void Test(TestContext context)
        {
            using (var document = new HTMLDocument(@"D:\99_임시저장\tomato_entrustment.html"))
            {
                var options = new PdfSaveOptions();
                Converter.ConvertHTML(document, options, @"D:\99_임시저장\tomato_entrustment.pdf");
            }
        }
    }
}
