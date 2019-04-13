using NUnit.Framework;

namespace QuickGraph
{
    /// <summary>This class contains parameterized unit tests for EdgeEventArgs`2</summary>
    [TestFixture]
    internal partial class EdgeEventArgsTVertexTEdgeTest
    {
        /// <summary>Test stub for .ctor(!1)</summary>
        public EdgeEventArgs<TVertex, TEdge> Constructor<TVertex,TEdge>(TEdge edge)
            where TEdge : IEdge<TVertex>
        {
            // TODO: add assertions to method EdgeEventArgsTVertexTEdgeTest.Constructor(!!1)
            EdgeEventArgs<TVertex, TEdge> target = new EdgeEventArgs<TVertex, TEdge>(edge);
            return target;
        }

        /// <summary>Test stub for Edge</summary>
        public void EdgeGet<TVertex,TEdge>(EdgeEventArgs<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            // TODO: add assertions to method EdgeEventArgsTVertexTEdgeTest.EdgeGet(EdgeEventArgs`2<!!0,!!1>)
            TEdge result = target.Edge;
        }
    }
}
