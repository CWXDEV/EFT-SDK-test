using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x020028D7 RID: 10455
	public class CharacterSelectionStartScreen : MonoBehaviour
	{
		// Token: 0x0600D0D0 RID: 53456 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600D0D1 RID: 53457 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(Action<CharacterSelectionStartScreen.PMC> acceptAction, Action backAction)
		{
			throw null;
		}

		// Token: 0x0600D0D2 RID: 53458 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Hide()
		{
			throw null;
		}

		// Token: 0x0600D0D3 RID: 53459 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0600D0D4 RID: 53460 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x0600D0D5 RID: 53461 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(bool arg)
		{
			throw null;
		}

		// Token: 0x0600D0D6 RID: 53462 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(bool arg)
		{
			throw null;
		}

		// Token: 0x0400D19F RID: 53663
		[SerializeField]
		private Button _acceptButton;

		// Token: 0x0400D1A0 RID: 53664
		[SerializeField]
		private Button _backButton;

		// Token: 0x0400D1A1 RID: 53665
		[SerializeField]
		private AnimatedToggle _usecButton;

		// Token: 0x0400D1A2 RID: 53666
		[SerializeField]
		private AnimatedToggle _bearButton;

		// Token: 0x0400D1A3 RID: 53667
		private Action<CharacterSelectionStartScreen.PMC> action_0;

		// Token: 0x0400D1A4 RID: 53668
		private Action action_1;

		// Token: 0x0400D1A5 RID: 53669
		private CharacterSelectionStartScreen.PMC pmc_0;

		// Token: 0x020028D8 RID: 10456
		public enum PMC
		{
			// Token: 0x0400D1A7 RID: 53671
			USEC,
			// Token: 0x0400D1A8 RID: 53672
			BEAR
		}
	}
}
