using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Comfort.Common;
using EFT;
using EFT.InventoryLogic;
using JetBrains.Annotations;

// Token: 0x02002EEC RID: 12012
public sealed class GClass3184
{
	// Token: 0x170028BC RID: 10428
	// (get) Token: 0x0600ED21 RID: 60705 RVA: 0x00002050 File Offset: 0x00000250
	private Dictionary<MongoID, GClass3183> Dictionary_0
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170028BD RID: 10429
	[CanBeNull]
	public GClass3183 this[MongoID id]
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600ED23 RID: 60707 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GClass3183 FindByName(string name)
	{
		throw null;
	}

	// Token: 0x0600ED24 RID: 60708 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddItemPresets(GClass1200[] itemPresets)
	{
		throw null;
	}

	// Token: 0x0600ED25 RID: 60709 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GClass3183 FindBuild(Item item)
	{
		throw null;
	}

	// Token: 0x0600ED26 RID: 60710 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private GClass3183 method_0(GClass1200 preset)
	{
		throw null;
	}

	// Token: 0x0600ED27 RID: 60711 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private GClass2884 method_1(GClass3183 build)
	{
		throw null;
	}

	// Token: 0x0600ED28 RID: 60712 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<IResult> SaveBuild(GClass3183 build)
	{
		throw null;
	}

	// Token: 0x0600ED29 RID: 60713 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2(GClass3183 weaponBuild)
	{
		throw null;
	}

	// Token: 0x0600ED2A RID: 60714 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<IResult> RemoveBuild(MongoID buildId)
	{
		throw null;
	}

	// Token: 0x0600ED2B RID: 60715 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3(MongoID buildId)
	{
		throw null;
	}

	// Token: 0x0600ED2C RID: 60716 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4(GClass3183 build)
	{
		throw null;
	}

	// Token: 0x0400F221 RID: 61985
	[CompilerGenerated]
	private readonly Dictionary<MongoID, GClass3183> dictionary_0;

	// Token: 0x0400F222 RID: 61986
	private readonly ISession ginterface145_0;

	// Token: 0x0400F223 RID: 61987
	private readonly GClass2881 gclass2881_0;

	// Token: 0x02002EED RID: 12013
	[CompilerGenerated]
	private sealed class Class2961
	{
		// Token: 0x0600ED2D RID: 60717 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(KeyValuePair<MongoID, GClass3183> x)
		{
			throw null;
		}

		// Token: 0x0400F224 RID: 61988
		public string name;
	}

	// Token: 0x02002EEE RID: 12014
	[CompilerGenerated]
	[Serializable]
	private sealed class Class2962
	{
		// Token: 0x0600ED2E RID: 60718 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(Item x)
		{
			throw null;
		}

		// Token: 0x0600ED2F RID: 60719 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string method_1(Item x)
		{
			throw null;
		}

		// Token: 0x0400F225 RID: 61989
		public static readonly GClass3184.Class2962 class2962_0;

		// Token: 0x0400F226 RID: 61990
		public static Func<Item, bool> func_0;

		// Token: 0x0400F227 RID: 61991
		public static Func<Item, string> func_1;
	}
}
