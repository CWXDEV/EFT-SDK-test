using System;
using Newtonsoft.Json;

namespace EFT.Vehicle
{
	// Token: 0x02002677 RID: 9847
	[Serializable]
	public struct BTRMapPath
	{
		// Token: 0x0400C538 RID: 50488
		public string mapID;

		// Token: 0x0400C539 RID: 50489
		[JsonProperty("pathsConfigurations")]
		public PathConfig[] pathsConfigurations;
	}
}
