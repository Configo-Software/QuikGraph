using System;
using System.Collections.Generic;
using NUnit.Framework;
using QuickGraph.Algorithms.Observers;
using QuickGraph.Serialization;
using QuikGraph.Tests;

namespace QuickGraph.Algorithms.ShortestPath
{
    [TestFixture]
    internal class DagShortestPathAlgorithmTest : QuikGraphUnitTests
    {
        public void Compute<TVertex, TEdge>(IVertexListGraph<TVertex, TEdge> g)
            where TEdge : IEdge<TVertex>
        {
            // is this a dag ?
            bool isDag = AlgorithmExtensions.IsDirectedAcyclicGraph(g);

            var relaxer = DistanceRelaxers.ShortestDistance;
            var vertices = new List<TVertex>(g.Vertices);
            foreach (var root in vertices)
            {
                if (isDag)
                    Search(g, root, relaxer);
                else
                {
                    try
                    {
                        Search(g, root, relaxer);
                    }
                    catch (NonAcyclicGraphException)
                    {
                        Console.WriteLine("NonAcyclicGraphException caught (as expected)");
                    }
                }
            }
        }

        [Test]
        public void DagShortestPathAll()
        {
            foreach(var g in TestGraphFactory.GetAdjacencyGraphs())
            {
                this.Compute(g);
                this.ComputeCriticalPath(g);
            }
        }

        public void ComputeCriticalPath<TVertex, TEdge>(
            IVertexListGraph<TVertex, TEdge> g)
            where TEdge : IEdge<TVertex>
        {
            // is this a dag ?
            bool isDag = g.IsDirectedAcyclicGraph();

            var relaxer = DistanceRelaxers.CriticalDistance;
            var vertices = new List<TVertex>(g.Vertices);
            foreach (var root in vertices)
            {
                if (isDag)
                    Search(g, root, relaxer);
                else
                {
                    try
                    {
                        Search(g, root, relaxer);
                        Assert.Fail("should have found the acyclic graph");
                    }
                    catch (NonAcyclicGraphException)
                    {
                        Console.WriteLine("NonAcyclicGraphException caught (as expected)");
                    }
                }
            }
        }

        private void Search<TVertex, TEdge>(
            IVertexListGraph<TVertex, TEdge> g, 
            TVertex root, IDistanceRelaxer relaxer)
            where TEdge : IEdge<TVertex>
        {
            var algo =
                new DagShortestPathAlgorithm<TVertex, TEdge>(
                    g,
                    e => 1,
                    relaxer
                    );
            var predecessors = new VertexPredecessorRecorderObserver<TVertex, TEdge>();
            using(predecessors.Attach(algo))
                algo.Compute(root);

            Verify(algo, predecessors);
        }

        private static void Verify<TVertex, TEdge>(
            DagShortestPathAlgorithm<TVertex, TEdge> algo,
            VertexPredecessorRecorderObserver<TVertex, TEdge> predecessors)
            where TEdge : IEdge<TVertex>
        {
            // let's verify the result
            foreach (var v in algo.VisitedGraph.Vertices)
            {
                TEdge predecessor;
                if (!predecessors.VertexPredecessors.TryGetValue(v, out predecessor))
                    continue;
                if (predecessor.Source.Equals(v))
                    continue;
                Assert.AreEqual(
                    algo.Distances[v], algo.Distances[predecessor.Source] + 1
                    );
            }
        }
    }
}
