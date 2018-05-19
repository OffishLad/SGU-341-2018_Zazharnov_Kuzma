using Task3.ITCompany.TypeOfCode;

namespace Task3.ITCompany.Workers
{
    public class BackendProgrammer : Programmer
    {
        public override Code Write()
        {
            return new BackendCode();
        }
    }
}
