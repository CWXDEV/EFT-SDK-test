using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x02002ACF RID: 10959
	public sealed class ScreenPositionAnchor : MonoBehaviour
	{
		// Token: 0x0600D9DE RID: 55774 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnEnable()
		{
			throw null;
		}

		// Token: 0x0600D9DF RID: 55775 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetCamera(Camera newCam)
		{
			throw null;
		}

		// Token: 0x0600D9E0 RID: 55776 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Update()
		{
			throw null;
		}

		// Token: 0x0400DCC2 RID: 56514
		[SerializeField]
		private Camera _camera;

		// Token: 0x0400DCC3 RID: 56515
		[SerializeField]
		private ScreenPositionAnchor.EAnchorType _type;

		// Token: 0x0400DCC4 RID: 56516
		[SerializeField]
		private TextAnchor _alignment;

		// Token: 0x0400DCC5 RID: 56517
		[SerializeField]
		private Vector2 _position;

		// Token: 0x0400DCC6 RID: 56518
		private int int_0;

		// Token: 0x0400DCC7 RID: 56519
		private int int_1;

		// Token: 0x02002AD0 RID: 10960
		private enum EAnchorType
		{
			// Token: 0x0400DCC9 RID: 56521
			RelativeByHeight,
			// Token: 0x0400DCCA RID: 56522
			RelativeByWidth,
			// Token: 0x0400DCCB RID: 56523
			Absolute
		}
	}
}
