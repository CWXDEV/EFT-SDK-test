using System;
using System.Runtime.CompilerServices;
using EFT.InputSystem;
using JetBrains.Annotations;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x02002C86 RID: 11398
	public abstract class DialogWindow<TContext> : Window<TContext> where TContext : GClass3087, new()
	{
		// Token: 0x1700272F RID: 10031
		// (get) Token: 0x0600E089 RID: 57481 RVA: 0x00002050 File Offset: 0x00000250
		protected virtual bool CloseOnAccept
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002730 RID: 10032
		// (get) Token: 0x0600E08A RID: 57482 RVA: 0x00002050 File Offset: 0x00000250
		protected override bool ShowOnTop
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002731 RID: 10033
		// (get) Token: 0x0600E08B RID: 57483 RVA: 0x00002050 File Offset: 0x00000250
		protected DefaultUIButton AcceptButton
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600E08C RID: 57484 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected TContext Show(string title, Action acceptAction, [CanBeNull] Action cancelAction)
		{
			throw null;
		}

		// Token: 0x0600E08D RID: 57485 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Awake()
		{
			throw null;
		}

		// Token: 0x0600E08E RID: 57486 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void Update()
		{
			throw null;
		}

		// Token: 0x0600E08F RID: 57487 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void SetAcceptActive(bool value)
		{
			throw null;
		}

		// Token: 0x0600E090 RID: 57488 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Accept()
		{
			throw null;
		}

		// Token: 0x0600E091 RID: 57489 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Decline()
		{
			throw null;
		}

		// Token: 0x0600E092 RID: 57490 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void CloseSilent()
		{
			throw null;
		}

		// Token: 0x0600E093 RID: 57491 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Close(ECloseState state)
		{
			throw null;
		}

		// Token: 0x0600E094 RID: 57492 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600E095 RID: 57493 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override InputNode.ETranslateResult TranslateCommand(ECommand command)
		{
			throw null;
		}

		// Token: 0x0600E096 RID: 57494 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void TranslateAxes(ref float[] axes)
		{
			throw null;
		}

		// Token: 0x0600E097 RID: 57495 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override ECursorResult ShouldLockCursor()
		{
			throw null;
		}

		// Token: 0x0400E537 RID: 58679
		private const int int_0 = 24;

		// Token: 0x0400E538 RID: 58680
		private const string string_0 = "OK";

		// Token: 0x0400E539 RID: 58681
		[SerializeField]
		protected DefaultUIButton _acceptButton;

		// Token: 0x0400E53A RID: 58682
		[SerializeField]
		private DefaultUIButton _cancelButton;

		// Token: 0x0400E53B RID: 58683
		private Action action_1;

		// Token: 0x0400E53C RID: 58684
		private string string_1;

		// Token: 0x0400E53D RID: 58685
		private int int_1;

		// Token: 0x0400E53E RID: 58686
		private bool bool_0;
	}
}
