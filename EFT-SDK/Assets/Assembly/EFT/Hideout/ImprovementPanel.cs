using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine;

namespace EFT.Hideout
{
	// Token: 0x02001ADE RID: 6878
	public sealed class ImprovementPanel : AbstractPanel<bool>
	{
		// Token: 0x060090AF RID: 37039 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Task ShowContents()
		{
			throw null;
		}

		// Token: 0x060090B0 RID: 37040 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetInfo()
		{
			throw null;
		}

		// Token: 0x060090B1 RID: 37041 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private ImprovementView method_0(GClass1908 arg)
		{
			throw null;
		}

		// Token: 0x060090B2 RID: 37042 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Transform method_1(GClass1908 arg)
		{
			throw null;
		}

		// Token: 0x060090B3 RID: 37043 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(GClass1908 improvement, ImprovementView view)
		{
			throw null;
		}

		// Token: 0x040097E9 RID: 38889
		[SerializeField]
		private ImprovementView _improvementViewTemplate;

		// Token: 0x040097EA RID: 38890
		[SerializeField]
		private RectTransform _container;

		// Token: 0x040097EB RID: 38891
		private Dictionary<GClass1919, GInterface167> dictionary_0;

		// Token: 0x040097EC RID: 38892
		private GClass3076<GClass1920, ProduceView> gclass3076_0;
	}
}
