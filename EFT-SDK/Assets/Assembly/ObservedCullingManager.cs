using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.Jobs;
using UnityEngine;

// Token: 0x02000BC9 RID: 3017
public class ObservedCullingManager : MonoBehaviour
{
	// Token: 0x17000AAA RID: 2730
	// (get) Token: 0x060041B6 RID: 16822 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060041B7 RID: 16823 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsUsingGrid
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x060041B8 RID: 16824 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x060041B9 RID: 16825 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	// Token: 0x060041BA RID: 16826 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int Register(GClass883 o)
	{
		throw null;
	}

	// Token: 0x060041BB RID: 16827 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Unregister(GClass883 o)
	{
		throw null;
	}

	// Token: 0x060041BC RID: 16828 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x060041BD RID: 16829 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1()
	{
		throw null;
	}

	// Token: 0x060041BE RID: 16830 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2()
	{
		throw null;
	}

	// Token: 0x060041BF RID: 16831 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3()
	{
		throw null;
	}

	// Token: 0x060041C0 RID: 16832 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4()
	{
		throw null;
	}

	// Token: 0x060041C1 RID: 16833 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_5(Camera cam)
	{
		throw null;
	}

	// Token: 0x060041C2 RID: 16834 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateSphere(GInterface42 o)
	{
		throw null;
	}

	// Token: 0x060041C3 RID: 16835 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateSphere(GInterface42 o, int index)
	{
		throw null;
	}

	// Token: 0x060041C4 RID: 16836 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_6(Camera cam)
	{
		throw null;
	}

	// Token: 0x060041C5 RID: 16837 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		throw null;
	}

	// Token: 0x04004ABB RID: 19131
	private Camera camera_0;

	// Token: 0x04004ABC RID: 19132
	private GClass882<ObservedCullingManager.Struct124> gclass882_0;

	// Token: 0x04004ABD RID: 19133
	private JobHandle jobHandle_0;

	// Token: 0x04004ABE RID: 19134
	private List<GClass883> list_0;

	// Token: 0x04004ABF RID: 19135
	[CompilerGenerated]
	private bool bool_0;

	// Token: 0x02000BCA RID: 3018
	[StructLayout(LayoutKind.Auto, Size = 1)]
	public struct Struct123 : IJob
	{
		// Token: 0x060041C6 RID: 16838 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Execute()
		{
			throw null;
		}

		// Token: 0x04004AC0 RID: 19136
		public static readonly CullingManager.GClass880 JobParameters;

		// Token: 0x04004AC1 RID: 19137
		public static ObservedCullingManager Instance;
	}

	// Token: 0x02000BCB RID: 3019
	[StructLayout(LayoutKind.Auto)]
	public struct Struct124
	{
		// Token: 0x04004AC2 RID: 19138
		public BoundingSphere Sphere;

		// Token: 0x04004AC3 RID: 19139
		public CullingManager.GStruct60 Data;
	}
}
