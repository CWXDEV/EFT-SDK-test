using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.GlobalEvents
{
	// Token: 0x02002635 RID: 9781
	public abstract class BaseEventFilter : MonoBehaviour
	{
		// Token: 0x140002C1 RID: 705
		// (add) Token: 0x0600C235 RID: 49717 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600C236 RID: 49718 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<BaseEventFilter, GClass2885> OnFilterPassed
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x0600C237 RID: 49719 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600C238 RID: 49720 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			throw null;
		}

		// Token: 0x0600C239 RID: 49721 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(GClass2885 invokedEvent)
		{
			throw null;
		}

		// Token: 0x0600C23A RID: 49722
		protected abstract bool IsFilterPassed(GClass2885 eventToFilter);

		// Token: 0x0400C400 RID: 50176
		[CompilerGenerated]
		private Action<BaseEventFilter, GClass2885> action_0;
	}
}
