namespace Lesson__13
{
    class BMWSeven : ICar
    {
        public int Speed { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public void Create()
        {
            throw new System.NotImplementedException();
        }

        public int Move(int distance)
        {
            return distance / 100;
        }
    }
}
