bool is_divisible(int a,int b){
    if(a%b==0){
        return true;
    }
    else{
        return false;
    }
}

void main(){
    int a=3;
    int b=4;
    Console.WriteLine(is_divisible(a,b));
}
main();