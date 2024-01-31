using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002B06 RID: 11014
	public class HierarchyFilterTab : FilterTab
	{
		// Token: 0x17002686 RID: 9862
		// (get) Token: 0x0600DA90 RID: 55952 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600DA91 RID: 55953 RVA: 0x00002050 File Offset: 0x00000250
		public IEnumerable<Tab> SubTabs
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x0600DA92 RID: 55954 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(IEnumerable<Tab> subTabs)
		{
			throw null;
		}

		// Token: 0x0600DA93 RID: 55955 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(HierarchyFilterTab parent)
		{
			throw null;
		}

		// Token: 0x0600DA94 RID: 55956 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Select(bool sendCallback = true)
		{
			throw null;
		}

		// Token: 0x0600DA95 RID: 55957 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Hover(bool isHovered)
		{
			throw null;
		}

		// Token: 0x0600DA96 RID: 55958 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void UpdateVisual(bool selected, bool uiOnly = false)
		{
			throw null;
		}

		// Token: 0x0600DA97 RID: 55959 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Task<bool> Deselect()
		{
			throw null;
		}

		// Token: 0x0400DDA4 RID: 56740
		[SerializeField]
		private Sprite _subtabNormal;

		// Token: 0x0400DDA5 RID: 56741
		[SerializeField]
		private Sprite _subtabHover;

		// Token: 0x0400DDA6 RID: 56742
		[SerializeField]
		private Sprite _subtabSelected;

		// Token: 0x0400DDA7 RID: 56743
		[SerializeField]
		private Image _subgroupArrow;

		// Token: 0x0400DDA8 RID: 56744
		[SerializeField]
		private Color _normalArrowColor;

		// Token: 0x0400DDA9 RID: 56745
		[SerializeField]
		private Color _selectedArrowColor;

		// Token: 0x0400DDAA RID: 56746
		private HierarchyFilterTab hierarchyFilterTab_0;

		// Token: 0x0400DDAB RID: 56747
		[CompilerGenerated]
		private IEnumerable<Tab> ienumerable_0;
	}
}
