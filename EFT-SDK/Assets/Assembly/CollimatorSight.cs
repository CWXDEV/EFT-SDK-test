using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000ADE RID: 2782
public class CollimatorSight : MonoBehaviour
{
	// Token: 0x140000CA RID: 202
	// (add) Token: 0x06003CA4 RID: 15524 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06003CA5 RID: 15525 RVA: 0x00002050 File Offset: 0x00000250
	public static event Action<CollimatorSight> OnCollimatorEnabled
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			throw null;
		}
	}

	// Token: 0x140000CB RID: 203
	// (add) Token: 0x06003CA6 RID: 15526 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06003CA7 RID: 15527 RVA: 0x00002050 File Offset: 0x00000250
	public static event Action<CollimatorSight> OnCollimatorDisabled
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			throw null;
		}
	}

	// Token: 0x140000CC RID: 204
	// (add) Token: 0x06003CA8 RID: 15528 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06003CA9 RID: 15529 RVA: 0x00002050 File Offset: 0x00000250
	public static event Action<CollimatorSight> OnCollimatorUpdated
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			throw null;
		}
	}

	// Token: 0x06003CAA RID: 15530 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06003CAB RID: 15531 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnEnable()
	{
		throw null;
	}

	// Token: 0x06003CAC RID: 15532 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		throw null;
	}

	// Token: 0x06003CAD RID: 15533 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LookAt(Vector3 point, Vector3 worldUp)
	{
		throw null;
	}

	// Token: 0x04004285 RID: 17029
	[CompilerGenerated]
	private static Action<CollimatorSight> action_0;

	// Token: 0x04004286 RID: 17030
	[CompilerGenerated]
	private static Action<CollimatorSight> action_1;

	// Token: 0x04004287 RID: 17031
	[CompilerGenerated]
	private static Action<CollimatorSight> action_2;

	// Token: 0x04004288 RID: 17032
	private static readonly Quaternion quaternion_0;

	// Token: 0x04004289 RID: 17033
	public MeshRenderer CollimatorMeshRenderer;

	// Token: 0x0400428A RID: 17034
	public Material CollimatorMaterial;
}
