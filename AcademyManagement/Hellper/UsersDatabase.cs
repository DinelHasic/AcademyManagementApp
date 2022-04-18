namespace AcademyManagement
{
    public static class UsersDatabase
    {

        public static List<User> USERS = new List<User>()
        {
            new Student("Dinel","Hasic","Dinko","12223", new Subject("Math",new List<int>{9,7,7})),
            new Student("Tom","Holand","Tom","1111", new Subject("Algebra",new List<int>{7,8,9})),
            new Student("Student1","Student1","StudentOne","StudentOne", new Subject("Math",new List<int>{7,7,7})),
            new Student("Student2","Student2","StudentTwo","StudentTwo", new Subject("Math",new List<int>{6,7,8})),
            new Admin("Jhony","Bravo","JBravo","OMama"),
            new Trainer("Tom","Hanks","Hank","Tom123")
        };

        public static void REMOVE_USER(User user)
        {
            if (USERS.Any(x => x == user))
            {
                USERS.Remove(user);
            }
            else
            {
                throw new Exception("That user dosent exist");
            }
        }

        public static void ADD_USER(User user)
        {
            if (user == null)
            {
                throw new ArgumentNullException("User is empty");
            }

            if (USERS.Any(x => x.Username == user.Username))
            {
                throw new Exception("That user already exists");
            }

            USERS.Add(user);
        }
    }
}
