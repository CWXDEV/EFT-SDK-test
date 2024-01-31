using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using EFT.UI;
using UnityEngine;

namespace EFT.Hideout
{
	// Token: 0x02001BF4 RID: 7156
	public class QTEController : UIElement
	{
		// Token: 0x140001C0 RID: 448
		// (add) Token: 0x06009651 RID: 38481 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06009652 RID: 38482 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<bool, GClass1934> OnSingleQteFinished
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

		// Token: 0x06009653 RID: 38483 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private QTEAction method_0(QuickTimeEvent quickTimeEvent)
		{
			throw null;
		}

		// Token: 0x06009654 RID: 38484 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task<bool> method_1(QuickTimeEvent quickTimeEvent)
		{
			throw null;
		}

		// Token: 0x06009655 RID: 38485 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<GClass1934> StartQteBySequence(IEnumerable<QuickTimeEvent> qteDatas)
		{
			throw null;
		}

		// Token: 0x06009656 RID: 38486 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Stop()
		{
			throw null;
		}

		// Token: 0x04009D11 RID: 40209
		[SerializeField]
		private QteTemplate[] _qteTemplates;

		// Token: 0x04009D12 RID: 40210
		[SerializeField]
		private bool _isLoop;

		// Token: 0x04009D13 RID: 40211
		private IEnumerable<QuickTimeEvent> ienumerable_0;

		// Token: 0x04009D14 RID: 40212
		private readonly GClass763 gclass763_0;

		// Token: 0x04009D15 RID: 40213
		private readonly List<GameObject> list_0;

		// Token: 0x04009D16 RID: 40214
		private GClass1934 gclass1934_0;

		// Token: 0x04009D17 RID: 40215
		private bool bool_0;

		// Token: 0x04009D18 RID: 40216
		[CompilerGenerated]
		private Action<bool, GClass1934> action_0;

		// Token: 0x02001BF5 RID: 7157
		[CompilerGenerated]
		private sealed class Class1687
		{
			// Token: 0x06009657 RID: 38487 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(QteTemplate q)
			{
				throw null;
			}

			// Token: 0x04009D19 RID: 40217
			public QuickTimeEvent quickTimeEvent;
		}

		// Token: 0x02001BF7 RID: 7159
		[CompilerGenerated]
		private sealed class Class1688
		{
			// Token: 0x0600965A RID: 38490 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0()
			{
				throw null;
			}

			// Token: 0x04009D22 RID: 40226
			public CancellationToken cancellationToken;
		}

		// Token: 0x02001BF9 RID: 7161
		[CompilerGenerated]
		[Serializable]
		private sealed class Class1689
		{
			// Token: 0x0600965D RID: 38493 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(GameObject spawnedQte)
			{
				throw null;
			}

			// Token: 0x04009D2C RID: 40236
			public static readonly QTEController.Class1689 class1689_0;

			// Token: 0x04009D2D RID: 40237
			public static Func<GameObject, bool> func_0;
		}
	}
}
