/*
    --
        --  MY FIRST PROJECT!  --
        -- BY: MICHAEL MARSICO --
    --
*/

/*
    -- MAIN CLASS --
*/

Console.WriteLine("this is the new way");
Person michael = new Person("Michael", "Marsico", 15);
Teacher langchung = new Teacher("Tenzin", "Langchung", "Computer Science");

Console.WriteLine($"{michael.FirstName} is in {langchung.FirstName[0]}. {langchung.LastName}'s {langchung.Subject} class.");

/*
    -- PERSON CLASS --
*/

class Person
{
    private string firstName;
    private string lastName;
    private byte age;

    public Person()
    {
        FirstName = "N/A";
        LastName = "N/A";
        Age = 0;
    }

    public Person(string fName, string lName)
    {
        FirstName = fName;
        LastName = lName;
        Age = 0;
    }

    public Person(string fName, string lName, byte nAge)
    {
        FirstName = fName;
        LastName = lName;
        Age = nAge;
    }

    public string FirstName
    {
        get { return this.firstName; }
        set
        {
            if (value.Length <= 15 && value.Length > 0)
            {
                this.firstName = value;
            }
            else
            {
                this.firstName = "N/A";
                Console.WriteLine($"Entered an Invalid Value: {value}");
                Console.WriteLine("Enter a valid first name between 1-15 characters");
            }
        }
    }

    public string LastName
    {
        get { return this.lastName; }
        set
        {
            if (value.Length <= 20 && value.Length > 0)
            {
                this.lastName = value;
            }
            else
            {
                this.lastName = "N/A";
                Console.WriteLine($"Entered an Invalid Value: {value}");
                Console.WriteLine("Enter a valid last name between 1-20 characters");
            }
        }
    }

    public byte Age
    {
        get { return this.age; }
        set
        {
            if (value >= 0 && value < byte.MaxValue)
            {
                this.age = value;
            }
            else
            {
                Console.WriteLine($"Entered an Invalid Value: {value}");
                Console.WriteLine("Please enter a positive whole number.");
            }
        }
    }
}

/*
    -- TEACHER CLASS --
*/

class Teacher : Person
{
    public static readonly string[] Subjects = {
        "Computer Science"
    };

    private string subject;

    public Teacher() : base()
    {
        Subject = "N/A";
    }

    public Teacher(string fName, string lName) : base(fName, lName)
    {
        Subject = "N/A";
    }

    public Teacher(string fName, string lName, string nSubject) : base(fName, lName)
    {
        Subject = nSubject;
    }

    public string Subject
    {
        get { return this.subject; }
        set
        {
            if (value == "N/A")
            {
                this.subject = value;
                return;
            }
            for (int i = 0; i < Subjects.Length; i++)
            {
                if (value == Subjects[i])
                {
                    this.subject = value;
                    return;
                }
            }
            this.subject = "N/A";
            Console.WriteLine($"Entered an Invalid Subject: {value}");
            Console.WriteLine("Please enter a valid subject from Teacher.Subjects");
        }
    }
}