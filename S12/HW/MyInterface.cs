public interface ICar{
    public double Size();
    public int Passenger();
}
public class Pars : ICar
{
    public double height;
    public double width;
    public int passenger;
    public Pars(double height,double width,int passenger){
        this.height=height;
        this.width=width;
        this.passenger=passenger;
    }
    public int Passenger()
    {
       return passenger;
    }

    public double Size()
    {
        return height*width;
    }
}

public class Pride : ICar
{
    public double height;
    public double width;
    public int passenger;
    public Pride(double height,double width,int passenger){
        this.height=height;
        this.width=width;
        this.passenger=passenger;
    }

    public int Passenger()
    {
        return passenger;
    }

    public double Size()
    {
        return height*width;
    }
    
}
public class Samand : ICar
{
    public double height;
    public double width;
    public int passenger;
    public Samand(double height,double width,int passenger){
        this.height=height;
        this.width=width;
        this.passenger=passenger;
    }

    public int Passenger()
    {
        return passenger;
    }

    public double Size()
    {
       return height*width;
    }
}