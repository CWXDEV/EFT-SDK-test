using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using EFT;
using EFT.InventoryLogic;
using JetBrains.Annotations;

// Token: 0x02000FD7 RID: 4055
[StructLayout(LayoutKind.Auto)]
public struct GStruct105
{
	// Token: 0x17000D51 RID: 3409
	// (get) Token: 0x06005531 RID: 21809 RVA: 0x00002050 File Offset: 0x00000250
	public static GStruct105 Other
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000D52 RID: 3410
	// (get) Token: 0x06005532 RID: 21810 RVA: 0x00002050 File Offset: 0x00000250
	public static GStruct105 Player
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000D53 RID: 3411
	// (get) Token: 0x06005533 RID: 21811 RVA: 0x00002050 File Offset: 0x00000250
	public static GStruct105 SynchronizableObject
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x040060DA RID: 24794
	public ResourceType ResourceType;

	// Token: 0x040060DB RID: 24795
	[CanBeNull]
	public ItemTemplate ItemTemplate;
}
