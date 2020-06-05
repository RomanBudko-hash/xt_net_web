using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._2.CUSTOM_PAINT
{
	public class Round : CircleShape
	{
		public int area { get; }

		public CircleShape(int x, int y, int insideRadius) : base(x, y, insideRadius)
		{
			this.insideRadius = insideRadius;
		}

		public void FindToArea(int insideRadius)
        {
			area = insideRadius * Math.PI * insideRadius;
        }

		public override void ShowInfo()
		{

		}
	}
}