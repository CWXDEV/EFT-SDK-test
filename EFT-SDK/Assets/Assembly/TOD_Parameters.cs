using System;
using System.Runtime.CompilerServices;

// Token: 0x020000AD RID: 173
[Serializable]
public class TOD_Parameters
{
	// Token: 0x06000369 RID: 873 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ToSky(TOD_Sky sky)
	{
		throw null;
	}

	// Token: 0x040003AE RID: 942
	public TOD_CycleParameters Cycle;

	// Token: 0x040003AF RID: 943
	public TOD_WorldParameters World;

	// Token: 0x040003B0 RID: 944
	public TOD_AtmosphereParameters Atmosphere;

	// Token: 0x040003B1 RID: 945
	public TOD_DayParameters Day;

	// Token: 0x040003B2 RID: 946
	public TOD_NightParameters Night;

	// Token: 0x040003B3 RID: 947
	public TOD_SunParameters Sun;

	// Token: 0x040003B4 RID: 948
	public TOD_MoonParameters Moon;

	// Token: 0x040003B5 RID: 949
	public TOD_LightParameters Light;

	// Token: 0x040003B6 RID: 950
	public TOD_StarParameters Stars;

	// Token: 0x040003B7 RID: 951
	public TOD_CloudParameters Clouds;

	// Token: 0x040003B8 RID: 952
	public TOD_FogParameters Fog;

	// Token: 0x040003B9 RID: 953
	public TOD_AmbientParameters Ambient;

	// Token: 0x040003BA RID: 954
	public TOD_ReflectionParameters Reflection;
}
