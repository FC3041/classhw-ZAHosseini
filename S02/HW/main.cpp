#include<iostream>
#include<cmath>
using namespace std;
class circle{
    public:
    double x;
    double y;
    double r;
    circle(){
        x=3;
        y=3;
    }
    
};
double mohitcircle(circle c1){
    double mohit=3.14*(c1.r)*2;
    return mohit;
}
double masahatcircle(circle c1){
    double masahat=3.14*(c1.r)*(c1.r);
    return masahat;
}
double distancecircle(circle c1,circle c2){
    double distance=sqrt((c1.x-c2.x)*(c1.x-c2.x)+(c1.y-c2.y)*(c1.y-c2.y));
    return distance;
}
double distancecircle2(circle c1){
    int x,y;
    cin>>x>>y;

    double distance=sqrt((c1.x-x)*(c1.x-x)+(c1.y-y)*(c1.y-y));
    return distance;
}
void incircle(circle c1){
    int x2;
    int y2;
    cin>>x2;
    cin>>y2;
    double newx=c1.x-x2;
    double newy=c1.y-y2;
    double dist=sqrt(newx*newx + newy*newy);
    if(dist<c1.r){
        cout<<"true"<<endl;

    }
    else{
        cout<<"false"<<endl;
    }
        

}
int main(){
    circle c1;
    c1.x=0;
    c1.y=0;
    c1.r=3;

    circle c2;
    c2.x=1;
    c2.y=2;
    c2.r=1;

    cout<<"mohit is :"<<mohitcircle(c1)<<endl;
    cout<<"masahat is:"<<masahatcircle(c1)<<endl;
    cout<<"distance for 2 center is:"<<distancecircle(c1,c2)<<endl;
    cout<<"choose x & y"<<endl;
    cout<<"distance for a center and a point is:"<<distancecircle2(c1)<<endl;
    cout<<"choose x & y"<<endl;
    incircle(c1);
   

}
