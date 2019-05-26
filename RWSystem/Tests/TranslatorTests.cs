using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using RWSystem.Translation;

namespace Tests
{
    [TestFixture]
    public class TranslatorTests
    {
        [Test]
        public void Test()
        {
            var causesStatementTranslator = new CausesStatementTranslator();

            var tokens = new string[] { "A", "causes", "dead", "if", "loaded" };

            var translated = causesStatementTranslator.Translate(tokens);

            Assert.AreEqual("causes(A, [[dead]], [[loaded]]).", translated);
        }
    }
}
