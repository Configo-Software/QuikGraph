namespace QuickGraph.Collections
{
    public static partial class FibonacciHeapFactory
    {
        public static FibonacciHeap<int, int> Create()
        {
            FibonacciHeap<int, int> fibonacciHeap
               = new FibonacciHeap<int, int>();
            return fibonacciHeap;
        }
    }
}
