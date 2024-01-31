using System;
using System.Runtime.CompilerServices;
using EFT.UI;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.ProfileEditor.UI
{
	// Token: 0x02001DAA RID: 7594
	public sealed class ProfileEditorRightPanel : UIElement, IDisposable, GInterface367
	{
		// Token: 0x06009C76 RID: 40054 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x06009C77 RID: 40055 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(string text)
		{
			throw null;
		}

		// Token: 0x06009C78 RID: 40056 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Configure(Action<LootItemClass> configureStashPanel, ItemFactory itemFactory, LootItemClass[] lootItems)
		{
			throw null;
		}

		// Token: 0x06009C79 RID: 40057 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(InventoryControllerClass leftSideInventoryController = null, ItemsPanel.EItemsTab tab = ItemsPanel.EItemsTab.Gear)
		{
			throw null;
		}

		// Token: 0x06009C7A RID: 40058 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x06009C7B RID: 40059 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(LootItemClass lootItem)
		{
			throw null;
		}

		// Token: 0x06009C7C RID: 40060 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x06009C7D RID: 40061 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x06009C7E RID: 40062 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x06009C7F RID: 40063 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5(int step)
		{
			throw null;
		}

		// Token: 0x06009C80 RID: 40064 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6(LootItemClass lootItem)
		{
			throw null;
		}

		// Token: 0x06009C81 RID: 40065 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0400A3BE RID: 41918
		[SerializeField]
		private SimpleStashPanel _simpleStash;

		// Token: 0x0400A3BF RID: 41919
		[SerializeField]
		private Button _nextButton;

		// Token: 0x0400A3C0 RID: 41920
		[SerializeField]
		private Button _prevButton;

		// Token: 0x0400A3C1 RID: 41921
		[SerializeField]
		private TMP_InputField _searchInput;

		// Token: 0x0400A3C2 RID: 41922
		[SerializeField]
		private GameObject _loader;

		// Token: 0x0400A3C3 RID: 41923
		private Action<LootItemClass> action_0;

		// Token: 0x0400A3C4 RID: 41924
		private ItemFactory gclass1483_0;

		// Token: 0x0400A3C5 RID: 41925
		private LootItemClass[] gclass2625_0;

		// Token: 0x0400A3C6 RID: 41926
		private int int_0;

		// Token: 0x0400A3C7 RID: 41927
		private GClass2094 gclass2094_0;
	}
}
