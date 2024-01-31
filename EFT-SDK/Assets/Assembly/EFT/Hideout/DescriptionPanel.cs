using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine;

namespace EFT.Hideout
{
	// Token: 0x02001B80 RID: 7040
	public sealed class DescriptionPanel : AbstractPanel<string>
	{
		// Token: 0x0600942B RID: 37931 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Task ShowContents()
		{
			throw null;
		}

		// Token: 0x0600942C RID: 37932 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetInfo()
		{
			throw null;
		}

		// Token: 0x04009AF8 RID: 39672
		[SerializeField]
		private CustomTextMeshProUGUI _descriptionLabel;
	}
}
