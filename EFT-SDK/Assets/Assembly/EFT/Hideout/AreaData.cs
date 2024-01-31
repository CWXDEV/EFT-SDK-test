using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cinemachine;
using Diz.Binding;
using EFT.InventoryLogic;
using UnityEngine;

namespace EFT.Hideout
{
	// Token: 0x02001B4A RID: 6986
	public sealed class AreaData
	{
		// Token: 0x1700167D RID: 5757
		// (get) Token: 0x06009329 RID: 37673 RVA: 0x00002050 File Offset: 0x00000250
		public AreaTemplate Template
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700167E RID: 5758
		// (get) Token: 0x0600932A RID: 37674 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600932B RID: 37675 RVA: 0x00002050 File Offset: 0x00000250
		public Transform AreaIconPoint
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

		// Token: 0x1700167F RID: 5759
		// (get) Token: 0x0600932C RID: 37676 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600932D RID: 37677 RVA: 0x00002050 File Offset: 0x00000250
		public CinemachineVirtualCamera AreaCamera
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

		// Token: 0x17001680 RID: 5760
		// (get) Token: 0x0600932E RID: 37678 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600932F RID: 37679 RVA: 0x00002050 File Offset: 0x00000250
		public CinemachineVirtualCamera SpecialActionCamera
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

		// Token: 0x17001681 RID: 5761
		// (get) Token: 0x06009330 RID: 37680 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06009331 RID: 37681 RVA: 0x00002050 File Offset: 0x00000250
		public bool Selected
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

		// Token: 0x17001682 RID: 5762
		// (get) Token: 0x06009332 RID: 37682 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06009333 RID: 37683 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsActive
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

		// Token: 0x17001683 RID: 5763
		// (get) Token: 0x06009334 RID: 37684 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06009335 RID: 37685 RVA: 0x00002050 File Offset: 0x00000250
		public bool HasActiveProduction
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

		// Token: 0x17001684 RID: 5764
		// (get) Token: 0x06009336 RID: 37686 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06009337 RID: 37687 RVA: 0x00002050 File Offset: 0x00000250
		public AreaData ParentAreaData
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

		// Token: 0x17001685 RID: 5765
		// (get) Token: 0x06009338 RID: 37688 RVA: 0x00002050 File Offset: 0x00000250
		public IReadOnlyList<AreaData> ChildAreasData
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001686 RID: 5766
		// (get) Token: 0x06009339 RID: 37689 RVA: 0x00002050 File Offset: 0x00000250
		public Transform HighlightTransform
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001687 RID: 5767
		// (get) Token: 0x0600933A RID: 37690 RVA: 0x00002050 File Offset: 0x00000250
		public Color HighlightColor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001688 RID: 5768
		// (get) Token: 0x0600933B RID: 37691 RVA: 0x00002050 File Offset: 0x00000250
		public Stage CurrentStage
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001689 RID: 5769
		// (get) Token: 0x0600933C RID: 37692 RVA: 0x00002050 File Offset: 0x00000250
		public Stage NextStage
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700168A RID: 5770
		// (get) Token: 0x0600933D RID: 37693 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsVisible
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700168B RID: 5771
		// (get) Token: 0x0600933E RID: 37694 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600933F RID: 37695 RVA: 0x00002050 File Offset: 0x00000250
		public int CurrentLevel
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x1700168C RID: 5772
		// (get) Token: 0x06009340 RID: 37696 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06009341 RID: 37697 RVA: 0x00002050 File Offset: 0x00000250
		public EAreaStatus Status
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x1700168D RID: 5773
		// (get) Token: 0x06009342 RID: 37698 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsInstalled
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700168E RID: 5774
		// (get) Token: 0x06009343 RID: 37699 RVA: 0x00002050 File Offset: 0x00000250
		public bool ReadyForAction
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700168F RID: 5775
		// (get) Token: 0x06009344 RID: 37700 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06009345 RID: 37701 RVA: 0x00002050 File Offset: 0x00000250
		public ELightStatus LightStatus
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17001690 RID: 5776
		// (get) Token: 0x06009346 RID: 37702 RVA: 0x00002050 File Offset: 0x00000250
		private TimeSpan TimeSpan_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001691 RID: 5777
		// (get) Token: 0x06009347 RID: 37703 RVA: 0x00002050 File Offset: 0x00000250
		public string TimeLeftFormatted
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001692 RID: 5778
		// (get) Token: 0x06009348 RID: 37704 RVA: 0x00002050 File Offset: 0x00000250
		public ValueTuple<EButtonDisplayStatus, string> ActionButtonStatus
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06009349 RID: 37705 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetProductionState(bool active)
		{
			throw null;
		}

