using Xunit;

namespace RulesEngine.Tests
{
    public class PaymentRulesUnitTest
    {
        [Theory]
        [InlineData(0, "Default product selected. No rules to generate")]
        [InlineData(1, "Package slip generated")]
        [InlineData(2, "Duplicate package slip generated")]
        [InlineData(3, "Membership activated")]
        [InlineData(4, "Upgraded")]
        [InlineData(4, "Email sent for activation/upgrade")]
        [InlineData(5, "Free first aid video added")]
        [InlineData(0, "Generated free commission agent")]
        [InlineData(8888, "Invalid product selected")]

        public void Given_ForDifferentPaymentTypes_When_RulesAreApplied_Then_TheExpectedOutputIsProcessed(int paymentType, string expectedResult)
        {
            // Arrange
            string actualOutput;

            // Act
            actualOutput = RulesEngine.ExecuteRule(paymentType);

            // Assert
            actualOutput.Equals(expectedResult);

        }
    }
}
