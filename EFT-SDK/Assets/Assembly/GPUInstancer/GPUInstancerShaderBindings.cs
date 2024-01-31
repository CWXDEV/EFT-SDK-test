using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace GPUInstancer
{
	// Token: 0x02000E90 RID: 3728
	public class GPUInstancerShaderBindings : ScriptableObject
	{
		// Token: 0x06004D9F RID: 19871 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual bool HasExtension(string extensionCode)
		{
			throw null;
		}

		// Token: 0x06004DA0 RID: 19872 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void AddExtension(GInterface65 extension)
		{
			throw null;
		}

		// Token: 0x06004DA1 RID: 19873 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual GInterface65 GetExtension(string extensionCode)
		{
			throw null;
		}

		// Token: 0x06004DA2 RID: 19874 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Shader GetInstancedShader(string shaderName, string extensionCode = null)
		{
			throw null;
		}

		// Token: 0x06004DA3 RID: 19875 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Material GetInstancedMaterial(Material originalMaterial, string extensionCode = null)
		{
			throw null;
		}

		// Token: 0x06004DA4 RID: 19876 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void ResetShaderInstances()
		{
			throw null;
		}

		// Token: 0x06004DA5 RID: 19877 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void ClearEmptyShaderInstances()
		{
			throw null;
		}

		// Token: 0x06004DA6 RID: 19878 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void AddShaderInstance(string name, Shader instancedShader, bool isOriginalInstanced = false, string extensionCode = null)
		{
			throw null;
		}

		// Token: 0x06004DA7 RID: 19879 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual bool IsShadersInstancedVersionExists(string shaderName, string extensionCode = null)
		{
			throw null;
		}

		// Token: 0x04005A73 RID: 23155
		public List<ShaderInstance> shaderInstances;

		// Token: 0x04005A74 RID: 23156
		private static readonly List<string> list_0;

		// Token: 0x04005A75 RID: 23157
		private static readonly List<string> list_1;

		// Token: 0x04005A76 RID: 23158
		private static readonly List<string> list_2;

		// Token: 0x04005A77 RID: 23159
		public List<GInterface65> shaderBindingsExtensions;

		// Token: 0x02000E91 RID: 3729
		[CompilerGenerated]
		private sealed class Class739
		{
			// Token: 0x06004DA8 RID: 19880 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(GInterface65 ex)
			{
				throw null;
			}

			// Token: 0x04005A78 RID: 23160
			public string extensionCode;
		}

		// Token: 0x02000E92 RID: 3730
		[CompilerGenerated]
		private sealed class Class740
		{
			// Token: 0x06004DA9 RID: 19881 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(GInterface65 ex)
			{
				throw null;
			}

			// Token: 0x04005A79 RID: 23161
			public GInterface65 extension;
		}
	}
}
