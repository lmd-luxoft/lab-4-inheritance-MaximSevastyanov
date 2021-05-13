using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
	public class Rook : ChessFigure
	{
		public Rook(Type type, string currentCoord) : base(type, currentCoord)
        {

        }

		internal override bool Move(string nextCoord)
		{
			if ((nextCoord[0] != CurrentCoord[0]) && (nextCoord[1] != CurrentCoord[1]) || ((nextCoord[0] == CurrentCoord[0]) && (nextCoord[1] == CurrentCoord[1])))
				return false;
			else
				return true;
		}
	}
}
