using System;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI.DragAndDrop
{
	// Token: 0x02002DF4 RID: 11764
	[UsedImplicitly]
	public sealed class ComplexStashPanel : UIElement, IDisposable, GInterface367
	{
		// Token: 0x0600E763 RID: 59235 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Configure(InventoryControllerClass inventoryController, GClass2809 equipmentContext, EquipmentClass equipment, SkillManager skills, InsuranceCompanyClass insurance, ItemUiContext itemUiContext)
		{
			throw null;
		}

		// Token: 0x0600E764 RID: 59236 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(InventoryControllerClass leftSideInventoryController = null, ItemsPanel.EItemsTab tab = ItemsPanel.EItemsTab.Gear)
		{
			throw null;
		}

		// Token: 0x0600E765 RID: 59237 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600E766 RID: 59238 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UnConfigure()
		{
			throw null;
		}

		// Token: 0x0600E767 RID: 59239 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0400ECA3 RID: 60579
		[SerializeField]
		private Image _gridIcon;

		// Token: 0x0400ECA4 RID: 60580
		[SerializeField]
		private TMP_Text _complexGridName;

		// Token: 0x0400ECA5 RID: 60581
		[SerializeField]
		private Transform _lootPanel;

		// Token: 0x0400ECA6 RID: 60582
		[SerializeField]
		private ContainersPanel _containersPanel;

		// Token: 0x0400ECA7 RID: 60583
		[SerializeField]
		private EquipmentTab _equipmentPanelSource;

		// Token: 0x0400ECA8 RID: 60584
		[SerializeField]
		private GameObject _complexPanel;

		// Token: 0x0400ECA9 RID: 60585
		[SerializeField]
		private GameObject _containerNamePanel;

		// Token: 0x0400ECAA RID: 60586
		[SerializeField]
		private TMP_Text _containerName;

		// Token: 0x0400ECAB RID: 60587
		private EquipmentTab equipmentTab_0;

		// Token: 0x0400ECAC RID: 60588
		private InventoryControllerClass gclass2757_0;

		// Token: 0x0400ECAD RID: 60589
		private EquipmentClass gclass2697_0;

		// Token: 0x0400ECAE RID: 60590
		private ItemUiContext itemUiContext_0;

		// Token: 0x0400ECAF RID: 60591
		private SkillManager skillManager_0;

		// Token: 0x0400ECB0 RID: 60592
		private InsuranceCompanyClass gclass3179_0;

		// Token: 0x0400ECB1 RID: 60593
		private GClass2809 gclass2809_0;
	}
}
