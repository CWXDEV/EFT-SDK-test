using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000BB1 RID: 2993
[ExecuteInEditMode]
public class CullingAdvancedLightObject : CullingObject
{
	// Token: 0x17000A7B RID: 2683
	// (set) Token: 0x060040D1 RID: 16593 RVA: 0x00002050 File Offset: 0x00000250
	public float IntensityMultiplier
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x060040D2 RID: 16594 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Awake()
	{
		throw null;
	}

	// Token: 0x060040D3 RID: 16595 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void CustomUpdate()
	{
		throw null;
	}

	// Token: 0x060040D4 RID: 16596 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SetVisibility(bool isVisible)
	{
		throw null;
	}

	// Token: 0x060040D5 RID: 16597 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1()
	{
		throw null;
	}

	// Token: 0x060040D6 RID: 16598 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void UpdateCullingObject(float multiplier)
	{
		throw null;
	}

	// Token: 0x060040D7 RID: 16599 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected float CalculateMultiplayer()
	{
		throw null;
	}

	// Token: 0x060040D8 RID: 16600 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnDisable()
	{
		throw null;
	}

	// Token: 0x060040D9 RID: 16601 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnDestroy()
	{
		throw null;
	}

	// Token: 0x04004A0F RID: 18959
	[SerializeField]
	private BaseLight _light;

	// Token: 0x04004A10 RID: 18960
	[SerializeField]
	private float _fadeStartDistance;

	// Token: 0x04004A11 RID: 18961
	[SerializeField]
	private float _fadeEndDistance;

	// Token: 0x04004A12 RID: 18962
	[SerializeField]
	private AnimationCurve _fadeCurve;

	// Token: 0x04004A13 RID: 18963
	[SerializeField]
	private float _maxLightIntensity;

	// Token: 0x04004A14 RID: 18964
	[SerializeField]
	private bool _isControlledByLampController;

	// Token: 0x04004A15 RID: 18965
	private float float_1;

	// Token: 0x04004A16 RID: 18966
	private float float_2;

	// Token: 0x04004A17 RID: 18967
	private static int int_1;

	// Token: 0x04004A18 RID: 18968
	private int int_2;

	// Token: 0x04004A19 RID: 18969
	private int int_3;

	// Token: 0x04004A1A RID: 18970
	private const int int_4 = 20;

	// Token: 0x04004A1B RID: 18971
	private float float_3;

	// Token: 0x04004A1C RID: 18972
	private float float_4;

	// Token: 0x04004A1D RID: 18973
	private float float_5;
}
