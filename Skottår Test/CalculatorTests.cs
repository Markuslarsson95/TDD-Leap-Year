using LeapYear_Calculator;

namespace LeapYear_Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(2024)]
        [TestCase(2020)]
        [TestCase(2028)]
        public void When_CheckLeapYear_ShouldReturnTrue(int leapYear)
        {
            //Arrange
            //int leapYear = 2024;

            //Act
            bool isLeapYear = Year.CheckLeapYear(leapYear);

            //Assert
            Assert.True(isLeapYear);
        }

        [Test]
        [TestCase(1700)]
        [TestCase(1900)]
        [TestCase(2100)]
        public void When_CheckLeapYear_ShouldReturnFalse(int leapYear)
        {
            //Arrange
            //int leapYear = 1700;

            //Act
            bool isLeapYear = Year.CheckLeapYear(leapYear);

            //Assert
            Assert.False(isLeapYear);
        }

        [Test]
        [TestCase("2023-11-15", 319)]
        [TestCase("2020-01-5", 5)]
        [TestCase("2024-04-18", 109)]
        public void When_GetDayNumber_Should_ReturnDay(DateTime date, int expectedInt)
        {
            //Arrange
            //DateTime date = new DateTime(2024, 1, 1);

            //Act
            int dayNumber = Year.GetDayNumber(date);

            //Assert
            Assert.That(dayNumber, Is.EqualTo(expectedInt));
        }

        [Test]
        [TestCase("2023-11-15", 46)]
        [TestCase("2020-01-5", 1)]
        [TestCase("2024-04-18", 16)]
        public void When_GetWeekOfTheYear_Should_ReturnWeek(DateTime date, int expectedInt)
        {
            //Arrange
            //DateTime date = DateTime.UtcNow;

            //Act
            int weekNumber = Year.GetWeekOfTheYear(date);

            //Assert
            Assert.That(weekNumber, Is.EqualTo(expectedInt));
        }

        [Test]
        [TestCase("2023-11-15", "Wednesday")]
        [TestCase("2020-01-5", "Sunday")]
        [TestCase("2024-04-18", "Thursday")]
        [Parallelizable(ParallelScope.All)]
        public void When_GetWeekDay_Should_ReturnWeekDay(DateTime date, string expectedString)
        {
            //Arrange
            //DateTime date = DateTime.UtcNow;

            //Act
            string weekDay = Year.GetWeekDay(date);

            //Assert
            //Change to match day of the week
            Assert.That(weekDay, Is.EqualTo(expectedString));
        }
    }
}