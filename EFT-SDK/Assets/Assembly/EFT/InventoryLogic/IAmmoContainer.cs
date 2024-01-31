using System;
using System.Collections.Generic;
using JetBrains.Annotations;

namespace EFT.InventoryLogic
{
	// Token: 0x020024AB RID: 9387
	public interface IAmmoContainer
	{
		// Token: 0x1700217B RID: 8571
		// (get) Token: 0x0600BC0C RID: 48140
		StackSlot Cartridges { get; }

		// Token: 0x1700217C RID: 8572
		// (get) Token: 0x0600BC0D RID: 48141
		int Count { get; }

		// Token: 0x1700217D RID: 8573
		// (get) Token: 0x0600BC0E RID: 48142
		IEnumerable<IContainer> Containers { get; }

		// Token: 0x0600BC0F RID: 48143
		[CanBeNull]
		IContainer GetContainer(string containerId);

		// Token: 0x0600BC10 RID: 48144
		BulletClass GetBulletAtPosition(int index);
	}
}
