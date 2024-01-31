using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine;

namespace EFT
{
	// Token: 0x0200193A RID: 6458
	public class LocalPlayer : Player
	{
		// Token: 0x06008AAD RID: 35501 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Task<LocalPlayer> Create(int playerId, Vector3 position, Quaternion rotation, string layerName, string prefix, EPointOfView pointOfView, Profile profile, bool aiControl, EUpdateQueue updateQueue, Player.EUpdateMode armsUpdateMode, Player.EUpdateMode bodyUpdateMode, CharacterControllerSpawner.Mode characterControllerMode, Func<float> getSensitivity, Func<float> getAimingSensitivity, IStatisticsManager statisticsManager, GInterface99 filter, AbstractQuestControllerClass questController, AbstractAchievementControllerClass achievementsController, bool isYourPlayer)
		{
			throw null;
		}

		// Token: 0x06008AAE RID: 35502 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnSkillLevelChanged(GClass1763 skill)
		{
			throw null;
		}

		// Token: 0x06008AAF RID: 35503 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnWeaponMastered(GClass1764 masterSkill)
		{
			throw null;
		}

		// Token: 0x06008AB0 RID: 35504 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void PauseAllEffectsOnPlayer()
		{
			throw null;
		}

		// Token: 0x06008AB1 RID: 35505 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void UnpauseAllEffectsOnPlayer()
		{
			throw null;
		}

		// Token: 0x0200193B RID: 6459
		[CompilerGenerated]
		[Serializable]
		private sealed class Class1501
		{
			// Token: 0x06008AB2 RID: 35506 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x04009042 RID: 36930
			public static readonly LocalPlayer.Class1501 class1501_0;

			// Token: 0x04009043 RID: 36931
			public static Action action_0;
		}
	}
}
