using System;
using System.Runtime.CompilerServices;
using System.Threading;
using EFT.InventoryLogic;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002AEA RID: 10986
	public class SimpleTooltip : Tooltip
	{
		// Token: 0x0600DA39 RID: 55865 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Awake()
		{
			throw null;
		}

		// Token: 0x0600DA3A RID: 55866 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CancellationToken Show(string text, Vector2? offset = null, float delay = 0f, float? maxWidth = null, bool isInteractable = true)
		{
			throw null;
		}

		// Token: 0x0600DA3B RID: 55867 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ShowInventoryError(InventoryError error)
		{
			throw null;
		}

		// Token: 0x0600DA3C RID: 55868 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ShowWarning(InventoryError warning)
		{
			throw null;
		}

		// Token: 0x0600DA3D RID: 55869 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetText(string text)
		{
			throw null;
		}

		// Token: 0x0400DD32 RID: 56626
		private readonly Vector2 vector2_1;

		// Token: 0x0400DD33 RID: 56627
		[SerializeField]
		[FormerlySerializedAs("_text")]
		private TextMeshProUGUI _label;

		// Token: 0x0400DD34 RID: 56628
		private LayoutElement layoutElement_0;

		// Token: 0x0400DD35 RID: 56629
		private float float_0;
	}
}
