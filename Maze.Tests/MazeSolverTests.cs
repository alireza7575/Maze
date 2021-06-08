using System;
using NUnit.Framework;

namespace Maze.Tests
{
	public class MazeSolverTests
	{
		[Test]
		public void SolveMazeSize5() =>
			Assert.That(MazeSolver.Spiralize(5),
				Is.EqualTo(new[,]
				{
					{ 1, 1, 1, 1, 1 },
					{ 0, 0, 0, 0, 1 },
					{ 1, 1, 1, 0, 1 },
					{ 1, 0, 0, 0, 1 },
					{ 1, 1, 1, 1, 1 }
				}), PrintSpiral(MazeSolver.Spiralize(5)));

		private static string PrintSpiral(int[,] spiral)
		{
			var result = "\n";
			for (var y = 0; y < spiral.GetLength(0); y++)
			{
				string line = "";
				for (var x = 0; x < spiral.GetLength(1); x++)
					line += spiral[y, x] + ",";
				result += line + Environment.NewLine;
			}
			return result;
		}

		[Test]
		public void SolveMazeSize8() =>
			Assert.That(MazeSolver.Spiralize(8),
				Is.EqualTo(new[,]
				{
					{ 1, 1, 1, 1, 1, 1, 1, 1 },
					{ 0, 0, 0, 0, 0, 0, 0, 1 },
					{ 1, 1, 1, 1, 1, 1, 0, 1 },
					{ 1, 0, 0, 0, 0, 1, 0, 1 },
					{ 1, 0, 1, 0, 0, 1, 0, 1 },
					{ 1, 0, 1, 1, 1, 1, 0, 1 },
					{ 1, 0, 0, 0, 0, 0, 0, 1 },
					{ 1, 1, 1, 1, 1, 1, 1, 1 }
				}));

		[Test]
		public void SolveMazeSize9() =>
			Assert.That(MazeSolver.Spiralize(9),
				Is.EqualTo(new[,]
				{
					{ 1, 1, 1, 1, 1, 1, 1, 1, 1 },
					{ 0, 0, 0, 0, 0, 0, 0, 0, 1 },
					{ 1, 1, 1, 1, 1, 1, 1, 0, 1 },
					{ 1, 0, 0, 0, 0, 0, 1, 0, 1 },
					{ 1, 0, 1, 1, 1, 0, 1, 0, 1 },
					{ 1, 0, 1, 0, 0, 0, 1, 0, 1 },
					{ 1, 0, 1, 1, 1, 1, 1, 0, 1 },
					{ 1, 0, 0, 0, 0, 0, 0, 0, 1 },
					{ 1, 1, 1, 1, 1, 1, 1, 1, 1 }
				}));

		[Test]
		public void InvalidInput() =>
			Assert.That(() => MazeSolver.Spiralize(4),
				Throws.InstanceOf<MazeSolver.InvalidSize>()!);
	}
}