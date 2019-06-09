using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using RWSystem.Translation;

namespace Tests
{
    [TestFixture]
    public class ActionLanguageTranslatorTests
    {
        [Test]
        public void CausesTest()
        {
            var actionLanguageTranslator = new ActionLanguageTranslator();
            var story = "A causes alfa";

            var translated = actionLanguageTranslator.Translate(story);

            Assert.AreEqual("causes(a, [[alfa]], []).", translated);
        }
        [Test]
        public void ImpossibleTest()
        {
            var actionLanguageTranslator = new ActionLanguageTranslator();
            var story = "impossible A if pi";

            var translated = actionLanguageTranslator.Translate(story);

            Assert.AreEqual("causes(a, [], [[pi]]).", translated);
        }
        [Test]
        public void CausesIfTest()
        {
            var actionLanguageTranslator = new ActionLanguageTranslator();
            var story = "A causes alfa if pi";

            var translated = actionLanguageTranslator.Translate(story);

            Assert.AreEqual("causes(a, [[alfa]], [[pi]]).", translated);
        }
        [Test]
        public void TypicallyCausesTest()
        {
            var actionLanguageTranslator = new ActionLanguageTranslator();
            var story = "A typically causes alfa";

            var translated = actionLanguageTranslator.Translate(story);

            Assert.AreEqual("typically_causes(a, [[alfa]], []).", translated);
        }
        [Test]
        public void TypicallyCausesIfTest()
        {
            var actionLanguageTranslator = new ActionLanguageTranslator();
            var story = "A typically causes alfa if pi";

            var translated = actionLanguageTranslator.Translate(story);

            Assert.AreEqual("typically_causes(a, [[alfa]], [[pi]]).", translated);
        }
        [Test]
        public void InvokesAfterIfTest()
        {
            var actionLanguageTranslator = new ActionLanguageTranslator();
            var story = "A invokes B after 1 if pi";

            var translated = actionLanguageTranslator.Translate(story);

            Assert.AreEqual("invokes(a, b, 1, [[pi]]).", translated);
        }
        [Test]
        public void InvokesAfterTest()
        {
            var actionLanguageTranslator = new ActionLanguageTranslator();
            var story = "A invokes B after 1";

            var translated = actionLanguageTranslator.Translate(story);

            Assert.AreEqual("invokes(a, b, 1, []).", translated);
        }
        [Test]
        public void InvokesAfterMinusTest()
        {
            var actionLanguageTranslator = new ActionLanguageTranslator();
            var story = "A invokes B after -1";

            Assert.Throws<Exception>(() =>
            {
                actionLanguageTranslator.Translate(story);
            });
        }
        [Test]
        public void InvokesIfTest()
        {
            var actionLanguageTranslator = new ActionLanguageTranslator();
            var story = "A invokes B if pi";

            var translated = actionLanguageTranslator.Translate(story);

            Assert.AreEqual("invokes(a, b, 0, [[pi]]).", translated);
        }
        [Test]
        public void InvokesTest()
        {
            var actionLanguageTranslator = new ActionLanguageTranslator();
            var story = "A invokes B";

            var translated = actionLanguageTranslator.Translate(story);

            Assert.AreEqual("invokes(a, b, 0, []).", translated);
        }
        [Test]
        public void TriggersTest()
        {
            var actionLanguageTranslator = new ActionLanguageTranslator();
            var story = "pi triggers B";

            var translated = actionLanguageTranslator.Translate(story);

            Assert.AreEqual("triggers([[pi]], b).", translated);
        }
        [Test]
        public void ReleasesIfTest()
        {
            var actionLanguageTranslator = new ActionLanguageTranslator();
            var story = "A releases f if pi";

            var translated = actionLanguageTranslator.Translate(story);

            Assert.AreEqual("releases(a, [[f]], [[pi]]).", translated);
        }
        [Test]
        public void ReleasesTest()
        {
            var actionLanguageTranslator = new ActionLanguageTranslator();
            var story = "A releases f";
            var translated = actionLanguageTranslator.Translate(story);

            Assert.AreEqual("releases(a, [[f]], []).", translated);
        }
        [Test]
        public void DisableBetweenTest()
        {
            var actionLanguageTranslator = new ActionLanguageTranslator();
            var story = "disable A between 1, 5";

            var translated = actionLanguageTranslator.Translate(story);

            Assert.AreEqual("disable_between(a, 1, 5).", translated);
        }
        [Test]
        public void DisableWhenTest()
        {
            var actionLanguageTranslator = new ActionLanguageTranslator();
            var story = "disable A when 4";

            var translated = actionLanguageTranslator.Translate(story);

            Assert.AreEqual("disable_between(a, 4, 4).", translated);
        }
    }
}
