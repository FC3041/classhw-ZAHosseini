#include<iostream>
#include<stdlib.h>
using namespace std;
class vector{
    private: int len;
    public:
    int* m_nums;
    int m_size;
    
    
    vector(int* arr,int size){
        m_size=size;
        m_nums=new int[sizeof(int)*size];
        for(int i=0;i<m_size;i++){
            m_nums[i]=arr[i];
        }
        
        
    }
    void capasity(){
        
        int newsize=m_size*2;
        int len=newsize;
        cout<<len<<endl;

    }

    void push_back(int n){
        resize(m_size+1);
        m_nums[m_size-1]=n;
        print(m_nums,m_size+1);

    }
    void resize(int size){
        int newsize=sizeof(m_nums)*2;
        int* newnum=new int[newsize];
        int i;
        for(i=0;i<m_size;i++){
            newnum[i]=m_nums[i];
        }
        free(m_nums);
        m_nums=newnum;
        m_size=size;
 
    }
    void size(){
        int count=0;
        for(int i=0;m_nums[i]!='\0';i++){
            count++;

        }
        cout<< count<<endl;

    }
    void at(int n){
        cout<<m_nums[n]<<endl;
    }
    void print(int* mylist,int size2){
        for(int i=0;i<size2 && mylist[i]!='\0';i++){
            cout<<mylist[i]<<" , ";
        }
        cout<<endl;
    }
    void insert(int index,int value){
        int* list3=new int[sizeof(int)*(m_size+1)];
        for(int i=0;i<index;i++){
            list3[i]=m_nums[i];
        }
        list3[index]=value;
        for(int i=index;i<m_size+1 && m_nums[i]!='\0';i++){
            list3[i+1]=m_nums[i];
        }

        free(m_nums);
        m_nums=list3;
        print(m_nums,m_size+1);
        
        

    }
    void erase(int n){
        int* list2=new int[sizeof(int)*(m_size-1)];
        for(int i=0;i<n;i++){
            list2[i]=m_nums[i];
        }
        for(int i=n;i<m_size-1;i++){
            list2[i]=m_nums[i+1];
        }
        free(m_nums);
        m_nums=list2;
        print(m_nums,m_size-1);
        

    }
    void clear(){
        free(m_nums);
        
    }
    

};
int main(){
    int num[5]={1,3,4,5,6};
    int size=5;
    vector mynum(num,size);
    mynum.capasity();
    mynum.at(4);
    mynum.push_back(3);
    mynum.size();
    mynum.insert(0,8);
    mynum.erase(3);
    mynum.clear();
    

    

}




     




