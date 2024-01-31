using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using EFT.Hideout;
using EFT.InventoryLogic;

// Token: 0x02001B0D RID: 6925
public abstract class GClass1919
{
	// Token: 0x1700163D RID: 5693
	// (get) Token: 0x0600923F RID: 37439 RVA: 0x00002050 File Offset: 0x00000250
	public bool HasRequirements
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700163E RID: 5694
	// (get) Token: 0x06009240 RID: 37440 RVA: 0x00002050 File Offset: 0x00000250
	public int FavoriteIndex
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700163F RID: 5695
	// (get) Token: 0x06009241 RID: 37441 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06009242 RID: 37442 RVA: 0x00002050 File Offset: 0x00000250
	public bool FavoriteScheme
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x17001640 RID: 5696
	// (get) Token: 0x06009243 RID: 37443 RVA: 0x00002050 File Offset: 0x00000250
	public IEnumerable<ItemRequirement> RequiredItems
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001641 RID: 5697
	// (get) Token: 0x06009244 RID: 37444 RVA: 0x00002050 File Offset: 0x00000250
	public virtual EOwnerType SchemeOwnerType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06009245 RID: 37445 RVA: 0x00002050 File Offset: 0x00000250
	[OnDeserialized]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(StreamingContext context)
	{
		throw null;
	}

	// Token: 0x06009246 RID: 37446 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GClass1918 GetProducingItem(float speedCoefficient, float reductionCoefficient = 1f)
	{
		throw null;
	}

	// Token: 0x06009247 RID: 37447 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1()
	{
		throw null;
	}

	// Token: 0x06009248 RID: 37448 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2()
	{
		throw null;
	}

	// Token: 0x040098F3 RID: 39155
	private static readonly HashSet<string> hashSet_0;

	// Token: 0x040098F4 RID: 39156
	public string _id;

	// Token: 0x040098F5 RID: 39157
	public int areaType;

	// Token: 0x040098F6 RID: 39158
	public float productionTime;

	// Token: 0x040098F7 RID: 39159
	public bool continuous;

	// Token: 0x040098F8 RID: 39160
	public bool needFuelForAllProductionTime;

	// Token: 0x040098F9 RID: 39161
	public bool locked;

	// Token: 0x040098FA RID: 39162
	public int count;

	// Token: 0x040098FB RID: 39163
	public int productionLimitCount;

	// Token: 0x040098FC RID: 39164
	public int Level;

	// Token: 0x040098FD RID: 39165
	public Requirement[] requirements;

	// Token: 0x02001B0E RID: 6926
	[CompilerGenerated]
	[Serializable]
	private sealed class Class1640
	{
		// Token: 0x06009249 RID: 37449 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int method_0(Requirement x, Requirement y)
		{
			throw null;
		}

		// Token: 0x040098FE RID: 39166
		public static readonly GClass1919.Class1640 class1640_0;

		// Token: 0x040098FF RID: 39167
		public static Comparison<Requirement> comparison_0;
	}
}
