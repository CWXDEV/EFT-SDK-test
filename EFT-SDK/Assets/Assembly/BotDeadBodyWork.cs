using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Comfort.Common;
using EFT.InventoryLogic;

// Token: 0x020002B0 RID: 688
public class BotDeadBodyWork : GClass362
{
	// Token: 0x1400001D RID: 29
	// (add) Token: 0x06000E0D RID: 3597 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06000E0E RID: 3598 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<float> OnStartLookToBody
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

	// Token: 0x17000383 RID: 899
	// (get) Token: 0x06000E0F RID: 3599 RVA: 0x00002050 File Offset: 0x00000250
	private float Single_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000384 RID: 900
	// (get) Token: 0x06000E10 RID: 3600 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000E11 RID: 3601 RVA: 0x00002050 File Offset: 0x00000250
	public bool ShallUse
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x17000385 RID: 901
	// (get) Token: 0x06000E12 RID: 3602 RVA: 0x00002050 File Offset: 0x00000250
	private bool Boolean_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06000E13 RID: 3603 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(GClass320 body)
	{
		throw null;
	}

	// Token: 0x06000E14 RID: 3604 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(float pTime)
	{
		throw null;
	}

	// Token: 0x06000E15 RID: 3605 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2()
	{
		throw null;
	}

	// Token: 0x06000E16 RID: 3606 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Activate()
	{
		throw null;
	}

	// Token: 0x06000E17 RID: 3607 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateCheck()
	{
		throw null;
	}

	// Token: 0x06000E18 RID: 3608 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ManualUpdate()
	{
		throw null;
	}

	// Token: 0x06000E19 RID: 3609 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected bool IsClose(out float dist)
	{
		throw null;
	}

	// Token: 0x06000E1A RID: 3610 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3()
	{
		throw null;
	}

	// Token: 0x06000E1B RID: 3611 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4()
	{
		throw null;
	}

	// Token: 0x06000E1C RID: 3612 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_5()
	{
		throw null;
	}

	// Token: 0x06000E1D RID: 3613 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_6()
	{
		throw null;
	}

	// Token: 0x06000E1E RID: 3614 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_7()
	{
		throw null;
	}

	// Token: 0x06000E1F RID: 3615 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_8()
	{
		throw null;
	}

	// Token: 0x06000E20 RID: 3616 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_9()
	{
		throw null;
	}

	// Token: 0x06000E21 RID: 3617 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_10()
	{
		throw null;
	}

	// Token: 0x04000DB0 RID: 3504
	private const float MOVEITEM_TRANSACTION_DELAY = 1f;

	// Token: 0x04000DB1 RID: 3505
	private List<GClass320> _bodies;

	// Token: 0x04000DB2 RID: 3506
	private float _nextCheckClose;

	// Token: 0x04000DB3 RID: 3507
	private float _nextPosibleGo;

	// Token: 0x04000DB4 RID: 3508
	private float _nextCheckBody;

	// Token: 0x04000DB5 RID: 3509
	private float _nextShallStopCheck;

	// Token: 0x04000DB6 RID: 3510
	private float _lastBodyDistCheck;

	// Token: 0x04000DB7 RID: 3511
	private float _leaveBodyTime;

	// Token: 0x04000DB8 RID: 3512
	private bool _lookInProgress;

	// Token: 0x04000DB9 RID: 3513
	private bool _lastDesicion;

	// Token: 0x04000DBA RID: 3514
	private GClass320 _activeBody;

	// Token: 0x04000DBB RID: 3515
	private bool _isStay;

	// Token: 0x04000DBC RID: 3516
	private BotDeadBodyWork.ELookState _curLookState;

	// Token: 0x04000DBD RID: 3517
	private float _unpauseTime;

	// Token: 0x04000DBE RID: 3518
	private List<Item> _itemsCache;

	// Token: 0x04000DBF RID: 3519
	private List<LootItemClass> _containersCache;

	// Token: 0x04000DC0 RID: 3520
	private List<ValueTuple<float, Item>> _weightedItems;

	// Token: 0x04000DC1 RID: 3521
	private int _takeItemsLeft;

	// Token: 0x04000DC2 RID: 3522
	private int _curItemIndex;

	// Token: 0x04000DC3 RID: 3523
	private Task<IResult> _moveItemTask;

	// Token: 0x020002B1 RID: 689
	private enum ELookState
	{
		// Token: 0x04000DC7 RID: 3527
		Initial,
		// Token: 0x04000DC8 RID: 3528
		LootWeapon,
		// Token: 0x04000DC9 RID: 3529
		CheckBackpack,
		// Token: 0x04000DCA RID: 3530
		LootAllCalculations,
		// Token: 0x04000DCB RID: 3531
		LootAllItemsMoving,
		// Token: 0x04000DCC RID: 3532
		DropBodyVest,
		// Token: 0x04000DCD RID: 3533
		DropBodyBackpack,
		// Token: 0x04000DCE RID: 3534
		Exit
	}

	// Token: 0x020002B2 RID: 690
	[CompilerGenerated]
	[Serializable]
	private sealed class Class162
	{
		// Token: 0x06000E22 RID: 3618 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int method_0( ValueTuple<float, Item> a,  ValueTuple<float, Item> b)
		{
			throw null;
		}

		// Token: 0x04000DCF RID: 3535
		public static readonly BotDeadBodyWork.Class162 class162_0;

		// Token: 0x04000DD0 RID: 3536
		public static Comparison<ValueTuple<float, Item>> comparison_0;
	}
}
