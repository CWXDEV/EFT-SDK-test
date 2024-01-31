using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020000C0 RID: 192
[ExecuteInEditMode]
[RequireComponent(typeof(TOD_Resources))]
[RequireComponent(typeof(TOD_Components))]
public class TOD_Sky : MonoBehaviour
{
	// Token: 0x17000161 RID: 353
	// (get) Token: 0x060003D0 RID: 976 RVA: 0x00002050 File Offset: 0x00000250
	public static List<TOD_Sky> Instances
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000162 RID: 354
	// (get) Token: 0x060003D1 RID: 977 RVA: 0x00002050 File Offset: 0x00000250
	public static TOD_Sky Instance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000163 RID: 355
	// (get) Token: 0x060003D2 RID: 978 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060003D3 RID: 979 RVA: 0x00002050 File Offset: 0x00000250
	public bool Initialized
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x17000164 RID: 356
	// (get) Token: 0x060003D4 RID: 980 RVA: 0x00002050 File Offset: 0x00000250
	public bool Headless
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000165 RID: 357
	// (get) Token: 0x060003D5 RID: 981 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060003D6 RID: 982 RVA: 0x00002050 File Offset: 0x00000250
	public TOD_Components Components
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x17000166 RID: 358
	// (get) Token: 0x060003D7 RID: 983 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060003D8 RID: 984 RVA: 0x00002050 File Offset: 0x00000250
	public TOD_Resources Resources
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x17000167 RID: 359
	// (get) Token: 0x060003D9 RID: 985 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060003DA RID: 986 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsDay
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x17000168 RID: 360
	// (get) Token: 0x060003DB RID: 987 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060003DC RID: 988 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsNight
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x17000169 RID: 361
	// (get) Token: 0x060003DD RID: 989 RVA: 0x00002050 File Offset: 0x00000250
	public float Radius
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700016A RID: 362
	// (get) Token: 0x060003DE RID: 990 RVA: 0x00002050 File Offset: 0x00000250
	public float Diameter
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700016B RID: 363
	// (get) Token: 0x060003DF RID: 991 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060003E0 RID: 992 RVA: 0x00002050 File Offset: 0x00000250
	public float LerpValue
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x1700016C RID: 364
	// (get) Token: 0x060003E1 RID: 993 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060003E2 RID: 994 RVA: 0x00002050 File Offset: 0x00000250
	public float SunZenith
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x1700016D RID: 365
	// (get) Token: 0x060003E3 RID: 995 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060003E4 RID: 996 RVA: 0x00002050 File Offset: 0x00000250
	public float MoonZenith
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x1700016E RID: 366
	// (get) Token: 0x060003E5 RID: 997 RVA: 0x00002050 File Offset: 0x00000250
	public float LightZenith
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700016F RID: 367
	// (get) Token: 0x060003E6 RID: 998 RVA: 0x00002050 File Offset: 0x00000250
	public float LightIntensity
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000170 RID: 368
	// (get) Token: 0x060003E7 RID: 999 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060003E8 RID: 1000 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3 SunDirection
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x17000171 RID: 369
	// (get) Token: 0x060003E9 RID: 1001 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060003EA RID: 1002 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3 MoonDirection
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x17000172 RID: 370
	// (get) Token: 0x060003EB RID: 1003 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060003EC RID: 1004 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3 LightDirection
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x17000173 RID: 371
	// (get) Token: 0x060003ED RID: 1005 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060003EE RID: 1006 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3 LocalSunDirection
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x17000174 RID: 372
	// (get) Token: 0x060003EF RID: 1007 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060003F0 RID: 1008 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3 LocalMoonDirection
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x17000175 RID: 373
	// (get) Token: 0x060003F1 RID: 1009 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060003F2 RID: 1010 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3 LocalLightDirection
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x17000176 RID: 374
	// (get) Token: 0x060003F3 RID: 1011 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060003F4 RID: 1012 RVA: 0x00002050 File Offset: 0x00000250
	public Color SunLightColor
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x17000177 RID: 375
	// (get) Token: 0x060003F5 RID: 1013 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060003F6 RID: 1014 RVA: 0x00002050 File Offset: 0x00000250
	public Color MoonLightColor
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x17000178 RID: 376
	// (get) Token: 0x060003F7 RID: 1015 RVA: 0x00002050 File Offset: 0x00000250
	public Color LightColor
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000179 RID: 377
	// (get) Token: 0x060003F8 RID: 1016 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060003F9 RID: 1017 RVA: 0x00002050 File Offset: 0x00000250
	public Color SunRayColor
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x1700017A RID: 378
	// (get) Token: 0x060003FA RID: 1018 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060003FB RID: 1019 RVA: 0x00002050 File Offset: 0x00000250
	public Color MoonRayColor
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x1700017B RID: 379
	// (get) Token: 0x060003FC RID: 1020 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060003FD RID: 1021 RVA: 0x00002050 File Offset: 0x00000250
	public Color RayColor
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x1700017C RID: 380
	// (get) Token: 0x060003FE RID: 1022 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060003FF RID: 1023 RVA: 0x00002050 File Offset: 0x00000250
	public Color SunSkyColor
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x1700017D RID: 381
	// (get) Token: 0x06000400 RID: 1024 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000401 RID: 1025 RVA: 0x00002050 File Offset: 0x00000250
	public Color MoonSkyColor
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x1700017E RID: 382
	// (get) Token: 0x06000402 RID: 1026 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000403 RID: 1027 RVA: 0x00002050 File Offset: 0x00000250
	public Color SunMeshColor
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x1700017F RID: 383
	// (get) Token: 0x06000404 RID: 1028 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000405 RID: 1029 RVA: 0x00002050 File Offset: 0x00000250
	public Color MoonMeshColor
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x17000180 RID: 384
	// (get) Token: 0x06000406 RID: 1030 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000407 RID: 1031 RVA: 0x00002050 File Offset: 0x00000250
	public Color CloudColor
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x17000181 RID: 385
	// (get) Token: 0x06000408 RID: 1032 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000409 RID: 1033 RVA: 0x00002050 File Offset: 0x00000250
	public Color GroundColor
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x17000182 RID: 386
	// (get) Token: 0x0600040A RID: 1034 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600040B RID: 1035 RVA: 0x00002050 File Offset: 0x00000250
	public Color AmbientColor
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x17000183 RID: 387
	// (get) Token: 0x0600040C RID: 1036 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600040D RID: 1037 RVA: 0x00002050 File Offset: 0x00000250
	public Color MoonHaloColor
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x17000184 RID: 388
	// (get) Token: 0x0600040E RID: 1038 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600040F RID: 1039 RVA: 0x00002050 File Offset: 0x00000250
	public ReflectionProbe Probe
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x06000410 RID: 1040 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector3 OrbitalToUnity(float radius, float theta, float phi)
	{
		throw null;
	}

