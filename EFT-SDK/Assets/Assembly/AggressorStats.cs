using System;
using System.Runtime.CompilerServices;
using EFT;

// Token: 0x0200075A RID: 1882
[Serializable]
public class AggressorStats : IProfileDataContainer
{
	// Token: 0x170007F7 RID: 2039
	// (get) Token: 0x06002C64 RID: 11364 RVA: 0x00002050 File Offset: 0x00000250
	string IProfileDataContainer.ProfileId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170007F8 RID: 2040
	// (get) Token: 0x06002C65 RID: 11365 RVA: 0x00002050 File Offset: 0x00000250
	string IProfileDataContainer.Nickname
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170007F9 RID: 2041
	// (get) Token: 0x06002C66 RID: 11366 RVA: 0x00002050 File Offset: 0x00000250
	EPlayerSide IProfileDataContainer.Side
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06002C67 RID: 11367 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		throw null;
	}

	// Token: 0x04002AF2 RID: 10994
	public string AccountId;

	// Token: 0x04002AF3 RID: 10995
	public string ProfileId;

	// Token: 0x04002AF4 RID: 10996
	public string MainProfileNickname;

	// Token: 0x04002AF5 RID: 10997
	public string Name;

	// Token: 0x04002AF6 RID: 10998
	public EPlayerSide Side;

	// Token: 0x04002AF7 RID: 10999
	public EBodyPartColliderType ColliderType;

	// Token: 0x04002AF8 RID: 11000
	public string WeaponName;

	// Token: 0x04002AF9 RID: 11001
	public EMemberCategory Category;
}
