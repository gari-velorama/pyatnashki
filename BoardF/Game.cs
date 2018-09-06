/*
 * Created by SharpDevelop.
 * User: User
 * Date: 06.09.2018
 * Time: 16:39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace BoardF
{
	/// <summary>
	/// Description of MyClass.
	/// </summary>
	public class Game
	{
		int size;

		public Game (int size)
		{
			this.size = size;
		}

		public void Start (int seed = 0)
		{

		}

		public int PressAt (int x, int y)
		{
			return 0;
		}
		
		public int GetDigitAt (int x, int y)
		{
			return 0;
		}
		
		public bool Solved()
		{
			return false;
		}
	}
}