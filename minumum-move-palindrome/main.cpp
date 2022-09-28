#include <iostream>
#include<string>
#include <algorithm> 
using namespace std;
int minMovesPalindrome(string s){
    //int midd=
    
    //return midd;

    return 0;
};

bool isPalindrome(string s){
    string reversed;
    for (int i=s.length()-1;i>=0;i--){
        reversed+=s[i];
    }

    return reversed==s;
}

int main(){
    string s= "aba";
    cout<<isPalindrome(s);
    return 0;   
}


