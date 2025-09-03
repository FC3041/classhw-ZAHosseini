bool abs_near(double x,double y,double closness){
    double max=0;
    if(x>y){
        max=x;
    }
    else if(y>x){
        max=y;
    }
    double c=closness*max;
    if(Math.Abs(x-y)<=c){
        return true;
    }
    else{
        return false;
    }

}
void main(){
    double x=1000;
    double y=1001;
    Console.WriteLine(abs_near(x,y,0.001));
}
main();