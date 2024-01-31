using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EFT;
using EFT.InventoryLogic;
using UnityEngine;

// Token: 0x02000C75 RID: 3189
public class GClass913
{
	// Token: 0x0600451B RID: 17691 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DisposeBody()
	{
		throw null;
	}

	// Token: 0x0600451C RID: 17692 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<PlayerBody> Show(GClass821 playerIconRequest)
	{
		throw null;
	}

	// Token: 0x0600451D RID: 17693 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_0(EquipmentClass equipment)
	{
		throw null;
	}

	// Token: 0x0600451E RID: 17694 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1()
	{
		throw null;
	}

	// Token: 0x0600451F RID: 17695 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Item method_2(EquipmentClass equipment)
	{
		throw null;
	}

	// Token: 0x06004520 RID: 17696 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private ResourceKey method_3(string x)
	{
		throw null;
	}

	// Token: 0x06004521 RID: 17697 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_4(ResourceKey x)
	{
		throw null;
	}

	// Token: 0x06004522 RID: 17698 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private string method_5(KeyValuePair<EBodyModelPart, string> x)
	{
		throw null;
	}

	// Token: 0x06004523 RID: 17699 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_6(string x)
	{
		throw null;
	}

	// Token: 0x06004524 RID: 17700 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_7(string x)
	{
		throw null;
	}

	// Token: 0x04004F54 RID: 20308
	private const int int_0 = -1;

	// Token: 0x04004F55 RID: 20309
	private const int int_1 = 0;

	// Token: 0x04004F56 RID: 20310
	private const int int_2 = 1;

	// Token: 0x04004F57 RID: 20311
	private const int int_3 = 2;

	// Token: 0x04004F58 RID: 20312
	private const int int_4 = 3;

	// Token: 0x04004F59 RID: 20313
	private WeaponPrefab weaponPrefab_0;

	// Token: 0x04004F5A RID: 20314
	private IAnimator ianimator_0;

	// Token: 0x04004F5B RID: 20315
	private GInterface99 ginterface99_0;

	// Token: 0x04004F5C RID: 20316
	private MenuPlayerPoser menuPlayerPoser_0;

	// Token: 0x04004F5D RID: 20317
	private PlayerBody playerBody_0;

	// Token: 0x04004F5E RID: 20318
	private GameObject gameObject_0;

	// Token: 0x04004F5F RID: 20319
	private GClass1441 gclass1441_0;

	// Token: 0x04004F60 RID: 20320
	private IEasyAssets ginterface394_0;

	// Token: 0x04004F61 RID: 20321
	private GClass1752 gclass1752_0;

	// Token: 0x04004F62 RID: 20322
	private PoolManager gclass1795_0;

	// Token: 0x04004F63 RID: 20323
	private Animator animator_0;

	// Token: 0x04004F64 RID: 20324
	private readonly HashSet<string> hashSet_0;

	// Token: 0x04004F65 RID: 20325
	private readonly List<DependencyGraph<IEasyBundle>.GClass3388> list_0;

	// Token: 0x02000C77 RID: 3191
	[CompilerGenerated]
	[Serializable]
	private sealed class Class639
	{
		// Token: 0x06004527 RID: 17703 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string method_0(ResourceKey x)
		{
			throw null;
		}

		// Token: 0x06004528 RID: 17704 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string method_1(Item x)
		{
			throw null;
		}

		// Token: 0x06004529 RID: 17705 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_2(Slot x)
		{
			throw null;
		}

		// Token: 0x0600452A RID: 17706 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_3(Item x)
		{
			throw null;
		}

		// Token: 0x04004F6D RID: 20333
		public static readonly GClass913.Class639 class639_0;

		// Token: 0x04004F6E RID: 20334
		public static Func<ResourceKey, string> func_0;

		// Token: 0x04004F6F RID: 20335
		public static Func<Item, string> func_1;

		// Token: 0x04004F70 RID: 20336
		public static Func<Slot, Item> func_2;

		// Token: 0x04004F71 RID: 20337
		public static Func<Item, bool> func_3;
	}
}
