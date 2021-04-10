using Xunit;

namespace Article.Nucleotide.UnitTests.Models
{
    public static class UnkeyedUserModelTests
    {
        public sealed class ConstructorMethod
        {
            [Fact]
            public void ReturnsInstance()
            {
                var instance = new Article.Nucleotide.Shared.Models.UnkeyedUserModel();
                Assert.NotNull(instance);
            }
        }
    }
}
