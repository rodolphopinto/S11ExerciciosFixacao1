using System;

namespace S11ExerciciosFixacao1.Entities.Exceptions
{
    class DamainException : ApplicationException
    {
        public DamainException(string message) : base(message)
        {
        }
    }
}
