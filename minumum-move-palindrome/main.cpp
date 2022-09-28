#include <iostream>
#include<string>
#include <algorithm> 

using namespace std;

//https://leetcode.com/problems/minimum-number-of-moves-to-make-palindrome/


bool isPalindrome(string s){
    string reversed;
    for (int i=s.length()-1;i>=0;i--){
        reversed+=s[i];
    }

    return reversed==s;
};

int getMiddleString(string s){
    int midd;
    if ((s.length()%2)==0){
        midd=(s.length()/2)-1;
    }else{
        midd=(s.length()-1)/2;
    }

    return midd;
};

int minMovesPalindrome(string s){
    int minMove=0;
    if (isPalindrome(s)){
        return 0;
    }
    int mid=getMiddleString(s);
    int i=0,j=s.length()-1;
    while(i<=mid && j>=mid){
        if (s[i]==s[j]){
            i++;
            j--;
        }else{
            char RightChar=s[j];
            for (int r=mid; r>=0;r--){
                if (s[r]==RightChar){
                    swap(s[i],s[r]);
                    break;
                }
            }
            minMove++;
            i++;
            j--;
        }
    }
    return 1;
};

// void swap(int *a, int *b){
//     int* temp=a;
//     a=b;
//     b=temp;
// }



int main(){
    string s= "abcddcba";
    cout<<minMovesPalindrome(s)<<endl;
    return 0;   
}


