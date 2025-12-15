# Overview
The FluentSyntax.Pro is a library with a very convenient fluent syntax extensions.

# Reference
```
namespace System;
public static class LangExtensions {

    public static T Chain<T>(this T value, Action<T> processor);
    public static TResult Pipe<T, TResult>(this T value, Func<T, TResult> converter);
    public static Option<T> Filter<T>(this T value, Func<T, bool> predicate);
    public static void Apply<T>(this T value, Action<T> callback);

    public static Option<T> Chain2<T>(this Option<T> value, Action<T> processor);
    public static Option<TResult> Pipe2<T, TResult>(this Option<T> value, Func<T, TResult> converter);
    public static Option<T> Filter2<T>(this Option<T> value, Func<T, bool> predicate);
    public static void Apply<T>(this Option<T> value, Action<T> callback);

}
```

# Links
- https://github.com/Denis535/DotNet.Extensions
- https://www.nuget.org/packages/FluentSyntax.Pro
