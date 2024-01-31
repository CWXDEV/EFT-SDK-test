using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EFT.InputSystem;
using EFT.UI;
using EFT.UI.Screens;
using UnityEngine;

namespace EFT.Hideout
{
	// Token: 0x02001BE0 RID: 7136
	public sealed class HideoutScreenOverlay : UIScreen
	{
		// Token: 0x140001BE RID: 446
		// (add) Token: 0x060095E4 RID: 38372 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060095E5 RID: 38373 RVA: 0x00002050 File Offset: 0x00000250
		public event Action OnReturnToHomeScreen
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

		// Token: 0x140001BF RID: 447
		// (add) Token: 0x060095E6 RID: 38374 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060095E7 RID: 38375 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<ELightingLevel> OnLightingLevelChanged
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

		// Token: 0x060095E8 RID: 38376 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x060095E9 RID: 38377 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(bool isOn)
		{
			throw null;
		}

		// Token: 0x060095EA RID: 38378 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(HideoutPlayer player, bool returnToFirstPerson, ISession session, AreaData[] areaDatas, HideoutScreenRear hideoutRear)
		{
			throw null;
		}

		// Token: 0x060095EB RID: 38379 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearLightLevels()
		{
			throw null;
		}

		// Token: 0x060095EC RID: 38380 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddLightingLevel(ELightingLevel level, bool switchToNewLevel)
		{
			throw null;
		}

		// Token: 0x060095ED RID: 38381 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetCurrentLightingLevel(ELightingLevel level)
		{
			throw null;
		}

		// Token: 0x060095EE RID: 38382 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task AreaSelected(AreaData data, bool wait)
		{
			throw null;
		}

		// Token: 0x060095EF RID: 38383 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x060095F0 RID: 38384 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x060095F1 RID: 38385 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void smethod_0(AreaData areaData)
		{
			throw null;
		}

		// Token: 0x060095F2 RID: 38386 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ReturnToPreviousState()
		{
			throw null;
		}

		// Token: 0x060095F3 RID: 38387 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5()
		{
			throw null;
		}

		// Token: 0x060095F4 RID: 38388 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6(AreaData area)
		{
			throw null;
		}

		// Token: 0x060095F5 RID: 38389 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override ECursorResult ShouldLockCursor()
		{
			throw null;
		}

		// Token: 0x060095F6 RID: 38390 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override InputNode.ETranslateResult TranslateCommand(ECommand command)
		{
			throw null;
		}

		// Token: 0x060095F7 RID: 38391 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void TranslateAxes(ref float[] axes)
		{
			throw null;
		}

		// Token: 0x060095F8 RID: 38392 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7()
		{
			throw null;
		}

		// Token: 0x060095F9 RID: 38393 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public new void Close()
		{
			throw null;
		}

		// Token: 0x060095FA RID: 38394 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_8(bool arg)
		{
			throw null;
		}

		// Token: 0x060095FB RID: 38395 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_9(bool arg)
		{
			throw null;
		}

		// Token: 0x060095FC RID: 38396 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_10(ELightingLevel lightingLevel)
		{
			throw null;
		}

		// Token: 0x060095FD RID: 38397 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_11()
		{
			throw null;
		}

		// Token: 0x060095FE RID: 38398 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_12(AreaPanel arg)
		{
			throw null;
		}

		// Token: 0x060095FF RID: 38399 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_13()
		{
			throw null;
		}

		// Token: 0x06009600 RID: 38400 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_14()
		{
			throw null;
		}

		// Token: 0x04009C9A RID: 40090
		private const string string_0 = "hideout/Turn night vision on";

		// Token: 0x04009C9B RID: 40091
		private const string string_1 = "hideout/Turn night vision off";

		// Token: 0x04009C9C RID: 40092
		private const string string_2 = "hideout/Turn generator on";

		// Token: 0x04009C9D RID: 40093
		private const string string_3 = "hideout/Turn generator off";

		// Token: 0x04009C9E RID: 40094
		private const string string_4 = "hideout/Generator not constructed";

		// Token: 0x04009C9F RID: 40095
		private const string string_5 = "hideout/Welcome title";

		// Token: 0x04009CA0 RID: 40096
		private const string string_6 = "hideout/Welcome";

		// Token: 0x04009CA1 RID: 40097
		private const float float_0 = 4f;

		// Token: 0x04009CA2 RID: 40098
		private const int int_0 = 10;

