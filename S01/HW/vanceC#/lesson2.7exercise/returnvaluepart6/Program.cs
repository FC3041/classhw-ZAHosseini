int days_in_month(int[] arr,int x){
    if(0<=x && x<12){
        return arr[x];
    }
    else{
        return -1;
    }
}
void main(){
    int[] arr={31,31,31,31,31,31,30,30,30,30,30,28};
    Console.WriteLine(days_in_month(arr,3));
}
main();