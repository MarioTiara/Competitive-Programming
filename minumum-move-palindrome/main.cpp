#include <iostream>
#include<string>
#include <algorithm> 
using namespace std;

//https://leetcode.com/problems/minimum-number-of-moves-to-make-palindrome/
int minMovesPalindrome(string s){
    



    return 0;
};

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

int main(){
    string s= "aaaaa";
    cout<<getMiddleString(s);
    return 0;   
}


