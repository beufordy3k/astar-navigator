﻿using System;
using System.Collections.Generic;

namespace AStarNavigator
{
	public interface ITileNavigator
	{
		IEnumerable<Tile> Navigate(Tile from, Tile to, int maxAttempts = Int32.MaxValue);
	}
}