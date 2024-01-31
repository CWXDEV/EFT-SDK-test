using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000A04 RID: 2564
public class RenderQueue : MonoBehaviour
{
	// Token: 0x060038A0 RID: 14496 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	// Token: 0x060038A1 RID: 14497 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnValidate()
	{
		throw null;
	}

	// Token: 0x060038A2 RID: 14498 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x04003A4A RID: 14922
	public int Queue;

	// Token: 0x04003A4B RID: 14923
	public RenderQueue.Queues SetQueue;

	// Token: 0x02000A05 RID: 2565
	public enum Queues
	{
		// Token: 0x04003A4D RID: 14925
		Cancel = -1,
		// Token: 0x04003A4E RID: 14926
		Background = 1000,
		// Token: 0x04003A4F RID: 14927
		Geometry = 2000,
		// Token: 0x04003A50 RID: 14928
		AlphaTest = 2450,
		// Token: 0x04003A51 RID: 14929
		Transparent = 3000,
		// Token: 0x04003A52 RID: 14930
		Overlay = 4000
	}
}
