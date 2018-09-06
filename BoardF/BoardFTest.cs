/*
 * Created by SharpDevelop.
 * User: User
 * Date: 06.09.2018
 * Time: 16:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using NUnit.Framework;

namespace BoardF
{
	[TestFixture]
	public class BoardFTest
	{
/*
		[Test]
		public GameTest (int size)
		{

		}*/
		[Test]
		public void StartTest ()
		{
			Game game = new Game(4);
			game.Start();
			Assert.AreEqual (1, game.GetDigitAt (0,0));
			
		}
		[Test]
		public int PressAtTest ()
		{

		}
		[Test]
		public int GetDigitAtTest ()
		{

		}
		[Test]
		public bool SolvedTest()
		{

		}
	}
}
