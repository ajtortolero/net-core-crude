namespace NETCoreCrude.Base
{
    using System;
    using System.Runtime.Serialization;
    /// <summary>
    /// Representa los errores que se producen durante la ejecución del Contexto de Datos.
    /// </summary>
    [Serializable]
    public class AppFailure<T>
        : Exception
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase Exception.
        /// </summary>
        public AppFailure()
        {

        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase Exception con un mensaje de error especificado.
        /// </summary>
        /// <param name="pMessage">El mensaje que describe el error.</param>
        public AppFailure(string pMessage)
            : base(pMessage)
        {

        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase Exception con un mensaje de error especificado.
        /// </summary>
        /// <param name="pMessageExpression">El mensaje que describe el error.</param>
        /// <param name="pArgs">Los argumentos del mensaje de excepción.</param>
        public AppFailure(string pMessageExpression, params object[] pArgs)
            : base(string.Format(pMessageExpression, pArgs))
        {

        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase Exception con datos serializados.
        /// </summary>
        /// <param name="pSerializationInfo">El SerializationInfo que contiene los datos de objetos serializados sobre la excepción de ser lanzado.</param>
        /// <param DataContextFailure="pStreamingContext">El StreamingContext que contiene información contextual sobre el origen o el destino.</param>
        protected AppFailure(SerializationInfo pSerializationInfo, StreamingContext pStreamingContext)
            : base(pSerializationInfo, pStreamingContext)
        {

        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase Exception con un mensaje de error especificado y una referencia a la excepción interna que representa la causa de esta excepción.
        /// </summary>
        /// <param name="pMessage">El mensaje que describe el error.</param>
        /// <param name="pException">Excepción que es la causa de la excepción actual, o una referencia null si no se especifica ninguna excepción interna.</param>
        public AppFailure(string pMessage, Exception pException)
            : base(pMessage, pException)
        {

        }
    }
}