	// Token: 0x06000411 RID: 1041 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector3 OrbitalToLocal(float theta, float phi)
	{
		throw null;
	}

	// Token: 0x06000412 RID: 1042 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Color SampleAtmosphere(Vector3 direction, bool directLight = true)
	{
		throw null;
	}

	// Token: 0x06000413 RID: 1043 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Color SampleAtmosphereRaw(Vector3 direction, bool directLight = true)
	{
		throw null;
	}

	// Token: 0x06000414 RID: 1044 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public SphericalHarmonicsL2 RenderToSphericalHarmonics()
	{
		throw null;
	}

	// Token: 0x06000415 RID: 1045 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RenderToCubemap(RenderTexture targetTexture = null)
	{
		throw null;
	}

	// Token: 0x06000416 RID: 1046 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Color SampleFogColor(bool directLight = true)
	{
		throw null;
	}

	// Token: 0x06000417 RID: 1047 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Color SampleSkyColor()
	{
		throw null;
	}

	// Token: 0x06000418 RID: 1048 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Color SampleEquatorColor()
	{
		throw null;
	}

	// Token: 0x06000419 RID: 1049 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateFog()
	{
		throw null;
	}

	// Token: 0x0600041A RID: 1050 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateAmbient()
	{
		throw null;
	}

	// Token: 0x0600041B RID: 1051 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateReflection()
	{
		throw null;
	}

	// Token: 0x0600041C RID: 1052 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LoadParameters(string xml)
	{
		throw null;
	}

	// Token: 0x0600041D RID: 1053 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x0600041E RID: 1054 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1()
	{
		throw null;
	}

	// Token: 0x0600041F RID: 1055 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2()
	{
		throw null;
	}

	// Token: 0x06000420 RID: 1056 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3()
	{
		throw null;
	}

