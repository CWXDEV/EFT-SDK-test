using System;
using System.Runtime.CompilerServices;
using System.Text;
using UnityEngine.LowLevel;

// Token: 0x020005CE RID: 1486
public static class GClass564
{
	// Token: 0x0600227D RID: 8829 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool smethod_0(PlayerLoopSystem root, Type type, out PlayerLoopSystem playerLoopSystem)
	{
		throw null;
	}

	// Token: 0x0600227E RID: 8830 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool FindParentPlayerLoopSystem(PlayerLoopSystem root, Type type, out PlayerLoopSystem playerLoopSystem, out int index)
	{
		throw null;
	}

	// Token: 0x0600227F RID: 8831 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool smethod_1(PlayerLoopSystem searchRoot, PlayerLoopSystem playerLoopSystem)
	{
		throw null;
	}

	// Token: 0x06002280 RID: 8832 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool smethod_2(PlayerLoopSystem playerLoopSystem, PlayerLoopSystem[] subSystemList)
	{
		throw null;
	}

	// Token: 0x06002281 RID: 8833 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void InsertAsSubSystem(Type rootType, PlayerLoopSystem newSystem, GClass564.EOrderType orderType)
	{
		throw null;
	}

	// Token: 0x06002282 RID: 8834 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void InsertAsSiblingSystem(Type siblingType, PlayerLoopSystem newSystem, GClass564.EOrderType orderType)
	{
		throw null;
	}

	// Token: 0x06002283 RID: 8835 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool smethod_3(PlayerLoopSystem searchRoot, Type removeSystemType)
	{
		throw null;
	}

	// Token: 0x06002284 RID: 8836 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void RemoveLoopSystem(Type removeSystemType)
	{
		throw null;
	}

	// Token: 0x06002285 RID: 8837 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool FindPlayerLoopSystem(Type type, out PlayerLoopSystem playerLoopSystem)
	{
		throw null;
	}

	// Token: 0x06002286 RID: 8838 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void PrintAllPlayerLoopSystems()
	{
		throw null;
	}

	// Token: 0x06002287 RID: 8839 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void smethod_4(PlayerLoopSystem playerLoopSystem, StringBuilder output, string indent = "")
	{
		throw null;
	}

	// Token: 0x06002288 RID: 8840 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ResetGameLoop()
	{
		throw null;
	}

	// Token: 0x040021D0 RID: 8656
	private static readonly PlayerLoopSystem playerLoopSystem_0;

	// Token: 0x020005CF RID: 1487
	public enum EOrderType
	{
		// Token: 0x040021D2 RID: 8658
		First,
		// Token: 0x040021D3 RID: 8659
		Last
	}
}
