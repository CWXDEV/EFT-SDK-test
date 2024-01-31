using System;
using System.Runtime.CompilerServices;

namespace EFT
{
	// Token: 0x02001603 RID: 5635
	[Serializable]
	public class AreaInfo
	{
		// Token: 0x17001340 RID: 4928
		// (get) Token: 0x06007A8B RID: 31371 RVA: 0x00002050 File Offset: 0x00000250
		public EAreaType AreaType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04007FA5 RID: 32677
		public bool active;

		// Token: 0x04007FA6 RID: 32678
		public int type;

		// Token: 0x04007FA7 RID: 32679
		public int level;

		// Token: 0x04007FA8 RID: 32680
		public int? completeTime;

		// Token: 0x04007FA9 RID: 32681
		public bool constructing;

		// Token: 0x04007FAA RID: 32682
		public bool passiveBonusesEnabled;

		// Token: 0x04007FAB RID: 32683
		public string lastRecipe;

		// Token: 0x04007FAC RID: 32684
		public GClass1404[] bonuses;

		// Token: 0x04007FAD RID: 32685
		public GClass1907[] slots;
	}
}
