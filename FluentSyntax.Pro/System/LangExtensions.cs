#nullable enable
namespace System {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    public static class LangExtensions {

        // Chain
        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public static T Chain<T>(this T value, Action<T> processor) {
            processor( value );
            return value;
        }
        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public static TResult Pipe<T, TResult>(this T value, Func<T, TResult> converter) {
            return converter( value );
        }
        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public static void Apply<T>(this T value, Action<T> callback) {
            callback( value );
        }

    }
}
