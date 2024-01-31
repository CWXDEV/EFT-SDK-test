using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine;

namespace EFT.Hideout
{
	// Token: 0x02001BD0 RID: 7120
	public sealed class UnitReadyPanel : AbstractPanel<EAreaStatus>
	{
		// Token: 0x06009583 RID: 38275 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Task ShowContents()
		{
			throw null;
		}

		// Token: 0x06009584 RID: 38276 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetInfo()
		{
			throw null;
		}

		// Token: 0x04009C3B RID: 39995
		private const string string_0 = "Unit is ready to be installed";

		// Token: 0x04009C3C RID: 39996
		[SerializeField]
		private CustomTextMeshProUGUI _statusLabel;

		// Token: 0x04009C3D RID: 39997
		[SerializeField]
		private CustomTextMeshProUGUI _descriptionLabel;
	}
}
