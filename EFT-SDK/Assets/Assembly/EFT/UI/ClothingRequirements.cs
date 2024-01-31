using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x02002938 RID: 10552
	public sealed class ClothingRequirements : UIElement
	{
		// Token: 0x0600D2AA RID: 53930 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(Profile profile, Profile.TraderInfo trader, GClass3359 quests, GClass2495 stashGrid, GClass2939 requirements, Action<bool> onAvailableChanged)
		{
			throw null;
		}

		// Token: 0x0600D2AB RID: 53931 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateView()
		{
			throw null;
		}

		// Token: 0x0600D2AC RID: 53932 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(Profile profile, Profile.TraderInfo trader, GClass3359 quests, GClass2939 requirements, Action<bool> onAvailableChanged)
		{
			throw null;
		}

		// Token: 0x0600D2AD RID: 53933 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0400D417 RID: 54295
		private const int int_0 = 4;

		// Token: 0x0400D418 RID: 54296
		private const int int_1 = 3;

		// Token: 0x0400D419 RID: 54297
		private const int int_2 = 40;

		// Token: 0x0400D41A RID: 54298
		[SerializeField]
		private SkillsAndLevelsRequirementsPanel _skillsAndLevelsRow;

		// Token: 0x0400D41B RID: 54299
		[SerializeField]
		private Transform _skillsAndLevelsPanel;

		// Token: 0x0400D41C RID: 54300
		[SerializeField]
		private ItemRequirementsPanel _itemsPanel;

		// Token: 0x02002939 RID: 10553
		public sealed class GClass3014
		{
			// Token: 0x0400D41D RID: 54301
			public RawQuestClass QuestTemplate;

			// Token: 0x0400D41E RID: 54302
			public float Width;
		}

		// Token: 0x0200293A RID: 10554
		private sealed class Class2409
		{
			// Token: 0x0400D41F RID: 54303
			public int? loyaltyLevel;

			// Token: 0x0400D420 RID: 54304
			public int? profileLevel;

			// Token: 0x0400D421 RID: 54305
			public float? standing;

			// Token: 0x0400D422 RID: 54306
			public IEnumerable<GClass2940> skillRequirements;

			// Token: 0x0400D423 RID: 54307
			public IEnumerable<ClothingRequirements.GClass3014> questRequirements;
		}

		// Token: 0x0200293B RID: 10555
		[CompilerGenerated]
		private sealed class Class2410
		{
			// Token: 0x0600D2AE RID: 53934 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(float rowWidth, ref ClothingRequirements.Struct839 struct839_0)
			{
				throw null;
			}

			// Token: 0x0600D2AF RID: 53935 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1(ClothingRequirements.Class2409 item, SkillsAndLevelsRequirementsPanel view)
			{
				throw null;
			}

			// Token: 0x0400D424 RID: 54308
			public GClass2939 requirements;

			// Token: 0x0400D425 RID: 54309
			public int requirementsInCurrentRow;

			// Token: 0x0400D426 RID: 54310
			public ClothingRequirements.Class2409 requirementsInfo;

			// Token: 0x0400D427 RID: 54311
			public List<ClothingRequirements.Class2409> panelsCollection;

			// Token: 0x0400D428 RID: 54312
			public int currentPanelIndex;

			// Token: 0x0400D429 RID: 54313
			public Profile profile;

			// Token: 0x0400D42A RID: 54314
			public Profile.TraderInfo trader;

			// Token: 0x0400D42B RID: 54315
			public GClass3359 quests;

			// Token: 0x0400D42C RID: 54316
			public Action<bool> onAvailableChanged;
		}

		// Token: 0x0200293C RID: 10556
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		public struct Struct839
		{
			// Token: 0x0400D42D RID: 54317
			public float rowAvailableWidth;

			// Token: 0x0400D42E RID: 54318
			public List<ClothingRequirements.GClass3014> panelQuestRequirements;
		}

		// Token: 0x0200293D RID: 10557
		[CompilerGenerated]
		private sealed class Class2411
		{
			// Token: 0x0600D2B0 RID: 53936 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(RawQuestClass template)
			{
				throw null;
			}

			// Token: 0x0400D42F RID: 54319
			public int i;

			// Token: 0x0400D430 RID: 54320
			public ClothingRequirements.Class2410 class2410_0;
		}
	}
}
