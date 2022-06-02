using CountOnIPAddress.App;
using System;
using Xunit;

namespace CountOnIPAddress.Test
{
    public class CalculateTheNumberOfIPAddressesBetweenTwoIPAddressesTest
    {
        [Fact]
        public void IpsBetweenTest1()
        {
            //Arrange
            ICalculateTheNumberOfIPAddressesBetweenTwoIPAddresses calculateTheNumberOfIPAddressesBetweenTwoIPAddresses =
                new CalculateTheNumberOfIPAddressesBetweenTwoIPAddresses();
            var start = "10.0.0.0";
            var end = "10.0.0.50";
            ulong expected = 50;

            //Act
            var actual = calculateTheNumberOfIPAddressesBetweenTwoIPAddresses.IpsBetween(start, end);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void IpsBetweenTest2()
        {
            //Arrange
            ICalculateTheNumberOfIPAddressesBetweenTwoIPAddresses calculateTheNumberOfIPAddressesBetweenTwoIPAddresses =
                new CalculateTheNumberOfIPAddressesBetweenTwoIPAddresses();
            var start = "20.0.0.10";
            var end = "20.0.1.0";
            ulong expected = 246;

            //Act
            var actual = calculateTheNumberOfIPAddressesBetweenTwoIPAddresses.IpsBetween(start, end);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void IpsBetweenTest3()
        {
            //Arrange
            ICalculateTheNumberOfIPAddressesBetweenTwoIPAddresses calculateTheNumberOfIPAddressesBetweenTwoIPAddresses =
                new CalculateTheNumberOfIPAddressesBetweenTwoIPAddresses();
            var start = "0.0.0.0";
            var end = "255.255.255.255";
            ulong expected = (1L << 32) - 1L;

            //Act
            var actual = calculateTheNumberOfIPAddressesBetweenTwoIPAddresses.IpsBetween(start, end);

            //Assert
            Assert.Equal(expected, actual);

        }
        [Fact]
        public void IpsBetweenTest4()
        {
            //Arrange
            ICalculateTheNumberOfIPAddressesBetweenTwoIPAddresses calculateTheNumberOfIPAddressesBetweenTwoIPAddresses =
                new CalculateTheNumberOfIPAddressesBetweenTwoIPAddresses();
            var start = "0.0.0.0";
            var end = "255.255.255.255";
            ulong expected = 4294967295;

            //Act
            var actual = calculateTheNumberOfIPAddressesBetweenTwoIPAddresses.IpsBetween(start, end);

            //Assert
            Assert.Equal(expected, actual);

        }
    }
}

