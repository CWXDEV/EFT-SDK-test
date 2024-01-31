using System;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020009E2 RID: 2530
public sealed class DurabilitySlider : Slider
{
	// Token: 0x17000976 RID: 2422
	// (set) Token: 0x06003828 RID: 14376 RVA: 0x00002050 File Offset: 0x00000250
	public bool ShowDurability
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x17000977 RID: 2423
	// (get) Token: 0x06003829 RID: 14377 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600382A RID: 14378 RVA: 0x00002050 File Offset: 0x00000250
	private float Single_0
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x0600382B RID: 14379 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Awake()
	{
		throw null;
	}

	// Token: 0x0600382C RID: 14380 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void method_0(RepairableComponent repairable, float durabilityThreshold)
	{
		throw null;
	}

	// Token: 0x0600382D RID: 14381 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void method_1(float durability)
	{
		throw null;
	}

	// Token: 0x0600382E RID: 14382 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2(bool inDangerZone)
	{
		throw null;
	}

	// Token: 0x040039E8 RID: 14824
	[SerializeField]
	private Image _background;

	// Token: 0x040039E9 RID: 14825
	[SerializeField]
	private Sprite _backgroundDangerZone;

	// Token: 0x040039EA RID: 14826
	[SerializeField]
	private Sprite _backgroundDefault;

	// Token: 0x040039EB RID: 14827
	[SerializeField]
	private Image _fill;

	// Token: 0x040039EC RID: 14828
	[SerializeField]
	private Image _fillWear;

	// Token: 0x040039ED RID: 14829
	[SerializeField]
	private Sprite _fillDangerZone;

	// Token: 0x040039EE RID: 14830
	[SerializeField]
	private Sprite _fillDefault;

	// Token: 0x040039EF RID: 14831
	[SerializeField]
	private GameObject _glow;

	// Token: 0x040039F0 RID: 14832
	[SerializeField]
	private GameObject _repairRequiredIcon;

	// Token: 0x040039F1 RID: 14833
	[CompilerGenerated]
	private float float_0;

	// Token: 0x040039F2 RID: 14834
	private bool bool_0;
}
