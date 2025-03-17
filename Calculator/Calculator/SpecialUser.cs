using System.Xml.Linq;

namespace Calculator
{
    class SpecialUser : User
    {
        public override string UserInfo()
        {
            return $"Special User: {Name}, Balance: {Balance}, Hello!";
        }
    }
}