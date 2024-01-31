using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x020005D4 RID: 1492
[CreateAssetMenu(fileName = "CutsceneTriggerStartInfoSO", menuName = "ScriptableObjects/CutsceneTriggerStartInfoSO")]
public class CutsceneTriggerStartInfoSO : ScriptableObject
{
	// Token: 0x1700065D RID: 1629
	// (get) Token: 0x0600228A RID: 8842 RVA: 0x00002050 File Offset: 0x00000250
	public static CutsceneTriggerStartInfoSO Instance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600228B RID: 8843 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x0600228C RID: 8844 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public CutsceneTriggerStartInfoSO.StartPlayerValues GetPlayerStartInfo(string sceneName, int cutsceneID)
	{
		throw null;
	}

	// Token: 0x0600228D RID: 8845 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public CutsceneTriggerStartInfoSO.StartPlayerValues GetPlayerStartInfo(int sceneNameHash, int cutsceneID)
	{
		throw null;
	}

	// Token: 0x040021F0 RID: 8688
	private static CutsceneTriggerStartInfoSO cutsceneTriggerStartInfoSO_0;

	// Token: 0x040021F1 RID: 8689
	[SerializeField]
	private List<CutsceneTriggerStartInfoSO.SceneCutscenesInfoRelation> infoByScenes;

	// Token: 0x040021F2 RID: 8690
	private Dictionary<string, Dictionary<int, CutsceneTriggerStartInfoSO.StartPlayerValues>> dictionary_0;

	// Token: 0x040021F3 RID: 8691
	private Dictionary<int, Dictionary<int, CutsceneTriggerStartInfoSO.StartPlayerValues>> dictionary_1;

	// Token: 0x020005D5 RID: 1493
	[Serializable]
	public class SceneCutscenesInfoRelation
	{
		// Token: 0x040021F4 RID: 8692
		public string sceneName;

		// Token: 0x040021F5 RID: 8693
		public List<CutsceneTriggerStartInfoSO.CutsceneIDWithStartValues> cutsceneTriggersStartInfo;
	}

	// Token: 0x020005D6 RID: 1494
	[Serializable]
	public class CutsceneIDWithStartValues
	{
		// Token: 0x040021F6 RID: 8694
		public int cutsceneID;

		// Token: 0x040021F7 RID: 8695
		public CutsceneTriggerStartInfoSO.StartPlayerValues startValues;
	}

	// Token: 0x020005D7 RID: 1495
	[Serializable]
	public class StartPlayerValues
	{
		// Token: 0x040021F8 RID: 8696
		public Vector3 startPosition;

		// Token: 0x040021F9 RID: 8697
		public Vector3 startViewDirection;

		// Token: 0x040021FA RID: 8698
		public float startPlayerPosLevel;

		// Token: 0x040021FB RID: 8699
		public bool needToProneAtStart;

		// Token: 0x040021FC RID: 8700
		public Vector3 cutsceneEndPlayerPos;
	}
}
