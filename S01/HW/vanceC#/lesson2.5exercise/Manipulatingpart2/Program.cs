void temprature(float c){
    double F=1.8*c +32;
    string format=F.ToString();
    Console.Write(format); 
}

void main(){
    float c=38;
    temprature(c);

}
main();