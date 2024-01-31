using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x02002BA9 RID: 11177
	public sealed class QuestsScreen : UIElement
	{
		// Token: 0x0600DC80 RID: 56448 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(ISession backendSession, GInterface313 controller, AbstractQuestControllerClass questController, TraderClass trader)
		{
			throw null;
		}

		// Token: 0x0600DC81 RID: 56449 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0400E0BF RID: 57535
		[SerializeField]
		private QuestView _questView;

		// Token: 0x0400E0C0 RID: 57536
		[SerializeField]
		private QuestsListView _questsListView;
	}
}
