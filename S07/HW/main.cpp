#include<iostream>
#include<Windows.h>
#include<string>
using namespace std;

class KeepTime{
    public:
    unsigned long long m_first;
    unsigned long long m_result;
    unsigned long long m_second;
    
    KeepTime(const char* str){
        cout<<str<<endl;
        m_first=GetTickCount64();
        double pi=3.14;
        double r=1;
        long double MasahatKore=0;
        for(int i=0;i<100000000;i++){
            MasahatKore+=4*pi*r*r*r;


        }


    }
    ~KeepTime(){
        m_second=GetTickCount64();
        m_result=m_second-m_first;
        cout<<m_result<<endl;
    }

};
int main(){
    KeepTime T("The Time that is needed for my loop:");
}