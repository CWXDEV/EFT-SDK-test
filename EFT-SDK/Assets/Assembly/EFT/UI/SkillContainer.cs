using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x02002B48 RID: 11080
	public class SkillContainer<TSkillView> : UIElement where TSkillView : IUIView
	{
		// Token: 0x0600DB5C RID: 56156 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void Show(SkillManager skillManager, DropDownBox sortMethod, DropDownBox filterMethod, Action<GClass1765, TSkillView> showAction)
		{
			throw null;
		}

		// Token: 0x0400DEF3 RID: 57075
		[SerializeField]
		private Transform _skillsContainer;

		// Token: 0x0400DEF4 RID: 57076
		[SerializeField]
		private TSkillView _skillViewTemplate;

		// Token: 0x02002B49 RID: 11081
		[CompilerGenerated]
		private sealed class Class2612
		{
			// Token: 0x0600DB5D RID: 56157 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(int index)
			{
				throw null;
			}

			// Token: 0x0600DB5E RID: 56158 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1(int index)
			{
				throw null;
			}

			// Token: 0x0600DB5F RID: 56159 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_2(GClass1765 skill)
			{
				throw null;
			}

			// Token: 0x0400DEF5 RID: 57077
			public GClass3076<GClass1765, IUIView> skillPanels;

			// Token: 0x0400DEF6 RID: 57078
			public SkillManager skillManager;

			// Token: 0x0400DEF7 RID: 57079
			public DropDownBox filterMethod;

			// Token: 0x0400DEF8 RID: 57080
			public Func<GClass1765, bool> func_0;
		}

		// Token: 0x02002B4A RID: 11082
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2613
		{
			// Token: 0x0600DB60 RID: 56160 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal int method_0(GClass1765 skill)
			{
				throw null;
			}

			// Token: 0x0600DB61 RID: 56161 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal DateTime method_1(GClass1765 skill)
			{
				throw null;
			}

			// Token: 0x0400DEF9 RID: 57081
			public static readonly SkillContainer<TSkillView>.Class2613 class2613_0;

			// Token: 0x0400DEFA RID: 57082
			public static Func<GClass1765, int> func_0;

			// Token: 0x0400DEFB RID: 57083
			public static Func<GClass1765, DateTime> func_1;
		}
	}
}
