public class Student
{
    public string name;
    public string family;
    public int stdid;
    public int credits;
   

    public Student(string name,string family, int stdid, int credits)
    {
        this.name = name;
        this.family=family;
        this.stdid = stdid;
        this.credits = credits;
    }

    public static Student Parse(string[] str)
    {
       
        var name = str[1];
        var family= str[2];
        var stdid = int.Parse(str[3]);
        var credits = int.Parse(str[4]);
        return new Student(name,family, stdid,credits);

    }
    public static Student Parse2(string[] str)
    {
       
        var name = str[0];
        var family= str[1];
        var stdid = int.Parse(str[2]);
        var credits = int.Parse(str[3]);
        return new Student(name,family, stdid,credits);

    }
    public override string ToString() =>
        $"{name},{family},{stdid},{credits}";

}