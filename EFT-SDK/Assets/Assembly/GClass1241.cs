using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x0200100E RID: 4110
public class GClass1241 : GInterface81
{
	// Token: 0x17000D7F RID: 3455
	// (get) Token: 0x060055E0 RID: 21984 RVA: 0x00002050 File Offset: 0x00000250
	public string Name
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000D80 RID: 3456
	// (get) Token: 0x060055E1 RID: 21985 RVA: 0x00002050 File Offset: 0x00000250
	public GClass1241.EBlendType Type
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000D81 RID: 3457
	// (get) Token: 0x060055E2 RID: 21986 RVA: 0x00002050 File Offset: 0x00000250
	public int ParameterXHash
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000D82 RID: 3458
	// (get) Token: 0x060055E3 RID: 21987 RVA: 0x00002050 File Offset: 0x00000250
	public int ParameterYHash
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000D83 RID: 3459
	// (get) Token: 0x060055E4 RID: 21988 RVA: 0x00002050 File Offset: 0x00000250
	public float MaxClipTime
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000D84 RID: 3460
	// (get) Token: 0x060055E5 RID: 21989 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsLooping
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000D85 RID: 3461
	// (get) Token: 0x060055E6 RID: 21990 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3 PosMotion
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000D86 RID: 3462
	// (get) Token: 0x060055E7 RID: 21991 RVA: 0x00002050 File Offset: 0x00000250
	public Quaternion PosRotation
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000D87 RID: 3463
	// (get) Token: 0x060055E8 RID: 21992 RVA: 0x00002050 File Offset: 0x00000250
	public int ChildrenCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060055E9 RID: 21993 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Serialize(BinaryWriter writer)
	{
		throw null;
	}

	// Token: 0x060055EA RID: 21994 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Deserialize(BinaryReader reader)
	{
		throw null;
	}

	// Token: 0x060055EB RID: 21995 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitChilds(IEnumerable<GInterface81> nodes)
	{
		throw null;
	}

	// Token: 0x060055EC RID: 21996 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitBlend1DParameters(float[] childrenThresholds)
	{
		throw null;
	}

	// Token: 0x060055ED RID: 21997 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitDirectBlendParameters(int[] directBlendHashes)
	{
		throw null;
	}

	// Token: 0x060055EE RID: 21998 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitBlend2DParameters(Vector2[] childrenPositions)
	{
		throw null;
	}

	// Token: 0x060055EF RID: 21999 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x060055F0 RID: 22000 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector3 ComputeRootPosition(float deltaTime, float stateNormalizedTime, GInterface82 parametersCache)
	{
		throw null;
	}

	// Token: 0x060055F1 RID: 22001 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Quaternion ComputeDeltaRotation(float deltaTime, GInterface82 parametersCache)
	{
		throw null;
	}

	// Token: 0x060055F2 RID: 22002 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public float ComputeClipTime(GInterface82 parametersCache)
	{
		throw null;
	}

	// Token: 0x060055F3 RID: 22003 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ComputeActiveClips(List<GStruct106> nodes, GInterface82 parametersCache)
	{
		throw null;
	}

	// Token: 0x060055F4 RID: 22004 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector3 ComputeRootPosition(float deltaTime, float stateNormalizedTime, GInterface82 parametersCache, float[] weights)
	{
		throw null;
	}

	// Token: 0x060055F5 RID: 22005 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Quaternion ComputeDeltaRotation(float deltaTime, GInterface82 parametersCache, float[] weights)
	{
		throw null;
	}

	// Token: 0x060055F6 RID: 22006 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public float ComputeClipTime(GInterface82 parametersCache, float[] weights)
	{
		throw null;
	}

	// Token: 0x060055F7 RID: 22007 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ComputeActiveNodes(List<GStruct106> nodes, GInterface82 parametersCache, float[] weights)
	{
		throw null;
	}

	// Token: 0x060055F8 RID: 22008 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ComputeWeights(float blendValueX, float blendValueY, ref float[] weights)
	{
		throw null;
	}

	// Token: 0x060055F9 RID: 22009 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(GInterface82 parametersCache)
	{
		throw null;
	}

