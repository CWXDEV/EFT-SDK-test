using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000AC0 RID: 2752
public class FlareForEffects : OnRenderObjectConnector
{
	// Token: 0x06003C32 RID: 15410 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Awake()
	{
		throw null;
	}

	// Token: 0x06003C33 RID: 15411 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x06003C34 RID: 15412 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LateUpdate()
	{
		throw null;
	}

	// Token: 0x06003C35 RID: 15413 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void ManualOnRenderObject(Camera currentCamera)
	{
		throw null;
	}

	// Token: 0x06003C36 RID: 15414 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Add(Vector3 pos, int flareID, float time)
	{
		throw null;
	}

	// Token: 0x06003C37 RID: 15415 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Mesh method_1(MultiFlareLight flareLight, MultiFlare.EFlareType type)
	{
		throw null;
	}

	// Token: 0x040041BC RID: 16828
	public MultiFlare MultiFlareObject;

	// Token: 0x040041BD RID: 16829
	private FlareForEffects.Class552[] class552_0;

	// Token: 0x040041BE RID: 16830
	private static readonly LinkedList<FlareForEffects.Class553> linkedList_0;

	// Token: 0x040041BF RID: 16831
	private Material material_0;

	// Token: 0x040041C0 RID: 16832
	private Material material_1;

	// Token: 0x040041C1 RID: 16833
	private float float_0;

	// Token: 0x040041C2 RID: 16834
	private float float_1;

	// Token: 0x040041C3 RID: 16835
	private static readonly int int_0;

	// Token: 0x02000AC1 RID: 2753
	private class Class552
	{
		// Token: 0x040041C4 RID: 16836
		public Mesh ScreenMesh;

		// Token: 0x040041C5 RID: 16837
		public Mesh ShitMesh;
	}

	// Token: 0x02000AC2 RID: 2754
	private class Class553
	{
		// Token: 0x06003C38 RID: 15416 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Process(float delta)
		{
			throw null;
		}

		// Token: 0x040041C6 RID: 16838
		public int FlareID;

		// Token: 0x040041C7 RID: 16839
		public Vector3 Position;

		// Token: 0x040041C8 RID: 16840
		private float float_0;

		// Token: 0x040041C9 RID: 16841
		public float Energy;
	}
}
