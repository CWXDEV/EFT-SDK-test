using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Comfort.Common;
using EFT.InventoryLogic;

// Token: 0x020003E8 RID: 1000
public class BotNightVisionData : GClass362
{
	// Token: 0x17000462 RID: 1122
	// (get) Token: 0x06001812 RID: 6162 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001813 RID: 6163 RVA: 0x00002050 File Offset: 0x00000250
	public bool HaveNightVision
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

	// Token: 0x17000463 RID: 1123
	// (get) Token: 0x06001814 RID: 6164 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001815 RID: 6165 RVA: 0x00002050 File Offset: 0x00000250
	public bool UsingNow
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

	// Token: 0x06001816 RID: 6166 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Activate()
	{
		throw null;
	}

	// Token: 0x06001817 RID: 6167 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public float UpdateVision(float distVision)
	{
		throw null;
	}

	// Token: 0x06001818 RID: 6168 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ManualUpdate()
	{
		throw null;
	}

	// Token: 0x06001819 RID: 6169 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x0600181A RID: 6170 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1()
	{
		throw null;
	}

	// Token: 0x0600181B RID: 6171 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_2(Item item)
	{
		throw null;
	}

	// Token: 0x0600181C RID: 6172 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_3(Item item)
	{
		throw null;
	}

	// Token: 0x0600181D RID: 6173 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4()
	{
		throw null;
	}

	// Token: 0x0600181E RID: 6174 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_5()
	{
		throw null;
	}

	// Token: 0x0600181F RID: 6175 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_6()
	{
		throw null;
	}

	// Token: 0x06001820 RID: 6176 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_7(Item item, EquipmentSlot slot)
	{
		throw null;
	}

	// Token: 0x040014E0 RID: 5344
	private const float CHECK_PERIOD_SEC = 60f;

	// Token: 0x040014E1 RID: 5345
	public NightVisionComponent NightVisionItem;

	// Token: 0x040014E2 RID: 5346
	public Item TradableItem;

	// Token: 0x040014E3 RID: 5347
	private bool _nightVisionAtPocket;

	// Token: 0x040014E4 RID: 5348
	private float _nextTimeCheck;

	// Token: 0x040014E5 RID: 5349
	private Slot _slotHeadwear;

	// Token: 0x040014E6 RID: 5350
	private bool _stopTryingMove;

	// Token: 0x020003EB RID: 1003
	[CompilerGenerated]
	private sealed class Class209
	{
		// Token: 0x06001825 RID: 6181 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(IResult arg)
		{
			throw null;
		}

		// Token: 0x040014F6 RID: 5366
		public TaskCompletionSource<object> completion;
	}
}
