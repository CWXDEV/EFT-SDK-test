using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000A75 RID: 2677
[RequireComponent(typeof(Camera))]
public class FastBlur : MonoBehaviour
{
	// Token: 0x06003AF1 RID: 15089 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06003AF2 RID: 15090 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	// Token: 0x06003AF3 RID: 15091 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Hit(float power)
	{
		throw null;
	}

	// Token: 0x06003AF4 RID: 15092 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Die()
	{
		throw null;
	}

	// Token: 0x06003AF5 RID: 15093 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Reset()
	{
		throw null;
	}

	// Token: 0x06003AF6 RID: 15094 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Update()
	{
		throw null;
	}

	// Token: 0x06003AF7 RID: 15095 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		throw null;
	}

	// Token: 0x06003AF8 RID: 15096 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void OnRenderImageImpl(RenderTexture source, RenderTexture destanation)
	{
		throw null;
	}

	// Token: 0x04003E68 RID: 15976
	[Header("Blur Setup")]
	[SerializeField]
	[Range(0f, 1f)]
	private float _value;

	// Token: 0x04003E69 RID: 15977
	[SerializeField]
	private Material _material;

	// Token: 0x04003E6A RID: 15978
	[SerializeField]
	private FastBlur.Dimensions _upsampleTexDimension;

	// Token: 0x04003E6B RID: 15979
	[SerializeField]
	private FastBlur.Dimensions _downsampleTexDimension;

	// Token: 0x04003E6C RID: 15980
	[Range(1f, 8f)]
	[SerializeField]
	private int _blurCount;

	// Token: 0x04003E6D RID: 15981
	[Header("Hit")]
	[SerializeField]
	private float _hitNoise;

	// Token: 0x04003E6E RID: 15982
	[SerializeField]
	private float _hitTime;

	// Token: 0x04003E6F RID: 15983
	[SerializeField]
	private AnimationCurve _hitCurve;

	// Token: 0x04003E70 RID: 15984
	[SerializeField]
	[Header("Death")]
	private float _deathTime;

	// Token: 0x04003E71 RID: 15985
	[SerializeField]
	private AnimationCurve _deathCurve;

	// Token: 0x04003E72 RID: 15986
	private SSAAPropagator ssaapropagator_0;

	// Token: 0x04003E73 RID: 15987
	private float float_0;

	// Token: 0x04003E74 RID: 15988
	private float float_1;

	// Token: 0x04003E75 RID: 15989
	private AnimationCurve animationCurve_0;

	// Token: 0x04003E76 RID: 15990
	private bool bool_0;

	// Token: 0x04003E77 RID: 15991
	private float float_2;

	// Token: 0x04003E78 RID: 15992
	private static readonly int int_0;

	// Token: 0x04003E79 RID: 15993
	private static readonly int int_1;

	// Token: 0x02000A76 RID: 2678
	[Serializable]
	public enum Dimensions
	{
		// Token: 0x04003E7B RID: 15995
		_128 = 128,
		// Token: 0x04003E7C RID: 15996
		_256 = 256,
		// Token: 0x04003E7D RID: 15997
		_512 = 512,
		// Token: 0x04003E7E RID: 15998
		_1024 = 1024,
		// Token: 0x04003E7F RID: 15999
		_2048 = 2048
	}
}
