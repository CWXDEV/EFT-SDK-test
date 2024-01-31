using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT
{
	// Token: 0x020016E1 RID: 5857
	[Serializable]
	public class FastGameInfo
	{
		// Token: 0x170013C9 RID: 5065
		// (get) Token: 0x06007E4A RID: 32330 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007E4B RID: 32331 RVA: 0x00002050 File Offset: 0x00000250
		public string[] MapsCollection
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

		// Token: 0x06007E4C RID: 32332 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x06007E4D RID: 32333 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x04008530 RID: 34096
		private const string SCENES_JSON_CONFIG_PATH = "Assets/Editor/ScenesJsonConfig.asset";

		// Token: 0x04008531 RID: 34097
		private TarkovApplication _tarkovApplication;

		// Token: 0x04008532 RID: 34098
		private string[] _mapsCollection;

		// Token: 0x04008533 RID: 34099
		public bool IsAutoLoginEnabled;

		// Token: 0x04008534 RID: 34100
		public bool UseLoginFromInspector;

		// Token: 0x04008535 RID: 34101
		public string LoginForAutoLogin;

		// Token: 0x04008536 RID: 34102
		public string PasswordForAutoLogin;

		// Token: 0x04008537 RID: 34103
		[Header("Fast start enable settings")]
		public bool IsFastStartEnabled;

		// Token: 0x04008538 RID: 34104
		public string FastGameMap;

		// Token: 0x04008539 RID: 34105
		public bool IsLocalGame;

		// Token: 0x0400853A RID: 34106
		public bool IsNoLootForLocalGame;

		// Token: 0x0400853B RID: 34107
		public bool IsAIEnabledInLocalGame;

		// Token: 0x0400853C RID: 34108
		public bool IsLocationGameSessionLimit;

		// Token: 0x0400853D RID: 34109
		public bool IsCustomGameSessionLimit;

		// Token: 0x0400853E RID: 34110
		public int CustomGameSessionTimeLimit;
	}
}
