using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.InputSystem;

// Token: 0x02001A3F RID: 6719
public class GClass1892 : GClass1890
{
	// Token: 0x06008E47 RID: 36423 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_0(GClass1892.EKeyState nextStateName)
	{
		throw null;
	}

	// Token: 0x17001598 RID: 5528
	// (get) Token: 0x06008E48 RID: 36424 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06008E49 RID: 36425 RVA: 0x00002050 File Offset: 0x00000250
	public bool CalculateFullHash
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

	// Token: 0x06008E4A RID: 36426 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateInput(List<GInterface156> inputKeys, EPressType pressType)
	{
		throw null;
	}

	// Token: 0x06008E4B RID: 36427 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(bool fullHash)
	{
		throw null;
	}

	// Token: 0x06008E4C RID: 36428 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override ECommand UpdateCommand(float deltaTime)
	{
		throw null;
	}

	// Token: 0x06008E4D RID: 36429 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int GetInputCount()
	{
		throw null;
	}

	// Token: 0x06008E4E RID: 36430 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool IsLowerPriority(GClass1890 combination)
	{
		throw null;
	}

	// Token: 0x06008E4F RID: 36431 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual GClass1892 Clone()
	{
		throw null;
	}

	// Token: 0x06008E50 RID: 36432 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		throw null;
	}

	// Token: 0x04009599 RID: 38297
	private GClass1892.KeyCombinationState keyCombinationState_0;

	// Token: 0x0400959A RID: 38298
	protected readonly GClass1892.KeyCombinationState[] keyCombinationState_1;

	// Token: 0x0400959B RID: 38299
	public float DoubleClickTimeout;

	// Token: 0x0400959C RID: 38300
	private float float_0;

	// Token: 0x0400959D RID: 38301
	public readonly EGameKey GameKey;

	// Token: 0x0400959E RID: 38302
	protected readonly ECommand ecommand_0;

	// Token: 0x0400959F RID: 38303
	public GInterface156[] InputKeys;

	// Token: 0x040095A0 RID: 38304
	public EPressType Type;

	// Token: 0x040095A1 RID: 38305
	private bool bool_0;

	// Token: 0x040095A2 RID: 38306
	private int int_1;

	// Token: 0x040095A3 RID: 38307
	public int KeysHash;

	// Token: 0x040095A4 RID: 38308
	public Action<GClass1892, IEnumerable<GClass1892>> OnSetKeys;

	// Token: 0x02001A40 RID: 6720
	protected enum EKeyState
	{
		// Token: 0x040095A6 RID: 38310
		ClickIdling,
		// Token: 0x040095A7 RID: 38311
		ClickWaitForRelease,
		// Token: 0x040095A8 RID: 38312
		ContinuousIdling,
		// Token: 0x040095A9 RID: 38313
		ContinuousPressed,
		// Token: 0x040095AA RID: 38314
		LongTapPressed,
		// Token: 0x040095AB RID: 38315
		LongTapWaitForRelease,
		// Token: 0x040095AC RID: 38316
		ReleaseIdling,
		// Token: 0x040095AD RID: 38317
		ReleasePressed,
		// Token: 0x040095AE RID: 38318
		ReleaseStuck,
		// Token: 0x040095AF RID: 38319
		DoubleClickIdling,
		// Token: 0x040095B0 RID: 38320
		WaitingForFirstRelease,
		// Token: 0x040095B1 RID: 38321
		WaitingForSecondPress,
		// Token: 0x040095B2 RID: 38322
		WaitingForSecondRelease
	}

	// Token: 0x02001A41 RID: 6721
	protected abstract class KeyCombinationState
	{
		// Token: 0x06008E51 RID: 36433
		public abstract ECommand GetCommand(float deltaTime);

		// Token: 0x06008E52 RID: 36434 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Enter()
		{
			throw null;
		}

		// Token: 0x06008E53 RID: 36435 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual ECommand GetCommandInternal()
		{
			throw null;
		}

		// Token: 0x06008E54 RID: 36436 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void HandleKeys(bool justForThisFrame)
		{
			throw null;
		}

		// Token: 0x06008E55 RID: 36437 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void HandleNotUsedKeys(bool justForThisFrame)
		{
			throw null;
		}

		// Token: 0x06008E56 RID: 36438 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void UnhandleKeys(EKeyPress? restoreValue = null)
		{
			throw null;
		}

		// Token: 0x06008E57 RID: 36439 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected bool GetKeysStatus(out EKeyPress keysStatus)
		{
			throw null;
		}

		// Token: 0x040095B3 RID: 38323
		protected readonly GClass1892 KeyCombination;
	}

	// Token: 0x02001A42 RID: 6722
	private abstract class Class1572 : GClass1892.KeyCombinationState
	{
		// Token: 0x06008E58 RID: 36440
		protected abstract GClass1892.EKeyState vmethod_0();

		// Token: 0x06008E59 RID: 36441 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override ECommand GetCommand(float deltaTime)
		{
			throw null;
		}
	}

	// Token: 0x02001A43 RID: 6723
	private abstract class Class1575 : GClass1892.KeyCombinationState
	{
		// Token: 0x06008E5A RID: 36442 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected bool method_0(float deltaTime)
		{
			throw null;
		}
	}

	// Token: 0x02001A44 RID: 6724
	private sealed class Class1580 : GClass1892.KeyCombinationState
	{
		// Token: 0x06008E5B RID: 36443 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override ECommand GetCommand(float deltaTime)
		{
			throw null;
		}
	}

	// Token: 0x02001A45 RID: 6725
	protected class ContinuousIdlingState : GClass1892.KeyCombinationState
	{
		// Token: 0x06008E5C RID: 36444 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override ECommand GetCommand(float deltaTime)
		{
			throw null;
		}

		// Token: 0x06008E5D RID: 36445 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected bool CanProcess()
		{
			throw null;
		}
	}

	// Token: 0x02001A46 RID: 6726
	protected class ContinuousPressedState : GClass1892.KeyCombinationState
	{
		// Token: 0x06008E5E RID: 36446 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override ECommand GetCommand(float deltaTime)
		{
			throw null;
		}
	}

	// Token: 0x02001A47 RID: 6727
	private sealed class Class1576 : GClass1892.Class1575
	{
		// Token: 0x06008E5F RID: 36447 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override ECommand GetCommand(float deltaTime)
		{
			throw null;
		}

		// Token: 0x06008E60 RID: 36448 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Enter()
		{
			throw null;
		}
	}

	// Token: 0x02001A48 RID: 6728
	private sealed class Class1573 : GClass1892.Class1572
	{
		// Token: 0x06008E61 RID: 36449 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override GClass1892.EKeyState vmethod_0()
		{
			throw null;
		}
	}

	// Token: 0x02001A49 RID: 6729
	private sealed class Class1583 : GClass1892.KeyCombinationState
	{
		// Token: 0x06008E62 RID: 36450 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override ECommand GetCommand(float deltaTime)
		{
			throw null;
		}
	}

	// Token: 0x02001A4A RID: 6730
	private sealed class Class1577 : GClass1892.Class1575
	{
		// Token: 0x06008E63 RID: 36451 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override ECommand GetCommand(float deltaTime)
		{
			throw null;
		}

		// Token: 0x06008E64 RID: 36452 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Enter()
		{
			throw null;
		}
	}

	// Token: 0x02001A4B RID: 6731
	private sealed class Class1578 : GClass1892.Class1575
	{
		// Token: 0x06008E65 RID: 36453 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override ECommand GetCommand(float deltaTime)
		{
			throw null;
		}
	}

	// Token: 0x02001A4C RID: 6732
	private sealed class Class1579 : GClass1892.Class1575
	{
		// Token: 0x06008E66 RID: 36454 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override ECommand GetCommand(float deltaTime)
		{
			throw null;
		}
	}

	// Token: 0x02001A4D RID: 6733
	private sealed class Class1584 : GClass1892.KeyCombinationState
	{
		// Token: 0x06008E67 RID: 36455 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override ECommand GetCommand(float deltaTime)
		{
			throw null;
		}
	}

	// Token: 0x02001A4E RID: 6734
	private sealed class Class1574 : GClass1892.Class1572
	{
		// Token: 0x06008E68 RID: 36456 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override GClass1892.EKeyState vmethod_0()
		{
			throw null;
		}
	}

	// Token: 0x02001A4F RID: 6735
	private sealed class Class1585 : GClass1892.KeyCombinationState
	{
		// Token: 0x06008E69 RID: 36457 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override ECommand GetCommand(float deltaTime)
		{
			throw null;
		}
	}

	// Token: 0x02001A50 RID: 6736
	private sealed class Class1586 : GClass1892.KeyCombinationState
	{
		// Token: 0x06008E6A RID: 36458 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override ECommand GetCommand(float deltaTime)
		{
			throw null;
		}
	}

	// Token: 0x02001A51 RID: 6737
	private sealed class Class1587 : GClass1892.KeyCombinationState
	{
		// Token: 0x06008E6B RID: 36459 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override ECommand GetCommand(float deltaTime)
		{
			throw null;
		}
	}
}
