using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using EFT.InventoryLogic;
using UnityEngine;

// Token: 0x0200097E RID: 2430
public sealed class GClass815 : GClass813<Item, GClass818>
{
	// Token: 0x1700095D RID: 2397
	// (get) Token: 0x060036BF RID: 14015 RVA: 0x00002050 File Offset: 0x00000250
	protected override string Folder
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060036C0 RID: 14016 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GClass818 GetItemIcon(Item item, in GStruct23 size, bool forcedGeneration = false)
	{
		throw null;
	}

	// Token: 0x060036C1 RID: 14017 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void PoseModelByPivot(GameObject model, Camera camera, float cameraAspect, PreviewPivot.IconSettings settings)
	{
		throw null;
	}

	// Token: 0x060036C2 RID: 14018 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void PoseModelByBounds(GameObject model, Camera camera, in Bounds bounds)
	{
		throw null;
	}

	// Token: 0x060036C3 RID: 14019 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void CenterByBounds(GameObject model, Camera camera, float cameraAspect, PreviewPivot.IconSettings iconSettings)
	{
		throw null;
	}

	// Token: 0x060036C4 RID: 14020 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task<bool> method_11(GameObject obj)
	{
		throw null;
	}

	// Token: 0x060036C5 RID: 14021 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_12(GameObject obj)
	{
		throw null;
	}

	// Token: 0x060036C6 RID: 14022 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override Task<GClass813<Item, GClass818>.RenderModelResult> RenderModel(Item item, GClass813<Item, GClass818>.SpriteFactory spriteFactory)
	{
		throw null;
	}

	// Token: 0x040037D4 RID: 14292
	private readonly IEasyAssets ginterface394_0;

	// Token: 0x040037D5 RID: 14293
	private readonly PoolManager gclass1795_0;

	// Token: 0x040037D6 RID: 14294
	private static int int_3;

	// Token: 0x040037D7 RID: 14295
	private static float float_0;

	// Token: 0x0200097F RID: 2431
	[StructLayout(LayoutKind.Auto)]
	public struct Struct100
	{
		// Token: 0x040037D8 RID: 14296
		public Texture2D tex2d;

		// Token: 0x040037D9 RID: 14297
		public int requestsCount;

		// Token: 0x040037DA RID: 14298
		public bool loggedError;
	}

	// Token: 0x02000982 RID: 2434
	[CompilerGenerated]
	[Serializable]
	private sealed class Class510
	{
		// Token: 0x060036CB RID: 14027 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string method_0(Item x)
		{
			throw null;
		}

		// Token: 0x040037E8 RID: 14312
		public static readonly GClass815.Class510 class510_0;

		// Token: 0x040037E9 RID: 14313
		public static Func<Item, string> func_0;
	}
}
