namespace Registration
{
    public class Position
    {
        private string position_name;

        public Position(string name)
        {
            this.position_name = name;
        }

        public string Name { get { return this.position_name; } }

        public override string ToString()
        {
            return this.position_name;
        }
    }
}
