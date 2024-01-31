using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EFT.InputSystem;
using EFT.UI;
using EFT.UI.Screens;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.Hideout
{
	// Token: 0x02001B5D RID: 7005
	public sealed class AreaScreenSubstrate : UIScreen
	{
		// Token: 0x140001BB RID: 443
		// (add) Token: 0x060093A7 RID: 37799 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060093A8 RID: 37800 RVA: 0x00002050 File Offset: 0x00000250
		private event Action Event_0
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x060093A9 RID: 37801 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x060093AA RID: 37802 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(InventoryControllerClass inventoryController, ISession session, Action<AreaData> onButtonClicked, Action onClosed)
		{
			throw null;
		}

		// Token: 0x060093AB RID: 37803 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SelectArea(AreaData areaData)
		{
			throw null;
		}

		// Token: 0x060093AC RID: 37804 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x060093AD RID: 37805 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private ELevelType method_3()
		{
			throw null;
		}

		// Token: 0x060093AE RID: 37806 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x060093AF RID: 37807 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5()
		{
			throw null;
		}

		// Token: 0x060093B0 RID: 37808 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6(ELevelType state, bool force)
		{
			throw null;
		}

		// Token: 0x060093B1 RID: 37809 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_7(GClass3076<RelatedData, GInterface171> viewList, ELevelType levelType)
		{
			throw null;
		}

		// Token: 0x060093B2 RID: 37810 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnEnable()
		{
			throw null;
		}

		// Token: 0x060093B3 RID: 37811 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_8()
		{
			throw null;
		}

		// Token: 0x060093B4 RID: 37812 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Dictionary<EPanelType, RelatedData> method_9(Stage stage, ELevelType levelType)
		{
			throw null;
		}

		// Token: 0x060093B5 RID: 37813 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_10(EPanelType panelType, ELevelType levelType)
		{
			throw null;
		}

		// Token: 0x060093B6 RID: 37814 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private GInterface171 method_11(RelatedData data)
		{
			throw null;
		}

		// Token: 0x060093B7 RID: 37815 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override InputNode.ETranslateResult TranslateCommand(ECommand command)
		{
			throw null;
		}

		// Token: 0x060093B8 RID: 37816 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_12()
		{
			throw null;
		}

		// Token: 0x060093B9 RID: 37817 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x060093BA RID: 37818 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_13()
		{
			throw null;
		}

		// Token: 0x060093BB RID: 37819 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_14()
		{
			throw null;
		}

		// Token: 0x060093BC RID: 37820 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_15()
		{
			throw null;
		}

		// Token: 0x04009A27 RID: 39463
		public const float FADE_DELAY = 0.3f;

		// Token: 0x04009A28 RID: 39464
		public const float CONTENT_HEIGHT_DELTA = 80f;

		// Token: 0x04009A29 RID: 39465
		[SerializeField]
		private float _maxHeight;

		// Token: 0x04009A2A RID: 39466
		[SerializeField]
		private AreaSubstrateSettings _areaSubstrateSettings;

		// Token: 0x04009A2B RID: 39467
		[SerializeField]
		private RectTransform _nextStageContainer;

		// Token: 0x04009A2C RID: 39468
		[SerializeField]
		private CanvasGroup _nextStageGroup;

		// Token: 0x04009A2D RID: 39469
		[SerializeField]
		private RectTransform _currentStageContainer;

		// Token: 0x04009A2E RID: 39470
		[SerializeField]
		private CanvasGroup _currentStageGroup;

		// Token: 0x04009A2F RID: 39471
		[SerializeField]
		private DefaultUIButton _nextLevelButton;

		// Token: 0x04009A30 RID: 39472
		[SerializeField]
		private DefaultUIButton _currentLevelButton;

		// Token: 0x04009A31 RID: 39473
		[SerializeField]
		private AreaPanel _areaPanel;

		// Token: 0x04009A32 RID: 39474
		[SerializeField]
		private Button _closeButton;

		// Token: 0x04009A33 RID: 39475
		[SerializeField]
		private AreaPanelSettings _areaPanelSettings;

		// Token: 0x04009A34 RID: 39476
		[SerializeField]
		private Image _areaStatusImage;

		// Token: 0x04009A35 RID: 39477
		[SerializeField]
		private CanvasGroup _buttonCanvasGroup;

		// Token: 0x04009A36 RID: 39478
		[SerializeField]
		private DefaultUIButton _actionButton;

		// Token: 0x04009A37 RID: 39479
		[SerializeField]
		private AreaDetails _areaDetailsPanel;

		// Token: 0x04009A38 RID: 39480
		[SerializeField]
		private LayoutElement _contentLayout;

		// Token: 0x04009A39 RID: 39481
		private Action<AreaData> action_0;

		// Token: 0x04009A3A RID: 39482
		private Action action_1;

		// Token: 0x04009A3B RID: 39483
		private AreaData areaData_0;

		// Token: 0x04009A3C RID: 39484
		private AreaData areaData_1;

		// Token: 0x04009A3D RID: 39485
		private int int_0;

		// Token: 0x04009A3E RID: 39486
		private InventoryControllerClass gclass2757_0;

		// Token: 0x04009A3F RID: 39487
		private ISession ginterface145_0;

		// Token: 0x04009A40 RID: 39488
		private GClass3076<RelatedData, GInterface171> gclass3076_0;

		// Token: 0x04009A41 RID: 39489
		private GClass3076<RelatedData, GInterface171> gclass3076_1;

		// Token: 0x04009A42 RID: 39490
		private ELevelType elevelType_0;

		// Token: 0x04009A43 RID: 39491
		private bool bool_0;

		// Token: 0x04009A44 RID: 39492
		private bool bool_1;

		// Token: 0x04009A45 RID: 39493
		private GClass764 gclass764_0;

		// Token: 0x04009A46 RID: 39494
		[CompilerGenerated]
		private Action action_2;

		// Token: 0x02001B5E RID: 7006
		[CompilerGenerated]
		private sealed class Class1654
		{
			// Token: 0x060093BD RID: 37821 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x04009A47 RID: 39495
			public GClass1912 producer;

			// Token: 0x04009A48 RID: 39496
			public AreaScreenSubstrate areaScreenSubstrate_0;
		}

		// Token: 0x02001B5F RID: 7007
		[CompilerGenerated]
		private sealed class Class1655
		{
			// Token: 0x060093BE RID: 37822 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x04009A49 RID: 39497
			public AreaScreenSubstrate areaScreenSubstrate_0;

			// Token: 0x04009A4A RID: 39498
			public ELevelType state;

			// Token: 0x04009A4B RID: 39499
			public CanvasGroup oldStageGroup;
		}

		// Token: 0x02001B60 RID: 7008
		[CompilerGenerated]
		private sealed class Class1656
		{
			// Token: 0x060093BF RID: 37823 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x060093C0 RID: 37824 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Transform method_1(RelatedData arg)
			{
				throw null;
			}

			// Token: 0x060093C1 RID: 37825 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_2(RelatedData item, GInterface171 view)
			{
				throw null;
			}

			// Token: 0x060093C2 RID: 37826 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_3()
			{
				throw null;
			}

			// Token: 0x04009A4C RID: 39500
			public AreaScreenSubstrate areaScreenSubstrate_0;

			// Token: 0x04009A4D RID: 39501
			public bool stateChanged;

			// Token: 0x04009A4E RID: 39502
			public RectTransform container;

			// Token: 0x04009A4F RID: 39503
			public List<Task> showTasks;

			// Token: 0x04009A50 RID: 39504
			public Stage stage;

			// Token: 0x04009A51 RID: 39505
			public ELevelType levelType;
		}

		// Token: 0x02001B63 RID: 7011
		[CompilerGenerated]
		private sealed class Class1657
		{
			// Token: 0x060093C7 RID: 37831 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(KeyValuePair<EPanelType, RelatedData> x)
			{
				throw null;
			}

			// Token: 0x04009A5F RID: 39519
			public AreaScreenSubstrate areaScreenSubstrate_0;

			// Token: 0x04009A60 RID: 39520
			public ELevelType levelType;
		}

		// Token: 0x02001B64 RID: 7012
		[CompilerGenerated]
		[Serializable]
		private sealed class Class1658
		{
			// Token: 0x060093C8 RID: 37832 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal EPanelType method_0(KeyValuePair<EPanelType, Func<RelatedData>> kvp)
			{
				throw null;
			}

			// Token: 0x060093C9 RID: 37833 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal RelatedData method_1(KeyValuePair<EPanelType, Func<RelatedData>> kvp)
			{
				throw null;
			}

			// Token: 0x060093CA RID: 37834 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_2(KeyValuePair<EPanelType, RelatedData> x)
			{
				throw null;
			}

			// Token: 0x060093CB RID: 37835 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_3(KeyValuePair<EPanelType, RelatedData> x)
			{
				throw null;
			}

			// Token: 0x060093CC RID: 37836 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal EPanelType method_4(KeyValuePair<EPanelType, RelatedData> x)
			{
				throw null;
			}

			// Token: 0x060093CD RID: 37837 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal RelatedData method_5(KeyValuePair<EPanelType, RelatedData> x)
			{
				throw null;
			}

			// Token: 0x04009A61 RID: 39521
			public static readonly AreaScreenSubstrate.Class1658 class1658_0;

			// Token: 0x04009A62 RID: 39522
			public static Func<KeyValuePair<EPanelType, Func<RelatedData>>, EPanelType> func_0;

			// Token: 0x04009A63 RID: 39523
			public static Func<KeyValuePair<EPanelType, Func<RelatedData>>, RelatedData> func_1;

			// Token: 0x04009A64 RID: 39524
			public static Func<KeyValuePair<EPanelType, RelatedData>, bool> func_2;

			// Token: 0x04009A65 RID: 39525
			public static Func<KeyValuePair<EPanelType, RelatedData>, bool> func_3;

			// Token: 0x04009A66 RID: 39526
			public static Func<KeyValuePair<EPanelType, RelatedData>, EPanelType> func_4;

			// Token: 0x04009A67 RID: 39527
			public static Func<KeyValuePair<EPanelType, RelatedData>, RelatedData> func_5;
		}
	}
}
