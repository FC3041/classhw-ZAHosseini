bool is_prime(int n){

    if(n<=1){
        return false; 
    }
    else if(n==2){
        return true;
    }
    for(int i=2;i<n;i++){
        if(n%i==0){
            return false;
        }
        
    }
    return true;
}

void main(){
    int n=7;
    int a=-7;
    Console.WriteLine(is_prime(n));
    Console.WriteLine(is_prime(a));
}
main();