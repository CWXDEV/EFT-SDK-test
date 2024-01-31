using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine;

namespace EFT.Hideout
{
	// Token: 0x02001B7E RID: 7038
	public sealed class ConstructionTimePanel : AbstractPanel<float>
	{
		// Token: 0x06009427 RID: 37927 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Task ShowContents()
		{
			throw null;
		}

		// Token: 0x06009428 RID: 37928 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetInfo()
		{
			throw null;
		}

		// Token: 0x04009AF1 RID: 39665
		private const string string_0 = "HOURS";

		// Token: 0x04009AF2 RID: 39666
		private const string string_1 = "INSTANT";

		// Token: 0x04009AF3 RID: 39667
		[SerializeField]
		private CustomTextMeshProUGUI _constructTimeLabel;
	}
}
