using System;
using System.Runtime.CompilerServices;
using EFT.UI;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace EFT.Hideout
{
	// Token: 0x02001B70 RID: 7024
	public sealed class BonusPanel : UIElement
	{
		// Token: 0x060093F8 RID: 37880 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(GClass1404 bonus, Sprite sprite)
		{
			throw null;
		}

		// Token: 0x060093F9 RID: 37881 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateView(ELightStatus lightStatus, bool activeProduction, ELevelType levelType)
		{
			throw null;
		}

		// Token: 0x060093FA RID: 37882 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateIcon([CanBeNull] Texture2D resultValue)
		{
			throw null;
		}

		// Token: 0x060093FB RID: 37883 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x04009AA6 RID: 39590
		private const string string_0 = "hideout/bonus_is_inactive_due_to_energy";

		// Token: 0x04009AA7 RID: 39591
		private const string string_1 = "hideout/bonus_is_inactive_due_to_production_state";

		// Token: 0x04009AA8 RID: 39592
		[SerializeField]
		private Image _icon;

		// Token: 0x04009AA9 RID: 39593
		[SerializeField]
		private TextMeshProUGUI _description;

		// Token: 0x04009AAA RID: 39594
		[SerializeField]
		private TextMeshProUGUI _effect;

		// Token: 0x04009AAB RID: 39595
		private GClass1404 gclass1404_0;

		// Token: 0x04009AAC RID: 39596
		private string string_2;

		// Token: 0x04009AAD RID: 39597
		private SimpleTooltip simpleTooltip_0;

		// Token: 0x02001B71 RID: 7025
		[CompilerGenerated]
		private sealed class Class1662
		{
			// Token: 0x060093FC RID: 37884 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(PointerEventData eventData)
			{
				throw null;
			}

			// Token: 0x060093FD RID: 37885 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1(PointerEventData eventData)
			{
				throw null;
			}

			// Token: 0x060093FE RID: 37886 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_2()
			{
				throw null;
			}

			// Token: 0x060093FF RID: 37887 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_3()
			{
				throw null;
			}

			// Token: 0x04009AAE RID: 39598
			public BonusPanel bonusPanel_0;

			// Token: 0x04009AAF RID: 39599
			public HoverTrigger hoverTrigger;
		}
	}
}
