using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT
{
	// Token: 0x020012D7 RID: 4823
	public sealed class WavesSpawnScenario : MonoBehaviour
	{
		// Token: 0x17001028 RID: 4136
		// (get) Token: 0x06006428 RID: 25640 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006429 RID: 25641 RVA: 0x00002050 File Offset: 0x00000250
		public BotWaveDataClass[] SpawnWaves
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

		// Token: 0x17001029 RID: 4137
		// (get) Token: 0x0600642A RID: 25642 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600642B RID: 25643 RVA: 0x00002050 File Offset: 0x00000250
		public bool Enabled
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

		// Token: 0x0600642C RID: 25644 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static WavesSpawnScenario smethod_0(GameObject game, WildSpawnWave[] waves, Action<BotWaveDataClass> spawnAction, LocationSettingsClass.Location location = null)
		{
			throw null;
		}

		// Token: 0x0600642D RID: 25645 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void smethod_1(Dictionary<WildSpawnType, int> minCounts, MinMaxBots[] minMaxBots)
		{
			throw null;
		}

		// Token: 0x0600642E RID: 25646 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(WildSpawnWave[] waves)
		{
			throw null;
		}

		// Token: 0x0600642F RID: 25647 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(WildSpawnWave[] waves, WildSpawnType type)
		{
			throw null;
		}

		// Token: 0x06006430 RID: 25648 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Run(EBotsSpawnMode spawnMode = EBotsSpawnMode.Anyway)
		{
			throw null;
		}

		// Token: 0x06006431 RID: 25649 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Stop()
		{
			throw null;
		}

		// Token: 0x06006432 RID: 25650 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private BotWaveDataClass method_1(WildSpawnWave wave)
		{
			throw null;
		}

		// Token: 0x0400708A RID: 28810
		public BotLocationModifier BotLocationModifier;

		// Token: 0x0400708B RID: 28811
		private readonly List<GClass551.GInterface13> list_0;

		// Token: 0x0400708C RID: 28812
		private Action<BotWaveDataClass> action_0;

		// Token: 0x0400708D RID: 28813
		private Dictionary<WildSpawnType, int> dictionary_0;

		// Token: 0x0400708E RID: 28814
		public readonly List<WaveInfo> BotsCountProfiles;

		// Token: 0x0400708F RID: 28815
		[CompilerGenerated]
		private BotWaveDataClass[] gclass1465_0;

		// Token: 0x04007090 RID: 28816
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x020012D8 RID: 4824
		[CompilerGenerated]
		[Serializable]
		private sealed class Class923
		{
			// Token: 0x06006433 RID: 25651 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal int method_0(WildSpawnWave x)
			{
				throw null;
			}

			// Token: 0x06006434 RID: 25652 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal float method_1(BotWaveDataClass wave)
			{
				throw null;
			}

			// Token: 0x04007091 RID: 28817
			public static readonly WavesSpawnScenario.Class923 class923_0;

			// Token: 0x04007092 RID: 28818
			public static Func<WildSpawnWave, int> func_0;

			// Token: 0x04007093 RID: 28819
			public static Func<BotWaveDataClass, float> func_1;
		}

		// Token: 0x020012D9 RID: 4825
		[CompilerGenerated]
		private sealed class Class924
		{
			// Token: 0x06006435 RID: 25653 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(MinMaxBots x)
			{
				throw null;
			}

			// Token: 0x04007094 RID: 28820
			public WildSpawnType wildSpawnType;
		}

		// Token: 0x020012DA RID: 4826
		[CompilerGenerated]
		private sealed class Class925
		{
			// Token: 0x06006436 RID: 25654 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal int method_0(WildSpawnWave x)
			{
				throw null;
			}

			// Token: 0x04007095 RID: 28821
			public WildSpawnType type;
		}

		// Token: 0x020012DB RID: 4827
		[CompilerGenerated]
		private sealed class Class926
		{
			// Token: 0x04007096 RID: 28822
			public BotWaveDataClass spawnWave;

			// Token: 0x04007097 RID: 28823
			public WavesSpawnScenario wavesSpawnScenario_0;
		}

		// Token: 0x020012DC RID: 4828
		[CompilerGenerated]
		private sealed class Class927
		{
			// Token: 0x06006437 RID: 25655 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x04007098 RID: 28824
			public GClass551.GInterface13 timer;

			// Token: 0x04007099 RID: 28825
			public WavesSpawnScenario.Class926 class926_0;
		}
	}
}
