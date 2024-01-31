using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.InputSystem;

// Token: 0x02001A33 RID: 6707
public class GClass1891 : GClass1890
{
	// Token: 0x06008E19 RID: 36377 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(GClass1891.EAxisState state)
	{
		throw null;
	}

	// Token: 0x06008E1A RID: 36378 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateInput(GInterface156[] positiveAxis, GInterface156[] negativeAxis, List<GInterface156> keys, List<GInterface156> modificator)
	{
		throw null;
	}

	// Token: 0x06008E1B RID: 36379 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int GetInputCount()
	{
		throw null;
	}

	// Token: 0x06008E1C RID: 36380 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override ECommand UpdateCommand(float deltaTime)
	{
		throw null;
	}

	// Token: 0x06008E1D RID: 36381 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool IsLowerPriority(GClass1890 combination)
	{
		throw null;
	}

	// Token: 0x06008E1E RID: 36382 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public float GetValue()
	{
		throw null;
	}

	// Token: 0x06008E1F RID: 36383 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GClass1891 Clone()
	{
		throw null;
	}

	// Token: 0x0400957A RID: 38266
	private readonly GClass1891.Class1567[] class1567_0;

	// Token: 0x0400957B RID: 38267
	private GClass1891.Class1567 class1567_1;

	// Token: 0x0400957C RID: 38268
	public readonly EAxis GameAxis;

	// Token: 0x0400957D RID: 38269
	public readonly int IntAxis;

	// Token: 0x0400957E RID: 38270
	public readonly EGameKey Modificator;

	// Token: 0x0400957F RID: 38271
	private GInterface156[] ginterface156_0;

	// Token: 0x04009580 RID: 38272
	private GInterface156[] ginterface156_1;

	// Token: 0x04009581 RID: 38273
	private int int_1;

	// Token: 0x04009582 RID: 38274
	private KeyValuePair<GClass1891.EUseSide, GInterface156[]>[] keyValuePair_0;

	// Token: 0x02001A34 RID: 6708
	[Flags]
	private enum EUseSide
	{
		// Token: 0x04009584 RID: 38276
		None = 0,
		// Token: 0x04009585 RID: 38277
		Positive = 1,
		// Token: 0x04009586 RID: 38278
		Negative = 2
	}

	// Token: 0x02001A35 RID: 6709
	private enum EAxisState
	{
		// Token: 0x04009588 RID: 38280
		JustAxis,
		// Token: 0x04009589 RID: 38281
		WithKeysIdling,
		// Token: 0x0400958A RID: 38282
		WithKeysPressed
	}

	// Token: 0x02001A36 RID: 6710
	private abstract class Class1567
	{
		// Token: 0x06008E20 RID: 36384
		public abstract void Update();

		// Token: 0x1700158E RID: 5518
		// (get) Token: 0x06008E21 RID: 36385 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06008E22 RID: 36386 RVA: 0x00002050 File Offset: 0x00000250
		public float Value
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected set
			{
				throw null;
			}
		}

		// Token: 0x06008E23 RID: 36387 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual GClass1891.EUseSide vmethod_0(out EKeyPress keysStatus)
		{
			throw null;
		}

		// Token: 0x06008E24 RID: 36388 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected float method_0(GClass1891.EUseSide side)
		{
			throw null;
		}

		// Token: 0x06008E25 RID: 36389 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(GInterface156[] axisGroup, ref float calculationValue)
		{
			throw null;
		}

		// Token: 0x0400958B RID: 38283
		private const float float_0 = 1000f;

		// Token: 0x0400958C RID: 38284
		public readonly GClass1891 AxisCombination;

		// Token: 0x0400958D RID: 38285
		[CompilerGenerated]
		private float float_1;
	}

	// Token: 0x02001A37 RID: 6711
	private class Class1568 : GClass1891.Class1567
	{
		// Token: 0x06008E26 RID: 36390 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Update()
		{
			throw null;
		}
	}

	// Token: 0x02001A38 RID: 6712
	private abstract class Class1569 : GClass1891.Class1567
	{
		// Token: 0x06008E27 RID: 36391 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override GClass1891.EUseSide vmethod_0(out EKeyPress keysStatus)
		{
			throw null;
		}

		// Token: 0x06008E28 RID: 36392 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void method_2(GClass1891.EUseSide useSide)
		{
			throw null;
		}

		// Token: 0x06008E29 RID: 36393 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void method_3()
		{
			throw null;
		}
	}

	// Token: 0x02001A39 RID: 6713
	private class Class1570 : GClass1891.Class1569
	{
		// Token: 0x06008E2A RID: 36394 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Update()
		{
			throw null;
		}
	}

	// Token: 0x02001A3A RID: 6714
	private class Class1571 : GClass1891.Class1569
	{
		// Token: 0x06008E2B RID: 36395 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Update()
		{
			throw null;
		}
	}
}
