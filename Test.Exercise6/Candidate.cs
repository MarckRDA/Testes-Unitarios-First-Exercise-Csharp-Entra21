namespace Test.Exercise6
{
    public class Candidate
    {
        public int Id
        {
            get { return _id; }
            set
            {
                if (value > 0)
                {
                    _id = value;
                }
            }
        }
        private int _id;
        public string Name { get; set; }
        public int Vote { get; set; }

        public Candidate(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}