namespace DefaultNamespace;

public class Person
{
    private string name;
    int age;

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public Person()
    {
        this.name = "John Doe";
        this.age = 20;
    }
    
    public int getAge()
    {
        return this.age;
    }
    
    public string getName()
    {
        return this.name;
    }
}