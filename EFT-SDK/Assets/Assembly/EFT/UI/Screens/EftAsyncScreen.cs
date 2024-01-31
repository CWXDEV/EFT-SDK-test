using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace EFT.UI.Screens
{
	// Token: 0x02002CFD RID: 11517
	public abstract class EftAsyncScreen<TController, TScreen> : EftScreen<TController, TScreen> where TController : GClass3156<TController, TScreen> where TScreen : EftAsyncScreen<TController, TScreen>
	{
		// Token: 0x0600E26C RID: 57964 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Show(TController controller)
		{
			throw null;
		}

		// Token: 0x0600E26D RID: 57965
		public abstract Task ShowAsync(TController controller);
	}
}
