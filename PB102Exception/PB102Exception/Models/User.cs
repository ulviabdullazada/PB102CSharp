namespace PB102Exception.Models
{
    class User
    {
        private static int _count = 0;
        public int Id { get; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public User()
        {
            Id = ++_count;
        }
    }
}
