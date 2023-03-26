Clone, `dotnet run -c Release`.
 
 
 ``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 11 (10.0.22621.1413/22H2/2022Update/SunValley2)
AMD Ryzen 9 7900, 1 CPU, 24 logical and 12 physical cores
.NET SDK=8.0.100-preview.2.23157.25
  [Host]     : .NET 8.0.0 (8.0.23.12803), X64 RyuJIT AVX2 DEBUG
  DefaultJob : .NET 8.0.0 (8.0.23.12803), X64 RyuJIT AVX2


```
|  Method |      Mean |     Error |    StdDev |   Gen0 | Allocated |
|-------- |----------:|----------:|----------:|-------:|----------:|
|  Option | 2.0639 ns | 0.0204 ns | 0.0171 ns | 0.0014 |      24 B |
| Voption | 3.0861 ns | 0.0381 ns | 0.0337 ns |      - |         - |
|  Result | 0.2330 ns | 0.0071 ns | 0.0063 ns |      - |         - |

 
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

``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19044.2728/21H2/November2021Update)
Intel Core i7-10700 CPU 2.90GHz, 1 CPU, 16 logical and 8 physical cores
.NET SDK=7.0.300-preview.23122.5
  [Host]     : .NET 7.0.3 (7.0.323.6910), X64 RyuJIT AVX2 DEBUG
  DefaultJob : .NET 7.0.3 (7.0.323.6910), X64 RyuJIT AVX2


```
|  Method |      Mean |     Error |    StdDev |   Gen0 | Allocated |
|-------- |----------:|----------:|----------:|-------:|----------:|
|  Option | 3.3377 ns | 0.0169 ns | 0.0149 ns | 0.0029 |      24 B |
| Voption | 2.7467 ns | 0.0138 ns | 0.0129 ns |      - |         - |
|  Result | 0.2212 ns | 0.0027 ns | 0.0021 ns |      - |         - |

``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19044.2728/21H2/November2021Update)
Intel Core i7-10700 CPU 2.90GHz, 1 CPU, 16 logical and 8 physical cores
.NET SDK=6.0.100
  [Host]     : .NET 6.0.14 (6.0.1423.7309), X64 RyuJIT AVX2 DEBUG
  DefaultJob : .NET 6.0.14 (6.0.1423.7309), X64 RyuJIT AVX2


```
|  Method |      Mean |     Error |    StdDev |   Gen0 | Allocated |
|-------- |----------:|----------:|----------:|-------:|----------:|
|  Option | 1.6237 ns | 0.0296 ns | 0.0277 ns | 0.0029 |      24 B |
| Voption | 2.8276 ns | 0.0173 ns | 0.0162 ns |      - |         - |
|  Result | 0.2077 ns | 0.0050 ns | 0.0045 ns |      - |         - |

```ini

BenchmarkDotNet=v0.13.5, OS=macOS Monterey 12.6.1 (21G217) [Darwin 21.6.0]
Intel Core i7-4870HQ CPU 2.50GHz (Haswell), 1 CPU, 4 logical and 4 physical cores
.NET SDK=7.0.202
  [Host]     : .NET 7.0.4 (7.0.423.11508), X64 RyuJIT AVX2 DEBUG
  DefaultJob : .NET 7.0.4 (7.0.423.11508), X64 RyuJIT AVX2


```
|  Method |     Mean |     Error |    StdDev |   Gen0 |   Gen1 | Allocated |
|-------- |---------:|----------:|----------:|-------:|-------:|----------:|
|  Option | 4.913 ns | 0.1654 ns | 0.1547 ns | 0.0076 | 0.0000 |      24 B |
| Voption | 4.036 ns | 0.0176 ns | 0.0165 ns |      - |      - |         - |
|  Result | 4.087 ns | 0.0218 ns | 0.0204 ns |      - |      - |         - |
