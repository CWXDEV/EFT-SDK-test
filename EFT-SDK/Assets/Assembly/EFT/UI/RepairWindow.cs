using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EFT.InventoryLogic;
using EFT.UI.WeaponModding;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace EFT.UI
{
	// Token: 0x02002A0C RID: 10764
	public sealed class RepairWindow : Window<GClass3085>, IEventSystemHandler, IPointerClickHandler
	{
		// Token: 0x170025F4 RID: 9716
		// (get) Token: 0x0600D5F3 RID: 54771 RVA: 0x00002050 File Offset: 0x00000250
		private bool Boolean_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600D5F4 RID: 54772 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Awake()
		{
			throw null;
		}

		// Token: 0x0600D5F5 RID: 54773 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(GClass2087 repairController, GClass2809 itemContext, Inventory inventory, MessageWindow messageWindow, GInterface313 itemController, IEnumerable<TraderClass> repairers, SkillManager skills, Action onSelectedAction, WeaponPreviewPool weaponPreviewPool, Action onClosedAction)
		{
			throw null;
		}

		// Token: 0x0600D5F6 RID: 54774 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private GInterface33 method_2(Item item, GClass2087 repairController)
		{
			throw null;
		}

		// Token: 0x0600D5F7 RID: 54775 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(ERepairStatusWarning? status)
		{
			throw null;
		}

		// Token: 0x0600D5F8 RID: 54776 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x0600D5F9 RID: 54777 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_5()
		{
			throw null;
		}

		// Token: 0x0600D5FA RID: 54778 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerClick([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600D5FC RID: 54780 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600D5FD RID: 54781 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6()
		{
			throw null;
		}

		// Token: 0x0400D823 RID: 55331
		[SerializeField]
		private TextMeshProUGUI _masteringLabel;

		// Token: 0x0400D824 RID: 55332
		[SerializeField]
		private RepairerParametersPanel _repairerParameters;

		// Token: 0x0400D825 RID: 55333
		[SerializeField]
		private RepairWarningStatusPanel _repairWarningStatusPanel;

		// Token: 0x0400D826 RID: 55334
		[SerializeField]
		private ItemInfoWindowLabels _itemLabels;

		// Token: 0x0400D827 RID: 55335
		[SerializeField]
		private CameraImage _cameraImage;

		// Token: 0x0400D828 RID: 55336
		[SerializeField]
		private DefaultUIButton _repairButton;

		// Token: 0x0400D829 RID: 55337
		[SerializeField]
		private GameObject _repairProcess;

		// Token: 0x0400D82A RID: 55338
		[SerializeField]
		private GameObject _loader;

		// Token: 0x0400D82B RID: 55339
		private WeaponPreview weaponPreview_0;

		// Token: 0x0400D82C RID: 55340
		private Item item_0;

		// Token: 0x0400D82D RID: 55341
		private GInterface33 ginterface33_0;

		// Token: 0x0400D82E RID: 55342
		private GClass2809 gclass2809_0;

		// Token: 0x0400D82F RID: 55343
		private GInterface313 ginterface313_0;

		// Token: 0x0400D830 RID: 55344
		private Action action_1;

		// Token: 0x0400D831 RID: 55345
		private GClass2884 gclass2884_0;

		// Token: 0x0400D832 RID: 55346
		private WeaponPreviewPool weaponPreviewPool_0;

		// Token: 0x0400D833 RID: 55347
		private MessageWindow messageWindow_0;

		// Token: 0x0400D834 RID: 55348
		private bool bool_0;

		// Token: 0x0400D835 RID: 55349
		private GClass2087 gclass2087_0;

		// Token: 0x0400D836 RID: 55350
		private GClass2726 gclass2726_0;

		// Token: 0x02002A0D RID: 10765
		[CompilerGenerated]
		private sealed class Class2481
		{
			// Token: 0x0600D5FE RID: 54782 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0600D5FF RID: 54783 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1()
			{
				throw null;
			}

			// Token: 0x0600D600 RID: 54784 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_2()
			{
				throw null;
			}

			// Token: 0x0400D837 RID: 55351
			public RepairWindow repairWindow_0;

			// Token: 0x0400D838 RID: 55352
			public IItemOwner itemOwner;
		}

		// Token: 0x02002A0E RID: 10766
		[CompilerGenerated]
		private sealed class Class2482
		{
			// Token: 0x0600D601 RID: 54785 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal float method_0()
			{
				throw null;
			}

			// Token: 0x0400D839 RID: 55353
			public GClass1764 mastered;

			// Token: 0x0400D83A RID: 55354
			public RepairWindow.Class2481 class2481_0;
		}

		// Token: 0x02002A0F RID: 10767
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2483
		{
			// Token: 0x0600D602 RID: 54786 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_0(string x)
			{
				throw null;
			}

			// Token: 0x0400D83B RID: 55355
			public static readonly RepairWindow.Class2483 class2483_0;

			// Token: 0x0400D83C RID: 55356
			public static Func<string, string> func_0;
		}
	}
}
