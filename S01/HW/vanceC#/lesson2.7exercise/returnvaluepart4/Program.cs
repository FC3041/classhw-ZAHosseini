﻿bool is_prime(int n){
    if(n==1){
        return false;
    
    }
    if (n==2){
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
    int n=4;
    Console.WriteLine(is_prime(n));
}
main();