using System;
using System.Runtime.CompilerServices;
using Bsg.GameSettings;
using UnityEngine;

namespace EFT.UI.Settings
{
	// Token: 0x02002D33 RID: 11571
	public abstract class SettingControl : UIElement
	{
		// Token: 0x170027C5 RID: 10181
		// (get) Token: 0x0600E3BA RID: 58298
		protected abstract Component TargetComponent { get; }

		// Token: 0x0600E3BB RID: 58299 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void InitSetting(IGameSetting setting)
		{
			throw null;
		}

		// Token: 0x0600E3BC RID: 58300 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HoverTooltipArea GetOrCreateTooltip()
		{
			throw null;
		}

		// Token: 0x0400E892 RID: 59538
		[SerializeField]
		private LocalizedText Text;

		// Token: 0x0400E893 RID: 59539
		private HoverTooltipArea hoverTooltipArea_0;

		// Token: 0x0400E894 RID: 59540
		private UiElementBlocker uiElementBlocker_0;
	}
}
