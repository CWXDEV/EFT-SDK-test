using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002B57 RID: 11095
	public sealed class SkillTooltip : Tooltip
	{
		// Token: 0x0600DB82 RID: 56194 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(GClass1765 skill, Vector2 position)
		{
			throw null;
		}

		// Token: 0x0400DF2E RID: 57134
		[SerializeField]
		private SkillClassIcon _classIcon;

		// Token: 0x0400DF2F RID: 57135
		[SerializeField]
		private CustomTextMeshProUGUI _name;

		// Token: 0x0400DF30 RID: 57136
		[SerializeField]
		private SkillLevelPanel _levelPanel;

		// Token: 0x0400DF31 RID: 57137
		[SerializeField]
		private CustomTextMeshProUGUI _description;

		// Token: 0x0400DF32 RID: 57138
		[SerializeField]
		private Image _initialProgressFill;

		// Token: 0x0400DF33 RID: 57139
		[SerializeField]
		private CustomTextMeshProUGUI _level;

		// Token: 0x0400DF34 RID: 57140
		[SerializeField]
		private CustomTextMeshProUGUI _progress;

		// Token: 0x0400DF35 RID: 57141
		[SerializeField]
		private Transform _buffContainer;

		// Token: 0x0400DF36 RID: 57142
		[SerializeField]
		private BuffPanel _buffPanelTemplate;

		// Token: 0x0400DF37 RID: 57143
		[SerializeField]
		private Sprite _normalFillSprite;

		// Token: 0x0400DF38 RID: 57144
		[SerializeField]
		private Sprite _eliteFillSprite;

		// Token: 0x0400DF39 RID: 57145
		[SerializeField]
		private GameObject _effectivenessUp;

		// Token: 0x0400DF3A RID: 57146
		[SerializeField]
		private GameObject _effectivenessDown;

		// Token: 0x02002B58 RID: 11096
		[CompilerGenerated]
		private sealed class Class2620
		{
			// Token: 0x0600DB83 RID: 56195 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(SkillManager.GClass1770 buff, BuffPanel buffPanel)
			{
				throw null;
			}

			// Token: 0x0600DB84 RID: 56196 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1()
			{
				throw null;
			}

			// Token: 0x0400DF3B RID: 57147
			public GClass1765 skill;

			// Token: 0x0400DF3C RID: 57148
			public SkillTooltip skillTooltip_0;

			// Token: 0x0400DF3D RID: 57149
			public GClass3078<SkillManager.GClass1770, BuffPanel> buffPanels;
		}

		// Token: 0x02002B59 RID: 11097
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2621
		{
			// Token: 0x0600DB85 RID: 56197 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(BuffPanel buffPanel)
			{
				throw null;
			}

			// Token: 0x0400DF3E RID: 57150
			public static readonly SkillTooltip.Class2621 class2621_0;

			// Token: 0x0400DF3F RID: 57151
			public static Action<BuffPanel> action_0;
		}
	}
}
