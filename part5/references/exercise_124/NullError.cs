namespace exercise_124
{
    public class NullError
    {
        private string name;
        private int value;
        public NullError(string name)
        {
            this.name = name;
            this.value = 0;
        }
        public void Increase(int number)
        {
            this.value += number;
        }
        public override string ToString()
        {
            return this.name;
        }
    }
}