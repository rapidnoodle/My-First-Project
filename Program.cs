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

Console.WriteLine($"{michael.FirstName} is in {langchung.GetDigitalSignature()}'s {langchung.Subject} class.");
Console.ReadLine();

/*
    -- PERSON CLASS --
*/

class Person
{
    private string firstName;
    private string lastName;
    private byte age;

    public Person(string fName = "N/A", string lName = "N/A", byte nAge = 0)
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

    public string GetDigitalSignature()
    {
        return $"{FirstName[0]}. {LastName}";
    }
}

/*
    -- TEACHER CLASS --
*/

class Teacher : Person
{
    public static readonly string[] Subjects = {
        "Computer Science",
        "Mathematics",
        "Science",
        "Social Studies",
        "English"
    };

    private string subject;

    public Teacher(string fName = "N/A", string lName = "N/A", string nSubject = "N/A") : base(fName, lName)
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