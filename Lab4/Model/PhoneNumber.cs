
namespace Lab4.Model
{
    public class PhoneNumber
    {
        public int CityCode { get; }
        public int Number { get; }

        public PhoneNumber() : this (0, 0)
        {
        }

        public PhoneNumber (int code, int number)
        {
            CityCode = code;
            Number = number;
        }

        public override string ToString()
        {
            return $"({CityCode:0##}) {Number:0#-##-##}";
        }
    }
}
