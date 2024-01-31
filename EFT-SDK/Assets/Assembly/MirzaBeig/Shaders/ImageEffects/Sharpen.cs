using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace MirzaBeig.Shaders.ImageEffects
{
	// Token: 0x02000ED1 RID: 3793
	[ExecuteInEditMode]
	[Serializable]
	public class Sharpen : IEBase
	{
		// Token: 0x06004F35 RID: 20277 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x06004F36 RID: 20278 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Start()
		{
			throw null;
		}

		// Token: 0x06004F37 RID: 20279 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x06004F38 RID: 20280 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			throw null;
		}

		// Token: 0x04005BDC RID: 23516
		[Range(-2f, 2f)]
		public float strength;

		// Token: 0x04005BDD RID: 23517
		[Range(0f, 8f)]
		public float edgeMult;

		// Token: 0x04005BDE RID: 23518
		private static readonly int _strength;

		// Token: 0x04005BDF RID: 23519
		private static readonly int _edgeMult;
	}
}
