using System;
using Calculator;
using Xunit;

namespace SalaryCalculatorTestProject
{
    public class UnitTest1
    {
        [Fact]
        public void AnnualSalaryTest()
        {
            SalaryCalculator sc = new SalaryCalculator();

            decimal annualSalary = sc.GetAnnualSalary(50);

            Assert.Equal(104000, annualSalary);
        }

        [Fact]
        public void HourlyWageTest()
        {
            SalaryCalculator sc = new SalaryCalculator();

            decimal hourlyWage = sc.GetHourlyWage(52000);

            Assert.Equal(25, hourlyWage);
        }
    }
}
