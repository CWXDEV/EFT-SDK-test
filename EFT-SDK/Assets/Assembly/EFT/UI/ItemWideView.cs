using System;
using System.Runtime.CompilerServices;
using EFT.Quests;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002B91 RID: 11153
	public sealed class ItemWideView : ItemIconView, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		// Token: 0x0600DC1F RID: 56351 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(GClass3244 reward)
		{
			throw null;
		}

		// Token: 0x0600DC20 RID: 56352 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(bool state)
		{
			throw null;
		}

		// Token: 0x0600DC21 RID: 56353 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void UpdateScale()
		{
			throw null;
		}

		// Token: 0x0600DC22 RID: 56354 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x0600DC23 RID: 56355 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerEnter([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600DC24 RID: 56356 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerExit([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600DC25 RID: 56357 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnDisable()
		{
			throw null;
		}

		// Token: 0x0400E022 RID: 57378
		[SerializeField]
		private CustomTextMeshProUGUI _name;

		// Token: 0x0400E023 RID: 57379
		[SerializeField]
		private CustomTextMeshProUGUI _count;

		// Token: 0x0400E024 RID: 57380
		[SerializeField]
		private Image _unlockRewardIcon;

		// Token: 0x0400E025 RID: 57381
		[SerializeField]
		private GameObject _foundInRaid;

		// Token: 0x0400E026 RID: 57382
		[SerializeField]
		private Sprite _schemeUnlockSprite;

		// Token: 0x0400E027 RID: 57383
		private SimpleTooltip simpleTooltip_0;

		// Token: 0x0400E028 RID: 57384
		private ERewardType erewardType_0;

		// Token: 0x0400E029 RID: 57385
		private string string_0;

		// Token: 0x0400E02A RID: 57386
		private bool bool_0;

		// Token: 0x02002B92 RID: 11154
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2643
		{
			// Token: 0x0600DC26 RID: 56358 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(bool arg1, PointerEventData arg2)
			{
				throw null;
			}

			// Token: 0x0400E02B RID: 57387
			public static readonly ItemWideView.Class2643 class2643_0;

			// Token: 0x0400E02C RID: 57388
			public static Action<bool, PointerEventData> action_0;
		}
	}
}
