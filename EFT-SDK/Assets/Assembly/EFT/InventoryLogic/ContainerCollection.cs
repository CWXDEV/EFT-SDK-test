using System;
using System.Collections.Generic;
using JetBrains.Annotations;

namespace EFT.InventoryLogic
{
	// Token: 0x020022BA RID: 8890
	public abstract class ContainerCollection : Item
	{
		// Token: 0x17001ED1 RID: 7889
		// (get) Token: 0x0600B4A1 RID: 46241
		public abstract IEnumerable<IContainer> Containers { get; }

		// Token: 0x0600B4A2 RID: 46242
		[CanBeNull]
		public abstract IContainer GetContainer(string containerId);

		// Token: 0x0600B4A3 RID: 46243
		public abstract Item FindItem(string itemId);
	}
}
