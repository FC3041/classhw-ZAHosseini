#include<iostream>
using namespace std;
class String{
    public:
        char* m_name;
        char* m_name2;
        int m_size;
   

        int lenght(const char* str2){
            int count =0;
            while(str2[count]!='\0'){
                count ++;
            }
        
            return count;
        }
        void copy(char* str1,const char* str2){
            int i=0;
            while (str2[i]!='\0')
            {
                str1[i]=str2[i];
                i++; 
            }
            str1[i]='\0';
            
        }

        String(const char*fname){
            m_size=lenght(fname);
            m_name=new char[m_size+1];
            copy(m_name,fname);
            cout<<m_name<<endl;
            
            
        }
        
        void assign(const char* name){
    
            m_name2=new char[lenght(name)];
            int i=0;
            for(i=0;i<lenght(name);i++){
                m_name2[i]=name[i];
            }
            m_name2[i]='\0';
            cout<<m_name2<<endl;
            delete[]m_name2;
        

        }
        void size(){
            m_size=lenght(m_name);
            cout<<m_size<<endl;
        }
    
        void append(const char*str){

            int newsize=lenght(m_name) + lenght(str);
            char*NewName=new char[newsize+1];
            copy(NewName,m_name);
            int size2=lenght(NewName);
            for(int j=0;j<lenght(str);j++){

                NewName[size2+j]=str[j];
            }
            NewName[newsize]='\0';
            
            delete[] m_name;
            m_name=NewName;
            m_size=newsize;
            
            

        }
        void print(){
            cout<<m_name<<endl;
        }
        void c_str(){
            cout<<m_name;

        }

};


int main(){
   String name("Ali");
   name.c_str();
   cout<<" : ";
   name.size();
   String name2("");
   name2.assign("Mozdeh");
   name.append(" + ");
   name.append("Mozdeh");
   name.append("\n");
   name.print();
   
}