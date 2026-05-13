# Overview
The FluentSyntax.Pro is a library with a very convenient fluent syntax extensions.

# Reference
```
namespace System;
public static class LangExtensions {

    public static T Chain<T>(this T value, Action<T> processor);
    public static TResult Pipe<T, TResult>(this T value, Func<T, TResult> converter);
    public static void Apply<T>(this T value, Action<T> callback);

}
```

# Links
- https://github.com/Denis535/DotNet-Extensions
- https://www.nuget.org/packages/FluentSyntax.Pro
