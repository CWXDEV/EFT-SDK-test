using System;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Bsg.GameSettings;
using Comfort.Common;
using UnityEngine;

namespace EFT.UI.Settings
{
	// Token: 0x02002D64 RID: 11620
	public sealed class SoundSettingsTab : SettingsTab
	{
		// Token: 0x0600E48C RID: 58508 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(GClass953 soundSettings, InfoClass profileInfo, ISession session)
		{
			throw null;
		}

		// Token: 0x0600E48D RID: 58509 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x0600E48E RID: 58510 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Task TakeSettingsFrom(SharedGameSettingsClass settingsManager)
		{
			throw null;
		}

		// Token: 0x0600E48F RID: 58511 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnTabSelected()
		{
			throw null;
		}

		// Token: 0x0600E490 RID: 58512 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task<bool> method_0(string voice)
		{
			throw null;
		}

		// Token: 0x0600E491 RID: 58513 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(GameSetting<string> setting, Transform container, ReadOnlyCollection<string> devices)
		{
			throw null;
		}

		// Token: 0x0600E492 RID: 58514 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(GameSetting<int> setting)
		{
			throw null;
		}

		// Token: 0x0600E493 RID: 58515 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(GameSetting<bool> setting)
		{
			throw null;
		}

		// Token: 0x0600E494 RID: 58516 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x0600E495 RID: 58517 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5(EBanType banType = EBanType.Voip)
		{
			throw null;
		}

		// Token: 0x0600E496 RID: 58518 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6()
		{
			throw null;
		}

		// Token: 0x0600E497 RID: 58519 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7(string message)
		{
			throw null;
		}

		// Token: 0x0600E498 RID: 58520 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_8(bool value)
		{
			throw null;
		}

		// Token: 0x0600E499 RID: 58521 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600E49A RID: 58522 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_9()
		{
			throw null;
		}

		// Token: 0x0400E99B RID: 59803
		private const string string_1 = "Error/VoiceChangingFailed";

		// Token: 0x0400E99C RID: 59804
		private readonly ReadOnlyCollection<int> readOnlyCollection_0;

		// Token: 0x0400E99D RID: 59805
		[SerializeField]
		private VoiceSelector _voiceSelector;

		// Token: 0x0400E99E RID: 59806
		[SerializeField]
		private Transform _slidersSection;

		// Token: 0x0400E99F RID: 59807
		[SerializeField]
		private Transform _togglesSection;

		// Token: 0x0400E9A0 RID: 59808
		[SerializeField]
		[Space]
		private SettingSelectSlider _selectSliderPrefab;

		// Token: 0x0400E9A1 RID: 59809
		[SerializeField]
		private SettingFloatSlider _floatSliderPrefab;

		// Token: 0x0400E9A2 RID: 59810
		[SerializeField]
		private SettingDropDown _dropDownPrefab;

		// Token: 0x0400E9A3 RID: 59811
		[SerializeField]
		private SettingToggle _togglePrefab;

		// Token: 0x0400E9A4 RID: 59812
		[Space]
		[SerializeField]
		private UiElementBlocker _voipEnableBlocker;

		// Token: 0x0400E9A5 RID: 59813
		[SerializeField]
		private UiElementBlocker _voipBanBlocker;

		// Token: 0x0400E9A6 RID: 59814
		[SerializeField]
		private CustomTextMeshProUGUI _voipBanMessageText;

		// Token: 0x0400E9A7 RID: 59815
		[SerializeField]
		private GameObject _voipBanMessage;

		// Token: 0x0400E9A8 RID: 59816
		private GClass953 gclass953_0;

		// Token: 0x0400E9A9 RID: 59817
		private GClass943 gclass943_0;

		// Token: 0x0400E9AA RID: 59818
		private ISession ginterface145_0;

		// Token: 0x0400E9AB RID: 59819
		private bool bool_0;

		// Token: 0x0400E9AC RID: 59820
		private InfoClass gclass1757_0;

		// Token: 0x0400E9AD RID: 59821
		private GClass1756 gclass1756_0;

		// Token: 0x0400E9AE RID: 59822
		private int int_0;

		// Token: 0x02002D65 RID: 11621
		[CompilerGenerated]
		private sealed class Class2802
		{
			// Token: 0x0600E49B RID: 58523 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(IResult result)
			{
				throw null;
			}

			// Token: 0x0400E9AF RID: 59823
			public TaskCompletionSource<bool> source;

			// Token: 0x0400E9B0 RID: 59824
			public SoundSettingsTab soundSettingsTab_0;

			// Token: 0x0400E9B1 RID: 59825
			public string voice;
		}

		// Token: 0x02002D66 RID: 11622
		[CompilerGenerated]
		private sealed class Class2803
		{
			// Token: 0x0600E49C RID: 58524 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0400E9B2 RID: 59826
			public SettingDropDown deviceDropDown;
		}

		// Token: 0x02002D67 RID: 11623
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2804
		{
			// Token: 0x0600E49D RID: 58525 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_0(string x)
			{
				throw null;
			}

			// Token: 0x0600E49E RID: 58526 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_1(int x)
			{
				throw null;
			}

			// Token: 0x0400E9B3 RID: 59827
			public static readonly SoundSettingsTab.Class2804 class2804_0;

			// Token: 0x0400E9B4 RID: 59828
			public static Func<string, string> func_0;

			// Token: 0x0400E9B5 RID: 59829
			public static Func<int, string> func_1;
		}
	}
}
