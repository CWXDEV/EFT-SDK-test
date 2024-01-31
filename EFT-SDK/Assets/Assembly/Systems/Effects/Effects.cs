using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DeferredDecals;
using EFT;
using EFT.Ballistics;
using EFT.Particles;
using UnityEngine;

namespace Systems.Effects
{
	// Token: 0x02000C2B RID: 3115
	public class Effects : MonoBehaviour
	{
		// Token: 0x17000AE8 RID: 2792
		// (get) Token: 0x060043EC RID: 17388 RVA: 0x00002050 File Offset: 0x00000250
		public EffectsCommutator EffectsCommutator
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060043ED RID: 17389 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnValidate()
		{
			throw null;
		}

		// Token: 0x060043EE RID: 17390 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x060043EF RID: 17391 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InitDictionaryAndNames()
		{
			throw null;
		}

		// Token: 0x060043F0 RID: 17392 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			throw null;
		}

		// Token: 0x060043F1 RID: 17393 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x060043F2 RID: 17394 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void AddEffectEmit(Effects.Effect effect, Vector3 position, Vector3 normal, BallisticCollider hitCollider, bool withDecal = true, float volume = 1f, bool isKnife = false, bool isHitPointVisible = true, bool isGrenade = false, EPointOfView pov = EPointOfView.ThirdPerson)
		{
			throw null;
		}

		// Token: 0x060043F3 RID: 17395 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PlayerMeshesHit(List<GStruct53> renderers, Vector3 point, Vector3 direction)
		{
			throw null;
		}

		// Token: 0x060043F4 RID: 17396 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void EmitBloodOnEnvironment(Vector3 position, Vector3 normal)
		{
			throw null;
		}

		// Token: 0x060043F5 RID: 17397 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void EmitBleeding(Vector3 position, Vector3 normal)
		{
			throw null;
		}

		// Token: 0x060043F6 RID: 17398 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Emit(MaterialType material, BallisticCollider hitCollider, Vector3 position, Vector3 normal, float volume = 1f, bool isKnife = false, bool isHitPointVisible = true, EPointOfView pov = EPointOfView.ThirdPerson)
		{
			throw null;
		}

		// Token: 0x060043F7 RID: 17399 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PrewarmEmit(MaterialType material, BallisticCollider hitCollider, Vector3 position, Vector3 normal, float volume = 1f, bool isKnife = false, bool isHitPointVisible = true, EPointOfView pov = EPointOfView.ThirdPerson)
		{
			throw null;
		}

		// Token: 0x060043F8 RID: 17400 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TestEmit(int id, Vector3 position, Vector3 normal)
		{
			throw null;
		}

		// Token: 0x060043F9 RID: 17401 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Emit(string ename, Vector3 position, Vector3 normal)
		{
			throw null;
		}

		// Token: 0x060043FA RID: 17402 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GrenadeEmission GetEmissionEffect(string key)
		{
			throw null;
		}

		// Token: 0x060043FB RID: 17403 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DisposeEmissionEffect(GrenadeEmission emission)
		{
			throw null;
		}

		// Token: 0x060043FC RID: 17404 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void EmitSoundOnly(MaterialType material, Vector3 position, EPointOfView pov = EPointOfView.ThirdPerson, float volume = 1f)
		{
			throw null;
		}

		// Token: 0x060043FD RID: 17405 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void EmitGrenade(string ename, Vector3 position, Vector3 normal, float volume = 1f)
		{
			throw null;
		}

		// Token: 0x060043FE RID: 17406 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearEffects(MaterialType materialType)
		{
			throw null;
		}

		// Token: 0x060043FF RID: 17407 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Effects.Effect Get(MaterialType id)
		{
			throw null;
		}

		// Token: 0x06004400 RID: 17408 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearDecal()
		{
			throw null;
		}

		// Token: 0x06004401 RID: 17409 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CacheEffects()
		{
			throw null;
		}

		// Token: 0x04004D44 RID: 19780
		private static readonly int int_0;

		// Token: 0x04004D45 RID: 19781
		public DeferredDecalRenderer DeferredDecals;

