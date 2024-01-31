using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using UnityEngine;

// Token: 0x02000984 RID: 2436
public class GClass820
{
	// Token: 0x060036CE RID: 14030 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task Prepare()
	{
		throw null;
	}

	// Token: 0x060036CF RID: 14031 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Restore()
	{
		throw null;
	}

	// Token: 0x060036D0 RID: 14032 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<bool> RequestMipZeroFast(GameObject obj)
	{
		throw null;
	}

	// Token: 0x060036D1 RID: 14033 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<bool> RequestMipZero(GameObject obj)
	{
		throw null;
	}

	// Token: 0x060036D2 RID: 14034 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(GameObject obj)
	{
		throw null;
	}

	// Token: 0x060036D3 RID: 14035 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task ResetRequestedMip(GameObject obj)
	{
		throw null;
	}

	// Token: 0x040037FA RID: 14330
	private static float float_0;

	// Token: 0x040037FB RID: 14331
	private static int int_0;

	// Token: 0x040037FC RID: 14332
	private static readonly List<GClass820.Struct104> list_0;

	// Token: 0x040037FD RID: 14333
	private static readonly List<Material> list_1;

	// Token: 0x040037FE RID: 14334
	private static readonly List<string> list_2;

	// Token: 0x040037FF RID: 14335
	private static readonly List<string> list_3;

	// Token: 0x02000985 RID: 2437
	[StructLayout(LayoutKind.Auto)]
	public struct Struct104
	{
		// Token: 0x04003800 RID: 14336
		public Texture2D tex2d;

		// Token: 0x04003801 RID: 14337
		public int requestsCount;

		// Token: 0x04003802 RID: 14338
		public bool loggedError;
	}
}
