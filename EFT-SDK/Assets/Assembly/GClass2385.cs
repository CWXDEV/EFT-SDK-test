using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using EFT.NextObservedPlayer;
using UnityEngine;

// Token: 0x02002049 RID: 8265
public class GClass2385 : IDisposable
{
	// Token: 0x17001C4A RID: 7242
	// (get) Token: 0x0600ABE0 RID: 44000 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsVisible
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001C4B RID: 7243
	// (get) Token: 0x0600ABE1 RID: 44001 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsCloseToMyPlayerCamera
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001C4C RID: 7244
	// (get) Token: 0x0600ABE2 RID: 44002 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600ABE3 RID: 44003 RVA: 0x00002050 File Offset: 0x00000250
	public GClass2385.EMode Mode
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

	// Token: 0x0600ABE4 RID: 44004 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Initialize(GClass2372 handsController)
	{
		throw null;
	}

	// Token: 0x0600ABE5 RID: 44005 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0( ValueTuple<Item, WeaponPrefab> prev,  ValueTuple<Item, WeaponPrefab> next)
	{
		throw null;
	}

	// Token: 0x0600ABE6 RID: 44006 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(bool state)
	{
		throw null;
	}

	// Token: 0x0600ABE7 RID: 44007 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2()
	{
		throw null;
	}

	// Token: 0x0600ABE8 RID: 44008 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ManualUpdate(float dt)
	{
		throw null;
	}

	// Token: 0x0600ABE9 RID: 44009 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Apply(GStruct287 model)
	{
		throw null;
	}

	// Token: 0x0600ABEA RID: 44010 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Reset()
	{
		throw null;
	}

	// Token: 0x0600ABEB RID: 44011 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3()
	{
		throw null;
	}

	// Token: 0x0600ABEC RID: 44012 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4()
	{
		throw null;
	}

	// Token: 0x0600ABED RID: 44013 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Enable()
	{
		throw null;
	}

	// Token: 0x0600ABEE RID: 44014 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Disable()
	{
		throw null;
	}

	// Token: 0x0600ABEF RID: 44015 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DisableCullingOnDead()
	{
		throw null;
	}

	// Token: 0x0600ABF0 RID: 44016 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x0600ABF1 RID: 44017 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_5(GClass2902 raisedEvent)
	{
		throw null;
	}

	// Token: 0x0400B26D RID: 45677
	private ObservedPlayerView observedPlayerView_0;

	// Token: 0x0400B26E RID: 45678
	private GClass2372 gclass2372_0;

	// Token: 0x0400B26F RID: 45679
	private GClass2354 gclass2354_0;

	// Token: 0x0400B270 RID: 45680
	private GClass883 gclass883_0;

	// Token: 0x0400B271 RID: 45681
	private GClass2385.Class1860 class1860_0;

	// Token: 0x0400B272 RID: 45682
	private List<Renderer> list_0;

	// Token: 0x0400B273 RID: 45683
	private GClass2385.EMode emode_0;

	// Token: 0x0400B274 RID: 45684
	private Action action_0;

	// Token: 0x0400B275 RID: 45685
	private int int_0;

	// Token: 0x0200204A RID: 8266
	public enum EMode
	{
		// Token: 0x0400B277 RID: 45687
		Disabled,
		// Token: 0x0400B278 RID: 45688
		Hidden,
		// Token: 0x0400B279 RID: 45689
		Visible,
		// Token: 0x0400B27A RID: 45690
		Auto
	}

	// Token: 0x0200204B RID: 8267
	private class Class1860 : IDisposable
	{
		// Token: 0x17001C4D RID: 7245
		// (get) Token: 0x0600ABF2 RID: 44018 RVA: 0x00002050 File Offset: 0x00000250
		public bool State
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600ABF3 RID: 44019 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ManualUpdate()
		{
			throw null;
		}

		// Token: 0x0600ABF4 RID: 44020 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0600ABF5 RID: 44021 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(bool isVisible)
		{
			throw null;
		}

		// Token: 0x0600ABF6 RID: 44022 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_2(GInterface355 ballisticsCalculator)
		{
			throw null;
		}

		// Token: 0x0600ABF7 RID: 44023 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x0600ABF8 RID: 44024 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static float smethod_0(Vector3 fromPoint, Vector3 toPoint, Vector3 zeroDirection)
		{
			throw null;
		}

		// Token: 0x0400B27B RID: 45691
		private const float float_0 = 5f;

		// Token: 0x0400B27C RID: 45692
		private readonly float float_1;

		// Token: 0x0400B27D RID: 45693
		private bool bool_0;

		// Token: 0x0400B27E RID: 45694
		private bool bool_1;

		// Token: 0x0400B27F RID: 45695
		private float float_2;

		// Token: 0x0400B280 RID: 45696
		private bool bool_2;

		// Token: 0x0400B281 RID: 45697
		private GClass883 gclass883_0;

		// Token: 0x0400B282 RID: 45698
		public Action<bool> OnChange;
	}
}
