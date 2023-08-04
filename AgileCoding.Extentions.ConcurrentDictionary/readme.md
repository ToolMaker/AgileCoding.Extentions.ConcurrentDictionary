AgileCoding.Extensions.ConcurrentDictionary
===========================================

Overview
--------

The AgileCoding.Extensions.ConcurrentDictionary is a .NET library that provides an extension method for the `System.Collections.Concurrent.ConcurrentDictionary` class, allowing you to easily convert a `ConcurrentDictionary` into a `Dictionary` with a mapping function.

Installation
------------

This library is available as a NuGet package. You can install it using the NuGet package manager console:

bashCopy code

`Install-Package AgileCoding.Extensions.ConcurrentDictionary -Version 2.0.5`

Features
--------

The library provides a way to convert a `ConcurrentDictionary` into a `Dictionary`:

1.  Convert ConcurrentDictionary to Dictionary: The `ToDictionary` extension method can be used to convert a `ConcurrentDictionary` to a `Dictionary`. This is useful in scenarios where you need the additional features provided by a `Dictionary`.

Usage
-----

Here's a brief example of how you can use this feature in your code:

```csharp
using AgileCoding.Extentions.ConcurrentDictionaries;
using System.Collections.Concurrent;

// Suppose 'myConcurrentDict' is a ConcurrentDictionary<TKeyType, TValueType1>.

Func<KeyValuePair<TKeyType, TValueType1>, KeyValuePair<TKeyType, TValueType2>> mappingFunction = kv => new KeyValuePair<TKeyType, TValueType2>(kv.Key, new TValueType2(kv.Value));

Dictionary<TKeyType, TValueType2> myDict = myConcurrentDict.ToDictionary(mappingFunction);
```

In the above example, replace `TKeyType`, `TValueType1`, and `TValueType2` with your actual types.

Documentation
-------------

For more detailed information about the usage of this library, please refer to the [official documentation](https://github.com/ToolMaker/AgileCoding.Extentions.ConcurrentDictionary/wiki).

License
-------

This project is licensed under the terms of the MIT license. For more information, see the [LICENSE](https://github.com/ToolMaker/AgileCoding.Extentions.ConcurrentDictionary/blob/main/LICENSE) file.

Contributing
------------

Contributions are welcome! Please see our [contributing guidelines](https://github.com/ToolMaker/AgileCoding.Extentions.ConcurrentDictionary/blob/main/CONTRIBUTING.md) for more details.