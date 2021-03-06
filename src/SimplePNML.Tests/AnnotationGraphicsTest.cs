﻿using NUnit.Framework;

using System.Linq;

namespace SimplePNML.Tests
{
    [TestFixture]
    public class AnnotationGraphicsTest
    {
        private AnnotationGraphics graphics;

        [SetUp]
        public void Setup()
        {
            graphics = new AnnotationGraphics();
        }

        [Test]
        public void IsDefault_NewInstance_True()
        {
            var isDefault = graphics.IsDefault();

            Assert.IsTrue(isDefault);
        }

        [Test]
        public void IsDefault_OffsetNotDefault_False()
        {
            graphics.Offset = new Offset(2.2, 5.6);

            var isDefault = graphics.IsDefault();

            Assert.IsFalse(isDefault);
        }

        [Test]
        public void Collect_NewInstance_ContainsMoreThanOneElement()
        {
            var children = graphics.Collect();

            Assert.Greater(children.Count(), 1);
        }
    }
}
