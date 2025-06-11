```

BenchmarkDotNet v0.14.0, Parrot Security 6.4 (lorikeet)
AMD PRO A10-9700 R7, 10 COMPUTE CORES 4C+6G, 1 CPU, 4 logical cores and 1 physical core
.NET SDK 9.0.301
  [Host]     : .NET 9.0.6 (9.0.625.26613), X64 RyuJIT AVX2
  DefaultJob : .NET 9.0.6 (9.0.625.26613), X64 RyuJIT AVX2


```
| Method          | Mean       | Error    | StdDev   | Ratio | RatioSD | Rank | Allocated | Alloc Ratio |
|---------------- |-----------:|---------:|---------:|------:|--------:|-----:|----------:|------------:|
| StaticMethod    |   366.4 μs |  6.78 μs |  6.34 μs |  1.00 |    0.02 |    1 |         - |          NA |
| SealedMethod    |   375.9 μs |  7.51 μs | 14.47 μs |  1.03 |    0.04 |    1 |         - |          NA |
| DirectMethod    |   382.7 μs |  7.90 μs | 21.64 μs |  1.04 |    0.06 |    1 |         - |          NA |
| VirtualMethod   |   578.1 μs |  5.54 μs |  4.63 μs |  1.58 |    0.03 |    2 |         - |          NA |
| AbstractMethod  |   594.0 μs | 11.56 μs | 12.37 μs |  1.62 |    0.04 |    2 |       1 B |          NA |
| InterfaceMethod |   598.3 μs |  7.01 μs |  6.55 μs |  1.63 |    0.03 |    2 |       1 B |          NA |
| DynamicMethod   | 3,866.8 μs | 18.68 μs | 16.56 μs | 10.56 |    0.18 |    3 |       2 B |          NA |
