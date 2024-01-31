using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002C82 RID: 11394
	public abstract class BaseUiWindow : UIElement
	{
		// Token: 0x1700272A RID: 10026
		// (get) Token: 0x0600E075 RID: 57461 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsActive
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600E076 RID: 57462 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void Awake()
		{
			throw null;
		}

		// Token: 0x0400E52A RID: 58666
		[SerializeField]
		private GameObject _captionPanel;

		// Token: 0x0400E52B RID: 58667
		[SerializeField]
		private Button _closeButton;
	}
}
