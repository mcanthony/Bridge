using Bridge.QUnit;
using System.Linq;

namespace ClientTestLibrary.Linq
{
    internal class TestLinqGenerationOperators
    {
        public static void Test(Assert assert)
        {
            assert.Expect(2);

            // TEST
            var numbers = (from n in Enumerable.Range(0, 6)
                           select new
                           {
                               Number = n,
                               IsOdd = n % 2 == 1
                           }).ToArray();
            var numbersExpected = new object[] {
                 new { Number = 0, IsOdd = false},
                 new { Number = 1, IsOdd = true},
                 new { Number = 2, IsOdd = false},
                 new { Number = 3, IsOdd = true},
                 new { Number = 4, IsOdd = false},
                 new { Number = 5, IsOdd = true},
                 };

            assert.DeepEqual(numbers, numbersExpected, "Range() 6 items from 0");

            // TEST
            var repeatNumbers = Enumerable.Repeat(-3, 4).ToArray();
            var repeatNumbersExpected = new[] { -3, -3, -3, -3 };

            assert.DeepEqual(repeatNumbers, repeatNumbersExpected, "Repeat() -3 four times");
        }
    }
}
