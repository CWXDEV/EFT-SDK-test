using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.AI;

// Token: 0x02000412 RID: 1042
public class GClass423 : GClass362
{
	// Token: 0x0600195C RID: 6492 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static EPathCalcResult CalculatePathFull(int connectionGroup, Vector3 from, IAICorePointLink coverTo, AICoversData covers, out Vector3[] path)
	{
		throw null;
	}

	// Token: 0x0600195D RID: 6493 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static EPathCalcResult CalculatePathFull(int connectionGroup, Vector3 from, Vector3 to, AICoversData covers, out Vector3[] path, bool onlyShortTrie = false)
	{
		throw null;
	}

	// Token: 0x0600195E RID: 6494 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void FindPathOfCoresTest(Vector3 f, Vector3 t)
	{
		throw null;
	}

	// Token: 0x0600195F RID: 6495 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void smethod_0(AICorePoint coreFrom, AICorePoint coreTo)
	{
		throw null;
	}

	// Token: 0x06001960 RID: 6496 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GroupPoint GetClosestPoint(AICoversData covers, Vector3 from, int connectionGroup)
	{
		throw null;
	}

	// Token: 0x06001961 RID: 6497 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GroupPoint GetClosestPointWithWay(AICoversData covers, Vector3 from, int connectionGroup, out Vector3[] corners)
	{
		throw null;
	}

	// Token: 0x06001962 RID: 6498 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool smethod_1(AICorePoint from, AICorePoint to, out Vector3[] way)
	{
		throw null;
	}

	// Token: 0x06001963 RID: 6499 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool smethod_2(AICorePoint from, AICorePoint to, out AICorePoint[] way)
	{
		throw null;
	}

	// Token: 0x06001964 RID: 6500 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Vector3[] smethod_3(List<Vector3[]> ways)
	{
		throw null;
	}

	// Token: 0x06001965 RID: 6501 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool FindPath(Vector3 f, Vector3 t, out Vector3[] corners)
	{
		throw null;
	}

	// Token: 0x170004A6 RID: 1190
	// (get) Token: 0x06001966 RID: 6502 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001967 RID: 6503 RVA: 0x00002050 File Offset: 0x00000250
	public bool SlowAtTheEnd
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x06001968 RID: 6504 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_0(Vector3 pos, bool slowAtTheEnd, bool getUpWithCheck)
	{
		throw null;
	}

	// Token: 0x06001969 RID: 6505 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public NavMeshPathStatus GoToPosition(IAICorePointLink target, bool slowAtTheEnd, float reachDist, bool getUpWithCheck)
	{
		throw null;
	}

	// Token: 0x0600196A RID: 6506 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public NavMeshPathStatus GoToPosition(Vector3 target, bool slowAtTheEnd, float reachDist, bool getUpWithCheck, bool mustHaveWay, bool onlyShortTrie = false)
	{
		throw null;
	}

	// Token: 0x0600196B RID: 6507 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_1()
	{
		throw null;
	}

	// Token: 0x0600196C RID: 6508 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private NavMeshPathStatus method_2(Vector3 pos, bool mustHaveWay)
	{
		throw null;
	}

	// Token: 0x0600196D RID: 6509 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void smethod_4(string sub, ref GClass423.Struct12 struct12_0)
	{
		throw null;
	}

	// Token: 0x0600196E RID: 6510 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool smethod_5(AICorePoint p, List<AICorePoint> wayResult, int deep, ref GClass423.Struct13 struct13_0)
	{
		throw null;
	}

	// Token: 0x040015B3 RID: 5555
	private const int int_0 = 10;

	// Token: 0x040015B4 RID: 5556
	private BotMover botMover_0;

	// Token: 0x040015B5 RID: 5557
	private readonly GClass422 gclass422_0;

	// Token: 0x040015B6 RID: 5558
	private readonly AICoversData aicoversData_0;

	// Token: 0x040015B7 RID: 5559
	private readonly GClass465 gclass465_0;

	// Token: 0x040015B8 RID: 5560
	private int int_1;

	// Token: 0x040015B9 RID: 5561
	private readonly BotMover botMover_1;

	// Token: 0x040015BA RID: 5562
	private int int_2;

	// Token: 0x040015BB RID: 5563
	[CompilerGenerated]
	private bool bool_0;

	// Token: 0x02000413 RID: 1043
	[CompilerGenerated]
	[StructLayout(LayoutKind.Auto)]
	public struct Struct12
	{
		// Token: 0x040015BC RID: 5564
		public Vector3 from;

		// Token: 0x040015BD RID: 5565
		public GroupPoint coverFrom;

		// Token: 0x040015BE RID: 5566
		public IAICorePointLink coverTo;
	}

	// Token: 0x02000414 RID: 1044
	[CompilerGenerated]
	[StructLayout(LayoutKind.Auto)]
	public struct Struct13
	{
		// Token: 0x040015BF RID: 5567
		public HashSet<AICorePoint> hash;

		// Token: 0x040015C0 RID: 5568
		public AICorePoint to;
	}
}
