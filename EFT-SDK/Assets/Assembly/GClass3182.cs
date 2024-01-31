using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Comfort.Common;
using EFT;
using EFT.UI.Ragfair;
using JetBrains.Annotations;

// Token: 0x02002EE5 RID: 12005
public sealed class GClass3182
{
	// Token: 0x170028B6 RID: 10422
	// (get) Token: 0x0600ED08 RID: 60680 RVA: 0x00002050 File Offset: 0x00000250
	public IReadOnlyDictionary<MongoID, GClass3181> EquipmentBuilds
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170028B7 RID: 10423
	// (get) Token: 0x0600ED09 RID: 60681 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600ED0A RID: 60682 RVA: 0x00002050 File Offset: 0x00000250
	public string LastEquippedPresetName
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

	// Token: 0x170028B8 RID: 10424
	// (get) Token: 0x0600ED0B RID: 60683 RVA: 0x00002050 File Offset: 0x00000250
	public bool HasCustomBuilds
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600ED0C RID: 60684 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GClass3181 FindCustomBuildByName(string name)
	{
		throw null;
	}

	// Token: 0x0600ED0D RID: 60685 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private string method_0()
	{
		throw null;
	}

	// Token: 0x0600ED0E RID: 60686 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SearchBuildOnRagfair(BuildItemSearchValue buildSearch)
	{
		throw null;
	}

	// Token: 0x0600ED0F RID: 60687 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<IResult> SaveBuild(GClass3181 build)
	{
		throw null;
	}

	// Token: 0x0600ED10 RID: 60688 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(GClass3181 equipmentBuild)
	{
		throw null;
	}

	// Token: 0x0600ED11 RID: 60689 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<IResult> RemoveBuild(MongoID buildId)
	{
		throw null;
	}

	// Token: 0x0400F207 RID: 61959
	private const string string_0 = "NEW PRESET {0}";

	// Token: 0x0400F208 RID: 61960
	private Dictionary<MongoID, GClass3181> dictionary_0;

	// Token: 0x0400F209 RID: 61961
	private readonly ISession ginterface145_0;

	// Token: 0x0400F20A RID: 61962
	private string string_1;

	// Token: 0x02002EE6 RID: 12006
	[CompilerGenerated]
	[Serializable]
	private sealed class Class2958
	{
		// Token: 0x0600ED12 RID: 60690 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(GClass3181 build)
		{
			throw null;
		}

		// Token: 0x0400F20B RID: 61963
		public static readonly GClass3182.Class2958 class2958_0;

		// Token: 0x0400F20C RID: 61964
		public static Func<GClass3181, bool> func_0;
	}

	// Token: 0x02002EE7 RID: 12007
	[CompilerGenerated]
	private sealed class Class2959
	{
		// Token: 0x0600ED13 RID: 60691 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(KeyValuePair<MongoID, GClass3181> x)
		{
			throw null;
		}

		// Token: 0x0400F20D RID: 61965
		public string name;
	}
}
