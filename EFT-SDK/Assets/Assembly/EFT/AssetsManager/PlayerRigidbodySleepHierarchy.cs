using System;
using System.Runtime.CompilerServices;

namespace EFT.AssetsManager
{
	// Token: 0x02002864 RID: 10340
	[Serializable]
	public class PlayerRigidbodySleepHierarchy
	{
		// Token: 0x170024EA RID: 9450
		// (get) Token: 0x0600CE7D RID: 52861 RVA: 0x00002050 File Offset: 0x00000250
		public bool CanSleep
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600CE7E RID: 52862 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool TryPutToSleep()
		{
			throw null;
		}

		// Token: 0x0600CE7F RID: 52863 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Reset()
		{
			throw null;
		}

		// Token: 0x0600CE80 RID: 52864 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WakeUp()
		{
			throw null;
		}

		// Token: 0x0400CF36 RID: 53046
		public EBodyPartColliderType BodyPart;

		// Token: 0x0400CF37 RID: 53047
		public RigidbodySpawner RigidbodySpawner;

		// Token: 0x0400CF38 RID: 53048
		public PlayerRigidbodySleepHierarchy Parent;

		// Token: 0x0400CF39 RID: 53049
		public bool MustBeSleeping;
	}
}
