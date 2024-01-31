using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EFT.InputSystem;
using EFT.UI;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace EFT.Hideout
{
	// Token: 0x02001B69 RID: 7017
	public sealed class AreasPanel : UIInputNode, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		// Token: 0x060093D6 RID: 37846 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x060093D7 RID: 37847 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(AreaData[] areas, Action<AreaPanel> onSelected)
		{
			throw null;
		}

		// Token: 0x060093D8 RID: 37848 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(int direction)
		{
			throw null;
		}

		// Token: 0x060093D9 RID: 37849 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SelectArea(AreaData area)
		{
			throw null;
		}

		// Token: 0x060093DA RID: 37850 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override InputNode.ETranslateResult TranslateCommand(ECommand command)
		{
			throw null;
		}

		// Token: 0x060093DB RID: 37851 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSelectedStatus(bool status)
		{
			throw null;
		}

		// Token: 0x060093DC RID: 37852 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(Vector2 scrollPosition)
		{
			throw null;
		}

		// Token: 0x060093DD RID: 37853 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnStartDrag()
		{
			throw null;
		}

		// Token: 0x060093DE RID: 37854 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerEnter(PointerEventData data)
		{
			throw null;
		}

		// Token: 0x060093DF RID: 37855 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerExit(PointerEventData data)
		{
			throw null;
		}

		// Token: 0x060093E0 RID: 37856 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void TranslateAxes(ref float[] axes)
		{
			throw null;
		}

		// Token: 0x060093E1 RID: 37857 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override ECursorResult ShouldLockCursor()
		{
			throw null;
		}

		// Token: 0x060093E2 RID: 37858 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_2(AreaPanel panel)
		{
			throw null;
		}

		// Token: 0x060093E3 RID: 37859 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private float method_3(float normalizedPosition)
		{
			throw null;
		}

		// Token: 0x060093E4 RID: 37860 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4(float normalizedPosition)
		{
			throw null;
		}

		// Token: 0x060093E5 RID: 37861 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5()
		{
			throw null;
		}

		// Token: 0x060093E6 RID: 37862 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6()
		{
			throw null;
		}

		// Token: 0x060093E7 RID: 37863 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7()
		{
			throw null;
		}

		// Token: 0x060093E8 RID: 37864 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_8()
		{
			throw null;
		}

		// Token: 0x060093E9 RID: 37865 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_9()
		{
			throw null;
		}

		// Token: 0x04009A81 RID: 39553
		private const float float_0 = 200f;

		// Token: 0x04009A82 RID: 39554
		private const float float_1 = 0.5f;

		// Token: 0x04009A83 RID: 39555
		private const float float_2 = 120f;

		// Token: 0x04009A84 RID: 39556
		private const float float_3 = 0.3f;

		// Token: 0x04009A85 RID: 39557
		[SerializeField]
		private AreaPanel _areaPanelTemplate;

		// Token: 0x04009A86 RID: 39558
		[SerializeField]
		private RectTransform _areaPanelsContainer;

		// Token: 0x04009A87 RID: 39559
		[SerializeField]
		private AreasScrollRect _scrollView;

		// Token: 0x04009A88 RID: 39560
		[SerializeField]
		private Button _leftButton;

		// Token: 0x04009A89 RID: 39561
		[SerializeField]
		private Button _rightButton;

		// Token: 0x04009A8A RID: 39562
		private AreaData[] areaData_0;

		// Token: 0x04009A8B RID: 39563
		private GClass3079<AreaData, AreaPanel> gclass3079_0;

		// Token: 0x04009A8C RID: 39564
		private Action<AreaPanel> action_0;

		// Token: 0x04009A8D RID: 39565
		private AreaPanel areaPanel_0;

		// Token: 0x04009A8E RID: 39566
		private bool bool_0;

		// Token: 0x04009A8F RID: 39567
		private bool bool_1;

		// Token: 0x04009A90 RID: 39568
		private bool bool_2;

		// Token: 0x04009A91 RID: 39569
		private Vector2 vector2_0;

		// Token: 0x02001B6A RID: 7018
		private sealed class Class1659 : IComparer<AreaData>
		{
			// Token: 0x060093EA RID: 37866 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public int Compare(AreaData x, AreaData y)
			{
				throw null;
			}

			// Token: 0x04009A92 RID: 39570
			private static readonly Dictionary<EAreaStatus, int> dictionary_0;

			// Token: 0x04009A93 RID: 39571
			public static readonly AreasPanel.Class1659 Instance;
		}

		// Token: 0x02001B6B RID: 7019
		[CompilerGenerated]
		private sealed class Class1660
		{
			// Token: 0x060093EB RID: 37867 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(AreaData item, AreaPanel view)
			{
				throw null;
			}

			// Token: 0x060093EC RID: 37868 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1()
			{
				throw null;
			}

			// Token: 0x060093ED RID: 37869 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_2()
			{
				throw null;
			}

			// Token: 0x04009A94 RID: 39572
			public Action<AreaPanel> onSelected;

			// Token: 0x04009A95 RID: 39573
			public AreasPanel areasPanel_0;
		}

		// Token: 0x02001B6E RID: 7022
		[CompilerGenerated]
		[Serializable]
		private sealed class Class1661
		{
			// Token: 0x060093F2 RID: 37874 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal AreaData method_0(AreaData x)
			{
				throw null;
			}

			// Token: 0x04009AA2 RID: 39586
			public static readonly AreasPanel.Class1661 class1661_0;

			// Token: 0x04009AA3 RID: 39587
			public static Func<AreaData, AreaData> func_0;
		}
	}
}