	// Token: 0x060055FA RID: 22010 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private float method_2(int i, int j, Vector2 blendPosition)
	{
		throw null;
	}

	// Token: 0x060055FB RID: 22011 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3(float blendValueX, float blendValueY, bool preCompute = false)
	{
		throw null;
	}

	// Token: 0x060055FC RID: 22012 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4(float blendValueX, float blendValueY, bool preCompute = false)
	{
		throw null;
	}

	// Token: 0x060055FD RID: 22013 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_5(float blendValueX, float blendValueY)
	{
		throw null;
	}

	// Token: 0x060055FE RID: 22014 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_6(float blendValue)
	{
		throw null;
	}

	// Token: 0x060055FF RID: 22015 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private float method_7(int index, float blend)
	{
		throw null;
	}

	// Token: 0x06005600 RID: 22016 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_8(GInterface82 allParameters)
	{
		throw null;
	}

	// Token: 0x06005601 RID: 22017 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Vector3 method_9(in float[] childBlends, in Vector3[] childRootPositions)
	{
		throw null;
	}

	// Token: 0x06005602 RID: 22018 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Quaternion method_10(in float[] childBlends, in Quaternion[] childRotations)
	{
		throw null;
	}

	// Token: 0x06005603 RID: 22019 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private float method_11(in float[] childBlends, in float[] childClipTimes)
	{
		throw null;
	}

	// Token: 0x06005604 RID: 22020 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private float method_12(Vector2 lhs, Vector2 rhs)
	{
		throw null;
	}

	// Token: 0x04006211 RID: 25105
	private const float float_0 = 0.31830987f;

	// Token: 0x04006212 RID: 25106
	private const float float_1 = 0.01f;

	// Token: 0x04006213 RID: 25107
	private static readonly Vector3 vector3_0;

	// Token: 0x04006214 RID: 25108
	private string string_0;

	// Token: 0x04006215 RID: 25109
	private List<GInterface81> list_0;

	// Token: 0x04006216 RID: 25110
	private List<GStruct106> list_1;

	// Token: 0x04006217 RID: 25111
	private GClass1241.EBlendType eblendType_0;

	// Token: 0x04006218 RID: 25112
	private int int_0;

	// Token: 0x04006219 RID: 25113
	private int int_1;

	// Token: 0x0400621A RID: 25114
	private int int_2;

	// Token: 0x0400621B RID: 25115
	private float[] float_2;

	// Token: 0x0400621C RID: 25116
	private Vector2[] vector2_0;

	// Token: 0x0400621D RID: 25117
	private int[] int_3;

	// Token: 0x0400621E RID: 25118
	private float[] float_3;

	// Token: 0x0400621F RID: 25119
	private Vector3[] vector3_1;

	// Token: 0x04006220 RID: 25120
	private Quaternion[] quaternion_0;

	// Token: 0x04006221 RID: 25121
	private float[] float_4;

	// Token: 0x04006222 RID: 25122
	private Vector2[] vector2_1;

	// Token: 0x04006223 RID: 25123
	private float[] float_5;

	// Token: 0x04006224 RID: 25124
	private Vector2[] vector2_2;

	// Token: 0x04006225 RID: 25125
	private float[] float_6;

	// Token: 0x04006226 RID: 25126
	private int[] int_4;

	// Token: 0x04006227 RID: 25127
	private bool[] bool_0;

	// Token: 0x04006228 RID: 25128
	private int[][] int_5;

	// Token: 0x04006229 RID: 25129
	[CompilerGenerated]
	private readonly bool bool_1;

	// Token: 0x0200100F RID: 4111
	public enum EBlendType : byte
	{
		// Token: 0x0400622B RID: 25131
		None,
		// Token: 0x0400622C RID: 25132
		Simple1D,
		// Token: 0x0400622D RID: 25133
		FreeformDirectional2D,
		// Token: 0x0400622E RID: 25134
		FreeformCartesian2D,
		// Token: 0x0400622F RID: 25135
		SimpleDirectional2D,
		// Token: 0x04006230 RID: 25136
		Direct
	}
}
