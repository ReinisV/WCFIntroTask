namespace CatsDataAccess
{
    using System;

    public class Cat
    {
        public int CatId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PictureLink { get; set; }
        public int Age { get; set; }
        public DateTime LastModified { get; set; }
    }
}