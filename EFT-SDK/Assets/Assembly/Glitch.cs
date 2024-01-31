using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000A7A RID: 2682
[RequireComponent(typeof(Camera))]
public class Glitch : MonoBehaviour
{
	// Token: 0x06003B01 RID: 15105 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		throw null;
	}

	// Token: 0x06003B02 RID: 15106 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x06003B03 RID: 15107 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1()
	{
		throw null;
	}

	// Token: 0x06003B04 RID: 15108 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private float method_2(float frequency)
	{
		throw null;
	}

	// Token: 0x04003E92 RID: 16018
	[SerializeField]
	private Shader _shader;

	// Token: 0x04003E93 RID: 16019
	[SerializeField]
	private Texture2D _displacementMap;

	// Token: 0x04003E94 RID: 16020
	[Header("Digital Mistake")]
	[SerializeField]
	[Range(0f, 1f)]
	private float _digitalMistakeIntensity;

	// Token: 0x04003E95 RID: 16021
	[SerializeField]
	[Range(0f, 1f)]
	private float _digitalMistakeFrequency;

	// Token: 0x04003E96 RID: 16022
	[Header("Vertical Flip")]
	[SerializeField]
	[Range(0f, 1f)]
	private float _verticalFlipIntensity;

	// Token: 0x04003E97 RID: 16023
	[Range(0f, 1f)]
	[SerializeField]
	private float _verticalFlipFrequency;

	// Token: 0x04003E98 RID: 16024
	[Header("Color Switch")]
	[SerializeField]
	[Range(0f, 1f)]
	private float _colorSwitchIntensity;

	// Token: 0x04003E99 RID: 16025
	[SerializeField]
	[Range(0f, 1f)]
	private float _colorSwitchFrequency;

	// Token: 0x04003E9A RID: 16026
	private float float_0;

	// Token: 0x04003E9B RID: 16027
	[SerializeField]
	[Header("Vertical Jump")]
	[Range(0f, 1f)]
	private float _verticalJumpCoef;

	// Token: 0x04003E9C RID: 16028
	[Range(0f, 1f)]
	[SerializeField]
	private float _verticalJumpFrequency;

	// Token: 0x04003E9D RID: 16029
	[SerializeField]
	private float _verticalJumpTimeScale;

	// Token: 0x04003E9E RID: 16030
	[SerializeField]
	[Range(0f, 1f)]
	[Header("Scan Line Jitter")]
	private float _scanLineJitterCoef;

	// Token: 0x04003E9F RID: 16031
	[SerializeField]
	[Range(0f, 1f)]
	private float _scanLineJitterFrequency;

	// Token: 0x04003EA0 RID: 16032
	[SerializeField]
	[Header("Horizontal Shake")]
	[Range(0f, 1f)]
	private float _horizontalShake;

	// Token: 0x04003EA1 RID: 16033
	[SerializeField]
	[Range(0f, 1f)]
	private float _horizontalShakeFrequency;

	// Token: 0x04003EA2 RID: 16034
	[Header("Color Drift")]
	[SerializeField]
	[Range(0f, 1f)]
	private float _colorDriftCoef;

	// Token: 0x04003EA3 RID: 16035
	[SerializeField]
	[Range(0f, 1f)]
	private float _colorDriftFrequency;

	// Token: 0x04003EA4 RID: 16036
	[SerializeField]
	private float _maxColorDrift;

	// Token: 0x04003EA5 RID: 16037
	private Material material_0;

	// Token: 0x04003EA6 RID: 16038
	private float float_1;

	// Token: 0x04003EA7 RID: 16039
	private float float_2;

	// Token: 0x04003EA8 RID: 16040
	private float float_3;

	// Token: 0x04003EA9 RID: 16041
	private float float_4;

	// Token: 0x04003EAA RID: 16042
	private float float_5;

	// Token: 0x04003EAB RID: 16043
	private float float_6;

	// Token: 0x04003EAC RID: 16044
	private static readonly int int_0;

	// Token: 0x04003EAD RID: 16045
	private static readonly int int_1;

	// Token: 0x04003EAE RID: 16046
	private static readonly int int_2;

	// Token: 0x04003EAF RID: 16047
	private static readonly int int_3;

	// Token: 0x04003EB0 RID: 16048
	private static readonly int int_4;

	// Token: 0x04003EB1 RID: 16049
	private static readonly int int_5;

	// Token: 0x04003EB2 RID: 16050
	private static readonly int int_6;

	// Token: 0x04003EB3 RID: 16051
	private static readonly int int_7;

	// Token: 0x04003EB4 RID: 16052
	private static readonly int int_8;

	// Token: 0x04003EB5 RID: 16053
	private static readonly int int_9;

	// Token: 0x04003EB6 RID: 16054
	private static readonly int int_10;

	// Token: 0x04003EB7 RID: 16055
	private static readonly int int_11;

	// Token: 0x04003EB8 RID: 16056
	private static readonly int int_12;
}
