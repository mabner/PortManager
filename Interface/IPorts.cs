using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortManager.Interface
{
	public interface IPorts<Ports>
	{
		void AddPort(Ports portRange);
		void RemovePort(Ports portRange);
		void RestartPorts(Ports portRange);
		List<Ports> ListPorts();

	}
}