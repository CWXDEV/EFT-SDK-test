using System;
using System.Runtime.CompilerServices;
using System.Threading;
using Comfort.Common;
using EFT.Quests;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002B28 RID: 11048
	public sealed class NotesTaskDescriptionShort : UIElement
	{
		// Token: 0x0600DB03 RID: 56067 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show<TConditional, TController>(TConditional conditional, GInterface313 controller, TController conditionalController, ISession session) where TConditional : GInterface381 where TController : GClass3202<TConditional>
		{
			throw null;
		}

		// Token: 0x0600DB04 RID: 56068 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0<T>(GInterface381 conditional, GClass3202<T> conditionalController, ISession session) where T : GInterface381
		{
			throw null;
		}

		// Token: 0x0600DB05 RID: 56069 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_1(EQuestStatus status)
		{
			throw null;
		}

		// Token: 0x0600DB06 RID: 56070 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(bool show)
		{
			throw null;
		}

		// Token: 0x0600DB07 RID: 56071 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(bool show)
		{
			throw null;
		}

		// Token: 0x0600DB08 RID: 56072 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0400DE6A RID: 56938
		[SerializeField]
		private TextMeshProUGUI _description;

		// Token: 0x0400DE6B RID: 56939
		[SerializeField]
		private GameObject _loader;

		// Token: 0x0400DE6C RID: 56940
		[SerializeField]
		private Image _image;

		// Token: 0x0400DE6D RID: 56941
		[SerializeField]
		private GInterface369 _objectivesView;

		// Token: 0x0400DE6E RID: 56942
		[SerializeField]
		private GameObject _initialsContainer;

		// Token: 0x0400DE6F RID: 56943
		[SerializeField]
		private GameObject _rewardsContainer;

		// Token: 0x0400DE70 RID: 56944
		[SerializeField]
		private GameObject _rewardListPrefab;

		// Token: 0x0400DE71 RID: 56945
		private GInterface381 ginterface381_0;

		// Token: 0x0400DE72 RID: 56946
		private GInterface313 ginterface313_0;

		// Token: 0x02002B29 RID: 11049
		[CompilerGenerated]
		private sealed class Class2598<T> where T : GInterface381
		{
			// Token: 0x0400DE73 RID: 56947
			public NotesTaskDescriptionShort notesTaskDescriptionShort_0;

			// Token: 0x0400DE74 RID: 56948
			public GInterface381 conditional;
		}

		// Token: 0x02002B2A RID: 11050
		[CompilerGenerated]
		private sealed class Class2599<T> where T : GInterface381
		{
			// Token: 0x0600DB09 RID: 56073 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(Result<Texture2D> result)
			{
				throw null;
			}

			// Token: 0x0400DE75 RID: 56949
			public CancellationToken cancellationToken;

			// Token: 0x0400DE76 RID: 56950
			public NotesTaskDescriptionShort.Class2598<T> class2598_0;
		}
	}
}
