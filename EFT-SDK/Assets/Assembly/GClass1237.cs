using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using AnimationSystem.RootMotionTable;
using UnityEngine;

// Token: 0x0200100A RID: 4106
public abstract class GClass1237 : GInterface81
{
	// Token: 0x060055BC RID: 21948 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ProcessParameterRec(GClass1237 node, Action<int> paramProcessor)
	{
		throw null;
	}

	// Token: 0x060055BD RID: 21949 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Vector3 ComputeRootMotion(Animator animator, float deltaTime, float stateNormalizedTime, GInterface82 allParameters, Dictionary<int, GClass1237> _cachedNodes)
	{
		throw null;
	}

	// Token: 0x17000D74 RID: 3444
	// (get) Token: 0x060055BE RID: 21950 RVA: 0x00002050 File Offset: 0x00000250
	public string Name
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000D75 RID: 3445
	// (get) Token: 0x060055BF RID: 21951 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3 PosMotion
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000D76 RID: 3446
	// (get) Token: 0x060055C0 RID: 21952 RVA: 0x00002050 File Offset: 0x00000250
	public Quaternion PosRotation
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000D77 RID: 3447
	// (get) Token: 0x060055C1 RID: 21953 RVA: 0x00002050 File Offset: 0x00000250
	public virtual int ParameterXHash
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000D78 RID: 3448
	// (get) Token: 0x060055C2 RID: 21954 RVA: 0x00002050 File Offset: 0x00000250
	public virtual int ParameterYHash
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000D79 RID: 3449
	// (get) Token: 0x060055C3 RID: 21955 RVA: 0x00002050 File Offset: 0x00000250
	public float MaxClipTime
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000D7A RID: 3450
	// (get) Token: 0x060055C4 RID: 21956 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060055C5 RID: 21957 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsLooping
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected set
		{
			throw null;
		}
	}

	// Token: 0x17000D7B RID: 3451
	// (get) Token: 0x060055C6 RID: 21958 RVA: 0x00002050 File Offset: 0x00000250
	public virtual GClass1237.EComputedNodeType NodeType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060055C7 RID: 21959 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StoreAllVariants(RootMotionBlendTable rootMotionTable)
	{
		throw null;
	}

	// Token: 0x060055C8 RID: 21960 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChildrensInitialized()
	{
		throw null;
	}

	// Token: 0x060055C9 RID: 21961 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Serialize(BinaryWriter writer)
	{
		throw null;
	}

	// Token: 0x060055CA RID: 21962 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Deserialize(BinaryReader reader)
	{
		throw null;
	}

	// Token: 0x060055CB RID: 21963 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Vector3 ComputeRootPosition(float deltaTime, float stateNormalizedTime, GInterface82 parametersCache)
	{
		throw null;
	}

	// Token: 0x060055CC RID: 21964 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Quaternion ComputeDeltaRotation(float deltaTime, GInterface82 parametersCache)
	{
		throw null;
	}

	// Token: 0x060055CD RID: 21965 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual float ComputeClipTime(GInterface82 parametersCache)
	{
		throw null;
	}

	// Token: 0x060055CE RID: 21966 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ComputeActiveClips(List<GStruct106> nodes, GInterface82 parametersCache)
	{
		throw null;
	}

	// Token: 0x040061FB RID: 25083
	public List<GClass1237> Childs;

	// Token: 0x040061FC RID: 25084
	[CompilerGenerated]
	private readonly int int_0;

	// Token: 0x040061FD RID: 25085
	[CompilerGenerated]
	private readonly int int_1;

	// Token: 0x040061FE RID: 25086
	[CompilerGenerated]
	private readonly float float_0;

	// Token: 0x040061FF RID: 25087
	[CompilerGenerated]
	private bool bool_0;

	// Token: 0x04006200 RID: 25088
	internal GInterface81 ginterface81_0;

	// Token: 0x04006201 RID: 25089
	internal GInterface83 ginterface83_0;

	// Token: 0x04006202 RID: 25090
	protected string string_0;

	// Token: 0x0200100B RID: 4107
	public enum EComputedNodeType : byte
	{
		// Token: 0x04006204 RID: 25092
		None,
		// Token: 0x04006205 RID: 25093
		Clip,
		// Token: 0x04006206 RID: 25094
		Tree
	}
}
