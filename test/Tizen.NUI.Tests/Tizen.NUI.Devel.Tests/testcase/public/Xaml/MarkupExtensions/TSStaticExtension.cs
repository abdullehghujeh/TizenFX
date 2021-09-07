﻿using NUnit.Framework;
using System;
using Tizen.NUI.Xaml;

namespace Tizen.NUI.Devel.Tests
{
    using tlog = Tizen.Log;

    [TestFixture]
    [Description("public/xaml/MarkupExtensions/StaticExtension")]
    public class PublicStaticExtensionTest
    {
        private const string tag = "NUITEST";
        private StaticExtension sExtention;

        internal class IServiceProviderImpl : IServiceProvider
        {
            public object GetService(Type serviceType) { return null; }
        }

        [SetUp]
        public void Init()
        {
            tlog.Info(tag, "Init() is called!");
            sExtention = new StaticExtension();
        }

        [TearDown]
        public void Destroy()
        {
            sExtention = null;
            tlog.Info(tag, "Destroy() is called!");
        }

        [Test]
        [Category("P1")]
        [Description("StaticExtension Member")]
        [Property("SPEC", "Tizen.NUI.StaticExtension.Member A")]
        [Property("SPEC_URL", "-")]
        [Property("CRITERIA", "PRW")]
        public void StaticExtensionMember()
        {
            tlog.Debug(tag, $"StaticExtensionMember START");

            try
            {
                var member = sExtention.Member;
                sExtention.Member = member;
                Assert.AreEqual(member, sExtention.Member, "Should be equal");
            }
            catch (Exception e)
            {
                tlog.Debug(tag, e.Message.ToString());
                Assert.Fail("Caught Exception : Failed!");
            }

            tlog.Debug(tag, $"StaticExtensionMember END");
        }

        [Test]
        [Category("P1")]
        [Description("StaticExtension ProvideValue")]
        [Property("SPEC", "Tizen.NUI.StaticExtension.ProvideValue M")]
        [Property("SPEC_URL", "-")]
        [Property("CRITERIA", "MR")]
        public void StaticExtensionProvideValue()
        {
            tlog.Debug(tag, $"StaticExtensionProvideValue START");

            try
            {
                sExtention.ProvideValue(new IServiceProviderImpl());  // IXamlTypeResolver is null
            }
            catch (ArgumentException e)
            {
                tlog.Debug(tag, e.Message.ToString());
                tlog.Debug(tag, $"StaticExtensionProvideValue END");
                Assert.Pass("Caught ArgumentException : Passed!");
            }
        }
    }
}