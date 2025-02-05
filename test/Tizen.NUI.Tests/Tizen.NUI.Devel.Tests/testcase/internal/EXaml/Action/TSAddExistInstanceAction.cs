﻿using global::System;
using NUnit.Framework;
using NUnit.Framework.TUnit;
using Tizen.NUI.Components;
using Tizen.NUI.BaseComponents;

namespace Tizen.NUI.Devel.Tests
{
    using tlog = Tizen.Log;

    [TestFixture]
    [Description("internal/EXaml/Action/AddExistInstanceAction")]
    public class InternalAddExistInstanceActionTest
    {
        private const string tag = "NUITEST";

        [SetUp]
        public void Init()
        {
            tlog.Info(tag, "Init() is called!");
        }

        [TearDown]
        public void Destroy()
        {
            tlog.Info(tag, "Destroy() is called!");
        }

        [Test]
        [Category("P1")]
        [Description("AddExistInstanceAction AddExistInstanceAction.")]
        [Property("SPEC", "Tizen.NUI.EXaml.AddExistInstanceAction.AddExistInstanceAction C")]
        [Property("SPEC_URL", "-")]
        [Property("CRITERIA", "CONSTR")]
        [Property("AUTHOR", "guowei.wang@samsung.com")]
        public void EXamlAddExistInstanceActionConstructor()
        {
            tlog.Debug(tag, $"EXamlAddExistInstanceActionConstructor START");

            var testingTarget = new Tizen.NUI.EXaml.AddExistInstanceAction(new Tizen.NUI.EXaml.GlobalDataList(), null);
            Assert.IsNotNull(testingTarget, "Can't create success object AddExistInstanceAction");
            Assert.IsInstanceOf<Tizen.NUI.EXaml.AddExistInstanceAction>(testingTarget, "Should be an instance of AddExistInstanceAction type.");

            tlog.Debug(tag, $"EXamlAddExistInstanceActionConstructor END (OK)");
        }

        [Test]
        [Category("P1")]
        [Description("AddExistInstanceAction Init.")]
        [Property("SPEC", "Tizen.NUI.EXaml.AddExistInstanceAction.Init M")]
        [Property("SPEC_URL", "-")]
        [Property("CRITERIA", "MR")]
        [Property("AUTHOR", "guowei.wang@samsung.com")]
        public void EXamlAddExistInstanceActionInit()
        {
            tlog.Debug(tag, $"EXamlAddExistInstanceActionInit START");

            var testingTarget = new Tizen.NUI.EXaml.AddExistInstanceAction(new Tizen.NUI.EXaml.GlobalDataList(), null);
            Assert.IsNotNull(testingTarget, "Can't create success object AddExistInstanceAction");
            Assert.IsInstanceOf<Tizen.NUI.EXaml.AddExistInstanceAction>(testingTarget, "Should be an instance of AddExistInstanceAction type.");

            try
            {
                testingTarget.Init();
            }
            catch (Exception e)
            {
                tlog.Debug(tag, e.Message.ToString());
                Assert.Fail("Caught Exception : Failed!");
            }

            tlog.Debug(tag, $"EXamlAddExistInstanceActionInit END (OK)");
        }
    }
}
