//-----------------------------------------------------------------------
// <copyright company="TheNucleus">
// Copyright (c) TheNucleus. All rights reserved.
// Licensed under the Apache License, Version 2.0 license. See LICENCE.md file in the project root for full license information.
// </copyright>
//-----------------------------------------------------------------------

using NUnit.Framework;

namespace Nuclei.ExceptionHandling.Samples
{
    [TestFixture]
    public sealed class TopLevelExceptionGuardSample
    {
        private static int MyMethod()
        {
            return 0;
        }

        [Test]
        public void RunGuarded()
        {
            var processor = new TestExceptionProcessor();

            int functionReturnResult = -1;
            var result = TopLevelExceptionGuard.RunGuarded(
                    () => functionReturnResult = MyMethod(),
                    new ExceptionProcessor[]
                        {
                            processor.Process,
                        });

            var exitCode = (result == GuardResult.Failure) ? -1 : functionReturnResult;
            Assert.AreEqual(0, exitCode);
        }
    }
}
