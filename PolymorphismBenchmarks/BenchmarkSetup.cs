using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;
using System;
using System.Runtime.CompilerServices;
using BenchmarkDotNet.Running;



[MemoryDiagnoser]
[Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
[RankColumn]
//[DisassemblyDiagnoser]
public class Benchmark
{
    private readonly Base _virtual = new Derived();
    private readonly ICompute _interface = new Implement();
    private readonly AbstractBase _abstract = new DerivedAbs();
    private readonly SealedImplement _sealed = new SealedImplement();
    private readonly MainBase _direct = new MainBase();
    private readonly dynamic _dynamic = new Implement();
    private readonly int IteratoinCount = 1000000;



    //[Benchmark(Baseline = true)]
    [Benchmark]
    public void DirectMethod()
    {
        for (int i = 0; i < IteratoinCount; i++)
        {
            _direct.Compute(i); 
            //Consumer.Consume(_direct.Compute(i));
        }
    }

    [Benchmark(Baseline = true)]

    public void StaticMethod()
    {
        for (int i = 0; i < IteratoinCount; i++)
        {
            StaticT.Compute(i); 
        }
    }
    
    [Benchmark]
    public void VirtualMethod()
    {
        for (int i = 0; i < IteratoinCount; i++)
        {
            _virtual.Compute(i); 
            //Consumer.Consume(_virtual.Compute(i));
        }
    }
    [Benchmark] 
    public void InterfaceMethod()
    {
        for (int i = 0; i < IteratoinCount; i++)
        {
            _interface.Compute(i); 
            //Consumer.Consume(_interface.Compute(i));
        }
    }
    [Benchmark]
    public void AbstractMethod()
    {
        for (int i = 0; i < IteratoinCount; i++)
        {
            _abstract.Compute(i);
            //Consumer.Consume(_abstract.Compute(i));
        }
    }

    [Benchmark]
    public void SealedMethod()
    {
        for (int i = 0; i < IteratoinCount; i++)
        {
            _sealed.Compute(i); 
            //Consumer.Consume(_sealed.Compute(i));
        }
    }
    [Benchmark]
    public void DynamicMethod()
    {
        for (int i = 0; i < IteratoinCount; i++)
        {
            _dynamic.Compute(i); 
            //Consumer.Consume(_dynamic.Compute(i));
        }
    }
}

public class MainBase
{
    //[MethodImpl(MethodImplOptions.NoInlining)]  
    public int Compute(int x) => x + 1;
}
public class Base
{
    //[MethodImpl(MethodImplOptions.NoInlining)] 
    public virtual int Compute(int x) => x + 1;
}

public class Derived : Base
{
    //[MethodImpl(MethodImplOptions.NoInlining)]  
    public override int Compute(int x) => x + 1;
}

public interface ICompute
{
    int Compute(int x);
}

public class Implement : ICompute
{
    //[MethodImpl(MethodImplOptions.NoInlining)] 
    public int Compute(int x) => x + 1;
}

public abstract class AbstractBase
{
    //[MethodImpl(MethodImplOptions.NoInlining)] 
    public abstract int Compute(int x);
}

public class DerivedAbs : AbstractBase
{
    //[MethodImpl(MethodImplOptions.NoInlining)] 
    public override int Compute(int x) => x + 1;
}

public sealed class SealedImplement
{
    //[MethodImpl(MethodImplOptions.NoInlining)]
    public int Compute(int x) => x + 1;
}
public class StaticT
{
    public static int Compute(int x) => x + 1;
}
// public static class Consumer
//{
 //   [MethodImpl(MethodImplOptions.NoInlining)]
 //   public static void Consume(int value) {}
//}




class Program
{
    static void Main(string[] args)
    {
        var summary = BenchmarkRunner.Run<Benchmark>();
    }
}





