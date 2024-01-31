using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.GlobalEvents
{
	// Token: 0x02002650 RID: 9808
	public sealed class SyncClientEventState : BaseSyncEvent
	{
		// Token: 0x0600C29D RID: 49821 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Invoke(int playerId, EEventState eventState, double eventStartTimestamp, Vector3 ritualPosition, double gameInitialTime, string exitName)
		{
			throw null;
		}

		// Token: 0x0600C29E RID: 49822 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Serialize(ref GInterface79 writerStream)
		{
			throw null;
		}

		// Token: 0x0600C29F RID: 49823 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Deserialize(ref GInterface76 readerStream)
		{
			throw null;
		}

		// Token: 0x0600C2A0 RID: 49824 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Reset()
		{
			throw null;
		}

		// Token: 0x0400C43D RID: 50237
		public int PlayerID;

		// Token: 0x0400C43E RID: 50238
		public double GameInitialTime;

		// Token: 0x0400C43F RID: 50239
		public double EventStartTimestamp;

		// Token: 0x0400C440 RID: 50240
		public EEventState EventState;

		// Token: 0x0400C441 RID: 50241
		public Vector3 RitualPosition;

		// Token: 0x0400C442 RID: 50242
		public string ExitName;
	}
}
