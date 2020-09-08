using FluentAssertions;
using Xunit;

namespace GithubActionsTest.Tests
{
    public class FailingTest
    {
        [Fact]
        public void TheTest()
        {
            true.Should().BeFalse();
        }
    }
}