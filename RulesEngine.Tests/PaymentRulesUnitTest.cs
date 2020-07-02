using Xunit;

namespace RulesEngine.Tests
{
    public class PaymentRulesUnitTest
    {
        [Theory]
        [InlineData(0, new string[] { "Default product selected. No rules to generate" } ) ]
        [InlineData(1, new string[] { "Package slip generated", "Generated free commission agent" })]
        [InlineData(2, new string[] { "Duplicate package slip generated", "Generated free commission agent" })]
        [InlineData(3, new string[] { "Membership activated", "Email sent for activation/upgrade" })]
        [InlineData(4, new string[] { "Upgraded", "Email sent for activation/upgrade" })]
        [InlineData(5, new string[] { "Free first aid video added" })]
        [InlineData(8888, new string[] { "Invalid product selected" })]

        public void Given_ForDifferentPaymentTypes_When_RulesAreApplied_Then_TheExpectedOutputIsProcessed(int paymentType, string[] expectedResult)
        {
            // Arrange
            string[] actualOutput;

            // Act
            actualOutput = RulesEngine.ExecuteRule(paymentType);

            // Assert
            actualOutput.Equals(expectedResult);

        }
    }
}
