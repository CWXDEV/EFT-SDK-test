using System;
using System.Runtime.CompilerServices;
using GPUInstancer;
using UnityEngine;

// Token: 0x02000820 RID: 2080
public class BoidController : MonoBehaviour
{
	// Token: 0x06002FB2 RID: 12210 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	// Token: 0x06002FB3 RID: 12211 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Spawn(int index)
	{
		throw null;
	}

	// Token: 0x06002FB4 RID: 12212 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	// Token: 0x04002EDA RID: 11994
	public int spawnCount;

	// Token: 0x04002EDB RID: 11995
	public float spawnRadius;

	// Token: 0x04002EDC RID: 11996
	[Range(0.1f, 20f)]
	public float velocity;

	// Token: 0x04002EDD RID: 11997
	[Range(0f, 0.9f)]
	public float velocityVariation;

	// Token: 0x04002EDE RID: 11998
	[Range(0.1f, 20f)]
	public float rotationCoeff;

	// Token: 0x04002EDF RID: 11999
	[Range(0.1f, 10f)]
	public float neighborDist;

	// Token: 0x04002EE0 RID: 12000
	private Matrix4x4[] matrix4x4_0;

	// Token: 0x04002EE1 RID: 12001
	private Vector4[] vector4_0;

	// Token: 0x04002EE2 RID: 12002
	public Transform centerTransform;

	// Token: 0x04002EE3 RID: 12003
	public Texture2D noiseTexture;

	// Token: 0x04002EE4 RID: 12004
	private GPUInstancerPrefabManager gpuinstancerPrefabManager_0;

	// Token: 0x04002EE5 RID: 12005
	private ComputeShader computeShader_0;

	// Token: 0x04002EE6 RID: 12006
	private string string_0;

	// Token: 0x04002EE7 RID: 12007
	private float[] float_0;

	// Token: 0x04002EE8 RID: 12008
	private ComputeBuffer computeBuffer_0;

	// Token: 0x02000821 RID: 2081
	public static class GClass772
	{
		// Token: 0x04002EE9 RID: 12009
		public static readonly int BP_boidsData;

		// Token: 0x04002EEA RID: 12010
		public static readonly int BP_bufferSize;

		// Token: 0x04002EEB RID: 12011
		public static readonly int BP_controllerTransform;

		// Token: 0x04002EEC RID: 12012
		public static readonly int BP_controllerVelocity;

		// Token: 0x04002EED RID: 12013
		public static readonly int BP_controllerVelocityVariation;

		// Token: 0x04002EEE RID: 12014
		public static readonly int BP_controllerRotationCoeff;

		// Token: 0x04002EEF RID: 12015
		public static readonly int BP_controllerNeighborDist;

		// Token: 0x04002EF0 RID: 12016
		public static readonly int BP_time;

		// Token: 0x04002EF1 RID: 12017
		public static readonly int BP_deltaTime;

		// Token: 0x04002EF2 RID: 12018
		public static readonly int BP_noiseTexture;
	}
}
