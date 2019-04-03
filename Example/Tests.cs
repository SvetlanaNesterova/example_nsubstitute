using System;
using NSubstitute;
using NUnit.Framework;

namespace Example
{
    [TestFixture]
    public class Tests
    {
        private IMainModule mainModule;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            mainModule = Substitute.For<IMainModule>();
            mainModule.Work(Arg.Any<string>(), Arg.Any<Guid>()).Returns(Guid.Empty);
        }

        [Test]
        public void Test()
        {
        }
    }
}
