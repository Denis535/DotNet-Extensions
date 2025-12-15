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
        public static Option<T> Filter<T>(this T value, Func<T, bool> predicate) {
            if (predicate( value )) return Option.Create( value );
            return default;
        }
        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public static void Apply<T>(this T value, Action<T> callback) {
            callback( value );
        }

        // Chain
        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public static Option<T> Chain2<T>(this Option<T> value, Action<T> processor) {
            if (value.HasValue) processor( value.Value );
            return default;
        }
        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public static Option<TResult> Pipe2<T, TResult>(this Option<T> value, Func<T, TResult> converter) {
            if (value.HasValue) return Option.Create( converter( value.Value ) );
            return default;
        }
        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public static Option<T> Filter<T>(this Option<T> value, Func<T, bool> predicate) {
            if (value.HasValue) if (predicate( value.Value )) return value;
            return default;
        }
        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public static void Apply<T>(this Option<T> value, Action<T> callback) {
            if (value.HasValue) callback( value.Value );
        }

    }
}
