using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

namespace EFT.Hideout
{
	// Token: 0x02001BDD RID: 7133
	public sealed class HideoutCameraFlashlight : MonoBehaviour
	{
		// Token: 0x17001728 RID: 5928
		// (get) Token: 0x060095D9 RID: 38361 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060095DA RID: 38362 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsActive
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

		// Token: 0x060095DB RID: 38363 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x060095DC RID: 38364 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnEnable()
		{
			throw null;
		}

		// Token: 0x060095DD RID: 38365 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetState(bool active)
		{
			throw null;
		}

		// Token: 0x04009C8C RID: 40076
		[SerializeField]
		private Light _flashlight;

		// Token: 0x04009C8D RID: 40077
		[SerializeField]
		private HideoutCameraFlashlight.TransitionSettings _turnOnTransition;

		// Token: 0x04009C8E RID: 40078
		[SerializeField]
		private HideoutCameraFlashlight.TransitionSettings _turnOffTransition;

		// Token: 0x04009C8F RID: 40079
		[SerializeField]
		private bool _startsActivated;

		// Token: 0x04009C90 RID: 40080
		private bool bool_0;

		// Token: 0x04009C91 RID: 40081
		private float float_0;

		// Token: 0x04009C92 RID: 40082
		[CompilerGenerated]
		private bool bool_1;

		// Token: 0x02001BDE RID: 7134
		[Serializable]
		public struct TransitionSettings
		{
			// Token: 0x04009C93 RID: 40083
			public float TransitionTime;

			// Token: 0x04009C94 RID: 40084
			public Ease TransitionType;
		}
	}
}
