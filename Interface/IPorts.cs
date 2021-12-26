using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortManager.Interface
{
	public interface IPorts<P>
	{
		void AddPort(P portRange);
		void RemovePort(P portRange);
		void RestartPorts(P portRange);
		List<P> ListPorts();

	}
}