		// Token: 0x04004D46 RID: 19782
		public bool UseDecalPainter;

		// Token: 0x04004D47 RID: 19783
		public TextureDecalsPainter TexDecals;

		// Token: 0x04004D48 RID: 19784
		public ParticleSystem MuzzleFumeParticleSystem;

		// Token: 0x04004D49 RID: 19785
		public SimpleSparksRenderer MuzzleSparkParticleSystem;

		// Token: 0x04004D4A RID: 19786
		public ParticleSystem MuzzleHeatParticleSystem;

		// Token: 0x04004D4B RID: 19787
		public ParticleSystem MuzzleHeatHazeParticleSystem;

		// Token: 0x04004D4C RID: 19788
		public SoundBank[] AdditionalSoundEffects;

		// Token: 0x04004D4D RID: 19789
		public Effects.Effect[] EffectsArray;

		// Token: 0x04004D4E RID: 19790
		public Effects.EmissionEffect[] EmissionEffects;

		// Token: 0x04004D4F RID: 19791
		private EffectsCommutator effectsCommutator_0;

		// Token: 0x04004D50 RID: 19792
		private GClass901 gclass901_0;

		// Token: 0x04004D51 RID: 19793
		private Dictionary<MaterialType, Effects.Effect> dictionary_0;

		// Token: 0x04004D52 RID: 19794
		private Dictionary<string, Effects.Effect> dictionary_1;

		// Token: 0x04004D53 RID: 19795
		private List<Effects.GStruct64> list_0;

		// Token: 0x02000C2C RID: 3116
		[Serializable]
		public class EmissionEffect
		{
			// Token: 0x06004402 RID: 17410 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public GrenadeEmission GetEffect()
			{
				throw null;
			}

			// Token: 0x06004403 RID: 17411 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Dispose(GrenadeEmission e)
			{
				throw null;
			}

			// Token: 0x06004404 RID: 17412 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void InstantiateNewEffect()
			{
				throw null;
			}

			// Token: 0x04004D54 RID: 19796
			public string Key;

			// Token: 0x04004D55 RID: 19797
			public GrenadeEmission Instance;

			// Token: 0x04004D56 RID: 19798
			private List<GrenadeEmission> _cache;
		}

		// Token: 0x02000C2D RID: 3117
		[StructLayout(LayoutKind.Auto)]
		public struct GStruct64
		{
			// Token: 0x04004D57 RID: 19799
			public Effects.Effect Effect;

			// Token: 0x04004D58 RID: 19800
			public Vector3 Position;

			// Token: 0x04004D59 RID: 19801
			public Vector3 Normal;

			// Token: 0x04004D5A RID: 19802
			public BallisticCollider HitCollider;

			// Token: 0x04004D5B RID: 19803
			public bool WithDecal;

			// Token: 0x04004D5C RID: 19804
			public float Volume;

			// Token: 0x04004D5D RID: 19805
			public bool IsKnife;

			// Token: 0x04004D5E RID: 19806
			public bool IsHitPointVisible;

			// Token: 0x04004D5F RID: 19807
			public bool IsGrenade;

			// Token: 0x04004D60 RID: 19808
			public EPointOfView Pov;
		}

		// Token: 0x02000C2E RID: 3118
		[Serializable]
		public class Effect
		{
			// Token: 0x06004405 RID: 17413 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Emit(Vector3 position, Vector3 normal, BallisticCollider hitCollider, bool withDecal = true, float volume = 1f, bool isKnife = false, bool isHitPointVisible = true, bool isGrenade = false, EPointOfView pov = EPointOfView.ThirdPerson)
			{
				throw null;
			}

			// Token: 0x06004406 RID: 17414 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Clear()
			{
				throw null;
			}

			// Token: 0x04004D61 RID: 19809
			public string Name;

			// Token: 0x04004D62 RID: 19810
			public MaterialType[] MaterialTypes;

			// Token: 0x04004D63 RID: 19811
			public BasicParticleSystemMediator BasicParticleSystemMediator;

