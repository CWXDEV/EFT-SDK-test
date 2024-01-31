using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x020028AB RID: 10411
	public sealed class BattleUIComponentAnimation : MonoBehaviour
	{
		// Token: 0x0600CFE4 RID: 53220 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task Show(bool autoHide, float delaySeconds = 0f)
		{
			throw null;
		}

		// Token: 0x0600CFE5 RID: 53221 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task Hide(float delaySeconds = 0f)
		{
			throw null;
		}

		// Token: 0x0600CFE6 RID: 53222 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Close()
		{
			throw null;
		}

		// Token: 0x0600CFE7 RID: 53223 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CancellationTokenSource StopAnimation()
		{
			throw null;
		}

		// Token: 0x0400D0BC RID: 53436
		public const float VISIBILITY_DURATION = 3f;

		// Token: 0x0400D0BD RID: 53437
		private const float float_0 = 0.5f;

		// Token: 0x0400D0BE RID: 53438
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0400D0BF RID: 53439
		private CancellationTokenSource cancellationTokenSource_0;
	}
}
