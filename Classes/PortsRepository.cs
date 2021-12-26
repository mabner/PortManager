using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PortManager.Classes;
using PortManager.Interface;

namespace PortManager
{
	public class PortsRepository : IPorts<Ports>
	{
		private List<Ports> listPorts = new List<Ports>();
		public void AddPort(Ports portRange)
		{
			throw new NotImplementedException();
		}

		public void RemovePort(Ports portRange)
		{
			throw new NotImplementedException();
		}

		public void RestartPorts(Ports portRange)
		{
			throw new NotImplementedException();
		}

		public List<Ports> ListPorts()
		{
			throw new NotImplementedException();
		}
	}
}