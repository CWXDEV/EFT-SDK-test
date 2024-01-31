using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;
using EFT.Game.Spawning;
using JetBrains.Annotations;
using UnityEngine;

// Token: 0x0200269C RID: 9884
public static class GClass2921
{
	// Token: 0x0600C3F7 RID: 50167 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool smethod_0([NotNull] this ISpawnPoint spawnPoint, ESpawnCategory category)
	{
		throw null;
	}

	// Token: 0x0600C3F8 RID: 50168 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool smethod_1([NotNull] this ISpawnPoint spawnPoint, EPlayerSide side)
	{
		throw null;
	}

	// Token: 0x0600C3F9 RID: 50169 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool smethod_2([NotNull] this ISpawnPoint spawnPoint, string infiltration = null)
	{
		throw null;
	}

	// Token: 0x0600C3FA RID: 50170 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool smethod_3([NotNull] this ISpawnPoint spawnPoint, params string[] spawnPointsFilter)
	{
		throw null;
	}

	// Token: 0x0600C3FB RID: 50171 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsCollided([NotNull] this ISpawnPoint spawnPoint, [CanBeNull] IReadOnlyCollection<IPlayer> persons)
	{
		throw null;
	}

	// Token: 0x0600C3FC RID: 50172 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsNotCollided([NotNull] this ISpawnPoint spawnPoint, [CanBeNull] IReadOnlyCollection<IPlayer> persons)
	{
		throw null;
	}

	// Token: 0x0600C3FD RID: 50173 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IEnumerable<IPlayer> Collided([NotNull] this ISpawnPoint spawnPoint, [CanBeNull] IReadOnlyCollection<IPlayer> persons)
	{
		throw null;
	}

	// Token: 0x0600C3FE RID: 50174 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsOccupied([NotNull] this ISpawnPoint spawnPoint, [CanBeNull] IReadOnlyCollection<IPlayer> persons, float sqrDistance = 1f)
	{
		throw null;
	}

	// Token: 0x0600C3FF RID: 50175 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool NotOccupied([NotNull] this ISpawnPoint spawnPoint, [CanBeNull] IReadOnlyCollection<IPlayer> persons, float sqrDistance = 1f)
	{
		throw null;
	}

	// Token: 0x0600C400 RID: 50176 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static float MinDistanceSqr([NotNull] this ISpawnPoint spawnPoint, [CanBeNull] IReadOnlyCollection<IPlayer> players)
	{
		throw null;
	}

	// Token: 0x0600C401 RID: 50177 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static float MinDistanceSqr(this Vector3 position, [CanBeNull] IReadOnlyCollection<IPlayer> players)
	{
		throw null;
	}

	// Token: 0x0600C402 RID: 50178 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Vector3 CenterPosition([CanBeNull] this IReadOnlyCollection<IPlayer> players)
	{
		throw null;
	}

	// Token: 0x0600C403 RID: 50179 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsValid([NotNull] this ISpawnPoint spawnPoint, [CanBeNull] IReadOnlyCollection<IPlayer> players, float distanceSqr, GClass603 debugCollector)
	{
		throw null;
	}

	// Token: 0x0600C404 RID: 50180 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsValid([NotNull] this ISpawnPoint spawnPoint, EPlayerSide? side)
	{
		throw null;
	}

	// Token: 0x0600C405 RID: 50181 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsValid([NotNull] this ISpawnPoint spawnPoint, EPlayerSide side)
	{
		throw null;
	}

	// Token: 0x0600C406 RID: 50182 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsValid([NotNull] this ISpawnPoint spawnPoint, ESpawnCategoryMask side)
	{
		throw null;
	}

	// Token: 0x0600C407 RID: 50183 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsValid([NotNull] this ISpawnPoint spawnPoint, EPlayerSideMask sideMask)
	{
		throw null;
	}

	// Token: 0x0600C408 RID: 50184 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsValid([NotNull] this ISpawnPoint spawnPoint, float time)
	{
		throw null;
	}

