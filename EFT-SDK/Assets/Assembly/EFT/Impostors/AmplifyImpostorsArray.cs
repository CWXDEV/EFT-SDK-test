using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Sirenix.OdinInspector;
using Sirenix.Serialization;
using UnityEngine;

namespace EFT.Impostors
{
	// Token: 0x02001DB1 RID: 7601
	[CreateAssetMenu(fileName = "ImpostorsArray", order = 86)]
	public sealed class AmplifyImpostorsArray : SerializedScriptableObject
	{
		// Token: 0x140001EA RID: 490
		// (add) Token: 0x06009CA5 RID: 40101 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06009CA6 RID: 40102 RVA: 0x00002050 File Offset: 0x00000250
		public event Action UnregisterEvent
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

		// Token: 0x140001EB RID: 491
		// (add) Token: 0x06009CA7 RID: 40103 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06009CA8 RID: 40104 RVA: 0x00002050 File Offset: 0x00000250
		public event Action RegisterEvent
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

		// Token: 0x17001895 RID: 6293
		// (get) Token: 0x06009CA9 RID: 40105 RVA: 0x00002050 File Offset: 0x00000250
		public int Length
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001896 RID: 6294
		// (get) Token: 0x06009CAA RID: 40106 RVA: 0x00002050 File Offset: 0x00000250
		public Mesh Mesh
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001897 RID: 6295
		// (get) Token: 0x06009CAB RID: 40107 RVA: 0x00002050 File Offset: 0x00000250
		public Material ArrayMaterial
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001898 RID: 6296
		// (get) Token: 0x06009CAC RID: 40108 RVA: 0x00002050 File Offset: 0x00000250
		public ImpostorVertex[] Vertices
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001899 RID: 6297
		// (get) Token: 0x06009CAD RID: 40109 RVA: 0x00002050 File Offset: 0x00000250
		public ImpostorPropBlock[] ImpostorPropBlocks
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700189A RID: 6298
		// (get) Token: 0x06009CAE RID: 40110 RVA: 0x00002050 File Offset: 0x00000250
		public ImpostorBounds[] Bounds
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06009CAF RID: 40111 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static ResourceKey[] smethod_0(IReadOnlyCollection<ResourceKey> keys, IReadOnlyList<int> ids)
		{
			throw null;
		}

		// Token: 0x06009CB0 RID: 40112 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static Task<ValueTuple<Texture[], DependencyGraph<IEasyBundle>.GClass3388>> smethod_1(IReadOnlyCollection<ResourceKey> keys, IReadOnlyList<int> ids)
		{
			throw null;
		}

		// Token: 0x06009CB1 RID: 40113 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static Task<ValueTuple<Texture2DArray, Texture2DArray, DependencyGraph<IEasyBundle>.GClass3388>> smethod_2(ResourceKey albedoKey, ResourceKey normalsKey)
		{
			throw null;
		}

		// Token: 0x06009CB2 RID: 40114 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static Texture2DArray smethod_3(IReadOnlyList<Texture> textures, string name)
		{
			throw null;
		}

		// Token: 0x06009CB3 RID: 40115 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Material method_0(Texture albedoArray = null, Texture normalsArray = null, Material template = null)
		{
			throw null;
		}

		// Token: 0x06009CB4 RID: 40116 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static ResourceKey[] smethod_4(IReadOnlyList<ResourceKey> keys)
		{
			throw null;
		}

		// Token: 0x06009CB5 RID: 40117 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static ValueTuple<ResourceKey, ResourceKey> smethod_5(ResourceKey albedo, ResourceKey normals)
		{
			throw null;
		}

		// Token: 0x06009CB6 RID: 40118 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Task<ValueTuple<Material, Texture2DArray, Texture2DArray, DependencyGraph<IEasyBundle>.GClass3388>> method_1(IReadOnlyList<int> ids)
		{
			throw null;
		}

		// Token: 0x06009CB7 RID: 40119 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Task<ValueTuple<Material, Texture2DArray, Texture2DArray, DependencyGraph<IEasyBundle>.GClass3388>> method_2()
		{
			throw null;
		}

