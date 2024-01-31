using System;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;

namespace EFT.InventoryLogic
{
	// Token: 0x02002291 RID: 8849
	public class LockableComponent : GClass2750
	{
		// Token: 0x17001E83 RID: 7811
		// (get) Token: 0x0600B40E RID: 46094 RVA: 0x00002050 File Offset: 0x00000250
		public string[] KeyIds
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600B40F RID: 46095 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GStruct412 Apply(Item item, TraderControllerClass itemController, GClass2495[] grids, bool simulate)
		{
			throw null;
		}

		// Token: 0x0600B410 RID: 46096 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GStruct413<GClass2794> ApplyKey(KeyComponent key, [CanBeNull] InventoryControllerClass inventoryController)
		{
			throw null;
		}

		// Token: 0x0400B834 RID: 47156
		public bool Locked;

		// Token: 0x0400B835 RID: 47157
		private readonly GInterface294 ginterface294_0;

		// Token: 0x02002292 RID: 8850
		public class GClass3284 : InventoryError
		{
			// Token: 0x0600B411 RID: 46097 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override string ToString()
			{
				throw null;
			}

			// Token: 0x0600B412 RID: 46098 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override string GetLocalizedDescription()
			{
				throw null;
			}

			// Token: 0x0400B836 RID: 47158
			public readonly LockableComponent Lockable;

			// Token: 0x0400B837 RID: 47159
			public readonly KeyComponent Key;

			// Token: 0x02002293 RID: 8851
			[CompilerGenerated]
			[Serializable]
			private sealed class Class1957
			{
				// Token: 0x0600B413 RID: 46099 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal string method_0(string x)
				{
					throw null;
				}

				// Token: 0x0400B838 RID: 47160
				public static readonly LockableComponent.GClass3284.Class1957 class1957_0;

				// Token: 0x0400B839 RID: 47161
				public static Func<string, string> func_0;
			}
		}
	}
}
