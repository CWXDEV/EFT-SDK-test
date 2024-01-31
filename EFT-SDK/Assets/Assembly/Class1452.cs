using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Comfort.Common;
using EFT;
using EFT.InputSystem;
using EFT.InventoryLogic;

// Token: 0x02001908 RID: 6408
internal sealed class Class1452 : GInterface150
{
	// Token: 0x1700152A RID: 5418
	// (get) Token: 0x06008A0E RID: 35342 RVA: 0x00002050 File Offset: 0x00000250
	private bool Boolean_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06008A0F RID: 35343 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public InputNode.ETranslateResult TranslateCommand(ECommand command)
	{
		throw null;
	}

	// Token: 0x06008A10 RID: 35344 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private GStruct163[] method_0()
	{
		throw null;
	}

	// Token: 0x06008A11 RID: 35345 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private GStruct163[] method_1(bool increase)
	{
		throw null;
	}

	// Token: 0x06008A12 RID: 35346 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2()
	{
		throw null;
	}

	// Token: 0x06008A13 RID: 35347 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3(ECommand command)
	{
		throw null;
	}

	// Token: 0x06008A14 RID: 35348 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TranslateAxes(ref float[] axes)
	{
		throw null;
	}

	// Token: 0x06008A15 RID: 35349 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4()
	{
		throw null;
	}

	// Token: 0x06008A16 RID: 35350 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_5()
	{
		throw null;
	}

	// Token: 0x06008A17 RID: 35351 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_6()
	{
		throw null;
	}

	// Token: 0x06008A18 RID: 35352 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_7()
	{
		throw null;
	}

	// Token: 0x06008A19 RID: 35353 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_8()
	{
		throw null;
	}

	// Token: 0x06008A1A RID: 35354 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_9()
	{
		throw null;
	}

	// Token: 0x06008A1B RID: 35355 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_10()
	{
		throw null;
	}

	// Token: 0x06008A1C RID: 35356 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_11()
	{
		throw null;
	}

	// Token: 0x06008A1D RID: 35357 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_12(Weapon weapon)
	{
		throw null;
	}

	// Token: 0x06008A1E RID: 35358 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_13(Weapon weapon, bool quickReload = false)
	{
		throw null;
	}

	// Token: 0x06008A1F RID: 35359 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_14(Weapon weapon)
	{
		throw null;
	}

	// Token: 0x06008A20 RID: 35360 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_15(Weapon weapon, bool quickReload)
	{
		throw null;
	}

	// Token: 0x04008FAF RID: 36783
	private static readonly List<MagazineClass> list_0;

	// Token: 0x04008FB0 RID: 36784
	private static readonly List<BulletClass> list_1;

	// Token: 0x04008FB1 RID: 36785
	private readonly IFirearmHandsController ifirearmHandsController_0;

	// Token: 0x04008FB2 RID: 36786
	private bool bool_0;

	// Token: 0x04008FB3 RID: 36787
	private readonly InventoryControllerClass gclass2757_0;

	// Token: 0x04008FB4 RID: 36788
	private readonly Player player_0;

	// Token: 0x02001909 RID: 6409
	[CompilerGenerated]
	[Serializable]
	private sealed class Class1453
	{
		// Token: 0x06008A21 RID: 35361 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_0(Slot x)
		{
			throw null;
		}

		// Token: 0x06008A22 RID: 35362 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal GStruct162 method_1(LightComponent x)
		{
			throw null;
		}

		// Token: 0x06008A23 RID: 35363 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_2(Slot x)
		{
			throw null;
		}

		// Token: 0x06008A24 RID: 35364 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal GStruct162 method_3(LightComponent x)
		{
			throw null;
		}

		// Token: 0x06008A25 RID: 35365 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_4(Slot x)
		{
			throw null;
		}

		// Token: 0x06008A26 RID: 35366 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string method_5(SightComponent x)
		{
			throw null;
		}

		// Token: 0x06008A27 RID: 35367 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_6(Slot x)
		{
			throw null;
		}

		// Token: 0x06008A28 RID: 35368 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string method_7(SightComponent x)
		{
			throw null;
		}

		// Token: 0x06008A29 RID: 35369 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_8(GClass2765 g)
		{
			throw null;
		}

		// Token: 0x06008A2A RID: 35370 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int method_9(GClass2765 g)
		{
			throw null;
		}

