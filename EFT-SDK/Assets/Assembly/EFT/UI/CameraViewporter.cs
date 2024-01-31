using System;
using System.Runtime.CompilerServices;
using EFT.UI.WeaponModding;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x02002CA2 RID: 11426
	[ExecuteInEditMode]
	public sealed class CameraViewporter : MonoBehaviour
	{
		// Token: 0x17002743 RID: 10051
		// (get) Token: 0x0600E122 RID: 57634 RVA: 0x00002050 File Offset: 0x00000250
		public Camera TargetCamera
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600E123 RID: 57635 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnEnable()
		{
			throw null;
		}

		// Token: 0x0600E124 RID: 57636 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x0600E125 RID: 57637 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Vector2 WorldToLocalScreenPosition(Vector3 worldPosition)
		{
			throw null;
		}

		// Token: 0x0600E126 RID: 57638 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDisable()
		{
			throw null;
		}

		// Token: 0x0400E5D6 RID: 58838
		[SerializeField]
		private WeaponPreview _weaponPreview;

		// Token: 0x0400E5D7 RID: 58839
		private Canvas canvas_0;

		// Token: 0x0400E5D8 RID: 58840
		private RectTransform rectTransform_0;
	}
}
