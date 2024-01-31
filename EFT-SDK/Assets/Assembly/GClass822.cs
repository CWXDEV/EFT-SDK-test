using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

// Token: 0x0200098C RID: 2444
public class GClass822 : GInterface36
{
	// Token: 0x060036E2 RID: 14050 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Replace(GameObject model)
	{
		throw null;
	}

	// Token: 0x060036E3 RID: 14051 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Restore()
	{
		throw null;
	}

	// Token: 0x04003820 RID: 14368
	private readonly List<GClass822.Struct109> list_0;

	// Token: 0x0200098D RID: 2445
	[StructLayout(LayoutKind.Auto)]
	public struct Struct109
	{
		// Token: 0x04003821 RID: 14369
		public Renderer Renderer;

		// Token: 0x04003822 RID: 14370
		public int MaterialIndex;

		// Token: 0x04003823 RID: 14371
		public Shader OriginalShader;
	}

	// Token: 0x0200098E RID: 2446
	[CompilerGenerated]
	[Serializable]
	private sealed class Class511
	{
		// Token: 0x060036E4 RID: 14052 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(Renderer renderer)
		{
			throw null;
		}

		// Token: 0x04003824 RID: 14372
		public static readonly GClass822.Class511 class511_0;

		// Token: 0x04003825 RID: 14373
		public static Func<Renderer, bool> func_0;
	}
}
