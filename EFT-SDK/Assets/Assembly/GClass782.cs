using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;
using UnityEngine;
using UnityEngine.Profiling;

// Token: 0x0200087D RID: 2173
public class GClass782
{
	// Token: 0x06003125 RID: 12581 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool PatchConfig(string json)
	{
		throw null;
	}

	// Token: 0x04003202 RID: 12802
	public string BackendUrl;

	// Token: 0x04003203 RID: 12803
	public string Version;

	// Token: 0x04003204 RID: 12804
	public string BuildVersion;

	// Token: 0x04003205 RID: 12805
	public ERaidMode RaidMode;

	// Token: 0x04003206 RID: 12806
	public GClass782.PoolsSettings Pools;

	// Token: 0x04003207 RID: 12807
	public int TargetFrameRate;

	// Token: 0x04003208 RID: 12808
	public bool ResetSettings;

	// Token: 0x04003209 RID: 12809
	public bool UseSpiritPlayer;

	// Token: 0x0400320A RID: 12810
	public bool UseSpiritFastAnimator;

	// Token: 0x0400320B RID: 12811
	public bool UseBodyFastAnimator;

	// Token: 0x0400320C RID: 12812
	public bool UseHandsFastAnimator;

	// Token: 0x0400320D RID: 12813
	public bool DevelopMode;

	// Token: 0x0400320E RID: 12814
	public float FixedFrameRate;

	// Token: 0x0400320F RID: 12815
	public int QualitySettingsAsyncUploadTimeSlice;

	// Token: 0x04003210 RID: 12816
	public int QualitySettingsAsyncUploadBufferSize;

	// Token: 0x04003211 RID: 12817
	public bool LogWhenShaderIsCompiled;

	// Token: 0x04003212 RID: 12818
	public bool ShowSpiritImage;

	// Token: 0x04003213 RID: 12819
	public bool UseSpiritHack;

	// Token: 0x04003214 RID: 12820
	public GClass782.ProfilingSettings Profiling;

	// Token: 0x04003215 RID: 12821
	public float MaximumDeltaTime;

	// Token: 0x04003216 RID: 12822
	public int SingleFixedUpdatesMeasurerCountForAVG;

	// Token: 0x04003217 RID: 12823
	public GClass782.CharacterControllerSettings CharacterController;

	// Token: 0x04003218 RID: 12824
	public GClass782.PhysicsSettings Physics;

	// Token: 0x04003219 RID: 12825
	public GClass782.NetworkConfig Network;

	// Token: 0x0400321A RID: 12826
	public float CorpseSyncThreshold;

	// Token: 0x0400321B RID: 12827
	public float DelayToOpenContainer;

	// Token: 0x0400321C RID: 12828
	public bool NoLootForLocalGame;

	// Token: 0x0400321D RID: 12829
	public int IconSaverScaleFactor;

	// Token: 0x0400321E RID: 12830
	public float LoadForceModeMultiplier;

	// Token: 0x0400321F RID: 12831
	public GClass782.LogConfig Log;

	// Token: 0x0200087E RID: 2174
	[Serializable]
	public class PoolsSettings
	{
		// Token: 0x04003220 RID: 12832
		public int AmmoPoolSize;

		// Token: 0x04003221 RID: 12833
		public int WeaponsPoolSize;

		// Token: 0x04003222 RID: 12834
		public int MagsPoolSize;

		// Token: 0x04003223 RID: 12835
		public int ItemsPoolSize;

		// Token: 0x04003224 RID: 12836
		public int PlayersPoolSize;

		// Token: 0x04003225 RID: 12837
		public Dictionary<ResourceType, int> AutoMaintainMinPoolSize;

		// Token: 0x04003226 RID: 12838
		public int FreeFrameTimeWindow;

		// Token: 0x04003227 RID: 12839
		public int AvgTimeBufferSize;

		// Token: 0x04003228 RID: 12840
		public float MaxAvgFrameLoad;

		// Token: 0x04003229 RID: 12841
		public bool ContinuationProfilerEnabled;
	}

	// Token: 0x0200087F RID: 2175
	[Serializable]
	public class ProfilingSettings
	{
		// Token: 0x0400322A RID: 12842
		public bool EnableInGameSpikeAnalyzer;

		// Token: 0x0400322B RID: 12843
		public GClass14.EPauseReason PauseReason;

		// Token: 0x0400322C RID: 12844
		public GClass14.DetectType DetectType;

		// Token: 0x0400322D RID: 12845
		public float TriggerTime;

		// Token: 0x0400322E RID: 12846
		public int FramesCountPerFile;

		// Token: 0x0400322F RID: 12847
		public string WorkingDirectory;

		// Token: 0x04003230 RID: 12848
		public ProfilerArea[] ProfilingAreas;
	}

	// Token: 0x02000880 RID: 2176
	[Serializable]
	public class CharacterControllerSettings
	{
		// Token: 0x04003231 RID: 12849
		public CharacterControllerSpawner.Mode ObservedPlayerMode;

		// Token: 0x04003232 RID: 12850
		public CharacterControllerSpawner.Mode ClientPlayerMode;

		// Token: 0x04003233 RID: 12851
		public CharacterControllerSpawner.Mode BotPlayerMode;
	}

	// Token: 0x02000881 RID: 2177
	[Serializable]
	public class PhysicsSettings
	{
		// Token: 0x04003234 RID: 12852
		public bool OverrideMBPSettings;

		// Token: 0x04003235 RID: 12853
		public Bounds OverrideMBPBounds;

		// Token: 0x04003236 RID: 12854
		public int OverrideMBPSubdivisions;

		// Token: 0x04003237 RID: 12855
		public bool ManualUpdate;

		// Token: 0x04003238 RID: 12856
		public GClass735.GStruct44 CullingForLoot;

		// Token: 0x04003239 RID: 12857
		public GClass735.GStruct44 CullingForGrenade;
	}

	// Token: 0x02000882 RID: 2178
	[Serializable]
	public class NetworkConfig
	{
		// Token: 0x0400323A RID: 12858
		public int FrameDiffForCorruptedTrigger;
	}

	// Token: 0x02000883 RID: 2179
	[Serializable]
	public class LogConfig
	{
		// Token: 0x0400323B RID: 12859
		public bool UnityDebugLogsEnabled;

		// Token: 0x0400323C RID: 12860
		public bool DisableAllLogs;

		// Token: 0x0400323D RID: 12861
		public float UpdateMetricsInterval;

		// Token: 0x0400323E RID: 12862
		public GClass1150.GClass617.GClass1151 FrameMeasurerLoggerConfig;

		// Token: 0x0400323F RID: 12863
		public int FramesCountForAvgForTimeMeasurers;

		// Token: 0x04003240 RID: 12864
		public int FramesCountForAvgForIncrementMeasurers;
	}
}
