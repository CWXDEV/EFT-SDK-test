using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AchievementsSystem;
using EFT.UI;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace EFT.Achievements
{
	// Token: 0x02003092 RID: 12434
	public sealed class AchievementView : UIElement, IDisposable, IUIView, GInterface382
	{
		// Token: 0x170029DD RID: 10717
		// (get) Token: 0x0600F3C9 RID: 62409 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F3CA RID: 62410 RVA: 0x00002050 File Offset: 0x00000250
		public GClass1248 Achievement
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

		// Token: 0x0600F3CB RID: 62411 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600F3CC RID: 62412 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void GInterface382.Show(GClass1248 model, AbstractAchievementControllerClass achievementsController, NotesTaskDescriptionShort description, ISession session)
		{
			throw null;
		}

		// Token: 0x0600F3CD RID: 62413 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0600F3CE RID: 62414 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x0600F3CF RID: 62415 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x0600F3D0 RID: 62416 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ShowRewardsTooltip(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600F3D1 RID: 62417 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void HideRewardsTooltip(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600F3D2 RID: 62418 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ShowConditionsTooltip(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600F3D3 RID: 62419 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void HideConditionsTooltip(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0400FA18 RID: 64024
		[SerializeField]
		private Image _templateBackground;

		// Token: 0x0400FA19 RID: 64025
		[SerializeField]
		private TMP_Text _titleText;

		// Token: 0x0400FA1A RID: 64026
		[SerializeField]
		private TMP_Text _descriptionText;

		// Token: 0x0400FA1B RID: 64027
		[SerializeField]
		private HoverTrigger _progressBar;

		// Token: 0x0400FA1C RID: 64028
		[SerializeField]
		private Image _progressBarImage;

		// Token: 0x0400FA1D RID: 64029
		[SerializeField]
		private TMP_Text _progressText;

		// Token: 0x0400FA1E RID: 64030
		[SerializeField]
		private TMP_Text _globalProgressText;

		// Token: 0x0400FA1F RID: 64031
		[SerializeField]
		private TMP_Text _unlockDateText;

		// Token: 0x0400FA20 RID: 64032
		[SerializeField]
		private Color _legendaryUnlockDateTextColor;

		// Token: 0x0400FA21 RID: 64033
		[SerializeField]
		private AchievementIconView _achievementIconView;

		// Token: 0x0400FA22 RID: 64034
		[SerializeField]
		private List<TextMeshProUGUI> _labels;

		// Token: 0x0400FA23 RID: 64035
		[SerializeField]
		private Sprite _commonBackground;

		// Token: 0x0400FA24 RID: 64036
		[SerializeField]
		private Sprite _rareBackground;

		// Token: 0x0400FA25 RID: 64037
		[SerializeField]
		private Sprite _legendaryBackground;

		// Token: 0x0400FA26 RID: 64038
		private NotesTaskDescriptionShort notesTaskDescriptionShort_0;

		// Token: 0x0400FA27 RID: 64039
		private AbstractAchievementControllerClass gclass3207_0;

		// Token: 0x0400FA28 RID: 64040
		private ISession ginterface145_0;

		// Token: 0x0400FA29 RID: 64041
		[CompilerGenerated]
		private GClass1248 gclass1248_0;
	}
}
