using System;
using System.Collections.Generic;
using Xunit;

namespace FizzBuzz.Test
{
    public class FizzBuzzTest
    {
        [Fact]
        public void Verify_Number_IsFizz()
        {
            var numberToVerify = 6;

            var fizzBuzzLibrary = new FizzBuzzLibrary();

            Assert.Equal(fizzBuzzLibrary.ChkNumber(numberToVerify), "Fizz");
        }

        [Fact]
        public void Verify_Number_IsBuzz()
        {
            var numberToVerify = 5;

            var fizzBuzzLibrary = new FizzBuzzLibrary();

            Assert.Equal(fizzBuzzLibrary.ChkNumber(numberToVerify), "Buzz");
        }

        [Fact]
        public void Verify_Number_IsFizzBuzz()
        {
            var numberToVerify = 15;

            var fizzBuzzLibrary = new FizzBuzzLibrary();

            Assert.Equal(fizzBuzzLibrary.ChkNumber(numberToVerify), "FizzBuzz");
        }

        [Fact]
        public void Verify_Number_IsNotFizzBuzz()
        {
            var numberToVerify = 7;

            var fizzBuzzLibrary = new FizzBuzzLibrary();

            Assert.Equal(fizzBuzzLibrary.ChkNumber(numberToVerify), numberToVerify.ToString("N"));
        }

        [Fact]
        public void Verify_ChkFizzBuzz_With_Combinations()
        {
            var combinations = new List<Tuple<int, string>>
            {
                new Tuple<int, string> (3, "Fizz"),
                new Tuple<int, string> (5, "Buzz"),
            };

            var fizzBuzzLibrary = new FizzBuzzLibrary();

            var numberToVerify = 3;
            Assert.Equal(fizzBuzzLibrary.ChkFizzBuzz(combinations, numberToVerify), "Fizz");
            numberToVerify = 5;
            Assert.Equal(fizzBuzzLibrary.ChkFizzBuzz(combinations, numberToVerify), "Buzz");
            numberToVerify = 15;
            Assert.Equal(fizzBuzzLibrary.ChkFizzBuzz(combinations, numberToVerify), "FizzBuzz");
            numberToVerify = 7;
            Assert.Equal(fizzBuzzLibrary.ChkFizzBuzz(combinations, numberToVerify), numberToVerify.ToString("N"));
        }
    }
}