		// Token: 0x04009CA3 RID: 40099
		[CompilerGenerated]
		private Action action_0;

		// Token: 0x04009CA4 RID: 40100
		[CompilerGenerated]
		private Action<ELightingLevel> action_1;

		// Token: 0x04009CA5 RID: 40101
		[SerializeField]
		private DefaultUIButton _enterHideoutButtonSpawner;

		// Token: 0x04009CA6 RID: 40102
		[SerializeField]
		private DefaultUIButton _returnToMenuButtonSpawner;

		// Token: 0x04009CA7 RID: 40103
		[SerializeField]
		private ComplementaryButton _nightVisionButton;

		// Token: 0x04009CA8 RID: 40104
		[SerializeField]
		private ComplementaryButton _generatorButton;

		// Token: 0x04009CA9 RID: 40105
		[SerializeField]
		private AreasPanel _areasPanel;

		// Token: 0x04009CAA RID: 40106
		[SerializeField]
		private DelayTypeWindow _delayTypeWindow;

		// Token: 0x04009CAB RID: 40107
		[SerializeField]
		private AreaScreenSubstrate _areaSubstrateTemplate;

		// Token: 0x04009CAC RID: 40108
		[SerializeField]
		private RectTransform _areaScreenContainer;

		// Token: 0x04009CAD RID: 40109
		[SerializeField]
		private ChangeLightButton _changeLightButton;

		// Token: 0x04009CAE RID: 40110
		[SerializeField]
		private ChangeLightPanel _changeLightPanel;

		// Token: 0x04009CAF RID: 40111
		private HideoutCameraController hideoutCameraController_0;

		// Token: 0x04009CB0 RID: 40112
		private AreaScreenSubstrate areaScreenSubstrate_0;

		// Token: 0x04009CB1 RID: 40113
		private HideoutPlayer hideoutPlayer_0;

		// Token: 0x04009CB2 RID: 40114
		private ISession ginterface145_0;

		// Token: 0x04009CB3 RID: 40115
		private AreaData areaData_0;

		// Token: 0x04009CB4 RID: 40116
		private HideoutScreenRear hideoutScreenRear_0;

		// Token: 0x04009CB5 RID: 40117
		private float[] float_1;

		// Token: 0x04009CB6 RID: 40118
		private bool bool_0;

		// Token: 0x04009CB7 RID: 40119
		private bool bool_1;

		// Token: 0x04009CB8 RID: 40120
		private EnergyControllerClass gclass1901_0;

		// Token: 0x04009CB9 RID: 40121
		private AreaData areaData_1;

		// Token: 0x02001BE1 RID: 7137
		[CompilerGenerated]
		[Serializable]
		private sealed class Class1683
		{
			// Token: 0x06009601 RID: 38401 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_0()
			{
				throw null;
			}

			// Token: 0x06009602 RID: 38402 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_1()
			{
				throw null;
			}

			// Token: 0x06009603 RID: 38403 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_2()
			{
				throw null;
			}

			// Token: 0x06009604 RID: 38404 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_3()
			{
				throw null;
			}

			// Token: 0x06009605 RID: 38405 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_4(AreaData data)
			{
				throw null;
			}

			// Token: 0x06009606 RID: 38406 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_5()
			{
				throw null;
			}

			// Token: 0x06009607 RID: 38407 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_6()
			{
				throw null;
			}

			// Token: 0x06009608 RID: 38408 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_7()
			{
				throw null;
			}

			// Token: 0x06009609 RID: 38409 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_8()
			{
				throw null;
			}

			// Token: 0x04009CBA RID: 40122
			public static readonly HideoutScreenOverlay.Class1683 class1683_0;

			// Token: 0x04009CBB RID: 40123
			public static Func<string> func_0;

			// Token: 0x04009CBC RID: 40124
			public static Func<string> func_1;

			// Token: 0x04009CBD RID: 40125
			public static Func<string> func_2;

			// Token: 0x04009CBE RID: 40126
			public static Func<string> func_3;

			// Token: 0x04009CBF RID: 40127
			public static Func<AreaData, bool> func_4;

			// Token: 0x04009CC0 RID: 40128
			public static Func<string> func_5;

			// Token: 0x04009CC1 RID: 40129
			public static Func<string> func_6;

			// Token: 0x04009CC2 RID: 40130
			public static Func<string> func_7;

			// Token: 0x04009CC3 RID: 40131
			public static Func<string> func_8;
		}
	}
}
