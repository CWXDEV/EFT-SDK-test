using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;

namespace EFT.InventoryLogic
{
	// Token: 0x020022F2 RID: 8946
	public sealed class ItemFilter
	{
		// Token: 0x0600B54F RID: 46415 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool CheckItemFilter(Item item)
		{
			throw null;
		}

		// Token: 0x0600B550 RID: 46416 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool CheckItemExcludedFilter(Item item)
		{
			throw null;
		}

		// Token: 0x0600B551 RID: 46417 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool CheckItem(Item item, string[] acceptableNodes)
		{
			throw null;
		}

		// Token: 0x0600B552 RID: 46418 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(IEnumerable<ItemFilter> filters)
		{
			throw null;
		}

		// Token: 0x0400B8EE RID: 47342
		public bool locked;

		// Token: 0x0400B8EF RID: 47343
		public string[] Filter;

		// Token: 0x0400B8F0 RID: 47344
		[CanBeNull]
		public EBodyPartColliderType[] armorColliders;

		// Token: 0x0400B8F1 RID: 47345
		[CanBeNull]
		public EArmorPlateCollider[] armorPlateColliders;

		// Token: 0x0400B8F2 RID: 47346
		[CanBeNull]
		public string[] ExcludedFilter;
	}
}
