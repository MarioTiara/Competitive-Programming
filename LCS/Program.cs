using System;

namespace LCS
{
    //LCS => Longest Common Subsequence
    class Program
    {
        static void Main(string[] args)
        {
            string A = "bd";
            string B="abcd";
            Console.WriteLine(Lcs(A,B,A.Length,B.Length));
        }

        public static int Lcs(string X, string Y, int m, int n)
        {
        int[] prev = new int[n + 1];
        int[] curr = new int[n + 1];
        int i, j;
 
        for (i = 0; i <= m; i++) {
            for (j = 0; j <= n; j++) {
                if (i == 0 || j == 0)
                    prev[j] = 0;
 
                else if (X[i - 1] == Y[j - 1])
                    curr[j] = prev[j - 1] + 1;
 
                else
                    curr[j]
                        = Math.Max(prev[j], curr[j - 1]);
            }
 
            prev = curr;
            }
 
        /* L[m][n] contains length of LCS for X[0..n-1]
                and Y[0..m-1] */
            return prev[n];
    }
 
    // LCS based function to find minimum number of
    // insertions
    static int FindMinInsertionsLCS(string str, int n)
    {
        // Creat another string to store reverse of 'str'
        char[] tmp = str.ToCharArray();
        Array.Reverse(tmp);
        string rev = new string(tmp);
 
        // The output is length of string minus length of
        // lcs of str and it reverse
        return (n - Lcs(str, rev, n, n));
        }
    }
}
