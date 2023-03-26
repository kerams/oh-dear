``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 11 (10.0.22621.1413/22H2/2022Update/SunValley2)
AMD Ryzen 9 7900, 1 CPU, 24 logical and 12 physical cores
.NET SDK=8.0.100-preview.2.23157.25
  [Host]     : .NET 7.0.3 (7.0.323.6910), X64 RyuJIT AVX2 DEBUG
  DefaultJob : .NET 7.0.3 (7.0.323.6910), X64 RyuJIT AVX2


```
|  Method |      Mean |     Error |    StdDev |   Gen0 | Allocated |
|-------- |----------:|----------:|----------:|-------:|----------:|
|  Option | 2.1162 ns | 0.0626 ns | 0.0522 ns | 0.0014 |      24 B |
| Voption | 3.0695 ns | 0.0059 ns | 0.0046 ns |      - |         - |
|  Result | 0.2416 ns | 0.0052 ns | 0.0043 ns |      - |         - |
