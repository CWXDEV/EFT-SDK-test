using System;
using System.Runtime.CompilerServices;
using Bsg.GameSettings;
using UnityEngine;

namespace EFT.UI.Settings
{
	// Token: 0x02002D3E RID: 11582
	public sealed class SettingToggle : SettingControl
	{
		// Token: 0x170027CB RID: 10187
		// (get) Token: 0x0600E3D7 RID: 58327 RVA: 0x00002050 File Offset: 0x00000250
		protected override Component TargetComponent
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600E3D8 RID: 58328 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void BindTo(GameSetting<bool> setting)
		{
			throw null;
		}

		// Token: 0x0400E8A9 RID: 59561
		[SerializeField]
		private UpdatableToggle Toggle;

		// Token: 0x02002D3F RID: 11583
		[CompilerGenerated]
		private sealed class Class2779
		{
			// Token: 0x0600E3D9 RID: 58329 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(bool value)
			{
				throw null;
			}

			// Token: 0x0400E8AA RID: 59562
			public GameSetting<bool> setting;
		}
	}
}
