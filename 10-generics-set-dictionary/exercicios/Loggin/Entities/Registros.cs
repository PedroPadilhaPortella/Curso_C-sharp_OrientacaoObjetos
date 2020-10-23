using System;

namespace Loggin.Entities
{
    class Registros
    {
        public string User { get; set; }
        public DateTime Instant { get; set; }

        public override int GetHashCode()
        {
            return User.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if(!(obj is Registros)){
                return false;
            }
            Registros other = obj as Registros;
            return User.Equals(other.User);
        }

        public override string ToString(){
            return $"{User}, {Instant}";
        }
    }
}