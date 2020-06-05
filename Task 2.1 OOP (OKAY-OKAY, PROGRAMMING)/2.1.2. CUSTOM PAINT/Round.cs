using System;

namespace _2._1._2.CUSTOM_PAINT
{
	public class Round : CircleShape
	{
		public int area { get; }

		public void FindToArea(int insideRadius)
        {
			area = insideRadius * Math.PI * insideRadius;
        }

		public override void ShowInfo()
		{

		}
	}
}