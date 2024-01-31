using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using EFT.InputSystem;
using EFT.InventoryLogic;
using EFT.UI.Screens;
using JetBrains.Annotations;
using Sirenix.Serialization;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002A7A RID: 10874
	public sealed class MenuTaskBar : UIInputNode, ISerializationCallbackReceiver, ISupportsPrefabSerialization
	{
		// Token: 0x140002F5 RID: 757
		// (add) Token: 0x0600D7FC RID: 55292 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600D7FD RID: 55293 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<EAreaType> OnHideoutCraftsButtonClick
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

		// Token: 0x140002F6 RID: 758
		// (add) Token: 0x0600D7FE RID: 55294 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600D7FF RID: 55295 RVA: 0x00002050 File Offset: 0x00000250
		internal event Action<EMenuType, bool> Event_0
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

		// Token: 0x17002644 RID: 9796
		// (get) Token: 0x0600D800 RID: 55296 RVA: 0x00002050 File Offset: 0x00000250
		public AnimatedToggle ChatToggle
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002645 RID: 9797
		// (get) Token: 0x0600D801 RID: 55297 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600D802 RID: 55298 RVA: 0x00002050 File Offset: 0x00000250
		private int Int32_0
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

		// Token: 0x17002646 RID: 9798
		// (get) Token: 0x0600D803 RID: 55299 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600D804 RID: 55300 RVA: 0x00002050 File Offset: 0x00000250
		private int Int32_1
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

		// Token: 0x17002647 RID: 9799
		// (set) Token: 0x0600D805 RID: 55301 RVA: 0x00002050 File Offset: 0x00000250
		public int FailedItemsCount
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17002648 RID: 9800
		// (get) Token: 0x0600D806 RID: 55302 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600D807 RID: 55303 RVA: 0x00002050 File Offset: 0x00000250
		public int ProducedItemsCount
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

		// Token: 0x0600D808 RID: 55304 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600D809 RID: 55305 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			throw null;
		}

		// Token: 0x0600D80A RID: 55306 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PreparingRaid()
		{
			throw null;
		}

		// Token: 0x0600D80B RID: 55307 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitSocial(GClass1839 social)
		{
			throw null;
		}

		// Token: 0x0600D80C RID: 55308 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitHandbook(GClass2881 handbook)
		{
			throw null;
		}

		// Token: 0x0600D80D RID: 55309 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitRagfair(RagFairClass ragfair)
		{
			throw null;
		}

		// Token: 0x0600D80E RID: 55310 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitBonusController(BonusController bonusController)
		{
			throw null;
		}

		// Token: 0x0600D80F RID: 55311 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitHideout(HideoutClass hideout)
		{
			throw null;
		}

		// Token: 0x0600D810 RID: 55312 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitGroupPanel(GClass3166 matchmakerPlayersController, GClass1839 socialNetwork)
		{
			throw null;
		}

		// Token: 0x0600D811 RID: 55313 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0600D812 RID: 55314 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x0600D813 RID: 55315 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetProducedItemsCount(ProductionControllerClass productionController)
		{
			throw null;
		}

		// Token: 0x0600D814 RID: 55316 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnScreenChanged(EEftScreenType eftScreenType)
		{
			throw null;
		}

		// Token: 0x0600D815 RID: 55317 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(GClass1912 producer)
		{
			throw null;
		}

		// Token: 0x0600D816 RID: 55318 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(GClass1912 producer)
		{
			throw null;
		}

		// Token: 0x0600D817 RID: 55319 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4(EAreaType areaType)
		{
			throw null;
		}

		// Token: 0x0600D818 RID: 55320 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5()
		{
			throw null;
		}

		// Token: 0x0600D819 RID: 55321 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6()
		{
			throw null;
		}

		// Token: 0x0600D81A RID: 55322 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7(bool isActive, EBonusType bonusType)
		{
			throw null;
		}

		// Token: 0x0600D81B RID: 55323 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_8()
		{
			throw null;
		}

		// Token: 0x0600D81C RID: 55324 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_9(KeyValuePair<GClass940, ChatMessageClass> pair)
		{
			throw null;
		}

		// Token: 0x0600D81D RID: 55325 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_10([CanBeNull] GClass940 dialogue)
		{
			throw null;
		}

		// Token: 0x0600D81E RID: 55326 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_11()
		{
			throw null;
		}

		// Token: 0x0600D81F RID: 55327 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_12(bool value)
		{
			throw null;
		}

		// Token: 0x0600D820 RID: 55328 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_13()
		{
			throw null;
		}

		// Token: 0x0600D821 RID: 55329 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetButtonsAvailable(bool available)
		{
			throw null;
		}

		// Token: 0x0600D822 RID: 55330 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_14()
		{
			throw null;
		}

		// Token: 0x0600D823 RID: 55331 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_15()
		{
			throw null;
		}

		// Token: 0x0600D824 RID: 55332 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_16(List<Action> disposableCollection)
		{
			throw null;
		}

		// Token: 0x0600D825 RID: 55333 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override InputNode.ETranslateResult TranslateCommand(ECommand command)
		{
			throw null;
		}

		// Token: 0x0600D826 RID: 55334 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void TranslateAxes(ref float[] axes)
		{
			throw null;
		}

		// Token: 0x0600D827 RID: 55335 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override ECursorResult ShouldLockCursor()
		{
			throw null;
		}

		// Token: 0x0600D828 RID: 55336 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x17002649 RID: 9801
		// (get) Token: 0x0600D829 RID: 55337 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600D82A RID: 55338 RVA: 0x00002050 File Offset: 0x00000250
		SerializationData ISupportsPrefabSerialization.SerializationData
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

		// Token: 0x0600D82B RID: 55339 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void ISerializationCallbackReceiver.OnAfterDeserialize()
		{
			throw null;
		}

		// Token: 0x0600D82C RID: 55340 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void ISerializationCallbackReceiver.OnBeforeSerialize()
		{
			throw null;
		}

		// Token: 0x0600D82D RID: 55341 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_17()
		{
			throw null;
		}

		// Token: 0x0600D82E RID: 55342 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_18(RagFairClass.ERagFairStatus status)
		{
			throw null;
		}

		// Token: 0x0600D82F RID: 55343 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_19()
		{
			throw null;
		}

		// Token: 0x0600D830 RID: 55344 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_20()
		{
			throw null;
		}

		// Token: 0x0600D831 RID: 55345 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_21()
		{
			throw null;
		}

		// Token: 0x0600D832 RID: 55346 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_22()
		{
			throw null;
		}

		// Token: 0x0400DAB9 RID: 55993
		private const string string_0 = "Not available in raid";

		// Token: 0x0400DABA RID: 55994
		[SerializeField]
		private GameObject _newInformation;

		// Token: 0x0400DABB RID: 55995
		[SerializeField]
		private Dictionary<EMenuType, HoverTooltipArea> _hoverTooltipAreas;

		// Token: 0x0400DABC RID: 55996
		[SerializeField]
		private Dictionary<EMenuType, AnimatedToggle> _toggleButtons;

		// Token: 0x0400DABD RID: 55997
		[SerializeField]
		private GameObject _failedItemsObject;

		// Token: 0x0400DABE RID: 55998
		[SerializeField]
		private CustomTextMeshProUGUI _failedItemsLabel;

		// Token: 0x0400DABF RID: 55999
		[SerializeField]
		private GameObject _producedItemsObject;

		// Token: 0x0400DAC0 RID: 56000
		[SerializeField]
		private Button _producedItemsButton;

		// Token: 0x0400DAC1 RID: 56001
		[SerializeField]
		private CustomTextMeshProUGUI _producedItemsLabel;

		// Token: 0x0400DAC2 RID: 56002
		[SerializeField]
		private GameObject _newMessagesObject;

		// Token: 0x0400DAC3 RID: 56003
		[SerializeField]
		private CustomTextMeshProUGUI _newMessagesLabel;

		// Token: 0x0400DAC4 RID: 56004
		[SerializeField]
		private GameObject _newAttachmentsMessagesObject;

		// Token: 0x0400DAC5 RID: 56005
		[SerializeField]
		private CustomTextMeshProUGUI _newAttachmentsMessagesLabel;

		// Token: 0x0400DAC6 RID: 56006
		[SerializeField]
		private GameObject _newFriendRequestsObject;

		// Token: 0x0400DAC7 RID: 56007
		[SerializeField]
		private CustomTextMeshProUGUI _newFriendsRequestsLabel;

		// Token: 0x0400DAC8 RID: 56008
		[SerializeField]
		private GameObject _newNodesObject;

		// Token: 0x0400DAC9 RID: 56009
		[SerializeField]
		private CustomTextMeshProUGUI _newNodesLabel;

		// Token: 0x0400DACA RID: 56010
		[SerializeField]
		private LocalizedText[] _labels;

		// Token: 0x0400DACB RID: 56011
		[SerializeField]
		private Button _readAllButton;

		// Token: 0x0400DACC RID: 56012
		[SerializeField]
		private GroupPanel _groupPanel;

		// Token: 0x0400DACD RID: 56013
		private readonly Dictionary<EEftScreenType, EMenuType> dictionary_0;

		// Token: 0x0400DACE RID: 56014
		[CompilerGenerated]
		private Action<EAreaType> action_0;

		// Token: 0x0400DACF RID: 56015
		[CompilerGenerated]
		private Action<EMenuType, bool> action_1;

		// Token: 0x0400DAD0 RID: 56016
		private GClass1839 gclass1839_0;

		// Token: 0x0400DAD1 RID: 56017
		private GClass2881 gclass2881_0;

		// Token: 0x0400DAD2 RID: 56018
		private RagFairClass gclass3190_0;

		// Token: 0x0400DAD3 RID: 56019
		private GClass3166 gclass3166_0;

		// Token: 0x0400DAD4 RID: 56020
		private ProductionControllerClass gclass1917_0;

		// Token: 0x0400DAD5 RID: 56021
		private readonly Dictionary<EAreaType, GClass1912> dictionary_1;

		// Token: 0x0400DAD6 RID: 56022
		private int int_0;

		// Token: 0x0400DAD7 RID: 56023
		private int int_1;

		// Token: 0x0400DAD8 RID: 56024
		private int int_2;

		// Token: 0x0400DAD9 RID: 56025
		private int int_3;

		// Token: 0x0400DADA RID: 56026
		private int int_4;

		// Token: 0x0400DADB RID: 56027
		private bool bool_0;

		// Token: 0x0400DADC RID: 56028
		private bool bool_1;

		// Token: 0x0400DADD RID: 56029
		private readonly List<Action> list_0;

		// Token: 0x0400DADE RID: 56030
		private readonly List<Action> list_1;

		// Token: 0x0400DADF RID: 56031
		private readonly List<Action> list_2;

		// Token: 0x0400DAE0 RID: 56032
		private List<EAreaType> list_3;

		// Token: 0x0400DAE1 RID: 56033
		[HideInInspector]
		[SerializeField]
		private SerializationData _serializationData;

		// Token: 0x02002A7B RID: 10875
		[CompilerGenerated]
		private sealed class Class2526
		{
			// Token: 0x0600D833 RID: 55347 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0400DAE2 RID: 56034
			public MenuTaskBar menuTaskBar_0;

			// Token: 0x0400DAE3 RID: 56035
			public GClass3107 screenManager;
		}

		// Token: 0x02002A7C RID: 10876
		[CompilerGenerated]
		private sealed class Class2527
		{
			// Token: 0x0600D834 RID: 55348 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(bool arg)
			{
				throw null;
			}

			// Token: 0x0400DAE4 RID: 56036
			public EMenuType menuType;

			// Token: 0x0400DAE5 RID: 56037
			public MenuTaskBar.Class2526 class2526_0;
		}

		// Token: 0x02002A7D RID: 10877
		[CompilerGenerated]
		private sealed class Class2528
		{
			// Token: 0x0600D835 RID: 55349 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0400DAE6 RID: 56038
			public BonusController bonusController;

			// Token: 0x0400DAE7 RID: 56039
			public MenuTaskBar menuTaskBar_0;
		}

		// Token: 0x02002A7E RID: 10878
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2529
		{
			// Token: 0x0600D836 RID: 55350 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal int method_0(GClass1912 x)
			{
				throw null;
			}

			// Token: 0x0600D837 RID: 55351 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_1(GClass940 x)
			{
				throw null;
			}

			// Token: 0x0600D838 RID: 55352 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal int method_2(GClass940 item)
			{
				throw null;
			}

			// Token: 0x0600D839 RID: 55353 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal int method_3(GClass940 item)
			{
				throw null;
			}

			// Token: 0x0400DAE8 RID: 56040
			public static readonly MenuTaskBar.Class2529 class2529_0;

			// Token: 0x0400DAE9 RID: 56041
			public static Func<GClass1912, int> func_0;

			// Token: 0x0400DAEA RID: 56042
			public static Func<GClass940, bool> func_1;

			// Token: 0x0400DAEB RID: 56043
			public static Func<GClass940, int> func_2;

			// Token: 0x0400DAEC RID: 56044
			public static Func<GClass940, int> func_3;
		}

		// Token: 0x02002A7F RID: 10879
		[CompilerGenerated]
		private sealed class Class2530
		{
			// Token: 0x0600D83A RID: 55354 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0400DAED RID: 56045
			public GClass3166 matchmakerPlayersController;

			// Token: 0x0400DAEE RID: 56046
			public MenuTaskBar menuTaskBar_0;
		}

		// Token: 0x02002A80 RID: 10880
		[CompilerGenerated]
		private sealed class Class2531
		{
			// Token: 0x0600D83B RID: 55355 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Task method_0()
			{
				throw null;
			}

			// Token: 0x0400DAEF RID: 56047
			public MenuTaskBar menuTaskBar_0;

			// Token: 0x0400DAF0 RID: 56048
			public AnimatedToggle toggleToSelect;

			// Token: 0x02002A81 RID: 10881
			[StructLayout(LayoutKind.Auto)]
			public struct Struct886 : IAsyncStateMachine
			{
				// Token: 0x0600D83C RID: 55356 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IAsyncStateMachine.MoveNext()
				{
					throw null;
				}

				// Token: 0x0600D83D RID: 55357 RVA: 0x00002050 File Offset: 0x00000250
				[DebuggerHidden]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
				{
					throw null;
				}

				// Token: 0x0400DAF1 RID: 56049
				public int int_0;

				// Token: 0x0400DAF2 RID: 56050
				public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

				// Token: 0x0400DAF3 RID: 56051
				public MenuTaskBar.Class2531 class2531_0;

				// Token: 0x0400DAF4 RID: 56052
				private YieldAwaitable.YieldAwaiter yieldAwaiter_0;
			}
		}

		// Token: 0x02002A82 RID: 10882
		[CompilerGenerated]
		private sealed class Class2532
		{
			// Token: 0x0600D83E RID: 55358 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0600D83F RID: 55359 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1(IEnumerable<Item> items)
			{
				throw null;
			}

			// Token: 0x0400DAF5 RID: 56053
			public GClass1912 producer;

			// Token: 0x0400DAF6 RID: 56054
			public MenuTaskBar menuTaskBar_0;
		}
	}
}
