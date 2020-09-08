using FluentAssertions;
using GithubActions.Core;
using Xunit;

namespace GithubActionsTest.Tests
{
    public class Data_GetName
    {
        [Fact]
        public void It_returns_Niels()
        {
            var data = new Data();
            var name = data.GetName();
            name.Should().Be("Niels");
        }
    }
}
