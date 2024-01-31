using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000939 RID: 2361
public class HysteresisFilter : MonoBehaviour
{
	// Token: 0x140000AD RID: 173
	// (add) Token: 0x06003553 RID: 13651 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06003554 RID: 13652 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<bool, bool> OnEnd
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

	// Token: 0x1700091B RID: 2331
	// (get) Token: 0x06003555 RID: 13653 RVA: 0x00002050 File Offset: 0x00000250
	public bool Direction
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x140000AE RID: 174
	// (add) Token: 0x06003556 RID: 13654 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06003557 RID: 13655 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<float> OnValueChanged
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

	// Token: 0x06003558 RID: 13656 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(Action<float> action)
	{
		throw null;
	}

	// Token: 0x06003559 RID: 13657 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnEnable()
	{
		throw null;
	}

	// Token: 0x0600355A RID: 13658 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		throw null;
	}

	// Token: 0x0600355B RID: 13659 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Deinit()
	{
		throw null;
	}

	// Token: 0x0600355C RID: 13660 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Set(bool isOn, bool initial)
	{
		throw null;
	}

	// Token: 0x0600355D RID: 13661 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_0()
	{
		throw null;
	}

	// Token: 0x0600355E RID: 13662 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	// Token: 0x04003641 RID: 13889
	public AnimationCurve Forward;

	// Token: 0x04003642 RID: 13890
	public AnimationCurve Backward;

	// Token: 0x04003643 RID: 13891
	[CompilerGenerated]
	private Action<bool, bool> action_0;

	// Token: 0x04003644 RID: 13892
	private Action<float> action_1;

	// Token: 0x04003645 RID: 13893
	private bool bool_0;

	// Token: 0x04003646 RID: 13894
	private float float_0;

	// Token: 0x04003647 RID: 13895
	private float float_1;

	// Token: 0x04003648 RID: 13896
	private float float_2;

	// Token: 0x04003649 RID: 13897
	[CompilerGenerated]
	private Action<float> action_2;
}
