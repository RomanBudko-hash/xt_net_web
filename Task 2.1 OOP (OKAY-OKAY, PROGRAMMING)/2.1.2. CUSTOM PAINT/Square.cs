using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._2.CUSTOM_PAINT
{
	public class Square : Figure
	{
		public int side { get; }

		public CircleShape(int x, int y, int side) : base(x, y, side)
		{
			this.side = side;
		}

	}
}