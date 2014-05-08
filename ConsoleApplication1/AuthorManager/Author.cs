using System;
namespace AuthorManager{
    sealed class Author{
        private string firstName;
        public string FirstName { get { return firstName;  } }

        private string lastName;
        public string LastName { get { return lastName; } }

        private string authorID;
        public string AuthorID { get { return authorID;  } }

        public Author() { }
        public Author(string author_id, string lName, string fName) {
            authorID  = author_id;
            lastName  = lName;
            firstName = fName;
        }
    }
}
