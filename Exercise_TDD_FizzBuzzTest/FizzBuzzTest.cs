using Exercise_TDD_FizzBuzz;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_TDD_FizzBuzzTest
{
    [TestClass]
    public class FizzBuzzTest
    {
        [TestMethod]
        public void DetermineFizzBuzz_Should_Return_0_For_0()
        {
            // ARRANGE
            string expected = "0";
            int input = 0;
            FizzBuzz SUT = new FizzBuzz();
            // RUN
            var actual = SUT.DetermineFizzBuzz(input);
            // ASSERT
            expected.Should().Be(actual);
        }
    }
}
