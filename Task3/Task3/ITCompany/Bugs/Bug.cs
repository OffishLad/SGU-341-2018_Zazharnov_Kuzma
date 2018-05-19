namespace Task3.ITCompany.Bugs
{
    public abstract class Bug
    {
        protected Bug() { }
        public string Name { get; }
        public bool DoesExists { get; set; }
    }
}
