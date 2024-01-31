using System;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002937 RID: 10551
	public sealed class ClothingConfirmationWindow : UIElement, IEventSystemHandler, IPointerClickHandler
	{
		// Token: 0x0600D2A1 RID: 53921 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600D2A2 RID: 53922 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(string suiteName, Profile profile, Profile.TraderInfo trader, GClass3359 quests, GClass2939 requirements, GClass2495 stashGrid, Action unlockAction, [CanBeNull] Action cancelAction)
		{
			throw null;
		}

		// Token: 0x0600D2A3 RID: 53923 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(bool availableStatus)
		{
			throw null;
		}

		// Token: 0x0600D2A4 RID: 53924 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void CorrectPosition(GStruct55 margins = default(GStruct55))
		{
			throw null;
		}

		// Token: 0x0600D2A5 RID: 53925 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x0600D2A6 RID: 53926 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerClick([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600D2A7 RID: 53927 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600D2A8 RID: 53928 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x0600D2A9 RID: 53929 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x0400D40F RID: 54287
		[SerializeField]
		private RectTransform _windowTransform;

		// Token: 0x0400D410 RID: 54288
		[SerializeField]
		private GameObject _captionPanel;

		// Token: 0x0400D411 RID: 54289
		[SerializeField]
		private DefaultUIButton _unlockButton;

		// Token: 0x0400D412 RID: 54290
		[SerializeField]
		private TextMeshProUGUI _suiteName;

		// Token: 0x0400D413 RID: 54291
		[SerializeField]
		private Button _closeButton;

		// Token: 0x0400D414 RID: 54292
		[SerializeField]
		private ClothingRequirements _requirements;

		// Token: 0x0400D415 RID: 54293
		private Action action_0;

		// Token: 0x0400D416 RID: 54294
		private Action action_1;
	}
}
