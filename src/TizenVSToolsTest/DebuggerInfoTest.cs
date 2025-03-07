/*
 * Copyright 2020 (c) Samsung Electronics Co., Ltd  All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
*/

using NUnit.Framework;
using Tizen.VisualStudio.Tools.Data;

namespace Tizen.VisualStudio.Tools.UnitTests
{
    [TestFixture]
    [Description("Tizen.VisualStudio.Tools.Data Debugger Info tests")]
    public class DebuggerInfoTests
    {
        [SetUp]
        public void Setup()
        {
            DebuggerInfo.UseLiveProfiler = true;
        }

        [Test]
        [Category("P1")]
        [Description("Test if UseLiveProfiler is set correctly")]
        [Property("AUTHOR", "Alka Sethi, alka.sethi@samsung.com")]
        [TestCase(true)]
        public void GetUseLiveProfiler_CorrectValue_ReturnTrue(bool expectedValue)
        {
            Assert.That(DebuggerInfo.UseLiveProfiler.Equals(true), Is.EqualTo(expectedValue));
        }

        [Test]
        [Category("P2")]
        [Description("Test if UseLiveProfiler is set correctly")]
        [Property("AUTHOR", "Alka Sethi, alka.sethi@samsung.com")]
        [TestCase(false)]
        public void GetUseLiveProfiler_IncorrectValue_ReturnFalse(bool expectedValue)
        {
            Assert.That(DebuggerInfo.UseLiveProfiler.Equals(false), Is.EqualTo(expectedValue));
        }
    }
}
