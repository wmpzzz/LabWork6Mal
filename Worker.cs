public class Worker
{
    public string _fullName = "unknown";
    public string _post = "unknown";
    public int _salary = 0;


    public Worker() : this("Kravchuck Mikhail Sergeevich", "cleaning manager", 10000000)
    {
    }

    public Worker(string fullName, string post, int salary)
    {
        FullName = fullName;
        Post = post;
        Salary = salary;
    }

    public string FullName
    {
        get => _fullName;
        set
        {
            if (value != "")
                _fullName = value;
        }
    }

    public string Post
    {
        get => _post;
        set
        {
            if (value != "")
                _post = value;
        }
    }

    public int Salary
    {
        get => _salary;
        set
        {
            if (value >= 0)
                _salary = value;
        }
    }

    public object this[string index]
    {
        get
        {
            if (index == "fullName")
                return _fullName;
            if (index == "post")
                return _post;
            if (index == "salary")
                return _salary;
            return null;
        }
    }

    public char this[int index]
    {
        get
        {
            if (index < _fullName.Length && index >= 0)
                return _fullName[index];
            return '\0';
        } 
    }

}