			// Token: 0x04004D64 RID: 19812
			public Effects.Effect.ParticleSys[] Particles;

			// Token: 0x04004D65 RID: 19813
			public SoundBank Sound;

			// Token: 0x04004D66 RID: 19814
			public SoundBank SoundFP;

			// Token: 0x04004D67 RID: 19815
			public DecalSystem Decal;

			// Token: 0x04004D68 RID: 19816
			public bool Flash;

			// Token: 0x04004D69 RID: 19817
			public int FlareID;

			// Token: 0x04004D6A RID: 19818
			public float FlashMaxDist;

			// Token: 0x04004D6B RID: 19819
			public float FlashTime;

			// Token: 0x04004D6C RID: 19820
			public bool Light;

			// Token: 0x04004D6D RID: 19821
			public Color LightColor;

			// Token: 0x04004D6E RID: 19822
			public float LightMaxDist;

			// Token: 0x04004D6F RID: 19823
			public float LightRange;

			// Token: 0x04004D70 RID: 19824
			public float LightIntensity;

			// Token: 0x04004D71 RID: 19825
			public float LightTime;

			// Token: 0x04004D72 RID: 19826
			public float ParticlesShift;

			// Token: 0x04004D73 RID: 19827
			public bool WithShadows;

			// Token: 0x04004D74 RID: 19828
			public bool Wind;

			// Token: 0x04004D75 RID: 19829
			public float WindIntensity;

			// Token: 0x04004D76 RID: 19830
			public float WindRadius;

			// Token: 0x04004D77 RID: 19831
			public float WindTime;

			// Token: 0x04004D78 RID: 19832
			public float WindMaxDist;

			// Token: 0x04004D79 RID: 19833
			public const string CHOKE_IMPACT_KEY = "Impact";

			// Token: 0x04004D7A RID: 19834
			public const string CHOKE_GRENADE_KEY = "Grenade";

			// Token: 0x04004D7B RID: 19835
			public bool UseDeferredDecals;

			// Token: 0x04004D7C RID: 19836
			[HideInInspector]
			public DeferredDecalRenderer DeferredDecals;

			// Token: 0x04004D7D RID: 19837
			public GClass901 LightPool;

			// Token: 0x04004D7E RID: 19838
			private Vector2 _impactsGagRadius;

			// Token: 0x02000C2F RID: 3119
			[Serializable]
			public class ParticleSys
			{
				// Token: 0x06004407 RID: 17415 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void Emit(Vector3 position, Vector3 normal, float distance)
				{
					throw null;
				}

				// Token: 0x04004D7F RID: 19839
				public Emitter Particle;

				// Token: 0x04004D80 RID: 19840
				public Vector2 Distance;

				// Token: 0x04004D81 RID: 19841
				public Effects.Effect.ParticleSys.Type RandomType;

				// Token: 0x04004D82 RID: 19842
				public int MinCount;

				// Token: 0x04004D83 RID: 19843
				public int RandomCountRange;

				// Token: 0x04004D84 RID: 19844
				public bool UseRandomScale;

				// Token: 0x04004D85 RID: 19845
				public Vector3 RandomScale;

				// Token: 0x02000C30 RID: 3120
				public enum Type
				{
					// Token: 0x04004D87 RID: 19847
					Forward,
					// Token: 0x04004D88 RID: 19848
					Cone,
					// Token: 0x04004D89 RID: 19849
					Hemisphere,
					// Token: 0x04004D8A RID: 19850
					Circle,
					// Token: 0x04004D8B RID: 19851
					ConeNormalized,
					// Token: 0x04004D8C RID: 19852
					Cone60
				}
			}
		}

		// Token: 0x02000C31 RID: 3121
		[CompilerGenerated]
		private sealed class Class628
		{
			// Token: 0x04004D8D RID: 19853
			public string key;
		}

		// Token: 0x02000C32 RID: 3122
		[CompilerGenerated]
		private sealed class Class629
		{
			// Token: 0x04004D8E RID: 19854
			public GrenadeEmission emission;
		}
	}
}
