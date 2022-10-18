using System;

namespace LCS
{
    //LCS => Longest Common Subsequence
    class Program
    {
        static void Main(string[] args)
        {
            string A = "AGGTAB";
            string B="GXTXAYB";
            Console.WriteLine(Lcs(A,B,A.Length,B.Length));
        }

        public static int Lcs(string X, string Y, int m, int n)
        {

            int [,] LCS= new int[m+1, n+1];
            for(int i=0; i<=m; i++){
                for(int j=0; j<=n; j++){
                    if (i==0 || j==0) LCS[i,j]=0;
                    else if (X[i-1]==Y[j-1]) LCS[i,j]=LCS[i-1, j-1]+1;
                    else LCS[i,j]=Math.Max(LCS[i-1,j], LCS[i,j-1]);
                }

            }

            return LCS[m,n];
        }
    }
 
    
}
