namespace Lesson__13
{
    public class Cyborg : ICar, IPerson
    {
        public int Speed { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public void Create()
        {
            throw new System.NotImplementedException();
        }

        int ICar.Move(int distance)
        {
            return distance / 100;
        }

        int IPerson.Move(int distance)
        {
            return distance / 5;
        }
        //public int Move(int distance)
        //{
        //    return distance / 50;
        //}
    }
}