		// Token: 0x06009CB8 RID: 40120 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Task<ValueTuple<Material, Texture2DArray, Texture2DArray, DependencyGraph<IEasyBundle>.GClass3388>> method_3()
		{
			throw null;
		}

		// Token: 0x0400A42F RID: 42031
		private static readonly string string_0;

		// Token: 0x0400A430 RID: 42032
		private static readonly Vector3 vector3_0;

		// Token: 0x0400A431 RID: 42033
		[CompilerGenerated]
		private Action action_0;

		// Token: 0x0400A432 RID: 42034
		[CompilerGenerated]
		private Action action_1;

		// Token: 0x0400A433 RID: 42035
		public const int VERTEX_NUMBER = 8;

		// Token: 0x0400A434 RID: 42036
		private const string string_1 = "39addfe8385b88141953ea24c4e80e74";

		// Token: 0x0400A435 RID: 42037
		private const string string_2 = "9e2596aaa367fad40a6a4a54118f6622";

		// Token: 0x0400A436 RID: 42038
		[OdinSerialize]
		[HideInInspector]
		public ImpostorVertex[] _vertices;

		// Token: 0x0400A437 RID: 42039
		[HideInInspector]
		[OdinSerialize]
		public ImpostorPropBlock[] _propBlocks;

		// Token: 0x0400A438 RID: 42040
		[OdinSerialize]
		[HideInInspector]
		public ImpostorBounds[] _bounds;

		// Token: 0x0400A439 RID: 42041
		[HideInInspector]
		[OdinSerialize]
		public Mesh _mesh;

		// Token: 0x0400A43A RID: 42042
		[OdinSerialize]
		[HideInInspector]
		public Material _arrayMaterial;

		// Token: 0x0400A43B RID: 42043
		[SerializeField]
		public Shader Shader;

		// Token: 0x0400A43C RID: 42044
		[SerializeField]
		public ComputeShader CullingShader;

		// Token: 0x0400A43D RID: 42045
		[SerializeField]
		public ResourceKey[] AlbedoKeys;

		// Token: 0x0400A43E RID: 42046
		[SerializeField]
		public ResourceKey[] NormalsKeys;

		// Token: 0x0400A43F RID: 42047
		[SerializeField]
		public ResourceKey Albedo1Key;

		// Token: 0x0400A440 RID: 42048
		[SerializeField]
		public ResourceKey Normals1Key;

		// Token: 0x0400A441 RID: 42049
		[SerializeField]
		public ResourceKey Albedo2Key;

		// Token: 0x0400A442 RID: 42050
		[SerializeField]
		public ResourceKey Normals2Key;

		// Token: 0x02001DB2 RID: 7602
		[CompilerGenerated]
		private sealed class Class1776
		{
			// Token: 0x06009CB9 RID: 40121 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal ResourceKey method_0(ResourceKey key)
			{
				throw null;
			}

			// Token: 0x0400A443 RID: 42051
			public int index;

			// Token: 0x0400A444 RID: 42052
			public bool failed;

			// Token: 0x0400A445 RID: 42053
			public IReadOnlyList<int> ids;
		}

		// Token: 0x02001DB3 RID: 7603
		[CompilerGenerated]
		[Serializable]
		private sealed class Class1777
		{
			// Token: 0x06009CBA RID: 40122 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(ResourceKey key)
			{
				throw null;
			}

			// Token: 0x06009CBB RID: 40123 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_1(ResourceKey key)
			{
				throw null;
			}

			// Token: 0x0400A446 RID: 42054
			public static readonly AmplifyImpostorsArray.Class1777 class1777_0;

			// Token: 0x0400A447 RID: 42055
			public static Func<ResourceKey, bool> func_0;

			// Token: 0x0400A448 RID: 42056
			public static Func<ResourceKey, string> func_1;
		}

		// Token: 0x02001DB4 RID: 7604
		[CompilerGenerated]
		private sealed class Class1778
		{
			// Token: 0x06009CBC RID: 40124 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Texture method_0(ResourceKey key)
			{
				throw null;
			}

			// Token: 0x0400A449 RID: 42057
			public IEasyAssets assets;
		}
	}
}
