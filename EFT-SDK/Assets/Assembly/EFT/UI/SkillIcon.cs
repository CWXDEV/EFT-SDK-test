using System;
using System.Runtime.CompilerServices;
using EFT.HealthSystem;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002B4B RID: 11083
	public sealed class SkillIcon : UIElement
	{
		// Token: 0x0600DB62 RID: 56162 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600DB63 RID: 56163 RVA: 0x00002050 File Offset: 0x00000250
		[CanBeNull]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static Sprite smethod_0(GClass1765 skill)
		{
			throw null;
		}

		// Token: 0x0600DB64 RID: 56164 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(GClass1765 skill, [CanBeNull] IHealthController healthController, Action<bool, PointerEventData> onHover)
		{
			throw null;
		}

		// Token: 0x0600DB65 RID: 56165 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(GInterface226 buff)
		{
			throw null;
		}

		// Token: 0x0600DB66 RID: 56166 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600DB67 RID: 56167 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0400DEFC RID: 57084
		[SerializeField]
		private Image _border;

		// Token: 0x0400DEFD RID: 57085
		[SerializeField]
		private CustomTextMeshProUGUI _progress;

		// Token: 0x0400DEFE RID: 57086
		[SerializeField]
		private Image _icon;

		// Token: 0x0400DEFF RID: 57087
		[SerializeField]
		private SkillLevelPanel _levelPanel;

		// Token: 0x0400DF00 RID: 57088
		[SerializeField]
		private SkillClassIcon _classIcon;

		// Token: 0x0400DF01 RID: 57089
		[SerializeField]
		private HoverTooltipArea _alphaBlockedSkill;

		// Token: 0x0400DF02 RID: 57090
		[SerializeField]
		private SkillBuffIcon _skillBuffIcon;

		// Token: 0x0400DF03 RID: 57091
		private GClass1765 gclass1765_0;

		// Token: 0x0400DF04 RID: 57092
		private static readonly Color color_0;

		// Token: 0x0400DF05 RID: 57093
		private Action<bool, PointerEventData> action_0;

		// Token: 0x0400DF06 RID: 57094
		private bool bool_0;

		// Token: 0x02002B4C RID: 11084
		[CompilerGenerated]
		private sealed class Class2614
		{
			// Token: 0x0600DB68 RID: 56168 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0600DB69 RID: 56169 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1()
			{
				throw null;
			}

			// Token: 0x0400DF07 RID: 57095
			public IHealthController healthController;

			// Token: 0x0400DF08 RID: 57096
			public SkillIcon skillIcon_0;

			// Token: 0x0400DF09 RID: 57097
			public GClass1765 skill;
		}

		// Token: 0x02002B4D RID: 11085
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2615
		{
			// Token: 0x0600DB6A RID: 56170 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(GInterface226 x)
			{
				throw null;
			}

			// Token: 0x0400DF0A RID: 57098
			public static readonly SkillIcon.Class2615 class2615_0;

			// Token: 0x0400DF0B RID: 57099
			public static Func<GInterface226, bool> func_0;
		}
	}
}
