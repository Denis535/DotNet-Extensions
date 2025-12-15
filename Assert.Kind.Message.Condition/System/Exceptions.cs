#nullable enable
namespace System {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public static class Exceptions {
        // Argument
        public static class Argument {
            public static ArgumentException Invalid(FormattableString? message) {
                return Factory.GetException<ArgumentException>( message );
            }
            public static ArgumentNullException Null(FormattableString? message) {
                return Factory.GetException<ArgumentNullException>( message );
            }
            public static ArgumentOutOfRangeException OutOfRange(FormattableString? message) {
                return Factory.GetException<ArgumentOutOfRangeException>( message );
            }
        }
        // Operation
        public static class Operation {
            public static InvalidOperationException Invalid(FormattableString? message) {
                return Factory.GetException<InvalidOperationException>( message );
            }
            public static ObjectNotReadyException NotReady(FormattableString? message) {
                return Factory.GetException<ObjectNotReadyException>( message );
            }
            public static ObjectDisposedException Disposed(FormattableString? message) {
                return Factory.GetException<ObjectDisposedException>( message );
            }
        }
        // Internal
        public static class Internal {
            public static Exception Exception(FormattableString? message) {
                return Factory.GetException<Exception>( message );
            }
            public static NullReferenceException NullReference(FormattableString? message) {
                return Factory.GetException<NullReferenceException>( message );
            }
            public static NotSupportedException NotSupported(FormattableString? message) {
                return Factory.GetException<NotSupportedException>( message );
            }
            public static NotImplementedException NotImplemented(FormattableString? message) {
                return Factory.GetException<NotImplementedException>( message );
            }
        }
        // Factory
        public static class Factory {

            // GetException
            public static T GetException<T>(FormattableString? message) where T : Exception {
                return GetException<T>( GetMessageString( message ) );
            }

            private static T GetException<T>(string? message) {
                var constructor = typeof( T ).GetConstructor( new[] { typeof( string ), typeof( Exception ) } );
                return (T) constructor.Invoke( new[] { message, null } );
            }

            // GetMessageString
            internal static string? GetMessageString(FormattableString? message) {
                if (message != null) {
                    var format = message.Format;
                    var arguments = message.GetArguments();
                    for (var i = 0; i < arguments.Length; i++) {
                        arguments[ i ] = "'" + GetArgumentString( arguments[ i ] ) + "'";
                    }
                    return string.Format( format, arguments );
                }
                return null;
            }

            // GetArgumentString
            private static string GetArgumentString(object? argument) {
                if (argument is IEnumerable enumerable and not string) {
                    return string.Join( ", ", enumerable.Cast<object?>().Select( GetArgumentString ) );
                }
                return argument?.ToString() ?? "Null";
            }

        }
    }
    // ObjectNotReadyException
    public class ObjectNotReadyException : InvalidOperationException {
        public ObjectNotReadyException(string message) : base( message ) {
        }
        public ObjectNotReadyException(string message, Exception? innerException) : base( message, innerException ) {
        }
    }
}
