using Xunit;

namespace RulesEngine.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(0, "None of the rules are applied")]
        [InlineData(1, "Package slip generated")]
        [InlineData(2, "Duplicate package slip generated")]
        [InlineData(3, "Membership activated")]
        [InlineData(4, "Email sent for activation/upgrade")]
        [InlineData(5, " Free first aid video added")]
        [InlineData(6, " Generated free commission agent")]
        public void Given_ForDifferentPaymentTypes_When_RulesAreApplied_Then_TheExpectedOutputIsProcessed(int paymentType, string expectedResult)
        {
            // Arrange

            // Act

            // Assert

        }
    }
}
