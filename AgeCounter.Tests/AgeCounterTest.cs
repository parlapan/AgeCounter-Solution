using NUnit.Framework;

namespace AgeCounter.Tests
{
    public class AgeCounterTest
    {

        [Test]
        public void Test_If_PersonIsAdult()
        {
            int age = AgeCounter.Age(new int[] { 12, 9 });

            Assert.That(age == 21);
        }

        [Test]
        public void Test_If_PersonIsNotAdultWithNegativeNumbers()
        {
            int age = AgeCounter.Age(new int[] { -2 , -3 });

            Assert.That(age == -5);
        }

        [Test]
        public void Test_If_AgesAreEmpty()
        {
            int age = AgeCounter.Age(new int[] { });

            Assert.That(age == 0);
        }

        [Test]
        public void Test_If_PersonIsNotAdul()
        {
            int age = AgeCounter.Age(new int[] { 2, 9 });

            Assert.That(age == 11);
        }

        [Test]
        public void Test_If_PersonIsTooOld()
        {
            int age = AgeCounter.Age(new int[] { 50, 69 });

            Assert.That(age == 119);
        }
    }
}