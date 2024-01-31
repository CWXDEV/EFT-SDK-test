using System;
using System.Collections.Generic;
using UnityEngine;

namespace WindowsManagerUtilities
{
	// Token: 0x02000C14 RID: 3092
	[Serializable]
	internal class SceneDataContainer
	{
		// Token: 0x04004CD8 RID: 19672
		[SerializeField]
		public List<int> _verticesInstances;

		// Token: 0x04004CD9 RID: 19673
		[SerializeField]
		public List<int> _verticesLocalOffsets;

		// Token: 0x04004CDA RID: 19674
		[SerializeField]
		public List<MeshOffsets> _meshesOffsetsList;

		// Token: 0x04004CDB RID: 19675
		[SerializeField]
		public List<int> _meshesVerticesCount;

		// Token: 0x04004CDC RID: 19676
		[SerializeField]
		public List<int> _instanceIdToStartVertexId;
	}
}
