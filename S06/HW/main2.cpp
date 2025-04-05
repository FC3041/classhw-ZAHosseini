#include<iostream>
#include<stdlib.h>

using namespace std;

class MyStr
{
    public:
    int m_size;
    char* m_PChars;

    MyStr():m_size(0),m_PChars(nullptr){};

    MyStr(const char* chars)
    {
        int i;
        for(i=0;chars[i]!='\0';i++);
        m_size = i+1;

        m_PChars = (char*)malloc(sizeof(char)*(m_size));
        for(i=0; i<m_size;i++)
        {
            m_PChars[i] = chars[i];
        }
        m_PChars[m_size] = '\0';
    }

    MyStr(const char* chars, int start, int count)
    :m_size(count)
    {
        m_PChars = (char*)malloc(sizeof(char)*(m_size+1));

        for(int i=0;i<m_size ;i++)
        {
            m_PChars[i] = chars[start+i];
        }
        m_PChars[count] = '\0';

    }
    int lenght(const char*str){
        int i=0;
        while(str[i]!='\0'){
            i++;
        }   
        return i;
    }
    bool check(char* mainStr,const char*subStr){
        for(int i=0;i<lenght(subStr);i++){
            if(mainStr[i]!=subStr[i]){
                return false;
            }

        }
        return true;
    
    }
    bool checkSubstr(const char* str){
        int size=lenght(str);
        for(int i=0;i<m_size - size ;i++){
            if(check(m_PChars,str)){
                return true;
            }
        }
        return false;

    }
    void len(){
        int i=0;
        while(m_PChars[i]!='\0'){
            i++;
        }
        cout<< i<<endl;
    }
    void add(MyStr& s){
        int newSize=m_size+ s.m_size;
        if(newSize>=m_size){
            resize(newSize);

        }
        int i=0;
        for(i=0;i<s.m_size;i++){
            m_PChars[i+m_size]=s.m_PChars[i];

        }
        m_PChars[i+m_size]='\0';
        printStr();


    }
    void add(char* str){
        int newSize=m_size+ lenght(str);
        if(newSize>=m_size){
            resize(newSize);

        }
        int i=0;
        for(i=0;i<lenght(str);i++){
            m_PChars[i+m_size]=str[i];

        }
        m_PChars[i+m_size]='\0';
        printStr();


    }


    void printStr()
    {
        cout << m_PChars << endl;
    }
    private :
    void resize(int size){

        char* newStr=new char[size+1];
        int i=0;
        for( i=0;i<m_size;i++){
            newStr[i]=m_PChars[i];
        }
        newStr[i]='\0';
        delete []m_PChars;
        m_PChars=newStr;

    }
};


int main()
{
    MyStr s1;

    MyStr s2("malihe hajihosseini", 7, 12);
    s2.printStr();
    cout<<s2.checkSubstr("haji")<<endl;
    s2.len();
    s2.add(s1);
    s2.add("HI");
    
}