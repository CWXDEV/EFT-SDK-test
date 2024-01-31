using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002B17 RID: 11031
	public sealed class MasteringIcon : ItemIconView
	{
		// Token: 0x0600DAD8 RID: 56024 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(KeyValuePair<string, GClass1764> masteringSkill, Action<bool, PointerEventData> onHover)
		{
			throw null;
		}

		// Token: 0x0600DAD9 RID: 56025 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateProgress(GClass1764 mastering)
		{
			throw null;
		}

		// Token: 0x0600DADA RID: 56026 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnHoverEnd(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0400DE16 RID: 56854
		[SerializeField]
		private CustomTextMeshProUGUI _progress;

		// Token: 0x0400DE17 RID: 56855
		[SerializeField]
		private Image _levelUpGlow;

		// Token: 0x0400DE18 RID: 56856
		[SerializeField]
		private GameObject _mastering;

		// Token: 0x0400DE19 RID: 56857
		[SerializeField]
		private CustomTextMeshProUGUI _masteringText;
	}
}