		// Token: 0x17001693 RID: 5779
		// (get) Token: 0x0600934A RID: 37706 RVA: 0x00002050 File Offset: 0x00000250
		public bool DisplayOutOfFuelIcon
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001694 RID: 5780
		// (get) Token: 0x0600934B RID: 37707 RVA: 0x00002050 File Offset: 0x00000250
		public bool DisplayInterface
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001695 RID: 5781
		// (get) Token: 0x0600934C RID: 37708 RVA: 0x00002050 File Offset: 0x00000250
		public bool DisplayLevel
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001696 RID: 5782
		// (get) Token: 0x0600934D RID: 37709 RVA: 0x00002050 File Offset: 0x00000250
		public bool DisplayNotification
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001697 RID: 5783
		// (get) Token: 0x0600934E RID: 37710 RVA: 0x00002050 File Offset: 0x00000250
		public RelatedRequirements Requirements
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001698 RID: 5784
		// (get) Token: 0x0600934F RID: 37711 RVA: 0x00002050 File Offset: 0x00000250
		public bool Enabled
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001699 RID: 5785
		// (get) Token: 0x06009350 RID: 37712 RVA: 0x00002050 File Offset: 0x00000250
		public string ParentAreaId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06009351 RID: 37713 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitArea(HideoutArea area)
		{
			throw null;
		}

		// Token: 0x06009352 RID: 37714 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Stage StageAt(int level)
		{
			throw null;
		}

		// Token: 0x06009353 RID: 37715 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitProfileData(AreaInfo areaInfo, InventoryControllerClass inventoryController, ISession session)
		{
			throw null;
		}

		// Token: 0x06009354 RID: 37716 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ReleaseSubscriptions()
		{
			throw null;
		}

		// Token: 0x06009355 RID: 37717 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_0(int timestamp)
		{
			throw null;
		}

		// Token: 0x06009356 RID: 37718 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task UpgradeAction()
		{
			throw null;
		}

		// Token: 0x06009357 RID: 37719 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_1()
		{
			throw null;
		}

		// Token: 0x06009358 RID: 37720 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x06009359 RID: 37721 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(int level)
		{
			throw null;
		}

		// Token: 0x0600935A RID: 37722 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x0600935B RID: 37723 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetProductionSchemes(IEnumerable<GClass1919> productionSchemes)
		{
			throw null;
		}

		// Token: 0x0600935C RID: 37724 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DecideStatus(int levelToSet)
		{
			throw null;
		}

		// Token: 0x0600935D RID: 37725 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_5(int level)
		{
			throw null;
		}

		// Token: 0x0600935E RID: 37726 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_6(Stage stage)
		{
			throw null;
		}

		// Token: 0x0600935F RID: 37727 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Hover(bool value)
		{
			throw null;
		}

		// Token: 0x06009360 RID: 37728 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x06009361 RID: 37729 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSelectedStatus(bool isSelected)
		{
			throw null;
		}

		// Token: 0x06009362 RID: 37730 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetProducedItemsHandler(Item[] items, GClass1918 _)
		{
			throw null;
		}

		// Token: 0x06009363 RID: 37731 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GetProducedItemsHandler(IEnumerable<Item> items)
		{
			throw null;
		}

		// Token: 0x06009364 RID: 37732 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AttachVideoCard(int count)
		{
			throw null;
		}

		// Token: 0x06009365 RID: 37733 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DetachVideoCard()
		{
			throw null;
		}

		// Token: 0x06009366 RID: 37734 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetImprovements()
		{
			throw null;
		}

