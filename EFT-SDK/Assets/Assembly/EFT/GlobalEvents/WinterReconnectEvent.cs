using System;
using System.Runtime.CompilerServices;

namespace EFT.GlobalEvents
{
	// Token: 0x02002656 RID: 9814
	public sealed class WinterReconnectEvent : BaseSyncEvent
	{
		// Token: 0x170022CD RID: 8909
		// (get) Token: 0x0600C2A6 RID: 49830 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600C2A7 RID: 49831 RVA: 0x00002050 File Offset: 0x00000250
		public EWinterStatus WinterStatus
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

		// Token: 0x170022CE RID: 8910
		// (get) Token: 0x0600C2A8 RID: 49832 RVA: 0x00002050 File Offset: 0x00000250
		private LoggerClass Logger
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600C2A9 RID: 49833 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Invoke(int playerID, EWinterStatus winterStatus)
		{
			throw null;
		}

		// Token: 0x0600C2AA RID: 49834 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Serialize(ref GInterface79 stream)
		{
			throw null;
		}

		// Token: 0x0600C2AB RID: 49835 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Deserialize(ref GInterface76 stream)
		{
			throw null;
		}

		// Token: 0x0600C2AC RID: 49836 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Reset()
		{
			throw null;
		}

		// Token: 0x0400C473 RID: 50291
		public int PlayerID;
	}
}
