namespace Schema.NET.Benchmarks
{
    using System;
    using BenchmarkDotNet.Running;

    internal class Program
    {
        private static void Main(string[] args) => BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
    }
}
