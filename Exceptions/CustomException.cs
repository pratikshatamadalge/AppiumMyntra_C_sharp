namespace MyntraAutomation.Exceptions
{
    public class CustomException
    {
        /// <summary>
        /// Enum.
        /// </summary>
        public TypeOfException TypeOfExceptionValue;

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomException"/> class.
        /// CustomExcption.
        /// </summary>
        /// <param name="typeOfException">Typeof Exception.</param>
        public CustomException(TypeOfException typeOfException)
        {
            this.TypeOfExceptionValue = typeOfException;
        }

        /// <summary>
        /// Type of exception Method.
        /// </summary>
        public enum TypeOfException
        {
            /// <summary>
            /// Null pointer exception.
            /// </summary>
            NULL_POINTER_EXCEPTION,

            /// <summary>
            /// Element not found exception.
            /// </summary>
            ELEMENT_NOT_FOUND,

            /// <summary>
            /// Element not visible exception.
            /// </summary>
            ELEMENT_NOT_VISIBLE,

            /// <summary>
            /// Timeout exception.
            /// </summary>
            TIMEOUT_EXCEPTION
        }
    }
}