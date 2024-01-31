using System;
using System.Runtime.CompilerServices;
using EFT.UI.Health;
using JetBrains.Annotations;
using UnityEngine;

namespace EFT.UI.Builds
{
	// Token: 0x02002EF1 RID: 12017
	[UsedImplicitly]
	public sealed class EquipmentBuildListView : BuildListView<GClass3017<GClass3181>, GClass3181>
	{
		// Token: 0x0600ED34 RID: 60724 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(GClass3017<GClass3181> buildWrapper,  ValueTuple<float, float, float>? weightParameters)
		{
			throw null;
		}

		// Token: 0x0400F232 RID: 62002
		[SerializeField]
		private HealthParameterPanel _weight;
	}
}
