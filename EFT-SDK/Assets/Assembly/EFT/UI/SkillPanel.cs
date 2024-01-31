using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.HealthSystem;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002B51 RID: 11089
	public sealed class SkillPanel : UIElement
	{
		// Token: 0x0600DB6E RID: 56174 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(GClass1765 skill, IHealthController healthController)
		{
			throw null;
		}

		// Token: 0x0600DB6F RID: 56175 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(GInterface226 buff)
		{
			throw null;
		}

		// Token: 0x0600DB70 RID: 56176 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x0600DB71 RID: 56177 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(bool hover, PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600DB72 RID: 56178 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(SkillManager.GClass1770 buff, BuffIcon buffIcon)
		{
			throw null;
		}

		// Token: 0x0600DB73 RID: 56179 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x0400DF0F RID: 57103
		[SerializeField]
		private CustomTextMeshProUGUI _level;

		// Token: 0x0400DF10 RID: 57104
		[SerializeField]
		private CustomTextMeshProUGUI _name;

		// Token: 0x0400DF11 RID: 57105
		[SerializeField]
		private BuffIcon _buffIconTemplate;

		// Token: 0x0400DF12 RID: 57106
		[SerializeField]
		private Transform _buffsContainer;

		// Token: 0x0400DF13 RID: 57107
		[SerializeField]
		private Image _initialProgressFill;

		// Token: 0x0400DF14 RID: 57108
		[SerializeField]
		private SkillIcon _skillIcon;

		// Token: 0x0400DF15 RID: 57109
		[SerializeField]
		private Sprite _normalFillSprite;

		// Token: 0x0400DF16 RID: 57110
		[SerializeField]
		private Sprite _eliteFillSprite;

		// Token: 0x0400DF17 RID: 57111
		[SerializeField]
		private CanvasGroup _alphaBlockedSkill;

		// Token: 0x0400DF18 RID: 57112
		[SerializeField]
		private GameObject _effectivenessUp;

		// Token: 0x0400DF19 RID: 57113
		[SerializeField]
		private GameObject _effectivenessDown;

		// Token: 0x0400DF1A RID: 57114
		private SimpleTooltip simpleTooltip_0;

		// Token: 0x0400DF1B RID: 57115
		private GClass3078<SkillManager.GClass1770, BuffIcon> gclass3078_0;

		// Token: 0x0400DF1C RID: 57116
		private GClass1765 gclass1765_0;

		// Token: 0x0400DF1D RID: 57117
		private IHealthController ihealthController_0;

		// Token: 0x02002B52 RID: 11090
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2617
		{
			// Token: 0x0600DB74 RID: 56180 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(SkillManager.GClass1770 buff)
			{
				throw null;
			}

			// Token: 0x0600DB75 RID: 56181 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal IEnumerable<GInterface226> method_1(GInterface276 effect)
			{
				throw null;
			}

			// Token: 0x0600DB76 RID: 56182 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_2(GInterface226 x)
			{
				throw null;
			}

			// Token: 0x0600DB77 RID: 56183 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_3(BuffIcon buffIcon)
			{
				throw null;
			}

			// Token: 0x0400DF1E RID: 57118
			public static readonly SkillPanel.Class2617 class2617_0;

			// Token: 0x0400DF1F RID: 57119
			public static Func<SkillManager.GClass1770, bool> func_0;

			// Token: 0x0400DF20 RID: 57120
			public static Func<GInterface226, bool> func_1;

			// Token: 0x0400DF21 RID: 57121
			public static Func<GInterface276, IEnumerable<GInterface226>> func_2;

			// Token: 0x0400DF22 RID: 57122
			public static Action<BuffIcon> action_0;
		}
	}
}