		// Token: 0x06008A2B RID: 35371 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_10(GClass2765 g)
		{
			throw null;
		}

		// Token: 0x06008A2C RID: 35372 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int method_11(GClass2765 g)
		{
			throw null;
		}

		// Token: 0x06008A2D RID: 35373 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_12(GClass2765 g)
		{
			throw null;
		}

		// Token: 0x06008A2E RID: 35374 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int method_13(GClass2765 g)
		{
			throw null;
		}

		// Token: 0x06008A2F RID: 35375 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_14(GClass2765 g)
		{
			throw null;
		}

		// Token: 0x06008A30 RID: 35376 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int method_15(GClass2765 g)
		{
			throw null;
		}

		// Token: 0x06008A31 RID: 35377 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_16(BulletClass ammo)
		{
			throw null;
		}

		// Token: 0x06008A32 RID: 35378 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_17(GClass2765 g)
		{
			throw null;
		}

		// Token: 0x06008A33 RID: 35379 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int method_18(GClass2765 g)
		{
			throw null;
		}

		// Token: 0x06008A34 RID: 35380 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_19(GClass2765 x)
		{
			throw null;
		}

		// Token: 0x06008A35 RID: 35381 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_20(MagazineClass mag)
		{
			throw null;
		}

		// Token: 0x06008A36 RID: 35382 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int method_21(MagazineClass m1, MagazineClass m2)
		{
			throw null;
		}

		// Token: 0x06008A37 RID: 35383 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_22(GClass2765 g)
		{
			throw null;
		}

		// Token: 0x06008A38 RID: 35384 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int method_23(GClass2765 g)
		{
			throw null;
		}

		// Token: 0x06008A39 RID: 35385 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_24(GClass2765 x)
		{
			throw null;
		}

		// Token: 0x04008FB5 RID: 36789
		public static readonly Class1452.Class1453 class1453_0;

		// Token: 0x04008FB6 RID: 36790
		public static Func<Slot, Item> func_0;

		// Token: 0x04008FB7 RID: 36791
		public static Func<LightComponent, GStruct162> func_1;

		// Token: 0x04008FB8 RID: 36792
		public static Func<Slot, Item> func_2;

		// Token: 0x04008FB9 RID: 36793
		public static Func<LightComponent, GStruct162> func_3;

		// Token: 0x04008FBA RID: 36794
		public static Func<Slot, Item> func_4;

		// Token: 0x04008FBB RID: 36795
		public static Func<SightComponent, string> func_5;

		// Token: 0x04008FBC RID: 36796
		public static Func<Slot, Item> func_6;

		// Token: 0x04008FBD RID: 36797
		public static Func<SightComponent, string> func_7;

		// Token: 0x04008FBE RID: 36798
		public static Func<GClass2765, bool> func_8;

		// Token: 0x04008FBF RID: 36799
		public static Func<GClass2765, int> func_9;

		// Token: 0x04008FC0 RID: 36800
		public static Func<GClass2765, bool> func_10;

		// Token: 0x04008FC1 RID: 36801
		public static Func<GClass2765, int> func_11;

		// Token: 0x04008FC2 RID: 36802
		public static Func<GClass2765, bool> func_12;

		// Token: 0x04008FC3 RID: 36803
		public static Func<GClass2765, int> func_13;

		// Token: 0x04008FC4 RID: 36804
		public static Func<GClass2765, bool> func_14;

		// Token: 0x04008FC5 RID: 36805
		public static Func<GClass2765, int> func_15;

		// Token: 0x04008FC6 RID: 36806
		public static Func<BulletClass, bool> func_16;

		// Token: 0x04008FC7 RID: 36807
		public static Func<GClass2765, bool> func_17;

		// Token: 0x04008FC8 RID: 36808
		public static Func<GClass2765, int> func_18;

		// Token: 0x04008FC9 RID: 36809
		public static Func<GClass2765, bool> func_19;

		// Token: 0x04008FCA RID: 36810
		public static Func<MagazineClass, bool> func_20;

		// Token: 0x04008FCB RID: 36811
		public static Comparison<MagazineClass> comparison_0;

		// Token: 0x04008FCC RID: 36812
		public static Func<GClass2765, bool> func_21;

		// Token: 0x04008FCD RID: 36813
		public static Func<GClass2765, int> func_22;

		// Token: 0x04008FCE RID: 36814
		public static Func<GClass2765, bool> func_23;
	}

