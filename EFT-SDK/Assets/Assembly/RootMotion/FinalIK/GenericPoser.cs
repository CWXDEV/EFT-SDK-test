using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x020010E2 RID: 4322
	public class GenericPoser : Poser
	{
		// Token: 0x06005B38 RID: 23352 RVA: 0x00002050 File Offset: 0x00000250
		[ContextMenu("Auto-Mapping")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void AutoMapping()
		{
			throw null;
		}

		// Token: 0x06005B39 RID: 23353 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void StoreDefaultState()
		{
			throw null;
		}

		// Token: 0x06005B3A RID: 23354 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void FixTransforms()
		{
			throw null;
		}

		// Token: 0x06005B3B RID: 23355 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Transform method_0(string tName, Transform[] array)
		{
			throw null;
		}

		// Token: 0x06005B3C RID: 23356 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void LateUpdate()
		{
			throw null;
		}

		// Token: 0x040066B5 RID: 26293
		public GenericPoser.Map[] maps;

		// Token: 0x020010E3 RID: 4323
		[Serializable]
		public class Map
		{
			// Token: 0x06005B3D RID: 23357 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void StoreDefaultState()
			{
				throw null;
			}

			// Token: 0x06005B3E RID: 23358 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void FixTransform()
			{
				throw null;
			}

			// Token: 0x06005B3F RID: 23359 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
				throw null;
			}

			// Token: 0x040066B6 RID: 26294
			public Transform bone;

			// Token: 0x040066B7 RID: 26295
			public Transform target;

			// Token: 0x040066B8 RID: 26296
			private Vector3 defaultLocalPosition;

			// Token: 0x040066B9 RID: 26297
			private Quaternion defaultLocalRotation;
		}
	}
}
