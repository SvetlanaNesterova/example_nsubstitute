using System;
using NSubstitute;
using NUnit.Framework;

namespace Example
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test()
        {
            var mainModule = Substitute.For<IMainModule>();
            mainModule.Work(Arg.Any<string>(), Arg.Any<Guid>()).Returns(Guid.Empty);

        }
    }
}