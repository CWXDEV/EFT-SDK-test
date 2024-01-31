using System;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using Bsg.GameSettings;
using UnityEngine;

namespace EFT.UI.Settings
{
	// Token: 0x02002D3C RID: 11580
	public sealed class SettingSelectSlider : SettingControl
	{
		// Token: 0x170027CA RID: 10186
		// (get) Token: 0x0600E3D3 RID: 58323 RVA: 0x00002050 File Offset: 0x00000250
		protected override Component TargetComponent
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600E3D4 RID: 58324 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void BindIndexTo<T>(GameSetting<int> setting, ReadOnlyCollection<T> variants, Func<T, string> stringConverter)
		{
			throw null;
		}

		// Token: 0x0600E3D5 RID: 58325 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool UpdateSliderValue<T>(SelectSlider slider, T value, ReadOnlyCollection<T> variants)
		{
			throw null;
		}

		// Token: 0x0400E8A7 RID: 59559
		[SerializeField]
		private SelectSlider Slider;

		// Token: 0x02002D3D RID: 11581
		[CompilerGenerated]
		private sealed class Class2778<T>
		{
			// Token: 0x0600E3D6 RID: 58326 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(int index)
			{
				throw null;
			}

			// Token: 0x0400E8A8 RID: 59560
			public GameSetting<int> setting;
		}
	}
}
