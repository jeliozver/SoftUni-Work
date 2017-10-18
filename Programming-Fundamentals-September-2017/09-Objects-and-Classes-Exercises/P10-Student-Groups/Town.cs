namespace P10_Student_Groups
{
    using System.Collections.Generic;

    public class Town
    {
        public string Name { get; set; }
        public int SeatsCount { get; set; }

        public List<Student> Students { get; set; }
    }
}