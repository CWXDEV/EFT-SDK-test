using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EFT.UI;
using TMPro;
using UnityEngine;

namespace EFT.Hideout
{
	// Token: 0x02001BB9 RID: 7097
	public sealed class RequirementsPanel : AbstractPanel<List<Requirement>>
	{
		// Token: 0x06009518 RID: 38168 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Task ShowContents()
		{
			throw null;
		}

		// Token: 0x06009519 RID: 38169 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetInfo()
		{
			throw null;
		}

		// Token: 0x0600951A RID: 38170 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private GInterface172 method_0(Requirement requirement)
		{
			throw null;
		}

		// Token: 0x0600951B RID: 38171 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Transform method_1(Requirement requirement)
		{
			throw null;
		}

		// Token: 0x04009BD2 RID: 39890
		private const string string_0 = "LEVEL {0} UPGRADE REQUIREMENTS";

		// Token: 0x04009BD3 RID: 39891
		private const string string_1 = "NEXT LEVEL UPGRADE REQUIREMENTS";

		// Token: 0x04009BD4 RID: 39892
		private const string string_2 = "CONSTRUCT REQUIREMENTS";

		// Token: 0x04009BD5 RID: 39893
		[SerializeField]
		private TextMeshProUGUI _requirementsLabel;

		// Token: 0x04009BD6 RID: 39894
		[SerializeField]
		private AreaRequirementPanel _areaRequirementPanel;

		// Token: 0x04009BD7 RID: 39895
		[SerializeField]
		private ItemRequirementPanel _itemRequirementPanel;

		// Token: 0x04009BD8 RID: 39896
		[SerializeField]
		private TraderRequirementPanel _traderRequirementPanel;

		// Token: 0x04009BD9 RID: 39897
		[SerializeField]
		private SkillRequirementPanel _skillRequirementPanel;

		// Token: 0x04009BDA RID: 39898
		[SerializeField]
		private RectTransform _areaContainer;

		// Token: 0x04009BDB RID: 39899
		[SerializeField]
		private RectTransform _itemContainer;

		// Token: 0x04009BDC RID: 39900
		[SerializeField]
		private RectTransform _traderContainer;

		// Token: 0x04009BDD RID: 39901
		[SerializeField]
		private RectTransform _skillContainer;

		// Token: 0x04009BDE RID: 39902
		private GClass3076<Requirement, GInterface172> gclass3076_0;

		// Token: 0x02001BBA RID: 7098
		[CompilerGenerated]
		private sealed class Class1677
		{
			// Token: 0x0600951C RID: 38172 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0()
			{
				throw null;
			}

			// Token: 0x0600951D RID: 38173 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1(Requirement requirement, GInterface172 view)
			{
				throw null;
			}

			// Token: 0x04009BDF RID: 39903
			public RequirementsPanel requirementsPanel_0;

			// Token: 0x04009BE0 RID: 39904
			public ItemUiContext itemUiContext;
		}

		// Token: 0x02001BBB RID: 7099
		[CompilerGenerated]
		[Serializable]
		private sealed class Class1678
		{
			// Token: 0x0600951E RID: 38174 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal ERequirementType method_0(Requirement x)
			{
				throw null;
			}

			// Token: 0x04009BE1 RID: 39905
			public static readonly RequirementsPanel.Class1678 class1678_0;

			// Token: 0x04009BE2 RID: 39906
			public static Func<Requirement, ERequirementType> func_0;
		}
	}
}
