using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace CW2.Animations
{
	// Token: 0x02000C83 RID: 3203
	[Serializable]
	public class SmoothRandom
	{
		// Token: 0x06004546 RID: 17734 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public float GetValue(float deltaTime)
		{
			throw null;
		}

		// Token: 0x04004FAF RID: 20399
		[Range(0f, 5f)]
		[FormerlySerializedAs("Amlitude")]
		public float Amplitude;

		// Token: 0x04004FB0 RID: 20400
		public Vector2 MinMaxDelay;

		// Token: 0x04004FB1 RID: 20401
		[Range(0f, 2f)]
		public float Hardness;

		// Token: 0x04004FB2 RID: 20402
		private float _countDown;

		// Token: 0x04004FB3 RID: 20403
		private float _currentVal;

		// Token: 0x04004FB4 RID: 20404
		private float _increase;
	}
}
