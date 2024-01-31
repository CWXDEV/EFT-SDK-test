using System;
using System.Runtime.CompilerServices;

namespace EFT
{
	// Token: 0x020015EC RID: 5612
	[Serializable]
	public class WildSpawnWave
	{
		// Token: 0x17001337 RID: 4919
		// (get) Token: 0x06007A6C RID: 31340 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007A6D RID: 31341 RVA: 0x00002050 File Offset: 0x00000250
		public BotDifficulty BotDifficulty
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06007A6E RID: 31342 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public WildSpawnWave Copy()
		{
			throw null;
		}

		// Token: 0x06007A6F RID: 31343 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BotDifficulty GetDifficulty()
		{
			throw null;
		}

		// Token: 0x04007F0D RID: 32525
		public int time_min;

		// Token: 0x04007F0E RID: 32526
		public int time_max;

		// Token: 0x04007F0F RID: 32527
		public int slots_min;

		// Token: 0x04007F10 RID: 32528
		public int slots_max;

		// Token: 0x04007F11 RID: 32529
		public string SpawnPoints;

		// Token: 0x04007F12 RID: 32530
		public EPlayerSide BotSide;

		// Token: 0x04007F13 RID: 32531
		public WildSpawnType WildSpawnType;

		// Token: 0x04007F14 RID: 32532
		public BotDifficulty _botDifficulty;

		// Token: 0x04007F15 RID: 32533
		public bool isPlayers;

		// Token: 0x04007F16 RID: 32534
		public string BotPreset;

		// Token: 0x04007F17 RID: 32535
		public float ChanceGroup;
	}
}
