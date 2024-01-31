using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Koenigz.PerfectCulling.EFT
{
	// Token: 0x02000DF3 RID: 3571
	[RequireComponent(typeof(ScreenDistanceSwitcher))]
	public sealed class BakedLodContent : PerfectCullingCrossSceneContent
	{
		// Token: 0x17000BF5 RID: 3061
		// (get) Token: 0x06004ADE RID: 19166 RVA: 0x00002050 File Offset: 0x00000250
		public ScreenDistanceSwitcher Switcher
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06004ADF RID: 19167 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnBakedLODVisbilityChanged(ScreenDistanceSwitcher bakeLOD, bool isVisible)
		{
			throw null;
		}

		// Token: 0x04005619 RID: 22041
		[SerializeField]
		private ScreenDistanceSwitcher _screenDistanceSwitcher;
	}
}
