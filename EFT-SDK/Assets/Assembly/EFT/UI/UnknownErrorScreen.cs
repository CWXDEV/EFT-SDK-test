using System;
using System.Runtime.CompilerServices;
using EFT.InputSystem;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x0200288E RID: 10382
	public sealed class UnknownErrorScreen : UIInputNode
	{
		// Token: 0x0600CF37 RID: 53047 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600CF38 RID: 53048 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(string header, string message, string fullDescription, Action acceptCallback = null)
		{
			throw null;
		}

		// Token: 0x0600CF39 RID: 53049 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override ECursorResult ShouldLockCursor()
		{
			throw null;
		}

		// Token: 0x0600CF3A RID: 53050 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void TranslateAxes(ref float[] axes)
		{
			throw null;
		}

		// Token: 0x0600CF3B RID: 53051 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override InputNode.ETranslateResult TranslateCommand(ECommand command)
		{
			throw null;
		}

		// Token: 0x0600CF3C RID: 53052 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x0600CF3D RID: 53053 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0600CF3E RID: 53054 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x0400D022 RID: 53282
		private const string string_0 = "ERROR";

		// Token: 0x0400D023 RID: 53283
		private Action action_0;

		// Token: 0x0400D024 RID: 53284
		[SerializeField]
		private CustomTextMeshProUGUI _errorHeader;

		// Token: 0x0400D025 RID: 53285
		[SerializeField]
		private CustomTextMeshProUGUI _errorMessage;

		// Token: 0x0400D026 RID: 53286
		[SerializeField]
		private CustomTextMeshProUGUI _errorDescription;

		// Token: 0x0400D027 RID: 53287
		[SerializeField]
		private DefaultUIButton _closeButton;

		// Token: 0x0400D028 RID: 53288
		[SerializeField]
		private DefaultUIButton _copyButton;
	}
}
