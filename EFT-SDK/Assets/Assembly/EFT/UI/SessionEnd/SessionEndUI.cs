using System;
using System.Runtime.CompilerServices;

namespace EFT.UI.SessionEnd
{
	// Token: 0x02002CE5 RID: 11493
	public sealed class SessionEndUI : MonoBehaviourSingleton<SessionEndUI>
	{
		// Token: 0x0600E21D RID: 57885 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Awake()
		{
			throw null;
		}

		// Token: 0x0600E21E RID: 57886 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnDestroy()
		{
			throw null;
		}

		// Token: 0x0400E6D9 RID: 59097
		public SessionResultExitStatus SessionResultExitStatus;

		// Token: 0x0400E6DA RID: 59098
		public SessionResultKillList SessionResultKillList;

		// Token: 0x0400E6DB RID: 59099
		public SessionResultStatistics SessionResultStatistics;

		// Token: 0x0400E6DC RID: 59100
		public SessionResultExperienceCount SessionResultExperienceCount;

		// Token: 0x0400E6DD RID: 59101
		public HealthTreatmentScreen HealthTreatmentScreen;

		// Token: 0x0400E6DE RID: 59102
		public OtherPlayerProfileScreen OtherPlayerProfileScreen;
	}
}
