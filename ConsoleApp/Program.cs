using System;

namespace Function
{
    public static class Func {
        public static int[] sort(int[] arr) {
            if (arr.Length == 0) {
                return new int[] {-1};
            }
            for(int i = 0; i < arr.Length; i++) {
                for(int j = 0; j < arr.Length - i - 1; j++) {
                    if(arr[j] > arr[j + 1]) {
                        (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                    }
                }
            }
            return arr;
        }

        public static bool palindrom(int a) {
            int res = 0, temp, copy = a;
            while(a > 0) {
                temp = a % 10;
                res = res * 10 + temp;
                a = a / 10;
            }
            return copy == res;
        }

        public static int fact(int a) {
            if (a < 0 || a > 10) {
                return -1;
            }
            int res = 1;
            for(int i = 1; i <= a; i++) {
                res *= i;
            }
            return res;
        }

        public static int fib(int n) {
            if (n < 0 || n > 47) {
                return -1;
            }
            int x = 0, y = 1;
            for(int i = 0; i < n; i++) {
                x += y;
                y = x - y;
            }
            return y;
        }

        public static bool findStr(string s1, string s2) {
            if (s2.Length > s1.Length) {
                return false;
            }
            if (s1 == "" && s2 == "") {
                return true;
            }
            else if (s1 == "" || s2 == "") {
                return false;
            }
            return s1.Contains(s2);
        }

        public static bool primeNumber(int a) {
            if(a > 1) {
                for(int i = 2; i < a/2 + 1; i++) {
                    if(a % i == 0) {
                        return false;
                    }
                }
            }
            else return false;
            return true;
        }

        public static int bits(int a) {
            string b = a.ToString();
            if (b.Length == 1) {
                return a;
            }
            string reverse = new string(b.Reverse().ToArray());
            char minus = reverse[reverse.Length - 1];
            if (minus == '-') {
                string res = minus + reverse.Substring(0, reverse.Length - 1);
                if (long.Parse(res) <= 2147483647 && long.Parse(res) >= -2147483647) {
                    return int.Parse(res);
                }
            }
            if (long.Parse(reverse) <= 2147483647 && long.Parse(reverse) >= -2147483647) {
                return int.Parse(reverse);
            }
            return 0;
        }

        public static string rim(int a) {
            if(a < 0 || a > 3999) {
                // Console.WriteLine("Введите число от 0 до 3999");
                return "-1";
            }
            if(a == 0) {
                return "0";
            }
            int[] values = new int[] { 1000, 900, 500, 400, 100,90, 50, 40, 10, 9, 5, 4, 1 };
            string[] numerals = new string[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            string result = "";
            for (int i = 0; i < 13; i++)
            {
                while (a >= values[i]) {
                    a -= values[i];
                    result += numerals[i];
                }
            }
            return result.ToString();
        }
    }

    public class Program {
        public static void Main() {
            Console.WriteLine(Func.rim(-34));
        }
    }
}