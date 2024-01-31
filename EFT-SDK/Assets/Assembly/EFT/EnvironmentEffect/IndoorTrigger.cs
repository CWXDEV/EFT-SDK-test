using System;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;

namespace EFT.EnvironmentEffect
{
	// Token: 0x020026C3 RID: 9923
	public class IndoorTrigger : MonoBehaviour, EnvironmentManagerBase.GInterface21
	{
		// Token: 0x0600C4A9 RID: 50345 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnValidate()
		{
			throw null;
		}

		// Token: 0x0600C4AA RID: 50346 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600C4AB RID: 50347 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Reinit()
		{
			throw null;
		}

		// Token: 0x0600C4AC RID: 50348 RVA: 0x00002050 File Offset: 0x00000250
		[CanBeNull]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IndoorTrigger Check(Vector3 pos)
		{
			throw null;
		}

		// Token: 0x0600C4AD RID: 50349 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDrawGizmosSelected()
		{
			throw null;
		}

		// Token: 0x0600C4AE RID: 50350 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDrawGizmos()
		{
			throw null;
		}

		// Token: 0x0400C650 RID: 50768
		[SerializeField]
		public bool IsBunker;

		// Token: 0x0400C651 RID: 50769
		[SerializeField]
		public float FadeTime;

		// Token: 0x0400C652 RID: 50770
		[SerializeField]
		public float BunkerDepth;

		// Token: 0x0400C653 RID: 50771
		[SerializeField]
		public float BunkerLowPass;

		// Token: 0x0400C654 RID: 50772
		[Space(15f)]
		[SerializeField]
		public float ExposureSpeed;

		// Token: 0x0400C655 RID: 50773
		[SerializeField]
		public float ExposureOffset;

		// Token: 0x0400C656 RID: 50774
		[SerializeField]
		public float RainVolume;

		// Token: 0x0400C657 RID: 50775
		[SerializeField]
		public Bounds Bounds;

		// Token: 0x0400C658 RID: 50776
		private static int int_0;

		// Token: 0x0400C659 RID: 50777
		public int AreaAutoId;
	}
}
