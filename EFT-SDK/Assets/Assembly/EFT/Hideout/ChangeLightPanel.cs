using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.UI;
using UnityEngine;

namespace EFT.Hideout
{
	// Token: 0x02001BD3 RID: 7123
	public sealed class ChangeLightPanel : UIElement
	{
		// Token: 0x140001BC RID: 444
		// (add) Token: 0x06009590 RID: 38288 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06009591 RID: 38289 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<Sprite> OnButtonSelected
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x140001BD RID: 445
		// (add) Token: 0x06009592 RID: 38290 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06009593 RID: 38291 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<ELightingLevel> OnLightningSelected
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x06009594 RID: 38292 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show()
		{
			throw null;
		}

		// Token: 0x06009595 RID: 38293 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Hide()
		{
			throw null;
		}

		// Token: 0x06009596 RID: 38294 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private string method_0(ELightingLevel level, ComplementaryButton button)
		{
			throw null;
		}

		// Token: 0x06009597 RID: 38295 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(ELightingLevel level)
		{
			throw null;
		}

		// Token: 0x06009598 RID: 38296 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetCurrentLightingLevel(ELightingLevel level)
		{
			throw null;
		}

		// Token: 0x06009599 RID: 38297 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddLightingLevel(ELightingLevel level, bool switchToNewLevel)
		{
			throw null;
		}

		// Token: 0x0600959A RID: 38298 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearLightLevels()
		{
			throw null;
		}

		// Token: 0x04009C44 RID: 40004
		private const string string_0 = "hideout/Disable all light";

		// Token: 0x04009C45 RID: 40005
		private const string string_1 = "hideout/Enable candles";

		// Token: 0x04009C46 RID: 40006
		private const string string_2 = "hideout/Enable light bulbs";

		// Token: 0x04009C47 RID: 40007
		private const string string_3 = "hideout/Enable gas lamps";

		// Token: 0x04009C48 RID: 40008
		private const string string_4 = "hideout/Enable christmas lights";

		// Token: 0x04009C49 RID: 40009
		private const string string_5 = "hideout/Enable halloween lights";

		// Token: 0x04009C4A RID: 40010
		private const string string_6 = "This light level has not been unlocked yet";

		// Token: 0x04009C4B RID: 40011
		[SerializeField]
		private Dictionary<ELightingLevel, ComplementaryButton> _lightButtons;

		// Token: 0x04009C4C RID: 40012
		[SerializeField]
		private Dictionary<ELightingLevel, AudioClip> _sounds;

		// Token: 0x04009C4D RID: 40013
		[CompilerGenerated]
		private Action<Sprite> action_0;

		// Token: 0x04009C4E RID: 40014
		[CompilerGenerated]
		private Action<ELightingLevel> action_1;

		// Token: 0x04009C4F RID: 40015
		private HashSet<ELightingLevel> hashSet_0;

		// Token: 0x04009C50 RID: 40016
		private ELightingLevel elightingLevel_0;

		// Token: 0x02001BD4 RID: 7124
		[CompilerGenerated]
		private sealed class Class1682
		{
			// Token: 0x0600959B RID: 38299 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(bool arg)
			{
				throw null;
			}

			// Token: 0x0600959C RID: 38300 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_1()
			{
				throw null;
			}

			// Token: 0x04009C51 RID: 40017
			public ELightingLevel level;

			// Token: 0x04009C52 RID: 40018
			public ComplementaryButton button;

			// Token: 0x04009C53 RID: 40019
			public ChangeLightPanel changeLightPanel_0;
		}
	}
}
