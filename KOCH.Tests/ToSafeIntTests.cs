using System;
using Xunit;

namespace KOCH.Tests
{
    /// <summary>
    /// KOCH interview ToSafeInt tests
    /// Author: Colin Gilbert
    /// </summary>
    public class ToSafeIntTests
    {
        #region ClassMethodTests
        [Theory]
        [InlineData("1", 1)]
        [InlineData("12", 12)]
        [InlineData("123", 123)]
        public void ClassMethod_ToSafeInt_GivenValidString_ReturnsExpectedNumber(string input, int expectedOutput)
        {
            var toSafeInt = new SafeIntConverter();
            var result = toSafeInt.ToSafeInt(input);
            Assert.Equal(result, expectedOutput);
        }

        [Theory]
        [InlineData("nope", 76)]
        [InlineData("wrong", 76)]
        public void ClassMethod_ToSafeInt_GivenInvalidString_DoesNotThrowException_ReturnsExpectedDefault(string input, int expectedDefault)
        {
            var toSafeInt = new SafeIntConverter();
            var result = toSafeInt.ToSafeInt(input);
            Assert.Equal(result, expectedDefault);
        }
        #endregion

        #region ExtensionMethodTests
        [Theory]
        [InlineData("1", 1, 98)]
        [InlineData("12", 12, 99)]
        [InlineData("123", 123, 100)]
        public void ExtensionMethod_ToSafeInt_GivenValidString_ReturnsExpectedNumber(string input, int expectedOutput, int defaultValue)
        {
            var result = input.ToSafeInt(defaultValue);
            Assert.Equal(result, expectedOutput);
        }

        [Theory]
        [InlineData("incorrect", 98)]
        [InlineData("bad",99)]
        public void ExtensionMethod_ToSafeInt_GivenInvalidString_DoesNotThrowException_ReturnsExpectedDefault(string input, int expectedDefault)
        {
            var result = input.ToSafeInt(expectedDefault);
            Assert.Equal(result, expectedDefault);
        }
        #endregion
    }
}
