using System;
using System.Runtime.CompilerServices;
using EFT.Vehicle;

namespace EFT.GlobalEvents
{
	// Token: 0x02002628 RID: 9768
	public sealed class BtrNotificationInteractionMessageEvent : BaseSyncEvent
	{
		// Token: 0x0600C20C RID: 49676 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Invoke(int playerId, EBtrInteractionStatus interactionStatus)
		{
			throw null;
		}

		// Token: 0x0600C20D RID: 49677 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Serialize(ref GInterface79 writerStream)
		{
			throw null;
		}

		// Token: 0x0600C20E RID: 49678 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Deserialize(ref GInterface76 readerStream)
		{
			throw null;
		}

		// Token: 0x0600C20F RID: 49679 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Reset()
		{
			throw null;
		}

		// Token: 0x0400C3EA RID: 50154
		public int PlayerId;

		// Token: 0x0400C3EB RID: 50155
		public EBtrInteractionStatus InteractionStatus;
	}
}
