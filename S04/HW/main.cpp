#include<iostream>
#include<stdlib.h>
using namespace std;


class MyList
{
    public:
        int m_size;
        int m_capacity;
        int* m_Pnums;

    MyList(int size, int *nums)
    :m_size(size)
    {
        m_Pnums = (int*)malloc(sizeof(int)*size);
        int i;
        for(i=0; i<m_size;i++)
        {
            m_Pnums[i] = nums[i];
        }
    }


    void append(int x)
    {
        resize(m_size+1);
        m_Pnums[m_size-1] = x;
        print(m_Pnums,m_size);
        count (m_capacity);
        
    }
    void remove(){
        resize(m_size-2);
        print(m_Pnums,m_size);
        count (m_size);

    }
    void pop(int n){
        int* newlist2 = (int*)malloc(sizeof(int)*(m_size-1));
        for(int i=0;i<n;i++){
            newlist2[i]=m_Pnums[i];   
           
        }
        newlist2[n]=m_Pnums[n+1];
        for(int i=n+1;i<m_size;i++){
            newlist2[i]=m_Pnums[i+1];
        }
        resize(m_size-1);
        free(m_Pnums);
        m_Pnums=newlist2;
        print(m_Pnums,m_size);
        count (m_size);

    }
    void print(int*list,int size){
        for(int i=0;i<size;i++){
            cout<<list[i]<<" , ";
        }
        cout<<endl;
    }
    

    private:
    void resize(int newsize)
    {
        if(newsize<=m_size){
            int* newMem = (int*)malloc(sizeof(int)*newsize);
            int i=0;
            for(i=0; i<m_size;i++)
            {
                newMem[i] = m_Pnums[i];
            }
            free(m_Pnums);
            m_size = newsize;
            m_Pnums = newMem;

        }
        else{
            int* newMem = (int*)malloc(sizeof(int)*m_size*2);
            int i=0;
            for(i=0; i<m_size;i++)
            {
                newMem[i] = m_Pnums[i];
            }
            free(m_Pnums);
            m_capacity = m_size*2;
            m_Pnums = newMem;

        }
        
    }
    void count(int size){
        int count=0;
        for(int i=0;i<size;i++){
            count+=1;
        }
        cout<< count<<endl;
    }
};

int main()
{
    int nums[5] = {1,2,3,4,5};
    int nus[5] = {1,2,3,4,5};
    MyList m(5, nums);
    MyList z(5,nus);

    m.append(14);
    m.remove();
    z.pop(2);
}