		// Token: 0x06009367 RID: 37735 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CheckVisibility()
		{
			throw null;
		}

		// Token: 0x06009368 RID: 37736 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddChildArea(AreaData areaData)
		{
			throw null;
		}

		// Token: 0x040099BB RID: 39355
		private const string CONSTRUCT_LABEL = "CONSTRUCT";

		// Token: 0x040099BC RID: 39356
		private const string CONSTRUCTING_LABEL = "CONSTRUCTING";

		// Token: 0x040099BD RID: 39357
		private const string INSTALL_LABEL = "INSTALL";

		// Token: 0x040099BE RID: 39358
		private const string UPGRADE_LABEL = "UPGRADE";

		// Token: 0x040099BF RID: 39359
		private const string UPGRADING_LABEL = "UPGRADING";

		// Token: 0x040099C0 RID: 39360
		private const int AREA_CAMERA_PRIORITY = 100;

		// Token: 0x040099C9 RID: 39369
		public readonly BindableEvent LevelUpdated;

		// Token: 0x040099CA RID: 39370
		public readonly BindableEvent StatusUpdated;

		// Token: 0x040099CB RID: 39371
		public readonly BindableEvent AreaUpgraded;

		// Token: 0x040099CC RID: 39372
		public readonly BindableEvent RecalculateAreas;

		// Token: 0x040099CD RID: 39373
		public readonly GClass3355<ELightStatus> LightStatusChanged;

		// Token: 0x040099CE RID: 39374
		public readonly GClass3355<bool> ProductionStateChanged;

		// Token: 0x040099CF RID: 39375
		public readonly BindableEvent ImprovementsUpdated;

		// Token: 0x040099D0 RID: 39376
		public readonly GClass3355<bool> OnHover;

		// Token: 0x040099D1 RID: 39377
		public readonly GClass3355<bool> OnSelected;

		// Token: 0x040099D2 RID: 39378
		public readonly BindableEvent IconStatusUpdated;

		// Token: 0x040099D3 RID: 39379
		public readonly GClass3355<bool> VisibilityChanged;

		// Token: 0x040099D4 RID: 39380
		private HideoutArea _hideoutArea;

		// Token: 0x040099D5 RID: 39381
		private int _actionGoingStatus;

		// Token: 0x040099D6 RID: 39382
		private bool _isVisible;

		// Token: 0x040099D7 RID: 39383
		private int _currentLevel;

		// Token: 0x040099D8 RID: 39384
		private readonly List<AreaData> _childAreasData;

		// Token: 0x040099D9 RID: 39385
		private EAreaStatus _status;

		// Token: 0x040099DA RID: 39386
		private ELightStatus _lightStatus;

		// Token: 0x02001B4E RID: 6990
		[CompilerGenerated]
		private sealed class Class1649
		{
			// Token: 0x040099EC RID: 39404
			public EAreaType areaType;
		}

		// Token: 0x02001B4F RID: 6991
		[CompilerGenerated]
		private sealed class Class1650
		{
			// Token: 0x0600936F RID: 37743 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(GClass1919 scheme)
			{
				throw null;
			}

			// Token: 0x06009370 RID: 37744 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_1(Requirement requirement)
			{
				throw null;
			}

			// Token: 0x040099ED RID: 39405
			public int level;

			// Token: 0x040099EE RID: 39406
			public AreaData.Class1649 class1649_0;

			// Token: 0x040099EF RID: 39407
			public Func<Requirement, bool> func_0;
		}

		// Token: 0x02001B50 RID: 6992
		[CompilerGenerated]
		[Serializable]
		private sealed class Class1651
		{
			// Token: 0x06009371 RID: 37745 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(Requirement requirement)
			{
				throw null;
			}

			// Token: 0x06009372 RID: 37746 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_1(Requirement requirement)
			{
				throw null;
			}

			// Token: 0x040099F0 RID: 39408
			public static readonly AreaData.Class1651 class1651_0;

			// Token: 0x040099F1 RID: 39409
			public static Func<Requirement, bool> func_0;

			// Token: 0x040099F2 RID: 39410
			public static Func<Requirement, bool> func_1;
		}
	}
}
