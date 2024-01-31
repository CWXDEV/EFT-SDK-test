using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000062 RID: 98
[RequireComponent(typeof(Camera))]
[AddComponentMenu("")]
public class CC_Base : MonoBehaviour
{
	// Token: 0x17000103 RID: 259
	// (get) Token: 0x060002B3 RID: 691 RVA: 0x00002050 File Offset: 0x00000250
	protected Material material
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060002B4 RID: 692 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsLinear()
	{
		throw null;
	}

	// Token: 0x060002B5 RID: 693 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void Awake()
	{
		throw null;
	}

	// Token: 0x060002B6 RID: 694 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void Start()
	{
		throw null;
	}

	// Token: 0x060002B7 RID: 695 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnDisable()
	{
		throw null;
	}

	// Token: 0x0400015F RID: 351
	public Shader shader;

	// Token: 0x04000160 RID: 352
	protected Material _material;

	// Token: 0x04000161 RID: 353
	protected SSAAPropagator _ssaaPropagator;
}
