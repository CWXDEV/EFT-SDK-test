using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cutscene;
using EFT;
using EFT.CameraControl;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

// Token: 0x02000CA9 RID: 3241
public class GClass919
{
	// Token: 0x17000B1B RID: 2843
	// (get) Token: 0x060045BD RID: 17853 RVA: 0x00002050 File Offset: 0x00000250
	public static GClass919 Instance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060045BE RID: 17854 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void smethod_0()
	{
		throw null;
	}

	// Token: 0x060045BF RID: 17855 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x060045C0 RID: 17856 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(PlayerCameraController playerCameraController, Camera camera)
	{
		throw null;
	}

	// Token: 0x060045C1 RID: 17857 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddActiveCutsceneTrigger(BaseCutsceneTrigger trigger)
	{
		throw null;
	}

	// Token: 0x060045C2 RID: 17858 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2(BaseCutsceneTrigger causedTrigger, Player player)
	{
		throw null;
	}

	// Token: 0x060045C3 RID: 17859 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_3(BaseCutsceneTrigger causedTrigger, Player player, CancellationToken cToken)
	{
		throw null;
	}

	// Token: 0x060045C4 RID: 17860 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4(PlayableDirector director)
	{
		throw null;
	}

	// Token: 0x060045C5 RID: 17861 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CutsceneTriggerStartInfoSO.StartPlayerValues CalculateMyPlayerInfoOnStartCutscene(Player player)
	{
		throw null;
	}

	// Token: 0x0400507C RID: 20604
	private static GClass919 gclass919_0;

	// Token: 0x0400507D RID: 20605
	public Dictionary<int, BaseCutsceneTrigger> cutscenesTriggers;

	// Token: 0x0400507E RID: 20606
	private CancellationTokenSource cancellationTokenSource_0;

	// Token: 0x0400507F RID: 20607
	private PlayerCameraController playerCameraController_0;

	// Token: 0x04005080 RID: 20608
	private Player player_0;

	// Token: 0x04005081 RID: 20609
	private PlayableDirector playableDirector_0;

	// Token: 0x04005082 RID: 20610
	private BaseCutsceneTrigger baseCutsceneTrigger_0;

	// Token: 0x04005083 RID: 20611
	private Scene scene_0;
}
