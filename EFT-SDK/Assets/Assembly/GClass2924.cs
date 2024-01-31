using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.Game.Spawning;
using JetBrains.Annotations;

// Token: 0x020026AC RID: 9900
public sealed class GClass2924 : IEnumerable, IEnumerable<ISpawnPoint>, IReadOnlyCollection<ISpawnPoint>, ISpawnPoints
{
	// Token: 0x0600C436 RID: 50230 RVA: 0x00002050 File Offset: 0x00000250
	[NotNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GClass2924 CreateFromScene([CanBeNull] DateTime? locationExportDateTime = null, [CanBeNull] SpawnPointParams[] parameters = null)
	{
		throw null;
	}

	// Token: 0x0600C437 RID: 50231 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool smethod_0([NotNull] LoggerClass logger, [CanBeNull] DateTime? locationDateTime)
	{
		throw null;
	}

	// Token: 0x0600C438 RID: 50232 RVA: 0x00002050 File Offset: 0x00000250
	[NotNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static SpawnPointMarker[] smethod_1([NotNull] LoggerClass logger, [NotNull] SpawnPointMarker[] markers, [NotNull] SpawnPointParams[] parameters)
	{
		throw null;
	}

	// Token: 0x0600C439 RID: 50233 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void smethod_2()
	{
		throw null;
	}

	// Token: 0x17002303 RID: 8963
	// (get) Token: 0x0600C43A RID: 50234 RVA: 0x00002050 File Offset: 0x00000250
	public int Count
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600C43B RID: 50235 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerator<ISpawnPoint> GetEnumerator()
	{
		throw null;
	}

	// Token: 0x0600C43C RID: 50236 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	IEnumerator IEnumerable.GetEnumerator()
	{
		throw null;
	}

	// Token: 0x0600C43D RID: 50237 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	ISpawnPoint ISpawnPoints.CreateSpawnPoint(SpawnPointParams @params)
	{
		throw null;
	}

	// Token: 0x0600C43E RID: 50238 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	void ISpawnPoints.DestroySpawnPoint(ISpawnPoint spawnPoint)
	{
		throw null;
	}

	// Token: 0x0600C43F RID: 50239 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Validate()
	{
		throw null;
	}

	// Token: 0x0400C5F3 RID: 50675
	private readonly Dictionary<ISpawnPoint, SpawnPointMarker> dictionary_0;

	// Token: 0x0400C5F4 RID: 50676
	private readonly GClass2924.Class352 class352_0;

	// Token: 0x020026AD RID: 9901
	private sealed class Class352 : LoggerClass
	{
		// Token: 0x0400C5F5 RID: 50677
		private const string string_0 = "maperrors";
	}

	// Token: 0x020026AE RID: 9902
	[CompilerGenerated]
	[Serializable]
	private sealed class Class2215
	{
		// Token: 0x0600C440 RID: 50240 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal ISpawnPoint method_0(SpawnPointMarker marker)
		{
			throw null;
		}

		// Token: 0x0600C441 RID: 50241 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal SpawnPointMarker method_1(SpawnPointMarker marker)
		{
			throw null;
		}

		// Token: 0x0600C442 RID: 50242 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string method_2(SpawnPointParams prm)
		{
			throw null;
		}

		// Token: 0x0600C443 RID: 50243 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string method_3(SpawnPointMarker marker)
		{
			throw null;
		}

		// Token: 0x0600C444 RID: 50244 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_4(SpawnPointMarker marker)
		{
			throw null;
		}

		// Token: 0x0400C5F6 RID: 50678
		public static readonly GClass2924.Class2215 class2215_0;

		// Token: 0x0400C5F7 RID: 50679
		public static Func<SpawnPointMarker, ISpawnPoint> func_0;

		// Token: 0x0400C5F8 RID: 50680
		public static Func<SpawnPointMarker, SpawnPointMarker> func_1;

		// Token: 0x0400C5F9 RID: 50681
		public static Func<SpawnPointParams, string> func_2;

		// Token: 0x0400C5FA RID: 50682
		public static Func<SpawnPointMarker, string> func_3;

		// Token: 0x0400C5FB RID: 50683
		public static Predicate<SpawnPointMarker> predicate_0;
	}

	// Token: 0x020026AF RID: 9903
	[CompilerGenerated]
	private sealed class Class2216
	{
		// Token: 0x0600C445 RID: 50245 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(SpawnPointMarker marker)
		{
			throw null;
		}

		// Token: 0x0600C446 RID: 50246 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_1(SpawnPointParams prm)
		{
			throw null;
		}

		// Token: 0x0400C5FC RID: 50684
		public string[] ids;
	}

	// Token: 0x020026B0 RID: 9904
	[CompilerGenerated]
	private sealed class Class2217
	{
		// Token: 0x0600C447 RID: 50247 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(SpawnPointParams p)
		{
			throw null;
		}

		// Token: 0x0400C5FD RID: 50685
		public string markerId;
	}
}
