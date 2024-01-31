using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using EFT;
using EFT.Game.Spawning;
using Newtonsoft.Json;
using UnityEngine;

// Token: 0x020012DD RID: 4829
public sealed class GClass624 : LoggerClass
{
	// Token: 0x06006438 RID: 25656 RVA: 0x00002050 File Offset: 0x00000250
	[Conditional("UNITY_EDITOR")]
	[Conditional("SERVER")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void method_3(Player player)
	{
		throw null;
	}

	// Token: 0x06006439 RID: 25657 RVA: 0x00002050 File Offset: 0x00000250
	[Conditional("SERVER")]
	[Conditional("UNITY_EDITOR")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void method_4(Player player, Vector3 discardedPosition)
	{
		throw null;
	}

	// Token: 0x0600643A RID: 25658 RVA: 0x00002050 File Offset: 0x00000250
	[Conditional("UNITY_EDITOR")]
	[Conditional("SERVER")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void method_5(Player player, bool isBoss)
	{
		throw null;
	}

	// Token: 0x0600643B RID: 25659 RVA: 0x00002050 File Offset: 0x00000250
	[Conditional("UNITY_EDITOR")]
	[Conditional("SERVER")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void method_6(Player player, bool isBoss, Vector3 discardedPosition)
	{
		throw null;
	}

	// Token: 0x0600643C RID: 25660 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_7(IDictionary<object, object> properties, Player player, ESpawnCategory category, Vector3? discardedPosition = null)
	{
		throw null;
	}

	// Token: 0x0400709A RID: 28826
	private const string string_0 = "spawns";

	// Token: 0x0400709B RID: 28827
	private readonly IDictionary<string, Player> idictionary_0;

	// Token: 0x0400709C RID: 28828
	private readonly IDictionary<string, Player> idictionary_1;

	// Token: 0x020012DE RID: 4830
	// (Invoke) Token: 0x0600643D RID: 25661
	internal delegate GClass624 Delegate7(IDictionary<string, Player> players, IDictionary<string, Player> bots);

	// Token: 0x020012DF RID: 4831
	private enum ActionId
	{
		// Token: 0x0400709E RID: 28830
		PlayerSpawned,
		// Token: 0x0400709F RID: 28831
		PlayerSpawnedWithTeleport,
		// Token: 0x040070A0 RID: 28832
		BotSpawned,
		// Token: 0x040070A1 RID: 28833
		BotSpawnedWithTeleport
	}

	// Token: 0x020012E0 RID: 4832
	public sealed class GClass1466
	{
		// Token: 0x040070A2 RID: 28834
		public string ProfileId;

		// Token: 0x040070A3 RID: 28835
		public ESpawnCategory Category;

		// Token: 0x040070A4 RID: 28836
		public EPlayerSide Side;

		// Token: 0x040070A5 RID: 28837
		public Vector3 Position;

		// Token: 0x040070A6 RID: 28838
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string GroupId;

		// Token: 0x040070A7 RID: 28839
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public Vector3? DiscardedPosition;

		// Token: 0x040070A8 RID: 28840
		public GClass624.GClass1467[] Players;

		// Token: 0x040070A9 RID: 28841
		public GClass624.GClass1467[] Bots;
	}

	// Token: 0x020012E1 RID: 4833
	public class GClass1467
	{
		// Token: 0x040070AA RID: 28842
		public string ProfileId;

		// Token: 0x040070AB RID: 28843
		public ESpawnCategory Category;

		// Token: 0x040070AC RID: 28844
		public EPlayerSide Side;

		// Token: 0x040070AD RID: 28845
		public Vector3 Position;

		// Token: 0x040070AE RID: 28846
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string GroupId;
	}

	// Token: 0x020012E2 RID: 4834
	[CompilerGenerated]
	[Serializable]
	private sealed class Class928
	{
		// Token: 0x06006440 RID: 25664 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal GClass624.GClass1467 method_0(KeyValuePair<string, Player> pair)
		{
			throw null;
		}

		// Token: 0x06006441 RID: 25665 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_1(KeyValuePair<string, Player> pair)
		{
			throw null;
		}

		// Token: 0x06006442 RID: 25666 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal GClass624.GClass1467 method_2(KeyValuePair<string, Player> pair)
		{
			throw null;
		}

		// Token: 0x040070AF RID: 28847
		public static readonly GClass624.Class928 class928_0;

		// Token: 0x040070B0 RID: 28848
		public static Func<KeyValuePair<string, Player>, GClass624.GClass1467> func_0;

		// Token: 0x040070B1 RID: 28849
		public static Func<KeyValuePair<string, Player>, bool> func_1;

		// Token: 0x040070B2 RID: 28850
		public static Func<KeyValuePair<string, Player>, GClass624.GClass1467> func_2;
	}
}
