using System;
using NUnit.Framework;

namespace Maze.Tests
{
    public class Tests
    {
        [Test]
        public void Test5() =>
            Assert.That(MazeClass.Spiralize(5), Is.EqualTo((new int[,]{
                { 1, 1, 1, 1, 1},
                { 0, 0, 0, 0, 1},
                { 1, 1, 1, 0, 1},
                { 1, 0, 0, 0, 1},
                { 1, 1, 1, 1, 1},
            })));

        [Test]
        public void Test8() =>
            Assert.That(MazeClass.Spiralize(8), Is.EqualTo((new int[,]{
                {1, 1, 1, 1, 1, 1, 1, 1},
                {0, 0, 0, 0, 0, 0, 0, 1},
                {1, 1, 1, 1, 1, 1, 0, 1},
                {1, 0, 0, 0, 0, 1, 0, 1},
                {1, 0, 1, 0, 0, 1, 0, 1},
                {1, 0, 1, 1, 1, 1, 0, 1},
                {1, 0, 0, 0, 0, 0, 0, 1},
                {1, 1, 1, 1, 1, 1, 1, 1},
            })));

        [Test]
        public void Test9() =>
            Assert.That(MazeClass.Spiralize(9), Is.EqualTo((new int[,]{
                {1, 1, 1, 1, 1, 1, 1, 1,1},
                {0, 0, 0, 0, 0, 0, 0, 0,1},
                {1, 1, 1, 1, 1, 1, 1, 0,1},
                {1, 0, 0, 0, 0, 0, 1, 0,1},
                {1, 0, 1, 1, 1, 0, 1, 0,1},
                {1, 0, 1, 0, 0, 0, 1, 0,1},
                {1, 0, 1, 1, 1, 1, 1, 0,1},
                {1, 0, 0, 0, 0, 0, 0, 0,1},
                {1, 1, 1, 1, 1, 1, 1, 1,1},
            })));

        [Test]
        public void InvalidInput() => Assert.That( () => MazeClass.Spiralize(4), Throws.InstanceOf<MazeClass.InvalidSize>());
    }
}