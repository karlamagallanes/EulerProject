namespace EulerProject.Business
{
    public abstract class Problem : IProblem
    {
        public int id;

        public string Name;

        public abstract string Execute();

    }
}