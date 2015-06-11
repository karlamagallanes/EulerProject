namespace EulerProject.Business
{
    public abstract class Problem : IProblem
    {
        public int id;

        public string Name;

        public abstract void Execute();

        public abstract void Init();
    }
}