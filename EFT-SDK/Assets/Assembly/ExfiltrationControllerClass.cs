using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;
using EFT.Interactive;
using UnityEngine;
using UnityEngine.Networking;

// Token: 0x0200104C RID: 4172
public sealed class ExfiltrationControllerClass
{
	// Token: 0x140000F8 RID: 248
	// (add) Token: 0x0600570C RID: 22284 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600570D RID: 22285 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<ExfiltrationPoint> StatusChanged
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

	// Token: 0x17000DC2 RID: 3522
	// (get) Token: 0x0600570E RID: 22286 RVA: 0x00002050 File Offset: 0x00000250
	public static ExfiltrationControllerClass Instance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000DC3 RID: 3523
	// (get) Token: 0x0600570F RID: 22287 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06005710 RID: 22288 RVA: 0x00002050 File Offset: 0x00000250
	public ExfiltrationPoint[] ExfiltrationPoints
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

	// Token: 0x17000DC4 RID: 3524
	// (get) Token: 0x06005711 RID: 22289 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06005712 RID: 22290 RVA: 0x00002050 File Offset: 0x00000250
	public ScavExfiltrationPoint[] ScavExfiltrationPoints
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

	// Token: 0x06005713 RID: 22291 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitAllExfiltrationPoints(GClass1222[] settings, bool justLoadSettings = false, string disabledScavExits = "", bool giveAuthority = true)
	{
		throw null;
	}

	// Token: 0x06005714 RID: 22292 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EventDisableAllExitsExceptOne(string exitNameToSave)
	{
		throw null;
	}

	// Token: 0x06005715 RID: 22293 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ExfiltrationPoint[] EligiblePoints(Profile profile)
	{
		throw null;
	}

	// Token: 0x06005716 RID: 22294 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ExfiltrationPoint[] EligiblePoints(string entryPointName)
	{
		throw null;
	}

	// Token: 0x06005717 RID: 22295 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_0(ExfiltrationPoint trigger)
	{
		throw null;
	}

	// Token: 0x06005718 RID: 22296 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void WriteStates(NetworkWriter writer)
	{
		throw null;
	}

	// Token: 0x06005719 RID: 22297 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReadStates(NetworkReader reader)
	{
		throw null;
	}

	// Token: 0x0600571A RID: 22298 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdatePoint(string name, EExfiltrationStatus command, List<string> queuedPlayers)
	{
		throw null;
	}

	// Token: 0x0600571B RID: 22299 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x0600571C RID: 22300 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ScavExfiltrationClaim(Vector3 position, string profileId, int count)
	{
		throw null;
	}

	// Token: 0x0600571D RID: 22301 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetScavExfiltrationMask(string profileId)
	{
		throw null;
	}

	// Token: 0x0600571E RID: 22302 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveProfileIdFromPoints(string profileId)
	{
		throw null;
	}

	// Token: 0x0600571F RID: 22303 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ExfiltrationPoint[] ScavExfiltrationClaim(int mask, string profileId)
	{
		throw null;
	}

	// Token: 0x06005720 RID: 22304 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AssignScavIdToPoint(ScavExfiltrationPoint point, string profileId)
	{
		throw null;
	}

	// Token: 0x06005721 RID: 22305 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LogDebug(string message, params object[] args)
	{
		throw null;
	}

	// Token: 0x06005722 RID: 22306 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LogInfo(string message, params object[] args)
	{
		throw null;
	}

	// Token: 0x06005723 RID: 22307 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LogError(string message, params object[] args)
	{
		throw null;
	}

	// Token: 0x040062E6 RID: 25318
	[CompilerGenerated]
	private Action<ExfiltrationPoint> action_0;

	// Token: 0x040062E7 RID: 25319
	public readonly GClass630 Logger;

	// Token: 0x040062E8 RID: 25320
	[CompilerGenerated]
	private ExfiltrationPoint[] exfiltrationPoint_0;

	// Token: 0x040062E9 RID: 25321
	[CompilerGenerated]
	private ScavExfiltrationPoint[] scavExfiltrationPoint_0;

	// Token: 0x040062EA RID: 25322
	private List<ScavExfiltrationPoint> list_0;

	// Token: 0x040062EB RID: 25323
	private List<ScavExfiltrationPoint> list_1;

	// Token: 0x0200104D RID: 4173
	[CompilerGenerated]
	private sealed class Class802
	{
		// Token: 0x06005724 RID: 22308 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(GClass1222 x)
		{
			throw null;
		}

		// Token: 0x040062EC RID: 25324
		public string exitName;
	}

	// Token: 0x0200104E RID: 4174
	[CompilerGenerated]
	[Serializable]
	private sealed class Class803
	{
		// Token: 0x06005725 RID: 22309 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(ExfiltrationPoint x)
		{
			throw null;
		}

		// Token: 0x06005726 RID: 22310 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_1(ExfiltrationPoint x)
		{
			throw null;
		}

		// Token: 0x06005727 RID: 22311 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_2(ExfiltrationPoint point)
		{
			throw null;
		}

		// Token: 0x06005728 RID: 22312 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_3(ExfiltrationPoint x)
		{
			throw null;
		}

		// Token: 0x06005729 RID: 22313 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_4(ExfiltrationPoint x)
		{
			throw null;
		}

		// Token: 0x040062ED RID: 25325
		public static readonly ExfiltrationControllerClass.Class803 class803_0;

		// Token: 0x040062EE RID: 25326
		public static Func<ExfiltrationPoint, bool> func_0;

		// Token: 0x040062EF RID: 25327
		public static Func<ExfiltrationPoint, bool> func_1;

		// Token: 0x040062F0 RID: 25328
		public static Func<ExfiltrationPoint, bool> func_2;

		// Token: 0x040062F1 RID: 25329
		public static Func<ExfiltrationPoint, bool> func_3;

		// Token: 0x040062F2 RID: 25330
		public static Func<ExfiltrationPoint, bool> func_4;
	}

	// Token: 0x0200104F RID: 4175
	[CompilerGenerated]
	private sealed class Class804
	{
		// Token: 0x0600572A RID: 22314 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(ExfiltrationPoint x)
		{
			throw null;
		}

		// Token: 0x040062F3 RID: 25331
		public string entryPointName;
	}

	// Token: 0x02001050 RID: 4176
	[CompilerGenerated]
	private sealed class Class805
	{
		// Token: 0x0600572B RID: 22315 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(ExfiltrationPoint x)
		{
			throw null;
		}

		// Token: 0x040062F4 RID: 25332
		public string name;
	}

	// Token: 0x02001051 RID: 4177
	[CompilerGenerated]
	private sealed class Class806
	{
		// Token: 0x0600572C RID: 22316 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(ExfiltrationPoint x)
		{
			throw null;
		}

		// Token: 0x0600572D RID: 22317 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_1(ScavExfiltrationPoint x)
		{
			throw null;
		}

		// Token: 0x040062F5 RID: 25333
		public string name;
	}

	// Token: 0x02001052 RID: 4178
	[CompilerGenerated]
	private sealed class Class807
	{
		// Token: 0x0600572E RID: 22318 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal float method_0(ScavExfiltrationPoint x)
		{
			throw null;
		}

		// Token: 0x040062F6 RID: 25334
		public Vector3 position;
	}
}
