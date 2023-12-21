using EvaluationSampleCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationSampleTest.UnitTests
{
    [TestClass]
    public class HtmlFormatHelperTests
    {
        private HtmlFormatHelper _formater;
        [TestInitialize]
        public void Init()
        {
            // Arrange
            _formater = new HtmlFormatHelper();
        }

        [TestMethod]

        public void GetOutput_WhenContentEqualSaucisse_ReturnBoldSaucisse()
        {
            var result = _formater.GetBoldFormat("Saucisse");

            Assert.AreEqual("<b>Saucisse</b>", result);
        }

        [TestMethod]

        public void GetOutput_WhenContentEqualSaucisse_ReturnItalicBurger()
        {
            var result = _formater.GetItalicFormat("Burger");

            Assert.AreEqual("<i>Burger</i>", result);
        }

        [TestMethod]

        public void GetOutput_WhenContentsInAList_ReturnHtmlFormatString()
        {
            List<string> contents_list = new List<string>();
            contents_list.Add("Pain");
            contents_list.Add("Salade");
            contents_list.Add("Sauce");
            contents_list.Add("Steak");
            var result = _formater.GetFormattedListElements(contents_list);

            Assert.AreEqual("<ul><li>Pain</li><li>Salade</li><li>Sauce</li><li>Steak</li></ul>", result);
        }
    }
}
