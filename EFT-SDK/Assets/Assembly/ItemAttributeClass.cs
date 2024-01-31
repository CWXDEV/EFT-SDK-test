using System;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;

// Token: 0x020024A1 RID: 9377
public class ItemAttributeClass
{
	// Token: 0x17002172 RID: 8562
	// (get) Token: 0x0600BBD8 RID: 48088 RVA: 0x00002050 File Offset: 0x00000250
	public string DisplayName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x140002A5 RID: 677
	// (add) Token: 0x0600BBD9 RID: 48089 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600BBDA RID: 48090 RVA: 0x00002050 File Offset: 0x00000250
	public event Action OnUpdate
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			throw null;
		}
	}

	// Token: 0x0600BBDB RID: 48091 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual ItemAttributeClass Clone()
	{
		throw null;
	}

	// Token: 0x0600BBDC RID: 48092 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CopyFrom(ItemAttributeClass source)
	{
		throw null;
	}

	// Token: 0x0600BBDD RID: 48093 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Update()
	{
		throw null;
	}

	// Token: 0x0600BBDE RID: 48094 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private string method_0()
	{
		throw null;
	}

	// Token: 0x0400BEA7 RID: 48807
	public Func<EItemAttributeDisplayType> DisplayType;

	// Token: 0x0400BEA8 RID: 48808
	public EItemAttributeLabelVariations LabelVariations;

	// Token: 0x0400BEA9 RID: 48809
	public bool LessIsGood;

	// Token: 0x0400BEAA RID: 48810
	public string Name;

	// Token: 0x0400BEAB RID: 48811
	public Enum Id;

	// Token: 0x0400BEAC RID: 48812
	public Func<float> Base;

	// Token: 0x0400BEAD RID: 48813
	public Func<string> DisplayNameFunc;

	// Token: 0x0400BEAE RID: 48814
	public Func<GClass3093> MultiLineInfo;

	// Token: 0x0400BEAF RID: 48815
	public Func<string> StringValue;

	// Token: 0x0400BEB0 RID: 48816
	public Func<string> FullStringValue;

	// Token: 0x0400BEB1 RID: 48817
	public Func<string> Tooltip;

	// Token: 0x0400BEB2 RID: 48818
	public bool IsDisplayable;

	// Token: 0x0400BEB3 RID: 48819
	public GClass2746 Enhancement;

	// Token: 0x0400BEB4 RID: 48820
	[CompilerGenerated]
	private Action action_0;

	// Token: 0x020024A2 RID: 9378
	[CompilerGenerated]
	[Serializable]
	private sealed class Class2079
	{
		// Token: 0x0600BBDF RID: 48095 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal float method_0()
		{
			throw null;
		}

		// Token: 0x0600BBE0 RID: 48096 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal GClass3093 method_1()
		{
			throw null;
		}

		// Token: 0x0600BBE1 RID: 48097 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string method_2()
		{
			throw null;
		}

		// Token: 0x0600BBE2 RID: 48098 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string method_3()
		{
			throw null;
		}

		// Token: 0x0400BEB5 RID: 48821
		public static readonly ItemAttributeClass.Class2079 class2079_0;

		// Token: 0x0400BEB6 RID: 48822
		public static Func<float> func_0;

		// Token: 0x0400BEB7 RID: 48823
		public static Func<GClass3093> func_1;

		// Token: 0x0400BEB8 RID: 48824
		public static Func<string> func_2;

		// Token: 0x0400BEB9 RID: 48825
		public static Func<string> func_3;
	}
}
