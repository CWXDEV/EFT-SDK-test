using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x0200293F RID: 10559
	public class SkillsAndLevelsRequirementsPanel : UIElement
	{
		// Token: 0x0600D2B3 RID: 53939 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TMP_TextInfo GetTextInfo(string text)
		{
			throw null;
		}

		// Token: 0x0600D2B4 RID: 53940 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(Profile profile, Profile.TraderInfo trader, GClass3359 quests, int? loyaltyLevel, int? profileLevel, float? standing, [CanBeNull] IEnumerable<GClass2940> skillRequirements, [CanBeNull] IEnumerable<ClothingRequirements.GClass3014> questRequirements, Action<bool> onAvailableChanged)
		{
			throw null;
		}

		// Token: 0x0600D2B5 RID: 53941 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(RequiredSkillOrLevel requirement, string message, bool available, Sprite icon = null, float width = -1f)
		{
			throw null;
		}

		// Token: 0x0600D2B6 RID: 53942 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0400D435 RID: 54325
		[SerializeField]
		private RequiredSkillOrLevel _loyalty;

		// Token: 0x0400D436 RID: 54326
		[SerializeField]
		private RequiredSkillOrLevel _level;

		// Token: 0x0400D437 RID: 54327
		[SerializeField]
		private RequiredSkillOrLevel _standing;

		// Token: 0x0400D438 RID: 54328
		[SerializeField]
		private RequiredSkillOrLevel _skillTemplate;

		// Token: 0x0400D439 RID: 54329
		[SerializeField]
		private Sprite _skillIcon;

		// Token: 0x0400D43A RID: 54330
		[SerializeField]
		private Sprite _questIcon;

		// Token: 0x0400D43B RID: 54331
		private bool bool_0;

		// Token: 0x0400D43C RID: 54332
		private Action<bool> action_0;

		// Token: 0x02002940 RID: 10560
		[CompilerGenerated]
		private sealed class Class2412
		{
			// Token: 0x0600D2B7 RID: 53943 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(GClass2940 skillRequirement, RequiredSkillOrLevel view)
			{
				throw null;
			}

			// Token: 0x0600D2B8 RID: 53944 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1(ClothingRequirements.GClass3014 questTemplate, RequiredSkillOrLevel view)
			{
				throw null;
			}

			// Token: 0x0400D43D RID: 54333
			public Profile profile;

			// Token: 0x0400D43E RID: 54334
			public SkillsAndLevelsRequirementsPanel skillsAndLevelsRequirementsPanel_0;

			// Token: 0x0400D43F RID: 54335
			public GClass3359 quests;
		}

		// Token: 0x02002941 RID: 10561
		[CompilerGenerated]
		private sealed class Class2413
		{
			// Token: 0x0600D2B9 RID: 53945 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(GClass1765 skill)
			{
				throw null;
			}

			// Token: 0x0400D440 RID: 54336
			public GClass2940 skillRequirement;
		}
	}
}
