﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuPDF.NET.Test
{
    public class TextPageTest : PdfTestBase
    {
        [SetUp]
        public void Setup()
        {
            doc = new Document("../../../resources/cython.pdf");

            textPage = doc.LoadPage(0).GetTextPage();
        }

        [Test]
        public void Constructor()
        {
            textPage = new TextPage(new mupdf.FzRect());
            Assert.Pass();

            textPage = new TextPage(doc.LoadPage(0).GetTextPage());
            Assert.Pass();
        }

        [Test]
        public void ExtractHtml()
        {
            textPage.ExtractHtml();
            Assert.Pass();
        }

        [Test]
        public void ExtractText()
        {
            textPage.ExtractText();
            Assert.Pass();
        }

        [Test]
        public void ExtractXml()
        {
            textPage.ExtractXML();
            Assert.Pass();
        }

        [Test]
        public void ExtractBlocks()
        {
            List<TextBlock> blocks = textPage.ExtractBlocks();
            Assert.That(blocks.Count, Is.EqualTo(4));
        }

        [Test]
        public void ExtractXHtml()
        {
            textPage.ExtractXHtml();
            Assert.Pass();
        }

        [Test]
        public void ExtractDict()
        {
            textPage.ExtractDict(new Rect(0, 0, 300, 300));
            Assert.Pass();
        }

        [Test]
        public void ExtractRAWDict()
        {
            textPage.ExtractRAWDict(new Rect(0, 0, 300, 300));
            Assert.Pass();

            textPage.ExtractRAWDict(null);
            Assert.Pass();
        }

        [Test]
        public void ExtractSelection()
        {
            textPage.ExtractSelection(new Point(20, 20), new Point(100, 100));
            Assert.Pass();

            textPage.ExtractSelection(null, null);
            Assert.Pass();

            string ret = textPage.ExtractSelection(new Point(-5, -15), null);
            Assert.Pass();
        }

        [Test]
        public void SearchTest()
        {
            Document doc = new Document("input.pdf");

            Page page = new Page(doc.GetPage(0), doc);

            TextPage tpage = page.GetTextPage();

            List<Quad> matches = TextPage.Search(tpage, "pixmap");

            if (matches.Count > 0)
            {
                page.AddHighlightAnnot(matches);
            }
        }
    }
}
