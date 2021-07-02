using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1, 1, 6, 8)]
        [InlineData(43, 75, 234, 352)]
        [InlineData(null, null, null,  0)]
        public void Add(int num1, int num2, int num3,  int expected)
        {
            //Arrange
            Adding add = new Adding();
            //Act
            int actual = add.GetAnswer(num1, num2, num3);
            //Assert
            Assert.Equal(expected, actual);
        }
        
        [Theory]
        [InlineData(1, 2, -1)]
        [InlineData(8, 2, 6)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            var sub = new Subtracting();
            //Act
            var actual = sub.GetAnswer(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 5, 10)]
        [InlineData(-7, 11, -77)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var multi = new Multiply();
            //Act
            var actual = multi.GetAnswer(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(81, 9, 9)]
        [InlineData(2, 5, 0.4)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var div = new Divide();
            //Act
            var actual = div.GetAnswer(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void YourMethodName()
        {
            //Arrange
            var mailManager = new MailManager();
            const string mailAddress = "john.smith@company.com";

            //Act
            bool isValid = mailManager.IsValidAddress(mailAddress);

            //Assert
            Assert.True(isValid, $"The email {mailAddress} is not valid");

        }

        [Fact]
        public void YourMethodName2()
        {
            //Arrange
            var user = new UserName();
            const string userName = "jeign6943L:";
            //Act
            bool isValid = user.IsUserNameAllowed(userName); 
            //Assert
            Assert.True(isValid, "That user name is not valid");


        }
    }
        
    
}
