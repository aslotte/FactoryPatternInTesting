using System.Collections.Generic;

namespace Domain.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PhoneNumber { get; set; }

        #region Equals implementation 

        public override bool Equals(object obj)
        {
            if (obj is Person otherPerson)
            {
                if (otherPerson.Id == Id &&
                    otherPerson.FirstName == FirstName &&
                    otherPerson.LastName == LastName &&
                    otherPerson.PhoneNumber == PhoneNumber) return true;

                return false;
            }
            return false;
        }

        public override int GetHashCode()
        {
            var hashCode = -1825862710;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(FirstName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(LastName);
            hashCode = hashCode * -1521134295 + PhoneNumber.GetHashCode();
            return hashCode;
        }

        #endregion
    }
}
