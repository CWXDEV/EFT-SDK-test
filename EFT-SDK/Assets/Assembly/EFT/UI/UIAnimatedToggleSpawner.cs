using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002C56 RID: 11350
	public sealed class UIAnimatedToggleSpawner : UISpawner<AnimatedToggle>
	{
		// Token: 0x17002715 RID: 10005
		// (get) Token: 0x0600DFC1 RID: 57281 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600DFC2 RID: 57282 RVA: 0x00002050 File Offset: 0x00000250
		internal bool Boolean_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17002716 RID: 10006
		// (get) Token: 0x0600DFC3 RID: 57283 RVA: 0x00002050 File Offset: 0x00000250
		public UISpawnableToggle SpawnableToggle
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600DFC4 RID: 57284 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override AnimatedToggle SpawnObject()
		{
			throw null;
		}

		// Token: 0x0600DFC5 RID: 57285 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void SetEllipsis(bool useEllipsis)
		{
			throw null;
		}

		// Token: 0x0600DFC6 RID: 57286 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ToggleSilently(bool show)
		{
			throw null;
		}

		// Token: 0x0600DFC7 RID: 57287 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override void vmethod_0(string caption, int size)
		{
			throw null;
		}

		// Token: 0x0600DFC8 RID: 57288 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetActive(bool active)
		{
			throw null;
		}

		// Token: 0x0400E46A RID: 58474
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0400E46B RID: 58475
		[SerializeField]
		private ToggleGroup _toggleGroup;

		// Token: 0x0400E46C RID: 58476
		[SerializeField]
		private bool _unavailable;

		// Token: 0x0400E46D RID: 58477
		private UISpawnableToggle uispawnableToggle_0;
	}
}
