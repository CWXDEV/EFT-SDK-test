using System;

namespace EFT
{
	// Token: 0x02001695 RID: 5781
	[Flags]
	public enum ResourceType
	{
		// Token: 0x040083D5 RID: 33749
		Ammo = 1,
		// Token: 0x040083D6 RID: 33750
		Weapon = 2,
		// Token: 0x040083D7 RID: 33751
		Magazine = 4,
		// Token: 0x040083D8 RID: 33752
		Item = 8,
		// Token: 0x040083D9 RID: 33753
		UsablePrefab = 16,
		// Token: 0x040083DA RID: 33754
		Player = 32,
		// Token: 0x040083DB RID: 33755
		WeaponModItem = 64,
		// Token: 0x040083DC RID: 33756
		SynchronizableObject = 128,
		// Token: 0x040083DD RID: 33757
		StationaryWeaponMagazine = 256,
		// Token: 0x040083DE RID: 33758
		Other = 512
	}
}
