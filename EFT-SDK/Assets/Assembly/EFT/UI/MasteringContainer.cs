using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x02002B13 RID: 11027
	public class MasteringContainer<TSkillView> : UIElement where TSkillView : IUIView
	{
		// Token: 0x0600DACC RID: 56012 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void Show(KeyValuePair<string, GClass1764>[] skills, DropDownBox sortMethod, DropDownBox filterMethod, TMP_InputField inputField, GInterface313 inventoryController, Action<KeyValuePair<string, GClass1764>, TSkillView> showAction)
		{
			throw null;
		}

		// Token: 0x0600DACD RID: 56013 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool smethod_0(KeyValuePair<string, GClass1764> skill, DropDownBox filterMethod, string weaponName)
		{
			throw null;
		}

		// Token: 0x0600DACE RID: 56014 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool smethod_1(KeyValuePair<string, GClass1764> skill, DropDownBox filterMethod)
		{
			throw null;
		}

		// Token: 0x0600DACF RID: 56015 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool smethod_2(KeyValuePair<string, GClass1764> skill, string weaponName)
		{
			throw null;
		}

		// Token: 0x0400DE09 RID: 56841
		[SerializeField]
		private Transform _skillsContainer;

		// Token: 0x0400DE0A RID: 56842
		[SerializeField]
		private TSkillView _skillViewTemplate;

		// Token: 0x02002B14 RID: 11028
		[CompilerGenerated]
		private sealed class Class2586
		{
			// Token: 0x0600DAD0 RID: 56016 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(int index)
			{
				throw null;
			}

			// Token: 0x0600DAD1 RID: 56017 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1(int index)
			{
				throw null;
			}

			// Token: 0x0600DAD2 RID: 56018 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_2(KeyValuePair<string, GClass1764> skill)
			{
				throw null;
			}

			// Token: 0x0600DAD3 RID: 56019 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_3(KeyValuePair<string, GClass1764> skill)
			{
				throw null;
			}

			// Token: 0x0400DE0B RID: 56843
			public GClass3078<KeyValuePair<string, GClass1764>, IUIView> skillPanels;

			// Token: 0x0400DE0C RID: 56844
			public KeyValuePair<string, GClass1764>[] skills;

			// Token: 0x0400DE0D RID: 56845
			public DropDownBox filterMethod;

			// Token: 0x0400DE0E RID: 56846
			public TMP_InputField inputField;

			// Token: 0x0400DE0F RID: 56847
			public Func<KeyValuePair<string, GClass1764>, bool> func_0;

			// Token: 0x0400DE10 RID: 56848
			public Func<KeyValuePair<string, GClass1764>, bool> func_1;
		}

		// Token: 0x02002B15 RID: 11029
		[CompilerGenerated]
		private sealed class Class2587
		{
			// Token: 0x0600DAD5 RID: 56021 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(KeyValuePair<string, GClass1764> skill)
			{
				throw null;
			}

			// Token: 0x0400DE11 RID: 56849
			public string arg;

			// Token: 0x0400DE12 RID: 56850
			public MasteringContainer<IUIView>.Class2586 class2586_0;
		}

		// Token: 0x02002B16 RID: 11030
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2588
		{
			// Token: 0x0600DAD6 RID: 56022 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal float method_0(KeyValuePair<string, GClass1764> skill)
			{
				throw null;
			}

			// Token: 0x0600DAD7 RID: 56023 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal DateTime method_1(KeyValuePair<string, GClass1764> skill)
			{
				throw null;
			}

			// Token: 0x0400DE13 RID: 56851
			public static readonly MasteringContainer<TSkillView>.Class2588 class2588_0;

			// Token: 0x0400DE14 RID: 56852
			public static Func<KeyValuePair<string, GClass1764>, float> func_0;

			// Token: 0x0400DE15 RID: 56853
			public static Func<KeyValuePair<string, GClass1764>, DateTime> func_1;
		}
	}
}
