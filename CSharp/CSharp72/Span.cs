using ConsoleDump;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace CSharp72
{
    //public readonly ref struct Span2<T>
    //{
    //    readonly ref T _pointer = null;
    //    readonly int _length;
    //    public ref T this[int index] => ...
    //}

    partial class Program
    {
        public static void RunSpan()
        {
            var arr = new int[] { 1, 2, 3, 4 };
            // implict
            Span<int> span = arr;
            Span<int> span2 = new Span<int>(arr);
            
            span.Slice(1).ToArray().Dump();
        }
    }
}
