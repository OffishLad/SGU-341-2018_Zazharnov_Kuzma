using Task3.ITCompany.TypeOfCode;

namespace Task3.ITCompany.Workers
{
    public class FrontendProgrammer : Programmer
    {
        public override Code Write()
        {
            return new FrontendCode();
        }
    }
}
