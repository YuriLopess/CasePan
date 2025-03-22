namespace CasePan.Models
{
    /*
     * The 'User' class uses the encapsulation principle to protect the data,
     * ensuring that access and modification of the information are done in a controlled manner.
     * 
     * The 'Id' and 'CreatedAt' properties are immutable after the object is created, using the 'init' modifier.
     */

    public class User
    {
        private Guid _id;
        private string _name;
        private string _email;
        private string _password;
        private DateTime _createdAt;
        private DateTime _lastModifiedAt;
        private bool _isActive;

        public Guid Id
        {
            get { return _id; }
            init { _id = value; }  
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public DateTime CreatedAt
        {
            get { return _createdAt; }
            init { _createdAt = value; }
        }

        public DateTime LastModifiedAt
        {
            get { return _lastModifiedAt; }
            set { _lastModifiedAt = value; }
        }

        public bool IsActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }

    }
}