using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000A34 RID: 2612
public class AmbientHighlight : OnRenderObjectConnector
{
	// Token: 0x06003963 RID: 14691 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Start()
	{
		throw null;
	}

	// Token: 0x06003964 RID: 14692 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void ManualOnRenderObject(Camera currentCamera)
	{
		throw null;
	}

	// Token: 0x06003965 RID: 14693 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(CommandBuffer ambientBuffer, Camera currentCamera)
	{
		throw null;
	}

	// Token: 0x06003966 RID: 14694 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private new void OnDestroy()
	{
		throw null;
	}

	// Token: 0x06003967 RID: 14695 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetSH(SphericalHarmonicsL2 sh)
	{
		throw null;
	}

	// Token: 0x06003968 RID: 14696 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Mesh GetQuadMesh()
	{
		throw null;
	}

	// Token: 0x04003BD3 RID: 15315
	[SerializeField]
	private float AmbientBlur;

	// Token: 0x04003BD4 RID: 15316
	[SerializeField]
	private Material AmbientMaterial;

	// Token: 0x04003BD5 RID: 15317
	[SerializeField]
	private AmbientHighlight.HighlightSettings[] _highlightSettings;

	// Token: 0x04003BD6 RID: 15318
	[SerializeField]
	private AmbientHighlight.AmbientDirectionalLight[] _additionalLights;

	// Token: 0x04003BD7 RID: 15319
	private GClass884 gclass884_0;

	// Token: 0x04003BD8 RID: 15320
	private static Mesh mesh_0;

	// Token: 0x04003BD9 RID: 15321
	private static readonly Matrix4x4 matrix4x4_0;

	// Token: 0x04003BDA RID: 15322
	private static readonly int int_0;

	// Token: 0x04003BDB RID: 15323
	private static readonly int int_1;

	// Token: 0x04003BDC RID: 15324
	private static readonly int[] int_2;

	// Token: 0x04003BDD RID: 15325
	private static readonly int[] int_3;

	// Token: 0x04003BDE RID: 15326
	private static readonly int int_4;

	// Token: 0x04003BDF RID: 15327
	private static readonly int int_5;

	// Token: 0x04003BE0 RID: 15328
	private static readonly int int_6;

	// Token: 0x04003BE1 RID: 15329
	private static readonly int int_7;

	// Token: 0x04003BE2 RID: 15330
	private MaterialPropertyBlock materialPropertyBlock_0;

	// Token: 0x02000A35 RID: 2613
	[Serializable]
	private struct AmbientDirectionalLight
	{
		// Token: 0x04003BE3 RID: 15331
		public Transform LightTransform;

		// Token: 0x04003BE4 RID: 15332
		public Color Color;

		// Token: 0x04003BE5 RID: 15333
		public float Intensity;
	}

	// Token: 0x02000A36 RID: 2614
	public enum StencilType
	{
		// Token: 0x04003BE7 RID: 15335
		Static,
		// Token: 0x04003BE8 RID: 15336
		Characters,
		// Token: 0x04003BE9 RID: 15337
		Hands
	}

	// Token: 0x02000A37 RID: 2615
	[Serializable]
	private class HighlightSettings
	{
		// Token: 0x04003BEA RID: 15338
		public float HighlightMinMultiplier;

		// Token: 0x04003BEB RID: 15339
		public float HighlightMaxMultiplier;

		// Token: 0x04003BEC RID: 15340
		public AnimationCurve HighlightIntensityCurve;

		// Token: 0x04003BED RID: 15341
		public AmbientHighlight.StencilType StencilTypeToUse;
	}
}
