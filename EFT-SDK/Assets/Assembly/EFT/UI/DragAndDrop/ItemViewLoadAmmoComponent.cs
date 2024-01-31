using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI.DragAndDrop
{
	// Token: 0x02002E24 RID: 11812
	public class ItemViewLoadAmmoComponent : SerializedMonoBehaviour
	{
		// Token: 0x0600E8B8 RID: 59576 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(float oneAmmoDuration, int ammoTotal, int ammoDone = 0)
		{
			throw null;
		}

		// Token: 0x0600E8B9 RID: 59577 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_0()
		{
			throw null;
		}

		// Token: 0x0600E8BA RID: 59578 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetStopButtonStatus(bool active)
		{
			throw null;
		}

		// Token: 0x0600E8BB RID: 59579 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Destroy()
		{
			throw null;
		}

		// Token: 0x0400ED99 RID: 60825
		[SerializeField]
		private Image _loadMagazineLoader;

		// Token: 0x0400ED9A RID: 60826
		[SerializeField]
		private GameObject _loadStopImage;

		// Token: 0x0400ED9B RID: 60827
		[SerializeField]
		private ProgressSpinner _loadProgressSpinner;

		// Token: 0x0400ED9C RID: 60828
		private float float_0;

		// Token: 0x0400ED9D RID: 60829
		private double double_0;

		// Token: 0x0400ED9E RID: 60830
		private double double_1;

		// Token: 0x0400ED9F RID: 60831
		private double double_2;

		// Token: 0x0400EDA0 RID: 60832
		private CancellationTokenSource cancellationTokenSource_0;
	}
}
