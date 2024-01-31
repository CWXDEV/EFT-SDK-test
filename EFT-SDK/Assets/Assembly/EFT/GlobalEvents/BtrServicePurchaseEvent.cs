using System;
using System.Runtime.CompilerServices;

namespace EFT.GlobalEvents
{
	// Token: 0x0200262B RID: 9771
	public sealed class BtrServicePurchaseEvent : BaseSyncEvent
	{
		// Token: 0x0600C219 RID: 49689 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Invoke(int[] playerIds, ETraderServiceType serviceType)
		{
			throw null;
		}

		// Token: 0x0600C21A RID: 49690 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Serialize(ref GInterface79 writerStream)
		{
			throw null;
		}

		// Token: 0x0600C21B RID: 49691 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Deserialize(ref GInterface76 readerStream)
		{
			throw null;
		}

		// Token: 0x0600C21C RID: 49692 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Reset()
		{
			throw null;
		}

		// Token: 0x0400C3ED RID: 50157
		public int[] PlayerIds;

		// Token: 0x0400C3EE RID: 50158
		public ETraderServiceType ServiceType;
	}
}
