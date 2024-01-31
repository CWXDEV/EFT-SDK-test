using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;
using EFT.Interactive;
using UnityEngine;

namespace CommonAssets.Scripts.Game
{
	// Token: 0x02001047 RID: 4167
	public sealed class EndByExitTrigerScenario : MonoBehaviour
	{
		// Token: 0x06005702 RID: 22274 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static EndByExitTrigerScenario Create(EndByExitTrigerScenario.GInterface87 game)
		{
			throw null;
		}

		// Token: 0x06005703 RID: 22275 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Run()
		{
			throw null;
		}

		// Token: 0x06005704 RID: 22276 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Stop()
		{
			throw null;
		}

		// Token: 0x06005705 RID: 22277 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(ExfiltrationPoint trigger, Player player)
		{
			throw null;
		}

		// Token: 0x06005706 RID: 22278 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(ExfiltrationPoint trigger, Player player)
		{
			throw null;
		}

		// Token: 0x06005707 RID: 22279 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(ExfiltrationPoint point, EExfiltrationStatus prevStatus)
		{
			throw null;
		}

		// Token: 0x06005708 RID: 22280 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x040062DC RID: 25308
		private EndByExitTrigerScenario.GInterface87 ginterface87_0;

		// Token: 0x040062DD RID: 25309
		private ExfiltrationPoint[] exfiltrationPoint_0;

		// Token: 0x040062DE RID: 25310
		private readonly List<EndByExitTrigerScenario.Class799> list_0;

		// Token: 0x040062DF RID: 25311
		private readonly List<ValueTuple<Player, string>> list_1;

		// Token: 0x040062E0 RID: 25312
		private readonly List<ExfiltrationPoint> list_2;

		// Token: 0x02001048 RID: 4168
		private sealed class Class799
		{
			// Token: 0x040062E1 RID: 25313
			public readonly Player Player;

			// Token: 0x040062E2 RID: 25314
			public readonly ExfiltrationPoint Trigger;

			// Token: 0x040062E3 RID: 25315
			public readonly float StartTime;
		}

		// Token: 0x02001049 RID: 4169
		public interface GInterface87 : GInterface100
		{
			// Token: 0x06005709 RID: 22281
			void StopSession(string profileId, ExitStatus exitStatus, string exitName);
		}

		// Token: 0x0200104A RID: 4170
		[CompilerGenerated]
		private sealed class Class800
		{
			// Token: 0x0600570A RID: 22282 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(EndByExitTrigerScenario.Class799 x)
			{
				throw null;
			}

			// Token: 0x040062E4 RID: 25316
			public Player player;
		}

		// Token: 0x0200104B RID: 4171
		[CompilerGenerated]
		private sealed class Class801
		{
			// Token: 0x0600570B RID: 22283 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(EndByExitTrigerScenario.Class799 x)
			{
				throw null;
			}

			// Token: 0x040062E5 RID: 25317
			public Player player;
		}
	}
}
