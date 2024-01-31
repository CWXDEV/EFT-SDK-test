using System;
using System.Runtime.CompilerServices;

namespace EFT.UI.Screens
{
	// Token: 0x02002D12 RID: 11538
	public abstract class BaseScreen<TController, TScreen, TType> : UIScreen where TController : UserInterfaceClass<TType>.GClass3108<TController, TScreen> where TScreen : BaseScreen<TController, TScreen, TType> where TType : struct, Enum
	{
		// Token: 0x170027AE RID: 10158
		// (get) Token: 0x0600E2E0 RID: 58080 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600E2E1 RID: 58081 RVA: 0x00002050 File Offset: 0x00000250
		public bool Destroyed
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x0600E2E2 RID: 58082
		public abstract void Show(TController controller);

		// Token: 0x0600E2E3 RID: 58083 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_2(TController controller)
		{
			throw null;
		}

		// Token: 0x0600E2E4 RID: 58084 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600E2E5 RID: 58085 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnDestroy()
		{
			throw null;
		}

		// Token: 0x0400E7B1 RID: 59313
		protected TController ScreenController;

		// Token: 0x0400E7B2 RID: 59314
		[CompilerGenerated]
		private bool bool_0;
	}
}
