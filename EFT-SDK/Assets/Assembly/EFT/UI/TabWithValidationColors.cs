using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002B69 RID: 11113
	public sealed class TabWithValidationColors : Tab
	{
		// Token: 0x0600DBA8 RID: 56232 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Init(GInterface368 controller)
		{
			throw null;
		}

		// Token: 0x0600DBA9 RID: 56233 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetValidationColor(bool active)
		{
			throw null;
		}

		// Token: 0x0600DBAA RID: 56234 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void UpdateVisual(bool selected, bool uiOnly = false)
		{
			throw null;
		}

		// Token: 0x0400DF6E RID: 57198
		[SerializeField]
		private Image _normalImage;

		// Token: 0x0400DF6F RID: 57199
		[SerializeField]
		private Image _selectedImage;

		// Token: 0x0400DF70 RID: 57200
		[SerializeField]
		private Sprite _positiveSelected;

		// Token: 0x0400DF71 RID: 57201
		[SerializeField]
		private Sprite _positiveIdle;

		// Token: 0x0400DF72 RID: 57202
		[SerializeField]
		private Sprite _negativeSelected;

		// Token: 0x0400DF73 RID: 57203
		[SerializeField]
		private Sprite _negativeIdle;

		// Token: 0x0400DF74 RID: 57204
		private bool bool_1;
	}
}
