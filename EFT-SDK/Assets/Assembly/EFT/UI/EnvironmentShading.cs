using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Sirenix.OdinInspector;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x02002962 RID: 10594
	public sealed class EnvironmentShading : SerializedMonoBehaviour
	{
		// Token: 0x0600D2F5 RID: 54005 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDefaultShading(CanvasGroup canvasGroup)
		{
			throw null;
		}

		// Token: 0x0600D2F6 RID: 54006 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ResetShading()
		{
			throw null;
		}

		// Token: 0x0600D2F7 RID: 54007 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetShading(EShadingType type, bool force = false)
		{
			throw null;
		}

		// Token: 0x0600D2F8 RID: 54008 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetShadingVisibility(bool visible, float duration = 0.8f)
		{
			throw null;
		}

		// Token: 0x0600D2F9 RID: 54009 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void smethod_0(CanvasGroup canvasGroup)
		{
			throw null;
		}

		// Token: 0x0400D4C9 RID: 54473
		private const float float_0 = 0.8f;

		// Token: 0x0400D4CA RID: 54474
		[SerializeField]
		private Dictionary<EShadingType, CanvasGroup> _environmentShadings;

		// Token: 0x0400D4CB RID: 54475
		private bool bool_0;

		// Token: 0x0400D4CC RID: 54476
		private CanvasGroup canvasGroup_0;

		// Token: 0x0400D4CD RID: 54477
		private EShadingType eshadingType_0;
	}
}
