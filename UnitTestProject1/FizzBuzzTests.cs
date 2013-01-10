using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class FizzBuzzTests
    {
        private Dictionary<int, string> setupRules()
        {
            var rules = new Dictionary<int, string>();
            rules.Add(3, "Fizz");
            rules.Add(5, "Buzz");
            rules.Add(15, "FizzBuzz");
            return rules;
        }

        [TestMethod]
        public void returns_correct_value_for_1()
        {
            var result = FizzBuzz.GetResult(1, setupRules());
            Assert.AreEqual(result, "1");
        }

        [TestMethod]
        public void returns_correct_value_for_11()
        {
            var result = FizzBuzz.GetResult(11, setupRules());
            Assert.AreEqual(result, "11");
        }

        [TestMethod]
        public void returns_correct_value_for_3()
        {
            var result = FizzBuzz.GetResult(3, setupRules());
            Assert.AreEqual(result, "Fizz");
        }

        [TestMethod]
        public void returns_correct_value_for_5()
        {
            var result = FizzBuzz.GetResult(5, setupRules());
            Assert.AreEqual(result, "Buzz");
        }

        [TestMethod]
        public void returns_correct_value_for_15()
        {
            var result = FizzBuzz.GetResult(15, setupRules());
            Assert.AreEqual(result, "FizzBuzz");
        }

        private Dictionary<int, string> setupAltRules() {
            var rules = new Dictionary<int, string>();
            rules.Add(8, "Foo");
            rules.Add(15, "Bar");
            rules.Add(95, "FooBarBaz");
            return rules;
        }

        [TestMethod]
        public void returns_correct_value_for_1_with_alternate_rules()
        {
            var result = FizzBuzz.GetResult(1, setupAltRules());
            Assert.AreEqual(result, "1");
        }

        [TestMethod]
        public void returns_correct_value_for_8_with_alternate_rules()
        {
            var result = FizzBuzz.GetResult(8, setupAltRules());
            Assert.AreEqual(result, "Foo");
        }

        [TestMethod]
        public void returns_correct_value_for_16_with_alternate_rules()
        {
            var result = FizzBuzz.GetResult(16, setupAltRules());
            Assert.AreEqual(result, "Foo");
        }

        [TestMethod]
        public void returns_correct_value_for_45_with_alternate_rules()
        {
            var result = FizzBuzz.GetResult(45, setupAltRules());
            Assert.AreEqual(result, "Bar");
        }

        [TestMethod]
        public void returns_correct_value_for_1520_with_alternate_rules()
        {
            var result = FizzBuzz.GetResult(1520, setupAltRules());
            Assert.AreEqual(result, "FooBarBaz");
        }

        [TestMethod]
        public void running_for_1000000000_times_should_not_throw_outofmemoryexception()
        {
            var result = String.Empty;

            for (int i = 0; i < 1000000000; i++)
            {
                result = FizzBuzz.GetResult(i, setupRules());
            }
        }
    }
}
