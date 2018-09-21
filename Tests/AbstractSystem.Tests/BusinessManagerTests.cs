using FluentAssertions;
using Xunit;

namespace AbstractSystem.Tests
{
    public class BusinessManagerTests
    {
        [Fact]
        public void ShouldGetSalaryPaidYtd()
        {
            // Arrange
            var businessManager = new BusinessManager();

            // Act
            var salaryPaidYtd = businessManager.GetSalaryPaidYtd();

            // Assert
            salaryPaidYtd.Should().Be(216000m);
        }
    }
}
