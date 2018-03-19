using Nauka;
using NUnit.Framework;
using System;

namespace Sort.Tests
{
    [TestFixture]
    public class SortTests<T> where T : Operations
    {
        [Test]
        public void SortTableSortedTable()
        {
            Operations operations = (T)Activator.CreateInstance(typeof(T), new object[] { (int)5, new int[] { 5, 3, 1, 2, 4 } });
            var sortedTab = operations.Sort();
            Assert.AreEqual(new int[] { 1, 2, 3, 4, 5 }, sortedTab);
        }
    }
}
