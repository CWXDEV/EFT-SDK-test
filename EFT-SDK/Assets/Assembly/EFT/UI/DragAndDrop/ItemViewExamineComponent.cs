using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Sirenix.OdinInspector;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI.DragAndDrop
{
	// Token: 0x02002E22 RID: 11810
	public sealed class ItemViewExamineComponent : SerializedMonoBehaviour
	{
		// Token: 0x0600E8B2 RID: 59570 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(float duration)
		{
			throw null;
		}

		// Token: 0x0600E8B3 RID: 59571 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_0()
		{
			throw null;
		}

		// Token: 0x0600E8B4 RID: 59572 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(float progress)
		{
			throw null;
		}

		// Token: 0x0600E8B5 RID: 59573 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Destroy()
		{
			throw null;
		}

		// Token: 0x0400ED8F RID: 60815
		[SerializeField]
		private TextMeshProUGUI _progressLabel;

		// Token: 0x0400ED90 RID: 60816
		[SerializeField]
		private Slider _progressSlider;

		// Token: 0x0400ED91 RID: 60817
		private float float_0;

		// Token: 0x0400ED92 RID: 60818
		private CancellationTokenSource cancellationTokenSource_0;
	}
}
