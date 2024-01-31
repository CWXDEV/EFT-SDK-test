using System;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI.DragAndDrop
{
	// Token: 0x02002E51 RID: 11857
	public sealed class SearchableView : MonoBehaviour
	{
		// Token: 0x0600EA31 RID: 59953 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Start()
		{
			throw null;
		}

		// Token: 0x0600EA32 RID: 59954 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Configure(InventoryControllerClass inventoryController, bool searchButtonDisplay)
		{
			throw null;
		}

		// Token: 0x0600EA33 RID: 59955 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(SearchableItemClass item, Action showGrids)
		{
			throw null;
		}

		// Token: 0x0600EA34 RID: 59956 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ShowContents()
		{
			throw null;
		}

		// Token: 0x0600EA35 RID: 59957 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Close()
		{
			throw null;
		}

		// Token: 0x0600EA36 RID: 59958 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0600EA37 RID: 59959 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(int _)
		{
			throw null;
		}

		// Token: 0x0600EA38 RID: 59960 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_2(GClass2865 x)
		{
			throw null;
		}

		// Token: 0x0600EA39 RID: 59961 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(SearchedState searchState)
		{
			throw null;
		}

		// Token: 0x0600EA3A RID: 59962 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4(GClass2865 currentOperation)
		{
			throw null;
		}

		// Token: 0x0600EA3B RID: 59963 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5(Class82<GClass2865, bool> x)
		{
			throw null;
		}

		// Token: 0x0600EA3C RID: 59964 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6(bool search)
		{
			throw null;
		}

		// Token: 0x0400EE8E RID: 61070
		[SerializeField]
		private SearchButton _searchButton;

		// Token: 0x0400EE8F RID: 61071
		[SerializeField]
		private TimerText _searchTimer;

		// Token: 0x0400EE90 RID: 61072
		[SerializeField]
		private Button _unsearchedPanel;

		// Token: 0x0400EE91 RID: 61073
		[SerializeField]
		private GameObject _unsearchedButtonLoader;

		// Token: 0x0400EE92 RID: 61074
		private InventoryControllerClass gclass2757_0;

		// Token: 0x0400EE93 RID: 61075
		private bool bool_0;

		// Token: 0x0400EE94 RID: 61076
		private SearchableItemClass gclass2676_0;

		// Token: 0x0400EE95 RID: 61077
		private Action action_0;

		// Token: 0x0400EE96 RID: 61078
		private readonly GClass763 gclass763_0;

		// Token: 0x0400EE97 RID: 61079
		private readonly BindableState<GClass2865> gclass3370_0;

		// Token: 0x0400EE98 RID: 61080
		private readonly BindableState<bool> gclass3370_1;

		// Token: 0x02002E52 RID: 11858
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2896
		{
			// Token: 0x0600EA3D RID: 59965 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(GClass2865 operation, SearchedState state)
			{
				throw null;
			}

			// Token: 0x0600EA3E RID: 59966 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Class82<GClass2865, bool> method_1(GClass2865 currentOperation, bool canStartNewOperation)
			{
				throw null;
			}

			// Token: 0x0400EE99 RID: 61081
			public static readonly SearchableView.Class2896 class2896_0;

			// Token: 0x0400EE9A RID: 61082
			public static Func<GClass2865, SearchedState, bool> func_0;

			// Token: 0x0400EE9B RID: 61083
			public static Func<GClass2865, bool, Class82<GClass2865, bool>> func_1;
		}
	}
}
