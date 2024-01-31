using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;

// Token: 0x02001662 RID: 5730
public class GClass1780 : ISerializer<SkillManager>
{
	// Token: 0x06007C34 RID: 31796 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public SkillManager Deserialize()
	{
		throw null;
	}

	// Token: 0x06007C35 RID: 31797 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Serialize(SkillManager skillManager)
	{
		throw null;
	}

	// Token: 0x040082CE RID: 33486
	public GClass1780.GClass1781[] Common;

	// Token: 0x040082CF RID: 33487
	public GClass1780.GClass1782[] Mastering;

	// Token: 0x040082D0 RID: 33488
	public List<GClass1404> Bonuses;

	// Token: 0x040082D1 RID: 33489
	public int? Points;

	// Token: 0x02001663 RID: 5731
	public class GClass1781
	{
		// Token: 0x040082D2 RID: 33490
		public ESkillId Id;

		// Token: 0x040082D3 RID: 33491
		public float Progress;

		// Token: 0x040082D4 RID: 33492
		public float PointsEarnedDuringSession;

		// Token: 0x040082D5 RID: 33493
		public int LastAccess;
	}

	// Token: 0x02001664 RID: 5732
	public class GClass1782
	{
		// Token: 0x040082D6 RID: 33494
		public string Id;

		// Token: 0x040082D7 RID: 33495
		public float Progress;
	}

	// Token: 0x02001665 RID: 5733
	[CompilerGenerated]
	private sealed class Class1179
	{
		// Token: 0x06007C36 RID: 31798 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(BackendConfigSettingsClass.GClass1363 x)
		{
			throw null;
		}

		// Token: 0x040082D8 RID: 33496
		public GClass1780.GClass1782 m;
	}

	// Token: 0x02001666 RID: 5734
	[CompilerGenerated]
	[Serializable]
	private sealed class Class1180
	{
		// Token: 0x06007C37 RID: 31799 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal GClass1780.GClass1781 method_0(GClass1765 skill)
		{
			throw null;
		}

		// Token: 0x06007C38 RID: 31800 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal GClass1780.GClass1782 method_1(KeyValuePair<string, GClass1764> m)
		{
			throw null;
		}

		// Token: 0x040082D9 RID: 33497
		public static readonly GClass1780.Class1180 class1180_0;

		// Token: 0x040082DA RID: 33498
		public static Func<GClass1765, GClass1780.GClass1781> func_0;

		// Token: 0x040082DB RID: 33499
		public static Func<KeyValuePair<string, GClass1764>, GClass1780.GClass1782> func_1;
	}
}
