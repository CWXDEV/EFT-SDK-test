using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000C39 RID: 3129
public class GClass901
{
	// Token: 0x06004425 RID: 17445 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init()
	{
		throw null;
	}

	// Token: 0x06004426 RID: 17446 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Destroy()
	{
		throw null;
	}

	// Token: 0x06004427 RID: 17447 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Update()
	{
		throw null;
	}

	// Token: 0x06004428 RID: 17448 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Add(Vector3 position, Color color, float range = 1.5f, float intensity = 5f, float time = 0.1f, bool shadows = false)
	{
		throw null;
	}

	// Token: 0x06004429 RID: 17449 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillFreeLights()
	{
		throw null;
	}

	// Token: 0x0600442A RID: 17450 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private GClass901.Class630 CreateLightStruct()
	{
		throw null;
	}

	// Token: 0x0600442B RID: 17451 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private GameObject CreateOrGetLightParent()
	{
		throw null;
	}

	// Token: 0x04004DC8 RID: 19912
	private GameObject gameObject_0;

	// Token: 0x04004DC9 RID: 19913
	private LinkedList<GClass901.Class630> linkedList_0;

	// Token: 0x04004DCA RID: 19914
	private LinkedList<GClass901.Class630> linkedList_1;

	// Token: 0x04004DCB RID: 19915
	private const int int_0 = 100;

	// Token: 0x04004DCC RID: 19916
	private const float float_0 = 1.5f;

	// Token: 0x04004DCD RID: 19917
	private const float float_1 = 0.1f;

	// Token: 0x04004DCE RID: 19918
	private const float float_2 = 5f;

	// Token: 0x02000C3A RID: 3130
	private class Class630
	{
		// Token: 0x0600442C RID: 17452 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Start(float time, float range, float intensity, Vector3 position, Color color, bool shadows = false)
		{
			throw null;
		}

		// Token: 0x0600442D RID: 17453 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Update(float deltaTime)
		{
			throw null;
		}

		// Token: 0x04004DCF RID: 19919
		public Light LightScript;

		// Token: 0x04004DD0 RID: 19920
		public GameObject LightObject;

		// Token: 0x04004DD1 RID: 19921
		public Transform LightTransform;

		// Token: 0x04004DD2 RID: 19922
		public float DeathTime;

		// Token: 0x04004DD3 RID: 19923
		public float RangeFallof;

		// Token: 0x04004DD4 RID: 19924
		public float IntensityFallof;
	}
}
