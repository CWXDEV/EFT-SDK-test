using System;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;

// Token: 0x020002FD RID: 765
public class BotWeaponInfo
{
	// Token: 0x170003DB RID: 987
	// (get) Token: 0x06001038 RID: 4152 RVA: 0x00002050 File Offset: 0x00000250
	public int BulletCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06001039 RID: 4153 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CheckHaveAmmoForReload()
	{
		throw null;
	}

	// Token: 0x04000F5F RID: 3935
	public Weapon weapon;

	// Token: 0x04000F60 RID: 3936
	public bool IsNowAutomatic;

	// Token: 0x04000F61 RID: 3937
	public BotReload Reload;
}
