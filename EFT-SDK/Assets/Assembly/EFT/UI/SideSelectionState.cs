using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x0200292C RID: 10540
	[Serializable]
	public class SideSelectionState : GClass3012
	{
		// Token: 0x0600D275 RID: 53877 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(GClass1816.GClass1817 profileData, Profile bearProfile, Profile usecProfile, Dictionary<EPlayerSide, PlayerProfilePreview> previews)
		{
			throw null;
		}

		// Token: 0x0600D276 RID: 53878 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Task ShowState()
		{
			throw null;
		}

		// Token: 0x0600D277 RID: 53879 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(bool active)
		{
			throw null;
		}

		// Token: 0x0600D278 RID: 53880 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Task HideState()
		{
			throw null;
		}

		// Token: 0x0600D279 RID: 53881 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(EPlayerSide side)
		{
			throw null;
		}

		// Token: 0x0600D27A RID: 53882 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(string text)
		{
			throw null;
		}

		// Token: 0x0600D27B RID: 53883 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[DebuggerHidden]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_4()
		{
			throw null;
		}

		// Token: 0x0600D27C RID: 53884 RVA: 0x00002050 File Offset: 0x00000250
		[DebuggerHidden]
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_5()
		{
			throw null;
		}

		// Token: 0x0400D3D2 RID: 54226
		private const string BEAR_DESCRIPTION = "Select BEAR Character";

		// Token: 0x0400D3D3 RID: 54227
		private const string USEC_DESCRIPTION = "Select USEC Character";

		// Token: 0x0400D3D4 RID: 54228
		[SerializeField]
		private CustomTextMeshProUGUI _descriptionLabel;

		// Token: 0x0400D3D5 RID: 54229
		[SerializeField]
		private ToggleGroup _toggleGroup;

		// Token: 0x0400D3D6 RID: 54230
		private Dictionary<EPlayerSide, PlayerProfilePreview> _previews;

		// Token: 0x0400D3D7 RID: 54231
		private Dictionary<EPlayerSide, string> _sideDescriptions;

		// Token: 0x0400D3D8 RID: 54232
		private GClass1816.GClass1817 _profileData;
	}
}
