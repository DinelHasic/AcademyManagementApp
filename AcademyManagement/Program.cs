// See https://aka.ms/new-console-template for more information

using AcademyManagement;
using AcademyManagement.Utilities;


ApplicationRun();



void ApplicationRun()
{
    User user = LogIn();
    if (user == null)
    {
        Console.WriteLine("Can not find that user :(");
    }
    else
    {
        if (user is Student student)
        {
            StudentLogsIn(student);
        }
        else if (user is Trainer trainer)
        {
            TrainerLogsIn(trainer);
        }
        else if (user is Admin admin)
        {
            AdminLogsIn(admin);
        }
        else
        {
            throw new Exception("Invalid role");
        }

    }
}
void AdminLogsIn(User user)
{
    Console.WriteLine("Enter R(remove) or A(add) user");
    string input = Console.ReadLine().ToUpper();

    if (input == OptionManue.ADD_USER)
    {
        AddUser();
    }
    else if (input == OptionManue.REMOVE_USER)
    {
        RemoveUser();
    }
    else
    {
        Console.WriteLine("Invalid input");
    }

}
void TrainerLogsIn(User user)
{
    Console.WriteLine("Enter 1 for student or 2 for subject:");
    string input = Console.ReadLine();
    List<Student> students = UsersDatabase.USERS.Where(u => u is Student).Select(u => (Student)u).ToList();
    if (input == OptionManue.STUDENTS)
    {
        students.ForEach(s => Console.WriteLine(s.Name));
    }
    else if (input == OptionManue.SUBJECTS)
    {
        List<string> subjects = students.Select(s => s.Subject.Name).Distinct().ToList();

        foreach (string subject in subjects)
        {
            int numberStudents = students.Where(s => s.Subject.Name == subject).Count();
            Console.WriteLine($"{subject} - {numberStudents} Students");
        }
    }
    else
    {
        Console.WriteLine("Ivalid input");
    }
}

void StudentLogsIn(Student student)
{
    Console.Write($"{student.Name} {student.Surname} Subject:{student.Subject.Name} Grades:");
    student.Subject.Grades.ForEach(x => Console.Write($"{x} "));
}

User LogIn()
{
    Console.WriteLine("Enter username");
    string username = Console.ReadLine();
    username.ValidInput();

    Console.WriteLine("Enter password");
    string password = Console.ReadLine();
    password.ValidInput();

    User user = UsersDatabase.USERS.FirstOrDefault(u => u.Username == username && u.GetPassword() == password);

    return user;
}

void AddUser()
{
    Console.WriteLine("Adding User");

    Console.WriteLine("Enter users name:");
    string name = Console.ReadLine();
    name.ValidInput();

    Console.WriteLine("Enter users surname:");
    string surname = Console.ReadLine();
    surname.ValidInput();

    Console.WriteLine("Enter users usersname:");
    string username = Console.ReadLine();
    username.ValidInput();

    Console.WriteLine("Enter users password");
    string password = Console.ReadLine();
    password.ValidInput();

    Console.WriteLine("Enter users role");
    string role = Console.ReadLine().ToLower();

    User user = null;
    switch (role)
    {
        case "admin":
            user = new Admin(name, surname, username, password);
            break;
        case "student":
            Console.WriteLine("Enter students subject");
            string subject = Console.ReadLine();
            user = new Student(name, surname, username, password, new Subject(subject, new List<int>()));
            break;
        case "treiner":
            user = new Trainer(name, surname, username, password);
            break;
        default:
            Console.WriteLine("Invalid role");
            break;
    }

    UsersDatabase.ADD_USER(user);

}

void RemoveUser()
{
    Console.WriteLine("Enter users usersname:");
    string username = Console.ReadLine();
    username.ValidInput();

    Console.WriteLine("Enter users password");
    string password = Console.ReadLine();
    password.ValidInput();

    User user = UsersDatabase.USERS.FirstOrDefault((x => x.Username == username && x.GetPassword() == password));

    UsersDatabase.REMOVE_USER(user);
}

