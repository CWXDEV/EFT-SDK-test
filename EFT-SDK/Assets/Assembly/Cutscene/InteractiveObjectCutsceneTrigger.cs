using System;
using System.Runtime.CompilerServices;
using EFT.Interactive;
using UnityEngine;

namespace Cutscene
{
	// Token: 0x02000CAB RID: 3243
	public class InteractiveObjectCutsceneTrigger : BaseCutsceneTrigger
	{
		// Token: 0x060045C8 RID: 17864 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Awake()
		{
			throw null;
		}

		// Token: 0x060045C9 RID: 17865 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(WorldInteractiveObject obj, EDoorState prevState, EDoorState nextState)
		{
			throw null;
		}

		// Token: 0x060045CA RID: 17866 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x0400508E RID: 20622
		[SerializeField]
		private WorldInteractiveObject interactiveObject;

		// Token: 0x0400508F RID: 20623
		[SerializeField]
		private InteractiveObjectCutsceneTrigger.StartCutsceneCondition condition;

		// Token: 0x02000CAC RID: 3244
		[Serializable]
		private class StartCutsceneCondition
		{
			// Token: 0x060045CB RID: 17867 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public bool IsPassingCondition(EDoorState prevState, EDoorState nextState)
			{
				throw null;
			}

			// Token: 0x04005090 RID: 20624
			public EDoorState prevObjectState;

			// Token: 0x04005091 RID: 20625
			public EDoorState nextObjectState;
		}
	}
}
