using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Diz.Skinning;
using UnityEngine;

namespace EFT.Visual
{
	// Token: 0x020019F8 RID: 6648
	public sealed class ArmBandView : Dress
	{
		// Token: 0x06008D57 RID: 36183 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Init(PlayerBody playerBody)
		{
			throw null;
		}

		// Token: 0x06008D58 RID: 36184 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetBodyHandler(string bodyCustomizationId)
		{
			throw null;
		}

		// Token: 0x06008D59 RID: 36185 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnSkin(Transform playerTransform, Transform meshTransform)
		{
			throw null;
		}

		// Token: 0x06008D5A RID: 36186 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Unskin()
		{
			throw null;
		}

		// Token: 0x06008D5B RID: 36187 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override IEnumerable<Renderer> GetRenderers()
		{
			throw null;
		}

		// Token: 0x040093B9 RID: 37817
		[SerializeField]
		private ArmBandView.MeshCustomizationIdPair[] _customizationIdPair;

		// Token: 0x040093BA RID: 37818
		private Dictionary<string, Mesh[]> dictionary_0;

		// Token: 0x040093BB RID: 37819
		[SerializeField]
		private Skin[] _main;

		// Token: 0x020019F9 RID: 6649
		[Serializable]
		private sealed class MeshCustomizationIdPair
		{
			// Token: 0x040093BC RID: 37820
			public string CustomizationId;

			// Token: 0x040093BD RID: 37821
			public Mesh[] Meshes;
		}

		// Token: 0x020019FA RID: 6650
		[CompilerGenerated]
		[Serializable]
		private sealed class Class1559
		{
			// Token: 0x06008D5C RID: 36188 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_0(ArmBandView.MeshCustomizationIdPair p)
			{
				throw null;
			}

			// Token: 0x06008D5D RID: 36189 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Mesh[] method_1(ArmBandView.MeshCustomizationIdPair p)
			{
				throw null;
			}

			// Token: 0x040093BE RID: 37822
			public static readonly ArmBandView.Class1559 class1559_0;

			// Token: 0x040093BF RID: 37823
			public static Func<ArmBandView.MeshCustomizationIdPair, string> func_0;

			// Token: 0x040093C0 RID: 37824
			public static Func<ArmBandView.MeshCustomizationIdPair, Mesh[]> func_1;
		}
	}
}
