﻿using System.Runtime.Serialization;

namespace DoctorsAppointmentAPI.Repository
{
    [Serializable]
    internal class NoDoctorsFoundException : Exception
    {
        public NoDoctorsFoundException()
        {
        }

        public NoDoctorsFoundException(string? message) : base(message)
        {
        }

        public NoDoctorsFoundException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected NoDoctorsFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}