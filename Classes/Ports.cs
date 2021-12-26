using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortManager.Classes
{
	public class Ports
	{
		int[] portRange = { };
		public void PortRange(int firstPort, int lastPort)
		{
			portRange = new int[lastPort - firstPort + 1];
			for (int i = 0; i < portRange.Length; i++)
			{
				portRange[i] = firstPort + i;
			}

		}
	}
}