	// Token: 0x0200190A RID: 6410
	[CompilerGenerated]
	private sealed class Class1454
	{
		// Token: 0x06008A3A RID: 35386 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal GClass2765 method_0(GClass2495 grid)
		{
			throw null;
		}

		// Token: 0x04008FCF RID: 36815
		public MagazineClass currentMagazine;
	}

	// Token: 0x0200190B RID: 6411
	[CompilerGenerated]
	private sealed class Class1455
	{
		// Token: 0x06008A3B RID: 35387 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal GClass2765 method_0(GClass2495 grid)
		{
			throw null;
		}

		// Token: 0x04008FD0 RID: 36816
		public Item ammoInChamber;
	}

	// Token: 0x0200190C RID: 6412
	[CompilerGenerated]
	private sealed class Class1456
	{
		// Token: 0x06008A3C RID: 35388 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal GClass2765 method_0(GClass2495 grid)
		{
			throw null;
		}

		// Token: 0x04008FD1 RID: 36817
		public BulletClass ammo;
	}

	// Token: 0x0200190D RID: 6413
	[CompilerGenerated]
	private sealed class Class1457
	{
		// Token: 0x06008A3D RID: 35389 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(List<BulletClass> ammoList, Weapon weapon2)
		{
			throw null;
		}

		// Token: 0x06008A3E RID: 35390 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_1(Weapon weapon1)
		{
			throw null;
		}

		// Token: 0x06008A3F RID: 35391 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal GClass2765 method_2(GClass2495 grid)
		{
			throw null;
		}

		// Token: 0x06008A40 RID: 35392 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_3(IResult error)
		{
			throw null;
		}

		// Token: 0x04008FD2 RID: 36818
		public Class1452 class1452_0;

		// Token: 0x04008FD3 RID: 36819
		public MagazineClass currentMagazine;

		// Token: 0x04008FD4 RID: 36820
		public Weapon weapon;
	}

	// Token: 0x0200190E RID: 6414
	[CompilerGenerated]
	private sealed class Class1458
	{
		// Token: 0x06008A41 RID: 35393 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(BulletClass ammo)
		{
			throw null;
		}

		// Token: 0x04008FD5 RID: 36821
		public Weapon weapon2;
	}

	// Token: 0x0200190F RID: 6415
	[CompilerGenerated]
	private sealed class Class1459
	{
		// Token: 0x06008A42 RID: 35394 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(BulletClass ammo)
		{
			throw null;
		}

		// Token: 0x04008FD6 RID: 36822
		public GClass2664 launcher;
	}

	// Token: 0x02001910 RID: 6416
	[CompilerGenerated]
	private sealed class Class1460
	{
		// Token: 0x06008A43 RID: 35395 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(BulletClass ammo)
		{
			throw null;
		}

		// Token: 0x06008A44 RID: 35396 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal GClass2765 method_1(GClass2495 grid)
		{
			throw null;
		}

		// Token: 0x04008FD7 RID: 36823
		public Slot chamber;

		// Token: 0x04008FD8 RID: 36824
		public Class1452 class1452_0;

		// Token: 0x04008FD9 RID: 36825
		public BulletClass containedAmmo;
	}

	// Token: 0x02001911 RID: 6417
	[CompilerGenerated]
	private sealed class Class1461
	{
		// Token: 0x06008A45 RID: 35397 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(BulletClass ammo)
		{
			throw null;
		}

		// Token: 0x04008FDA RID: 36826
		public Class1452 class1452_0;

		// Token: 0x04008FDB RID: 36827
		public CylinderMagazineClass currentMagazine;
	}

	// Token: 0x02001912 RID: 6418
	[CompilerGenerated]
	private sealed class Class1462
	{
		// Token: 0x06008A46 RID: 35398 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(BulletClass ammo)
		{
			throw null;
		}

		// Token: 0x04008FDC RID: 36828
		public Weapon weapon;

		// Token: 0x04008FDD RID: 36829
		public Class1452 class1452_0;
	}

	// Token: 0x02001913 RID: 6419
	[CompilerGenerated]
	private sealed class Class1463
	{
		// Token: 0x06008A47 RID: 35399 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal GClass2765 method_0(GClass2495 grid)
		{
			throw null;
		}

		// Token: 0x04008FDE RID: 36830
		public MagazineClass currentMagazine;
	}
}
