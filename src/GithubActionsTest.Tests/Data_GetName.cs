using FluentAssertions;
using GithubActions.Core;

namespace GithubActionsTest.Tests
{
    public class Data_GetName
    {
        [Xunit.Fact]
        public void It_returns_Niels()
        {
            var data = new Data();
            var name = data.GetName();
            name.Should().Be("Niels");
        }
    }
}
