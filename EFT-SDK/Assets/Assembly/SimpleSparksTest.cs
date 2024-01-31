using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000AF8 RID: 2808
public class SimpleSparksTest : MonoBehaviour
{
	// Token: 0x06003D17 RID: 15639 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Awake()
	{
		throw null;
	}

	// Token: 0x06003D18 RID: 15640 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	// Token: 0x04004343 RID: 17219
	public SimpleSparksRenderer Renderer;

	// Token: 0x04004344 RID: 17220
	public float Speed;

	// Token: 0x04004345 RID: 17221
	public float Gravity;

	// Token: 0x04004346 RID: 17222
	[Range(0f, 0.9999999f)]
	public float Drag;

	// Token: 0x04004347 RID: 17223
	public float Radius;

	// Token: 0x04004348 RID: 17224
	public float LifeTime;

	// Token: 0x04004349 RID: 17225
	[Range(0f, 255f)]
	public byte Emission;

	// Token: 0x0400434A RID: 17226
	[Range(0f, 255f)]
	public byte Size;

	// Token: 0x0400434B RID: 17227
	[Range(0f, 255f)]
	public byte TurbulenceAmp;

	// Token: 0x0400434C RID: 17228
	[Range(0f, 255f)]
	public byte TurbulenceFreq;

	// Token: 0x0400434D RID: 17229
	public int Count;

	// Token: 0x0400434E RID: 17230
	public int CountRnd;

	// Token: 0x0400434F RID: 17231
	public bool Check;

	// Token: 0x04004350 RID: 17232
	public bool Once;
}
