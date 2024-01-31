using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Diz.Skinning;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Serialization;

namespace EFT.Visual
{
	// Token: 0x02001A04 RID: 6660
	public class LoddedSkin : MonoBehaviour
	{
		// Token: 0x06008D81 RID: 36225 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(Skeleton skeleton, PlayerBody playerBody)
		{
			throw null;
		}

		// Token: 0x06008D82 RID: 36226 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Skin()
		{
			throw null;
		}

		// Token: 0x06008D83 RID: 36227 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Unskin()
		{
			throw null;
		}

		// Token: 0x06008D84 RID: 36228 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void EnableRenderers(bool on)
		{
			throw null;
		}

		// Token: 0x06008D85 RID: 36229 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IEnumerable<Renderer> GetRenderers()
		{
			throw null;
		}

		// Token: 0x06008D86 RID: 36230 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetShadowCastingMode(ShadowCastingMode shadowCastingMode)
		{
			throw null;
		}

		// Token: 0x06008D87 RID: 36231 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsVisible()
		{
			throw null;
		}

		// Token: 0x06008D88 RID: 36232 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetLayer(int layer)
		{
			throw null;
		}

		// Token: 0x06008D89 RID: 36233 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetTemperature(float tempCelsio)
		{
			throw null;
		}

		// Token: 0x06008D8A RID: 36234 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x040093E3 RID: 37859
		[SerializeField]
		[FormerlySerializedAs("Skins")]
		private AbstractSkin[] _lods;

		// Token: 0x040093E4 RID: 37860
		private List<HotObject> list_0;

		// Token: 0x02001A05 RID: 6661
		[CompilerGenerated]
		[Serializable]
		private sealed class Class1561
		{
			// Token: 0x06008D8B RID: 36235 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Renderer method_0(AbstractSkin x)
			{
				throw null;
			}

			// Token: 0x040093E5 RID: 37861
			public static readonly LoddedSkin.Class1561 class1561_0;

			// Token: 0x040093E6 RID: 37862
			public static Func<AbstractSkin, Renderer> func_0;
		}
	}
}
