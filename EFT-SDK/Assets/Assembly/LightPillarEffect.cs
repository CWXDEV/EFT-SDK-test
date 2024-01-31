using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000827 RID: 2087
public class LightPillarEffect : HalloweenEffect
{
	// Token: 0x06002FC8 RID: 12232 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Initialize(Vector3 position)
	{
		throw null;
	}

	// Token: 0x06002FC9 RID: 12233 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetValue(bool value)
	{
		throw null;
	}

	// Token: 0x06002FCA RID: 12234 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override IEnumerator RunProcess()
	{
		throw null;
	}

	// Token: 0x06002FCB RID: 12235 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator method_0()
	{
		throw null;
	}

	// Token: 0x06002FCC RID: 12236 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator method_1()
	{
		throw null;
	}

	// Token: 0x06002FCD RID: 12237 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2()
	{
		throw null;
	}

	// Token: 0x06002FCE RID: 12238 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LateUpdate()
	{
		throw null;
	}

	// Token: 0x06002FCF RID: 12239 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		throw null;
	}

	// Token: 0x06002FD0 RID: 12240 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3()
	{
		throw null;
	}

	// Token: 0x04002F02 RID: 12034
	private static readonly int int_0;

	// Token: 0x04002F03 RID: 12035
	private static readonly int int_1;

	// Token: 0x04002F04 RID: 12036
	private MaterialPropertyBlock materialPropertyBlock_0;

	// Token: 0x04002F05 RID: 12037
	private MaterialPropertyBlock materialPropertyBlock_1;

	// Token: 0x04002F06 RID: 12038
	private Vector3 vector3_0;

	// Token: 0x04002F07 RID: 12039
	private bool bool_0;

	// Token: 0x04002F08 RID: 12040
	private bool bool_1;

	// Token: 0x04002F09 RID: 12041
	[SerializeField]
	private MeshRenderer _renderer;

	// Token: 0x04002F0A RID: 12042
	[SerializeField]
	private Vector2 _minMaxDistanceToFade;

	// Token: 0x04002F0B RID: 12043
	[SerializeField]
	private AnimationCurve _lightPillarFade;

	// Token: 0x04002F0C RID: 12044
	[Space]
	[SerializeField]
	private MeshRenderer _rendererGlow;

	// Token: 0x04002F0D RID: 12045
	[SerializeField]
	private Vector2 _minMaxDistanceGlowToFade;

	// Token: 0x04002F0E RID: 12046
	[SerializeField]
	private AnimationCurve _lightPillarGlowFade;

	// Token: 0x04002F0F RID: 12047
	[Space]
	[SerializeField]
	[Range(0f, 1f)]
	private float _heightFade;

	// Token: 0x04002F10 RID: 12048
	[Range(0f, 1f)]
	[SerializeField]
	private float _speed;

	// Token: 0x04002F11 RID: 12049
	[SerializeField]
	private ParticleSystem _fire;

	// Token: 0x04002F12 RID: 12050
	private bool bool_2;
}
