using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.Vehicle
{
	// Token: 0x02002661 RID: 9825
	[Serializable]
	public class BTRPlace
	{
		// Token: 0x170022D2 RID: 8914
		// (get) Token: 0x0600C2EB RID: 49899 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600C2EC RID: 49900 RVA: 0x00002050 File Offset: 0x00000250
		public BTRPlace.EState State
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x0600C2ED RID: 49901 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SyncStateFromServer(byte state)
		{
			throw null;
		}

		// Token: 0x140002C4 RID: 708
		// (add) Token: 0x0600C2EE RID: 49902 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600C2EF RID: 49903 RVA: 0x00002050 File Offset: 0x00000250
		public event Action OnStateChanged
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x0400C4A5 RID: 50341
		public Transform Point;

		// Token: 0x02002662 RID: 9826
		public enum EState : byte
		{
			// Token: 0x0400C4A9 RID: 50345
			Free,
			// Token: 0x0400C4AA RID: 50346
			Occupied
		}
	}
}
