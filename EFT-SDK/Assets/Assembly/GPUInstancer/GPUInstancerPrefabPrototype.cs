using System;
using UnityEngine;

namespace GPUInstancer
{
	// Token: 0x02000E83 RID: 3715
	[Serializable]
	public class GPUInstancerPrefabPrototype : GPUInstancerPrototype
	{
		// Token: 0x04005A05 RID: 23045
		public bool enableRuntimeModifications;

		// Token: 0x04005A06 RID: 23046
		public bool startWithRigidBody;

		// Token: 0x04005A07 RID: 23047
		public bool addRemoveInstancesAtRuntime;

		// Token: 0x04005A08 RID: 23048
		public int extraBufferSize;

		// Token: 0x04005A09 RID: 23049
		public bool addRuntimeHandlerScript;

		// Token: 0x04005A0A RID: 23050
		public bool hasRigidBody;

		// Token: 0x04005A0B RID: 23051
		public GPUInstancerPrefabPrototype.RigidbodyData rigidbodyData;

		// Token: 0x04005A0C RID: 23052
		public bool meshRenderersDisabled;

		// Token: 0x04005A0D RID: 23053
		public bool isTransformsSerialized;

		// Token: 0x04005A0E RID: 23054
		public TextAsset serializedTransformData;

		// Token: 0x04005A0F RID: 23055
		public int serializedTransformDataCount;

		// Token: 0x02000E84 RID: 3716
		[Serializable]
		public class RigidbodyData
		{
			// Token: 0x04005A10 RID: 23056
			public bool useGravity;

			// Token: 0x04005A11 RID: 23057
			public float angularDrag;

			// Token: 0x04005A12 RID: 23058
			public float mass;

			// Token: 0x04005A13 RID: 23059
			public RigidbodyConstraints constraints;

			// Token: 0x04005A14 RID: 23060
			public float drag;

			// Token: 0x04005A15 RID: 23061
			public bool isKinematic;

			// Token: 0x04005A16 RID: 23062
			public RigidbodyInterpolation interpolation;
		}
	}
}
