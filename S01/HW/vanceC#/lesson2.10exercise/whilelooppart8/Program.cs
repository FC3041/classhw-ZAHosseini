string number=Console.ReadLine();
int num;
int.TryParse(number,out num);

int count(int n){
    int count=0;
    while(n!=-1){
        count+=1;
    }
    Console.WriteLine(count);
}

void avg(int n){
    double sum=0;
    double avg=0;
    while(n!=-1){
       sum+=n;
        
    }
    avg=sum/count(n);
    Console.WriteLine(avg);
}
void min(int n){
    int min=0;
    while(n!=-1){
        for (int i=0;i<=n;i++){
            for(int j=0;j<=n;j++){
                if(i<j){
                    min=i;
                }
                else{
                    min=j;
                }
            }
        }
    }
    Console.WriteLine(min);
}

void max(int n){
    int max=0;
    while(n!=-1){
        for (int i=0;i<=n;i++){
            for(int j=0;j<=n;j++){
                if(i<j){
                    max=j;
                }
                else{
                    max=i;
                }
            }
        }
    }
    Console.WriteLine(max);
}
count(num);
avg(num);
min(num);
max(num);