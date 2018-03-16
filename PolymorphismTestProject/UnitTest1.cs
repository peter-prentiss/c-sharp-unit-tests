using System;
using Polymorphism;
using Xunit;

namespace PolymorphismTestProject
{
    public class UnitTest1
    {
        [Fact]
        public void CalculateWeeklySalaryForEmployeeTest_70wage55hoursReturns2800dollars()
        {
            int weeklyHours = 55;
            int wage = 70;
            int salary = 40 * wage;
            Employee e = new Employee();

            string expectedResponse = String.Format($"This ANGRY EMPLOYEE worked {weeklyHours} hrs. " +
                                                    $"Paid for 40 hrs at $ {wage}" +
                                                    $"/hr = ${salary}");

            string response = e.CalculateWeeklySalary(weeklyHours, wage);

            Assert.Equal(response, expectedResponse);
        }

        [Fact]
        public void CalculateWeeklySalaryForContractorTest_70wage55hoursReturns3850dollars()
        {
            int weeklyHours = 55;
            int wage = 70;
            int salary = weeklyHours * wage;
            Employee e = new Contractor();

            string expectedResponse = String.Format($"This HAPPY CONTRACTOR worked {weeklyHours} hrs. " +
                                                    $"Paid for {weeklyHours} hrs at $ {wage}" +
                                                    $"/hr = ${salary} ");

            string response = e.CalculateWeeklySalary(weeklyHours, wage);

            Assert.Equal(response, expectedResponse);
        }

        public void CalculateWeeklySalaryForEmployeeTest_70wage55hoursDoesNotReturnCorrectString()
        {
            int weeklyHours = 55;
            int wage = 70;
            int salary = 40 * wage;
            Employee e = new Employee();

            string expectedResponse = String.Format($"Problem 1-This ANGRY EMPLOYEE worked {weeklyHours} hrs. " +
                                                    $"Paid for 40 hrs at $ {wage}" +
                                                    $"/hr = ${salary}");

            string response = e.CalculateWeeklySalary(weeklyHours, wage);

            Assert.NotEqual(response, expectedResponse);
        }

        public void CalculateWeeklySalaryForContractorTest_70wage55hoursDoesNotReturnCorrectString()
        {
            int weeklyHours = 55;
            int wage = 70;
            int salary = weeklyHours * wage;
            Employee e = new Contractor();

            string expectedResponse = String.Format($"Problem 2-This HAPPY CONTRACTOR worked {weeklyHours} hrs. " +
                                                    $"Paid for {weeklyHours} hrs at $ {wage}" +
                                                    $"/hr = ${salary} ");

            string response = e.CalculateWeeklySalary(weeklyHours, wage);

            Assert.NotEqual(response, expectedResponse);
        }
    }
}
