# Overview
The Assert.Kind.Message.Condition is a library with a very convenient fluent assertions.

# Reference
```
// Assert.Argument
Assert.Argument.Message( $"ArgumentException" ).Valid( ... )
Assert.Argument.Message( $"ArgumentNullException" ).NotNull( ... )
Assert.Argument.Message( $"ArgumentOutOfRangeException" ).InRange( ... )
// Assert.Operation
Assert.Operation.Message( $"InvalidOperationException" ).Valid( ... )
Assert.Operation.Message( $"ObjectNotReadyException" ).Ready( ... )
Assert.Operation.Message( $"ObjectDisposedException" ).NotDisposed( ... )

// Exceptions.Argument
throw Exceptions.Argument.Invalid( ... )
throw Exceptions.Argument.Null( ... )
throw Exceptions.Argument.OutOfRange( ... )
// Exceptions.Operation
throw Exceptions.Operation.Invalid( ... )
throw Exceptions.Operation.NotReady( ... )
throw Exceptions.Operation.Disposed( ... )
// Exceptions.Internal
throw Exceptions.Internal.Exception( ... )
throw Exceptions.Internal.NullReference( ... )
throw Exceptions.Internal.NotSupported( ... )
throw Exceptions.Internal.NotImplemented( ... )
```

# Links
- https://github.com/denis535/DotNet.Extensions
- https://www.nuget.org/packages/Assert.Kind.Message.Condition
