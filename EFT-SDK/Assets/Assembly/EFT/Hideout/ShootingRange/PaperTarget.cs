using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.Hideout.ShootingRange
{
	// Token: 0x02001C66 RID: 7270
	public class PaperTarget : MonoBehaviour
	{
		// Token: 0x140001C2 RID: 450
		// (add) Token: 0x060097CD RID: 38861 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060097CE RID: 38862 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<TargetColliderType, int> OnHitTarget
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

		// Token: 0x060097CF RID: 38863 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void OnEnable()
		{
			throw null;
		}

		// Token: 0x060097D0 RID: 38864 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void OnDisable()
		{
			throw null;
		}

		// Token: 0x060097D1 RID: 38865 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(TargetColliderType targetColliderType, int segmentTarget)
		{
			throw null;
		}

		// Token: 0x060097D2 RID: 38866 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Replace()
		{
			throw null;
		}

		// Token: 0x04009F49 RID: 40777
		[SerializeField]
		private DecalSystem _decal;

		// Token: 0x04009F4A RID: 40778
		[SerializeField]
		private HideoutTargetBallisticCollider[] _colliders;

		// Token: 0x04009F4B RID: 40779
		[CompilerGenerated]
		private Action<TargetColliderType, int> action_0;
	}
}
