using System;

namespace Clockwork
{
	class ClockWorking
	{
		public float GetDegrees(int min, int hour)
		{
			float degrees = 0;
            float minDegrees = min * 6;
            float hourDegrees = hour * 30 + min / 2;
            degrees = Math.Abs(minDegrees - hourDegrees);

			return degrees;
		}
		
	}
	
}