// <copyright file="BinaryHeapTPriorityTValueTest.InsertAndEnumerate.g.cs" company="MSIT">Copyright © MSIT 2007</copyright>
// <auto-generated>
// This file contains automatically generated unit tests.
// Do NOT modify this file manually.
// 
// When Pex is invoked again,
// it might remove or update any previously generated unit tests.
// 
// If the contents of this file becomes outdated, e.g. if it does not
// compile anymore, you may delete this file and invoke Pex again.
// </auto-generated>
using System.Collections.Generic;
using NUnit.Framework;

namespace QuickGraph.Collections
{
    internal partial class BinaryHeapTPriorityTValueTest
    {
[Test]
public void InsertAndEnumerate636()
{
    BinaryHeap<int, int> binaryHeap;
    binaryHeap = BinaryHeapFactory.Create(0);
    KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[0];
    this.InsertAndEnumerate<int, int>(binaryHeap, keyValuePairs);
    Assert.IsNotNull((object)binaryHeap);
    Assert.IsNotNull(binaryHeap.PriorityComparison);
    Assert.AreEqual(0, binaryHeap.Capacity);
    Assert.AreEqual(0, binaryHeap.Count);
}
[Test]
public void InsertAndEnumerate471()
{
    BinaryHeap<int, int> binaryHeap;
    binaryHeap = BinaryHeapFactory.Create(1);
    KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[1];
    this.InsertAndEnumerate<int, int>(binaryHeap, keyValuePairs);
    Assert.IsNotNull((object)binaryHeap);
    Assert.IsNotNull(binaryHeap.PriorityComparison);
    Assert.AreEqual(1, binaryHeap.Capacity);
    Assert.AreEqual(1, binaryHeap.Count);
}
[Test]
public void InsertAndEnumerate47101()
{
    BinaryHeap<int, int> binaryHeap;
    binaryHeap = BinaryHeapFactory.Create(0);
    KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[1];
    this.InsertAndEnumerate<int, int>(binaryHeap, keyValuePairs);
    Assert.IsNotNull((object)binaryHeap);
    Assert.IsNotNull(binaryHeap.PriorityComparison);
    Assert.AreEqual(1, binaryHeap.Capacity);
    Assert.AreEqual(1, binaryHeap.Count);
}
[Test]
public void InsertAndEnumerate707()
{
    BinaryHeap<int, int> binaryHeap;
    binaryHeap = BinaryHeapFactory.Create(1);
    KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[2];
    KeyValuePair<int, int> s0 = new KeyValuePair<int, int>(414277560, default(int));
    keyValuePairs[0] = s0;
    KeyValuePair<int, int> s1 = new KeyValuePair<int, int>(16384, 16384);
    keyValuePairs[1] = s1;
    this.InsertAndEnumerate<int, int>(binaryHeap, keyValuePairs);
    Assert.IsNotNull((object)binaryHeap);
    Assert.IsNotNull(binaryHeap.PriorityComparison);
    Assert.AreEqual(3, binaryHeap.Capacity);
    Assert.AreEqual(2, binaryHeap.Count);
}
[Test]
public void InsertAndEnumerate397()
{
    BinaryHeap<int, int> binaryHeap;
    binaryHeap = BinaryHeapFactory.Create(2);
    KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[2];
    KeyValuePair<int, int> s0 = new KeyValuePair<int, int>(995098625, default(int));
    keyValuePairs[0] = s0;
    KeyValuePair<int, int> s1 = new KeyValuePair<int, int>(16384, 16384);
    keyValuePairs[1] = s1;
    this.InsertAndEnumerate<int, int>(binaryHeap, keyValuePairs);
    Assert.IsNotNull((object)binaryHeap);
    Assert.IsNotNull(binaryHeap.PriorityComparison);
    Assert.AreEqual(2, binaryHeap.Capacity);
    Assert.AreEqual(2, binaryHeap.Count);
}
    }
}
