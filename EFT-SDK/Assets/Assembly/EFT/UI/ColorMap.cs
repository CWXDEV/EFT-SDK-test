using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x02002C34 RID: 11316
	[Serializable]
	public class ColorMap
	{
		// Token: 0x170026F1 RID: 9969
		public Color this[string key]
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170026F2 RID: 9970
		public Color this[Enum key]
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0400E3DF RID: 58335
		[SerializeField]
		private ColorMap.Data[] _items;

		// Token: 0x02002C35 RID: 11317
		[Serializable]
		public class Data
		{
			// Token: 0x0400E3E0 RID: 58336
			public string Id;

			// Token: 0x0400E3E1 RID: 58337
			public Color Item;
		}
	}
}
