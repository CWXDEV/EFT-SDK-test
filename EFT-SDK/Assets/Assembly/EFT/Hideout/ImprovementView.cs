using System;
using System.Runtime.CompilerServices;
using EFT.UI;
using TMPro;
using UnityEngine;

namespace EFT.Hideout
{
	// Token: 0x02001AE0 RID: 6880
	public class ImprovementView : UIElement
	{
		// Token: 0x170015EE RID: 5614
		// (get) Token: 0x060090B6 RID: 37046 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060090B7 RID: 37047 RVA: 0x00002050 File Offset: 0x00000250
		private InventoryControllerClass GClass2757_0
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170015EF RID: 5615
		// (get) Token: 0x060090B8 RID: 37048 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060090B9 RID: 37049 RVA: 0x00002050 File Offset: 0x00000250
		private ItemUiContext ItemUiContext_0
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170015F0 RID: 5616
		// (get) Token: 0x060090BA RID: 37050 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060090BB RID: 37051 RVA: 0x00002050 File Offset: 0x00000250
		private AreaData AreaData_0
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060090BC RID: 37052 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(ItemUiContext itemUiContext, InventoryControllerClass inventoryController, GClass1908 improvement, AreaData area)
		{
			throw null;
		}

		// Token: 0x060090BD RID: 37053 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x060090BE RID: 37054 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x060090BF RID: 37055 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x060090C0 RID: 37056 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public new void ShowGameObject()
		{
			throw null;
		}

		// Token: 0x060090C1 RID: 37057 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_3()
		{
			throw null;
		}

		// Token: 0x060090C2 RID: 37058 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateView()
		{
			throw null;
		}

		// Token: 0x060090C3 RID: 37059 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x060090C4 RID: 37060 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x060090C5 RID: 37061 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5()
		{
			throw null;
		}

		// Token: 0x060090C6 RID: 37062 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6()
		{
			throw null;
		}

		// Token: 0x060090C7 RID: 37063 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7()
		{
			throw null;
		}

		// Token: 0x060090C8 RID: 37064 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_8()
		{
			throw null;
		}

		// Token: 0x040097F1 RID: 38897
		[SerializeField]
		[Space]
		private DefaultUIButton _startButton;

		// Token: 0x040097F2 RID: 38898
		[SerializeField]
		[Space]
		private GameObject _percentagePanel;

		// Token: 0x040097F3 RID: 38899
		[SerializeField]
		private TextMeshProUGUI _percentageText;

		// Token: 0x040097F4 RID: 38900
		[SerializeField]
		private GameObject _expectedTimePanel;

		// Token: 0x040097F5 RID: 38901
		[SerializeField]
		private TextMeshProUGUI _expectedTime;

		// Token: 0x040097F6 RID: 38902
		[Space]
		[SerializeField]
		private TextMeshProUGUI _status;

		// Token: 0x040097F7 RID: 38903
		[Space]
		[SerializeField]
		private ItemRequirementPanel _requiredItemTemplate;

		// Token: 0x040097F8 RID: 38904
		[SerializeField]
		private Transform _requiredItemsContainer;

		// Token: 0x040097F9 RID: 38905
		[CompilerGenerated]
		private InventoryControllerClass gclass2757_0;

		// Token: 0x040097FA RID: 38906
		[CompilerGenerated]
		private ItemUiContext itemUiContext_0;

		// Token: 0x040097FB RID: 38907
		[CompilerGenerated]
		private AreaData areaData_0;

		// Token: 0x040097FC RID: 38908
		protected const string REQUIREMENTS_NOT_FULFILLED = "hideout/Requirements are not fulfilled";

		// Token: 0x040097FD RID: 38909
		private const int int_0 = 1;

		// Token: 0x040097FE RID: 38910
		private DateTime dateTime_0;

		// Token: 0x040097FF RID: 38911
		private static readonly string string_0;

		// Token: 0x04009800 RID: 38912
		private static readonly string string_1;

		// Token: 0x04009801 RID: 38913
		private GClass3078<Requirement, ItemRequirementPanel> gclass3078_0;

		// Token: 0x04009802 RID: 38914
		private bool bool_0;

		// Token: 0x04009803 RID: 38915
		private bool bool_1;

		// Token: 0x04009804 RID: 38916
		private GClass1908 gclass1908_0;

		// Token: 0x02001AE1 RID: 6881
		[CompilerGenerated]
		private sealed class Class1620
		{
			// Token: 0x060090C9 RID: 37065 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x060090CA RID: 37066 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1(Requirement requirement, ItemRequirementPanel itemView)
			{
				throw null;
			}

			// Token: 0x04009805 RID: 38917
			public ImprovementView improvementView_0;

			// Token: 0x04009806 RID: 38918
			public AreaData area;
		}

		// Token: 0x02001AE2 RID: 6882
		[CompilerGenerated]
		[Serializable]
		private sealed class Class1621
		{
			// Token: 0x060090CB RID: 37067 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(Requirement v)
			{
				throw null;
			}

			// Token: 0x04009807 RID: 38919
			public static readonly ImprovementView.Class1621 class1621_0;

			// Token: 0x04009808 RID: 38920
			public static Func<Requirement, bool> func_0;
		}
	}
}
