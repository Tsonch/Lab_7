using Function;

namespace Tests {
    public class Tests
    {
        [TestCase(new int[] {3, 2, 1}, new int[] {1, 2, 3})]
        [TestCase(new int[] {2, 4, 6, 1, 3}, new int[] {1, 2, 3, 4, 6})]
        [TestCase(new int[] {3, -1, -4, 2, 3}, new int[] {-4, -1, 2, 3, 3})]
        [TestCase(new int[] {}, new int[] {-1})]
        public void sort(int[] arr, int[] res) {
            Assert.AreEqual(res, Func.sort(arr));
        }

        [TestCase(123, "false")]
        [TestCase(123321, "true")]
        [TestCase(2222, "true")]
        [TestCase(1, "true")]
        [TestCase(-1, "false")]
        public void palindrom(int a, bool res) {
            Assert.AreEqual(res, Func.palindrom(a));
        }

        [TestCase(5,120)]
        [TestCase(0,1)]
        [TestCase(-2,-1)]
        [TestCase(13,-1)]
        public void fact(int a, int result) {
            Assert.AreEqual(result, Func.fact(a));
        }

        [TestCase(1, 0)]
        [TestCase(-4, -1)]
        [TestCase(2, 1)]
        [TestCase(11, 55)]
        [TestCase(50, -1)]
        public void fib(int a, int res) {
            Assert.AreEqual(res, Func.fib(a));
        }

        [TestCase("qwerty", "qwe", "true")]
        [TestCase("qwe", "qwerty", "false")]
        [TestCase("", "", "true")]
        [TestCase("qwe", "", "false")]
        public void findStr(string s1, string s2, bool res) {
            Assert.AreEqual(res, Func.findStr(s1, s2));  
        }

        [TestCase(1, "false")]
        [TestCase(4, "false")]
        [TestCase(7, "true")]
        [TestCase(-3, "false")]
        public void primeNumber(int a, bool res) {
            Assert.AreEqual(res, Func.primeNumber(a));
        }

        [TestCase(-121, -121)]
        [TestCase(-1, -1)]
        [TestCase(2147483647, 0)]
        [TestCase(300, 3)]
        [TestCase(0, 0)]
        public void bits(int a, int res) {
            Assert.AreEqual(res, Func.bits(a));
        }

        [TestCase(1, "I")]
        [TestCase(14, "XIV")]
        [TestCase(0, "0")]
        [TestCase(-34, "-1")]
        [TestCase(4500, "-1")]
        public void rim(int a, string res) {
            Assert.AreEqual(res, Func.rim(a));
        }
    }
}