using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x020028DA RID: 10458
	[CreateAssetMenu(fileName = "ChatSpecialIconSettings", menuName = "EFT/Create ChatSpecialIconSettings object", order = 0)]
	public sealed class ChatSpecialIconSettings : ScriptableObject
	{
		// Token: 0x0600D0D8 RID: 53464 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChatSpecialIconSettings.IconsData GetDataByMemberCategory(EMemberCategory category)
		{
			throw null;
		}

		// Token: 0x0400D1AC RID: 53676
		private static readonly EMemberCategory[] ememberCategory_0;

		// Token: 0x0400D1AD RID: 53677
		public EMemberCategory[] Priority;

		// Token: 0x0400D1AE RID: 53678
		public ChatSpecialIconSettings.IconsData[] IconsSettings;

		// Token: 0x0400D1AF RID: 53679
		private readonly SortedList<int, EMemberCategory> sortedList_0;

		// Token: 0x020028DB RID: 10459
		[Serializable]
		public class IconsData
		{
			// Token: 0x0400D1B0 RID: 53680
			public string Name;

			// Token: 0x0400D1B1 RID: 53681
			public EMemberCategory Category;

			// Token: 0x0400D1B2 RID: 53682
			public Sprite IconSprite;

			// Token: 0x0400D1B3 RID: 53683
			public Color IconColor;
		}

		// Token: 0x020028DC RID: 10460
		[CompilerGenerated]
		private sealed class Class2378
		{
			// Token: 0x0600D0D9 RID: 53465 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(ChatSpecialIconSettings.IconsData t)
			{
				throw null;
			}

			// Token: 0x0400D1B4 RID: 53684
			public EMemberCategory targetCategory;
		}
	}
}
