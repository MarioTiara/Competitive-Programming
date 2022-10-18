using System;
using System.Linq;
using System.Collections.Generic;
namespace Minimum_Insert_Palindrome
{
    class Program
    {
        static int Lcs(char[] X, char[] Y, int m, int n )
        {

            int [,] L= new int[m+1, n+1];
            for (int i = 0; i <= m; i++) 
            { 
                for (int j = 0; j <= n; j++) 
                { 
                    if (i == 0 || j == 0) 
                        L[i, j] = 0; 
                    else if (X[i - 1] == Y[j - 1]) 
                        L[i, j] = L[i - 1, j - 1] + 1; 
                    else
                        L[i, j] = Math.Max(L[i - 1, j], L[i, j - 1]); 
                } 
            }

            return L[m,n];
        }

        static int minInsertions(string input) {
            char[] X=input.ToCharArray(); 
            char[] Y=input.ToCharArray(); 
            Array.Reverse(Y);
            return input.Length-Lcs(X,Y,X.Length,Y.Length);
        }
        static void Main(string[] args)
        {
            string s1 = "mbadm"; 
            Console.WriteLine(minInsertions(s1));
        }


     

        

        
    }
}
