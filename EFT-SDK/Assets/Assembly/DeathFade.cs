using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000A48 RID: 2632
[RequireComponent(typeof(Camera))]
[ExecuteInEditMode]
[DisallowMultipleComponent]
public class DeathFade : MonoBehaviour
{
	// Token: 0x060039BA RID: 14778 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EnableEffect()
	{
		throw null;
	}

	// Token: 0x060039BB RID: 14779 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DisableEffect()
	{
		throw null;
	}

	// Token: 0x060039BC RID: 14780 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x060039BD RID: 14781 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	// Token: 0x060039BE RID: 14782 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		throw null;
	}

	// Token: 0x060039BF RID: 14783 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(RenderTexture source, RenderTexture destination)
	{
		throw null;
	}

	// Token: 0x04003CD7 RID: 15575
	[SerializeField]
	private Material _deathFade;

	// Token: 0x04003CD8 RID: 15576
	[SerializeField]
	private Material _deathColorFade;

	// Token: 0x04003CD9 RID: 15577
	[SerializeField]
	private Color _color;

	// Token: 0x04003CDA RID: 15578
	[SerializeField]
	private float _closeEyesTime;

	// Token: 0x04003CDB RID: 15579
	[SerializeField]
	private float _closeEyesDelay;

	// Token: 0x04003CDC RID: 15580
	[SerializeField]
	private float _disableTime;

	// Token: 0x04003CDD RID: 15581
	[SerializeField]
	private AnimationCurve _enableCurve;

	// Token: 0x04003CDE RID: 15582
	[SerializeField]
	private AnimationCurve _disableCurve;

	// Token: 0x04003CDF RID: 15583
	[SerializeField]
	private bool _debug;

	// Token: 0x04003CE0 RID: 15584
	private float float_0;

	// Token: 0x04003CE1 RID: 15585
	[Range(0f, 1f)]
	[SerializeField]
	private float _closeEyesValue;

	// Token: 0x04003CE2 RID: 15586
	[SerializeField]
	[Range(0f, 1f)]
	private float _fadeValue;

	// Token: 0x04003CE3 RID: 15587
	private bool bool_0;

	// Token: 0x04003CE4 RID: 15588
	private float float_1;

	// Token: 0x04003CE5 RID: 15589
	private float float_2;

	// Token: 0x04003CE6 RID: 15590
	private AnimationCurve animationCurve_0;

	// Token: 0x04003CE7 RID: 15591
	private Material material_0;

	// Token: 0x04003CE8 RID: 15592
	private Material material_1;

	// Token: 0x04003CE9 RID: 15593
	private SSAAPropagator ssaapropagator_0;

	// Token: 0x04003CEA RID: 15594
	private float float_3;

	// Token: 0x04003CEB RID: 15595
	private static readonly int int_0;

	// Token: 0x04003CEC RID: 15596
	private static readonly int int_1;
}
