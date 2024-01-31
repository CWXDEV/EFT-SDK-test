using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using JetBrains.Annotations;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x02002AE2 RID: 10978
	[UsedImplicitly]
	public sealed class VoiceSelector : UIElement
	{
		// Token: 0x0600DA12 RID: 55826 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Initialize(string currentVoice, EPlayerSide side, Func<string, Task<bool>> onVoiceChanged)
		{
			throw null;
		}

		// Token: 0x0600DA13 RID: 55827 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(bool profileIsFree)
		{
			throw null;
		}

		// Token: 0x0600DA14 RID: 55828 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(int currentIndex)
		{
			throw null;
		}

		// Token: 0x0600DA15 RID: 55829 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(bool currentSelected)
		{
			throw null;
		}

		// Token: 0x0600DA16 RID: 55830 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_2()
		{
			throw null;
		}

		// Token: 0x0600DA17 RID: 55831 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(bool status)
		{
			throw null;
		}

		// Token: 0x0600DA18 RID: 55832 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600DA19 RID: 55833 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerable<string> method_4()
		{
			throw null;
		}

		// Token: 0x0600DA1A RID: 55834 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5()
		{
			throw null;
		}

		// Token: 0x0400DD09 RID: 56585
		[SerializeField]
		private DropDownBox _dropdown;

		// Token: 0x0400DD0A RID: 56586
		[SerializeField]
		private DefaultUIButton _button;

		// Token: 0x0400DD0B RID: 56587
		[SerializeField]
		private GameObject _loader;

		// Token: 0x0400DD0C RID: 56588
		[SerializeField]
		private CanvasGroup _changeVoiceCanvas;

		// Token: 0x0400DD0D RID: 56589
		private readonly List<ValueTuple<string, string>> list_0;

		// Token: 0x0400DD0E RID: 56590
		private int int_0;

		// Token: 0x0400DD0F RID: 56591
		private int int_1;

		// Token: 0x0400DD10 RID: 56592
		private GClass3054 gclass3054_0;

		// Token: 0x0400DD11 RID: 56593
		private Func<string, Task<bool>> func_0;

		// Token: 0x02002AE3 RID: 10979
		[CompilerGenerated]
		private sealed class Class2573
		{
			// Token: 0x0600DA1B RID: 55835 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(GClass2937 x)
			{
				throw null;
			}

			// Token: 0x0400DD12 RID: 56594
			public EPlayerSide side;
		}

		// Token: 0x02002AE4 RID: 10980
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2574
		{
			// Token: 0x0600DA1C RID: 55836 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_0(GClass2937 x)
			{
				throw null;
			}

			// Token: 0x0600DA1D RID: 55837 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_1(ValueTuple<string, string> x)
			{
				throw null;
			}

			// Token: 0x0400DD13 RID: 56595
			public static readonly VoiceSelector.Class2574 class2574_0;

			// Token: 0x0400DD14 RID: 56596
			public static Func<GClass2937, string> func_0;

			// Token: 0x0400DD15 RID: 56597
			public static Func<ValueTuple<string, string>, string> func_1;
		}
	}
}
