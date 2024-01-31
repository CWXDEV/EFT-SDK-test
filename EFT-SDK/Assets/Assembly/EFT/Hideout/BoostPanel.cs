using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EFT.UI;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace EFT.Hideout
{
	// Token: 0x02001B7B RID: 7035
	public sealed class BoostPanel : AbstractPanel<Requirement>
	{
		// Token: 0x06009420 RID: 37920 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x06009421 RID: 37921 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Task ShowContents()
		{
			throw null;
		}

		// Token: 0x06009422 RID: 37922 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetInfo()
		{
			throw null;
		}

		// Token: 0x06009423 RID: 37923 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x04009AE8 RID: 39656
		[SerializeField]
		private RequirementsPanel _boostRequirementsPanel;

		// Token: 0x04009AE9 RID: 39657
		[SerializeField]
		private DefaultUIButton _boostButton;

		// Token: 0x04009AEA RID: 39658
		[SerializeField]
		private TextMeshProUGUI _boostInfo;

		// Token: 0x02001B7C RID: 7036
		[CompilerGenerated]
		[Serializable]
		private sealed class Class1665
		{
			// Token: 0x06009424 RID: 37924 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x04009AEB RID: 39659
			public static readonly BoostPanel.Class1665 class1665_0;

			// Token: 0x04009AEC RID: 39660
			public static UnityAction unityAction_0;
		}
	}
}
