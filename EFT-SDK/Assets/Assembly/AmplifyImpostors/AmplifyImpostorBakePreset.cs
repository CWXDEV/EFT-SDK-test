using System;
using System.Collections.Generic;
using UnityEngine;

namespace AmplifyImpostors
{
	// Token: 0x020031BF RID: 12735
	[CreateAssetMenu(fileName = "New Bake Preset", order = 86)]
	public class AmplifyImpostorBakePreset : ScriptableObject
	{
		// Token: 0x0400FF83 RID: 65411
		[SerializeField]
		public Shader BakeShader;

		// Token: 0x0400FF84 RID: 65412
		[SerializeField]
		public Shader RuntimeShader;

		// Token: 0x0400FF85 RID: 65413
		[SerializeField]
		public PresetPipeline Pipeline;

		// Token: 0x0400FF86 RID: 65414
		[SerializeField]
		public int AlphaIndex;

		// Token: 0x0400FF87 RID: 65415
		[SerializeField]
		public List<TextureOutput> Output;
	}
}
