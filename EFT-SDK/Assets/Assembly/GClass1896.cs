using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

// Token: 0x02001A64 RID: 6756
public class GClass1896 : GInterface157
{
	// Token: 0x06008EAF RID: 36527
	[DllImport("user32.dll")]
	private static extern bool SetCursorPos(int X, int Y);

	// Token: 0x06008EB0 RID: 36528
	[DllImport("user32.dll")]
	private static extern bool GetCursorPos(out GClass1896.GStruct237 pos);

	// Token: 0x06008EB1 RID: 36529 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GClass1896 GetUpdater(int axisIndex)
	{
		throw null;
	}

	// Token: 0x06008EB2 RID: 36530 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Update()
	{
		throw null;
	}

	// Token: 0x06008EB3 RID: 36531 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public float GetValue()
	{
		throw null;
	}

	// Token: 0x06008EB4 RID: 36532 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(float deltaValue)
	{
		throw null;
	}

	// Token: 0x06008EB5 RID: 36533 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void smethod_0()
	{
		throw null;
	}

	// Token: 0x040095F0 RID: 38384
	private static readonly Dictionary<int, GClass1896> dictionary_0;

	// Token: 0x040095F1 RID: 38385
	private static CursorLockMode cursorLockMode_0;

	// Token: 0x040095F2 RID: 38386
	private static CursorLockMode cursorLockMode_1;

	// Token: 0x040095F3 RID: 38387
	private readonly int int_0;

	// Token: 0x040095F4 RID: 38388
	private float float_0;

	// Token: 0x040095F5 RID: 38389
	private float float_1;

	// Token: 0x02001A65 RID: 6757
	[StructLayout(LayoutKind.Auto)]
	public struct GStruct237
	{
		// Token: 0x040095F6 RID: 38390
		public int X;

		// Token: 0x040095F7 RID: 38391
		public int Y;
	}
}
