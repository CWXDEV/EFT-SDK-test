using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace EFT.Interactive
{
	// Token: 0x0200275C RID: 10076
	public class DoorSwitch : Door
	{
		// Token: 0x0600C9DB RID: 51675 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override IEnumerator SmoothDoorOpenCoroutine(EDoorState state, bool isLocalInteraction, float speed = 1f)
		{
			throw null;
		}

		// Token: 0x170023D1 RID: 9169
		// (get) Token: 0x0600C9DC RID: 51676 RVA: 0x00002050 File Offset: 0x00000250
		public bool HasAuthority
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600C9DD RID: 51677 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[DebuggerHidden]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_7(EDoorState state, bool isLocalInteraction, float speed)
		{
			throw null;
		}

		// Token: 0x0400C9D1 RID: 51665
		public Switch SwitchToTrigger;
	}
}
