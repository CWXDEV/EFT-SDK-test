using System;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x02002C4C RID: 11340
	[Serializable]
	public class SpriteMap
	{
		// Token: 0x1700270B RID: 9995
		[CanBeNull]
		public Sprite this[string key]
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700270C RID: 9996
		[CanBeNull]
		public Sprite this[Enum key]
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0400E448 RID: 58440
		[SerializeField]
		private SpriteMap.Data[] _sprites;

		// Token: 0x02002C4D RID: 11341
		[Serializable]
		public class Data
		{
			// Token: 0x0400E449 RID: 58441
			public string Id;

			// Token: 0x0400E44A RID: 58442
			public Sprite Sprite;
		}

		// Token: 0x02002C4E RID: 11342
		[CompilerGenerated]
		private sealed class Class2697
		{
			// Token: 0x0600DF88 RID: 57224 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(SpriteMap.Data item)
			{
				throw null;
			}

			// Token: 0x0400E44B RID: 58443
			public string key;
		}

		// Token: 0x02002C4F RID: 11343
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2698
		{
			// Token: 0x0600DF89 RID: 57225 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Sprite method_0(SpriteMap.Data item)
			{
				throw null;
			}

			// Token: 0x0400E44C RID: 58444
			public static readonly SpriteMap.Class2698 class2698_0;

			// Token: 0x0400E44D RID: 58445
			public static Func<SpriteMap.Data, Sprite> func_0;
		}
	}
}