	// Token: 0x0600C409 RID: 50185 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SetUse([NotNull] this ISpawnPoint spawnPoint, float time, bool isPlayer = false)
	{
		throw null;
	}

	// Token: 0x0600C40A RID: 50186 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ISpawnPoint smethod_4([NotNull] this IReadOnlyList<ISpawnPoint> spawnPoints, [NotNull] IReadOnlyCollection<IPlayer> players, int sqrSafeDistanceMeters, [CanBeNull] SpawnSystemClass.Class353 logger = null)
	{
		throw null;
	}

	// Token: 0x0600C40B RID: 50187 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ISpawnPoint smethod_5([NotNull] this IReadOnlyList<ISpawnPoint> spawnPoints, [NotNull] IReadOnlyCollection<IPlayer> players, [NotNull] GClass603 debugCollector, [CanBeNull] SpawnSystemClass.Class353 logger = null)
	{
		throw null;
	}

	// Token: 0x0600C40C RID: 50188 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static ISpawnPoint FindSpawnPointInPosition([NotNull] this IEnumerable<ISpawnPoint> spawnPoints, Vector3 position, float sqrDistance = 0.25f)
	{
		throw null;
	}

	// Token: 0x0600C40D RID: 50189 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ISpawnPoint smethod_6([NotNull] this IReadOnlyCollection<ISpawnPoint> spawnPoints, [NotNull] IReadOnlyCollection<IPlayer> groupPlayers, [NotNull] IReadOnlyCollection<IPlayer> noneGroupPlayers, [CanBeNull] SpawnSystemClass.Class353 logger = null)
	{
		throw null;
	}

	// Token: 0x0200269D RID: 9885
	[CompilerGenerated]
	private sealed class Class2208
	{
		// Token: 0x0600C40E RID: 50190 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(IPlayer person)
		{
			throw null;
		}

		// Token: 0x0400C5D2 RID: 50642
		public ISpawnPoint spawnPoint;
	}

	// Token: 0x0200269E RID: 9886
	[CompilerGenerated]
	private sealed class Class2209
	{
		// Token: 0x0600C40F RID: 50191 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal float method_0(IPlayer player)
		{
			throw null;
		}

		// Token: 0x0400C5D3 RID: 50643
		public Vector3 position;
	}

	// Token: 0x0200269F RID: 9887
	[CompilerGenerated]
	[Serializable]
	private sealed class Class2210
	{
		// Token: 0x0600C410 RID: 50192 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Vector3 method_0(Vector3 position, IPlayer groupPlayer)
		{
			throw null;
		}

		// Token: 0x0400C5D4 RID: 50644
		public static readonly GClass2921.Class2210 class2210_0;

		// Token: 0x0400C5D5 RID: 50645
		public static Func<Vector3, IPlayer, Vector3> func_0;
	}

	// Token: 0x020026A0 RID: 9888
	[CompilerGenerated]
	private sealed class Class2211
	{
		// Token: 0x0600C411 RID: 50193 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(ISpawnPoint spawnPoint)
		{
			throw null;
		}

		// Token: 0x0400C5D6 RID: 50646
		public Vector3 position;

		// Token: 0x0400C5D7 RID: 50647
		public float sqrDistance;
	}

	// Token: 0x020026A1 RID: 9889
	[CompilerGenerated]
	private sealed class Class2212
	{
		// Token: 0x0600C412 RID: 50194 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal float method_0(ISpawnPoint spawnPoint)
		{
			throw null;
		}

		// Token: 0x0600C413 RID: 50195 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_1(ISpawnPoint spawnPoint)
		{
			throw null;
		}

		// Token: 0x0600C414 RID: 50196 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_2(ISpawnPoint spawnPoint)
		{
			throw null;
		}

		// Token: 0x0400C5D8 RID: 50648
		public Vector3 groupCenter;

		// Token: 0x0400C5D9 RID: 50649
		public IReadOnlyCollection<IPlayer> groupPlayers;

		// Token: 0x0400C5DA RID: 50650
		public IReadOnlyCollection<IPlayer> noneGroupPlayers;
	}
}
