using System;
using System.Runtime.CompilerServices;

namespace EFT.GlobalEvents
{
	// Token: 0x02002627 RID: 9767
	public class BtrIncomingToDestinationGlobalEvent : BaseSyncEvent
	{
		// Token: 0x1700229F RID: 8863
		// (get) Token: 0x0600C202 RID: 49666 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600C203 RID: 49667 RVA: 0x00002050 File Offset: 0x00000250
		public string PathID
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170022A0 RID: 8864
		// (get) Token: 0x0600C204 RID: 49668 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600C205 RID: 49669 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsAnyPassengerInGroupWithAggressor
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

		// Token: 0x170022A1 RID: 8865
		// (get) Token: 0x0600C206 RID: 49670 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600C207 RID: 49671 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsAnyEnemyNearBtr
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

		// Token: 0x0600C208 RID: 49672 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Invoke(string pathID, bool isAnyPassengerInGroupWithAggressor, bool isAnyEnemyNearBtr)
		{
			throw null;
		}

		// Token: 0x0600C209 RID: 49673 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Serialize(ref GInterface79 writerStream)
		{
			throw null;
		}

		// Token: 0x0600C20A RID: 49674 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Deserialize(ref GInterface76 readerStream)
		{
			throw null;
		}

		// Token: 0x0600C20B RID: 49675 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Reset()
		{
			throw null;
		}
	}
}
