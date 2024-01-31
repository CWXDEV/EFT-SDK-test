using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002B23 RID: 11043
	public sealed class MasteringTooltip : Tooltip
	{
		// Token: 0x0600DAF0 RID: 56048 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(KeyValuePair<string, GClass1764> mastering)
		{
			throw null;
		}

		// Token: 0x0400DE39 RID: 56889
		[SerializeField]
		private CustomTextMeshProUGUI _name;

		// Token: 0x0400DE3A RID: 56890
		[SerializeField]
		private CustomTextMeshProUGUI _type;

		// Token: 0x0400DE3B RID: 56891
		[SerializeField]
		private Image _initialProgressFill;

		// Token: 0x0400DE3C RID: 56892
		[SerializeField]
		private CustomTextMeshProUGUI _level;

		// Token: 0x0400DE3D RID: 56893
		[SerializeField]
		private CustomTextMeshProUGUI _progress;

		// Token: 0x02002B24 RID: 11044
		[CompilerGenerated]
		private sealed class Class2596
		{
			// Token: 0x0600DAF1 RID: 56049 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0400DE3E RID: 56894
			public MasteringTooltip masteringTooltip_0;

			// Token: 0x0400DE3F RID: 56895
			public GClass1764 value;
		}
	}
}
