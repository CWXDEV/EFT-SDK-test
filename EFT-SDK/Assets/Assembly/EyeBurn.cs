using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000A71 RID: 2673
public class EyeBurn : MonoBehaviour
{
	// Token: 0x170009BF RID: 2495
	// (get) Token: 0x06003AD8 RID: 15064 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003AD9 RID: 15065 RVA: 0x00002050 File Offset: 0x00000250
	public bool EyesBurn
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

	// Token: 0x06003ADA RID: 15066 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06003ADB RID: 15067 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnEnable()
	{
		throw null;
	}

	// Token: 0x06003ADC RID: 15068 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		throw null;
	}

	// Token: 0x06003ADD RID: 15069 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	// Token: 0x06003ADE RID: 15070 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		throw null;
	}

	// Token: 0x06003ADF RID: 15071 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Burn(Vector3 position, float stregnth, Vector2 deltaRotation)
	{
		throw null;
	}

	// Token: 0x06003AE0 RID: 15072 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Draw(Vector3 position, Vector3 scale, float rotation, Material material, float coef, float scaleCoef)
	{
		throw null;
	}

	// Token: 0x06003AE1 RID: 15073 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private RenderTexture method_0()
	{
		throw null;
	}

	// Token: 0x06003AE2 RID: 15074 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator method_1(float t)
	{
		throw null;
	}

	// Token: 0x06003AE3 RID: 15075 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2(Vector3 screenPosition, Vector3 scale, float eyeBurnTime)
	{
		throw null;
	}

	// Token: 0x06003AE4 RID: 15076 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3(Vector3 direction, Vector3 scale, float eyeBurnTime)
	{
		throw null;
	}

	// Token: 0x06003AE5 RID: 15077 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_4(Vector3 screenPosition)
	{
		throw null;
	}

	// Token: 0x06003AE6 RID: 15078 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Vector3 method_5(Vector3 screenPosition)
	{
		throw null;
	}

	// Token: 0x06003AE7 RID: 15079 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClearEyeBurnRT()
	{
		throw null;
	}

	// Token: 0x04003E38 RID: 15928
	public Material EyeBurnScreenEffect;

	// Token: 0x04003E39 RID: 15929
	[SerializeField]
	private Material[] _eyeBurnEffectMaterial;

	// Token: 0x04003E3A RID: 15930
	[SerializeField]
	private Material[] _eyeBurnTrailMaterial;

	// Token: 0x04003E3B RID: 15931
	[SerializeField]
	private Vector2 _scaleMinMax;

	// Token: 0x04003E3C RID: 15932
	[SerializeField]
	private float _eyeBurnMaxTime;

	// Token: 0x04003E3D RID: 15933
	[SerializeField]
	private float TrailSpotEvery;

	// Token: 0x04003E3E RID: 15934
	[SerializeField]
	private float TrailSpotShift;

	// Token: 0x04003E3F RID: 15935
	[SerializeField]
	private AnimationCurve trailDecreaseCurve;

	// Token: 0x04003E40 RID: 15936
	[SerializeField]
	private int MaxTrailLength;

	// Token: 0x04003E41 RID: 15937
	[SerializeField]
	private AnimationCurve _scaleCoefCurve;

	// Token: 0x04003E42 RID: 15938
	[CompilerGenerated]
	private bool bool_0;

	// Token: 0x04003E43 RID: 15939
	public bool IsPaused;

	// Token: 0x04003E44 RID: 15940
	private const string string_0 = "_Rotation";

	// Token: 0x04003E45 RID: 15941
	private const string string_1 = "_Coef";

	// Token: 0x04003E46 RID: 15942
	private RenderTexture renderTexture_0;

	// Token: 0x04003E47 RID: 15943
	private Coroutine coroutine_0;

	// Token: 0x04003E48 RID: 15944
	private List<EyeBurn.Class542> list_0;

	// Token: 0x04003E49 RID: 15945
	private int int_0;

	// Token: 0x04003E4A RID: 15946
	private Vector3 vector3_0;

	// Token: 0x04003E4B RID: 15947
	private static readonly int int_1;

	// Token: 0x04003E4C RID: 15948
	protected SSAAPropagator _ssaaPropagator;

	// Token: 0x02000A72 RID: 2674
	private class Class542
	{
		// Token: 0x04003E4D RID: 15949
		public Vector3 ScreenPosition;

		// Token: 0x04003E4E RID: 15950
		public Material Material;

		// Token: 0x04003E4F RID: 15951
		public float Rotation;

		// Token: 0x04003E50 RID: 15952
		public Vector3 Scale;

		// Token: 0x04003E51 RID: 15953
		public float StartTime;

		// Token: 0x04003E52 RID: 15954
		public float MaxTime;
	}
}
