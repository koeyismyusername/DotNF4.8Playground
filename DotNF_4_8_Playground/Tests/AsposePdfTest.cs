using Aspose.Pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNF_4_8_Playground.Tests
{
    public class AsposePdfTest : ITestable
    {
        public void Test(TestContext context)
        {
            // initialize document object
            Document document = new Document();
            // add a page
            Page page = document.Pages.Add();
            // add text to the new page
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment("Hello World!"));
            // save PDF document
            document.Save(@"D:\99_임시저장\output.pdf");
        }
    }
}