	// Token: 0x06000421 RID: 1057 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4(Material material)
	{
		throw null;
	}

	// Token: 0x06000422 RID: 1058 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_5(Material material)
	{
		throw null;
	}

	// Token: 0x06000423 RID: 1059 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_6(Material material)
	{
		throw null;
	}

	// Token: 0x06000424 RID: 1060 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_7(Material material)
	{
		throw null;
	}

	// Token: 0x06000425 RID: 1061 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private float method_8(float inCos)
	{
		throw null;
	}

	// Token: 0x06000426 RID: 1062 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private float method_9(float eyeCos, float eyeCos2)
	{
		throw null;
	}

	// Token: 0x06000427 RID: 1063 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private float method_10(float eyeCos2)
	{
		throw null;
	}

	// Token: 0x06000428 RID: 1064 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Color method_11(Vector3 dir)
	{
		throw null;
	}

	// Token: 0x06000429 RID: 1065 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Color method_12(Vector3 dir)
	{
		throw null;
	}

	// Token: 0x0600042A RID: 1066 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Color method_13(Color color)
	{
		throw null;
	}

	// Token: 0x0600042B RID: 1067 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Color method_14(Color color)
	{
		throw null;
	}

	// Token: 0x0600042C RID: 1068 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Color method_15(Color color)
	{
		throw null;
	}

	// Token: 0x0600042D RID: 1069 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Color method_16(Vector3 dir, bool directLight = true)
	{
		throw null;
	}

	// Token: 0x0600042E RID: 1070 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void OnEnable()
	{
		throw null;
	}

	// Token: 0x0600042F RID: 1071 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void OnDisable()
	{
		throw null;
	}

	// Token: 0x06000430 RID: 1072 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void Start()
	{
		throw null;
	}

	// Token: 0x06000431 RID: 1073 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void LateUpdate()
	{
		throw null;
	}

	// Token: 0x06000432 RID: 1074 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_17()
	{
		throw null;
	}

	// Token: 0x06000433 RID: 1075 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector3 LightDirectionExtrapolated(float addTime)
	{
		throw null;
	}

	// Token: 0x06000434 RID: 1076 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_18()
	{
		throw null;
	}

	// Token: 0x04000466 RID: 1126
	private static List<TOD_Sky> list_0;

	// Token: 0x04000467 RID: 1127
	private int int_0;

	// Token: 0x04000468 RID: 1128
	public TOD_ColorSpaceType ColorSpace;

	// Token: 0x04000469 RID: 1129
	public TOD_ColorRangeType ColorRange;

	// Token: 0x0400046A RID: 1130
	public TOD_SkyQualityType SkyQuality;

	// Token: 0x0400046B RID: 1131
	public TOD_CloudQualityType CloudQuality;

	// Token: 0x0400046C RID: 1132
	public TOD_MeshQualityType MeshQuality;

	// Token: 0x0400046D RID: 1133
	public TOD_CycleParameters Cycle;

	// Token: 0x0400046E RID: 1134
	public TOD_WorldParameters World;

	// Token: 0x0400046F RID: 1135
	public TOD_AtmosphereParameters Atmosphere;

	// Token: 0x04000470 RID: 1136
	public TOD_DayParameters Day;

	// Token: 0x04000471 RID: 1137
	public TOD_NightParameters Night;

	// Token: 0x04000472 RID: 1138
	public TOD_SunParameters Sun;

	// Token: 0x04000473 RID: 1139
	public TOD_MoonParameters Moon;

	// Token: 0x04000474 RID: 1140
	public TOD_StarParameters Stars;

	// Token: 0x04000475 RID: 1141
	public TOD_CloudParameters Clouds;

	// Token: 0x04000476 RID: 1142
	public TOD_LightParameters Light;

	// Token: 0x04000477 RID: 1143
	public TOD_FogParameters Fog;

	// Token: 0x04000478 RID: 1144
	public TOD_AmbientParameters Ambient;

	// Token: 0x04000479 RID: 1145
	public TOD_ReflectionParameters Reflection;

	// Token: 0x0400047A RID: 1146
	[CompilerGenerated]
	private bool bool_0;

	// Token: 0x0400047B RID: 1147
	[CompilerGenerated]
	private TOD_Components tod_Components_0;

