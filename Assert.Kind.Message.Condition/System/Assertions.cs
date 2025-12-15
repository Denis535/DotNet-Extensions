#nullable enable
namespace System {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.CompilerServices;

    public static class Assertions {
        // Argument
        public readonly struct Argument {

            public FormattableString? Message { get; }

            public Argument(FormattableString? message) {
                this.Message = message;
            }

            [MethodImpl( MethodImplOptions.AggressiveInlining )]
            public void Valid([DoesNotReturnIf( false )] bool isValid) {
                if (!isValid) throw Exceptions.Argument.Invalid( this.Message );
            }

            [MethodImpl( MethodImplOptions.AggressiveInlining )]
            public void NotNull([DoesNotReturnIf( false )] bool isValid) {
                if (!isValid) throw Exceptions.Argument.Null( this.Message );
            }

            [MethodImpl( MethodImplOptions.AggressiveInlining )]
            public void InRange([DoesNotReturnIf( false )] bool isValid) {
                if (!isValid) throw Exceptions.Argument.OutOfRange( this.Message );
            }

            public override string ToString() {
                return Exceptions.Factory.GetMessageString( this.Message ) ?? "Null";
            }

        }
        // Operation
        public readonly struct Operation {

            public FormattableString? Message { get; }

            public Operation(FormattableString? message) {
                this.Message = message;
            }

            [MethodImpl( MethodImplOptions.AggressiveInlining )]
            public void Valid([DoesNotReturnIf( false )] bool isValid) {
                if (!isValid) throw Exceptions.Operation.Invalid( this.Message );
            }

            [MethodImpl( MethodImplOptions.AggressiveInlining )]
            public void Ready([DoesNotReturnIf( false )] bool isValid) {
                if (!isValid) throw Exceptions.Operation.NotReady( this.Message );
            }

            [MethodImpl( MethodImplOptions.AggressiveInlining )]
            public void NotDisposed([DoesNotReturnIf( false )] bool isValid) {
                if (!isValid) throw Exceptions.Operation.Disposed( this.Message );
            }

            public override string ToString() {
                return Exceptions.Factory.GetMessageString( this.Message ) ?? "Null";
            }

        }
    }
}
