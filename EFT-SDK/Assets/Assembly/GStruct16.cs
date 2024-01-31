using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using EFT;

// Token: 0x02000202 RID: 514
[StructLayout(LayoutKind.Auto)]
public struct GStruct16
{
	// Token: 0x0600098E RID: 2446 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public string MessageInfo()
	{
		throw null;
	}

	// Token: 0x0600098F RID: 2447 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Serialize(GStruct16 data, GInterface79 stream)
	{
		throw null;
	}

	// Token: 0x06000990 RID: 2448 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GStruct16 Deserialize(GInterface76 stream)
	{
		throw null;
	}

	// Token: 0x04000A80 RID: 2688
	public static List<string> GroupsNames;

	// Token: 0x04000A81 RID: 2689
	public EPlayerSide Side;

	// Token: 0x04000A82 RID: 2690
	public string name;

	// Token: 0x04000A83 RID: 2691
	public int Members;

	// Token: 0x04000A84 RID: 2692
	public int Enemies;

	// Token: 0x04000A85 RID: 2693
	public int ActiveEnemies;

	// Token: 0x04000A86 RID: 2694
	public int Requests;

	// Token: 0x04000A87 RID: 2695
	public int DeadBodies;

	// Token: 0x04000A88 RID: 2696
	public int PlacesForCheckCount;

	// Token: 0x04000A89 RID: 2697
	public int DangerArea;

	// Token: 0x04000A8A RID: 2698
	public int enemiesCount;

	// Token: 0x04000A8B RID: 2699
	public float[] powers;

	// Token: 0x04000A8C RID: 2700
	public string[] ids;

	// Token: 0x04000A8D RID: 2701
	public string[] members;

	// Token: 0x04000A8E RID: 2702
	public string[] enemies;

	// Token: 0x04000A8F RID: 2703
	public string[] neutrals;

	// Token: 0x04000A90 RID: 2704
	public string[] allies;

	// Token: 0x02000203 RID: 515
	[CompilerGenerated]
	[Serializable]
	private sealed class Class115
	{
		// Token: 0x06000991 RID: 2449 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(KeyValuePair<IPlayer, BotSettingsClass> x)
		{
			throw null;
		}

		// Token: 0x04000A91 RID: 2705
		public static readonly GStruct16.Class115 class115_0;

		// Token: 0x04000A92 RID: 2706
		public static Func<KeyValuePair<IPlayer, BotSettingsClass>, bool> func_0;
	}
}
