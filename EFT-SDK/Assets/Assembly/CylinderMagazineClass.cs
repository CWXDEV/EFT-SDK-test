using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using JetBrains.Annotations;

// Token: 0x020024A6 RID: 9382
public class CylinderMagazineClass : MagazineClass
{
	// Token: 0x17002174 RID: 8564
	// (get) Token: 0x0600BBE7 RID: 48103 RVA: 0x00002050 File Offset: 0x00000250
	public int CurrentCamoraIndex
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17002175 RID: 8565
	// (get) Token: 0x0600BBE8 RID: 48104 RVA: 0x00002050 File Offset: 0x00000250
	public Slot[] Camoras
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17002176 RID: 8566
	// (get) Token: 0x0600BBE9 RID: 48105 RVA: 0x00002050 File Offset: 0x00000250
	public override int Count
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17002177 RID: 8567
	// (get) Token: 0x0600BBEA RID: 48106 RVA: 0x00002050 File Offset: 0x00000250
	public override int MaxCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600BBEB RID: 48107 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Item FirstRealAmmo()
	{
		throw null;
	}

	// Token: 0x17002178 RID: 8568
	// (get) Token: 0x0600BBEC RID: 48108 RVA: 0x00002050 File Offset: 0x00000250
	public override IEnumerable<IContainer> Containers
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600BBED RID: 48109 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override IContainer GetContainer(string containerId)
	{
		throw null;
	}

	// Token: 0x0600BBEE RID: 48110 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Item FindItem(string itemId)
	{
		throw null;
	}

	// Token: 0x0600BBEF RID: 48111 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Slot GetCamoraForFire(bool singleFireMode)
	{
		throw null;
	}

	// Token: 0x0600BBF0 RID: 48112 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override GStruct412 Apply([NotNull] TraderControllerClass itemController, [NotNull] Item item, int count, bool simulate)
	{
		throw null;
	}

	// Token: 0x0600BBF1 RID: 48113 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override GStruct412 ApplyWithoutRestrictions([NotNull] TraderControllerClass itemController, [NotNull] BulletClass ammo, int count, bool simulate)
	{
		throw null;
	}

	// Token: 0x0600BBF2 RID: 48114 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public BulletClass GetAmmoByCamoraIndex(int camoraIndex)
	{
		throw null;
	}

	// Token: 0x0600BBF3 RID: 48115 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public BulletClass GetFirstAmmo(bool singleFireMode)
	{
		throw null;
	}

	// Token: 0x0600BBF4 RID: 48116 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetCamoraFireOrLoadStartIndex(bool singleFireMode)
	{
		throw null;
	}

	// Token: 0x0600BBF5 RID: 48117 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual int CamoraIndexForDoubleActionFire()
	{
		throw null;
	}

	// Token: 0x0600BBF6 RID: 48118 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<int> GetCamorasIndexesList()
	{
		throw null;
	}

	// Token: 0x0600BBF7 RID: 48119 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ResetCamoraIndex()
	{
		throw null;
	}

	// Token: 0x0600BBF8 RID: 48120 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual List<int> GetFreeCamorasIndexesFromCurrentActiveIndex(bool quickReload, bool singleAction)
	{
		throw null;
	}

	// Token: 0x0600BBF9 RID: 48121 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private GStruct413<GInterface322> method_43(Item item, TraderControllerClass itemController)
	{
		throw null;
	}

	// Token: 0x0600BBFA RID: 48122 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveAmmoInCamora(Item ammo, TraderControllerClass itemController)
	{
		throw null;
	}

	// Token: 0x0600BBFB RID: 48123 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveAllAmmo(TraderControllerClass itemController)
	{
		throw null;
	}

	// Token: 0x0600BBFC RID: 48124 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCurrentCamoraIndex(int camoraIndex)
	{
		throw null;
	}

	// Token: 0x0600BBFD RID: 48125 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SetNotEmptyCamoraAsActive()
	{
		throw null;
	}

	// Token: 0x0600BBFE RID: 48126 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void IncrementCamoraIndex(bool rollToZeroCamora = false)
	{
		throw null;
	}

	// Token: 0x0600BBFF RID: 48127 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void DryFireIncrementCamoraIndex()
	{
		throw null;
	}

	// Token: 0x0600BC00 RID: 48128 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool Compare(Item item)
	{
		throw null;
	}

	// Token: 0x0600BC01 RID: 48129 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private int method_44()
	{
		throw null;
	}

	// Token: 0x0600BC02 RID: 48130 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Slot GetActiveCamoraSlot(bool inRaid)
	{
		throw null;
	}

	// Token: 0x0600BC03 RID: 48131 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool CanRollCylinderInsteadOfReload()
	{
		throw null;
	}

	// Token: 0x0600BC04 RID: 48132 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[DebuggerHidden]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerable<IContainer> method_45()
	{
		throw null;
	}

	// Token: 0x0400BEBE RID: 48830
	private bool bool_0;

	// Token: 0x0400BEBF RID: 48831
	protected int int_0;

	// Token: 0x0400BEC0 RID: 48832
	protected Slot[] slot_0;

	// Token: 0x020024A7 RID: 9383
	[CompilerGenerated]
	[Serializable]
	private sealed class Class2081
	{
		// Token: 0x0600BC05 RID: 48133 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(Slot x)
		{
			throw null;
		}

		// Token: 0x0400BEC1 RID: 48833
		public static readonly CylinderMagazineClass.Class2081 class2081_0;

		// Token: 0x0400BEC2 RID: 48834
		public static Func<Slot, bool> func_0;
	}
}
