using System;
using System.Runtime.CompilerServices;
using Bsg.GameSettings;
using UnityEngine;

namespace EFT.UI.Settings
{
	// Token: 0x02002D39 RID: 11577
	public sealed class SettingFloatSlider : SettingControl
	{
		// Token: 0x170027C8 RID: 10184
		// (get) Token: 0x0600E3CD RID: 58317 RVA: 0x00002050 File Offset: 0x00000250
		protected override Component TargetComponent
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170027C9 RID: 10185
		// (set) Token: 0x0600E3CE RID: 58318 RVA: 0x00002050 File Offset: 0x00000250
		public string Format
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600E3CF RID: 58319 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void BindTo(GameSetting<int> setting, int minValue, int maxValue)
		{
			throw null;
		}

		// Token: 0x0600E3D0 RID: 58320 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void BindTo(GameSetting<float> setting, float minValue, float maxValue)
		{
			throw null;
		}

		// Token: 0x0400E8A4 RID: 59556
		[SerializeField]
		private FloatSlider Slider;

		// Token: 0x02002D3A RID: 11578
		[CompilerGenerated]
		private sealed class Class2776
		{
			// Token: 0x0600E3D1 RID: 58321 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(float value)
			{
				throw null;
			}

			// Token: 0x0400E8A5 RID: 59557
			public GameSetting<int> setting;
		}

		// Token: 0x02002D3B RID: 11579
		[CompilerGenerated]
		private sealed class Class2777
		{
			// Token: 0x0600E3D2 RID: 58322 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(float value)
			{
				throw null;
			}

			// Token: 0x0400E8A6 RID: 59558
			public GameSetting<float> setting;
		}
	}
}
