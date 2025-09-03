bool is_leap_year(int n){
    if ((n % 4 == 0 && n % 100 != 0)||(n %400==0)){
        return true;
    }
        
    else{
        return false;

    }
}
    
int days_in_month(int monthNo, int n){
    int[] days_in_months = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};

    if (monthNo == 2 && is_leap_year(n)){
         return 29;

    }
        
    else{
        return days_in_months[monthNo - 1];

    }


}
   
void main(){
    Console.WriteLine(days_in_month(2, 2000));
}
    
main();
       