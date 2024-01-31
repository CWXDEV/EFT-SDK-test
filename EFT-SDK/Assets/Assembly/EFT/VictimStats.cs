using System;
using System.Runtime.CompilerServices;
using Diz.Binding;

namespace EFT
{
	// Token: 0x02001600 RID: 5632
	[Serializable]
	public class VictimStats : IUpdatable<VictimStats>, IProfileDataContainer
	{
		// Token: 0x1700133D RID: 4925
		// (get) Token: 0x06007A85 RID: 31365 RVA: 0x00002050 File Offset: 0x00000250
		string IProfileDataContainer.ProfileId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700133E RID: 4926
		// (get) Token: 0x06007A86 RID: 31366 RVA: 0x00002050 File Offset: 0x00000250
		string IProfileDataContainer.Nickname
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700133F RID: 4927
		// (get) Token: 0x06007A87 RID: 31367 RVA: 0x00002050 File Offset: 0x00000250
		EPlayerSide IProfileDataContainer.Side
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06007A88 RID: 31368 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Compare(VictimStats other)
		{
			throw null;
		}

		// Token: 0x06007A89 RID: 31369 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateFromAnotherItem(VictimStats other)
		{
			throw null;
		}

		// Token: 0x04007F92 RID: 32658
		public string AccountId;

		// Token: 0x04007F93 RID: 32659
		public string ProfileId;

		// Token: 0x04007F94 RID: 32660
		public string Name;

		// Token: 0x04007F95 RID: 32661
		public EPlayerSide Side;

		// Token: 0x04007F96 RID: 32662
		public TimeSpan Time;

		// Token: 0x04007F97 RID: 32663
		public int Level;

		// Token: 0x04007F98 RID: 32664
		public EBodyPart BodyPart;

		// Token: 0x04007F99 RID: 32665
		public string Weapon;

		// Token: 0x04007F9A RID: 32666
		public float Distance;

		// Token: 0x04007F9B RID: 32667
		public WildSpawnType Role;
	}
}