	// Token: 0x0400047C RID: 1148
	[CompilerGenerated]
	private TOD_Resources tod_Resources_0;

	// Token: 0x0400047D RID: 1149
	[CompilerGenerated]
	private bool bool_1;

	// Token: 0x0400047E RID: 1150
	[CompilerGenerated]
	private bool bool_2;

	// Token: 0x0400047F RID: 1151
	[CompilerGenerated]
	private float float_0;

	// Token: 0x04000480 RID: 1152
	[CompilerGenerated]
	private float float_1;

	// Token: 0x04000481 RID: 1153
	[CompilerGenerated]
	private float float_2;

	// Token: 0x04000482 RID: 1154
	[CompilerGenerated]
	private Vector3 vector3_0;

	// Token: 0x04000483 RID: 1155
	[CompilerGenerated]
	private Vector3 vector3_1;

	// Token: 0x04000484 RID: 1156
	[CompilerGenerated]
	private Vector3 vector3_2;

	// Token: 0x04000485 RID: 1157
	[CompilerGenerated]
	private Vector3 vector3_3;

	// Token: 0x04000486 RID: 1158
	[CompilerGenerated]
	private Vector3 vector3_4;

	// Token: 0x04000487 RID: 1159
	[CompilerGenerated]
	private Vector3 vector3_5;

	// Token: 0x04000488 RID: 1160
	[CompilerGenerated]
	private Color color_0;

	// Token: 0x04000489 RID: 1161
	[CompilerGenerated]
	private Color color_1;

	// Token: 0x0400048A RID: 1162
	[CompilerGenerated]
	private Color color_2;

	// Token: 0x0400048B RID: 1163
	[CompilerGenerated]
	private Color color_3;

	// Token: 0x0400048C RID: 1164
	[CompilerGenerated]
	private Color color_4;

	// Token: 0x0400048D RID: 1165
	[CompilerGenerated]
	private Color color_5;

	// Token: 0x0400048E RID: 1166
	[CompilerGenerated]
	private Color color_6;

	// Token: 0x0400048F RID: 1167
	[CompilerGenerated]
	private Color color_7;

	// Token: 0x04000490 RID: 1168
	[CompilerGenerated]
	private Color color_8;

	// Token: 0x04000491 RID: 1169
	[CompilerGenerated]
	private Color color_9;

	// Token: 0x04000492 RID: 1170
	[CompilerGenerated]
	private Color color_10;

	// Token: 0x04000493 RID: 1171
	[CompilerGenerated]
	private Color color_11;

	// Token: 0x04000494 RID: 1172
	[CompilerGenerated]
	private Color color_12;

	// Token: 0x04000495 RID: 1173
	[CompilerGenerated]
	private ReflectionProbe reflectionProbe_0;

	// Token: 0x04000496 RID: 1174
	private float float_3;

	// Token: 0x04000497 RID: 1175
	private float float_4;

	// Token: 0x04000498 RID: 1176
	private float float_5;

	// Token: 0x04000499 RID: 1177
	private float float_6;

	// Token: 0x0400049A RID: 1178
	private float float_7;

	// Token: 0x0400049B RID: 1179
	private const int int_1 = 2;

	// Token: 0x0400049C RID: 1180
	private Vector3 vector3_6;

	// Token: 0x0400049D RID: 1181
	private Vector4 vector4_0;

	// Token: 0x0400049E RID: 1182
	private Vector4 vector4_1;

	// Token: 0x0400049F RID: 1183
	private Vector4 vector4_2;

	// Token: 0x040004A0 RID: 1184
	private Vector4 vector4_3;

	// Token: 0x040004A1 RID: 1185
	[Tooltip("sLerp debug rotation speed")]
	public float rotationSpeed;

	// Token: 0x040004A2 RID: 1186
	private const float float_8 = 3.1415927f;

	// Token: 0x040004A3 RID: 1187
	private const float float_9 = 6.2831855f;

	// Token: 0x040004A4 RID: 1188
	private float float_10;

	// Token: 0x040004A5 RID: 1189
	private float float_11;

	// Token: 0x040004A6 RID: 1190
	private float float_12;

	// Token: 0x040004A7 RID: 1191
	private float float_13;

	// Token: 0x040004A8 RID: 1192
	private Quaternion quaternion_0;

	// Token: 0x040004A9 RID: 1193
	private Quaternion quaternion_1;
}
