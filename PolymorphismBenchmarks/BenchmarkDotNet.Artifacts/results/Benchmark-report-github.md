```

BenchmarkDotNet v0.14.0, Parrot Security 6.3 (lorikeet)
AMD PRO A10-9700 R7, 10 COMPUTE CORES 4C+6G, 1 CPU, 4 logical cores and 1 physical core
.NET SDK 9.0.203
  [Host]     : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2
  DefaultJob : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2


```
| Method          | Mean       | Error    | StdDev   | Rank | Allocated |
|---------------- |-----------:|---------:|---------:|-----:|----------:|
| SealedMethod    |   360.8 μs |  7.16 μs | 12.16 μs |    1 |         - |
| DirectMethod    |   360.9 μs |  7.12 μs | 16.77 μs |    1 |         - |
| AbstractMethod  |   568.0 μs |  8.76 μs |  8.19 μs |    2 |         - |
| InterfaceMethod |   575.0 μs | 11.47 μs | 16.45 μs |    2 |       1 B |
| VirtualMethod   |   584.2 μs |  9.82 μs |  8.71 μs |    2 |       1 B |
| DynamicMethod   | 3,784.3 μs | 14.19 μs | 13.27 μs |    3 |       3 B |
